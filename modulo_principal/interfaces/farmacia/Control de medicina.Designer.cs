namespace interfaces.farmacia
{
    partial class Control_de_medicina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Control_de_medicina));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.cerrar = new System.Windows.Forms.PictureBox();
            this.lblEncanezado = new System.Windows.Forms.Label();
            this.panel_izquierda = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnImprimirReporte = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.tabla_detalle_venta = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupo_botones = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkPeriodo = new System.Windows.Forms.RadioButton();
            this.chkCaja_activa = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fechaFinal = new System.Windows.Forms.DateTimePicker();
            this.fechaInicial = new System.Windows.Forms.DateTimePicker();
            this.panel_derecho = new System.Windows.Forms.Panel();
            this.lblNombre = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tabla_detalles = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).BeginInit();
            this.panel_izquierda.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnImprimirReporte)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_detalle_venta)).BeginInit();
            this.grupo_botones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel_derecho.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_detalles)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(196)))), ((int)(((byte)(255)))));
            this.panelTitulo.Controls.Add(this.cerrar);
            this.panelTitulo.Controls.Add(this.lblEncanezado);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(972, 46);
            this.panelTitulo.TabIndex = 6;
            this.panelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitulo_MouseDown);
            // 
            // cerrar
            // 
            this.cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cerrar.Image = ((System.Drawing.Image)(resources.GetObject("cerrar.Image")));
            this.cerrar.Location = new System.Drawing.Point(932, 6);
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
            this.lblEncanezado.Location = new System.Drawing.Point(325, 12);
            this.lblEncanezado.Name = "lblEncanezado";
            this.lblEncanezado.Size = new System.Drawing.Size(187, 23);
            this.lblEncanezado.TabIndex = 0;
            this.lblEncanezado.Text = "Control de medicinas";
            // 
            // panel_izquierda
            // 
            this.panel_izquierda.Controls.Add(this.groupBox2);
            this.panel_izquierda.Controls.Add(this.grupo_botones);
            this.panel_izquierda.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_izquierda.Location = new System.Drawing.Point(0, 46);
            this.panel_izquierda.Name = "panel_izquierda";
            this.panel_izquierda.Size = new System.Drawing.Size(470, 575);
            this.panel_izquierda.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnImprimirReporte);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.tabla_detalle_venta);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(470, 474);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle ventas de medicina";
            // 
            // btnImprimirReporte
            // 
            this.btnImprimirReporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimirReporte.Image = global::interfaces.Properties.Resources.text_page;
            this.btnImprimirReporte.Location = new System.Drawing.Point(419, 420);
            this.btnImprimirReporte.Name = "btnImprimirReporte";
            this.btnImprimirReporte.Size = new System.Drawing.Size(48, 48);
            this.btnImprimirReporte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnImprimirReporte.TabIndex = 2;
            this.btnImprimirReporte.TabStop = false;
            this.btnImprimirReporte.Click += new System.EventHandler(this.btnImprimirReporte_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtBusqueda);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(3, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(464, 54);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscar";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBusqueda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBusqueda.Location = new System.Drawing.Point(3, 22);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(458, 26);
            this.txtBusqueda.TabIndex = 0;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // tabla_detalle_venta
            // 
            this.tabla_detalle_venta.AllowUserToAddRows = false;
            this.tabla_detalle_venta.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabla_detalle_venta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.tabla_detalle_venta.BackgroundColor = System.Drawing.Color.White;
            this.tabla_detalle_venta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabla_detalle_venta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabla_detalle_venta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.tabla_detalle_venta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla_detalle_venta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.tabla_detalle_venta.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabla_detalle_venta.GridColor = System.Drawing.Color.White;
            this.tabla_detalle_venta.Location = new System.Drawing.Point(3, 82);
            this.tabla_detalle_venta.MultiSelect = false;
            this.tabla_detalle_venta.Name = "tabla_detalle_venta";
            this.tabla_detalle_venta.ReadOnly = true;
            this.tabla_detalle_venta.RowHeadersVisible = false;
            this.tabla_detalle_venta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabla_detalle_venta.Size = new System.Drawing.Size(464, 389);
            this.tabla_detalle_venta.TabIndex = 0;
            this.tabla_detalle_venta.Click += new System.EventHandler(this.tabla_detalle_venta_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "nom_producto";
            this.Column1.HeaderText = "Producto";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 275;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "cantidad";
            this.Column2.HeaderText = "Cantidad";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "total";
            this.Column3.HeaderText = "Total";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "suc_pro";
            this.Column4.HeaderText = "idsuc";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // grupo_botones
            // 
            this.grupo_botones.Controls.Add(this.btnBuscar);
            this.grupo_botones.Controls.Add(this.groupBox1);
            this.grupo_botones.Controls.Add(this.label2);
            this.grupo_botones.Controls.Add(this.label1);
            this.grupo_botones.Controls.Add(this.fechaFinal);
            this.grupo_botones.Controls.Add(this.fechaInicial);
            this.grupo_botones.Dock = System.Windows.Forms.DockStyle.Top;
            this.grupo_botones.Location = new System.Drawing.Point(0, 0);
            this.grupo_botones.Name = "grupo_botones";
            this.grupo_botones.Size = new System.Drawing.Size(470, 98);
            this.grupo_botones.TabIndex = 0;
            this.grupo_botones.TabStop = false;
            this.grupo_botones.Text = "Opciones";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Image = global::interfaces.Properties.Resources.search2;
            this.btnBuscar.Location = new System.Drawing.Point(294, 52);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(32, 32);
            this.btnBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.TabStop = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkPeriodo);
            this.groupBox1.Controls.Add(this.chkCaja_activa);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(351, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(116, 73);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar";
            // 
            // chkPeriodo
            // 
            this.chkPeriodo.AutoSize = true;
            this.chkPeriodo.Location = new System.Drawing.Point(13, 46);
            this.chkPeriodo.Name = "chkPeriodo";
            this.chkPeriodo.Size = new System.Drawing.Size(75, 23);
            this.chkPeriodo.TabIndex = 7;
            this.chkPeriodo.TabStop = true;
            this.chkPeriodo.Text = "Periodo";
            this.chkPeriodo.UseVisualStyleBackColor = true;
            this.chkPeriodo.CheckedChanged += new System.EventHandler(this.chkPeriodo_CheckedChanged);
            // 
            // chkCaja_activa
            // 
            this.chkCaja_activa.AutoSize = true;
            this.chkCaja_activa.Checked = true;
            this.chkCaja_activa.Location = new System.Drawing.Point(13, 20);
            this.chkCaja_activa.Name = "chkCaja_activa";
            this.chkCaja_activa.Size = new System.Drawing.Size(95, 23);
            this.chkCaja_activa.TabIndex = 6;
            this.chkCaja_activa.TabStop = true;
            this.chkCaja_activa.Text = "Caja activa";
            this.chkCaja_activa.UseVisualStyleBackColor = true;
            this.chkCaja_activa.CheckedChanged += new System.EventHandler(this.chkCaja_activa_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Image = global::interfaces.Properties.Resources.calendar1;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(161, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha Final";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Image = global::interfaces.Properties.Resources.calendar_empty1;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha inicial";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fechaFinal
            // 
            this.fechaFinal.CustomFormat = "dd/MM/yyyy";
            this.fechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaFinal.Location = new System.Drawing.Point(165, 58);
            this.fechaFinal.Name = "fechaFinal";
            this.fechaFinal.Size = new System.Drawing.Size(123, 26);
            this.fechaFinal.TabIndex = 1;
            // 
            // fechaInicial
            // 
            this.fechaInicial.CustomFormat = "dd/MM/yyyy";
            this.fechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaInicial.Location = new System.Drawing.Point(24, 58);
            this.fechaInicial.Name = "fechaInicial";
            this.fechaInicial.Size = new System.Drawing.Size(128, 26);
            this.fechaInicial.TabIndex = 0;
            // 
            // panel_derecho
            // 
            this.panel_derecho.Controls.Add(this.lblNombre);
            this.panel_derecho.Controls.Add(this.groupBox4);
            this.panel_derecho.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_derecho.Location = new System.Drawing.Point(476, 46);
            this.panel_derecho.Name = "panel_derecho";
            this.panel_derecho.Size = new System.Drawing.Size(496, 575);
            this.panel_derecho.TabIndex = 8;
            // 
            // lblNombre
            // 
            this.lblNombre.BackColor = System.Drawing.Color.Silver;
            this.lblNombre.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNombre.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(0, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(496, 55);
            this.lblNombre.TabIndex = 11;
            this.lblNombre.Text = "Nombre del producto";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tabla_detalles);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox4.Location = new System.Drawing.Point(0, 58);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(496, 517);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Moviento del producto";
            // 
            // tabla_detalles
            // 
            this.tabla_detalles.AllowUserToAddRows = false;
            this.tabla_detalles.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabla_detalles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.tabla_detalles.BackgroundColor = System.Drawing.Color.White;
            this.tabla_detalles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabla_detalles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabla_detalles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.tabla_detalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla_detalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.tabla_detalles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabla_detalles.GridColor = System.Drawing.Color.White;
            this.tabla_detalles.Location = new System.Drawing.Point(3, 22);
            this.tabla_detalles.MultiSelect = false;
            this.tabla_detalles.Name = "tabla_detalles";
            this.tabla_detalles.ReadOnly = true;
            this.tabla_detalles.RowHeadersVisible = false;
            this.tabla_detalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabla_detalles.Size = new System.Drawing.Size(490, 492);
            this.tabla_detalles.TabIndex = 0;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "fecha";
            this.Column5.HeaderText = "Fecha";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "docu";
            this.Column6.HeaderText = "N° Documento";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "cant";
            this.Column7.HeaderText = "Cantidad";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 70;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "pre";
            this.Column8.HeaderText = "Presentación";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 95;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "preci";
            this.Column9.HeaderText = "Precio";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 55;
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column10.DataPropertyName = "total";
            this.Column10.HeaderText = "Total";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Control_de_medicina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(972, 621);
            this.Controls.Add(this.panel_derecho);
            this.Controls.Add(this.panel_izquierda);
            this.Controls.Add(this.panelTitulo);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Control_de_medicina";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control_de_medicina";
            this.Load += new System.EventHandler(this.Control_de_medicina_Load);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).EndInit();
            this.panel_izquierda.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnImprimirReporte)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_detalle_venta)).EndInit();
            this.grupo_botones.ResumeLayout(false);
            this.grupo_botones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel_derecho.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabla_detalles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.PictureBox cerrar;
        private System.Windows.Forms.Label lblEncanezado;
        private System.Windows.Forms.Panel panel_izquierda;
        private System.Windows.Forms.GroupBox grupo_botones;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton chkPeriodo;
        private System.Windows.Forms.RadioButton chkCaja_activa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker fechaFinal;
        private System.Windows.Forms.DateTimePicker fechaInicial;
        private System.Windows.Forms.PictureBox btnBuscar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView tabla_detalle_venta;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.PictureBox btnImprimirReporte;
        private System.Windows.Forms.Panel panel_derecho;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView tabla_detalles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
    }
}