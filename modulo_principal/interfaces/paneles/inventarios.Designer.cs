namespace interfaces.paneles
{
    partial class inventarios
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
            this.panelOpciones = new System.Windows.Forms.FlowLayoutPanel();
            this.inveClientes = new System.Windows.Forms.Panel();
            this.btnClientes = new System.Windows.Forms.Button();
            this.inveFarmacia = new System.Windows.Forms.Panel();
            this.btnFarmacia = new System.Windows.Forms.Button();
            this.panelOpciones.SuspendLayout();
            this.inveClientes.SuspendLayout();
            this.inveFarmacia.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelOpciones
            // 
            this.panelOpciones.Controls.Add(this.inveClientes);
            this.panelOpciones.Controls.Add(this.inveFarmacia);
            this.panelOpciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOpciones.Location = new System.Drawing.Point(0, 0);
            this.panelOpciones.Name = "panelOpciones";
            this.panelOpciones.Size = new System.Drawing.Size(814, 523);
            this.panelOpciones.TabIndex = 1;
            // 
            // inveClientes
            // 
            this.inveClientes.Controls.Add(this.btnClientes);
            this.inveClientes.Location = new System.Drawing.Point(10, 10);
            this.inveClientes.Margin = new System.Windows.Forms.Padding(10);
            this.inveClientes.Name = "inveClientes";
            this.inveClientes.Size = new System.Drawing.Size(159, 170);
            this.inveClientes.TabIndex = 0;
            this.inveClientes.Visible = false;
            // 
            // btnClientes
            // 
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Image = global::interfaces.Properties.Resources.customer;
            this.btnClientes.Location = new System.Drawing.Point(0, 0);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(20);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(159, 170);
            this.btnClientes.TabIndex = 2;
            this.btnClientes.Text = "Estadisticas clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // inveFarmacia
            // 
            this.inveFarmacia.Controls.Add(this.btnFarmacia);
            this.inveFarmacia.Location = new System.Drawing.Point(189, 10);
            this.inveFarmacia.Margin = new System.Windows.Forms.Padding(10);
            this.inveFarmacia.Name = "inveFarmacia";
            this.inveFarmacia.Size = new System.Drawing.Size(159, 170);
            this.inveFarmacia.TabIndex = 8;
            this.inveFarmacia.Visible = false;
            // 
            // btnFarmacia
            // 
            this.btnFarmacia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFarmacia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFarmacia.FlatAppearance.BorderSize = 0;
            this.btnFarmacia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFarmacia.Image = global::interfaces.Properties.Resources.drugs_128;
            this.btnFarmacia.Location = new System.Drawing.Point(0, 0);
            this.btnFarmacia.Margin = new System.Windows.Forms.Padding(20);
            this.btnFarmacia.Name = "btnFarmacia";
            this.btnFarmacia.Size = new System.Drawing.Size(159, 170);
            this.btnFarmacia.TabIndex = 2;
            this.btnFarmacia.Text = "Farmacia";
            this.btnFarmacia.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFarmacia.UseVisualStyleBackColor = true;
            this.btnFarmacia.Click += new System.EventHandler(this.btnFarmacia_Click);
            // 
            // inventarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 523);
            this.Controls.Add(this.panelOpciones);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "inventarios";
            this.Text = "inventarios";
            this.Load += new System.EventHandler(this.inventarios_Load);
            this.panelOpciones.ResumeLayout(false);
            this.inveClientes.ResumeLayout(false);
            this.inveFarmacia.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panelOpciones;
        private System.Windows.Forms.Panel inveClientes;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Panel inveFarmacia;
        private System.Windows.Forms.Button btnFarmacia;
    }
}