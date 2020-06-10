namespace interfaces.compras.auxiliares
{
    partial class producto_unica_presentacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(producto_unica_presentacion));
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.cerrar = new System.Windows.Forms.PictureBox();
            this.lblExis = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listaPresentaciones = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ventaDetalle = new System.Windows.Forms.NumericUpDown();
            this.ventaMayoreo = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listaUDetalle = new System.Windows.Forms.ComboBox();
            this.listaUMayoreo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.compraDetalle = new System.Windows.Forms.NumericUpDown();
            this.compraMayoreo = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tabla_presentaciones = new System.Windows.Forms.DataGridView();
            this.idp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgr = new System.Windows.Forms.PictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtCantidad = new System.Windows.Forms.NumericUpDown();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ventaDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaMayoreo)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.compraDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraMayoreo)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_presentaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgr)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(96)))), ((int)(((byte)(128)))));
            this.panelTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTitulo.Controls.Add(this.cerrar);
            this.panelTitulo.Controls.Add(this.lblExis);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(950, 62);
            this.panelTitulo.TabIndex = 2;
            this.panelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitulo_MouseDown);
            // 
            // cerrar
            // 
            this.cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cerrar.Image = ((System.Drawing.Image)(resources.GetObject("cerrar.Image")));
            this.cerrar.Location = new System.Drawing.Point(912, 4);
            this.cerrar.Margin = new System.Windows.Forms.Padding(4);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(32, 32);
            this.cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cerrar.TabIndex = 2;
            this.cerrar.TabStop = false;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // lblExis
            // 
            this.lblExis.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExis.ForeColor = System.Drawing.Color.White;
            this.lblExis.Location = new System.Drawing.Point(326, 4);
            this.lblExis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExis.Name = "lblExis";
            this.lblExis.Size = new System.Drawing.Size(169, 49);
            this.lblExis.TabIndex = 0;
            this.lblExis.Text = "Exist";
            this.lblExis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNombre
            // 
            this.lblNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNombre.Enabled = false;
            this.lblNombre.Location = new System.Drawing.Point(12, 108);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(174, 76);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "label1";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Presentación:";
            // 
            // listaPresentaciones
            // 
            this.listaPresentaciones.FormattingEnabled = true;
            this.listaPresentaciones.Location = new System.Drawing.Point(103, 69);
            this.listaPresentaciones.Name = "listaPresentaciones";
            this.listaPresentaciones.Size = new System.Drawing.Size(347, 27);
            this.listaPresentaciones.TabIndex = 1;
            this.listaPresentaciones.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listaPresentaciones_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 19);
            this.label3.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ventaDetalle);
            this.groupBox1.Controls.Add(this.ventaMayoreo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(271, 191);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 85);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Precios de venta";
            // 
            // ventaDetalle
            // 
            this.ventaDetalle.DecimalPlaces = 2;
            this.ventaDetalle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ventaDetalle.Location = new System.Drawing.Point(129, 44);
            this.ventaDetalle.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ventaDetalle.Name = "ventaDetalle";
            this.ventaDetalle.Size = new System.Drawing.Size(67, 26);
            this.ventaDetalle.TabIndex = 8;
            // 
            // ventaMayoreo
            // 
            this.ventaMayoreo.DecimalPlaces = 2;
            this.ventaMayoreo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ventaMayoreo.Location = new System.Drawing.Point(36, 44);
            this.ventaMayoreo.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ventaMayoreo.Name = "ventaMayoreo";
            this.ventaMayoreo.Size = new System.Drawing.Size(67, 26);
            this.ventaMayoreo.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(125, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Detalle:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mayoreo:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listaUDetalle);
            this.groupBox2.Controls.Add(this.listaUMayoreo);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 191);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 85);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Utilidades";
            // 
            // listaUDetalle
            // 
            this.listaUDetalle.FormattingEnabled = true;
            this.listaUDetalle.Location = new System.Drawing.Point(124, 44);
            this.listaUDetalle.Name = "listaUDetalle";
            this.listaUDetalle.Size = new System.Drawing.Size(109, 27);
            this.listaUDetalle.TabIndex = 3;
            this.listaUDetalle.SelectedIndexChanged += new System.EventHandler(this.listaUDetalle_SelectedIndexChanged);
            // 
            // listaUMayoreo
            // 
            this.listaUMayoreo.FormattingEnabled = true;
            this.listaUMayoreo.Location = new System.Drawing.Point(7, 45);
            this.listaUMayoreo.Name = "listaUMayoreo";
            this.listaUMayoreo.Size = new System.Drawing.Size(109, 27);
            this.listaUMayoreo.TabIndex = 2;
            this.listaUMayoreo.SelectedIndexChanged += new System.EventHandler(this.listaUMayoreo_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(120, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "Detalle:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mayoreo:";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(392, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ingresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(486, 292);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 36);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.compraDetalle);
            this.groupBox3.Controls.Add(this.compraMayoreo);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(194, 103);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(194, 82);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Precios de compras";
            // 
            // compraDetalle
            // 
            this.compraDetalle.DecimalPlaces = 2;
            this.compraDetalle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compraDetalle.Location = new System.Drawing.Point(110, 45);
            this.compraDetalle.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.compraDetalle.Name = "compraDetalle";
            this.compraDetalle.Size = new System.Drawing.Size(67, 26);
            this.compraDetalle.TabIndex = 3;
            this.compraDetalle.Enter += new System.EventHandler(this.compraDetalle_Enter);
            this.compraDetalle.KeyUp += new System.Windows.Forms.KeyEventHandler(this.compraMayoreo_KeyUp);
            this.compraDetalle.Leave += new System.EventHandler(this.compraDetalle_Leave);
            // 
            // compraMayoreo
            // 
            this.compraMayoreo.DecimalPlaces = 2;
            this.compraMayoreo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compraMayoreo.Location = new System.Drawing.Point(17, 45);
            this.compraMayoreo.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.compraMayoreo.Name = "compraMayoreo";
            this.compraMayoreo.Size = new System.Drawing.Size(67, 26);
            this.compraMayoreo.TabIndex = 1;
            this.compraMayoreo.Enter += new System.EventHandler(this.compraMayoreo_Enter);
            this.compraMayoreo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.compraMayoreo_KeyUp);
            this.compraMayoreo.Leave += new System.EventHandler(this.compraMayoreo_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(106, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 19);
            this.label8.TabIndex = 2;
            this.label8.Text = "Detalle:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "Mayoreo:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tabla_presentaciones);
            this.groupBox4.Location = new System.Drawing.Point(511, 70);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(427, 206);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Precios de presentaciones";
            // 
            // tabla_presentaciones
            // 
            this.tabla_presentaciones.AllowUserToAddRows = false;
            this.tabla_presentaciones.AllowUserToDeleteRows = false;
            this.tabla_presentaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabla_presentaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla_presentaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idp,
            this.nom,
            this.Column1,
            this.cantidad,
            this.Column2});
            this.tabla_presentaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabla_presentaciones.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.tabla_presentaciones.Location = new System.Drawing.Point(3, 22);
            this.tabla_presentaciones.MultiSelect = false;
            this.tabla_presentaciones.Name = "tabla_presentaciones";
            this.tabla_presentaciones.RowHeadersVisible = false;
            this.tabla_presentaciones.Size = new System.Drawing.Size(421, 181);
            this.tabla_presentaciones.TabIndex = 0;
            // 
            // idp
            // 
            this.idp.HeaderText = "ID";
            this.idp.Name = "idp";
            this.idp.ReadOnly = true;
            this.idp.Width = 50;
            // 
            // nom
            // 
            this.nom.HeaderText = "Presentación";
            this.nom.Name = "nom";
            this.nom.ReadOnly = true;
            this.nom.Width = 150;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Precio";
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cant";
            this.cantidad.Name = "cantidad";
            this.cantidad.Width = 52;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Tipo";
            this.Column2.Name = "Column2";
            // 
            // btnAgr
            // 
            this.btnAgr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgr.Image = ((System.Drawing.Image)(resources.GetObject("btnAgr.Image")));
            this.btnAgr.Location = new System.Drawing.Point(464, 66);
            this.btnAgr.Name = "btnAgr";
            this.btnAgr.Size = new System.Drawing.Size(32, 32);
            this.btnAgr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnAgr.TabIndex = 17;
            this.btnAgr.TabStop = false;
            this.btnAgr.Click += new System.EventHandler(this.btnAgr_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtCantidad);
            this.groupBox5.Location = new System.Drawing.Point(398, 103);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(100, 82);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(18, 32);
            this.txtCantidad.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(67, 39);
            this.txtCantidad.TabIndex = 0;
            this.txtCantidad.Enter += new System.EventHandler(this.txtCantidad_Enter);
            this.txtCantidad.KeyUp += new System.Windows.Forms.KeyEventHandler(this.compraMayoreo_KeyUp);
            // 
            // error
            // 
            this.error.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.error.ContainerControl = this;
            // 
            // producto_unica_presentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(950, 340);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btnAgr);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listaPresentaciones);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.panelTitulo);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "producto_unica_presentacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "producto_unica_presentacion";
            this.Load += new System.EventHandler(this.producto_unica_presentacion_Load);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ventaDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaMayoreo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.compraDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraMayoreo)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabla_presentaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgr)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.PictureBox cerrar;
        public System.Windows.Forms.Label lblExis;
        public System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.NumericUpDown ventaDetalle;
        public System.Windows.Forms.NumericUpDown ventaMayoreo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.NumericUpDown compraDetalle;
        public System.Windows.Forms.NumericUpDown compraMayoreo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView tabla_presentaciones;
        private System.Windows.Forms.PictureBox btnAgr;
        private System.Windows.Forms.DataGridViewTextBoxColumn idp;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.GroupBox groupBox5;
        public System.Windows.Forms.NumericUpDown txtCantidad;
        public System.Windows.Forms.ComboBox listaUDetalle;
        public System.Windows.Forms.ComboBox listaUMayoreo;
        public System.Windows.Forms.ComboBox listaPresentaciones;
        private System.Windows.Forms.ErrorProvider error;
    }
}