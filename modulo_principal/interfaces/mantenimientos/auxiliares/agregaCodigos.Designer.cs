namespace interfaces.mantenimientos.auxiliares
{
    partial class agregaCodigos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(agregaCodigos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.cerrar = new System.Windows.Forms.PictureBox();
            this.lblEncanezado = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkDesac = new System.Windows.Forms.RadioButton();
            this.chkActi = new System.Windows.Forms.RadioButton();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tablaCodigos = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.est = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idprese = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregar = new System.Windows.Forms.PictureBox();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnModifica = new System.Windows.Forms.PictureBox();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCodigos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnModifica)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(121)))), ((int)(((byte)(23)))));
            this.panelTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTitulo.Controls.Add(this.cerrar);
            this.panelTitulo.Controls.Add(this.lblEncanezado);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(626, 52);
            this.panelTitulo.TabIndex = 7;
            this.panelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitulo_MouseDown);
            // 
            // cerrar
            // 
            this.cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cerrar.Image = ((System.Drawing.Image)(resources.GetObject("cerrar.Image")));
            this.cerrar.Location = new System.Drawing.Point(564, 4);
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
            this.lblEncanezado.Location = new System.Drawing.Point(196, 13);
            this.lblEncanezado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEncanezado.Name = "lblEncanezado";
            this.lblEncanezado.Size = new System.Drawing.Size(144, 23);
            this.lblEncanezado.TabIndex = 0;
            this.lblEncanezado.Text = "Nuevos codigos";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkDesac);
            this.groupBox1.Controls.Add(this.chkActi);
            this.groupBox1.Controls.Add(this.lblEstado);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 173);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nuevo codigo";
            // 
            // chkDesac
            // 
            this.chkDesac.AutoSize = true;
            this.chkDesac.Location = new System.Drawing.Point(119, 117);
            this.chkDesac.Name = "chkDesac";
            this.chkDesac.Size = new System.Drawing.Size(102, 23);
            this.chkDesac.TabIndex = 2;
            this.chkDesac.TabStop = true;
            this.chkDesac.Text = "Desactivado";
            this.chkDesac.UseVisualStyleBackColor = true;
            // 
            // chkActi
            // 
            this.chkActi.AutoSize = true;
            this.chkActi.Location = new System.Drawing.Point(14, 117);
            this.chkActi.Name = "chkActi";
            this.chkActi.Size = new System.Drawing.Size(82, 23);
            this.chkActi.TabIndex = 1;
            this.chkActi.TabStop = true;
            this.chkActi.Text = "Activado";
            this.chkActi.UseVisualStyleBackColor = true;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(10, 93);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(54, 19);
            this.lblEstado.TabIndex = 3;
            this.lblEstado.Text = "Estado:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.Silver;
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.Location = new System.Drawing.Point(7, 53);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(227, 26);
            this.txtCodigo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tablaCodigos);
            this.groupBox2.Location = new System.Drawing.Point(317, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(295, 173);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Codigos agregados";
            // 
            // tablaCodigos
            // 
            this.tablaCodigos.AllowUserToAddRows = false;
            this.tablaCodigos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tablaCodigos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaCodigos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaCodigos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tablaCodigos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaCodigos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.codi,
            this.est,
            this.idprese});
            this.tablaCodigos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablaCodigos.Location = new System.Drawing.Point(3, 22);
            this.tablaCodigos.MultiSelect = false;
            this.tablaCodigos.Name = "tablaCodigos";
            this.tablaCodigos.ReadOnly = true;
            this.tablaCodigos.RowHeadersVisible = false;
            this.tablaCodigos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaCodigos.Size = new System.Drawing.Size(289, 148);
            this.tablaCodigos.TabIndex = 0;
            this.tablaCodigos.Click += new System.EventHandler(this.tablaCodigos_Click);
            // 
            // id
            // 
            this.id.DataPropertyName = "idcodigo";
            this.id.HeaderText = "IDc";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // codi
            // 
            this.codi.DataPropertyName = "codigo";
            this.codi.HeaderText = "Codigo";
            this.codi.Name = "codi";
            this.codi.ReadOnly = true;
            this.codi.Width = 200;
            // 
            // est
            // 
            this.est.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.est.DataPropertyName = "estado";
            this.est.HeaderText = "Estado";
            this.est.Name = "est";
            this.est.ReadOnly = true;
            // 
            // idprese
            // 
            this.idprese.DataPropertyName = "idproducto_codigo";
            this.idprese.HeaderText = "presenta";
            this.idprese.Name = "idprese";
            this.idprese.ReadOnly = true;
            this.idprese.Visible = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(269, 104);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(32, 32);
            this.btnAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.TabStop = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // btnModifica
            // 
            this.btnModifica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifica.Image = global::interfaces.Properties.Resources.refresh;
            this.btnModifica.Location = new System.Drawing.Point(263, 147);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(48, 48);
            this.btnModifica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnModifica.TabIndex = 11;
            this.btnModifica.TabStop = false;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // agregaCodigos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(626, 246);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelTitulo);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "agregaCodigos";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "agregaCodigos";
            this.Load += new System.EventHandler(this.agregaCodigos_Load);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablaCodigos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnModifica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.PictureBox cerrar;
        public System.Windows.Forms.Label lblEncanezado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView tablaCodigos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton chkDesac;
        private System.Windows.Forms.RadioButton chkActi;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.PictureBox btnAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn codi;
        private System.Windows.Forms.DataGridViewTextBoxColumn est;
        private System.Windows.Forms.DataGridViewTextBoxColumn idprese;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.PictureBox btnModifica;
        public System.Windows.Forms.TextBox txtCodigo;
    }
}