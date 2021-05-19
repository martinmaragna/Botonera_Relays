using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace System.Windows.Forms
{
    public enum Relay
    {
        Relay_1 = 0,
        Relay_2 = 1,
        Relay_3 = 2,
        Relay_4 = 3
    }

    public class Estado_Boton
    {
        public string Titulo { get; set; }
        public string Imagen { get; set; }
        public Keys Tecla { get; set; }
        public Color Fondo { get; set; }
        public Color Texto { get; set; }

        public Estado_Boton(string TITULO, string IMAGEN, Keys TECLA, Color FONDO, Color TEXTO)
        {
            Titulo = TITULO;
            Imagen = IMAGEN;
            Tecla = TECLA;
            Fondo = FONDO;
            Texto = TEXTO;
        }

        public Estado_Boton(string TITULO, string IMAGEN, Color FONDO, Color TEXTO) : this(TITULO, IMAGEN, Keys.None, FONDO, TEXTO)
        { }

        public Estado_Boton(string TITULO, Color FONDO, Color TEXTO) : this(TITULO, "", Keys.None, FONDO, TEXTO)
        { }

        public Estado_Boton() : this("", "", Keys.None, Color.Empty, Color.Empty)
        { }

        public string Archivo_Imagen()
        {
            return Application.StartupPath + Configuracion.Directorio_Imagenes + @"\" + Imagen;
        }
    }

    public static class Configuracion
    {
        public static bool Modo_Demo = false;
        public static string Titulo_App = "Botonera de Relays v" + Application.ProductVersion.Trim('.', '0');
        public static DataGridViewCellStyle Estilo_Normal = new DataGridViewCellStyle() { BackColor = Color.WhiteSmoke, SelectionBackColor = Color.DimGray, ForeColor = Color.Black, SelectionForeColor = Color.White };
        public static Propiedades_DataGridView DataGridView_Default = new Propiedades_DataGridView(Color.FromArgb(32, 32, 32), Estilo_Normal);
        public static Propiedades_Columnas_Editables Columna_No_Editable = new Propiedades_Columnas_Editables();
        public static string Directorio_Imagenes = @"\Imagenes";
        public static string Filtro_Imagenes = "*.png";
        public static string Extension_Archivo_Dispositivos = "json";
        public static string Archivo_Dispositivos = "Dispositivos." + Extension_Archivo_Dispositivos;
        public static List<Modulo_Dispositivo> Dispositivos = new List<Modulo_Dispositivo> { };
        public static List<Modulo_Dispositivo> Obtener_Dispositivos(string ARCHIVO)
        {
            return JsonSerializer.Deserialize<List<Modulo_Dispositivo>>(File.ReadAllText(ARCHIVO));
        }
        public static void Guardar_Dispositivos(string ARCHIVO, List<Modulo_Dispositivo> DISPOSITIVOS)
        {
            File.WriteAllText(ARCHIVO, JsonSerializer.Serialize(DISPOSITIVOS, new JsonSerializerOptions() { WriteIndented = true }));
        }
        public static string Extension_Archivo_Botones = "json";
        public static string Archivo_Botones = "Botones." + Extension_Archivo_Botones;
        public static List<Modulo_Boton> Obtener_Botones(string ARCHIVO)
        {
            JsonSerializerOptions __OPCIONES = new JsonSerializerOptions() { WriteIndented = true, Converters = { new Color_JsonConverter() } };
            return JsonSerializer.Deserialize<List<Modulo_Boton>>(File.ReadAllText(ARCHIVO), __OPCIONES);
        }
        public static void Guardar_Botones(string ARCHIVO, List<Modulo_Boton> BOTONES)
        {
            JsonSerializerOptions __OPCIONES = new JsonSerializerOptions() { WriteIndented = true, Converters = { new Color_JsonConverter() } };

            File.WriteAllText(ARCHIVO, JsonSerializer.Serialize(BOTONES, __OPCIONES));
        }
    }

    public class Color_JsonConverter : JsonConverter<Color>
    {
        public override Color Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return Color.FromName(reader.GetString());
        }

        public override void Write(Utf8JsonWriter writer, Color value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.Name);
        }
    }

    public static class Mensajes
    {
        public static List<IMensajes> Modulos = new List<IMensajes>();
        public static DialogResult Pregunta_Cerrar_Formulario(object GENERADOR, string TITULO)
        {
            return MENSAJES.Mostrar_Mensaje(Modulos, new Info_Mensaje(MEN_Tipo.Pregunta, 10, "Cerrar {0}", "¿Está seguro que desea cerrar el formulario '{0}'?", Tipo_Mensaje_Formulario.Formulario_Si_no), GENERADOR, TITULO);
        }
        public static DialogResult Pregunta_Cerrar_Formulario_Sin_Guardar(object GENERADOR, string TITULO)
        {
            return MENSAJES.Mostrar_Mensaje(Modulos, new Info_Mensaje(MEN_Tipo.Pregunta, 10, "Cerrar {0}", "¿Está seguro que desea cerrar el formulario '{0}' sin guardar los cambios?", Tipo_Mensaje_Formulario.Formulario_Si_no), GENERADOR, TITULO);
        }
        public static DialogResult Mensaje_Detalle_No_Permitido_Agregar(object GENERADOR, string TITULO, string ELEMENTO)
        {
            return MENSAJES.Mostrar_Mensaje(Modulos, new Info_Mensaje(MEN_Tipo.Detener, 10, "{0}", "No se puede agregar al detalle.{1}", Tipo_Mensaje_Formulario.Formulario_Ok), GENERADOR, TITULO, ELEMENTO);
        }
        public static DialogResult Mensaje_Detalle_No_Permitido_Agregar_Ya_Existe(object GENERADOR, string TITULO, string ELEMENTO)
        {
            return Mensaje_Detalle_No_Permitido_Agregar(GENERADOR, TITULO, Environment.NewLine + ELEMENTO + Environment.NewLine + "Motivo: Ya existe un elemento igual en el detalle.");
        }

    }

    public class Modulo_Dispositivo : IDetallable
    {
        public BackgroundWorker Subproceso = new BackgroundWorker();

        public const int CMD_RELAY_OFF = 0x00;
        public const int CMD_RELAY_ON = 0x01;
        public const int CMD_ERROR = 0x02;
        public const int CMD_VERIFICAR = 0x03;

        public const int CMD_ENVIAR_R1_ON = 0x11;
        public const int CMD_ENVIAR_R1_OFF = 0x10;
        public const int CMD_ENVIAR_R2_ON = 0x21;
        public const int CMD_ENVIAR_R2_OFF = 0x20;
        public const int CMD_ENVIAR_R3_ON = 0x31;
        public const int CMD_ENVIAR_R3_OFF = 0x30;
        public const int CMD_ENVIAR_R4_ON = 0x41;
        public const int CMD_ENVIAR_R4_OFF = 0x40;

        public static byte[] R1_ON = { 0xA0, 0x01, 0x01, 0xA2 };
        public static byte[] R1_OFF = { 0xA0, 0x01, 0x00, 0xA1 };
        public static byte[] R2_ON = { 0xA0, 0x02, 0x01, 0xA3 };
        public static byte[] R2_OFF = { 0xA0, 0x02, 0x00, 0xA2 };
        public static byte[] R3_ON = { 0xA0, 0x03, 0x01, 0xA4 };
        public static byte[] R3_OFF = { 0xA0, 0x03, 0x00, 0xA3 };
        public static byte[] R4_ON = { 0xA0, 0x04, 0x01, 0xA5 };
        public static byte[] R4_OFF = { 0xA0, 0x04, 0x00, 0xA4 };

        public string Nombre { get; set; }

        public int Puerto { get; set; }

        public int Ip1;

        public int Ip2;

        public int Ip3;

        public int Ip4;

        public string Direccion
        {
            get
            {
                return Ip1.ToString() + "." + Ip2.ToString() + "." + Ip3.ToString() + "." + Ip4.ToString();
            }
            set
            {
                string[] __CUADROS = value.Split('.');
                int.TryParse(__CUADROS[0], out Ip1);
                int.TryParse(__CUADROS[1], out Ip2);
                int.TryParse(__CUADROS[2], out Ip3);
                int.TryParse(__CUADROS[3], out Ip4);
            }
        }

        public int Comando = CMD_ERROR;

        //protected Socket Socalo;

        public Modulo_Dispositivo(string NOMBRE, string DIRECCION, int PUERTO)
        {
            Nombre = NOMBRE;
            Direccion = DIRECCION;
            Puerto = PUERTO;
            Subproceso.DoWork += Subproceso_DoWork;
            Subproceso.RunWorkerCompleted += Subproceso_RunWorkerCompleted;
        }

        public Modulo_Dispositivo(string NOMBRE, string DIRECCION) : this(NOMBRE, DIRECCION, 8080)
        {
        }

        public Modulo_Dispositivo() : this("", "192.168.1.1", 8080)
        {
        }

        public override string ToString()
        {
            return Nombre + " (" + Direccion + ")";
        }

        public static byte[] Obtener_Trama(Relay RELAY, bool ESTADO)
        {
            switch (RELAY)
            {
                case Relay.Relay_1:
                    if (ESTADO)
                    {
                        return R1_ON;
                    }
                    else
                    {
                        return R1_OFF;
                    }
                case Relay.Relay_2:
                    if (ESTADO)
                    {
                        return R2_ON;
                    }
                    else
                    {
                        return R2_OFF;
                    }
                case Relay.Relay_3:
                    if (ESTADO)
                    {
                        return R3_ON;
                    }
                    else
                    {
                        return R3_OFF;
                    }
                case Relay.Relay_4:
                    if (ESTADO)
                    {
                        return R4_ON;
                    }
                    else
                    {
                        return R4_OFF;
                    }
            }
            return new byte[] { };
        }

        public static int Establecer_Comando(Relay RELAY, bool ESTADO)
        {
            if (ESTADO)
            {
                switch (RELAY)
                {
                    case Relay.Relay_1:
                        return CMD_ENVIAR_R1_ON;
                    case Relay.Relay_2:
                        return CMD_ENVIAR_R2_ON;
                    case Relay.Relay_3:
                        return CMD_ENVIAR_R3_ON;
                    case Relay.Relay_4:
                        return CMD_ENVIAR_R4_ON;
                }
            }
            else
            {
                switch (RELAY)
                {
                    case Relay.Relay_1:
                        return CMD_ENVIAR_R1_OFF;
                    case Relay.Relay_2:
                        return CMD_ENVIAR_R2_OFF;
                    case Relay.Relay_3:
                        return CMD_ENVIAR_R3_OFF;
                    case Relay.Relay_4:
                        return CMD_ENVIAR_R4_OFF;
                }
            }
            return CMD_ERROR;
        }

        public void Subproceso_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                Socket Socalo = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                Socalo.Connect(Direccion, Puerto);
                switch (Comando)
                {
                    case CMD_VERIFICAR:
                        break;
                    case CMD_ENVIAR_R1_OFF:
                        Socalo.Send(Obtener_Trama(Relay.Relay_1, false));
                        Comando = CMD_RELAY_OFF;
                        break;
                    case CMD_ENVIAR_R1_ON:
                        Socalo.Send(Obtener_Trama(Relay.Relay_1, true));
                        Comando = CMD_RELAY_ON;
                        break;
                    case CMD_ENVIAR_R2_OFF:
                        Socalo.Send(Obtener_Trama(Relay.Relay_2, false));
                        Comando = CMD_RELAY_OFF;
                        break;
                    case CMD_ENVIAR_R2_ON:
                        Socalo.Send(Obtener_Trama(Relay.Relay_2, true));
                        Comando = CMD_RELAY_ON;
                        break;
                    case CMD_ENVIAR_R3_OFF:
                        Socalo.Send(Obtener_Trama(Relay.Relay_3, false));
                        Comando = CMD_RELAY_OFF;
                        break;
                    case CMD_ENVIAR_R3_ON:
                        Socalo.Send(Obtener_Trama(Relay.Relay_3, true));
                        Comando = CMD_RELAY_ON;
                        break;
                    case CMD_ENVIAR_R4_OFF:
                        Socalo.Send(Obtener_Trama(Relay.Relay_4, false));
                        Comando = CMD_RELAY_OFF;
                        break;
                    case CMD_ENVIAR_R4_ON:
                        Socalo.Send(Obtener_Trama(Relay.Relay_4, true));
                        Comando = CMD_RELAY_ON;
                        break;
                }
                Socalo.Close();
                Socalo.Dispose();
            }
            catch (Exception A)
            {
                Comando = CMD_ERROR;
                MessageBox.Show(A.Message);
            }
            e.Result = e.Argument;
        }

        public void Subproceso_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result is Boton_Relay _BOTON)
            {
                _BOTON.Cursor = Cursors.Default;
                switch (Comando)
                {
                    case CMD_ERROR:
                        _BOTON.Estado = false;
                        break;
                    case CMD_RELAY_ON:
                        _BOTON.Estado = true;
                        break;
                    case CMD_RELAY_OFF:
                        _BOTON.Estado = false;
                        break;
                }
                _BOTON.Aplicar_Estado();
            }
        }
        //IDetallable
        public const int Indice_Nombre = 0;
        public const int Indice_Direccion = 1;
        public const int Indice_Puerto = 2;
        public const int Indice_Estado = 3;

        public static void Cargar_DatagridviewColumns(DetalleDataGridView DATAGRIDVIEW, EventHandler<DetalleDataGridViewEventArgs> METODO_AGREGAR, EventHandler<DetalleDataGridViewEventArgs> METODO_MODIFICAR)
        {
            DATAGRIDVIEW.ReadOnly = true;
            DATAGRIDVIEW.MultiSelect = false;
            DATAGRIDVIEW.AllowUserToAddRows = false;
            DATAGRIDVIEW.RowHeadersVisible = false;
            DATAGRIDVIEW.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DATAGRIDVIEW.AllowUserToResizeRows = false;
            DATAGRIDVIEW.Modulos = Mensajes.Modulos;
            DATAGRIDVIEW.Estilo = Configuracion.DataGridView_Default;
            DATAGRIDVIEW.Cargar_Columnas(new DataGridViewColumn[]
            {
                FUNCIONES.Generar_DataGridViewTextBoxColumn("Nombre", new Propiedades_Columnas() { Ancho = 250}, Configuracion.Columna_No_Editable),
                FUNCIONES.Generar_DataGridViewTextBoxColumn("Dirección", new Propiedades_Columnas() { Ancho = 120}, Configuracion.Columna_No_Editable),
                FUNCIONES.Generar_DataGridViewTextBoxColumn("Puerto", new Propiedades_Columnas() {Ancho =  80}, Configuracion.Columna_No_Editable),
                FUNCIONES.Generar_DataGridViewTextBoxColumn("Estado", new Propiedades_Columnas() { Ancho = 130}, Configuracion.Columna_No_Editable)
            });
            DATAGRIDVIEW.Plantilla = new Modulo_Dispositivo("", "192.168.0.0");
            DATAGRIDVIEW.Titulo = "Lista de Dispositivos";
            DATAGRIDVIEW.Todos = "Todos los Dispositivos";
            DATAGRIDVIEW.Doble_Click_Celda_ReadOnly += METODO_MODIFICAR;
            DATAGRIDVIEW.Pre_Agregar_Detalle += METODO_AGREGAR;
            DATAGRIDVIEW.Pre_Modificar_Detalle += METODO_MODIFICAR;
        }
        [JsonIgnore]
        public int Indice_Fila { get; set; }

        public string Obtener_Elemento()
        {
            return "El Dispositivo: " + ToString();
        }

        public bool Permitir_Agregar(DetalleDataGridView DATAGRIDVIEW)
        {
            foreach (Modulo_Dispositivo X in DATAGRIDVIEW.Detalle)
            {
                if (X.Direccion == Direccion || X.Nombre == Nombre)
                {
                    Mensajes.Mensaje_Detalle_No_Permitido_Agregar_Ya_Existe(DATAGRIDVIEW, DATAGRIDVIEW.Titulo, Obtener_Elemento());
                    return false;
                }
            }
            return true;
        }

        public bool Permitir_Modificar(DetalleDataGridView DATAGRIDVIEW)
        {
            //foreach(Modulo_Dispositivo X in DATAGRIDVIEW.Detalle)
            //{
            //    if(X.Direccion == Direccion && X.Indice_Fila != Indice_Fila)
            //    {
            //        return false;
            //    }
            //}
            return true;
        }

        public bool Permitir_Eliminar(DetalleDataGridView DATAGRIDVIEW)
        {
            //foreach (Boton_Relay X in )
            //{
            //    if (X.Direccion == Direccion && X.Indice_Fila == Indice_Fila)
            //    {
            //        return
            //    }
            //}

            return true;
        }

        public int Insertar_Fila(DetalleDataGridView DATAGRIDVIEW)
        {
            return DATAGRIDVIEW.Rows.Add(Nombre, Direccion, Puerto, "");
        }

        public bool Actualizar_Fila(DetalleDataGridView DATAGRIDVIEW)
        {
            bool __CAMBIO_FILA = false;
            __CAMBIO_FILA |= DATAGRIDVIEW.Actualizar_Celda(Indice_Nombre, Indice_Fila, Nombre);
            __CAMBIO_FILA |= DATAGRIDVIEW.Actualizar_Celda(Indice_Direccion, Indice_Fila, Direccion);
            __CAMBIO_FILA |= DATAGRIDVIEW.Actualizar_Celda(Indice_Puerto, Indice_Fila, Puerto);
            __CAMBIO_FILA |= DATAGRIDVIEW.Actualizar_Celda(Indice_Estado, Indice_Fila, "");
            return __CAMBIO_FILA;
        }

        public void Actualizar_Objeto(DetalleDataGridView DATAGRIDVIEW, int INDICE_COLUMNA)
        {

        }

        public bool Validar_Fila()
        {
            return true;
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }

    public class Modulo_Boton
    {
        public string Nombre { get; set; }
        public string Dispositivo { get; set; }
        public Relay Relay { get; set; }
        public Size Tamanio { get; set; }
        public Point Ubicacion { get; set; }
        public Estado_Boton Desactivado { get; set; }
        public Estado_Boton Activado { get; set; }

        public Modulo_Boton(string NOMBRE, string DISPOSITIVO, Relay RELAY, Size TAMANIO, Point UBICACION, Estado_Boton DESACTIVADO, Estado_Boton ACTIVADO)
        {
            Nombre = NOMBRE;
            Dispositivo = DISPOSITIVO;
            Relay = RELAY;
            Tamanio = TAMANIO;
            Ubicacion = UBICACION;
            Desactivado = DESACTIVADO;
            Activado = ACTIVADO;
        }

        public Modulo_Boton() : this("", "", Relay.Relay_1, new Size(100, 100), new Point(0, 0), new Estado_Boton("OFF", Color.Empty, Color.Empty), new Estado_Boton("ON", Color.Empty, Color.Empty)) { }

        public object Clone()
        {
            return new Modulo_Boton(Nombre, Dispositivo, Relay, Tamanio, Ubicacion, Desactivado, Activado);
        }
    }

    public class Boton_Relay : Button_Key
    {
        public static Estado_Boton Desconectado = new Estado_Boton("OFFLINE", Color.Gray, Color.DarkGray);
        public static Estado_Boton Error = new Estado_Boton("ERROR", Color.Maroon, Color.DarkGray);
        public Modulo_Dispositivo Dispositivo = null;
        public Relay Relay = Relay.Relay_1;
        public bool Estado = false;
        public Estado_Boton Desactivado = new Estado_Boton("OFF", Color.Empty, Color.Empty);
        public Estado_Boton Activado = new Estado_Boton("ON", Color.Empty, Color.Empty);
        [DefaultValue(false)]
        public bool Modo_Demo { get; set; } = false;

        protected override Size DefaultSize
        {
            get
            {
                return new Size(100, 100);
            }
        }

        public Boton_Relay(Modulo_Boton MODULO, ContextMenuStrip MENU)
        {
            UseVisualStyleBackColor = true;
            TextImageRelation = TextImageRelation.ImageAboveText;
            ContextMenuStrip = MENU;
            Cargar_Modulo(MODULO);
        }

        public Boton_Relay() : this(new Modulo_Boton(), null) { }

        public void Cargar_Modulo(Modulo_Boton BOTON)
        {
            Name = BOTON.Nombre;
            Dispositivo = null;
            foreach (Modulo_Dispositivo X in Configuracion.Dispositivos)
            {
                if (X.Nombre == BOTON.Dispositivo)
                {
                    Dispositivo = X;
                }
            }
            Relay = BOTON.Relay;
            Estado = false;
            Size = BOTON.Tamanio;
            Location = BOTON.Ubicacion;
            Desactivado = BOTON.Desactivado;
            Activado = BOTON.Activado;
            Aplicar_Estado();
        }

        public Modulo_Boton Obtener_Modulo()
        {
            if (Dispositivo != null)
            {
                return new Modulo_Boton(Name, Dispositivo.Nombre, Relay, Size, Location, Desactivado, Activado);
            }
            else
            {
                return new Modulo_Boton(Name, "", Relay, Size, Location, Desactivado, Activado);
            }
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            if (Modo_Demo || Configuracion.Modo_Demo || Dispositivo == null)
            {
                Estado = !Estado;
                Aplicar_Estado();
            }
            else
            {
                if (!Dispositivo.Subproceso.IsBusy)
                {
                    Cursor = Cursors.WaitCursor;
                    Dispositivo.Comando = Modulo_Dispositivo.Establecer_Comando(Relay, !Estado);
                    Dispositivo.Subproceso.RunWorkerAsync(this);
                }
            }
        }

        public void Aplicar_Estado(Estado_Boton ESTADO)
        {
            Texto = ESTADO.Titulo;
            Tecla = ESTADO.Tecla;
            FileInfo __A = new FileInfo(ESTADO.Archivo_Imagen());
            if (__A.Exists)
            {
                Image = new Bitmap(__A.FullName);
            }
            else
            {
                Image = null;
            }
            if (ESTADO.Fondo != Color.Empty)
            {
                BackColor = ESTADO.Fondo;
            }
            else
            {
                BackColor = SystemColors.Control;
            }
            if (ESTADO.Texto != Color.Empty)
            {
                ForeColor = ESTADO.Texto;
            }
            else
            {
                ForeColor = SystemColors.ControlText;
            }
        }

        public void Aplicar_Estado()
        {
            if (Dispositivo == null)
            {
                Estado = false;
                Aplicar_Estado(Error);
            }
            else if (!Modo_Demo && !Configuracion.Modo_Demo && Dispositivo.Comando == Modulo_Dispositivo.CMD_ERROR)
            {
                Estado = false;
                Aplicar_Estado(Desconectado);
            }
            else
            {
                if (Estado)
                {
                    Aplicar_Estado(Activado);

                }
                else
                {
                    Aplicar_Estado(Desactivado);
                }
            }
        }

        public void Obtener_Estado_Asincrono()
        {
            if (!Dispositivo.Subproceso.IsBusy)
            {
                Cursor = Cursors.WaitCursor;
                Dispositivo.Comando = Modulo_Dispositivo.CMD_VERIFICAR;
                Dispositivo.Subproceso.RunWorkerAsync(this);
            }
        }

        public void Obtener_Estado_Sincrono()
        {
            Dispositivo.Comando = Modulo_Dispositivo.CMD_VERIFICAR;
            Dispositivo.Subproceso_DoWork(Dispositivo, new DoWorkEventArgs(this));
        }
    }
}
