namespace interfaces.mantenimientos.negocio
{
    partial class cambio_precios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cambio_precios));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.cerrar = new System.Windows.Forms.PictureBox();
            this.lblEncanezado = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listasBusqueda = new System.Windows.Forms.ComboBox();
            this.chkNombre = new System.Windows.Forms.RadioButton();
            this.chkCodi = new System.Windows.Forms.RadioButton();
            this.agregarProducto = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtnombreP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tabla_presentacion_producto = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnModifica = new System.Windows.Forms.Button();
            this.canti = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.precio = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listaPresentacion = new System.Windows.Forms.ComboBox();
            this.chkD = new System.Windows.Forms.RadioButton();
            this.chkM = new System.Windows.Forms.RadioButton();
            this.chkPriori = new System.Windows.Forms.CheckBox();
            this.id1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agregarProducto)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_presentacion_producto)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.precio)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(96)))), ((int)(((byte)(128)))));
            this.panelTitulo.Controls.Add(this.cerrar);
            this.panelTitulo.Controls.Add(this.lblEncanezado);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(622, 43);
            this.panelTitulo.TabIndex = 1;
            this.panelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitulo_MouseDown);
            // 
            // cerrar
            // 
            this.cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cerrar.Image = ((System.Drawing.Image)(resources.GetObject("cerrar.Image")));
            this.cerrar.Location = new System.Drawing.Point(577, 5);
            this.cerrar.Margin = new System.Windows.Forms.Padding(4);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(32, 32);
            this.cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cerrar.TabIndex = 2;
            this.cerrar.TabStop = false;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // lblEncanezado
            // 
            this.lblEncanezado.AutoSize = true;
            this.lblEncanezado.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncanezado.ForeColor = System.Drawing.Color.White;
            this.lblEncanezado.Location = new System.Drawing.Point(213, 9);
            this.lblEncanezado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEncanezado.Name = "lblEncanezado";
            this.lblEncanezado.Size = new System.Drawing.Size(165, 23);
            this.lblEncanezado.TabIndex = 0;
            this.lblEncanezado.Text = "Cambio de precios";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listasBusqueda);
            this.groupBox1.Controls.Add(this.chkNombre);
            this.groupBox1.Controls.Add(this.chkCodi);
            this.groupBox1.Controls.Add(this.agregarProducto);
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(597, 78);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda";
            // 
            // listasBusqueda
            // 
            this.listasBusqueda.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.listasBusqueda.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.listasBusqueda.BackColor = System.Drawing.Color.Silver;
            this.listasBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.listasBusqueda.FormattingEnabled = true;
            this.listasBusqueda.Location = new System.Drawing.Point(22, 25);
            this.listasBusqueda.Name = "listasBusqueda";
            this.listasBusqueda.Size = new System.Drawing.Size(306, 27);
            this.listasBusqueda.TabIndex = 0;
            this.listasBusqueda.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listasBusqueda_KeyUp);
            // 
            // chkNombre
            // 
            this.chkNombre.AutoSize = true;
            this.chkNombre.Location = new System.Drawing.Point(487, 29);
            this.chkNombre.Name = "chkNombre";
            this.chkNombre.Size = new System.Drawing.Size(78, 23);
            this.chkNombre.TabIndex = 1;
            this.chkNombre.TabStop = true;
            this.chkNombre.Text = "Nombre";
            this.chkNombre.UseVisualStyleBackColor = true;
            this.chkNombre.CheckedChanged += new System.EventHandler(this.chkNombre_CheckedChanged);
            // 
            // chkCodi
            // 
            this.chkCodi.AutoSize = true;
            this.chkCodi.Checked = true;
            this.chkCodi.Location = new System.Drawing.Point(409, 29);
            this.chkCodi.Name = "chkCodi";
            this.chkCodi.Size = new System.Drawing.Size(72, 23);
            this.chkCodi.TabIndex = 2;
            this.chkCodi.TabStop = true;
            this.chkCodi.Text = "Código";
            this.chkCodi.UseVisualStyleBackColor = true;
            this.chkCodi.CheckedChanged += new System.EventHandler(this.chkCodi_CheckedChanged);
            // 
            // agregarProducto
            // 
            this.agregarProducto.Cursor = System.Windows.Forms.Cursors.Default;
            this.agregarProducto.Image = ((System.Drawing.Image)(resources.GetObject("agregarProducto.Image")));
            this.agregarProducto.Location = new System.Drawing.Point(334, 24);
            this.agregarProducto.Name = "agregarProducto";
            this.agregarProducto.Size = new System.Drawing.Size(32, 32);
            this.agregarProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.agregarProducto.TabIndex = 6;
            this.agregarProducto.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtnombreP);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(13, 135);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(596, 118);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos";
            // 
            // txtnombreP
            // 
            this.txtnombreP.BackColor = System.Drawing.Color.Silver;
            this.txtnombreP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnombreP.Enabled = false;
            this.txtnombreP.Location = new System.Drawing.Point(12, 45);
            this.txtnombreP.Multiline = true;
            this.txtnombreP.Name = "txtnombreP";
            this.txtnombreP.Size = new System.Drawing.Size(573, 58);
            this.txtnombreP.TabIndex = 6;
            this.txtnombreP.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(8, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre del producto:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tabla_presentacion_producto);
            this.groupBox3.Location = new System.Drawing.Point(13, 260);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(391, 273);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Presentaciones";
            // 
            // tabla_presentacion_producto
            // 
            this.tabla_presentacion_producto.AllowUserToAddRows = false;
            this.tabla_presentacion_producto.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tabla_presentacion_producto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tabla_presentacion_producto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabla_presentacion_producto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tabla_presentacion_producto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla_presentacion_producto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id1,
            this.presen,
            this.prec,
            this.Column2,
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column5});
            this.tabla_presentacion_producto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabla_presentacion_producto.Location = new System.Drawing.Point(3, 22);
            this.tabla_presentacion_producto.MultiSelect = false;
            this.tabla_presentacion_producto.Name = "tabla_presentacion_producto";
            this.tabla_presentacion_producto.ReadOnly = true;
            this.tabla_presentacion_producto.RowHeadersVisible = false;
            this.tabla_presentacion_producto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabla_presentacion_producto.Size = new System.Drawing.Size(385, 248);
            this.tabla_presentacion_producto.TabIndex = 0;
            this.tabla_presentacion_producto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tabla_presentacion_producto_KeyUp);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkPriori);
            this.groupBox4.Controls.Add(this.btnModifica);
            this.groupBox4.Controls.Add(this.canti);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.precio);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.listaPresentacion);
            this.groupBox4.Controls.Add(this.chkD);
            this.groupBox4.Controls.Add(this.chkM);
            this.groupBox4.Location = new System.Drawing.Point(410, 260);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(199, 270);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Modificar";
            // 
            // btnModifica
            // 
            this.btnModifica.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnModifica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifica.Location = new System.Drawing.Point(63, 235);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(78, 29);
            this.btnModifica.TabIndex = 8;
            this.btnModifica.Text = "Modificar";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // canti
            // 
            this.canti.BackColor = System.Drawing.Color.Silver;
            this.canti.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.canti.Location = new System.Drawing.Point(92, 154);
            this.canti.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.canti.Name = "canti";
            this.canti.Size = new System.Drawing.Size(96, 32);
            this.canti.TabIndex = 7;
            this.canti.Enter += new System.EventHandler(this.canti_Enter);
            this.canti.KeyUp += new System.Windows.Forms.KeyEventHandler(this.precio_KeyUp);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(97, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 40);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cantidad interna:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // precio
            // 
            this.precio.BackColor = System.Drawing.Color.Silver;
            this.precio.DecimalPlaces = 2;
            this.precio.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precio.Location = new System.Drawing.Point(17, 154);
            this.precio.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(65, 32);
            this.precio.TabIndex = 5;
            this.precio.Enter += new System.EventHandler(this.precio_Enter);
            this.precio.KeyUp += new System.Windows.Forms.KeyEventHandler(this.precio_KeyUp);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(13, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 40);
            this.label9.TabIndex = 4;
            this.label9.Text = "Precio";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Presentación";
            // 
            // listaPresentacion
            // 
            this.listaPresentacion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.listaPresentacion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.listaPresentacion.BackColor = System.Drawing.Color.Silver;
            this.listaPresentacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.listaPresentacion.FormattingEnabled = true;
            this.listaPresentacion.Location = new System.Drawing.Point(17, 76);
            this.listaPresentacion.Name = "listaPresentacion";
            this.listaPresentacion.Size = new System.Drawing.Size(171, 27);
            this.listaPresentacion.TabIndex = 3;
            this.listaPresentacion.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listaPresentacion_KeyUp);
            // 
            // chkD
            // 
            this.chkD.AutoSize = true;
            this.chkD.Location = new System.Drawing.Point(119, 25);
            this.chkD.Name = "chkD";
            this.chkD.Size = new System.Drawing.Size(69, 23);
            this.chkD.TabIndex = 1;
            this.chkD.Text = "Detalle";
            this.chkD.UseVisualStyleBackColor = true;
            this.chkD.KeyUp += new System.Windows.Forms.KeyEventHandler(this.chkD_KeyUp);
            // 
            // chkM
            // 
            this.chkM.AutoSize = true;
            this.chkM.Location = new System.Drawing.Point(17, 25);
            this.chkM.Name = "chkM";
            this.chkM.Size = new System.Drawing.Size(83, 23);
            this.chkM.TabIndex = 0;
            this.chkM.Text = "Mayoreo";
            this.chkM.UseVisualStyleBackColor = true;
            this.chkM.KeyUp += new System.Windows.Forms.KeyEventHandler(this.chkM_KeyUp);
            // 
            // chkPriori
            // 
            this.chkPriori.AutoSize = true;
            this.chkPriori.Location = new System.Drawing.Point(17, 198);
            this.chkPriori.Name = "chkPriori";
            this.chkPriori.Size = new System.Drawing.Size(84, 23);
            this.chkPriori.TabIndex = 9;
            this.chkPriori.Text = "Prioridad";
            this.chkPriori.UseVisualStyleBackColor = true;
            // 
            // id1
            // 
            this.id1.DataPropertyName = "idpresentacion_producto";
            this.id1.HeaderText = "ID_presentacion_pro";
            this.id1.Name = "id1";
            this.id1.ReadOnly = true;
            this.id1.Visible = false;
            this.id1.Width = 40;
            // 
            // presen
            // 
            this.presen.DataPropertyName = "idpresentacion";
            this.presen.HeaderText = "ID";
            this.presen.Name = "presen";
            this.presen.ReadOnly = true;
            this.presen.Width = 40;
            // 
            // prec
            // 
            this.prec.DataPropertyName = "nombre_presentacion";
            this.prec.HeaderText = "Presentación";
            this.prec.Name = "prec";
            this.prec.ReadOnly = true;
            this.prec.Width = 120;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "precio";
            this.Column2.HeaderText = "Precio";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 75;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "tipo";
            this.Column1.HeaderText = "Tipo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 75;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "cantidad_unidades";
            this.Column3.HeaderText = "Unidades";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "tipoN";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "prioridad";
            this.Column5.HeaderText = "priori";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // cambio_precios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(622, 545);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelTitulo);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "cambio_precios";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cambio_precios";
            this.Load += new System.EventHandler(this.cambio_precios_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cambio_precios_KeyUp);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agregarProducto)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabla_presentacion_producto)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.precio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.PictureBox cerrar;
        public System.Windows.Forms.Label lblEncanezado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox listasBusqueda;
        private System.Windows.Forms.RadioButton chkNombre;
        private System.Windows.Forms.RadioButton chkCodi;
        private System.Windows.Forms.PictureBox agregarProducto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtnombreP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.DataGridView tabla_presentacion_producto;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton chkD;
        private System.Windows.Forms.RadioButton chkM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox listaPresentacion;
        public System.Windows.Forms.NumericUpDown canti;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.NumericUpDown precio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.CheckBox chkPriori;
        private System.Windows.Forms.DataGridViewTextBoxColumn id1;
        private System.Windows.Forms.DataGridViewTextBoxColumn presen;
        private System.Windows.Forms.DataGridViewTextBoxColumn prec;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}