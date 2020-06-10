namespace interfaces.mantenimientos.auxiliares
{
    partial class presentaciones_productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(presentaciones_productos));
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.cerrar = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.canti = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.precio = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.lblPresenta = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkD = new System.Windows.Forms.RadioButton();
            this.chkM = new System.Windows.Forms.RadioButton();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.chkPrioridad = new System.Windows.Forms.CheckBox();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.precio)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(181)))), ((int)(((byte)(76)))));
            this.panelTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTitulo.Controls.Add(this.cerrar);
            this.panelTitulo.Controls.Add(this.lblTitulo);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(283, 45);
            this.panelTitulo.TabIndex = 1;
            this.panelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitulo_MouseDown);
            // 
            // cerrar
            // 
            this.cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cerrar.Image = ((System.Drawing.Image)(resources.GetObject("cerrar.Image")));
            this.cerrar.Location = new System.Drawing.Point(237, 7);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(32, 32);
            this.cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cerrar.TabIndex = 3;
            this.cerrar.TabStop = false;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(21, 11);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(156, 21);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Nueva presentación";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 342);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkPrioridad);
            this.groupBox2.Controls.Add(this.canti);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.precio);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lblPresenta);
            this.groupBox2.Location = new System.Drawing.Point(13, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 177);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos";
            // 
            // canti
            // 
            this.canti.BackColor = System.Drawing.Color.Silver;
            this.canti.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.canti.Location = new System.Drawing.Point(130, 106);
            this.canti.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.canti.Name = "canti";
            this.canti.Size = new System.Drawing.Size(96, 32);
            this.canti.TabIndex = 3;
            this.canti.Enter += new System.EventHandler(this.canti_Enter);
            this.canti.KeyUp += new System.Windows.Forms.KeyEventHandler(this.precio_KeyUp);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(126, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad interna:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // precio
            // 
            this.precio.BackColor = System.Drawing.Color.Silver;
            this.precio.DecimalPlaces = 2;
            this.precio.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precio.Location = new System.Drawing.Point(29, 106);
            this.precio.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(65, 32);
            this.precio.TabIndex = 1;
            this.precio.Enter += new System.EventHandler(this.precio_Enter);
            this.precio.KeyUp += new System.Windows.Forms.KeyEventHandler(this.precio_KeyUp);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(9, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 40);
            this.label9.TabIndex = 0;
            this.label9.Text = "Precio";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPresenta
            // 
            this.lblPresenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPresenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPresenta.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblPresenta.Location = new System.Drawing.Point(12, 29);
            this.lblPresenta.Name = "lblPresenta";
            this.lblPresenta.Size = new System.Drawing.Size(230, 27);
            this.lblPresenta.TabIndex = 0;
            this.lblPresenta.Text = "label1";
            this.lblPresenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPresenta.Click += new System.EventHandler(this.lblPresenta_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkD);
            this.groupBox1.Controls.Add(this.chkM);
            this.groupBox1.Location = new System.Drawing.Point(12, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 67);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo";
            // 
            // chkD
            // 
            this.chkD.AutoSize = true;
            this.chkD.Checked = true;
            this.chkD.Location = new System.Drawing.Point(152, 25);
            this.chkD.Name = "chkD";
            this.chkD.Size = new System.Drawing.Size(69, 23);
            this.chkD.TabIndex = 1;
            this.chkD.TabStop = true;
            this.chkD.Text = "Detalle";
            this.chkD.UseVisualStyleBackColor = true;
            this.chkD.CheckedChanged += new System.EventHandler(this.chkD_CheckedChanged);
            // 
            // chkM
            // 
            this.chkM.AutoSize = true;
            this.chkM.Location = new System.Drawing.Point(28, 26);
            this.chkM.Name = "chkM";
            this.chkM.Size = new System.Drawing.Size(83, 23);
            this.chkM.TabIndex = 0;
            this.chkM.Text = "Mayoreo";
            this.chkM.UseVisualStyleBackColor = true;
            this.chkM.CheckedChanged += new System.EventHandler(this.chkM_CheckedChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(102, 301);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 29);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Agregar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // error
            // 
            this.error.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.error.ContainerControl = this;
            // 
            // chkPrioridad
            // 
            this.chkPrioridad.AutoSize = true;
            this.chkPrioridad.Location = new System.Drawing.Point(29, 147);
            this.chkPrioridad.Name = "chkPrioridad";
            this.chkPrioridad.Size = new System.Drawing.Size(84, 23);
            this.chkPrioridad.TabIndex = 4;
            this.chkPrioridad.Text = "Prioridad";
            this.chkPrioridad.UseVisualStyleBackColor = true;
            // 
            // presentaciones_productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 387);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTitulo);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "presentaciones_productos";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "presentaciones_productos";
            this.Load += new System.EventHandler(this.presentaciones_productos_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.presentaciones_productos_KeyUp);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.precio)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.PictureBox cerrar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton chkD;
        private System.Windows.Forms.RadioButton chkM;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.NumericUpDown canti;
        public System.Windows.Forms.NumericUpDown precio;
        public System.Windows.Forms.Label lblPresenta;
        private System.Windows.Forms.ErrorProvider error;
        public System.Windows.Forms.CheckBox chkPrioridad;
    }
}