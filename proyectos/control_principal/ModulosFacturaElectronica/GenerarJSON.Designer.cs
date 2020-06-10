namespace control_principal.ModulosFacturaElectronica
{
    partial class GenerarJSON
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
            this.lblRutaXML = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRutaJSON = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSlecionarRutaJSON = new System.Windows.Forms.PictureBox();
            this.btnBuscar_XML = new System.Windows.Forms.PictureBox();
            this.btnCrearJson = new System.Windows.Forms.PictureBox();
            this.ListaRutasArchivosXML = new System.Windows.Forms.ComboBox();
            this.txtNombreJSON = new System.Windows.Forms.TextBox();
            this.pnlTxtTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlecionarRutaJSON)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar_XML)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCrearJson)).BeginInit();
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
            this.label4.Location = new System.Drawing.Point(329, 6);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 32);
            this.label4.TabIndex = 27;
            this.label4.Text = "Generar JSON";
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
            this.btn_cancelar.TabIndex = 33;
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
            this.label2.Location = new System.Drawing.Point(61, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 31);
            this.label2.TabIndex = 38;
            this.label2.Text = "Selecione XML:";
            // 
            // lblRutaXML
            // 
            this.lblRutaXML.Enabled = false;
            this.lblRutaXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRutaXML.Location = new System.Drawing.Point(67, 214);
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
            this.label1.Location = new System.Drawing.Point(61, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 31);
            this.label1.TabIndex = 35;
            this.label1.Text = "Buscar XML(factura) :";
            // 
            // txtRutaJSON
            // 
            this.txtRutaJSON.Enabled = false;
            this.txtRutaJSON.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRutaJSON.Location = new System.Drawing.Point(67, 428);
            this.txtRutaJSON.Margin = new System.Windows.Forms.Padding(4);
            this.txtRutaJSON.Multiline = true;
            this.txtRutaJSON.Name = "txtRutaJSON";
            this.txtRutaJSON.Size = new System.Drawing.Size(750, 55);
            this.txtRutaJSON.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(61, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(630, 31);
            this.label5.TabIndex = 40;
            this.label5.Text = "Seleccione la ruta donde se gusrdara el JSON :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(61, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(265, 31);
            this.label6.TabIndex = 44;
            this.label6.Text = "Nombre del JSON: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(742, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 31);
            this.label7.TabIndex = 47;
            this.label7.Text = ".json ";
            // 
            // btnSlecionarRutaJSON
            // 
            this.btnSlecionarRutaJSON.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSlecionarRutaJSON.Image = global::control_principal.Properties.Resources.folder2;
            this.btnSlecionarRutaJSON.Location = new System.Drawing.Point(756, 361);
            this.btnSlecionarRutaJSON.Margin = new System.Windows.Forms.Padding(4);
            this.btnSlecionarRutaJSON.Name = "btnSlecionarRutaJSON";
            this.btnSlecionarRutaJSON.Size = new System.Drawing.Size(61, 49);
            this.btnSlecionarRutaJSON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSlecionarRutaJSON.TabIndex = 41;
            this.btnSlecionarRutaJSON.TabStop = false;
            this.btnSlecionarRutaJSON.Click += new System.EventHandler(this.btnSlecionarRutaJSON_Click);
            this.btnSlecionarRutaJSON.MouseEnter += new System.EventHandler(this.btnSlecionarRutaJSON_MouseEnter);
            this.btnSlecionarRutaJSON.MouseLeave += new System.EventHandler(this.btnSlecionarRutaJSON_MouseLeave);
            // 
            // btnBuscar_XML
            // 
            this.btnBuscar_XML.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar_XML.Image = global::control_principal.Properties.Resources.folder2;
            this.btnBuscar_XML.Location = new System.Drawing.Point(391, 99);
            this.btnBuscar_XML.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar_XML.Name = "btnBuscar_XML";
            this.btnBuscar_XML.Size = new System.Drawing.Size(61, 49);
            this.btnBuscar_XML.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBuscar_XML.TabIndex = 36;
            this.btnBuscar_XML.TabStop = false;
            this.btnBuscar_XML.Click += new System.EventHandler(this.btnBuscar_XML_Click);
            this.btnBuscar_XML.MouseEnter += new System.EventHandler(this.btnBuscar_XML_MouseEnter);
            this.btnBuscar_XML.MouseLeave += new System.EventHandler(this.btnBuscar_XML_MouseLeave);
            // 
            // btnCrearJson
            // 
            this.btnCrearJson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearJson.Image = global::control_principal.Properties.Resources.crearJson;
            this.btnCrearJson.Location = new System.Drawing.Point(309, 523);
            this.btnCrearJson.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrearJson.Name = "btnCrearJson";
            this.btnCrearJson.Size = new System.Drawing.Size(244, 94);
            this.btnCrearJson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCrearJson.TabIndex = 34;
            this.btnCrearJson.TabStop = false;
            this.btnCrearJson.Click += new System.EventHandler(this.btnCrearJson_Click);
            this.btnCrearJson.MouseEnter += new System.EventHandler(this.btnCrearJson_MouseEnter);
            this.btnCrearJson.MouseLeave += new System.EventHandler(this.btnCrearJson_MouseLeave);
            // 
            // ListaRutasArchivosXML
            // 
            this.ListaRutasArchivosXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaRutasArchivosXML.FormattingEnabled = true;
            this.ListaRutasArchivosXML.Location = new System.Drawing.Point(391, 155);
            this.ListaRutasArchivosXML.Name = "ListaRutasArchivosXML";
            this.ListaRutasArchivosXML.Size = new System.Drawing.Size(426, 39);
            this.ListaRutasArchivosXML.TabIndex = 48;
            this.ListaRutasArchivosXML.SelectedValueChanged += new System.EventHandler(this.ListaRutasArchivosXML_SelectedValueChanged);
            // 
            // txtNombreJSON
            // 
            this.txtNombreJSON.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreJSON.Location = new System.Drawing.Point(391, 297);
            this.txtNombreJSON.Name = "txtNombreJSON";
            this.txtNombreJSON.Size = new System.Drawing.Size(345, 38);
            this.txtNombreJSON.TabIndex = 49;
            // 
            // GenerarJSON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(863, 660);
            this.Controls.Add(this.txtNombreJSON);
            this.Controls.Add(this.ListaRutasArchivosXML);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtRutaJSON);
            this.Controls.Add(this.btnSlecionarRutaJSON);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pnlTxtTitulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRutaXML);
            this.Controls.Add(this.btnBuscar_XML);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCrearJson);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GenerarJSON";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GenerarJSON";
            this.pnlTxtTitulo.ResumeLayout(false);
            this.pnlTxtTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlecionarRutaJSON)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar_XML)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCrearJson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTxtTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lblRutaXML;
        private System.Windows.Forms.PictureBox btnBuscar_XML;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnCrearJson;
        private System.Windows.Forms.PictureBox btn_cancelar;
        private System.Windows.Forms.TextBox txtRutaJSON;
        private System.Windows.Forms.PictureBox btnSlecionarRutaJSON;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ListaRutasArchivosXML;
        private System.Windows.Forms.TextBox txtNombreJSON;
    }
}