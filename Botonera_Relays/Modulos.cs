using Botonera_Relays;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Text.Json.Serialization;
using System.IO;
using System.Text.Json;
using System.Net.Sockets;

namespace Botonera_Relays
{
    public enum Relay
    {
        Relay_1 = 0,
        Relay_2 = 1,
        Relay_3 = 2,
        Relay_4 = 3
    }

    static public class Configuracion
    {
        static public string Titulo_App = "Botonera de Relays v" + Application.ProductVersion.Trim('.', '0');
        static public DataGridViewCellStyle Estilo_Normal = new DataGridViewCellStyle() { BackColor = Color.WhiteSmoke, SelectionBackColor = Color.DimGray, ForeColor = Color.Black, SelectionForeColor = Color.White };
        static public Propiedades_DataGridView DataGridView_Default = new Propiedades_DataGridView(Color.FromArgb(32, 32, 32), Estilo_Normal);
        static public Propiedades_Columnas_Editables Columna_No_Editable = new Propiedades_Columnas_Editables();
        static public string Directorio_Imagenes = @"\Imagenes";
        static public string Filtro_Imagenes = "*.png";

        static public string Extension_Archivo_Dispositivos = "json";
        static public string Archivo_Dispositivos = "Dispositivos." + Extension_Archivo_Dispositivos;
        static public List<Modulo_Dispositivo> Dispositivos = new List<Modulo_Dispositivo> { };
        static public List<Modulo_Dispositivo> Obtener_Dispositivos(string ARCHIVO)
        {
            return JsonSerializer.Deserialize<List<Modulo_Dispositivo>>(File.ReadAllText(ARCHIVO));
        }
        static public void Guardar_Dispositivos(string ARCHIVO, List<Modulo_Dispositivo> DISPOSITIVOS)
        {
            File.WriteAllText(ARCHIVO, JsonSerializer.Serialize(DISPOSITIVOS, new JsonSerializerOptions() { WriteIndented = true }));
        }

        static public string Extension_Archivo_Botones = "json";
        static public string Archivo_Botones = "Botones." + Extension_Archivo_Botones;
        static public List<Boton_Relay> Obtener_Botones(string ARCHIVO)
        {
            return JsonSerializer.Deserialize<List<Boton_Relay>>(File.ReadAllText(ARCHIVO));
        }
        static public void Guardar_Botones(string ARCHIVO, List<Boton_Relay> BOTONES)
        {
            File.WriteAllText(ARCHIVO, JsonSerializer.Serialize(BOTONES, new JsonSerializerOptions() { WriteIndented = true }));
        }
    }

    static public class Mensajes
    {
        static public List<IMensajes> Modulos = new List<IMensajes>();
        static public DialogResult Pregunta_Cerrar_Formulario(object GENERADOR, string TITULO)
        {
            return MENSAJES.Mostrar_Mensaje(Modulos, new Info_Mensaje(MEN_Tipo.Pregunta, 10, "Cerrar {0}", "¿Está seguro que desea cerrar el formulario '{0}'?", Tipo_Mensaje_Formulario.Formulario_Si_no), GENERADOR, TITULO);
        }
        static public DialogResult Pregunta_Cerrar_Formulario_Sin_Guardar(object GENERADOR, string TITULO)
        {
            return MENSAJES.Mostrar_Mensaje(Modulos, new Info_Mensaje(MEN_Tipo.Pregunta, 10, "Cerrar {0}", "¿Está seguro que desea cerrar el formulario '{0}' sin guardar los cambios?", Tipo_Mensaje_Formulario.Formulario_Si_no), GENERADOR, TITULO);
        }
        static public DialogResult Mensaje_Detalle_No_Permitido_Agregar(object GENERADOR, string TITULO, string ELEMENTO)
        {
            return MENSAJES.Mostrar_Mensaje(Modulos, new Info_Mensaje(MEN_Tipo.Detener, 10, "{0}", "No se puede agregar al detalle.{1}", Tipo_Mensaje_Formulario.Formulario_Ok), GENERADOR, TITULO, ELEMENTO);
        }
        static public DialogResult Mensaje_Detalle_No_Permitido_Agregar_Ya_Existe(object GENERADOR, string TITULO, string ELEMENTO)
        {
            return Mensaje_Detalle_No_Permitido_Agregar(GENERADOR, TITULO, Environment.NewLine + ELEMENTO + Environment.NewLine + "Motivo: Ya existe un elemento igual en el detalle.");
        }

    }
    public class Modulo_Dispositivo : IDetallable
    {
        static public byte[] R1_O = { 0xA0, 0x01, 0x01, 0xA2 };
        static public byte[] R1_C = { 0xA0, 0x01, 0x00, 0xA1 };
        static public byte[] R2_O = { 0xA0, 0x02, 0x01, 0xA3 };
        static public byte[] R2_C = { 0xA0, 0x02, 0x00, 0xA2 };
        static public byte[] R3_O = { 0xA0, 0x03, 0x01, 0xA4 };
        static public byte[] R3_C = { 0xA0, 0x03, 0x00, 0xA3 };
        static public byte[] R4_O = { 0xA0, 0x04, 0x01, 0xA5 };
        static public byte[] R4_C = { 0xA0, 0x04, 0x00, 0xA4 };

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
                return Ip1.ToString("000") + "." + Ip2.ToString("000") + "." + Ip3.ToString("000") + "." + Ip4.ToString("000");
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

