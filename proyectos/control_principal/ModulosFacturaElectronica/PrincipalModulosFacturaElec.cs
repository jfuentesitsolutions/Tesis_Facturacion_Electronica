using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace control_principal.ModulosFacturaElectronica
{
    public partial class PrincipalModulosFacturaElec : Form
    {
        private Form FormularioActivo = null;

        public PrincipalModulosFacturaElec()
        {
            InitializeComponent();
        }

        private void AbrirFormularioHijo(Form formulario)
        {
            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }
            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            // pnlShowO.Controls.Add(formulario);  // (pnlShowO)panel donde se agregaban los formularios
            // pnlShowO.Tag = formulario;
            formulario.BringToFront();
            formulario.Show();
        }

        private void btnValidarXML_Click_1(object sender, EventArgs e)
        {
            new ValidarXML().ShowDialog();
        }

        private void btnValidarPDF_Click_1(object sender, EventArgs e)
        {
            new ValidarPDF().ShowDialog();
        }

        private void btnValidarJSON_Click_1(object sender, EventArgs e)
        {
            new ValidarJSON().ShowDialog();
        }

        private void btnGenerarPDF_Click_1(object sender, EventArgs e)
        {
            new GenerarPDF().ShowDialog();
        }

        private void btnGenerarJSON_Click_1(object sender, EventArgs e)
        {
            new GenerarJSON().ShowDialog();
        }

        private void btnFirmarPDF_Click_1(object sender, EventArgs e)
        {
            new FirmarPDF().ShowDialog();
        }

        private void btnEnviarFactura_Click(object sender, EventArgs e)
        {
            new EnviarDocumentos().ShowDialog();
        }
    }
}
