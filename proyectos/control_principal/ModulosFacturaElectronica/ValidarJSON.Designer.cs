namespace control_principal.ModulosFacturaElectronica
{
    partial class ValidarJSON
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
            this.lblRutaJSON = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnValidarJson = new System.Windows.Forms.PictureBox();
            this.btnBuscar_JSON = new System.Windows.Forms.PictureBox();
            this.ListaRutasArchivosJSON = new System.Windows.Forms.ComboBox();
            this.pnlTxtTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnValidarJson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar_JSON)).BeginInit();
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
            this.label4.Location = new System.Drawing.Point(333, 7);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 32);
            this.label4.TabIndex = 27;
            this.label4.Text = "Validar JSON";
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
            this.label2.Location = new System.Drawing.Point(49, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 31);
            this.label2.TabIndex = 38;
            this.label2.Text = "Seleccione JSON :";
            // 
            // lblRutaJSON
            // 
            this.lblRutaJSON.Enabled = false;
            this.lblRutaJSON.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRutaJSON.Location = new System.Drawing.Point(55, 293);
            this.lblRutaJSON.Margin = new System.Windows.Forms.Padding(4);
            this.lblRutaJSON.Multiline = true;
            this.lblRutaJSON.Name = "lblRutaJSON";
            this.lblRutaJSON.Size = new System.Drawing.Size(750, 55);
            this.lblRutaJSON.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(49, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 31);
            this.label1.TabIndex = 34;
            this.label1.Text = "Buscar  JSON:";
            // 
            // btnValidarJson
            // 
            this.btnValidarJson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnValidarJson.Image = global::control_principal.Properties.Resources.validarJSON;
            this.btnValidarJson.Location = new System.Drawing.Point(303, 419);
            this.btnValidarJson.Margin = new System.Windows.Forms.Padding(4);
            this.btnValidarJson.Name = "btnValidarJson";
            this.btnValidarJson.Size = new System.Drawing.Size(244, 94);
            this.btnValidarJson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnValidarJson.TabIndex = 36;
            this.btnValidarJson.TabStop = false;
            this.btnValidarJson.Click += new System.EventHandler(this.btnValidarJson_Click);
            this.btnValidarJson.MouseEnter += new System.EventHandler(this.btnValidarJson_MouseEnter);
            this.btnValidarJson.MouseLeave += new System.EventHandler(this.btnValidarJson_MouseLeave);
            // 
            // btnBuscar_JSON
            // 
            this.btnBuscar_JSON.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar_JSON.Image = global::control_principal.Properties.Resources.folder2;
            this.btnBuscar_JSON.Location = new System.Drawing.Point(339, 159);
            this.btnBuscar_JSON.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar_JSON.Name = "btnBuscar_JSON";
            this.btnBuscar_JSON.Size = new System.Drawing.Size(61, 49);
            this.btnBuscar_JSON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBuscar_JSON.TabIndex = 35;
            this.btnBuscar_JSON.TabStop = false;
            this.btnBuscar_JSON.Click += new System.EventHandler(this.btnBuscar_JSON_Click);
            this.btnBuscar_JSON.MouseEnter += new System.EventHandler(this.btnBuscar_JSON_MouseEnter);
            this.btnBuscar_JSON.MouseLeave += new System.EventHandler(this.btnBuscar_JSON_MouseLeave);
            // 
            // ListaRutasArchivosJSON
            // 
            this.ListaRutasArchivosJSON.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaRutasArchivosJSON.FormattingEnabled = true;
            this.ListaRutasArchivosJSON.Location = new System.Drawing.Point(339, 232);
            this.ListaRutasArchivosJSON.Name = "ListaRutasArchivosJSON";
            this.ListaRutasArchivosJSON.Size = new System.Drawing.Size(466, 39);
            this.ListaRutasArchivosJSON.TabIndex = 40;
            this.ListaRutasArchivosJSON.SelectedValueChanged += new System.EventHandler(this.ListaRutasArchivosJSON_SelectedValueChanged);
            // 
            // ValidarJSON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(863, 554);
            this.Controls.Add(this.ListaRutasArchivosJSON);
            this.Controls.Add(this.pnlTxtTitulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRutaJSON);
            this.Controls.Add(this.btnValidarJson);
            this.Controls.Add(this.btnBuscar_JSON);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ValidarJSON";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ValidarJSON";
            this.pnlTxtTitulo.ResumeLayout(false);
            this.pnlTxtTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnValidarJson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar_JSON)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTxtTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lblRutaJSON;
        private System.Windows.Forms.PictureBox btnValidarJson;
        private System.Windows.Forms.PictureBox btnBuscar_JSON;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btn_cancelar;
        private System.Windows.Forms.ComboBox ListaRutasArchivosJSON;
    }
}