        public bool Estado;

        public Modulo_Dispositivo(string NOMBRE, string DIRECCION, int PUERTO)
        {
            Nombre = NOMBRE;
            Direccion = DIRECCION;
            Puerto = PUERTO;
        }

        public Modulo_Dispositivo(string NOMBRE, string DIRECCION) : this(NOMBRE, DIRECCION, 8080)
        {
        }

        public Modulo_Dispositivo() : this("", "192.168.1.1", 8080)
        {
        }

        public string Estado_string()
        {
            if (Estado)
            {
                return "CONECTADO";
            }
            else
            {
                return "DESCONECTADO";
            }
        }

        public byte[] Obtener_Trama(Relay RELAY, bool ESTADO)
        {
            switch (RELAY)
            {
                case Relay.Relay_1:
                    if (ESTADO)
                    {
                        return R1_C;
                    }
                    else
                    {
                        return R1_O;
                    }
                case Relay.Relay_2:
                    if (ESTADO)
                    {
                        return R2_C;
                    }
                    else
                    {
                        return R2_O;
                    }
                case Relay.Relay_3:
                    if (ESTADO)
                    {
                        return R3_C;
                    }
                    else
                    {
                        return R3_O;
                    }
                case Relay.Relay_4:
                    if (ESTADO)
                    {
                        return R4_C;
                    }
                    else
                    {
                        return R4_O;
                    }
            }
            return new byte[] { };
        }

        public bool Ejecutar_Estado(Relay RELAY, bool ESTADO)
        {
            try
            {
                Socket __SOCALO = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                __SOCALO.Connect(Direccion, Puerto);
                __SOCALO.Send(Obtener_Trama(RELAY, ESTADO));
                __SOCALO.Close();
                Estado = true;
            }
            catch (Exception A)
            {
                Estado = false;
            }
            return Estado;
        }

        public bool Obtener_Estado()
        {
            try
            {
                Socket __SOCALO = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                __SOCALO.Connect(Direccion, Puerto);
                __SOCALO.Close();
                Estado = true;
            }
            catch (Exception A)
            {
                Estado = false;
            }
            return Estado;
        }
        //IDetallable
        public const int Indice_Nombre = 0;
        public const int Indice_Direccion = 1;
        public const int Indice_Puerto = 2;
        public const int Indice_Estado = 3;

        static public void Cargar_DatagridviewColumns(DetalleDataGridView DATAGRIDVIEW, EventHandler<DetalleDataGridViewEventArgs> METODO_AGREGAR, EventHandler<DetalleDataGridViewEventArgs> METODO_MODIFICAR)
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
        public override string ToString()
        {
            return Nombre + " (" + Direccion + ")";
        }

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
}

namespace System.Windows.Forms
{
    public class Boton_Relay : Button_Key
    {
        static public Estado_Boton Desconectado = new Estado_Boton("OFFLINE", Color.Gray, Color.DarkGray);
        public BackgroundWorker Subproceso = new BackgroundWorker();
        public Modulo_Dispositivo Dispositivo = null;
        public Relay Relay = Relay.Relay_1;
        public bool Estado = false;
        public Estado_Boton Desactivado = new Estado_Boton("OFF", Color.Empty, Color.Empty);
        public Estado_Boton Activado = new Estado_Boton("ON", Color.Empty, Color.Empty);

        protected override Size DefaultSize
        {
            get
            {
                return new Size(100, 100);
            }
        }

        [DefaultValue(false)]
        public bool Modo_Demo { get; set; } = false;

        public Boton_Relay()
        {
            UseVisualStyleBackColor = true;
            TextImageRelation = TextImageRelation.ImageAboveText;
            Subproceso.DoWork += Subproceso_DoWork;
            Subproceso.RunWorkerCompleted += Subproceso_RunWorkerCompleted;
        }

        private void Subproceso_DoWork(object sender, DoWorkEventArgs e)
        {
            if ((bool)e.Argument)
            {
                Estado = Ejecutar_Estado();
            }
            else
            {
                Estado = Obtener_Estado();
            }
        }

        private void Subproceso_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Cursor = Cursors.Default;
            Aplicar_Estado();
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            if (Modo_Demo)
            {
                Estado = !Estado;
                Aplicar_Estado();
            }
            else
            {
                if (!Subproceso.IsBusy)
                {
                    Cursor = Cursors.WaitCursor;
                    Subproceso.RunWorkerAsync(true);
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
            if (Dispositivo != null && !Dispositivo.Estado)
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

        public bool Ejecutar_Estado()
        {
            if (Dispositivo != null)
            {
                if (Dispositivo.Ejecutar_Estado(Relay, Estado))
                {
                    return !Estado;
                }
            }
            return false;
        }

        public bool Obtener_Estado()
        {
            if (Dispositivo != null)
            {
                if (Dispositivo.Obtener_Estado())
                {
                    return Estado;
                }
            }
            return false;
        }

        public void Obtener_Estado_Asincrono()
        {
            if (!Subproceso.IsBusy)
            {
                Cursor = Cursors.WaitCursor;
                Subproceso.RunWorkerAsync(false);
            }
        }
    }
}
