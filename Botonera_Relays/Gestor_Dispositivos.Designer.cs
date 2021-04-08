
namespace Botonera_Relays
{
    partial class Gestor_Dispositivos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cargar_button_Key = new System.Windows.Forms.Button_Key();
            this.limpiar_button_Key = new System.Windows.Forms.Button_Key();
            this.eliminar_button_Key = new System.Windows.Forms.Button_Key();
            this.modificar_button_Key = new System.Windows.Forms.Button_Key();
            this.agregar_button_Key = new System.Windows.Forms.Button_Key();
            this.dispositivos_detalleDataGridView = new System.Windows.Forms.DetalleDataGridView();
            this.dispositivos_label = new System.Windows.Forms.Label();
            this.guardar_button_Key = new System.Windows.Forms.Button_Key();
            this.cancelar_button_Key = new System.Windows.Forms.Button_Key();
            this.cargar_openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.guardar_saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dispositivos_detalleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cargar_button_Key
            // 
            this.cargar_button_Key.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cargar_button_Key.Location = new System.Drawing.Point(436, 423);
            this.cargar_button_Key.Mostrar_Tecla = true;
            this.cargar_button_Key.Name = "cargar_button_Key";
            this.cargar_button_Key.Size = new System.Drawing.Size(140, 26);
            this.cargar_button_Key.TabIndex = 13;
            this.cargar_button_Key.Tecla = System.Windows.Forms.Keys.F5;
            this.cargar_button_Key.Text = "Cargar Archivo (F5)";
            this.cargar_button_Key.Texto = "Cargar Archivo";
            this.cargar_button_Key.UseVisualStyleBackColor = true;
            this.cargar_button_Key.Click += new System.EventHandler(this.cargar_button_Key_Click);
            // 
            // limpiar_button_Key
            // 
            this.limpiar_button_Key.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.limpiar_button_Key.Location = new System.Drawing.Point(330, 423);
            this.limpiar_button_Key.Mostrar_Tecla = true;
            this.limpiar_button_Key.Name = "limpiar_button_Key";
            this.limpiar_button_Key.Size = new System.Drawing.Size(100, 26);
            this.limpiar_button_Key.TabIndex = 12;
            this.limpiar_button_Key.Tecla = System.Windows.Forms.Keys.F4;
            this.limpiar_button_Key.Text = "Limpiar (F4)";
            this.limpiar_button_Key.Texto = "Limpiar";
            this.limpiar_button_Key.UseVisualStyleBackColor = true;
            this.limpiar_button_Key.Click += new System.EventHandler(this.limpiar_button_Key_Click);
            // 
            // eliminar_button_Key
            // 
            this.eliminar_button_Key.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.eliminar_button_Key.Location = new System.Drawing.Point(224, 423);
            this.eliminar_button_Key.Mostrar_Tecla = true;
            this.eliminar_button_Key.Name = "eliminar_button_Key";
            this.eliminar_button_Key.Size = new System.Drawing.Size(100, 26);
            this.eliminar_button_Key.TabIndex = 11;
            this.eliminar_button_Key.Tecla = System.Windows.Forms.Keys.F3;
            this.eliminar_button_Key.Text = "Eliminar (F3)";
            this.eliminar_button_Key.Texto = "Eliminar";
            this.eliminar_button_Key.UseVisualStyleBackColor = true;
            this.eliminar_button_Key.Click += new System.EventHandler(this.eliminar_button_Key_Click);
            // 
            // modificar_button_Key
            // 
            this.modificar_button_Key.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.modificar_button_Key.Location = new System.Drawing.Point(118, 423);
            this.modificar_button_Key.Mostrar_Tecla = true;
            this.modificar_button_Key.Name = "modificar_button_Key";
            this.modificar_button_Key.Size = new System.Drawing.Size(100, 26);
            this.modificar_button_Key.TabIndex = 10;
            this.modificar_button_Key.Tecla = System.Windows.Forms.Keys.F2;
            this.modificar_button_Key.Text = "Modificar (F2)";
            this.modificar_button_Key.Texto = "Modificar";
            this.modificar_button_Key.UseVisualStyleBackColor = true;
            this.modificar_button_Key.Click += new System.EventHandler(this.modificar_button_Key_Click);
            // 
            // agregar_button_Key
            // 
            this.agregar_button_Key.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.agregar_button_Key.Location = new System.Drawing.Point(12, 423);
            this.agregar_button_Key.Mostrar_Tecla = true;
            this.agregar_button_Key.Name = "agregar_button_Key";
            this.agregar_button_Key.Size = new System.Drawing.Size(100, 26);
            this.agregar_button_Key.TabIndex = 9;
            this.agregar_button_Key.Tecla = System.Windows.Forms.Keys.F1;
            this.agregar_button_Key.Text = "Agregar (F1)";
            this.agregar_button_Key.Texto = "Agregar";
            this.agregar_button_Key.UseVisualStyleBackColor = true;
            this.agregar_button_Key.Click += new System.EventHandler(this.agregar_button_Key_Click);
            // 
            // dispositivos_detalleDataGridView
            // 
            this.dispositivos_detalleDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dispositivos_detalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dispositivos_detalleDataGridView.Location = new System.Drawing.Point(12, 28);
            this.dispositivos_detalleDataGridView.Name = "dispositivos_detalleDataGridView";
            this.dispositivos_detalleDataGridView.Size = new System.Drawing.Size(860, 389);
            this.dispositivos_detalleDataGridView.TabIndex = 8;
            // 
            // dispositivos_label
            // 
            this.dispositivos_label.AutoSize = true;
            this.dispositivos_label.Location = new System.Drawing.Point(12, 9);
            this.dispositivos_label.Name = "dispositivos_label";
            this.dispositivos_label.Size = new System.Drawing.Size(135, 16);
            this.dispositivos_label.TabIndex = 7;
            this.dispositivos_label.Text = "Lista de Dispositivos:";
            // 
            // guardar_button_Key
            // 
            this.guardar_button_Key.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.guardar_button_Key.Location = new System.Drawing.Point(582, 423);
            this.guardar_button_Key.Mostrar_Tecla = true;
            this.guardar_button_Key.Name = "guardar_button_Key";
            this.guardar_button_Key.Size = new System.Drawing.Size(160, 26);
            this.guardar_button_Key.TabIndex = 14;
            this.guardar_button_Key.Tecla = System.Windows.Forms.Keys.F6;
            this.guardar_button_Key.Text = "Guardar Cambios (F6)";
            this.guardar_button_Key.Texto = "Guardar Cambios";
            this.guardar_button_Key.UseVisualStyleBackColor = true;
            this.guardar_button_Key.Click += new System.EventHandler(this.guardar_button_Key_Click);
            // 
            // cancelar_button_Key
            // 
            this.cancelar_button_Key.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelar_button_Key.Location = new System.Drawing.Point(748, 423);
            this.cancelar_button_Key.Mostrar_Tecla = true;
            this.cancelar_button_Key.Name = "cancelar_button_Key";
            this.cancelar_button_Key.Size = new System.Drawing.Size(124, 26);
            this.cancelar_button_Key.TabIndex = 15;
            this.cancelar_button_Key.Tecla = System.Windows.Forms.Keys.Escape;
            this.cancelar_button_Key.Text = "Cancelar (Esc)";
            this.cancelar_button_Key.Texto = "Cancelar";
            this.cancelar_button_Key.UseVisualStyleBackColor = true;
            this.cancelar_button_Key.Click += new System.EventHandler(this.Cancelar_button_Key_Click);
            // 
            // cargar_openFileDialog
            // 
            this.cargar_openFileDialog.ReadOnlyChecked = true;
            this.cargar_openFileDialog.Title = "Cargar archivo con lista de dispositivos";
            // 
            // guardar_saveFileDialog
            // 
            this.guardar_saveFileDialog.Title = "Guardar archivo con lista de dispositivos";
            // 
            // Gestor_Dispositivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.cancelar_button_Key);
            this.Controls.Add(this.guardar_button_Key);
            this.Controls.Add(this.cargar_button_Key);
            this.Controls.Add(this.limpiar_button_Key);
            this.Controls.Add(this.eliminar_button_Key);
            this.Controls.Add(this.modificar_button_Key);
            this.Controls.Add(this.agregar_button_Key);
            this.Controls.Add(this.dispositivos_detalleDataGridView);
            this.Controls.Add(this.dispositivos_label);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(900, 300);
            this.Name = "Gestor_Dispositivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor de Dispositivos";
            this.Shown += new System.EventHandler(this.Gestor_Dispositivos_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dispositivos_detalleDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button_Key cargar_button_Key;
        private System.Windows.Forms.Button_Key limpiar_button_Key;
        private System.Windows.Forms.Button_Key eliminar_button_Key;
        private System.Windows.Forms.Button_Key modificar_button_Key;
        private System.Windows.Forms.Button_Key agregar_button_Key;
        private System.Windows.Forms.DetalleDataGridView dispositivos_detalleDataGridView;
        private System.Windows.Forms.Label dispositivos_label;
        private System.Windows.Forms.Button_Key guardar_button_Key;
        private System.Windows.Forms.Button_Key cancelar_button_Key;
        private System.Windows.Forms.OpenFileDialog cargar_openFileDialog;
        private System.Windows.Forms.SaveFileDialog guardar_saveFileDialog;
    }
}