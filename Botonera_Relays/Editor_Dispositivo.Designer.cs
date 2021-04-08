
namespace Botonera_Relays
{
    partial class Editor_Dispositivo
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
            this.nombre_label = new System.Windows.Forms.Label();
            this.nombre_textBox = new System.Windows.Forms.TextBox();
            this.direccion_label = new System.Windows.Forms.Label();
            this.ip1_intBox = new System.Windows.Forms.IntBox();
            this.ip2_intBox = new System.Windows.Forms.IntBox();
            this.ip3_intBox = new System.Windows.Forms.IntBox();
            this.ip4_intBox = new System.Windows.Forms.IntBox();
            this.puerto_label = new System.Windows.Forms.Label();
            this.puerto_intBox = new System.Windows.Forms.IntBox();
            this.aceptar_button_Key = new System.Windows.Forms.Button_Key();
            this.SuspendLayout();
            // 
            // cancelar_button_Key
            // 
            this.cancelar_button_Key.Location = new System.Drawing.Point(248, 69);
            this.cancelar_button_Key.Margin = new System.Windows.Forms.Padding(4);
            this.cancelar_button_Key.Mostrar_Tecla = true;
            this.cancelar_button_Key.Name = "cancelar_button_Key";
            this.cancelar_button_Key.Size = new System.Drawing.Size(119, 28);
            this.cancelar_button_Key.TabIndex = 10;
            this.cancelar_button_Key.Tecla = System.Windows.Forms.Keys.Escape;
            this.cancelar_button_Key.Text = "Cancelar (Esc)";
            this.cancelar_button_Key.Texto = "Cancelar";
            this.cancelar_button_Key.UseVisualStyleBackColor = true;
            this.cancelar_button_Key.Click += new System.EventHandler(this.Boton_Cancelar);
            // 
            // nombre_label
            // 
            this.nombre_label.AutoSize = true;
            this.nombre_label.Location = new System.Drawing.Point(54, 15);
            this.nombre_label.Name = "nombre_label";
            this.nombre_label.Size = new System.Drawing.Size(60, 16);
            this.nombre_label.TabIndex = 0;
            this.nombre_label.Text = "Nombre:";
            // 
            // nombre_textBox
            // 
            this.nombre_textBox.Location = new System.Drawing.Point(120, 12);
            this.nombre_textBox.MaxLength = 32;
            this.nombre_textBox.Name = "nombre_textBox";
            this.nombre_textBox.Size = new System.Drawing.Size(247, 22);
            this.nombre_textBox.TabIndex = 1;
            // 
            // direccion_label
            // 
            this.direccion_label.AutoSize = true;
            this.direccion_label.Location = new System.Drawing.Point(12, 43);
            this.direccion_label.Name = "direccion_label";
            this.direccion_label.Size = new System.Drawing.Size(102, 16);
            this.direccion_label.TabIndex = 2;
            this.direccion_label.Text = "Dirección de IP:";
            // 
            // ip1_intBox
            // 
            this.ip1_intBox.BackColor = System.Drawing.SystemColors.Window;
            this.ip1_intBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ip1_intBox.Location = new System.Drawing.Point(120, 40);
            this.ip1_intBox.Maximo = 255;
            this.ip1_intBox.MaxLength = 3;
            this.ip1_intBox.Name = "ip1_intBox";
            this.ip1_intBox.Size = new System.Drawing.Size(29, 22);
            this.ip1_intBox.TabIndex = 3;
            this.ip1_intBox.Text = "192";
            this.ip1_intBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ip1_intBox.Valor = 192;
            // 
            // ip2_intBox
            // 
            this.ip2_intBox.BackColor = System.Drawing.SystemColors.Window;
            this.ip2_intBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ip2_intBox.Location = new System.Drawing.Point(155, 40);
            this.ip2_intBox.Maximo = 255;
            this.ip2_intBox.MaxLength = 3;
            this.ip2_intBox.Name = "ip2_intBox";
            this.ip2_intBox.Size = new System.Drawing.Size(29, 22);
            this.ip2_intBox.TabIndex = 4;
            this.ip2_intBox.Text = "168";
            this.ip2_intBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ip2_intBox.Valor = 168;
            // 
            // ip3_intBox
            // 
            this.ip3_intBox.BackColor = System.Drawing.SystemColors.Window;
            this.ip3_intBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ip3_intBox.Location = new System.Drawing.Point(190, 40);
            this.ip3_intBox.Maximo = 255;
            this.ip3_intBox.MaxLength = 3;
            this.ip3_intBox.Name = "ip3_intBox";
            this.ip3_intBox.Size = new System.Drawing.Size(29, 22);
            this.ip3_intBox.TabIndex = 5;
            this.ip3_intBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ip4_intBox
            // 
            this.ip4_intBox.BackColor = System.Drawing.SystemColors.Window;
            this.ip4_intBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ip4_intBox.Location = new System.Drawing.Point(225, 40);
            this.ip4_intBox.Maximo = 255;
            this.ip4_intBox.MaxLength = 3;
            this.ip4_intBox.Name = "ip4_intBox";
            this.ip4_intBox.Size = new System.Drawing.Size(29, 22);
            this.ip4_intBox.TabIndex = 6;
            this.ip4_intBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // puerto_label
            // 
            this.puerto_label.AutoSize = true;
            this.puerto_label.Location = new System.Drawing.Point(260, 43);
            this.puerto_label.Name = "puerto_label";
            this.puerto_label.Size = new System.Drawing.Size(50, 16);
            this.puerto_label.TabIndex = 7;
            this.puerto_label.Text = "Puerto:";
            // 
            // puerto_intBox
            // 
            this.puerto_intBox.BackColor = System.Drawing.SystemColors.Window;
            this.puerto_intBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.puerto_intBox.Location = new System.Drawing.Point(316, 40);
            this.puerto_intBox.Maximo = 65535;
            this.puerto_intBox.MaxLength = 3;
            this.puerto_intBox.Name = "puerto_intBox";
            this.puerto_intBox.Size = new System.Drawing.Size(51, 22);
            this.puerto_intBox.TabIndex = 8;
            this.puerto_intBox.Text = "8080";
            this.puerto_intBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.puerto_intBox.Valor = 8080;
            // 
            // aceptar_button_Key
            // 
            this.aceptar_button_Key.Location = new System.Drawing.Point(120, 69);
            this.aceptar_button_Key.Margin = new System.Windows.Forms.Padding(4);
            this.aceptar_button_Key.Mostrar_Tecla = true;
            this.aceptar_button_Key.Name = "aceptar_button_Key";
            this.aceptar_button_Key.Size = new System.Drawing.Size(120, 28);
            this.aceptar_button_Key.TabIndex = 9;
            this.aceptar_button_Key.Tecla = System.Windows.Forms.Keys.Return;
            this.aceptar_button_Key.Text = "Aceptar (Enter)";
            this.aceptar_button_Key.Texto = "Aceptar";
            this.aceptar_button_Key.UseVisualStyleBackColor = true;
            this.aceptar_button_Key.Click += new System.EventHandler(this.Boton_Aceptar);
            // 
            // Editor_Dispositivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 110);
            this.ControlBox = false;
            this.Controls.Add(this.cancelar_button_Key);
            this.Controls.Add(this.aceptar_button_Key);
            this.Controls.Add(this.puerto_intBox);
            this.Controls.Add(this.puerto_label);
            this.Controls.Add(this.ip4_intBox);
            this.Controls.Add(this.ip3_intBox);
            this.Controls.Add(this.ip2_intBox);
            this.Controls.Add(this.ip1_intBox);
            this.Controls.Add(this.direccion_label);
            this.Controls.Add(this.nombre_textBox);
            this.Controls.Add(this.nombre_label);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Editor_Dispositivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor Dispositivo";
            this.Shown += new System.EventHandler(this.Leer_Modulo);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button_Key cancelar_button_Key;
        private System.Windows.Forms.Label nombre_label;
        private System.Windows.Forms.TextBox nombre_textBox;
        private System.Windows.Forms.Label direccion_label;
        private System.Windows.Forms.IntBox ip1_intBox;
        private System.Windows.Forms.IntBox ip2_intBox;
        private System.Windows.Forms.IntBox ip3_intBox;
        private System.Windows.Forms.IntBox ip4_intBox;
        private System.Windows.Forms.Label puerto_label;
        private System.Windows.Forms.IntBox puerto_intBox;
        private System.Windows.Forms.Button_Key aceptar_button_Key;
    }
}