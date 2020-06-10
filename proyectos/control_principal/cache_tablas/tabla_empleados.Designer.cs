namespace control_principal.configuracion_inicial
{
    partial class tabla_empleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tabla_empleados));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.txtBuscar = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tablaEmpleados = new System.Windows.Forms.DataGridView();
            this.cId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cApellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaEmpleados)).BeginInit();
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
            this.toolStrip1.Size = new System.Drawing.Size(487, 26);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(200, 26);
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel1.Image")));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(130, 23);
            this.toolStripLabel1.Text = "Buscar empleado";
            // 
            // tablaEmpleados
            // 
            this.tablaEmpleados.AllowUserToAddRows = false;
            this.tablaEmpleados.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tablaEmpleados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaEmpleados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.tablaEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cId,
            this.cCodigo,
            this.cNombres,
            this.cApellidos,
            this.cUnidad});
            this.tablaEmpleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tablaEmpleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablaEmpleados.Location = new System.Drawing.Point(0, 26);
            this.tablaEmpleados.Name = "tablaEmpleados";
            this.tablaEmpleados.ReadOnly = true;
            this.tablaEmpleados.RowHeadersVisible = false;
            this.tablaEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaEmpleados.Size = new System.Drawing.Size(487, 184);
            this.tablaEmpleados.TabIndex = 2;
            this.tablaEmpleados.DoubleClick += new System.EventHandler(this.tablaEmpleados_DoubleClick);
            // 
            // cId
            // 
            this.cId.DataPropertyName = "idempleado";
            this.cId.HeaderText = "idempleado";
            this.cId.Name = "cId";
            this.cId.ReadOnly = true;
            this.cId.Visible = false;
            // 
            // cCodigo
            // 
            this.cCodigo.DataPropertyName = "codigo_empleado";
            this.cCodigo.HeaderText = "Codigo";
            this.cCodigo.Name = "cCodigo";
            this.cCodigo.ReadOnly = true;
            this.cCodigo.Width = 75;
            // 
            // cNombres
            // 
            this.cNombres.DataPropertyName = "nombres";
            this.cNombres.FillWeight = 250F;
            this.cNombres.HeaderText = "Nombres";
            this.cNombres.Name = "cNombres";
            this.cNombres.ReadOnly = true;
            this.cNombres.Width = 150;
            // 
            // cApellidos
            // 
            this.cApellidos.DataPropertyName = "apellidos";
            this.cApellidos.FillWeight = 250F;
            this.cApellidos.HeaderText = "Apellidos";
            this.cApellidos.Name = "cApellidos";
            this.cApellidos.ReadOnly = true;
            this.cApellidos.Width = 150;
            // 
            // cUnidad
            // 
            this.cUnidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cUnidad.DataPropertyName = "nombre";
            this.cUnidad.HeaderText = "Unidad";
            this.cUnidad.Name = "cUnidad";
            this.cUnidad.ReadOnly = true;
            // 
            // tabla_empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 210);
            this.Controls.Add(this.tablaEmpleados);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "tabla_empleados";
            this.Text = "Busqueda de empleados";
            this.Load += new System.EventHandler(this.tabla_empleados_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox txtBuscar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.DataGridView tablaEmpleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn cId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn cApellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUnidad;
    }
}