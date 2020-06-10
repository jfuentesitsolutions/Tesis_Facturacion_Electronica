namespace interfaces.mantenimientos
{
    partial class empleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(empleados));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.cerrar = new System.Windows.Forms.PictureBox();
            this.lblEncanezado = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listaGenero = new System.Windows.Forms.ComboBox();
            this.lbl = new System.Windows.Forms.Label();
            this.btnAgregarSucursal = new System.Windows.Forms.Button();
            this.btnAgregaCargo = new System.Windows.Forms.Button();
            this.listaSucursales = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.listaCargo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDui = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tablaEmpleados = new System.Windows.Forms.DataGridView();
            this.Cid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ccargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idsu_em = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdisu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaEmpleados)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
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
            this.panelTitulo.Size = new System.Drawing.Size(803, 46);
            this.panelTitulo.TabIndex = 6;
            this.panelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // cerrar
            // 
            this.cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cerrar.Image = ((System.Drawing.Image)(resources.GetObject("cerrar.Image")));
            this.cerrar.Location = new System.Drawing.Point(756, 6);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(37, 35);
            this.cerrar.TabIndex = 2;
            this.cerrar.TabStop = false;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // lblEncanezado
            // 
            this.lblEncanezado.AutoSize = true;
            this.lblEncanezado.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncanezado.ForeColor = System.Drawing.Color.White;
            this.lblEncanezado.Location = new System.Drawing.Point(286, 11);
            this.lblEncanezado.Name = "lblEncanezado";
            this.lblEncanezado.Size = new System.Drawing.Size(252, 23);
            this.lblEncanezado.TabIndex = 0;
            this.lblEncanezado.Text = "Ingreso de nuevos empleados";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 548);
            this.panel1.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(181, 507);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 29);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(91, 507);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 29);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCorreo);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtTelefono);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(12, 396);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 92);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contactos";
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.Silver;
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCorreo.Location = new System.Drawing.Point(167, 45);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(127, 26);
            this.txtCorreo.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(163, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "Correo:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.Silver;
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefono.Location = new System.Drawing.Point(30, 45);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(127, 26);
            this.txtTelefono.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(26, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "Telefono:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.listaGenero);
            this.groupBox1.Controls.Add(this.lbl);
            this.groupBox1.Controls.Add(this.btnAgregarSucursal);
            this.groupBox1.Controls.Add(this.btnAgregaCargo);
            this.groupBox1.Controls.Add(this.listaSucursales);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.listaCargo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNit);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDui);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtApellidos);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(12, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 382);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del empleado";
            // 
            // listaGenero
            // 
            this.listaGenero.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.listaGenero.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.listaGenero.BackColor = System.Drawing.Color.Silver;
            this.listaGenero.DisplayMember = "hola";
            this.listaGenero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listaGenero.ForeColor = System.Drawing.Color.Black;
            this.listaGenero.FormattingEnabled = true;
            this.listaGenero.Location = new System.Drawing.Point(31, 153);
            this.listaGenero.Name = "listaGenero";
            this.listaGenero.Size = new System.Drawing.Size(263, 27);
            this.listaGenero.TabIndex = 2;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.BackColor = System.Drawing.Color.Transparent;
            this.lbl.Location = new System.Drawing.Point(27, 132);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(57, 19);
            this.lbl.TabIndex = 18;
            this.lbl.Text = "Genero:";
            // 
            // btnAgregarSucursal
            // 
            this.btnAgregarSucursal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarSucursal.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAgregarSucursal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAgregarSucursal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAgregarSucursal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.error.SetIconAlignment(this.btnAgregarSucursal, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.btnAgregarSucursal.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarSucursal.Image")));
            this.btnAgregarSucursal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarSucursal.Location = new System.Drawing.Point(262, 327);
            this.btnAgregarSucursal.Name = "btnAgregarSucursal";
            this.btnAgregarSucursal.Size = new System.Drawing.Size(33, 27);
            this.btnAgregarSucursal.TabIndex = 8;
            this.btnAgregarSucursal.UseVisualStyleBackColor = true;
            this.btnAgregarSucursal.Click += new System.EventHandler(this.btnAgregarSucursal_Click);
            // 
            // btnAgregaCargo
            // 
            this.btnAgregaCargo.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregaCargo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregaCargo.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAgregaCargo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAgregaCargo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAgregaCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.error.SetIconAlignment(this.btnAgregaCargo, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.btnAgregaCargo.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregaCargo.Image")));
            this.btnAgregaCargo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregaCargo.Location = new System.Drawing.Point(262, 268);
            this.btnAgregaCargo.Name = "btnAgregaCargo";
            this.btnAgregaCargo.Size = new System.Drawing.Size(33, 27);
            this.btnAgregaCargo.TabIndex = 6;
            this.btnAgregaCargo.UseVisualStyleBackColor = false;
            this.btnAgregaCargo.Click += new System.EventHandler(this.btnAgregaCargo_Click);
            // 
            // listaSucursales
            // 
            this.listaSucursales.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.listaSucursales.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.listaSucursales.BackColor = System.Drawing.Color.Silver;
            this.listaSucursales.DisplayMember = "hola";
            this.listaSucursales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listaSucursales.ForeColor = System.Drawing.Color.Black;
            this.listaSucursales.FormattingEnabled = true;
            this.listaSucursales.Location = new System.Drawing.Point(31, 328);
            this.listaSucursales.Name = "listaSucursales";
            this.listaSucursales.Size = new System.Drawing.Size(225, 27);
            this.listaSucursales.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(27, 306);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "Sucursal";
            // 
            // listaCargo
            // 
            this.listaCargo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.listaCargo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.listaCargo.BackColor = System.Drawing.Color.Silver;
            this.listaCargo.DisplayMember = "hola";
            this.listaCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listaCargo.ForeColor = System.Drawing.Color.Black;
            this.listaCargo.FormattingEnabled = true;
            this.listaCargo.Location = new System.Drawing.Point(31, 268);
            this.listaCargo.Name = "listaCargo";
            this.listaCargo.Size = new System.Drawing.Size(225, 27);
            this.listaCargo.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(27, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Cargo:";
            // 
            // txtNit
            // 
            this.txtNit.BackColor = System.Drawing.Color.Silver;
            this.txtNit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNit.Location = new System.Drawing.Point(168, 213);
            this.txtNit.Name = "txtNit";
            this.txtNit.Size = new System.Drawing.Size(127, 26);
            this.txtNit.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(164, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Nit:";
            // 
            // txtDui
            // 
            this.txtDui.BackColor = System.Drawing.Color.Silver;
            this.txtDui.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDui.Location = new System.Drawing.Point(31, 213);
            this.txtDui.Name = "txtDui";
            this.txtDui.Size = new System.Drawing.Size(127, 26);
            this.txtDui.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(27, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Dui:";
            // 
            // txtApellidos
            // 
            this.txtApellidos.BackColor = System.Drawing.Color.Silver;
            this.txtApellidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellidos.Location = new System.Drawing.Point(31, 101);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(264, 26);
            this.txtApellidos.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(27, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Apellidos:";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.Silver;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Location = new System.Drawing.Point(31, 49);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(264, 26);
            this.txtNombre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(27, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombres:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tablaEmpleados);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(359, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(444, 548);
            this.panel3.TabIndex = 8;
            // 
            // tablaEmpleados
            // 
            this.tablaEmpleados.AllowUserToAddRows = false;
            this.tablaEmpleados.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tablaEmpleados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaEmpleados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tablaEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cid,
            this.Cn,
            this.Ca,
            this.suc,
            this.c5,
            this.Cd,
            this.Cnit,
            this.Ccargo,
            this.Cca,
            this.Ct,
            this.Cc,
            this.idsu_em,
            this.cdisu});
            this.tablaEmpleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablaEmpleados.Location = new System.Drawing.Point(0, 41);
            this.tablaEmpleados.MultiSelect = false;
            this.tablaEmpleados.Name = "tablaEmpleados";
            this.tablaEmpleados.ReadOnly = true;
            this.tablaEmpleados.RowHeadersVisible = false;
            this.tablaEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaEmpleados.Size = new System.Drawing.Size(444, 475);
            this.tablaEmpleados.TabIndex = 1;
            this.tablaEmpleados.Click += new System.EventHandler(this.tablaEmpleados_Click);
            // 
            // Cid
            // 
            this.Cid.DataPropertyName = "idempleado";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Cid.DefaultCellStyle = dataGridViewCellStyle3;
            this.Cid.HeaderText = "ID";
            this.Cid.Name = "Cid";
            this.Cid.ReadOnly = true;
            this.Cid.Width = 75;
            // 
            // Cn
            // 
            this.Cn.DataPropertyName = "nombres";
            this.Cn.HeaderText = "Nombres";
            this.Cn.Name = "Cn";
            this.Cn.ReadOnly = true;
            this.Cn.Width = 150;
            // 
            // Ca
            // 
            this.Ca.DataPropertyName = "apellidos";
            this.Ca.HeaderText = "Apellidos";
            this.Ca.Name = "Ca";
            this.Ca.ReadOnly = true;
            this.Ca.Width = 150;
            // 
            // suc
            // 
            this.suc.DataPropertyName = "numero_de_sucursal";
            this.suc.HeaderText = "Sucursal";
            this.suc.Name = "suc";
            this.suc.ReadOnly = true;
            // 
            // c5
            // 
            this.c5.DataPropertyName = "genero";
            this.c5.HeaderText = "Genero";
            this.c5.Name = "c5";
            this.c5.ReadOnly = true;
            // 
            // Cd
            // 
            this.Cd.DataPropertyName = "dui";
            this.Cd.HeaderText = "Dui";
            this.Cd.Name = "Cd";
            this.Cd.ReadOnly = true;
            // 
            // Cnit
            // 
            this.Cnit.DataPropertyName = "nit";
            this.Cnit.HeaderText = "Nit";
            this.Cnit.Name = "Cnit";
            this.Cnit.ReadOnly = true;
            // 
            // Ccargo
            // 
            this.Ccargo.DataPropertyName = "idcargo";
            this.Ccargo.HeaderText = "idcargo";
            this.Ccargo.Name = "Ccargo";
            this.Ccargo.ReadOnly = true;
            this.Ccargo.Visible = false;
            // 
            // Cca
            // 
            this.Cca.DataPropertyName = "nombre_cargo";
            this.Cca.HeaderText = "Cargo";
            this.Cca.Name = "Cca";
            this.Cca.ReadOnly = true;
            // 
            // Ct
            // 
            this.Ct.DataPropertyName = "telefono";
            this.Ct.HeaderText = "Telefono";
            this.Ct.Name = "Ct";
            this.Ct.ReadOnly = true;
            // 
            // Cc
            // 
            this.Cc.DataPropertyName = "correo";
            this.Cc.HeaderText = "Correo";
            this.Cc.Name = "Cc";
            this.Cc.ReadOnly = true;
            // 
            // idsu_em
            // 
            this.idsu_em.DataPropertyName = "idempleado_sucursal";
            this.idsu_em.HeaderText = "idsucur_empl";
            this.idsu_em.Name = "idsu_em";
            this.idsu_em.ReadOnly = true;
            this.idsu_em.Visible = false;
            // 
            // cdisu
            // 
            this.cdisu.DataPropertyName = "idsucursal";
            this.cdisu.HeaderText = "idsucur";
            this.cdisu.Name = "cdisu";
            this.cdisu.ReadOnly = true;
            this.cdisu.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.lblRegistro);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 516);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(444, 32);
            this.panel2.TabIndex = 1;
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Location = new System.Drawing.Point(239, 7);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(45, 19);
            this.lblRegistro.TabIndex = 0;
            this.lblRegistro.Text = "label9";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Silver;
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Controls.Add(this.txtBuscar);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(444, 41);
            this.panel5.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(350, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.Silver;
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Location = new System.Drawing.Point(80, 8);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(264, 26);
            this.txtBuscar.TabIndex = 0;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // error
            // 
            this.error.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.error.ContainerControl = this;
            // 
            // empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 594);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTitulo);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "empleados";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "empleados";
            this.Load += new System.EventHandler(this.empleados_Load);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablaEmpleados)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.PictureBox cerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDui;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox listaCargo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.ComboBox listaSucursales;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAgregarSucursal;
        private System.Windows.Forms.Button btnAgregaCargo;
        private System.Windows.Forms.ComboBox listaGenero;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.DataGridView tablaEmpleados;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ca;
        private System.Windows.Forms.DataGridViewTextBoxColumn suc;
        private System.Windows.Forms.DataGridViewTextBoxColumn c5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ccargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cc;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsu_em;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdisu;
        public System.Windows.Forms.Label lblEncanezado;
    }
}