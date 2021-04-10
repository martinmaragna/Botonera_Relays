using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Botonera_Relays
{
    public partial class Gestor_Dispositivos : Form
    {
        public Gestor_Dispositivos()
        {
            InitializeComponent();
            Modulo_Dispositivo.Cargar_DatagridviewColumns(dispositivos_detalleDataGridView, Agregar_Dispositivo, Modificar_Dispositivo);
            cargar_openFileDialog.FileName = Configuracion.Archivo_Dispositivos;
            cargar_openFileDialog.DefaultExt = Configuracion.Extension_Archivo_Dispositivos;
            cargar_openFileDialog.Filter = "Archivos " + Configuracion.Extension_Archivo_Dispositivos + "|*." + Configuracion.Extension_Archivo_Dispositivos;
            guardar_saveFileDialog.FileName = Configuracion.Archivo_Dispositivos;
            guardar_saveFileDialog.DefaultExt = Configuracion.Extension_Archivo_Dispositivos;
            guardar_saveFileDialog.Filter = "Archivos " + Configuracion.Extension_Archivo_Dispositivos + "|*." + Configuracion.Extension_Archivo_Dispositivos;
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

        private void Gestor_Dispositivos_Shown(object sender, EventArgs e)
        {
            dispositivos_detalleDataGridView.Cargar_Detalle(Configuracion.Dispositivos.ToArray());
        }

        private void Agregar_Dispositivo(object sender, DetalleDataGridViewEventArgs e)
        {
            Editor_Dispositivo __EDITOR = new Editor_Dispositivo
            {
                Modulo = (Modulo_Dispositivo)e.Plantilla.Clone()
            };
            if (__EDITOR.ShowDialog() == DialogResult.OK)
            {
                e.Detalle.Add((Modulo_Dispositivo)__EDITOR.Modulo.Clone());
                e.Aplicar_Detalle = true;
                return;
            }
            e.Aplicar_Detalle = false;
        }

        private void Modificar_Dispositivo(object sender, DetalleDataGridViewEventArgs e)
        {
            Editor_Dispositivo __EDITOR = new Editor_Dispositivo
            {
                Modulo = (Modulo_Dispositivo)e.Detalle[0].Clone()
            };
            if (__EDITOR.ShowDialog() == DialogResult.OK)
            {
                e.Detalle[0] = (Modulo_Dispositivo)__EDITOR.Modulo.Clone();
                e.Aplicar_Detalle = true;
                return;
            }
            e.Aplicar_Detalle = false;
        }

        private void Agregar_button_Key_Click(object sender, EventArgs e)
        {
            dispositivos_detalleDataGridView.Agregar_Detalle(sender, e);
        }

        private void Modificar_button_Key_Click(object sender, EventArgs e)
        {
            dispositivos_detalleDataGridView.Modificar_Detalle(sender, e);
        }

        private void Eliminar_button_Key_Click(object sender, EventArgs e)
        {
            dispositivos_detalleDataGridView.Eliminar_Detalle(sender, e);
        }

        private void Limpiar_button_Key_Click(object sender, EventArgs e)
        {
            dispositivos_detalleDataGridView.Limpiar_Detalle(sender, e);
        }

        private void Cargar_button_Key_Click(object sender, EventArgs e)
        {
            if (cargar_openFileDialog.ShowDialog() == DialogResult.OK)
            {
                List<Modulo_Dispositivo> __DISPOSITIVOS = Configuracion.Obtener_Dispositivos(cargar_openFileDialog.FileName);
                dispositivos_detalleDataGridView.Cargar_Detalle(__DISPOSITIVOS.ToArray());
            }
        }

        private void Guardar_button_Key_Click(object sender, EventArgs e)
        {
            if (guardar_saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Configuracion.Dispositivos.Clear();
                foreach (Modulo_Dispositivo X in dispositivos_detalleDataGridView.Detalle)
                {
                    Configuracion.Dispositivos.Add(X);
                }
                Configuracion.Guardar_Dispositivos(guardar_saveFileDialog.FileName, Configuracion.Dispositivos);
            }
            Close();
        }

        private void Cancelar_button_Key_Click(object sender, EventArgs e)
        {
            if (Mensajes.Pregunta_Cerrar_Formulario_Sin_Guardar(sender, Text) == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
