namespace control_principal.ModulosFacturaElectronica
{
    partial class GenerarPDF
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
            this.lblRutaXML = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRutaSelecionadaPDF = new System.Windows.Forms.TextBox();
            this.btnSelecionarRuta = new System.Windows.Forms.PictureBox();
            this.btnCrear_PDF = new System.Windows.Forms.PictureBox();
            this.btnBuscar_XML = new System.Windows.Forms.PictureBox();
            this.ListaRutasArchivosXML = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombrePDF = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlTxtTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSelecionarRuta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCrear_PDF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar_XML)).BeginInit();
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
            this.label4.Location = new System.Drawing.Point(337, 6);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 32);
            this.label4.TabIndex = 27;
            this.label4.Text = "Generar PDF";
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
            this.btn_cancelar.TabIndex = 34;
            this.btn_cancelar.TabStop = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            this.btn_cancelar.MouseEnter += new System.EventHandler(this.btn_cancelar_MouseEnter);
            this.btn_cancelar.MouseLeave += new System.EventHandler(this.btn_cancelar_MouseLeave);
            // 
            // lblRutaXML
            // 
            this.lblRutaXML.Enabled = false;
            this.lblRutaXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRutaXML.Location = new System.Drawing.Point(59, 216);
            this.lblRutaXML.Margin = new System.Windows.Forms.Padding(4);
            this.lblRutaXML.Multiline = true;
            this.lblRutaXML.Name = "lblRutaXML";
            this.lblRutaXML.Size = new System.Drawing.Size(750, 55);
            this.lblRutaXML.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(53, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 31);
            this.label1.TabIndex = 33;
            this.label1.Text = "Buscar XML(factura) :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(53, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 31);
            this.label3.TabIndex = 47;
            this.label3.Text = "Nombre del pdf : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(53, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(588, 31);
            this.label5.TabIndex = 49;
            this.label5.Text = "Selecione la ruta donde se guardara el pdf : ";
            // 
            // txtRutaSelecionadaPDF
            // 
            this.txtRutaSelecionadaPDF.Enabled = false;
            this.txtRutaSelecionadaPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRutaSelecionadaPDF.Location = new System.Drawing.Point(59, 422);
            this.txtRutaSelecionadaPDF.Margin = new System.Windows.Forms.Padding(4);
            this.txtRutaSelecionadaPDF.Multiline = true;
            this.txtRutaSelecionadaPDF.Name = "txtRutaSelecionadaPDF";
            this.txtRutaSelecionadaPDF.Size = new System.Drawing.Size(750, 55);
            this.txtRutaSelecionadaPDF.TabIndex = 51;
            // 
            // btnSelecionarRuta
            // 
            this.btnSelecionarRuta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelecionarRuta.Image = global::control_principal.Properties.Resources.folder2;
            this.btnSelecionarRuta.Location = new System.Drawing.Point(748, 356);
            this.btnSelecionarRuta.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelecionarRuta.Name = "btnSelecionarRuta";
            this.btnSelecionarRuta.Size = new System.Drawing.Size(61, 49);
            this.btnSelecionarRuta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSelecionarRuta.TabIndex = 50;
            this.btnSelecionarRuta.TabStop = false;
            this.btnSelecionarRuta.Click += new System.EventHandler(this.btnSelecionarRuta_Click);
            this.btnSelecionarRuta.MouseEnter += new System.EventHandler(this.btnSelecionarRuta_MouseEnter);
            this.btnSelecionarRuta.MouseLeave += new System.EventHandler(this.btnSelecionarRuta_MouseLeave);
            // 
            // btnCrear_PDF
            // 
            this.btnCrear_PDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrear_PDF.Image = global::control_principal.Properties.Resources.crearPDF1;
            this.btnCrear_PDF.Location = new System.Drawing.Point(309, 517);
            this.btnCrear_PDF.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrear_PDF.Name = "btnCrear_PDF";
            this.btnCrear_PDF.Size = new System.Drawing.Size(244, 94);
            this.btnCrear_PDF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCrear_PDF.TabIndex = 36;
            this.btnCrear_PDF.TabStop = false;
            this.btnCrear_PDF.Click += new System.EventHandler(this.btnCrear_PDF_Click);
            this.btnCrear_PDF.MouseEnter += new System.EventHandler(this.btnCrear_PDF_MouseEnter);
            this.btnCrear_PDF.MouseLeave += new System.EventHandler(this.btnCrear_PDF_MouseLeave);
            // 
            // btnBuscar_XML
            // 
            this.btnBuscar_XML.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar_XML.Image = global::control_principal.Properties.Resources.folder2;
            this.btnBuscar_XML.Location = new System.Drawing.Point(382, 89);
            this.btnBuscar_XML.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar_XML.Name = "btnBuscar_XML";
            this.btnBuscar_XML.Size = new System.Drawing.Size(61, 49);
            this.btnBuscar_XML.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBuscar_XML.TabIndex = 35;
            this.btnBuscar_XML.TabStop = false;
            this.btnBuscar_XML.Click += new System.EventHandler(this.btnBuscar_XML_Click);
            this.btnBuscar_XML.MouseEnter += new System.EventHandler(this.btnBuscar_XML_MouseEnter);
            this.btnBuscar_XML.MouseLeave += new System.EventHandler(this.btnBuscar_XML_MouseLeave);
            // 
            // ListaRutasArchivosXML
            // 
            this.ListaRutasArchivosXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaRutasArchivosXML.FormattingEnabled = true;
            this.ListaRutasArchivosXML.Location = new System.Drawing.Point(382, 158);
            this.ListaRutasArchivosXML.Name = "ListaRutasArchivosXML";
            this.ListaRutasArchivosXML.Size = new System.Drawing.Size(427, 39);
            this.ListaRutasArchivosXML.TabIndex = 55;
            this.ListaRutasArchivosXML.SelectedValueChanged += new System.EventHandler(this.ListaRutasArchivosXML_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(53, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 31);
            this.label2.TabIndex = 54;
            this.label2.Text = "Selecione XML:";
            // 
            // txtNombrePDF
            // 
            this.txtNombrePDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombrePDF.Location = new System.Drawing.Point(382, 295);
            this.txtNombrePDF.Name = "txtNombrePDF";
            this.txtNombrePDF.Size = new System.Drawing.Size(357, 38);
            this.txtNombrePDF.TabIndex = 56;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(745, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 31);
            this.label6.TabIndex = 57;
            this.label6.Text = ".pdf";
            // 
            // GenerarPDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(863, 631);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNombrePDF);
            this.Controls.Add(this.ListaRutasArchivosXML);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRutaSelecionadaPDF);
            this.Controls.Add(this.btnSelecionarRuta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pnlTxtTitulo);
            this.Controls.Add(this.lblRutaXML);
            this.Controls.Add(this.btnCrear_PDF);
            this.Controls.Add(this.btnBuscar_XML);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GenerarPDF";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GenerarPDF";
            this.pnlTxtTitulo.ResumeLayout(false);
            this.pnlTxtTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSelecionarRuta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCrear_PDF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar_XML)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTxtTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox lblRutaXML;
        private System.Windows.Forms.PictureBox btnCrear_PDF;
        private System.Windows.Forms.PictureBox btnBuscar_XML;
        private System.Windows.Forms.PictureBox btn_cancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox btnSelecionarRuta;
        private System.Windows.Forms.TextBox txtRutaSelecionadaPDF;
        private System.Windows.Forms.ComboBox ListaRutasArchivosXML;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombrePDF;
        private System.Windows.Forms.Label label6;
    }
}