namespace interfaces.cajas_efectivo
{
    partial class revisar_caja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(revisar_caja));
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.lblEncanezado = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblAnula_Compras = new System.Windows.Forms.Label();
            this.lblVentaT = new System.Windows.Forms.Label();
            this.lblVentaF = new System.Windows.Forms.Label();
            this.lblAnulacion = new System.Windows.Forms.Label();
            this.lblGanan = new System.Windows.Forms.Label();
            this.lblTota = new System.Windows.Forms.Label();
            this.lblCompra = new System.Windows.Forms.Label();
            this.lblGastoOpe = new System.Windows.Forms.Label();
            this.lblinicial = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cerrar = new System.Windows.Forms.PictureBox();
            this.panelTitulo.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(182)))), ((int)(((byte)(172)))));
            this.panelTitulo.Controls.Add(this.cerrar);
            this.panelTitulo.Controls.Add(this.lblEncanezado);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(423, 43);
            this.panelTitulo.TabIndex = 2;
            this.panelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitulo_MouseDown);
            // 
            // lblEncanezado
            // 
            this.lblEncanezado.AutoSize = true;
            this.lblEncanezado.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncanezado.ForeColor = System.Drawing.Color.White;
            this.lblEncanezado.Location = new System.Drawing.Point(124, 9);
            this.lblEncanezado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEncanezado.Name = "lblEncanezado";
            this.lblEncanezado.Size = new System.Drawing.Size(169, 23);
            this.lblEncanezado.TabIndex = 0;
            this.lblEncanezado.Text = "Resumen de la caja";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.196F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.85043F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.16764F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.78593F));
            this.tableLayoutPanel1.Controls.Add(this.btnCerrar, 3, 10);
            this.tableLayoutPanel1.Controls.Add(this.label7, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.lblGanan, 2, 9);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.lblTota, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblCompra, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblGastoOpe, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.label8, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblAnula_Compras, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblAnulacion, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblVentaF, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblVentaT, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label9, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblinicial, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 43);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 12;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(423, 438);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // lblAnula_Compras
            // 
            this.lblAnula_Compras.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAnula_Compras.AutoSize = true;
            this.lblAnula_Compras.Location = new System.Drawing.Point(256, 180);
            this.lblAnula_Compras.Name = "lblAnula_Compras";
            this.lblAnula_Compras.Size = new System.Drawing.Size(51, 40);
            this.lblAnula_Compras.TabIndex = 20;
            this.lblAnula_Compras.Text = "label8";
            this.lblAnula_Compras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblVentaT
            // 
            this.lblVentaT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblVentaT.AutoSize = true;
            this.lblVentaT.Location = new System.Drawing.Point(256, 60);
            this.lblVentaT.Name = "lblVentaT";
            this.lblVentaT.Size = new System.Drawing.Size(51, 40);
            this.lblVentaT.TabIndex = 12;
            this.lblVentaT.Text = "label8";
            this.lblVentaT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblVentaF
            // 
            this.lblVentaF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblVentaF.AutoSize = true;
            this.lblVentaF.Location = new System.Drawing.Point(256, 100);
            this.lblVentaF.Name = "lblVentaF";
            this.lblVentaF.Size = new System.Drawing.Size(51, 40);
            this.lblVentaF.TabIndex = 13;
            this.lblVentaF.Text = "label8";
            this.lblVentaF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAnulacion
            // 
            this.lblAnulacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAnulacion.AutoSize = true;
            this.lblAnulacion.Location = new System.Drawing.Point(256, 140);
            this.lblAnulacion.Name = "lblAnulacion";
            this.lblAnulacion.Size = new System.Drawing.Size(51, 40);
            this.lblAnulacion.TabIndex = 14;
            this.lblAnulacion.Text = "label8";
            this.lblAnulacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGanan
            // 
            this.lblGanan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblGanan.AutoSize = true;
            this.lblGanan.Location = new System.Drawing.Point(256, 340);
            this.lblGanan.Name = "lblGanan";
            this.lblGanan.Size = new System.Drawing.Size(51, 34);
            this.lblGanan.TabIndex = 18;
            this.lblGanan.Text = "label8";
            this.lblGanan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTota
            // 
            this.lblTota.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTota.AutoSize = true;
            this.lblTota.Location = new System.Drawing.Point(256, 300);
            this.lblTota.Name = "lblTota";
            this.lblTota.Size = new System.Drawing.Size(51, 40);
            this.lblTota.TabIndex = 17;
            this.lblTota.Text = "label8";
            this.lblTota.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCompra
            // 
            this.lblCompra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCompra.AutoSize = true;
            this.lblCompra.Location = new System.Drawing.Point(256, 260);
            this.lblCompra.Name = "lblCompra";
            this.lblCompra.Size = new System.Drawing.Size(51, 40);
            this.lblCompra.TabIndex = 16;
            this.lblCompra.Text = "label8";
            this.lblCompra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGastoOpe
            // 
            this.lblGastoOpe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblGastoOpe.AutoSize = true;
            this.lblGastoOpe.Location = new System.Drawing.Point(256, 220);
            this.lblGastoOpe.Name = "lblGastoOpe";
            this.lblGastoOpe.Size = new System.Drawing.Size(51, 40);
            this.lblGastoOpe.TabIndex = 15;
            this.lblGastoOpe.Text = "label8";
            this.lblGastoOpe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblinicial
            // 
            this.lblinicial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblinicial.AutoSize = true;
            this.lblinicial.Location = new System.Drawing.Point(256, 20);
            this.lblinicial.Name = "lblinicial";
            this.lblinicial.Size = new System.Drawing.Size(51, 40);
            this.lblinicial.TabIndex = 23;
            this.lblinicial.Text = "label8";
            this.lblinicial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::interfaces.Properties.Resources._lock;
            this.btnCerrar.Location = new System.Drawing.Point(375, 377);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(45, 47);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnCerrar.TabIndex = 21;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Image = global::interfaces.Properties.Resources.more_32;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(118, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 34);
            this.label7.TabIndex = 7;
            this.label7.Text = "Ganancias:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Image = global::interfaces.Properties.Resources.money_32;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(164, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 40);
            this.label6.TabIndex = 6;
            this.label6.Text = "Total:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Image = global::interfaces.Properties.Resources.shopping_bag_32;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(101, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 40);
            this.label5.TabIndex = 5;
            this.label5.Text = "Total compras:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Image = global::interfaces.Properties.Resources.payment_32;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(69, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 40);
            this.label4.TabIndex = 4;
            this.label4.Text = "Gastos operativos:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Image = global::interfaces.Properties.Resources.cancel_32;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(50, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(200, 40);
            this.label8.TabIndex = 19;
            this.label8.Text = "Anulaciones compras:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Image = global::interfaces.Properties.Resources.files_and_folders_32;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(61, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 40);
            this.label3.TabIndex = 3;
            this.label3.Text = "Anulaciones ventas:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Image = global::interfaces.Properties.Resources.fact_32;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(65, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ventas en facturas:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Image = global::interfaces.Properties.Resources.bill_32;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(79, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ventas en tickets:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.Image = global::interfaces.Properties.Resources.money_321;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Location = new System.Drawing.Point(96, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 40);
            this.label9.TabIndex = 22;
            this.label9.Text = "Efectivo inicial:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cerrar
            // 
            this.cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cerrar.Image = ((System.Drawing.Image)(resources.GetObject("cerrar.Image")));
            this.cerrar.Location = new System.Drawing.Point(378, 5);
            this.cerrar.Margin = new System.Windows.Forms.Padding(4);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(32, 32);
            this.cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cerrar.TabIndex = 2;
            this.cerrar.TabStop = false;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // revisar_caja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 481);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panelTitulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "revisar_caja";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "revisar_caja";
            this.Load += new System.EventHandler(this.revisar_caja_Load);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.PictureBox cerrar;
        public System.Windows.Forms.Label lblEncanezado;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblVentaT;
        private System.Windows.Forms.Label lblVentaF;
        private System.Windows.Forms.Label lblAnulacion;
        private System.Windows.Forms.Label lblGastoOpe;
        private System.Windows.Forms.Label lblCompra;
        private System.Windows.Forms.Label lblTota;
        private System.Windows.Forms.Label lblGanan;
        private System.Windows.Forms.Label lblAnula_Compras;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblinicial;
    }
}