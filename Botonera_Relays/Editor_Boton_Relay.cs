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
            imagen_activado_comboBox.Items.AddRange(Boton_Relay.Imagenes.Obtener_Lista_Texto().ToArray());
            imagen_desactivado_comboBox.Items.AddRange(Boton_Relay.Imagenes.Obtener_Lista_Texto().ToArray());
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

            Boton.Name = "";
            dispositivo_comboBox.SelectedItem = Boton.Dispositivo.Obtener_Elemento();
            relay_comboBox.SelectedIndex = Boton.Relay - 1;
            ancho_intBox.Valor = Boton.Size.Width;
            alto_intBox.Valor = Boton.Size.Height;

            x_intBox.Valor = Boton.Location.X;
            y_intBox.Valor = Boton.Location.Y;
            nombre_desactivado_textBox.Text = Boton.Desactivado.Nombre;
            fondo_desactivado_colorComboBox.Color_Seleccionado = Boton.Desactivado.Fondo;

            nombre_activado_textBox.Text = Boton.Activado.Nombre;
            fondo_activado_colorComboBox.Color_Seleccionado = Boton.Activado.Fondo;

        }

        private void Guardar_Modulo(object sender, EventArgs e)
        {
            Boton.Name = "";
            Boton.Dispositivo = Configuracion.Dispositivos[dispositivo_comboBox.SelectedIndex];
            Boton.Relay = relay_comboBox.SelectedIndex + 1;
            if (ancho_intBox.Ok && alto_intBox.Ok)
            {
                Boton.Size = new Size(ancho_intBox.Valor, alto_intBox.Valor);
            }
            if (x_intBox.Ok && y_intBox.Ok)
            {
                Boton.Location = new Point(x_intBox.Valor, y_intBox.Valor);
            }
            Boton.Desactivado.Nombre = nombre_desactivado_textBox.Text;
            Boton.Desactivado.Fondo = fondo_desactivado_colorComboBox.Color_Seleccionado;
            Boton.Desactivado.Imagen = Boton_Relay.Imagenes.Obtener_Llave(imagen_desactivado_comboBox.Text);
            Boton.Activado.Nombre = nombre_activado_textBox.Text;
            Boton.Activado.Fondo = fondo_activado_colorComboBox.Color_Seleccionado;
            Boton.Activado.Imagen = Boton_Relay.Imagenes.Obtener_Llave(imagen_activado_comboBox.Text);
            Boton.Aplicar_Estado();
        }

        private void Boton_Aceptar(object sender, EventArgs e)
        {
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

        private void Desactivado_Changed(object sender, EventArgs e)
        {
            demo_boton_Relay.Desactivado.Nombre = nombre_desactivado_textBox.Text;
            demo_boton_Relay.Desactivado.Fondo = fondo_desactivado_colorComboBox.Color_Seleccionado;
            demo_boton_Relay.Desactivado.Imagen = Boton_Relay.Imagenes.Obtener_Llave(imagen_desactivado_comboBox.Text);
            demo_boton_Relay.Aplicar_Estado();
        }

        private void Activado_Changed(object sender, EventArgs e)
        {
            demo_boton_Relay.Activado.Nombre = nombre_activado_textBox.Text;
            demo_boton_Relay.Activado.Fondo = fondo_activado_colorComboBox.Color_Seleccionado;
            demo_boton_Relay.Activado.Imagen = Boton_Relay.Imagenes.Obtener_Llave(imagen_activado_comboBox.Text);
            demo_boton_Relay.Aplicar_Estado();
        }
    }
}
