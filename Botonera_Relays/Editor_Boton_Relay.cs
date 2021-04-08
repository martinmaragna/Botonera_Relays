using System;
using System.Windows.Forms;
using System.Drawing;

namespace Botonera_Relays
{
    public partial class Editor_Boton_Relay : Form
    {
        public Boton_Relay Boton = new Boton_Relay();

        public Editor_Boton_Relay()
        {
            InitializeComponent();
            dispositivo_comboBox.Items.AddRange(Configuracion.Dispositivos.ToArray());
            relay_comboBox.Items.AddRange(Enum.GetNames(typeof(Relay)));
            desactivado_estado_Boton_Control.Cargar_Imagenes();
            activado_estado_Boton_Control.Cargar_Imagenes();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            foreach (object X in Controls)
            {
                if (X is IControl_Key __CONTROL_KEY)
                {
                    if (__CONTROL_KEY.KeyClick(keyData))
                    {
                        return false;
                    }
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Leer_Modulo(object sender, EventArgs e)
        {
            nombre_textBox.Text = Boton.Name;
            if(Boton.Dispositivo != null)
            {
                dispositivo_comboBox.Text = Boton.Dispositivo.ToString();
            }
            relay_comboBox.SelectedIndex = (int)Boton.Relay ;
            ancho_intBox.Valor = Boton.Size.Width;
            alto_intBox.Valor = Boton.Size.Height;
            x_intBox.Valor = Boton.Location.X;
            y_intBox.Valor = Boton.Location.Y;
            desactivado_estado_Boton_Control.Cargar(Boton.Desactivado);
            activado_estado_Boton_Control.Cargar(Boton.Activado);
        }

        private void Guardar_Modulo(object sender, EventArgs e)
        {
            Boton.Name = nombre_textBox.Text;
            Boton.Dispositivo = Configuracion.Dispositivos[dispositivo_comboBox.SelectedIndex];
            Boton.Relay =((Relay)relay_comboBox.SelectedIndex);
            if (ancho_intBox.Ok && alto_intBox.Ok)
            {
                Boton.Size = new Size(ancho_intBox.Valor, alto_intBox.Valor);
            }
            if (x_intBox.Ok && y_intBox.Ok)
            {
                Boton.Location = new Point(x_intBox.Valor, y_intBox.Valor);
            }
            Boton.Desactivado = desactivado_estado_Boton_Control.Obtener_Estado();
            Boton.Activado = activado_estado_Boton_Control.Obtener_Estado();
            Boton.Aplicar_Estado();
        }

        private void Boton_Aceptar(object sender, EventArgs e)
        {
            if(dispositivo_comboBox.SelectedIndex == -1)
            {
                Mensajes.Mensaje_Detalle_No_Permitido_Agregar(this, Text, "");
                return;
            }
            Guardar_Modulo(sender, e);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void Boton_Cancelar(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void Tamanio_TextChanged(object sender, EventArgs e)
        {
            if(ancho_intBox.Ok && alto_intBox.Ok)
            {
                demo_boton_Relay.Size = new Size(ancho_intBox.Valor, alto_intBox.Valor);
            }
        }

        private void Desactivado_Cambio_Estado(object sender, EventArgs e)
        {
            demo_boton_Relay.Desactivado = desactivado_estado_Boton_Control.Obtener_Estado();
            demo_boton_Relay.Aplicar_Estado();
        }

        private void Activado_Cambio_Estado(object sender, EventArgs e)
        {
            demo_boton_Relay.Activado = activado_estado_Boton_Control.Obtener_Estado();
            demo_boton_Relay.Aplicar_Estado();
        }
    }
}
