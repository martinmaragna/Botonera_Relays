using System;
using System.Windows.Forms;

namespace Botonera_Relays
{
    public partial class Editor_Dispositivo : Form
    {
        public Modulo_Dispositivo Modulo = new Modulo_Dispositivo("Dispo1", "192.168.0.100");

        public Editor_Dispositivo()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            cancelar_button_Key.KeyClick(keyData);
            aceptar_button_Key.KeyClick(keyData);
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Leer_Modulo(object sender, EventArgs e)
        {
            nombre_textBox.Text = Modulo.Nombre;
            ip1_intBox.Valor = Modulo.Ip1;
            ip2_intBox.Valor = Modulo.Ip2;
            ip3_intBox.Valor = Modulo.Ip3;
            ip4_intBox.Valor = Modulo.Ip4;
            puerto_intBox.Valor = Modulo.Puerto;
        }

        private void Guardar_Modulo(object sender, EventArgs e)
        {
            Modulo.Nombre = nombre_textBox.Text;
            Modulo.Ip1 = ip1_intBox.Valor;
            Modulo.Ip2 = ip2_intBox.Valor;
            Modulo.Ip3 = ip3_intBox.Valor;
            Modulo.Ip4 = ip4_intBox.Valor;
            Modulo.Puerto = puerto_intBox.Valor;
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
    }
}
