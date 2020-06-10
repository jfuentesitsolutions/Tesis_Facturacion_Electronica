namespace interfaces.Inventarios
{
    partial class clientes_frecuentes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(clientes_frecuentes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.cerrar = new System.Windows.Forms.PictureBox();
            this.lblEncanezado = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEstadisticas = new System.Windows.Forms.Button();
            this.tabla_Clientes = new System.Windows.Forms.DataGridView();
            this.CN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.PictureBox();
            this.txtBusquedaClientes = new System.Windows.Forms.TextBox();
            this.grpDescripcion = new System.Windows.Forms.GroupBox();
            this.btnReporte = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tabla_detalles = new System.Windows.Forms.DataGridView();
            this.FE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.To = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotal = new System.Windows.Forms.Label();
            this.grpFechas = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.fechaFinal = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_Clientes)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLimpiar)).BeginInit();
            this.grpDescripcion.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_detalles)).BeginInit();
            this.grpFechas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.grpDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.panelTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTitulo.Controls.Add(this.cerrar);
            this.panelTitulo.Controls.Add(this.lblEncanezado);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(1035, 46);
            this.panelTitulo.TabIndex = 7;
            this.panelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitulo_MouseDown);
            // 
            // cerrar
            // 
            this.cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cerrar.Image = ((System.Drawing.Image)(resources.GetObject("cerrar.Image")));
            this.cerrar.Location = new System.Drawing.Point(986, 6);
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
            this.lblEncanezado.Location = new System.Drawing.Point(428, 11);
            this.lblEncanezado.Name = "lblEncanezado";
            this.lblEncanezado.Size = new System.Drawing.Size(168, 23);
            this.lblEncanezado.TabIndex = 0;
            this.lblEncanezado.Text = "Clientes frecuentes";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 46);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.tabla_Clientes);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grpDescripcion);
            this.splitContainer1.Panel2.Controls.Add(this.grpFechas);
            this.splitContainer1.Panel2.Controls.Add(this.grpDatos);
            this.splitContainer1.Size = new System.Drawing.Size(1035, 569);
            this.splitContainer1.SplitterDistance = 508;
            this.splitContainer1.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEstadisticas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 495);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 72);
            this.panel1.TabIndex = 2;
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.Image = global::interfaces.Properties.Resources.chart_pie2;
            this.btnEstadisticas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstadisticas.Location = new System.Drawing.Point(171, 15);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Size = new System.Drawing.Size(143, 40);
            this.btnEstadisticas.TabIndex = 0;
            this.btnEstadisticas.Text = "Ver estadisticas";
            this.btnEstadisticas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEstadisticas.UseVisualStyleBackColor = true;
            this.btnEstadisticas.Click += new System.EventHandler(this.btnEstadisticas_Click);
            // 
            // tabla_Clientes
            // 
            this.tabla_Clientes.AllowUserToAddRows = false;
            this.tabla_Clientes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.tabla_Clientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tabla_Clientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabla_Clientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tabla_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla_Clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CN,
            this.DIR,
            this.id,
            this.cod});
            this.tabla_Clientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabla_Clientes.Location = new System.Drawing.Point(0, 67);
            this.tabla_Clientes.MultiSelect = false;
            this.tabla_Clientes.Name = "tabla_Clientes";
            this.tabla_Clientes.ReadOnly = true;
            this.tabla_Clientes.RowHeadersVisible = false;
            this.tabla_Clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabla_Clientes.Size = new System.Drawing.Size(506, 428);
            this.tabla_Clientes.TabIndex = 1;
            this.tabla_Clientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabla_Clientes_CellClick);
            // 
            // CN
            // 
            this.CN.DataPropertyName = "nombre";
            this.CN.HeaderText = "Nombre completo";
            this.CN.Name = "CN";
            this.CN.ReadOnly = true;
            this.CN.Width = 300;
            // 
            // DIR
            // 
            this.DIR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DIR.DataPropertyName = "direccion";
            this.DIR.HeaderText = "Dirección";
            this.DIR.Name = "DIR";
            this.DIR.ReadOnly = true;
            // 
            // id
            // 
            this.id.DataPropertyName = "idcliente";
            this.id.HeaderText = "idcli";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // cod
            // 
            this.cod.DataPropertyName = "cod_cliente";
            this.cod.HeaderText = "codigo";
            this.cod.Name = "cod";
            this.cod.ReadOnly = true;
            this.cod.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.txtBusquedaClientes);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 67);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda de clientes";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.Location = new System.Drawing.Point(459, 19);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(32, 32);
            this.btnLimpiar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.TabStop = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtBusquedaClientes
            // 
            this.txtBusquedaClientes.BackColor = System.Drawing.SystemColors.Control;
            this.txtBusquedaClientes.Location = new System.Drawing.Point(12, 25);
            this.txtBusquedaClientes.Name = "txtBusquedaClientes";
            this.txtBusquedaClientes.Size = new System.Drawing.Size(441, 26);
            this.txtBusquedaClientes.TabIndex = 0;
            this.txtBusquedaClientes.TextChanged += new System.EventHandler(this.txtBusquedaClientes_TextChanged);
            this.txtBusquedaClientes.Enter += new System.EventHandler(this.txtBusquedaClientes_Enter);
            // 
            // grpDescripcion
            // 
            this.grpDescripcion.Controls.Add(this.btnReporte);
            this.grpDescripcion.Controls.Add(this.groupBox5);
            this.grpDescripcion.Controls.Add(this.lblTotal);
            this.grpDescripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDescripcion.Location = new System.Drawing.Point(0, 245);
            this.grpDescripcion.Name = "grpDescripcion";
            this.grpDescripcion.Size = new System.Drawing.Size(521, 322);
            this.grpDescripcion.TabIndex = 2;
            this.grpDescripcion.TabStop = false;
            this.grpDescripcion.Text = "Descripción de compras";
            // 
            // btnReporte
            // 
            this.btnReporte.Image = global::interfaces.Properties.Resources.full_page1;
            this.btnReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporte.Location = new System.Drawing.Point(199, 265);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(146, 40);
            this.btnReporte.TabIndex = 2;
            this.btnReporte.Text = "Imprimir reporte";
            this.btnReporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tabla_detalles);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Location = new System.Drawing.Point(3, 77);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(515, 173);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Detalles de documentos";
            // 
            // tabla_detalles
            // 
            this.tabla_detalles.AllowUserToAddRows = false;
            this.tabla_detalles.AllowUserToDeleteRows = false;
            this.tabla_detalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla_detalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FE,
            this.Ti,
            this.To});
            this.tabla_detalles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabla_detalles.Location = new System.Drawing.Point(3, 22);
            this.tabla_detalles.MultiSelect = false;
            this.tabla_detalles.Name = "tabla_detalles";
            this.tabla_detalles.ReadOnly = true;
            this.tabla_detalles.RowHeadersVisible = false;
            this.tabla_detalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabla_detalles.Size = new System.Drawing.Size(509, 148);
            this.tabla_detalles.TabIndex = 0;
            // 
            // FE
            // 
            this.FE.DataPropertyName = "fecha";
            this.FE.HeaderText = "Fecha";
            this.FE.Name = "FE";
            this.FE.ReadOnly = true;
            this.FE.Width = 200;
            // 
            // Ti
            // 
            this.Ti.DataPropertyName = "correlativo";
            this.Ti.HeaderText = "N° de documento";
            this.Ti.Name = "Ti";
            this.Ti.ReadOnly = true;
            this.Ti.Width = 200;
            // 
            // To
            // 
            this.To.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.To.DataPropertyName = "monto_total";
            this.To.HeaderText = "Total";
            this.To.Name = "To";
            this.To.ReadOnly = true;
            // 
            // lblTotal
            // 
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTotal.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(3, 22);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotal.Size = new System.Drawing.Size(515, 55);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total=$ 0.0";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grpFechas
            // 
            this.grpFechas.Controls.Add(this.pictureBox3);
            this.grpFechas.Controls.Add(this.pictureBox2);
            this.grpFechas.Controls.Add(this.fechaFinal);
            this.grpFechas.Controls.Add(this.label6);
            this.grpFechas.Controls.Add(this.label2);
            this.grpFechas.Controls.Add(this.fechaInicio);
            this.grpFechas.Controls.Add(this.label1);
            this.grpFechas.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpFechas.Location = new System.Drawing.Point(0, 154);
            this.grpFechas.Name = "grpFechas";
            this.grpFechas.Size = new System.Drawing.Size(521, 91);
            this.grpFechas.TabIndex = 1;
            this.grpFechas.TabStop = false;
            this.grpFechas.Text = "Filtrar compras por fecha";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::interfaces.Properties.Resources.calendar_empty1;
            this.pictureBox3.Location = new System.Drawing.Point(182, 44);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::interfaces.Properties.Resources.calendar1;
            this.pictureBox2.Location = new System.Drawing.Point(476, 44);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // fechaFinal
            // 
            this.fechaFinal.CustomFormat = "dd/MM/yyyy";
            this.fechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaFinal.Location = new System.Drawing.Point(306, 48);
            this.fechaFinal.Name = "fechaFinal";
            this.fechaFinal.Size = new System.Drawing.Size(164, 26);
            this.fechaFinal.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(302, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 19);
            this.label6.TabIndex = 3;
            this.label6.Text = "Fecha final";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hasta";
            // 
            // fechaInicio
            // 
            this.fechaInicio.CustomFormat = "dd/MM/yyyy";
            this.fechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaInicio.Location = new System.Drawing.Point(11, 49);
            this.fechaInicio.Name = "fechaInicio";
            this.fechaInicio.Size = new System.Drawing.Size(169, 26);
            this.fechaInicio.TabIndex = 1;
            this.fechaInicio.ValueChanged += new System.EventHandler(this.fechaInicio_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha de inicio";
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.txtDireccion);
            this.grpDatos.Controls.Add(this.txtCodigo);
            this.grpDatos.Controls.Add(this.txtNombre);
            this.grpDatos.Controls.Add(this.label3);
            this.grpDatos.Controls.Add(this.label5);
            this.grpDatos.Controls.Add(this.label4);
            this.grpDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpDatos.Location = new System.Drawing.Point(0, 0);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(521, 154);
            this.grpDatos.TabIndex = 0;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos del cliente";
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.SystemColors.Control;
            this.txtDireccion.Location = new System.Drawing.Point(149, 89);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.ReadOnly = true;
            this.txtDireccion.Size = new System.Drawing.Size(359, 54);
            this.txtDireccion.TabIndex = 5;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.SystemColors.Control;
            this.txtCodigo.Location = new System.Drawing.Point(149, 56);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(177, 26);
            this.txtCodigo.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.Control;
            this.txtNombre.Location = new System.Drawing.Point(149, 23);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(359, 26);
            this.txtNombre.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre del cliente:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Dirección:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Codigo:";
            // 
            // clientes_frecuentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 615);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panelTitulo);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "clientes_frecuentes";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "clientes_frecuentes";
            this.Load += new System.EventHandler(this.clientes_frecuentes_Load);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabla_Clientes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLimpiar)).EndInit();
            this.grpDescripcion.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabla_detalles)).EndInit();
            this.grpFechas.ResumeLayout(false);
            this.grpFechas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.PictureBox cerrar;
        public System.Windows.Forms.Label lblEncanezado;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBusquedaClientes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEstadisticas;
        private System.Windows.Forms.DataGridView tabla_Clientes;
        private System.Windows.Forms.PictureBox btnLimpiar;
        private System.Windows.Forms.GroupBox grpDescripcion;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.GroupBox grpFechas;
        private System.Windows.Forms.DateTimePicker fechaFinal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker fechaInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView tabla_detalles;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn CN;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIR;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn FE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ti;
        private System.Windows.Forms.DataGridViewTextBoxColumn To;
    }
}