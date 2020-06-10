namespace control_principal.ModulosFacturaElectronica
{
    partial class ValidarPDF
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
            this.pnlTxtTitulo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRutaPDF = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ListaRutasArchivosPDF = new System.Windows.Forms.ComboBox();
            this.btnVisibilidadPass = new System.Windows.Forms.PictureBox();
            this.brnValidarPDF = new System.Windows.Forms.PictureBox();
            this.btnBuscar_PDF = new System.Windows.Forms.PictureBox();
            this.txtContraPFX = new System.Windows.Forms.TextBox();
            this.pnlTxtTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVisibilidadPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brnValidarPDF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar_PDF)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTxtTitulo
            // 
            this.pnlTxtTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlTxtTitulo.Controls.Add(this.panel1);
            this.pnlTxtTitulo.Controls.Add(this.label4);
            this.pnlTxtTitulo.Controls.Add(this.btn_cancelar);
            this.pnlTxtTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTxtTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTxtTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTxtTitulo.Name = "pnlTxtTitulo";
            this.pnlTxtTitulo.Size = new System.Drawing.Size(863, 46);
            this.pnlTxtTitulo.TabIndex = 39;
            this.pnlTxtTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTxtTitulo_MouseDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 45);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(863, 1);
            this.panel1.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(340, 7);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 32);
            this.label4.TabIndex = 27;
            this.label4.Text = "Validar PDF";
            this.label4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label4_MouseDown);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.Image = global::control_principal.Properties.Resources.cerrar1;
            this.btn_cancelar.Location = new System.Drawing.Point(805, 3);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(49, 39);
            this.btn_cancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_cancelar.TabIndex = 35;
            this.btn_cancelar.TabStop = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            this.btn_cancelar.MouseEnter += new System.EventHandler(this.btn_cancelar_MouseEnter);
            this.btn_cancelar.MouseLeave += new System.EventHandler(this.btn_cancelar_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(54, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 31);
            this.label2.TabIndex = 38;
            this.label2.Text = "Selecione PDF :";
            // 
            // lblRutaPDF
            // 
            this.lblRutaPDF.Enabled = false;
            this.lblRutaPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRutaPDF.Location = new System.Drawing.Point(60, 317);
            this.lblRutaPDF.Margin = new System.Windows.Forms.Padding(4);
            this.lblRutaPDF.Multiline = true;
            this.lblRutaPDF.Name = "lblRutaPDF";
            this.lblRutaPDF.Size = new System.Drawing.Size(750, 55);
            this.lblRutaPDF.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(54, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 31);
            this.label1.TabIndex = 33;
            this.label1.Text = "Buscar PDF Firmado :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(54, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(238, 31);
            this.label6.TabIndex = 60;
            this.label6.Text = "Contraseña PFX:";
            // 
            // ListaRutasArchivosPDF
            // 
            this.ListaRutasArchivosPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaRutasArchivosPDF.FormattingEnabled = true;
            this.ListaRutasArchivosPDF.Location = new System.Drawing.Point(379, 258);
            this.ListaRutasArchivosPDF.Name = "ListaRutasArchivosPDF";
            this.ListaRutasArchivosPDF.Size = new System.Drawing.Size(431, 39);
            this.ListaRutasArchivosPDF.TabIndex = 62;
            this.ListaRutasArchivosPDF.SelectedValueChanged += new System.EventHandler(this.ListaRutasArchivosPDF_SelectedValueChanged);
            // 
            // btnVisibilidadPass
            // 
            this.btnVisibilidadPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVisibilidadPass.Image = global::control_principal.Properties.Resources.novisible;
            this.btnVisibilidadPass.Location = new System.Drawing.Point(756, 108);
            this.btnVisibilidadPass.Name = "btnVisibilidadPass";
            this.btnVisibilidadPass.Size = new System.Drawing.Size(54, 49);
            this.btnVisibilidadPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnVisibilidadPass.TabIndex = 63;
            this.btnVisibilidadPass.TabStop = false;
            this.btnVisibilidadPass.Click += new System.EventHandler(this.btnVisibilidadPass_Click);
            this.btnVisibilidadPass.MouseEnter += new System.EventHandler(this.btnVisibilidadPass_MouseEnter);
            this.btnVisibilidadPass.MouseLeave += new System.EventHandler(this.btnVisibilidadPass_MouseLeave);
            // 
            // brnValidarPDF
            // 
            this.brnValidarPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.brnValidarPDF.Image = global::control_principal.Properties.Resources.validarpdf;
            this.brnValidarPDF.Location = new System.Drawing.Point(309, 430);
            this.brnValidarPDF.Margin = new System.Windows.Forms.Padding(4);
            this.brnValidarPDF.Name = "brnValidarPDF";
            this.brnValidarPDF.Size = new System.Drawing.Size(244, 94);
            this.brnValidarPDF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.brnValidarPDF.TabIndex = 36;
            this.brnValidarPDF.TabStop = false;
            this.brnValidarPDF.Click += new System.EventHandler(this.brnValidarPDF_Click);
            this.brnValidarPDF.MouseEnter += new System.EventHandler(this.brnValidarPDF_MouseEnter);
            this.brnValidarPDF.MouseLeave += new System.EventHandler(this.brnValidarPDF_MouseLeave);
            // 
            // btnBuscar_PDF
            // 
            this.btnBuscar_PDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar_PDF.Image = global::control_principal.Properties.Resources.folder2;
            this.btnBuscar_PDF.Location = new System.Drawing.Point(379, 181);
            this.btnBuscar_PDF.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar_PDF.Name = "btnBuscar_PDF";
            this.btnBuscar_PDF.Size = new System.Drawing.Size(61, 49);
            this.btnBuscar_PDF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBuscar_PDF.TabIndex = 34;
            this.btnBuscar_PDF.TabStop = false;
            this.btnBuscar_PDF.Click += new System.EventHandler(this.btnBuscar_PDF_Click);
            this.btnBuscar_PDF.MouseEnter += new System.EventHandler(this.btnBuscar_PDF_MouseEnter);
            this.btnBuscar_PDF.MouseLeave += new System.EventHandler(this.btnBuscar_PDF_MouseLeave);
            // 
            // txtContraPFX
            // 
            this.txtContraPFX.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraPFX.Location = new System.Drawing.Point(379, 116);
            this.txtContraPFX.Name = "txtContraPFX";
            this.txtContraPFX.PasswordChar = '●';
            this.txtContraPFX.Size = new System.Drawing.Size(371, 38);
            this.txtContraPFX.TabIndex = 64;
            // 
            // ValidarPDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(863, 554);
            this.Controls.Add(this.txtContraPFX);
            this.Controls.Add(this.btnVisibilidadPass);
            this.Controls.Add(this.ListaRutasArchivosPDF);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pnlTxtTitulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRutaPDF);
            this.Controls.Add(this.brnValidarPDF);
            this.Controls.Add(this.btnBuscar_PDF);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ValidarPDF";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ValidarPDF";
            this.pnlTxtTitulo.ResumeLayout(false);
            this.pnlTxtTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVisibilidadPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brnValidarPDF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar_PDF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTxtTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lblRutaPDF;
        private System.Windows.Forms.PictureBox brnValidarPDF;
        private System.Windows.Forms.PictureBox btn_cancelar;
        private System.Windows.Forms.PictureBox btnBuscar_PDF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ListaRutasArchivosPDF;
        private System.Windows.Forms.PictureBox btnVisibilidadPass;
        private System.Windows.Forms.TextBox txtContraPFX;
    }
}