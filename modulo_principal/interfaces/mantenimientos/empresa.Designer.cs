namespace interfaces.mantenimientos
{
    partial class empresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(empresa));
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.cerrar = new System.Windows.Forms.PictureBox();
            this.lblEncanezado = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNRC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRazon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDenomi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGiro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCerti = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnGuarda = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.buscar_certificado = new System.Windows.Forms.OpenFileDialog();
            this.btnBuscar2 = new System.Windows.Forms.Button();
            this.txtPfx = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buscar_pfx = new System.Windows.Forms.OpenFileDialog();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(216)))), ((int)(((byte)(222)))));
            this.panelTitulo.Controls.Add(this.cerrar);
            this.panelTitulo.Controls.Add(this.lblEncanezado);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(434, 43);
            this.panelTitulo.TabIndex = 1;
            this.panelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitulo_MouseDown);
            // 
            // cerrar
            // 
            this.cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cerrar.Image = ((System.Drawing.Image)(resources.GetObject("cerrar.Image")));
            this.cerrar.Location = new System.Drawing.Point(389, 5);
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
            this.lblEncanezado.Location = new System.Drawing.Point(88, 9);
            this.lblEncanezado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEncanezado.Name = "lblEncanezado";
            this.lblEncanezado.Size = new System.Drawing.Size(241, 23);
            this.lblEncanezado.TabIndex = 0;
            this.lblEncanezado.Text = "Configuación de la empresa";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.Silver;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Location = new System.Drawing.Point(22, 95);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(219, 26);
            this.txtNombre.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(18, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre de la empresa";
            // 
            // txtNRC
            // 
            this.txtNRC.BackColor = System.Drawing.Color.Silver;
            this.txtNRC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNRC.Location = new System.Drawing.Point(260, 95);
            this.txtNRC.Margin = new System.Windows.Forms.Padding(4);
            this.txtNRC.Name = "txtNRC";
            this.txtNRC.Size = new System.Drawing.Size(150, 26);
            this.txtNRC.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(258, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "NRC";
            // 
            // txtRazon
            // 
            this.txtRazon.BackColor = System.Drawing.Color.Silver;
            this.txtRazon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRazon.Location = new System.Drawing.Point(22, 154);
            this.txtRazon.Margin = new System.Windows.Forms.Padding(4);
            this.txtRazon.Name = "txtRazon";
            this.txtRazon.Size = new System.Drawing.Size(185, 26);
            this.txtRazon.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(18, 131);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Razón social";
            // 
            // txtDenomi
            // 
            this.txtDenomi.BackColor = System.Drawing.Color.Silver;
            this.txtDenomi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDenomi.Location = new System.Drawing.Point(225, 154);
            this.txtDenomi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDenomi.Name = "txtDenomi";
            this.txtDenomi.Size = new System.Drawing.Size(185, 26);
            this.txtDenomi.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(221, 131);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Denominación";
            // 
            // txtGiro
            // 
            this.txtGiro.BackColor = System.Drawing.Color.Silver;
            this.txtGiro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGiro.Location = new System.Drawing.Point(22, 216);
            this.txtGiro.Margin = new System.Windows.Forms.Padding(4);
            this.txtGiro.Name = "txtGiro";
            this.txtGiro.Size = new System.Drawing.Size(185, 26);
            this.txtGiro.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(18, 193);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Giro";
            // 
            // txtNit
            // 
            this.txtNit.BackColor = System.Drawing.Color.Silver;
            this.txtNit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNit.Location = new System.Drawing.Point(225, 216);
            this.txtNit.Margin = new System.Windows.Forms.Padding(4);
            this.txtNit.Name = "txtNit";
            this.txtNit.Size = new System.Drawing.Size(185, 26);
            this.txtNit.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(221, 193);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "NIT";
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.Silver;
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccion.Location = new System.Drawing.Point(22, 279);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(388, 26);
            this.txtDireccion.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(18, 256);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 19);
            this.label7.TabIndex = 18;
            this.label7.Text = "Dirección";
            // 
            // txtCerti
            // 
            this.txtCerti.BackColor = System.Drawing.Color.Silver;
            this.txtCerti.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCerti.Location = new System.Drawing.Point(22, 344);
            this.txtCerti.Margin = new System.Windows.Forms.Padding(4);
            this.txtCerti.Name = "txtCerti";
            this.txtCerti.ReadOnly = true;
            this.txtCerti.Size = new System.Drawing.Size(340, 26);
            this.txtCerti.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(18, 321);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 19);
            this.label8.TabIndex = 20;
            this.label8.Text = "Certificado digital";
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(370, 344);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(40, 26);
            this.btnBuscar.TabIndex = 21;
            this.btnBuscar.Text = "...";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnGuarda
            // 
            this.btnGuarda.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnGuarda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuarda.Location = new System.Drawing.Point(169, 439);
            this.btnGuarda.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuarda.Name = "btnGuarda";
            this.btnGuarda.Size = new System.Drawing.Size(87, 31);
            this.btnGuarda.TabIndex = 22;
            this.btnGuarda.Text = "Guardar";
            this.btnGuarda.UseVisualStyleBackColor = true;
            this.btnGuarda.Click += new System.EventHandler(this.btnGuarda_Click);
            // 
            // error
            // 
            this.error.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.error.ContainerControl = this;
            // 
            // buscar_certificado
            // 
            this.buscar_certificado.FileName = "openFileDialog1";
            // 
            // btnBuscar2
            // 
            this.btnBuscar2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnBuscar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar2.Location = new System.Drawing.Point(370, 403);
            this.btnBuscar2.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar2.Name = "btnBuscar2";
            this.btnBuscar2.Size = new System.Drawing.Size(40, 26);
            this.btnBuscar2.TabIndex = 25;
            this.btnBuscar2.Text = "...";
            this.btnBuscar2.UseVisualStyleBackColor = true;
            this.btnBuscar2.Click += new System.EventHandler(this.btnBuscar2_Click);
            // 
            // txtPfx
            // 
            this.txtPfx.BackColor = System.Drawing.Color.Silver;
            this.txtPfx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPfx.Location = new System.Drawing.Point(22, 403);
            this.txtPfx.Margin = new System.Windows.Forms.Padding(4);
            this.txtPfx.Name = "txtPfx";
            this.txtPfx.ReadOnly = true;
            this.txtPfx.Size = new System.Drawing.Size(340, 26);
            this.txtPfx.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(18, 380);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 19);
            this.label9.TabIndex = 24;
            this.label9.Text = "Almacen pfx";
            // 
            // buscar_pfx
            // 
            this.buscar_pfx.FileName = "openFileDialog1";
            // 
            // empresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(434, 495);
            this.Controls.Add(this.btnBuscar2);
            this.Controls.Add(this.txtPfx);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnGuarda);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtCerti);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtGiro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDenomi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRazon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNRC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelTitulo);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "empresa";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "empresa";
            this.Load += new System.EventHandler(this.empresa_Load);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.PictureBox cerrar;
        public System.Windows.Forms.Label lblEncanezado;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNRC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRazon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDenomi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGiro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCerti;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnBuscar;
        public System.Windows.Forms.Button btnGuarda;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.OpenFileDialog buscar_certificado;
        private System.Windows.Forms.Button btnBuscar2;
        private System.Windows.Forms.TextBox txtPfx;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.OpenFileDialog buscar_pfx;
    }
}