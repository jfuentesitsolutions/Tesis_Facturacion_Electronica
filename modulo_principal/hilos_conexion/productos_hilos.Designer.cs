namespace hilos_conexion
{
    partial class productos_hilos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tablad = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idmar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idesta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kardex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.utiliM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.utiliD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prvm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prvd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablad)).BeginInit();
            this.SuspendLayout();
            // 
            // tablad
            // 
            this.tablad.AllowUserToAddRows = false;
            this.tablad.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
            this.tablad.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.tablad.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tablad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column5,
            this.Column6,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15,
            this.Column16,
            this.Column17,
            this.Column18,
            this.Column19,
            this.Column20,
            this.Column23,
            this.Column22,
            this.idpr,
            this.idmar,
            this.idcat,
            this.idesta,
            this.kardex,
            this.fecha,
            this.utiliM,
            this.utiliD,
            this.prv,
            this.prc,
            this.prvm,
            this.prvd});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(96)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablad.DefaultCellStyle = dataGridViewCellStyle5;
            this.tablad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablad.Location = new System.Drawing.Point(0, 0);
            this.tablad.MultiSelect = false;
            this.tablad.Name = "tablad";
            this.tablad.ReadOnly = true;
            this.tablad.RowHeadersVisible = false;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tablad.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.tablad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablad.Size = new System.Drawing.Size(917, 327);
            this.tablad.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "idsp";
            this.Column1.HeaderText = "idsp";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "codigo";
            this.Column5.HeaderText = "Codi";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "nombre";
            this.Column6.HeaderText = "Nombre";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 360;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "cantipre";
            this.Column12.HeaderText = "N° p";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Visible = false;
            this.Column12.Width = 50;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "productoCod";
            this.Column13.HeaderText = "proc";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Visible = false;
            // 
            // Column14
            // 
            this.Column14.DataPropertyName = "precio";
            this.Column14.HeaderText = "Precio";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            this.Column14.Visible = false;
            this.Column14.Width = 45;
            // 
            // Column15
            // 
            this.Column15.DataPropertyName = "existencias";
            this.Column15.HeaderText = "Exist";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            this.Column15.Width = 50;
            // 
            // Column16
            // 
            this.Column16.DataPropertyName = "prese";
            this.Column16.HeaderText = "prese";
            this.Column16.Name = "Column16";
            this.Column16.ReadOnly = true;
            this.Column16.Visible = false;
            // 
            // Column17
            // 
            this.Column17.DataPropertyName = "prepro";
            this.Column17.HeaderText = "prep";
            this.Column17.Name = "Column17";
            this.Column17.ReadOnly = true;
            this.Column17.Visible = false;
            // 
            // Column18
            // 
            this.Column18.DataPropertyName = "ud";
            this.Column18.HeaderText = "u";
            this.Column18.Name = "Column18";
            this.Column18.ReadOnly = true;
            this.Column18.Visible = false;
            // 
            // Column19
            // 
            this.Column19.DataPropertyName = "um";
            this.Column19.HeaderText = "m";
            this.Column19.Name = "Column19";
            this.Column19.ReadOnly = true;
            this.Column19.Visible = false;
            // 
            // Column20
            // 
            this.Column20.DataPropertyName = "tipo";
            this.Column20.HeaderText = "tp";
            this.Column20.Name = "Column20";
            this.Column20.ReadOnly = true;
            this.Column20.Visible = false;
            // 
            // Column23
            // 
            this.Column23.DataPropertyName = "pre";
            this.Column23.HeaderText = "Precio";
            this.Column23.Name = "Column23";
            this.Column23.ReadOnly = true;
            this.Column23.Width = 60;
            // 
            // Column22
            // 
            this.Column22.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column22.DataPropertyName = "cantipre";
            this.Column22.HeaderText = "N° ";
            this.Column22.Name = "Column22";
            this.Column22.ReadOnly = true;
            // 
            // idpr
            // 
            this.idpr.DataPropertyName = "idproducto";
            this.idpr.HeaderText = "idpro";
            this.idpr.Name = "idpr";
            this.idpr.ReadOnly = true;
            this.idpr.Visible = false;
            // 
            // idmar
            // 
            this.idmar.DataPropertyName = "idmarca";
            this.idmar.HeaderText = "idmar";
            this.idmar.Name = "idmar";
            this.idmar.ReadOnly = true;
            this.idmar.Visible = false;
            // 
            // idcat
            // 
            this.idcat.DataPropertyName = "idcategoria";
            this.idcat.HeaderText = "idcate";
            this.idcat.Name = "idcat";
            this.idcat.ReadOnly = true;
            this.idcat.Visible = false;
            // 
            // idesta
            // 
            this.idesta.DataPropertyName = "idestante";
            this.idesta.HeaderText = "idestan";
            this.idesta.Name = "idesta";
            this.idesta.ReadOnly = true;
            this.idesta.Visible = false;
            // 
            // kardex
            // 
            this.kardex.DataPropertyName = "kardex";
            this.kardex.HeaderText = "karde";
            this.kardex.Name = "kardex";
            this.kardex.ReadOnly = true;
            this.kardex.Visible = false;
            // 
            // fecha
            // 
            this.fecha.DataPropertyName = "fecha_ingreso";
            this.fecha.HeaderText = "fe";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Visible = false;
            // 
            // utiliM
            // 
            this.utiliM.DataPropertyName = "idutilidadMayoreo";
            this.utiliM.HeaderText = "UM";
            this.utiliM.Name = "utiliM";
            this.utiliM.ReadOnly = true;
            this.utiliM.Visible = false;
            // 
            // utiliD
            // 
            this.utiliD.DataPropertyName = "idutilidadDetalles";
            this.utiliD.HeaderText = "UD";
            this.utiliD.Name = "utiliD";
            this.utiliD.ReadOnly = true;
            this.utiliD.Visible = false;
            // 
            // prv
            // 
            this.prv.DataPropertyName = "precio_venta";
            this.prv.HeaderText = "PV";
            this.prv.Name = "prv";
            this.prv.ReadOnly = true;
            this.prv.Visible = false;
            // 
            // prc
            // 
            this.prc.DataPropertyName = "precio_compra";
            this.prc.HeaderText = "PC";
            this.prc.Name = "prc";
            this.prc.ReadOnly = true;
            this.prc.Visible = false;
            // 
            // prvm
            // 
            this.prvm.DataPropertyName = "precio_ventaM";
            this.prvm.HeaderText = "PVM";
            this.prvm.Name = "prvm";
            this.prvm.ReadOnly = true;
            this.prvm.Visible = false;
            // 
            // prvd
            // 
            this.prvd.DataPropertyName = "precio_compraM";
            this.prvd.HeaderText = "PCM";
            this.prvd.Name = "prvd";
            this.prvd.ReadOnly = true;
            this.prvd.Visible = false;
            // 
            // productos_hilos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 327);
            this.Controls.Add(this.tablad);
            this.Name = "productos_hilos";
            this.Text = "productos_hilos";
            this.Load += new System.EventHandler(this.productos_hilos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tablad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column19;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column20;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column23;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column22;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpr;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcat;
        private System.Windows.Forms.DataGridViewTextBoxColumn idesta;
        private System.Windows.Forms.DataGridViewTextBoxColumn kardex;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn utiliM;
        private System.Windows.Forms.DataGridViewTextBoxColumn utiliD;
        private System.Windows.Forms.DataGridViewTextBoxColumn prv;
        private System.Windows.Forms.DataGridViewTextBoxColumn prc;
        private System.Windows.Forms.DataGridViewTextBoxColumn prvm;
        private System.Windows.Forms.DataGridViewTextBoxColumn prvd;
    }
}