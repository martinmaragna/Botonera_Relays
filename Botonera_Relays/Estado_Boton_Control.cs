using System.ComponentModel;
using System.Drawing;
using System.IO;

namespace System.Windows.Forms
{
    public partial class Estado_Boton_Control : UserControl
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grupo_groupBox = new System.Windows.Forms.GroupBox();
            this.texto_colorComboBox = new System.Windows.Forms.ColorComboBox();
            this.texto_label = new System.Windows.Forms.Label();
            this.fondo_colorComboBox = new System.Windows.Forms.ColorComboBox();
            this.fondo_label = new System.Windows.Forms.Label();
            this.imagen_comboBox = new System.Windows.Forms.ComboBox();
            this.imagen_label = new System.Windows.Forms.Label();
            this.titulo_textBox = new System.Windows.Forms.TextBox();
            this.titulo_label = new System.Windows.Forms.Label();
            this.grupo_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // grupo_groupBox
            // 
            this.grupo_groupBox.Controls.Add(this.texto_colorComboBox);
            this.grupo_groupBox.Controls.Add(this.texto_label);
            this.grupo_groupBox.Controls.Add(this.fondo_colorComboBox);
            this.grupo_groupBox.Controls.Add(this.fondo_label);
            this.grupo_groupBox.Controls.Add(this.imagen_comboBox);
            this.grupo_groupBox.Controls.Add(this.imagen_label);
            this.grupo_groupBox.Controls.Add(this.titulo_textBox);
            this.grupo_groupBox.Controls.Add(this.titulo_label);
            this.grupo_groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grupo_groupBox.Location = new System.Drawing.Point(0, 0);
            this.grupo_groupBox.Name = "grupo_groupBox";
            this.grupo_groupBox.Size = new System.Drawing.Size(400, 140);
            this.grupo_groupBox.TabIndex = 0;
            this.grupo_groupBox.TabStop = false;
            // 
            // texto_colorComboBox
            // 
            this.texto_colorComboBox.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right);
            this.texto_colorComboBox.Color_Seleccionado = System.Drawing.Color.Empty;
            this.texto_colorComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.texto_colorComboBox.Location = new System.Drawing.Point(116, 108);
            this.texto_colorComboBox.Mostrar_Boton = false;
            this.texto_colorComboBox.Name = "texto_colorComboBox";
            this.texto_colorComboBox.Permitir_Color_Personalizado = false;
            this.texto_colorComboBox.Permitir_Color_Sistema = false;
            this.texto_colorComboBox.Permitir_Color_Transparente = false;
            this.texto_colorComboBox.Size = new System.Drawing.Size(278, 24);
            this.texto_colorComboBox.TabIndex = 7;
            this.texto_colorComboBox.Color_Cambio += new System.EventHandler(this.Forzar_Cambio_Estado);
            // 
            // texto_label
            // 
            this.texto_label.AutoSize = true;
            this.texto_label.Location = new System.Drawing.Point(11, 116);
            this.texto_label.Name = "texto_label";
            this.texto_label.Size = new System.Drawing.Size(99, 16);
            this.texto_label.TabIndex = 6;
            this.texto_label.Text = "Color de Texto:";
            // 
            // fondo_colorComboBox
            // 
            this.fondo_colorComboBox.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right);
            this.fondo_colorComboBox.Color_Seleccionado = System.Drawing.Color.Empty;
            this.fondo_colorComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.fondo_colorComboBox.Location = new System.Drawing.Point(116, 79);
            this.fondo_colorComboBox.Mostrar_Boton = false;
            this.fondo_colorComboBox.Name = "fondo_colorComboBox";
            this.fondo_colorComboBox.Permitir_Color_Personalizado = false;
            this.fondo_colorComboBox.Permitir_Color_Sistema = false;
            this.fondo_colorComboBox.Permitir_Color_Transparente = false;
            this.fondo_colorComboBox.Size = new System.Drawing.Size(278, 24);
            this.fondo_colorComboBox.TabIndex = 5;
            this.fondo_colorComboBox.Color_Cambio += new System.EventHandler(this.Forzar_Cambio_Estado);
            // 
            // fondo_label
            // 
            this.fondo_label.AutoSize = true;
            this.fondo_label.Location = new System.Drawing.Point(6, 87);
            this.fondo_label.Name = "fondo_label";
            this.fondo_label.Size = new System.Drawing.Size(104, 16);
            this.fondo_label.TabIndex = 4;
            this.fondo_label.Text = "Color de Fondo:";
            // 
            // imagen_comboBox
            // 
            this.imagen_comboBox.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right);
            this.imagen_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.imagen_comboBox.FormattingEnabled = true;
            this.imagen_comboBox.Location = new System.Drawing.Point(116, 49);
            this.imagen_comboBox.Name = "imagen_comboBox";
            this.imagen_comboBox.Size = new System.Drawing.Size(278, 24);
            this.imagen_comboBox.TabIndex = 3;
            this.imagen_comboBox.SelectedIndexChanged += new System.EventHandler(this.Forzar_Cambio_Estado);
            // 
            // imagen_label
            // 
            this.imagen_label.AutoSize = true;
            this.imagen_label.Location = new System.Drawing.Point(54, 52);
            this.imagen_label.Name = "imagen_label";
            this.imagen_label.Size = new System.Drawing.Size(56, 16);
            this.imagen_label.TabIndex = 2;
            this.imagen_label.Text = "Imagen:";
            // 
            // titulo_textBox
            // 
            this.titulo_textBox.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right);
            this.titulo_textBox.Location = new System.Drawing.Point(116, 21);
            this.titulo_textBox.MaxLength = 32;
            this.titulo_textBox.Name = "titulo_textBox";
            this.titulo_textBox.Size = new System.Drawing.Size(278, 22);
            this.titulo_textBox.TabIndex = 1;
            this.titulo_textBox.TextChanged += new System.EventHandler(this.Forzar_Cambio_Estado);
            // 
            // titulo_label
            // 
            this.titulo_label.AutoSize = true;
            this.titulo_label.Location = new System.Drawing.Point(66, 24);
            this.titulo_label.Name = "titulo_label";
            this.titulo_label.Size = new System.Drawing.Size(44, 16);
            this.titulo_label.TabIndex = 0;
            this.titulo_label.Text = "Título:";
            // 
            // Estado_Boton_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grupo_groupBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.Name = "Estado_Boton_Control";
            this.Size = new System.Drawing.Size(400, 140);
            this.grupo_groupBox.ResumeLayout(false);
            this.grupo_groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grupo_groupBox;
        private System.Windows.Forms.ComboBox imagen_comboBox;
        private System.Windows.Forms.Label imagen_label;
        private System.Windows.Forms.ColorComboBox fondo_colorComboBox;
        private System.Windows.Forms.Label fondo_label;
        private System.Windows.Forms.Label titulo_label;
        private System.Windows.Forms.TextBox titulo_textBox;
        private System.Windows.Forms.Label texto_label;
        private System.Windows.Forms.ColorComboBox texto_colorComboBox;


        public event EventHandler Cambio_Estado;

        public Estado_Boton_Control()
        {
            InitializeComponent();
        }

        protected override Size DefaultSize
        {
            get
            {
                return new Size(400, 140);
            }
        }

        protected override Size DefaultMaximumSize
        {
            get
            {
                return new Size(800, 140);
            }
        }

        protected override Size DefaultMinimumSize
        {
            get
            {
                return new Size(300, 140);
            }
        }

        [DefaultValue("")]
        public string Titulo
        {
            get
            {
                return grupo_groupBox.Text;
            }
            set
            {
                grupo_groupBox.Text = value;
            }
        }

        public void Cargar(Estado_Boton ESTADO)
        {
            titulo_textBox.Text = ESTADO.Titulo;
            if (imagen_comboBox.Items.Contains(ESTADO.Imagen))
            {
                imagen_comboBox.Text = ESTADO.Imagen;
            }
            else
            {
                imagen_comboBox.SelectedIndex = 0;
            }
            fondo_colorComboBox.Color_Seleccionado = ESTADO.Fondo;
            texto_colorComboBox.Color_Seleccionado = ESTADO.Texto;
        }

        public Estado_Boton Obtener_Estado()
        {
            if (imagen_comboBox.SelectedIndex == 0)
            {
                return new Estado_Boton(titulo_textBox.Text.Trim(), fondo_colorComboBox.Color_Seleccionado, texto_colorComboBox.Color_Seleccionado);
            }
            else
            {
                return new Estado_Boton(titulo_textBox.Text.Trim(), imagen_comboBox.Text, fondo_colorComboBox.Color_Seleccionado, texto_colorComboBox.Color_Seleccionado);
            }
        }

        public void Cargar_Imagenes()
        {
            imagen_comboBox.Items.Clear();
            imagen_comboBox.Items.Add("Ninguna");
            DirectoryInfo __ARCHIVOS = new DirectoryInfo(Application.StartupPath + Configuracion.Directorio_Imagenes);
            foreach (FileInfo __ARCHIVO in __ARCHIVOS.GetFiles(Configuracion.Filtro_Imagenes))
            {
                imagen_comboBox.Items.Add(__ARCHIVO.Name);
            }
        }

        protected virtual void On_Cambio_Estado(EventArgs e)
        {
            Cambio_Estado?.Invoke(this, e);
        }

        private void Forzar_Cambio_Estado(object sender, EventArgs e)
        {
            On_Cambio_Estado(e);
        }
    }
}
