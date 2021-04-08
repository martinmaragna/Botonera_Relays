using Botonera_Relays;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Text.Json.Serialization;
using System.IO;
using System.Text.Json;

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

        public bool Estado()
        {
                //System.Threading.Thread.Sleep(1000);
                return false;
        }

        public string Estado_string()
        {
                if(Estado())
                {
                    return "CONECTADO";
                }
                else
                {
                    return "DESCONECTADO";
                }
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
    public class Estado_Boton
    {
        public string Nombre;
        public Keys Tecla;
        public Color Fondo;
        public Image Imagen;

        public Estado_Boton(string NOMBRE)
        {
            Nombre = NOMBRE;
            Tecla = Keys.None;
            Fondo = Color.Gray;
            Imagen = null;
        }
    }



    public class Boton_Relay : Button_Key
    {
        static public List_Tuple<Image> Imagenes = new List_Tuple<Image>
        {
            new Tuple<Image, string>(Botonera_Relays.Properties.Resources.bafle,"Bafle"),
            new Tuple<Image, string>(Botonera_Relays.Properties.Resources.lineal,"Lineal"),
            new Tuple<Image, string>(Botonera_Relays.Properties.Resources.subwoofer,"Subwoofer"),
            new Tuple<Image, string>(Botonera_Relays.Properties.Resources.estructura,"Estructura")
        };

        public Modulo_Dispositivo Dispositivo = new Modulo_Dispositivo("Ninguno", "127.0.0.1");
        public int Relay = 1;

        public bool Estado = false;

        public Estado_Boton Desactivado = new Estado_Boton("OFF");
        public Estado_Boton Activado = new Estado_Boton("ON");

        protected override Size DefaultSize
        {
            get
            {
                return new Size(100, 100);
            }
        }

        public Boton_Relay()
        {
            TextImageRelation = TextImageRelation.ImageAboveText;
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            Estado = !Estado;
            Aplicar_Estado();
        }

        protected override void OnInvalidated(InvalidateEventArgs e)
        {
            base.OnInvalidated(e);
        }

        public void Aplicar_Estado(Estado_Boton ESTADO)
        {
            Texto = ESTADO.Nombre;
            Tecla = ESTADO.Tecla;
            if (ESTADO.Fondo != Color.Empty)
            {
                BackColor = ESTADO.Fondo;
            }
            if (ESTADO.Imagen != null)
            {
                Image = ESTADO.Imagen;
            }
        }

        public void Aplicar_Estado()
        {
            if (Estado)
            {

                Aplicar_Estado(Desactivado);
            }
            else
            {
                Aplicar_Estado(Activado);
            }

        }
    }
}
