
namespace Botonera_Relays
{
    partial class Editor_Boton_Relay
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
            this.cancelar_button_Key = new System.Windows.Forms.Button_Key();
            this.dispositivo_label = new System.Windows.Forms.Label();
            this.aceptar_button_Key = new System.Windows.Forms.Button_Key();
            this.tamanio_label = new System.Windows.Forms.Label();
            this.alto_intBox = new System.Windows.Forms.IntBox();
            this.ancho_intBox = new System.Windows.Forms.IntBox();
            this.x_label = new System.Windows.Forms.Label();
            this.posicion_label = new System.Windows.Forms.Label();
            this.sep_label = new System.Windows.Forms.Label();
            this.y_intBox = new System.Windows.Forms.IntBox();
            this.x_intBox = new System.Windows.Forms.IntBox();
            this.dispositivo_comboBox = new System.Windows.Forms.ComboBox();
            this.relay_label = new System.Windows.Forms.Label();
            this.relay_comboBox = new System.Windows.Forms.ComboBox();
            this.demo_flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.demo_boton_Relay = new System.Windows.Forms.Boton_Relay();
            this.nombre_label = new System.Windows.Forms.Label();
            this.nombre_textBox = new System.Windows.Forms.TextBox();
            this.activado_estado_Boton_Control = new System.Windows.Forms.Estado_Boton_Control();
            this.desactivado_estado_Boton_Control = new System.Windows.Forms.Estado_Boton_Control();
            this.demo_flowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelar_button_Key
            // 
            this.cancelar_button_Key.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelar_button_Key.Location = new System.Drawing.Point(675, 410);
            this.cancelar_button_Key.Margin = new System.Windows.Forms.Padding(4);
            this.cancelar_button_Key.Mostrar_Tecla = true;
            this.cancelar_button_Key.Name = "cancelar_button_Key";
            this.cancelar_button_Key.Size = new System.Drawing.Size(119, 28);
            this.cancelar_button_Key.TabIndex = 18;
            this.cancelar_button_Key.Tecla = System.Windows.Forms.Keys.Escape;
            this.cancelar_button_Key.Text = "Cancelar (Esc)";
            this.cancelar_button_Key.Texto = "Cancelar";
            this.cancelar_button_Key.UseVisualStyleBackColor = true;
            this.cancelar_button_Key.Click += new System.EventHandler(this.Boton_Cancelar);
            // 
            // dispositivo_label
            // 
            this.dispositivo_label.AutoSize = true;
            this.dispositivo_label.Location = new System.Drawing.Point(51, 43);
            this.dispositivo_label.Name = "dispositivo_label";
            this.dispositivo_label.Size = new System.Drawing.Size(78, 16);
            this.dispositivo_label.TabIndex = 2;
            this.dispositivo_label.Text = "Dispositivo:";
            // 
            // aceptar_button_Key
            // 
            this.aceptar_button_Key.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.aceptar_button_Key.Location = new System.Drawing.Point(550, 410);
            this.aceptar_button_Key.Margin = new System.Windows.Forms.Padding(4);
            this.aceptar_button_Key.Mostrar_Tecla = true;
            this.aceptar_button_Key.Name = "aceptar_button_Key";
            this.aceptar_button_Key.Size = new System.Drawing.Size(120, 28);
            this.aceptar_button_Key.TabIndex = 17;
            this.aceptar_button_Key.Tecla = System.Windows.Forms.Keys.Return;
            this.aceptar_button_Key.Text = "Aceptar (Enter)";
            this.aceptar_button_Key.Texto = "Aceptar";
            this.aceptar_button_Key.UseVisualStyleBackColor = true;
            this.aceptar_button_Key.Click += new System.EventHandler(this.Boton_Aceptar);
            // 
            // tamanio_label
            // 
            this.tamanio_label.AutoSize = true;
            this.tamanio_label.Location = new System.Drawing.Point(67, 103);
            this.tamanio_label.Name = "tamanio_label";
            this.tamanio_label.Size = new System.Drawing.Size(62, 16);
            this.tamanio_label.TabIndex = 6;
            this.tamanio_label.Text = "Tamaño:";
            // 
            // alto_intBox
            // 
            this.alto_intBox.BackColor = System.Drawing.SystemColors.Window;
            this.alto_intBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.alto_intBox.Location = new System.Drawing.Point(188, 100);
            this.alto_intBox.Maximo = 999;
            this.alto_intBox.MaxLength = 3;
            this.alto_intBox.Minimo = 10;
            this.alto_intBox.Name = "alto_intBox";
            this.alto_intBox.Obligatorio = true;
            this.alto_intBox.Size = new System.Drawing.Size(29, 22);
            this.alto_intBox.TabIndex = 9;
            this.alto_intBox.Text = "100";
            this.alto_intBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.alto_intBox.Valor = 100;
            this.alto_intBox.TextChanged += new System.EventHandler(this.Tamanio_TextChanged);
            // 
            // ancho_intBox
            // 
            this.ancho_intBox.BackColor = System.Drawing.SystemColors.Window;
            this.ancho_intBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ancho_intBox.Location = new System.Drawing.Point(135, 100);
            this.ancho_intBox.Maximo = 999;
            this.ancho_intBox.MaxLength = 3;
            this.ancho_intBox.Minimo = 10;
            this.ancho_intBox.Name = "ancho_intBox";
            this.ancho_intBox.Obligatorio = true;
            this.ancho_intBox.Size = new System.Drawing.Size(29, 22);
            this.ancho_intBox.TabIndex = 7;
            this.ancho_intBox.Text = "100";
            this.ancho_intBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ancho_intBox.Valor = 100;
            this.ancho_intBox.TextChanged += new System.EventHandler(this.Tamanio_TextChanged);
            // 
            // x_label
            // 
            this.x_label.AutoSize = true;
            this.x_label.Location = new System.Drawing.Point(170, 103);
            this.x_label.Name = "x_label";
            this.x_label.Size = new System.Drawing.Size(14, 16);
            this.x_label.TabIndex = 8;
            this.x_label.Text = "x";
            // 
            // posicion_label
            // 
            this.posicion_label.AutoSize = true;
            this.posicion_label.Location = new System.Drawing.Point(57, 131);
            this.posicion_label.Name = "posicion_label";
            this.posicion_label.Size = new System.Drawing.Size(72, 16);
            this.posicion_label.TabIndex = 10;
            this.posicion_label.Text = "Posición x:";
            // 
            // sep_label
            // 
            this.sep_label.AutoSize = true;
            this.sep_label.Location = new System.Drawing.Point(185, 131);
            this.sep_label.Name = "sep_label";
            this.sep_label.Size = new System.Drawing.Size(18, 16);
            this.sep_label.TabIndex = 12;
            this.sep_label.Text = "y:";
            // 
            // y_intBox
            // 
            this.y_intBox.BackColor = System.Drawing.SystemColors.Window;
            this.y_intBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.y_intBox.Location = new System.Drawing.Point(209, 128);
            this.y_intBox.Maximo = 1080;
            this.y_intBox.MaxLength = 3;
            this.y_intBox.Name = "y_intBox";
            this.y_intBox.Obligatorio = true;
            this.y_intBox.Size = new System.Drawing.Size(44, 22);
            this.y_intBox.TabIndex = 13;
            this.y_intBox.Text = "0";
            this.y_intBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // x_intBox
            // 
            this.x_intBox.BackColor = System.Drawing.SystemColors.Window;
            this.x_intBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.x_intBox.Location = new System.Drawing.Point(135, 128);
            this.x_intBox.Maximo = 1920;
            this.x_intBox.MaxLength = 4;
            this.x_intBox.Name = "x_intBox";
            this.x_intBox.Obligatorio = true;
            this.x_intBox.Size = new System.Drawing.Size(44, 22);
            this.x_intBox.TabIndex = 11;
            this.x_intBox.Text = "0";
            this.x_intBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dispositivo_comboBox
            // 
            this.dispositivo_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dispositivo_comboBox.FormattingEnabled = true;
            this.dispositivo_comboBox.Location = new System.Drawing.Point(135, 40);
            this.dispositivo_comboBox.Name = "dispositivo_comboBox";
            this.dispositivo_comboBox.Size = new System.Drawing.Size(277, 24);
            this.dispositivo_comboBox.TabIndex = 3;
            // 
            // relay_label
            // 
            this.relay_label.AutoSize = true;
            this.relay_label.Location = new System.Drawing.Point(82, 73);
            this.relay_label.Name = "relay_label";
            this.relay_label.Size = new System.Drawing.Size(47, 16);
            this.relay_label.TabIndex = 4;
            this.relay_label.Text = "Relay:";
            // 
            // relay_comboBox
            // 
            this.relay_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.relay_comboBox.FormattingEnabled = true;
            this.relay_comboBox.Location = new System.Drawing.Point(135, 70);
            this.relay_comboBox.Name = "relay_comboBox";
            this.relay_comboBox.Size = new System.Drawing.Size(120, 24);
            this.relay_comboBox.TabIndex = 5;
            // 
            // demo_flowLayoutPanel
            // 
            this.demo_flowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.demo_flowLayoutPanel.BackColor = System.Drawing.Color.Black;
            this.demo_flowLayoutPanel.Controls.Add(this.demo_boton_Relay);
            this.demo_flowLayoutPanel.Location = new System.Drawing.Point(421, 12);
            this.demo_flowLayoutPanel.Name = "demo_flowLayoutPanel";
            this.demo_flowLayoutPanel.Padding = new System.Windows.Forms.Padding(10);
            this.demo_flowLayoutPanel.Size = new System.Drawing.Size(374, 391);
            this.demo_flowLayoutPanel.TabIndex = 16;
            // 
            // demo_boton_Relay
            // 
            this.demo_boton_Relay.BackColor = System.Drawing.Color.Maroon;
            this.demo_boton_Relay.ForeColor = System.Drawing.Color.DarkGray;
            this.demo_boton_Relay.Location = new System.Drawing.Point(13, 13);
            this.demo_boton_Relay.Name = "demo_boton_Relay";
            this.demo_boton_Relay.Size = new System.Drawing.Size(100, 100);
            this.demo_boton_Relay.TabIndex = 0;
            this.demo_boton_Relay.Text = "ERROR";
            this.demo_boton_Relay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.demo_boton_Relay.Texto = "ERROR";
            this.demo_boton_Relay.UseVisualStyleBackColor = true;
            // 
            // nombre_label
            // 
            this.nombre_label.AutoSize = true;
            this.nombre_label.Location = new System.Drawing.Point(12, 15);
            this.nombre_label.Name = "nombre_label";
            this.nombre_label.Size = new System.Drawing.Size(117, 16);
            this.nombre_label.TabIndex = 0;
            this.nombre_label.Text = "Nombre de Boton:";
            // 
            // nombre_textBox
            // 
            this.nombre_textBox.Location = new System.Drawing.Point(135, 12);
            this.nombre_textBox.MaxLength = 32;
            this.nombre_textBox.Name = "nombre_textBox";
            this.nombre_textBox.Size = new System.Drawing.Size(277, 22);
            this.nombre_textBox.TabIndex = 1;
            // 
            // activado_estado_Boton_Control
            // 
            this.activado_estado_Boton_Control.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activado_estado_Boton_Control.Location = new System.Drawing.Point(12, 302);
            this.activado_estado_Boton_Control.Name = "activado_estado_Boton_Control";
            this.activado_estado_Boton_Control.Size = new System.Drawing.Size(400, 140);
            this.activado_estado_Boton_Control.TabIndex = 15;
            this.activado_estado_Boton_Control.Titulo = "ACTIVADO";
            this.activado_estado_Boton_Control.Cambio_Estado += new System.EventHandler(this.Activado_Cambio_Estado);
            // 
            // desactivado_estado_Boton_Control
            // 
            this.desactivado_estado_Boton_Control.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desactivado_estado_Boton_Control.Location = new System.Drawing.Point(15, 156);
            this.desactivado_estado_Boton_Control.Name = "desactivado_estado_Boton_Control";
            this.desactivado_estado_Boton_Control.Size = new System.Drawing.Size(400, 140);
            this.desactivado_estado_Boton_Control.TabIndex = 14;
            this.desactivado_estado_Boton_Control.Titulo = "DESACTIVADO";
            this.desactivado_estado_Boton_Control.Cambio_Estado += new System.EventHandler(this.Desactivado_Cambio_Estado);
            // 
            // Editor_Boton_Relay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 451);
            this.ControlBox = false;
            this.Controls.Add(this.cancelar_button_Key);
            this.Controls.Add(this.aceptar_button_Key);
            this.Controls.Add(this.demo_flowLayoutPanel);
            this.Controls.Add(this.activado_estado_Boton_Control);
            this.Controls.Add(this.desactivado_estado_Boton_Control);
            this.Controls.Add(this.y_intBox);
            this.Controls.Add(this.sep_label);
            this.Controls.Add(this.x_intBox);
            this.Controls.Add(this.posicion_label);
            this.Controls.Add(this.alto_intBox);
            this.Controls.Add(this.x_label);
            this.Controls.Add(this.ancho_intBox);
            this.Controls.Add(this.tamanio_label);
            this.Controls.Add(this.relay_comboBox);
            this.Controls.Add(this.relay_label);
            this.Controls.Add(this.dispositivo_comboBox);
            this.Controls.Add(this.dispositivo_label);
            this.Controls.Add(this.nombre_textBox);
            this.Controls.Add(this.nombre_label);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Editor_Boton_Relay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor Boton Relay";
            this.Shown += new System.EventHandler(this.Leer_Modulo);
            this.demo_flowLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button_Key cancelar_button_Key;
        private System.Windows.Forms.Label dispositivo_label;
        private System.Windows.Forms.Button_Key aceptar_button_Key;
        private System.Windows.Forms.Label tamanio_label;
        private System.Windows.Forms.IntBox alto_intBox;
        private System.Windows.Forms.IntBox ancho_intBox;
        private System.Windows.Forms.Label x_label;
        private System.Windows.Forms.Label posicion_label;
        private System.Windows.Forms.Label sep_label;
        private System.Windows.Forms.IntBox y_intBox;
        private System.Windows.Forms.IntBox x_intBox;
        private System.Windows.Forms.ComboBox dispositivo_comboBox;
        private System.Windows.Forms.Label relay_label;
        private System.Windows.Forms.ComboBox relay_comboBox;
        private System.Windows.Forms.FlowLayoutPanel demo_flowLayoutPanel;
        private System.Windows.Forms.Boton_Relay demo_boton_Relay;
        private System.Windows.Forms.Estado_Boton_Control desactivado_estado_Boton_Control;
        private System.Windows.Forms.Estado_Boton_Control activado_estado_Boton_Control;
        private System.Windows.Forms.Label nombre_label;
        private System.Windows.Forms.TextBox nombre_textBox;
    }
}