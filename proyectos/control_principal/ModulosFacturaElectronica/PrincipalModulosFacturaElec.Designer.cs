namespace control_principal.ModulosFacturaElectronica
{
    partial class PrincipalModulosFacturaElec
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
            this.btnEnviarFactura = new System.Windows.Forms.Button();
            this.btnFirmarPDF = new System.Windows.Forms.Button();
            this.btnGenerarJSON = new System.Windows.Forms.Button();
            this.btnGenerarPDF = new System.Windows.Forms.Button();
            this.btnValidarJSON = new System.Windows.Forms.Button();
            this.btnValidarPDF = new System.Windows.Forms.Button();
            this.btnValidarXML = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEnviarFactura
            // 
            this.btnEnviarFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviarFactura.FlatAppearance.BorderSize = 0;
            this.btnEnviarFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviarFactura.Image = global::control_principal.Properties.Resources.email__1_;
            this.btnEnviarFactura.Location = new System.Drawing.Point(139, 184);
            this.btnEnviarFactura.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnviarFactura.Name = "btnEnviarFactura";
            this.btnEnviarFactura.Size = new System.Drawing.Size(119, 138);
            this.btnEnviarFactura.TabIndex = 28;
            this.btnEnviarFactura.Text = "Enviar factura";
            this.btnEnviarFactura.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEnviarFactura.UseVisualStyleBackColor = false;
            this.btnEnviarFactura.Click += new System.EventHandler(this.btnEnviarFactura_Click);
            // 
            // btnFirmarPDF
            // 
            this.btnFirmarPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFirmarPDF.FlatAppearance.BorderSize = 0;
            this.btnFirmarPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirmarPDF.Image = global::control_principal.Properties.Resources.firma_pdf_2;
            this.btnFirmarPDF.Location = new System.Drawing.Point(9, 184);
            this.btnFirmarPDF.Margin = new System.Windows.Forms.Padding(2);
            this.btnFirmarPDF.Name = "btnFirmarPDF";
            this.btnFirmarPDF.Size = new System.Drawing.Size(119, 138);
            this.btnFirmarPDF.TabIndex = 27;
            this.btnFirmarPDF.Text = "Firmar PDF";
            this.btnFirmarPDF.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFirmarPDF.UseVisualStyleBackColor = true;
            this.btnFirmarPDF.Click += new System.EventHandler(this.btnFirmarPDF_Click_1);
            // 
            // btnGenerarJSON
            // 
            this.btnGenerarJSON.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerarJSON.FlatAppearance.BorderSize = 0;
            this.btnGenerarJSON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarJSON.Image = global::control_principal.Properties.Resources.Genrar_json;
            this.btnGenerarJSON.Location = new System.Drawing.Point(447, 5);
            this.btnGenerarJSON.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerarJSON.Name = "btnGenerarJSON";
            this.btnGenerarJSON.Size = new System.Drawing.Size(119, 138);
            this.btnGenerarJSON.TabIndex = 26;
            this.btnGenerarJSON.Text = "Generar JSON";
            this.btnGenerarJSON.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGenerarJSON.UseVisualStyleBackColor = true;
            this.btnGenerarJSON.Click += new System.EventHandler(this.btnGenerarJSON_Click_1);
            // 
            // btnGenerarPDF
            // 
            this.btnGenerarPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerarPDF.FlatAppearance.BorderSize = 0;
            this.btnGenerarPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarPDF.Image = global::control_principal.Properties.Resources.pdf__1_;
            this.btnGenerarPDF.Location = new System.Drawing.Point(296, 11);
            this.btnGenerarPDF.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerarPDF.Name = "btnGenerarPDF";
            this.btnGenerarPDF.Size = new System.Drawing.Size(119, 138);
            this.btnGenerarPDF.TabIndex = 25;
            this.btnGenerarPDF.Text = "Generar PDF";
            this.btnGenerarPDF.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGenerarPDF.UseVisualStyleBackColor = true;
            this.btnGenerarPDF.Click += new System.EventHandler(this.btnGenerarPDF_Click_1);
            // 
            // btnValidarJSON
            // 
            this.btnValidarJSON.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnValidarJSON.FlatAppearance.BorderSize = 0;
            this.btnValidarJSON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidarJSON.Image = global::control_principal.Properties.Resources.json_file;
            this.btnValidarJSON.Location = new System.Drawing.Point(139, 11);
            this.btnValidarJSON.Margin = new System.Windows.Forms.Padding(2);
            this.btnValidarJSON.Name = "btnValidarJSON";
            this.btnValidarJSON.Size = new System.Drawing.Size(119, 138);
            this.btnValidarJSON.TabIndex = 24;
            this.btnValidarJSON.Text = "Validar JSON";
            this.btnValidarJSON.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnValidarJSON.UseVisualStyleBackColor = true;
            this.btnValidarJSON.Click += new System.EventHandler(this.btnValidarJSON_Click_1);
            // 
            // btnValidarPDF
            // 
            this.btnValidarPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnValidarPDF.FlatAppearance.BorderSize = 0;
            this.btnValidarPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidarPDF.Image = global::control_principal.Properties.Resources.pdf__2_;
            this.btnValidarPDF.Location = new System.Drawing.Point(296, 184);
            this.btnValidarPDF.Margin = new System.Windows.Forms.Padding(2);
            this.btnValidarPDF.Name = "btnValidarPDF";
            this.btnValidarPDF.Size = new System.Drawing.Size(119, 138);
            this.btnValidarPDF.TabIndex = 23;
            this.btnValidarPDF.Text = "Validar PDF";
            this.btnValidarPDF.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnValidarPDF.UseVisualStyleBackColor = true;
            this.btnValidarPDF.Visible = false;
            this.btnValidarPDF.Click += new System.EventHandler(this.btnValidarPDF_Click_1);
            // 
            // btnValidarXML
            // 
            this.btnValidarXML.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnValidarXML.FlatAppearance.BorderSize = 0;
            this.btnValidarXML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidarXML.Image = global::control_principal.Properties.Resources.xml__1_;
            this.btnValidarXML.Location = new System.Drawing.Point(4, 5);
            this.btnValidarXML.Margin = new System.Windows.Forms.Padding(2);
            this.btnValidarXML.Name = "btnValidarXML";
            this.btnValidarXML.Size = new System.Drawing.Size(119, 138);
            this.btnValidarXML.TabIndex = 22;
            this.btnValidarXML.Text = "Validar XML";
            this.btnValidarXML.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnValidarXML.UseVisualStyleBackColor = true;
            this.btnValidarXML.Click += new System.EventHandler(this.btnValidarXML_Click_1);
            // 
            // PrincipalModulosFacturaElec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 400);
            this.Controls.Add(this.btnEnviarFactura);
            this.Controls.Add(this.btnFirmarPDF);
            this.Controls.Add(this.btnGenerarJSON);
            this.Controls.Add(this.btnGenerarPDF);
            this.Controls.Add(this.btnValidarJSON);
            this.Controls.Add(this.btnValidarPDF);
            this.Controls.Add(this.btnValidarXML);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PrincipalModulosFacturaElec";
            this.Text = "PrincipalModulosFacturaElec";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnValidarXML;
        private System.Windows.Forms.Button btnValidarPDF;
        private System.Windows.Forms.Button btnValidarJSON;
        private System.Windows.Forms.Button btnGenerarPDF;
        private System.Windows.Forms.Button btnGenerarJSON;
        private System.Windows.Forms.Button btnFirmarPDF;
        private System.Windows.Forms.Button btnEnviarFactura;
    }
}