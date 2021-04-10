using System;
using System.Collections.Generic;
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
            cargar_openFileDialog.FileName = Configuracion.Archivo_Botones;
            cargar_openFileDialog.DefaultExt = Configuracion.Extension_Archivo_Botones;
            cargar_openFileDialog.Filter = "Archivos " + Configuracion.Extension_Archivo_Botones + "|*." + Configuracion.Extension_Archivo_Botones;
            guardar_saveFileDialog.FileName = Configuracion.Archivo_Botones;
            guardar_saveFileDialog.DefaultExt = Configuracion.Extension_Archivo_Botones;
            guardar_saveFileDialog.Filter = "Archivos " + Configuracion.Extension_Archivo_Botones + "|*." + Configuracion.Extension_Archivo_Botones;
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
            Configuracion.Dispositivos = Configuracion.Obtener_Dispositivos(Configuracion.Archivo_Dispositivos);
            List<Modulo_Boton> __BOTONES = Configuracion.Obtener_Botones(Configuracion.Archivo_Botones);
            foreach (Modulo_Boton X in __BOTONES)
            {
                plantilla_panel.Controls.Add(new Boton_Relay(X, menu_contextMenuStrip));
            }
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
                Boton_Relay __CONTROL = new Boton_Relay(__EDITOR.Boton, menu_contextMenuStrip);
                plantilla_panel.Controls.Add(__CONTROL);
            }
        }

        private void Duplicar_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (menu_contextMenuStrip.SourceControl is Boton_Relay __BOTON)
            {
                Editor_Boton_Relay __EDITOR = new Editor_Boton_Relay
                {
                    Boton = __BOTON.Obtener_Modulo()
                };
                if (__EDITOR.ShowDialog() == DialogResult.OK)
                {
                    plantilla_panel.Controls.Add(new Boton_Relay(__EDITOR.Boton, menu_contextMenuStrip));
                }
            }
        }

        private void Modificar_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (menu_contextMenuStrip.SourceControl is Boton_Relay __BOTON)
            {
                Editor_Boton_Relay __EDITOR = new Editor_Boton_Relay
                {
                    Boton = __BOTON.Obtener_Modulo()
                };
                if (__EDITOR.ShowDialog() == DialogResult.OK)
                {
                    __BOTON.Cargar_Modulo(__EDITOR.Boton);
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

        private void Verificar_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (menu_contextMenuStrip.SourceControl is Boton_Relay __BOTON)
            {
                __BOTON.Obtener_Estado_Asincrono();
            }
        }

        private void Guardar_toolStripButton_Key_Click(object sender, EventArgs e)
        {
            if (guardar_saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                List<Modulo_Boton> __BOTONES = new List<Modulo_Boton>();
                foreach (Control C in plantilla_panel.Controls)
                {
                    if (C is Boton_Relay R)
                    {
                        __BOTONES.Add(R.Obtener_Modulo());
                    }
                }
                Configuracion.Guardar_Botones(guardar_saveFileDialog.FileName, __BOTONES);
            }
        }

        private void Cargar_toolStripButton_Key_Click(object sender, EventArgs e)
        {
            if (cargar_openFileDialog.ShowDialog() == DialogResult.OK)
            {
                List<Modulo_Boton> __BOTONES = Configuracion.Obtener_Botones(cargar_openFileDialog.FileName);
                foreach (Modulo_Boton X in __BOTONES)
                {
                    plantilla_panel.Controls.Add(new Boton_Relay(X, menu_contextMenuStrip));
                }
            }
        }
    }
}
