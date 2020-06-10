namespace interfaces.ventas.auxiliares
{
    partial class cobrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cobrar));
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.lblEncanezado = new System.Windows.Forms.Label();
            this.lblTotala = new System.Windows.Forms.Label();
            this.lblCambio = new System.Windows.Forms.Label();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtefe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.efec = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblMeto = new System.Windows.Forms.Label();
            this.listaMetodoPago = new System.Windows.Forms.ComboBox();
            this.cerrar = new System.Windows.Forms.PictureBox();
            this.panelTitulo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.efec)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(102)))), ((int)(((byte)(149)))));
            this.panelTitulo.Controls.Add(this.cerrar);
            this.panelTitulo.Controls.Add(this.lblEncanezado);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(232, 46);
            this.panelTitulo.TabIndex = 6;
            this.panelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitulo_MouseDown);
            // 
            // lblEncanezado
            // 
            this.lblEncanezado.AutoSize = true;
            this.lblEncanezado.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncanezado.ForeColor = System.Drawing.Color.White;
            this.lblEncanezado.Location = new System.Drawing.Point(71, 9);
            this.lblEncanezado.Name = "lblEncanezado";
            this.lblEncanezado.Size = new System.Drawing.Size(68, 23);
            this.lblEncanezado.TabIndex = 0;
            this.lblEncanezado.Text = "Cobrar";
            // 
            // lblTotala
            // 
            this.lblTotala.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotala.Location = new System.Drawing.Point(46, 30);
            this.lblTotala.Name = "lblTotala";
            this.lblTotala.Size = new System.Drawing.Size(135, 58);
            this.lblTotala.TabIndex = 8;
            this.lblTotala.Text = "0.0";
            this.lblTotala.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCambio
            // 
            this.lblCambio.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambio.Location = new System.Drawing.Point(41, 22);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(144, 66);
            this.lblCambio.TabIndex = 12;
            this.lblCambio.Text = "0.0";
            this.lblCambio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCobrar
            // 
            this.btnCobrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnCobrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCobrar.Location = new System.Drawing.Point(68, 453);
            this.btnCobrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(89, 27);
            this.btnCobrar.TabIndex = 1;
            this.btnCobrar.Text = "Cobrar";
            this.btnCobrar.UseVisualStyleBackColor = true;
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblTotala);
            this.groupBox1.Location = new System.Drawing.Point(16, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Total a pagar:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 58);
            this.label1.TabIndex = 17;
            this.label1.Text = "$";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtefe);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(16, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Efectivo:";
            // 
            // txtefe
            // 
            this.txtefe.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtefe.Location = new System.Drawing.Point(45, 20);
            this.txtefe.Name = "txtefe";
            this.txtefe.Size = new System.Drawing.Size(136, 63);
            this.txtefe.TabIndex = 19;
            this.txtefe.Text = "$";
            this.txtefe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtefe.TextChanged += new System.EventHandler(this.txtefe_TextChanged);
            this.txtefe.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtefe_KeyUp);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 58);
            this.label3.TabIndex = 18;
            this.label3.Text = "$";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // efec
            // 
            this.efec.DecimalPlaces = 2;
            this.efec.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efec.Location = new System.Drawing.Point(45, 22);
            this.efec.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.efec.Name = "efec";
            this.efec.Size = new System.Drawing.Size(136, 63);
            this.efec.TabIndex = 0;
            this.efec.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.efec);
            this.groupBox3.Controls.Add(this.lblCambio);
            this.groupBox3.Location = new System.Drawing.Point(16, 271);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cambio:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 58);
            this.label2.TabIndex = 18;
            this.label2.Text = "$";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // error
            // 
            this.error.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.error.ContainerControl = this;
            // 
            // lblMeto
            // 
            this.lblMeto.AutoSize = true;
            this.lblMeto.Location = new System.Drawing.Point(14, 382);
            this.lblMeto.Name = "lblMeto";
            this.lblMeto.Size = new System.Drawing.Size(111, 19);
            this.lblMeto.TabIndex = 18;
            this.lblMeto.Text = "Metodo de pago";
            // 
            // listaMetodoPago
            // 
            this.listaMetodoPago.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.listaMetodoPago.BackColor = System.Drawing.SystemColors.Control;
            this.listaMetodoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listaMetodoPago.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.listaMetodoPago.FormattingEnabled = true;
            this.listaMetodoPago.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta",
            "Cheque"});
            this.listaMetodoPago.Location = new System.Drawing.Point(16, 409);
            this.listaMetodoPago.Name = "listaMetodoPago";
            this.listaMetodoPago.Size = new System.Drawing.Size(200, 27);
            this.listaMetodoPago.TabIndex = 34;
            this.listaMetodoPago.SelectedIndexChanged += new System.EventHandler(this.listaMetodoPago_SelectedIndexChanged);
            // 
            // cerrar
            // 
            this.cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cerrar.Image = ((System.Drawing.Image)(resources.GetObject("cerrar.Image")));
            this.cerrar.Location = new System.Drawing.Point(194, 6);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(32, 32);
            this.cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cerrar.TabIndex = 2;
            this.cerrar.TabStop = false;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // cobrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 494);
            this.Controls.Add(this.listaMetodoPago);
            this.Controls.Add(this.lblMeto);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCobrar);
            this.Controls.Add(this.panelTitulo);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "cobrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cobrar";
            this.Load += new System.EventHandler(this.cobrar_Load);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.efec)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox cerrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.Label lblTotala;
        public System.Windows.Forms.Label lblCambio;
        private System.Windows.Forms.ErrorProvider error;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.NumericUpDown efec;
        public System.Windows.Forms.TextBox txtefe;
        public System.Windows.Forms.Panel panelTitulo;
        public System.Windows.Forms.Label lblEncanezado;
        public System.Windows.Forms.ComboBox listaMetodoPago;
        public System.Windows.Forms.Label lblMeto;
        public System.Windows.Forms.Button btnCobrar;
    }
}