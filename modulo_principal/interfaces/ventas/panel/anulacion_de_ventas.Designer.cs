namespace interfaces.ventas.panel
{
    partial class anulacion_de_ventas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listaDocu = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.listaDocumentos = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.anulacion = new System.Windows.Forms.GroupBox();
            this.reporte = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtJustificacion = new System.Windows.Forms.TextBox();
            this.btnAnular = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.listaVendedor = new System.Windows.Forms.ComboBox();
            this.fec = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.anulacion.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listaDocu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.fecha);
            this.groupBox1.Controls.Add(this.listaDocumentos);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 232);
            this.groupBox1.TabIndex = 8;
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
            this.listaDocu.Location = new System.Drawing.Point(30, 175);
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
            // fecha
            // 
            this.fecha.CustomFormat = "dd/MM/yyyy";
            this.fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fecha.Location = new System.Drawing.Point(30, 52);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(237, 26);
            this.fecha.TabIndex = 12;
            this.fecha.ValueChanged += new System.EventHandler(this.fecha_ValueChanged);
            // 
            // listaDocumentos
            // 
            this.listaDocumentos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.listaDocumentos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.listaDocumentos.BackColor = System.Drawing.Color.Silver;
            this.listaDocumentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listaDocumentos.ForeColor = System.Drawing.Color.Black;
            this.listaDocumentos.FormattingEnabled = true;
            this.listaDocumentos.Items.AddRange(new object[] {
            "Tickets",
            "Facturas"});
            this.listaDocumentos.Location = new System.Drawing.Point(30, 114);
            this.listaDocumentos.Name = "listaDocumentos";
            this.listaDocumentos.Size = new System.Drawing.Size(237, 27);
            this.listaDocumentos.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(26, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tipo documento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(26, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Número de documento:";
            // 
            // anulacion
            // 
            this.anulacion.Controls.Add(this.reporte);
            this.anulacion.Dock = System.Windows.Forms.DockStyle.Right;
            this.anulacion.Location = new System.Drawing.Point(321, 0);
            this.anulacion.Name = "anulacion";
            this.anulacion.Size = new System.Drawing.Size(560, 580);
            this.anulacion.TabIndex = 9;
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
            this.reporte.Size = new System.Drawing.Size(554, 555);
            this.reporte.TabIndex = 0;
            this.reporte.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtJustificacion);
            this.groupBox3.Location = new System.Drawing.Point(13, 239);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(297, 140);
            this.groupBox3.TabIndex = 10;
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
            // btnAnular
            // 
            this.btnAnular.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnAnular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnular.Location = new System.Drawing.Point(69, 537);
            this.btnAnular.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(89, 30);
            this.btnAnular.TabIndex = 11;
            this.btnAnular.Text = "Anular";
            this.btnAnular.UseVisualStyleBackColor = true;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(166, 537);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 30);
            this.button1.TabIndex = 12;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // error
            // 
            this.error.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.error.ContainerControl = this;
            // 
            // listaVendedor
            // 
            this.listaVendedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.listaVendedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.listaVendedor.BackColor = System.Drawing.SystemColors.Control;
            this.listaVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.listaVendedor.FormattingEnabled = true;
            this.listaVendedor.Location = new System.Drawing.Point(13, 490);
            this.listaVendedor.Name = "listaVendedor";
            this.listaVendedor.Size = new System.Drawing.Size(112, 27);
            this.listaVendedor.TabIndex = 13;
            // 
            // fec
            // 
            this.fec.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.fec.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fec.Location = new System.Drawing.Point(12, 458);
            this.fec.Name = "fec";
            this.fec.Size = new System.Drawing.Size(168, 26);
            this.fec.TabIndex = 14;
            // 
            // anulacion_de_ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(881, 580);
            this.Controls.Add(this.fec);
            this.Controls.Add(this.listaVendedor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAnular);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.anulacion);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "anulacion_de_ventas";
            this.Opacity = 0.98D;
            this.Text = "anulacion_de_ventas";
            this.Load += new System.EventHandler(this.anulacion_de_ventas_Load);
            this.SizeChanged += new System.EventHandler(this.anulacion_de_ventas_SizeChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.anulacion.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.ComboBox listaDocumentos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox anulacion;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer reporte;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtJustificacion;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.ComboBox listaDocu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.ComboBox listaVendedor;
        private System.Windows.Forms.DateTimePicker fec;
    }
}