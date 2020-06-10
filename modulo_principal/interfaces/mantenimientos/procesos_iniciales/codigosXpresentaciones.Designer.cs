namespace interfaces.mantenimientos.procesos_iniciales
{
    partial class codigosXpresentaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(codigosXpresentaciones));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.cerrar = new System.Windows.Forms.PictureBox();
            this.lblEncanezado = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tabla_presentacion_producto = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtnombreP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listasBusqueda = new System.Windows.Forms.ComboBox();
            this.chkNombre = new System.Windows.Forms.RadioButton();
            this.chkCodi = new System.Windows.Forms.RadioButton();
            this.agregarProducto = new System.Windows.Forms.PictureBox();
            this.id1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_presentacion_producto)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agregarProducto)).BeginInit();
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
            this.panelTitulo.Size = new System.Drawing.Size(514, 43);
            this.panelTitulo.TabIndex = 1;
            this.panelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitulo_MouseDown);
            // 
            // cerrar
            // 
            this.cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cerrar.Image = ((System.Drawing.Image)(resources.GetObject("cerrar.Image")));
            this.cerrar.Location = new System.Drawing.Point(469, 5);
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
            this.lblEncanezado.Location = new System.Drawing.Point(143, 9);
            this.lblEncanezado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEncanezado.Name = "lblEncanezado";
            this.lblEncanezado.Size = new System.Drawing.Size(222, 23);
            this.lblEncanezado.TabIndex = 0;
            this.lblEncanezado.Text = "Codigo de presentaciones";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tabla_presentacion_producto);
            this.groupBox3.Location = new System.Drawing.Point(11, 266);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(488, 239);
            this.groupBox3.TabIndex = 5;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabla_presentacion_producto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tabla_presentacion_producto.ColumnHeadersHeight = 40;
            this.tabla_presentacion_producto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id1,
            this.presen,
            this.prec,
            this.Column2,
            this.Column1,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabla_presentacion_producto.DefaultCellStyle = dataGridViewCellStyle3;
            this.tabla_presentacion_producto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabla_presentacion_producto.Location = new System.Drawing.Point(3, 22);
            this.tabla_presentacion_producto.MultiSelect = false;
            this.tabla_presentacion_producto.Name = "tabla_presentacion_producto";
            this.tabla_presentacion_producto.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabla_presentacion_producto.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tabla_presentacion_producto.RowHeadersVisible = false;
            this.tabla_presentacion_producto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabla_presentacion_producto.Size = new System.Drawing.Size(482, 214);
            this.tabla_presentacion_producto.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtnombreP);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(14, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(485, 118);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos";
            // 
            // txtnombreP
            // 
            this.txtnombreP.BackColor = System.Drawing.Color.Silver;
            this.txtnombreP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnombreP.Enabled = false;
            this.txtnombreP.Location = new System.Drawing.Point(7, 44);
            this.txtnombreP.Multiline = true;
            this.txtnombreP.Name = "txtnombreP";
            this.txtnombreP.ReadOnly = true;
            this.txtnombreP.Size = new System.Drawing.Size(467, 58);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listasBusqueda);
            this.groupBox1.Controls.Add(this.chkNombre);
            this.groupBox1.Controls.Add(this.chkCodi);
            this.groupBox1.Controls.Add(this.agregarProducto);
            this.groupBox1.Location = new System.Drawing.Point(14, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 78);
            this.groupBox1.TabIndex = 4;
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
            this.listasBusqueda.Size = new System.Drawing.Size(257, 27);
            this.listasBusqueda.TabIndex = 0;
            this.listasBusqueda.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listasBusqueda_KeyUp);
            // 
            // chkNombre
            // 
            this.chkNombre.AutoSize = true;
            this.chkNombre.Location = new System.Drawing.Point(401, 29);
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
            this.chkCodi.Location = new System.Drawing.Point(323, 29);
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
            this.agregarProducto.Location = new System.Drawing.Point(285, 25);
            this.agregarProducto.Name = "agregarProducto";
            this.agregarProducto.Size = new System.Drawing.Size(32, 32);
            this.agregarProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.agregarProducto.TabIndex = 6;
            this.agregarProducto.TabStop = false;
            // 
            // id1
            // 
            this.id1.DataPropertyName = "idpresentacion_producto";
            this.id1.HeaderText = "ID";
            this.id1.Name = "id1";
            this.id1.ReadOnly = true;
            this.id1.Width = 60;
            // 
            // presen
            // 
            this.presen.DataPropertyName = "idpresentacion";
            this.presen.HeaderText = "ID_pre";
            this.presen.Name = "presen";
            this.presen.ReadOnly = true;
            this.presen.Visible = false;
            this.presen.Width = 40;
            // 
            // prec
            // 
            this.prec.DataPropertyName = "nombre_presentacion";
            this.prec.HeaderText = "Presentación";
            this.prec.Name = "prec";
            this.prec.ReadOnly = true;
            this.prec.Width = 150;
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
            // codigosXpresentaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(514, 533);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelTitulo);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "codigosXpresentaciones";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "codigosXpresentaciones";
            this.Load += new System.EventHandler(this.codigosXpresentaciones_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.codigosXpresentaciones_KeyUp);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabla_presentacion_producto)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agregarProducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.PictureBox cerrar;
        public System.Windows.Forms.Label lblEncanezado;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.DataGridView tabla_presentacion_producto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtnombreP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox listasBusqueda;
        private System.Windows.Forms.RadioButton chkNombre;
        private System.Windows.Forms.RadioButton chkCodi;
        private System.Windows.Forms.PictureBox agregarProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn id1;
        private System.Windows.Forms.DataGridViewTextBoxColumn presen;
        private System.Windows.Forms.DataGridViewTextBoxColumn prec;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}