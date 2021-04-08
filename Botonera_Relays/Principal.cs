using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Botonera_Relays
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            Text = Configuracion.Titulo_App;
            plantilla_panel.BackColor = Configuracion.DataGridView_Default.Color_Fondo_Trabajo;
            Mensajes.Modulos.Add(principal_messageForm);
            Configuracion.Dispositivos = Configuracion.Obtener_Dispositivos(Configuracion.Archivo_Dispositivos);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            foreach(object X in botones_toolStrip.Items)
            {
                if(X is IControl_Key __CONTROL_KEY)
                {
                    if(__CONTROL_KEY.KeyClick(keyData))
                    {
                        return false;
                    }
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Principal_Shown(object sender, EventArgs e)
        {

        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(Mensajes.Pregunta_Cerrar_Formulario(sender, Text) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void Salir_toolStripButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Gestor_disp_toolStripButton_Click(object sender, EventArgs e)
        {
            Gestor_Dispositivos __FORMULARIO = new Gestor_Dispositivos();
            __FORMULARIO.ShowDialog();
        }
        
        private void Agregar_boton_toolStripButton_Click(object sender, EventArgs e)
        {
            Editor_Boton_Relay __EDITOR = new Editor_Boton_Relay();
            if (__EDITOR.ShowDialog() == DialogResult.OK)
            {
                __EDITOR.Boton.ContextMenuStrip = menu_contextMenuStrip;
                plantilla_panel.Controls.Add(__EDITOR.Boton);
            }
        }







        private void agregar_boton_button_Key_Click(object sender, EventArgs e)
        {
            Editor_Boton_Relay __FORM = new Editor_Boton_Relay();
            if (sender is Boton_Relay __BOTON)
            {
                __FORM.Boton = __BOTON;
            }
            if (__FORM.ShowDialog() == DialogResult.OK)
            {
                __FORM.Boton.ContextMenuStrip = menu_contextMenuStrip;
                plantilla_panel.Controls.Add(__FORM.Boton);
            }
        }

        private void duplicar_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem __BOTON)
            {
                //__BOTON.Owner.
                agregar_boton_button_Key_Click(__BOTON, e);
            }
        }

        private void Modificar_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (menu_contextMenuStrip.SourceControl is Boton_Relay __BOTON)
            {
                Editor_Boton_Relay __EDITOR = new Editor_Boton_Relay();
                __EDITOR.Boton = __BOTON;
                if (__EDITOR.ShowDialog() == DialogResult.OK)
                {
                    plantilla_panel.Controls.Remove(__BOTON);
                    plantilla_panel.Controls.Add(__EDITOR.Boton);
                }
            }
        }

        private void Eliminar_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (menu_contextMenuStrip.SourceControl is Boton_Relay __BOTON)
            {
                plantilla_panel.Controls.Remove(__BOTON);
            }
        }
    }
}
