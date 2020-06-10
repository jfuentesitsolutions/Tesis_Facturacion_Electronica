namespace control_principal.configuracion_inicial
{
    partial class tabla_unidades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tabla_unidades));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.txtBuscar = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tablaUnidades = new System.Windows.Forms.DataGridView();
            this.cId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNomebre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaUnidades)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtBuscar,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(434, 26);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(299, 26);
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel1.Image")));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(111, 23);
            this.toolStripLabel1.Text = "Buscar unidad";
            // 
            // tablaUnidades
            // 
            this.tablaUnidades.AllowUserToAddRows = false;
            this.tablaUnidades.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tablaUnidades.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaUnidades.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.tablaUnidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaUnidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cId,
            this.cCodigo,
            this.cNomebre,
            this.cTel});
            this.tablaUnidades.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tablaUnidades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablaUnidades.Location = new System.Drawing.Point(0, 26);
            this.tablaUnidades.Name = "tablaUnidades";
            this.tablaUnidades.ReadOnly = true;
            this.tablaUnidades.RowHeadersVisible = false;
            this.tablaUnidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaUnidades.Size = new System.Drawing.Size(434, 159);
            this.tablaUnidades.TabIndex = 4;
            this.tablaUnidades.DoubleClick += new System.EventHandler(this.tablaUnidades_DoubleClick);
            // 
            // cId
            // 
            this.cId.DataPropertyName = "idunidad";
            this.cId.HeaderText = "id";
            this.cId.Name = "cId";
            this.cId.ReadOnly = true;
            this.cId.Visible = false;
            // 
            // cCodigo
            // 
            this.cCodigo.DataPropertyName = "codigo_unidad";
            this.cCodigo.HeaderText = "Codigo";
            this.cCodigo.Name = "cCodigo";
            this.cCodigo.ReadOnly = true;
            // 
            // cNomebre
            // 
            this.cNomebre.DataPropertyName = "nombre";
            this.cNomebre.HeaderText = "Nombre";
            this.cNomebre.Name = "cNomebre";
            this.cNomebre.ReadOnly = true;
            this.cNomebre.Width = 200;
            // 
            // cTel
            // 
            this.cTel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cTel.DataPropertyName = "telefono";
            this.cTel.HeaderText = "Telefono";
            this.cTel.Name = "cTel";
            this.cTel.ReadOnly = true;
            // 
            // tabla_unidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 185);
            this.Controls.Add(this.tablaUnidades);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "tabla_unidades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar unidades";
            this.Load += new System.EventHandler(this.tabla_unidades_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaUnidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox txtBuscar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.DataGridView tablaUnidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn cId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNomebre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTel;
    }
}