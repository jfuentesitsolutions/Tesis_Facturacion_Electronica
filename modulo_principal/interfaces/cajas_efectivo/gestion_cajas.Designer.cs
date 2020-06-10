namespace interfaces.cajas_efectivo
{
    partial class Imagenes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Imagenes));
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.cerrar = new System.Windows.Forms.PictureBox();
            this.lblEncanezado = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chkTodos = new System.Windows.Forms.CheckBox();
            this.lista_cajas = new System.Windows.Forms.ListView();
            this.lista_imagenes = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.grupo_caja = new System.Windows.Forms.GroupBox();
            this.panel_contenido = new System.Windows.Forms.Panel();
            this.efectivo_inicial = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.MonthCalendar();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAbrir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCerrar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRevisar = new System.Windows.Forms.ToolStripButton();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCajasC = new System.Windows.Forms.ToolStripButton();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.grupo_caja.SuspendLayout();
            this.panel_contenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.efectivo_inicial)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
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
            this.panelTitulo.Size = new System.Drawing.Size(774, 43);
            this.panelTitulo.TabIndex = 1;
            this.panelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitulo_MouseDown);
            // 
            // cerrar
            // 
            this.cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cerrar.Image = ((System.Drawing.Image)(resources.GetObject("cerrar.Image")));
            this.cerrar.Location = new System.Drawing.Point(729, 5);
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
            this.lblEncanezado.Location = new System.Drawing.Point(263, 9);
            this.lblEncanezado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEncanezado.Name = "lblEncanezado";
            this.lblEncanezado.Size = new System.Drawing.Size(251, 23);
            this.lblEncanezado.TabIndex = 0;
            this.lblEncanezado.Text = "Administrar cajas de efectivo";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lista_cajas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(496, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 237);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.chkTodos);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(278, 26);
            this.panel3.TabIndex = 1;
            // 
            // chkTodos
            // 
            this.chkTodos.AutoSize = true;
            this.chkTodos.Location = new System.Drawing.Point(56, 3);
            this.chkTodos.Name = "chkTodos";
            this.chkTodos.Size = new System.Drawing.Size(169, 23);
            this.chkTodos.TabIndex = 0;
            this.chkTodos.Text = "Mostrar todas las cajas";
            this.chkTodos.UseVisualStyleBackColor = true;
            this.chkTodos.CheckedChanged += new System.EventHandler(this.chkTodos_CheckedChanged);
            // 
            // lista_cajas
            // 
            this.lista_cajas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lista_cajas.Location = new System.Drawing.Point(0, 26);
            this.lista_cajas.MultiSelect = false;
            this.lista_cajas.Name = "lista_cajas";
            this.lista_cajas.Size = new System.Drawing.Size(278, 211);
            this.lista_cajas.TabIndex = 0;
            this.lista_cajas.UseCompatibleStateImageBehavior = false;
            this.lista_cajas.ItemActivate += new System.EventHandler(this.lista_cajas_SelectedIndexChanged);
            // 
            // lista_imagenes
            // 
            this.lista_imagenes.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("lista_imagenes.ImageStream")));
            this.lista_imagenes.TransparentColor = System.Drawing.Color.Transparent;
            this.lista_imagenes.Images.SetKeyName(0, "caja_abierta.png");
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.grupo_caja);
            this.panel2.Controls.Add(this.toolStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(496, 237);
            this.panel2.TabIndex = 3;
            // 
            // grupo_caja
            // 
            this.grupo_caja.Controls.Add(this.panel_contenido);
            this.grupo_caja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grupo_caja.Location = new System.Drawing.Point(0, 26);
            this.grupo_caja.Name = "grupo_caja";
            this.grupo_caja.Size = new System.Drawing.Size(496, 211);
            this.grupo_caja.TabIndex = 1;
            this.grupo_caja.TabStop = false;
            this.grupo_caja.Text = "Datos de la caja";
            // 
            // panel_contenido
            // 
            this.panel_contenido.BackColor = System.Drawing.Color.Transparent;
            this.panel_contenido.Controls.Add(this.efectivo_inicial);
            this.panel_contenido.Controls.Add(this.label2);
            this.panel_contenido.Controls.Add(this.lblNombre);
            this.panel_contenido.Controls.Add(this.label1);
            this.panel_contenido.Controls.Add(this.fecha);
            this.panel_contenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_contenido.Location = new System.Drawing.Point(3, 22);
            this.panel_contenido.Name = "panel_contenido";
            this.panel_contenido.Size = new System.Drawing.Size(490, 186);
            this.panel_contenido.TabIndex = 1;
            // 
            // efectivo_inicial
            // 
            this.efectivo_inicial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.efectivo_inicial.DecimalPlaces = 2;
            this.efectivo_inicial.Enabled = false;
            this.efectivo_inicial.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efectivo_inicial.Location = new System.Drawing.Point(307, 133);
            this.efectivo_inicial.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.efectivo_inicial.Name = "efectivo_inicial";
            this.efectivo_inicial.Size = new System.Drawing.Size(123, 38);
            this.efectivo_inicial.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Efectivo inicial";
            // 
            // lblNombre
            // 
            this.lblNombre.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(274, 32);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(180, 71);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "label2";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre del equipo";
            // 
            // fecha
            // 
            this.fecha.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.fecha.Enabled = false;
            this.fecha.Location = new System.Drawing.Point(9, 9);
            this.fecha.Name = "fecha";
            this.fecha.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAbrir,
            this.toolStripSeparator1,
            this.btnCerrar,
            this.toolStripSeparator2,
            this.btnRevisar,
            this.toolStripSeparator3,
            this.btnCajasC});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(496, 26);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAbrir
            // 
            this.btnAbrir.Image = global::interfaces.Properties.Resources.caja_abierta;
            this.btnAbrir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(117, 23);
            this.btnAbrir.Text = "Aperturar caja";
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 26);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = global::interfaces.Properties.Resources.caja_cerrada;
            this.btnCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(98, 23);
            this.btnCerrar.Text = "Cerrar caja";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 26);
            // 
            // btnRevisar
            // 
            this.btnRevisar.Image = global::interfaces.Properties.Resources.search;
            this.btnRevisar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRevisar.Name = "btnRevisar";
            this.btnRevisar.Size = new System.Drawing.Size(103, 23);
            this.btnRevisar.Text = "Revisar caja";
            this.btnRevisar.Click += new System.EventHandler(this.btnRevisar_Click);
            // 
            // error
            // 
            this.error.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.error.ContainerControl = this;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 26);
            // 
            // btnCajasC
            // 
            this.btnCajasC.Image = global::interfaces.Properties.Resources._lock;
            this.btnCajasC.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCajasC.Name = "btnCajasC";
            this.btnCajasC.Size = new System.Drawing.Size(120, 23);
            this.btnCajasC.Text = "Cajas cerradas";
            this.btnCajasC.Click += new System.EventHandler(this.btnCajasC_Click);
            // 
            // Imagenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(774, 280);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTitulo);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Imagenes";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "gestion_cajas";
            this.Load += new System.EventHandler(this.Imagenes_Load);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.grupo_caja.ResumeLayout(false);
            this.panel_contenido.ResumeLayout(false);
            this.panel_contenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.efectivo_inicial)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.PictureBox cerrar;
        public System.Windows.Forms.Label lblEncanezado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lista_cajas;
        private System.Windows.Forms.ImageList lista_imagenes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAbrir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnCerrar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnRevisar;
        private System.Windows.Forms.GroupBox grupo_caja;
        private System.Windows.Forms.Panel panel_contenido;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox chkTodos;
        private System.Windows.Forms.MonthCalendar fecha;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown efectivo_inicial;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnCajasC;
    }
}