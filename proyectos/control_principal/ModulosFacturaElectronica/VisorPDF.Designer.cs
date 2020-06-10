namespace control_principal.ModulosFacturaElectronica
{
    partial class Visor_PDF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Visor_PDF));
            this.VisorDel_PDF = new AxAcroPDFLib.AxAcroPDF();
            ((System.ComponentModel.ISupportInitialize)(this.VisorDel_PDF)).BeginInit();
            this.SuspendLayout();
            // 
            // VisorDel_PDF
            // 
            this.VisorDel_PDF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VisorDel_PDF.Enabled = true;
            this.VisorDel_PDF.Location = new System.Drawing.Point(0, 0);
            this.VisorDel_PDF.Name = "VisorDel_PDF";
            this.VisorDel_PDF.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("VisorDel_PDF.OcxState")));
            this.VisorDel_PDF.Size = new System.Drawing.Size(1124, 589);
            this.VisorDel_PDF.TabIndex = 0;
            // 
            // Visor_PDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 589);
            this.Controls.Add(this.VisorDel_PDF);
            this.Name = "Visor_PDF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VisorPDF";
            ((System.ComponentModel.ISupportInitialize)(this.VisorDel_PDF)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxAcroPDFLib.AxAcroPDF VisorDel_PDF;
    }
}