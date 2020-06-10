namespace interfaces.compras
{
    partial class anular_compra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anular_compra));
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.cerrar = new System.Windows.Forms.PictureBox();
            this.lblEncanezado = new System.Windows.Forms.Label();
            this.fec = new System.Windows.Forms.DateTimePicker();
            this.listaVendedor = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAnular = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtJustificacion = new System.Windows.Forms.TextBox();
            this.anulacion = new System.Windows.Forms.GroupBox();
            this.reporte = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listaDocu = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fechaa = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.anulacion.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
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
            this.panelTitulo.Size = new System.Drawing.Size(886, 43);
            this.panelTitulo.TabIndex = 1;
            this.panelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitulo_MouseDown);
            // 
            // cerrar
            // 
            this.cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cerrar.Image = ((System.Drawing.Image)(resources.GetObject("cerrar.Image")));
            this.cerrar.Location = new System.Drawing.Point(841, 5);
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
            this.lblEncanezado.Location = new System.Drawing.Point(254, 14);
            this.lblEncanezado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEncanezado.Name = "lblEncanezado";
            this.lblEncanezado.Size = new System.Drawing.Size(195, 23);
            this.lblEncanezado.TabIndex = 0;
            this.lblEncanezado.Text = "Anulación de compras";
            // 
            // fec
            // 
            this.fec.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.fec.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fec.Location = new System.Drawing.Point(8, 406);
            this.fec.Name = "fec";
            this.fec.Size = new System.Drawing.Size(168, 26);
            this.fec.TabIndex = 21;
            // 
            // listaVendedor
            // 
            this.listaVendedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.listaVendedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.listaVendedor.BackColor = System.Drawing.SystemColors.Control;
            this.listaVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.listaVendedor.FormattingEnabled = true;
            this.listaVendedor.Location = new System.Drawing.Point(8, 448);
            this.listaVendedor.Name = "listaVendedor";
            this.listaVendedor.Size = new System.Drawing.Size(112, 27);
            this.listaVendedor.TabIndex = 20;
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(161, 499);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 30);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAnular
            // 
            this.btnAnular.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnAnular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnular.Location = new System.Drawing.Point(64, 499);
            this.btnAnular.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(89, 30);
            this.btnAnular.TabIndex = 18;
            this.btnAnular.Text = "Anular";
            this.btnAnular.UseVisualStyleBackColor = true;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtJustificacion);
            this.groupBox3.Location = new System.Drawing.Point(8, 234);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(297, 140);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Justificación";
            // 
            // txtJustificacion
            // 
            this.txtJustificacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtJustificacion.Location = new System.Drawing.Point(3, 22);
            this.txtJustificacion.Multiline = true;
            this.txtJustificacion.Name = "txtJustificacion";
            this.txtJustificacion.Size = new System.Drawing.Size(291, 115);
            this.txtJustificacion.TabIndex = 0;
            // 
            // anulacion
            // 
            this.anulacion.Controls.Add(this.reporte);
            this.anulacion.Dock = System.Windows.Forms.DockStyle.Right;
            this.anulacion.Location = new System.Drawing.Point(311, 43);
            this.anulacion.Name = "anulacion";
            this.anulacion.Size = new System.Drawing.Size(575, 504);
            this.anulacion.TabIndex = 16;
            this.anulacion.TabStop = false;
            this.anulacion.Text = "Detalle";
            // 
            // reporte
            // 
            this.reporte.ActiveViewIndex = -1;
            this.reporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reporte.Cursor = System.Windows.Forms.Cursors.Default;
            this.reporte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reporte.Location = new System.Drawing.Point(3, 22);
            this.reporte.Name = "reporte";
            this.reporte.Size = new System.Drawing.Size(569, 479);
            this.reporte.TabIndex = 0;
            this.reporte.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listaDocu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.fechaa);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(7, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 185);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Documento";
            // 
            // listaDocu
            // 
            this.listaDocu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.listaDocu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.listaDocu.BackColor = System.Drawing.Color.Silver;
            this.listaDocu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listaDocu.ForeColor = System.Drawing.Color.Black;
            this.listaDocu.FormattingEnabled = true;
            this.listaDocu.Location = new System.Drawing.Point(30, 122);
            this.listaDocu.Name = "listaDocu";
            this.listaDocu.Size = new System.Drawing.Size(237, 27);
            this.listaDocu.TabIndex = 14;
            this.listaDocu.SelectedIndexChanged += new System.EventHandler(this.listaDocu_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(26, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Fecha:";
            // 
            // fechaa
            // 
            this.fechaa.CustomFormat = "dd/MM/yyyy";
            this.fechaa.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaa.Location = new System.Drawing.Point(30, 52);
            this.fechaa.Name = "fechaa";
            this.fechaa.Size = new System.Drawing.Size(237, 26);
            this.fechaa.TabIndex = 12;
            this.fechaa.ValueChanged += new System.EventHandler(this.fechaa_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(26, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Número de documento:";
            // 
            // error
            // 
            this.error.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.error.ContainerControl = this;
            // 
            // anular_compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(886, 547);
            this.Controls.Add(this.fec);
            this.Controls.Add(this.listaVendedor);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAnular);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.anulacion);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelTitulo);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "anular_compra";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "anular_compra";
            this.Load += new System.EventHandler(this.anular_compra_Load);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.anulacion.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.PictureBox cerrar;
        public System.Windows.Forms.Label lblEncanezado;
        private System.Windows.Forms.DateTimePicker fec;
        private System.Windows.Forms.ComboBox listaVendedor;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtJustificacion;
        private System.Windows.Forms.GroupBox anulacion;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer reporte;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox listaDocu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker fechaa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider error;
    }
}