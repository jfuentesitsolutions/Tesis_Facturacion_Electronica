namespace interfaces.mantenimientos
{
    partial class usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usuarios));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.cerrar = new System.Windows.Forms.PictureBox();
            this.lblEncanezado = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.mostrar2 = new System.Windows.Forms.CheckBox();
            this.mostrar = new System.Windows.Forms.CheckBox();
            this.noCoincide = new System.Windows.Forms.PictureBox();
            this.coincide = new System.Windows.Forms.PictureBox();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.chkCambiarC = new System.Windows.Forms.CheckBox();
            this.listaGrupos = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listaEmpleado = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRcontra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabla_usuarios = new System.Windows.Forms.DataGridView();
            this.Cid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.est = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ce = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idemp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idgr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.noCoincide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coincide)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_usuarios)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(74)))), ((int)(((byte)(94)))));
            this.panelTitulo.Controls.Add(this.cerrar);
            this.panelTitulo.Controls.Add(this.lblEncanezado);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(775, 46);
            this.panelTitulo.TabIndex = 6;
            this.panelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // cerrar
            // 
            this.cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cerrar.Image = ((System.Drawing.Image)(resources.GetObject("cerrar.Image")));
            this.cerrar.Location = new System.Drawing.Point(728, 6);
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
            this.lblEncanezado.Location = new System.Drawing.Point(255, 9);
            this.lblEncanezado.Name = "lblEncanezado";
            this.lblEncanezado.Size = new System.Drawing.Size(235, 23);
            this.lblEncanezado.TabIndex = 0;
            this.lblEncanezado.Text = "Ingreso de nuevos usuarios";
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.mostrar2);
            this.panel3.Controls.Add(this.mostrar);
            this.panel3.Controls.Add(this.noCoincide);
            this.panel3.Controls.Add(this.coincide);
            this.panel3.Controls.Add(this.chkEstado);
            this.panel3.Controls.Add(this.chkCambiarC);
            this.panel3.Controls.Add(this.listaGrupos);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.listaEmpleado);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtRcontra);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtContra);
            this.panel3.Controls.Add(this.txtNombre);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnCancelar);
            this.panel3.Controls.Add(this.btnGuardar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(322, 439);
            this.panel3.TabIndex = 0;
            // 
            // mostrar2
            // 
            this.mostrar2.AutoSize = true;
            this.mostrar2.Location = new System.Drawing.Point(213, 189);
            this.mostrar2.Name = "mostrar2";
            this.mostrar2.Size = new System.Drawing.Size(77, 23);
            this.mostrar2.TabIndex = 16;
            this.mostrar2.Text = "Mostrar";
            this.mostrar2.UseVisualStyleBackColor = true;
            this.mostrar2.CheckedChanged += new System.EventHandler(this.mostrar2_CheckedChanged);
            // 
            // mostrar
            // 
            this.mostrar.AutoSize = true;
            this.mostrar.Location = new System.Drawing.Point(213, 129);
            this.mostrar.Name = "mostrar";
            this.mostrar.Size = new System.Drawing.Size(77, 23);
            this.mostrar.TabIndex = 15;
            this.mostrar.Text = "Mostrar";
            this.mostrar.UseVisualStyleBackColor = true;
            this.mostrar.CheckedChanged += new System.EventHandler(this.mostrar_CheckedChanged);
            // 
            // noCoincide
            // 
            this.noCoincide.Image = ((System.Drawing.Image)(resources.GetObject("noCoincide.Image")));
            this.noCoincide.Location = new System.Drawing.Point(296, 196);
            this.noCoincide.Name = "noCoincide";
            this.noCoincide.Size = new System.Drawing.Size(16, 16);
            this.noCoincide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.noCoincide.TabIndex = 14;
            this.noCoincide.TabStop = false;
            this.noCoincide.Visible = false;
            // 
            // coincide
            // 
            this.coincide.Image = ((System.Drawing.Image)(resources.GetObject("coincide.Image")));
            this.coincide.Location = new System.Drawing.Point(296, 196);
            this.coincide.Name = "coincide";
            this.coincide.Size = new System.Drawing.Size(16, 16);
            this.coincide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.coincide.TabIndex = 13;
            this.coincide.TabStop = false;
            this.coincide.Visible = false;
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Location = new System.Drawing.Point(220, 357);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(70, 23);
            this.chkEstado.TabIndex = 5;
            this.chkEstado.Text = "Estado";
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // chkCambiarC
            // 
            this.chkCambiarC.AutoSize = true;
            this.chkCambiarC.Location = new System.Drawing.Point(141, 18);
            this.chkCambiarC.Name = "chkCambiarC";
            this.chkCambiarC.Size = new System.Drawing.Size(149, 23);
            this.chkCambiarC.TabIndex = 12;
            this.chkCambiarC.Text = "Cambiar contraseña";
            this.chkCambiarC.UseVisualStyleBackColor = true;
            this.chkCambiarC.Visible = false;
            this.chkCambiarC.CheckedChanged += new System.EventHandler(this.chkCambiarC_CheckedChanged);
            // 
            // listaGrupos
            // 
            this.listaGrupos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.listaGrupos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.listaGrupos.BackColor = System.Drawing.Color.Silver;
            this.listaGrupos.DisplayMember = "hola";
            this.listaGrupos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listaGrupos.ForeColor = System.Drawing.Color.Black;
            this.listaGrupos.FormattingEnabled = true;
            this.listaGrupos.Location = new System.Drawing.Point(26, 313);
            this.listaGrupos.Name = "listaGrupos";
            this.listaGrupos.Size = new System.Drawing.Size(264, 27);
            this.listaGrupos.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(22, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Miembro del grupo:";
            // 
            // listaEmpleado
            // 
            this.listaEmpleado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.listaEmpleado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.listaEmpleado.BackColor = System.Drawing.Color.Silver;
            this.listaEmpleado.DisplayMember = "hola";
            this.listaEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listaEmpleado.ForeColor = System.Drawing.Color.Black;
            this.listaEmpleado.FormattingEnabled = true;
            this.listaEmpleado.Location = new System.Drawing.Point(26, 250);
            this.listaEmpleado.Name = "listaEmpleado";
            this.listaEmpleado.Size = new System.Drawing.Size(264, 27);
            this.listaEmpleado.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(22, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nombre del empleado:";
            // 
            // txtRcontra
            // 
            this.txtRcontra.BackColor = System.Drawing.Color.Silver;
            this.txtRcontra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRcontra.Location = new System.Drawing.Point(26, 186);
            this.txtRcontra.Name = "txtRcontra";
            this.txtRcontra.Size = new System.Drawing.Size(178, 26);
            this.txtRcontra.TabIndex = 2;
            this.txtRcontra.UseSystemPasswordChar = true;
            this.txtRcontra.Leave += new System.EventHandler(this.txtRcontra_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(22, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Repita la contraseña:";
            // 
            // txtContra
            // 
            this.txtContra.BackColor = System.Drawing.Color.Silver;
            this.txtContra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContra.Location = new System.Drawing.Point(26, 126);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(178, 26);
            this.txtContra.TabIndex = 1;
            this.txtContra.UseSystemPasswordChar = true;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.Silver;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Location = new System.Drawing.Point(26, 71);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(264, 26);
            this.txtNombre.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(22, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contraseña:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(22, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre del usuario:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(169, 395);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 29);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(79, 395);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 29);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabla_usuarios);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(322, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 439);
            this.panel1.TabIndex = 10;
            // 
            // tabla_usuarios
            // 
            this.tabla_usuarios.AllowUserToAddRows = false;
            this.tabla_usuarios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Lavender;
            this.tabla_usuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.tabla_usuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabla_usuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.tabla_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla_usuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cid,
            this.Cu,
            this.est,
            this.Ce,
            this.idemp,
            this.idgr});
            this.tabla_usuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabla_usuarios.Location = new System.Drawing.Point(0, 41);
            this.tabla_usuarios.MultiSelect = false;
            this.tabla_usuarios.Name = "tabla_usuarios";
            this.tabla_usuarios.ReadOnly = true;
            this.tabla_usuarios.RowHeadersVisible = false;
            this.tabla_usuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabla_usuarios.Size = new System.Drawing.Size(453, 366);
            this.tabla_usuarios.TabIndex = 1;
            this.tabla_usuarios.Click += new System.EventHandler(this.tabla_usuarios_Click);
            // 
            // Cid
            // 
            this.Cid.DataPropertyName = "idusuario";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Cid.DefaultCellStyle = dataGridViewCellStyle9;
            this.Cid.HeaderText = "ID";
            this.Cid.Name = "Cid";
            this.Cid.ReadOnly = true;
            this.Cid.Width = 75;
            // 
            // Cu
            // 
            this.Cu.DataPropertyName = "usuario";
            this.Cu.HeaderText = "Usuario";
            this.Cu.Name = "Cu";
            this.Cu.ReadOnly = true;
            // 
            // est
            // 
            this.est.DataPropertyName = "estado";
            this.est.HeaderText = "Estado";
            this.est.Name = "est";
            this.est.ReadOnly = true;
            // 
            // Ce
            // 
            this.Ce.DataPropertyName = "nombres";
            this.Ce.HeaderText = "Nombre Empleado";
            this.Ce.Name = "Ce";
            this.Ce.ReadOnly = true;
            this.Ce.Width = 275;
            // 
            // idemp
            // 
            this.idemp.DataPropertyName = "idempleado_sucursal";
            this.idemp.HeaderText = "idempleado_suc";
            this.idemp.Name = "idemp";
            this.idemp.ReadOnly = true;
            this.idemp.Visible = false;
            // 
            // idgr
            // 
            this.idgr.DataPropertyName = "idgrupo";
            this.idgr.HeaderText = "idgrupos";
            this.idgr.Name = "idgr";
            this.idgr.ReadOnly = true;
            this.idgr.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblRegistro);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 407);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(453, 32);
            this.panel2.TabIndex = 1;
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Location = new System.Drawing.Point(263, 7);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(45, 19);
            this.lblRegistro.TabIndex = 0;
            this.lblRegistro.Text = "label6";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Silver;
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Controls.Add(this.txtBuscar);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(453, 41);
            this.panel5.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(342, 4);
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
            this.txtBuscar.Location = new System.Drawing.Point(72, 8);
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
            // usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(775, 485);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelTitulo);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "usuarios";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "usuarios";
            this.Load += new System.EventHandler(this.usuarios_Load);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.noCoincide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coincide)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabla_usuarios)).EndInit();
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
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRcontra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.ComboBox listaEmpleado;
        private System.Windows.Forms.ComboBox listaGrupos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkCambiarC;
        private System.Windows.Forms.CheckBox chkEstado;
        private System.Windows.Forms.DataGridView tabla_usuarios;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cu;
        private System.Windows.Forms.DataGridViewTextBoxColumn est;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ce;
        private System.Windows.Forms.DataGridViewTextBoxColumn idemp;
        private System.Windows.Forms.DataGridViewTextBoxColumn idgr;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.PictureBox coincide;
        private System.Windows.Forms.PictureBox noCoincide;
        private System.Windows.Forms.CheckBox mostrar;
        private System.Windows.Forms.CheckBox mostrar2;
        public System.Windows.Forms.Label lblEncanezado;
    }
}