
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
            this.nombre_desactivado_label = new System.Windows.Forms.Label();
            this.nombre_desactivado_textBox = new System.Windows.Forms.TextBox();
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
            this.nombre_activado_textBox = new System.Windows.Forms.TextBox();
            this.nombre_activado_label = new System.Windows.Forms.Label();
            this.dispositivo_comboBox = new System.Windows.Forms.ComboBox();
            this.relay_label = new System.Windows.Forms.Label();
            this.relay_comboBox = new System.Windows.Forms.ComboBox();
            this.fondo_desactivado_colorComboBox = new System.Windows.Forms.ColorComboBox();
            this.fondo_desactivado_label = new System.Windows.Forms.Label();
            this.imagen_desactivado_comboBox = new System.Windows.Forms.ComboBox();
            this.imagen_desactivado_label = new System.Windows.Forms.Label();
            this.demo_flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.imagen_activado_label = new System.Windows.Forms.Label();
            this.imagen_activado_comboBox = new System.Windows.Forms.ComboBox();
            this.fondo_activado_label = new System.Windows.Forms.Label();
            this.fondo_activado_colorComboBox = new System.Windows.Forms.ColorComboBox();
            this.desactivado_groupBox = new System.Windows.Forms.GroupBox();
            this.activado_groupBox = new System.Windows.Forms.GroupBox();
            this.demo_boton_Relay = new System.Windows.Forms.Boton_Relay();
            this.demo_flowLayoutPanel.SuspendLayout();
            this.desactivado_groupBox.SuspendLayout();
            this.activado_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelar_button_Key
            // 
            this.cancelar_button_Key.Location = new System.Drawing.Point(274, 320);
            this.cancelar_button_Key.Margin = new System.Windows.Forms.Padding(4);
            this.cancelar_button_Key.Mostrar_Tecla = true;
            this.cancelar_button_Key.Name = "cancelar_button_Key";
            this.cancelar_button_Key.Size = new System.Drawing.Size(119, 28);
            this.cancelar_button_Key.TabIndex = 16;
            this.cancelar_button_Key.Tecla = System.Windows.Forms.Keys.Escape;
            this.cancelar_button_Key.Text = "Cancelar (Esc)";
            this.cancelar_button_Key.Texto = "Cancelar";
            this.cancelar_button_Key.UseVisualStyleBackColor = true;
            this.cancelar_button_Key.Click += new System.EventHandler(this.Boton_Cancelar);
            // 
            // nombre_desactivado_label
            // 
            this.nombre_desactivado_label.AutoSize = true;
            this.nombre_desactivado_label.Location = new System.Drawing.Point(26, 24);
            this.nombre_desactivado_label.Name = "nombre_desactivado_label";
            this.nombre_desactivado_label.Size = new System.Drawing.Size(60, 16);
            this.nombre_desactivado_label.TabIndex = 0;
            this.nombre_desactivado_label.Text = "Nombre:";
            // 
            // nombre_desactivado_textBox
            // 
            this.nombre_desactivado_textBox.Location = new System.Drawing.Point(147, 21);
            this.nombre_desactivado_textBox.MaxLength = 32;
            this.nombre_desactivado_textBox.Name = "nombre_desactivado_textBox";
            this.nombre_desactivado_textBox.Size = new System.Drawing.Size(202, 22);
            this.nombre_desactivado_textBox.TabIndex = 1;
            this.nombre_desactivado_textBox.TextChanged += new System.EventHandler(this.Desactivado_Changed);
            // 
            // dispositivo_label
            // 
            this.dispositivo_label.AutoSize = true;
            this.dispositivo_label.Location = new System.Drawing.Point(72, 15);
            this.dispositivo_label.Name = "dispositivo_label";
            this.dispositivo_label.Size = new System.Drawing.Size(78, 16);
            this.dispositivo_label.TabIndex = 0;
            this.dispositivo_label.Text = "Dispositivo:";
            // 
            // aceptar_button_Key
            // 
            this.aceptar_button_Key.Location = new System.Drawing.Point(146, 320);
            this.aceptar_button_Key.Margin = new System.Windows.Forms.Padding(4);
            this.aceptar_button_Key.Mostrar_Tecla = true;
            this.aceptar_button_Key.Name = "aceptar_button_Key";
            this.aceptar_button_Key.Size = new System.Drawing.Size(120, 28);
            this.aceptar_button_Key.TabIndex = 15;
            this.aceptar_button_Key.Tecla = System.Windows.Forms.Keys.Return;
            this.aceptar_button_Key.Text = "Aceptar (Enter)";
            this.aceptar_button_Key.Texto = "Aceptar";
            this.aceptar_button_Key.UseVisualStyleBackColor = true;
            this.aceptar_button_Key.Click += new System.EventHandler(this.Boton_Aceptar);
            // 
            // tamanio_label
            // 
            this.tamanio_label.AutoSize = true;
            this.tamanio_label.Location = new System.Drawing.Point(89, 45);
            this.tamanio_label.Name = "tamanio_label";
            this.tamanio_label.Size = new System.Drawing.Size(62, 16);
            this.tamanio_label.TabIndex = 4;
            this.tamanio_label.Text = "Tamaño:";
            // 
            // alto_intBox
            // 
            this.alto_intBox.BackColor = System.Drawing.SystemColors.Window;
            this.alto_intBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.alto_intBox.Location = new System.Drawing.Point(211, 42);
            this.alto_intBox.Maximo = 999;
            this.alto_intBox.MaxLength = 3;
            this.alto_intBox.Minimo = 10;
            this.alto_intBox.Name = "alto_intBox";
            this.alto_intBox.Obligatorio = true;
            this.alto_intBox.Size = new System.Drawing.Size(29, 22);
            this.alto_intBox.TabIndex = 7;
            this.alto_intBox.Text = "100";
            this.alto_intBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.alto_intBox.Valor = 100;
            this.alto_intBox.TextChanged += new System.EventHandler(this.Tamanio_TextChanged);
            // 
            // ancho_intBox
            // 
            this.ancho_intBox.BackColor = System.Drawing.SystemColors.Window;
            this.ancho_intBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ancho_intBox.Location = new System.Drawing.Point(156, 42);
            this.ancho_intBox.Maximo = 999;
            this.ancho_intBox.MaxLength = 3;
            this.ancho_intBox.Minimo = 10;
            this.ancho_intBox.Name = "ancho_intBox";
            this.ancho_intBox.Obligatorio = true;
            this.ancho_intBox.Size = new System.Drawing.Size(29, 22);
            this.ancho_intBox.TabIndex = 5;
            this.ancho_intBox.Text = "100";
            this.ancho_intBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ancho_intBox.Valor = 100;
            this.ancho_intBox.TextChanged += new System.EventHandler(this.Tamanio_TextChanged);
            // 
            // x_label
            // 
            this.x_label.AutoSize = true;
            this.x_label.Location = new System.Drawing.Point(191, 45);
            this.x_label.Name = "x_label";
            this.x_label.Size = new System.Drawing.Size(14, 16);
            this.x_label.TabIndex = 6;
            this.x_label.Text = "x";
            // 
            // posicion_label
            // 
            this.posicion_label.AutoSize = true;
            this.posicion_label.Location = new System.Drawing.Point(421, 45);
            this.posicion_label.Name = "posicion_label";
            this.posicion_label.Size = new System.Drawing.Size(63, 16);
            this.posicion_label.TabIndex = 8;
            this.posicion_label.Text = "Posición:";
            // 
            // sep_label
            // 
            this.sep_label.AutoSize = true;
            this.sep_label.Location = new System.Drawing.Point(540, 45);
            this.sep_label.Name = "sep_label";
            this.sep_label.Size = new System.Drawing.Size(11, 16);
            this.sep_label.TabIndex = 10;
            this.sep_label.Text = ":";
            // 
            // y_intBox
            // 
            this.y_intBox.BackColor = System.Drawing.SystemColors.Window;
            this.y_intBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.y_intBox.Location = new System.Drawing.Point(557, 42);
            this.y_intBox.Maximo = 1080;
            this.y_intBox.MaxLength = 3;
            this.y_intBox.Name = "y_intBox";
            this.y_intBox.Obligatorio = true;
            this.y_intBox.Size = new System.Drawing.Size(44, 22);
            this.y_intBox.TabIndex = 11;
            this.y_intBox.Text = "0";
            this.y_intBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // x_intBox
            // 
            this.x_intBox.BackColor = System.Drawing.SystemColors.Window;
            this.x_intBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.x_intBox.Location = new System.Drawing.Point(490, 42);
            this.x_intBox.Maximo = 1920;
            this.x_intBox.MaxLength = 4;
            this.x_intBox.Name = "x_intBox";
            this.x_intBox.Obligatorio = true;
            this.x_intBox.Size = new System.Drawing.Size(44, 22);
            this.x_intBox.TabIndex = 9;
            this.x_intBox.Text = "0";
            this.x_intBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nombre_activado_textBox
            // 
            this.nombre_activado_textBox.Location = new System.Drawing.Point(136, 21);
            this.nombre_activado_textBox.MaxLength = 32;
            this.nombre_activado_textBox.Name = "nombre_activado_textBox";
            this.nombre_activado_textBox.Size = new System.Drawing.Size(202, 22);
            this.nombre_activado_textBox.TabIndex = 1;
            this.nombre_activado_textBox.TextChanged += new System.EventHandler(this.Activado_Changed);
            // 
            // nombre_activado_label
            // 
            this.nombre_activado_label.AutoSize = true;
            this.nombre_activado_label.Location = new System.Drawing.Point(67, 27);
            this.nombre_activado_label.Name = "nombre_activado_label";
            this.nombre_activado_label.Size = new System.Drawing.Size(60, 16);
            this.nombre_activado_label.TabIndex = 0;
            this.nombre_activado_label.Text = "Nombre:";
            // 
            // dispositivo_comboBox
            // 
            this.dispositivo_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dispositivo_comboBox.FormattingEnabled = true;
            this.dispositivo_comboBox.Location = new System.Drawing.Point(156, 12);
            this.dispositivo_comboBox.Name = "dispositivo_comboBox";
            this.dispositivo_comboBox.Size = new System.Drawing.Size(202, 24);
            this.dispositivo_comboBox.TabIndex = 1;
            // 
            // relay_label
            // 
            this.relay_label.AutoSize = true;
            this.relay_label.Location = new System.Drawing.Point(437, 15);
            this.relay_label.Name = "relay_label";
            this.relay_label.Size = new System.Drawing.Size(47, 16);
            this.relay_label.TabIndex = 2;
            this.relay_label.Text = "Relay:";
            // 
            // relay_comboBox
            // 
            this.relay_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.relay_comboBox.FormattingEnabled = true;
            this.relay_comboBox.Location = new System.Drawing.Point(490, 12);
            this.relay_comboBox.Name = "relay_comboBox";
            this.relay_comboBox.Size = new System.Drawing.Size(202, 24);
            this.relay_comboBox.TabIndex = 3;
            // 
            // fondo_desactivado_colorComboBox
            // 
            this.fondo_desactivado_colorComboBox.Color_Seleccionado = System.Drawing.Color.Empty;
            this.fondo_desactivado_colorComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fondo_desactivado_colorComboBox.Location = new System.Drawing.Point(147, 49);
            this.fondo_desactivado_colorComboBox.Name = "fondo_desactivado_colorComboBox";
            this.fondo_desactivado_colorComboBox.Size = new System.Drawing.Size(202, 24);
            this.fondo_desactivado_colorComboBox.TabIndex = 3;
            this.fondo_desactivado_colorComboBox.Color_Cambio += new System.EventHandler(this.Desactivado_Changed);
            // 
            // fondo_desactivado_label
            // 
            this.fondo_desactivado_label.AutoSize = true;
            this.fondo_desactivado_label.Location = new System.Drawing.Point(37, 52);
            this.fondo_desactivado_label.Name = "fondo_desactivado_label";
            this.fondo_desactivado_label.Size = new System.Drawing.Size(104, 16);
            this.fondo_desactivado_label.TabIndex = 2;
            this.fondo_desactivado_label.Text = "Color de Fondo:";
            // 
            // imagen_desactivado_comboBox
            // 
            this.imagen_desactivado_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.imagen_desactivado_comboBox.FormattingEnabled = true;
            this.imagen_desactivado_comboBox.Location = new System.Drawing.Point(147, 79);
            this.imagen_desactivado_comboBox.Name = "imagen_desactivado_comboBox";
            this.imagen_desactivado_comboBox.Size = new System.Drawing.Size(202, 24);
            this.imagen_desactivado_comboBox.TabIndex = 5;
            this.imagen_desactivado_comboBox.SelectedIndexChanged += new System.EventHandler(this.Desactivado_Changed);
            // 
            // imagen_desactivado_label
            // 
            this.imagen_desactivado_label.AutoSize = true;
            this.imagen_desactivado_label.Location = new System.Drawing.Point(85, 82);
            this.imagen_desactivado_label.Name = "imagen_desactivado_label";
            this.imagen_desactivado_label.Size = new System.Drawing.Size(56, 16);
            this.imagen_desactivado_label.TabIndex = 4;
            this.imagen_desactivado_label.Text = "Imagen:";
            // 
            // demo_flowLayoutPanel
            // 
            this.demo_flowLayoutPanel.BackColor = System.Drawing.Color.Black;
            this.demo_flowLayoutPanel.Controls.Add(this.demo_boton_Relay);
            this.demo_flowLayoutPanel.Location = new System.Drawing.Point(400, 83);
            this.demo_flowLayoutPanel.Name = "demo_flowLayoutPanel";
            this.demo_flowLayoutPanel.Padding = new System.Windows.Forms.Padding(10);
            this.demo_flowLayoutPanel.Size = new System.Drawing.Size(413, 378);
            this.demo_flowLayoutPanel.TabIndex = 14;
            // 
            // imagen_activado_label
            // 
            this.imagen_activado_label.AutoSize = true;
            this.imagen_activado_label.Location = new System.Drawing.Point(74, 87);
            this.imagen_activado_label.Name = "imagen_activado_label";
            this.imagen_activado_label.Size = new System.Drawing.Size(56, 16);
            this.imagen_activado_label.TabIndex = 4;
            this.imagen_activado_label.Text = "Imagen:";
            // 
            // imagen_activado_comboBox
            // 
            this.imagen_activado_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.imagen_activado_comboBox.FormattingEnabled = true;
            this.imagen_activado_comboBox.Location = new System.Drawing.Point(136, 79);
            this.imagen_activado_comboBox.Name = "imagen_activado_comboBox";
            this.imagen_activado_comboBox.Size = new System.Drawing.Size(202, 24);
            this.imagen_activado_comboBox.TabIndex = 5;
            this.imagen_activado_comboBox.SelectedIndexChanged += new System.EventHandler(this.Activado_Changed);
            // 
            // fondo_activado_label
            // 
            this.fondo_activado_label.AutoSize = true;
            this.fondo_activado_label.Location = new System.Drawing.Point(26, 52);
            this.fondo_activado_label.Name = "fondo_activado_label";
            this.fondo_activado_label.Size = new System.Drawing.Size(104, 16);
            this.fondo_activado_label.TabIndex = 2;
            this.fondo_activado_label.Text = "Color de Fondo:";
            // 
            // fondo_activado_colorComboBox
            // 
            this.fondo_activado_colorComboBox.Color_Seleccionado = System.Drawing.Color.Empty;
            this.fondo_activado_colorComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fondo_activado_colorComboBox.Location = new System.Drawing.Point(136, 49);
            this.fondo_activado_colorComboBox.Name = "fondo_activado_colorComboBox";
            this.fondo_activado_colorComboBox.Size = new System.Drawing.Size(202, 24);
            this.fondo_activado_colorComboBox.TabIndex = 3;
            this.fondo_activado_colorComboBox.Color_Cambio += new System.EventHandler(this.Activado_Changed);
            // 
            // desactivado_groupBox
            // 
            this.desactivado_groupBox.Controls.Add(this.imagen_desactivado_comboBox);
            this.desactivado_groupBox.Controls.Add(this.imagen_desactivado_label);
            this.desactivado_groupBox.Controls.Add(this.fondo_desactivado_colorComboBox);
            this.desactivado_groupBox.Controls.Add(this.fondo_desactivado_label);
            this.desactivado_groupBox.Controls.Add(this.nombre_desactivado_label);
            this.desactivado_groupBox.Controls.Add(this.nombre_desactivado_textBox);
            this.desactivado_groupBox.Location = new System.Drawing.Point(26, 83);
            this.desactivado_groupBox.Name = "desactivado_groupBox";
            this.desactivado_groupBox.Size = new System.Drawing.Size(355, 112);
            this.desactivado_groupBox.TabIndex = 12;
            this.desactivado_groupBox.TabStop = false;
            this.desactivado_groupBox.Text = "Desactivado";
            // 
            // activado_groupBox
            // 
            this.activado_groupBox.Controls.Add(this.imagen_activado_comboBox);
            this.activado_groupBox.Controls.Add(this.imagen_activado_label);
            this.activado_groupBox.Controls.Add(this.fondo_activado_colorComboBox);
            this.activado_groupBox.Controls.Add(this.fondo_activado_label);
            this.activado_groupBox.Controls.Add(this.nombre_activado_textBox);
            this.activado_groupBox.Controls.Add(this.nombre_activado_label);
            this.activado_groupBox.Location = new System.Drawing.Point(26, 201);
            this.activado_groupBox.Name = "activado_groupBox";
            this.activado_groupBox.Size = new System.Drawing.Size(355, 112);
            this.activado_groupBox.TabIndex = 13;
            this.activado_groupBox.TabStop = false;
            this.activado_groupBox.Text = "Activado";
            // 
            // demo_boton_Relay
            // 
            this.demo_boton_Relay.Location = new System.Drawing.Point(13, 13);
            this.demo_boton_Relay.Name = "demo_boton_Relay";
            this.demo_boton_Relay.Size = new System.Drawing.Size(100, 100);
            this.demo_boton_Relay.TabIndex = 0;
            this.demo_boton_Relay.Texto = "Activado";
            this.demo_boton_Relay.UseVisualStyleBackColor = true;
            // 
            // Editor_Boton_Relay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 492);
            this.ControlBox = false;
            this.Controls.Add(this.cancelar_button_Key);
            this.Controls.Add(this.aceptar_button_Key);
            this.Controls.Add(this.demo_flowLayoutPanel);
            this.Controls.Add(this.activado_groupBox);
            this.Controls.Add(this.desactivado_groupBox);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Editor_Boton_Relay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor Boton Relay";
            this.Shown += new System.EventHandler(this.Leer_Modulo);
            this.demo_flowLayoutPanel.ResumeLayout(false);
            this.desactivado_groupBox.ResumeLayout(false);
            this.desactivado_groupBox.PerformLayout();
            this.activado_groupBox.ResumeLayout(false);
            this.activado_groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button_Key cancelar_button_Key;
        private System.Windows.Forms.Label nombre_desactivado_label;
        private System.Windows.Forms.TextBox nombre_desactivado_textBox;
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
        private System.Windows.Forms.TextBox nombre_activado_textBox;
        private System.Windows.Forms.Label nombre_activado_label;
        private System.Windows.Forms.ComboBox dispositivo_comboBox;
        private System.Windows.Forms.Label relay_label;
        private System.Windows.Forms.ComboBox relay_comboBox;
        private System.Windows.Forms.ColorComboBox fondo_desactivado_colorComboBox;
        private System.Windows.Forms.Label fondo_desactivado_label;
        private System.Windows.Forms.ComboBox imagen_desactivado_comboBox;
        private System.Windows.Forms.Label imagen_desactivado_label;
        private System.Windows.Forms.FlowLayoutPanel demo_flowLayoutPanel;
        private System.Windows.Forms.Boton_Relay demo_boton_Relay;
        private System.Windows.Forms.Label imagen_activado_label;
        private System.Windows.Forms.ComboBox imagen_activado_comboBox;
        private System.Windows.Forms.Label fondo_activado_label;
        private System.Windows.Forms.ColorComboBox fondo_activado_colorComboBox;
        private System.Windows.Forms.GroupBox desactivado_groupBox;
        private System.Windows.Forms.GroupBox activado_groupBox;
    }
}