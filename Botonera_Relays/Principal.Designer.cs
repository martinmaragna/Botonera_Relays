
namespace Botonera_Relays
{
    partial class Principal
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
            this.components = new System.ComponentModel.Container();
            this.principal_messageForm = new System.ComponentModel.MessageForm();
            this.menu_contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.duplicar_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificar_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminar_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.botones_toolStrip = new System.Windows.Forms.ToolStrip();
            this.gestor_disp_toolStripButton = new System.Windows.Forms.ToolStripButton_Key();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.agregar_boton_toolStripButton = new System.Windows.Forms.ToolStripButton_Key();
            this.salir_toolStripButton = new System.Windows.Forms.ToolStripButton_Key();
            this.plantilla_panel = new System.Windows.Forms.Panel();
            this.menu_contextMenuStrip.SuspendLayout();
            this.botones_toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_contextMenuStrip
            // 
            this.menu_contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.duplicar_toolStripMenuItem,
            this.modificar_toolStripMenuItem,
            this.eliminar_toolStripMenuItem});
            this.menu_contextMenuStrip.Name = "contextMenuStrip1";
            this.menu_contextMenuStrip.Size = new System.Drawing.Size(126, 70);
            // 
            // duplicar_toolStripMenuItem
            // 
            this.duplicar_toolStripMenuItem.Name = "duplicar_toolStripMenuItem";
            this.duplicar_toolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.duplicar_toolStripMenuItem.Text = "Duplicar";
            this.duplicar_toolStripMenuItem.Click += new System.EventHandler(this.duplicar_toolStripMenuItem_Click);
            // 
            // modificar_toolStripMenuItem
            // 
            this.modificar_toolStripMenuItem.Name = "modificar_toolStripMenuItem";
            this.modificar_toolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.modificar_toolStripMenuItem.Text = "Modificar";
            this.modificar_toolStripMenuItem.Click += new System.EventHandler(this.Modificar_toolStripMenuItem_Click);
            // 
            // eliminar_toolStripMenuItem
            // 
            this.eliminar_toolStripMenuItem.Name = "eliminar_toolStripMenuItem";
            this.eliminar_toolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.eliminar_toolStripMenuItem.Text = "Eliminar";
            this.eliminar_toolStripMenuItem.Click += new System.EventHandler(this.Eliminar_toolStripMenuItem_Click);
            // 
            // botones_toolStrip
            // 
            this.botones_toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.botones_toolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.botones_toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestor_disp_toolStripButton,
            this.toolStripSeparator1,
            this.agregar_boton_toolStripButton,
            this.salir_toolStripButton});
            this.botones_toolStrip.Location = new System.Drawing.Point(0, 0);
            this.botones_toolStrip.Name = "botones_toolStrip";
            this.botones_toolStrip.Size = new System.Drawing.Size(688, 25);
            this.botones_toolStrip.TabIndex = 0;
            this.botones_toolStrip.Text = "toolStrip1";
            // 
            // gestor_disp_toolStripButton
            // 
            this.gestor_disp_toolStripButton.Mostrar_Tecla = true;
            this.gestor_disp_toolStripButton.Name = "gestor_disp_toolStripButton";
            this.gestor_disp_toolStripButton.Size = new System.Drawing.Size(156, 22);
            this.gestor_disp_toolStripButton.Tecla = System.Windows.Forms.Keys.F12;
            this.gestor_disp_toolStripButton.Text = "Gestor de Dispositivos (F12)";
            this.gestor_disp_toolStripButton.Texto = "Gestor de Dispositivos";
            this.gestor_disp_toolStripButton.Click += new System.EventHandler(this.Gestor_disp_toolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // agregar_boton_toolStripButton
            // 
            this.agregar_boton_toolStripButton.Mostrar_Tecla = true;
            this.agregar_boton_toolStripButton.Name = "agregar_boton_toolStripButton";
            this.agregar_boton_toolStripButton.Size = new System.Drawing.Size(111, 22);
            this.agregar_boton_toolStripButton.Tecla = System.Windows.Forms.Keys.F1;
            this.agregar_boton_toolStripButton.Text = "Agregar Boton (F1)";
            this.agregar_boton_toolStripButton.Texto = "Agregar Boton";
            this.agregar_boton_toolStripButton.Click += new System.EventHandler(this.Agregar_boton_toolStripButton_Click);
            // 
            // salir_toolStripButton
            // 
            this.salir_toolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.salir_toolStripButton.Mostrar_Tecla = true;
            this.salir_toolStripButton.Name = "salir_toolStripButton";
            this.salir_toolStripButton.Size = new System.Drawing.Size(61, 22);
            this.salir_toolStripButton.Tecla = System.Windows.Forms.Keys.Escape;
            this.salir_toolStripButton.Text = "Salir (Esc)";
            this.salir_toolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.salir_toolStripButton.Texto = "Salir";
            this.salir_toolStripButton.Click += new System.EventHandler(this.Salir_toolStripButton_Click);
            // 
            // plantilla_panel
            // 
            this.plantilla_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plantilla_panel.Location = new System.Drawing.Point(0, 25);
            this.plantilla_panel.Name = "plantilla_panel";
            this.plantilla_panel.Size = new System.Drawing.Size(688, 529);
            this.plantilla_panel.TabIndex = 1;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 554);
            this.Controls.Add(this.plantilla_panel);
            this.Controls.Add(this.botones_toolStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Principal";
            this.Text = "Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Principal_FormClosing);
            this.Shown += new System.EventHandler(this.Principal_Shown);
            this.menu_contextMenuStrip.ResumeLayout(false);
            this.botones_toolStrip.ResumeLayout(false);
            this.botones_toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.MessageForm principal_messageForm;

        private System.Windows.Forms.Panel plantilla_panel;
        private System.Windows.Forms.ContextMenuStrip menu_contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem duplicar_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificar_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminar_toolStripMenuItem;
        private System.Windows.Forms.ToolStrip botones_toolStrip;
        private System.Windows.Forms.ToolStripButton_Key gestor_disp_toolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton_Key agregar_boton_toolStripButton;
        private System.Windows.Forms.ToolStripButton_Key salir_toolStripButton;
    }
}