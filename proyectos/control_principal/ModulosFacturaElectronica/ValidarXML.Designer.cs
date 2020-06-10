namespace control_principal.ModulosFacturaElectronica
{
    partial class ValidarXML
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
            this.label3 = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRutaXML = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnValidar_XML = new System.Windows.Forms.PictureBox();
            this.btnBuscar_XML = new System.Windows.Forms.PictureBox();
            this.ListaRutasArchivos = new System.Windows.Forms.ComboBox();
            this.pnlTxtTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnValidar_XML)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar_XML)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTxtTitulo
            // 
            this.pnlTxtTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlTxtTitulo.Controls.Add(this.panel1);
            this.pnlTxtTitulo.Controls.Add(this.label3);
            this.pnlTxtTitulo.Controls.Add(this.btn_cancelar);
            this.pnlTxtTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTxtTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTxtTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTxtTitulo.Name = "pnlTxtTitulo";
            this.pnlTxtTitulo.Size = new System.Drawing.Size(863, 46);
            this.pnlTxtTitulo.TabIndex = 35;
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
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(340, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 32);
            this.label3.TabIndex = 27;
            this.label3.Text = "Validar XML";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label3_MouseDown);
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
            this.btn_cancelar.TabIndex = 30;
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
            this.label2.Location = new System.Drawing.Point(54, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 31);
            this.label2.TabIndex = 34;
            this.label2.Text = "Selecione XML :";
            // 
            // lblRutaXML
            // 
            this.lblRutaXML.Enabled = false;
            this.lblRutaXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRutaXML.Location = new System.Drawing.Point(60, 272);
            this.lblRutaXML.Margin = new System.Windows.Forms.Padding(4);
            this.lblRutaXML.Multiline = true;
            this.lblRutaXML.Name = "lblRutaXML";
            this.lblRutaXML.Size = new System.Drawing.Size(750, 55);
            this.lblRutaXML.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(54, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 31);
            this.label1.TabIndex = 29;
            this.label1.Text = "Buscar XML :";
            // 
            // btnValidar_XML
            // 
            this.btnValidar_XML.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnValidar_XML.Image = global::control_principal.Properties.Resources.validar_xml;
            this.btnValidar_XML.Location = new System.Drawing.Point(307, 393);
            this.btnValidar_XML.Margin = new System.Windows.Forms.Padding(4);
            this.btnValidar_XML.Name = "btnValidar_XML";
            this.btnValidar_XML.Size = new System.Drawing.Size(244, 94);
            this.btnValidar_XML.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnValidar_XML.TabIndex = 32;
            this.btnValidar_XML.TabStop = false;
            this.btnValidar_XML.Click += new System.EventHandler(this.btnValidar_XML_Click);
            this.btnValidar_XML.MouseEnter += new System.EventHandler(this.btnValidar_XML_MouseEnter);
            this.btnValidar_XML.MouseLeave += new System.EventHandler(this.btnValidar_XML_MouseLeave);
            // 
            // btnBuscar_XML
            // 
            this.btnBuscar_XML.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar_XML.Image = global::control_principal.Properties.Resources.folder2;
            this.btnBuscar_XML.Location = new System.Drawing.Point(313, 149);
            this.btnBuscar_XML.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar_XML.Name = "btnBuscar_XML";
            this.btnBuscar_XML.Size = new System.Drawing.Size(61, 49);
            this.btnBuscar_XML.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBuscar_XML.TabIndex = 31;
            this.btnBuscar_XML.TabStop = false;
            this.btnBuscar_XML.Click += new System.EventHandler(this.btnBuscar_XML_Click);
            this.btnBuscar_XML.MouseEnter += new System.EventHandler(this.btnBuscar_XML_MouseEnter);
            this.btnBuscar_XML.MouseLeave += new System.EventHandler(this.btnBuscar_XML_MouseLeave);
            // 
            // ListaRutasArchivos
            // 
            this.ListaRutasArchivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaRutasArchivos.FormattingEnabled = true;
            this.ListaRutasArchivos.Location = new System.Drawing.Point(313, 214);
            this.ListaRutasArchivos.Name = "ListaRutasArchivos";
            this.ListaRutasArchivos.Size = new System.Drawing.Size(497, 39);
            this.ListaRutasArchivos.TabIndex = 36;
            this.ListaRutasArchivos.SelectedValueChanged += new System.EventHandler(this.ListaRutasArchivos_SelectedValueChanged);
            // 
            // ValidarXML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(863, 554);
            this.Controls.Add(this.ListaRutasArchivos);
            this.Controls.Add(this.pnlTxtTitulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRutaXML);
            this.Controls.Add(this.btnValidar_XML);
            this.Controls.Add(this.btnBuscar_XML);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ValidarXML";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ValidarXML";
            this.pnlTxtTitulo.ResumeLayout(false);
            this.pnlTxtTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnValidar_XML)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar_XML)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTxtTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lblRutaXML;
        private System.Windows.Forms.PictureBox btnValidar_XML;
        private System.Windows.Forms.PictureBox btnBuscar_XML;
        private System.Windows.Forms.PictureBox btn_cancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ListaRutasArchivos;
    }
}