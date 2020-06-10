namespace interfaces.mantenimientos.auxiliares
{
    partial class cuentas_proveedores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cuentas_proveedores));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tablaCuentas = new System.Windows.Forms.DataGridView();
            this.Cid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cnombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cdescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblReg = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.quit = new System.Windows.Forms.PictureBox();
            this.agre = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnBancoNuevo = new System.Windows.Forms.Button();
            this.listaBanco = new System.Windows.Forms.ComboBox();
            this.txtNumCuenta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.cerrar = new System.Windows.Forms.PictureBox();
            this.lblEncanezado = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCuentas)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agre)).BeginInit();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panelTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(677, 334);
            this.panel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(322, 46);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(355, 288);
            this.panel4.TabIndex = 7;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.tablaCuentas);
            this.panel6.Controls.Add(this.panel2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 41);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(353, 245);
            this.panel6.TabIndex = 3;
            // 
            // tablaCuentas
            // 
            this.tablaCuentas.AllowUserToAddRows = false;
            this.tablaCuentas.AllowUserToDeleteRows = false;
            this.tablaCuentas.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tablaCuentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.tablaCuentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaCuentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaCuentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.tablaCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaCuentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cid,
            this.Cnombre,
            this.Cdescripcion,
            this.c4,
            this.c5});
            this.tablaCuentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablaCuentas.Location = new System.Drawing.Point(0, 0);
            this.tablaCuentas.MultiSelect = false;
            this.tablaCuentas.Name = "tablaCuentas";
            this.tablaCuentas.ReadOnly = true;
            this.tablaCuentas.RowHeadersVisible = false;
            this.tablaCuentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaCuentas.Size = new System.Drawing.Size(353, 217);
            this.tablaCuentas.TabIndex = 0;
            this.tablaCuentas.Click += new System.EventHandler(this.tablaCuentas_Click);
            // 
            // Cid
            // 
            this.Cid.DataPropertyName = "idcuenta_proveedor";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Cid.DefaultCellStyle = dataGridViewCellStyle6;
            this.Cid.HeaderText = "IDcuenta_prove";
            this.Cid.Name = "Cid";
            this.Cid.ReadOnly = true;
            this.Cid.Visible = false;
            this.Cid.Width = 75;
            // 
            // Cnombre
            // 
            this.Cnombre.DataPropertyName = "nombre";
            this.Cnombre.HeaderText = "Banco";
            this.Cnombre.Name = "Cnombre";
            this.Cnombre.ReadOnly = true;
            this.Cnombre.Width = 150;
            // 
            // Cdescripcion
            // 
            this.Cdescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cdescripcion.DataPropertyName = "numero_cuenta";
            this.Cdescripcion.HeaderText = "Número de cuenta";
            this.Cdescripcion.Name = "Cdescripcion";
            this.Cdescripcion.ReadOnly = true;
            // 
            // c4
            // 
            this.c4.DataPropertyName = "idproveedor";
            this.c4.HeaderText = "idpro";
            this.c4.Name = "c4";
            this.c4.ReadOnly = true;
            this.c4.Visible = false;
            // 
            // c5
            // 
            this.c5.DataPropertyName = "idbanco";
            this.c5.HeaderText = "idbanco";
            this.c5.Name = "c5";
            this.c5.ReadOnly = true;
            this.c5.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.lblReg);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 217);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(353, 28);
            this.panel2.TabIndex = 1;
            // 
            // lblReg
            // 
            this.lblReg.AutoSize = true;
            this.lblReg.Location = new System.Drawing.Point(196, 5);
            this.lblReg.Name = "lblReg";
            this.lblReg.Size = new System.Drawing.Size(45, 19);
            this.lblReg.TabIndex = 0;
            this.lblReg.Text = "label3";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Silver;
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Controls.Add(this.txtBuscar);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(353, 41);
            this.panel5.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(316, 4);
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
            this.txtBuscar.Location = new System.Drawing.Point(46, 8);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(264, 26);
            this.txtBuscar.TabIndex = 0;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.quit);
            this.panel3.Controls.Add(this.agre);
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Controls.Add(this.btnBancoNuevo);
            this.panel3.Controls.Add(this.listaBanco);
            this.panel3.Controls.Add(this.txtNumCuenta);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnGuardar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(322, 288);
            this.panel3.TabIndex = 0;
            // 
            // quit
            // 
            this.quit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quit.Image = ((System.Drawing.Image)(resources.GetObject("quit.Image")));
            this.quit.Location = new System.Drawing.Point(160, 180);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(32, 32);
            this.quit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.quit.TabIndex = 8;
            this.quit.TabStop = false;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // agre
            // 
            this.agre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.agre.Image = ((System.Drawing.Image)(resources.GetObject("agre.Image")));
            this.agre.Location = new System.Drawing.Point(119, 180);
            this.agre.Name = "agre";
            this.agre.Size = new System.Drawing.Size(32, 32);
            this.agre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.agre.TabIndex = 7;
            this.agre.TabStop = false;
            this.agre.Click += new System.EventHandler(this.agre_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(160, 247);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 29);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnBancoNuevo
            // 
            this.btnBancoNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBancoNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnBancoNuevo.Image")));
            this.btnBancoNuevo.Location = new System.Drawing.Point(266, 63);
            this.btnBancoNuevo.Name = "btnBancoNuevo";
            this.btnBancoNuevo.Size = new System.Drawing.Size(27, 27);
            this.btnBancoNuevo.TabIndex = 1;
            this.btnBancoNuevo.UseVisualStyleBackColor = true;
            this.btnBancoNuevo.Click += new System.EventHandler(this.btnBancoNuevo_Click);
            // 
            // listaBanco
            // 
            this.listaBanco.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.listaBanco.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.listaBanco.BackColor = System.Drawing.Color.Silver;
            this.listaBanco.DisplayMember = "hola";
            this.listaBanco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listaBanco.ForeColor = System.Drawing.Color.Black;
            this.listaBanco.FormattingEnabled = true;
            this.listaBanco.Location = new System.Drawing.Point(29, 63);
            this.listaBanco.Name = "listaBanco";
            this.listaBanco.Size = new System.Drawing.Size(231, 27);
            this.listaBanco.TabIndex = 0;
            // 
            // txtNumCuenta
            // 
            this.txtNumCuenta.BackColor = System.Drawing.Color.Silver;
            this.txtNumCuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumCuenta.Location = new System.Drawing.Point(29, 135);
            this.txtNumCuenta.Name = "txtNumCuenta";
            this.txtNumCuenta.Size = new System.Drawing.Size(264, 26);
            this.txtNumCuenta.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(25, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Número de cuenta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(25, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre del banco:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(74, 247);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 29);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(127)))), ((int)(((byte)(86)))));
            this.panelTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTitulo.Controls.Add(this.cerrar);
            this.panelTitulo.Controls.Add(this.lblEncanezado);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(677, 46);
            this.panelTitulo.TabIndex = 5;
            this.panelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitulo_MouseDown);
            // 
            // cerrar
            // 
            this.cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cerrar.Image = ((System.Drawing.Image)(resources.GetObject("cerrar.Image")));
            this.cerrar.Location = new System.Drawing.Point(628, 6);
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
            this.lblEncanezado.Location = new System.Drawing.Point(246, 11);
            this.lblEncanezado.Name = "lblEncanezado";
            this.lblEncanezado.Size = new System.Drawing.Size(224, 23);
            this.lblEncanezado.TabIndex = 0;
            this.lblEncanezado.Text = "Ingreso de nuevas cuentas";
            // 
            // error
            // 
            this.error.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.error.ContainerControl = this;
            // 
            // cuentas_proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 334);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "cuentas_proveedores";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cuentas_proveedores";
            this.Load += new System.EventHandler(this.cuentas_proveedores_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablaCuentas)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agre)).EndInit();
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblReg;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtNumCuenta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.PictureBox cerrar;
        private System.Windows.Forms.Label lblEncanezado;
        private System.Windows.Forms.ComboBox listaBanco;
        private System.Windows.Forms.Button btnBancoNuevo;
        private System.Windows.Forms.ErrorProvider error;
        public System.Windows.Forms.DataGridView tablaCuentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cnombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cdescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn c4;
        private System.Windows.Forms.DataGridViewTextBoxColumn c5;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox quit;
        private System.Windows.Forms.PictureBox agre;
    }
}