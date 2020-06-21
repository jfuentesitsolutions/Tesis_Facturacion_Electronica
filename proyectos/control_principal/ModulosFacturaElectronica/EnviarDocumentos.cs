using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace control_principal.ModulosFacturaElectronica
{
    public partial class EnviarDocumentos : Form
    {
        public EnviarDocumentos()
        {
            InitializeComponent();
        }

        private void btn_cancelar_MouseEnter(object sender, EventArgs e)
        {
            this.btn_cancelar.Image = global::control_principal.Properties.Resources.cerrar2;
        }

        private void btn_cancelar_MouseLeave(object sender, EventArgs e)
        {
            this.btn_cancelar.Image = global::control_principal.Properties.Resources.cerrar1;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFIrmar_PDF_MouseEnter(object sender, EventArgs e)
        {
            this.btnEnviar.Image = global::control_principal.Properties.Resources.enviar2;
        }

        private void btnFIrmar_PDF_MouseLeave(object sender, EventArgs e)
        {
            this.btnEnviar.Image = global::control_principal.Properties.Resources.enviar1;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (!validar())
            {
                utilitarios.envio_correo correo = new utilitarios.envio_correo(txtCorreo.Text, "Esta una prueba", txtObservacion.Text, lblRutaXML.Text, lblRutaPDF.Text);

                using(espera_datos.splash_espera fe=new espera_datos.splash_espera())
                {
                    fe.Validar = correo.enviar_correo;
                    fe.Tipo_operacio = 3;

                    if (fe.ShowDialog() == DialogResult.OK)
                    {
                        if (fe.Creado)
                        {
                            if(MessageBox.Show("Correo enviado con exíto. ¿Deseas enviar otro?", "Correo enviado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                txtCorreo.Text = "";
                                lblRutaXML.Text = "";
                                lblRutaPDF.Text = "";
                                txtObservacion.Text = "";
                            }
                            else
                            {
                                this.Close();
                            }
                            
                        }
                        else
                        {
                            MessageBox.Show("No se pudo enviar el correo, revise su conexión a internet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }  
                }  
            }
        }
        DataTable empresa = conexiones_BD.clases.empresa.datos_empresa();
        private string BuscarRutaDocumento(bool tipo_archivo)
        {
            //Crear cuadro de seleccionar archivo
            OpenFileDialog Carpeta = new OpenFileDialog();
            
            if (tipo_archivo)
            {
                Carpeta.InitialDirectory = empresa.Rows[0][10].ToString();
                Carpeta.Filter = "Archivos XML (*.xml)|*.xml";
            }
            else
            {
                Carpeta.InitialDirectory = empresa.Rows[0][11].ToString();
                Carpeta.Filter = "Archivos PDF (*.pdf)|*.pdf";
            }
            

            //verifica si un archivo ha sido selecionado
            if (Carpeta.ShowDialog() == DialogResult.OK)
            {
                //Archivo que hemos seleccionado               
                return Carpeta.FileName;
            }
            else
            {
                return "";
            }

        }

        private bool validar()
        {
            bool valido = false;
            error.Clear();

            if (!validaCorreo(txtCorreo.Text))
            {
                error.SetError(txtCorreo, "Coloque un correo valido");
                valido = true;
            }

            if (lblRutaXML.TextLength == 0)
            {
                error.SetError(lblRutaXML, "Debes especificar la ruta del archivo xml");
                valido = true;
            }

            if (lblRutaPDF.TextLength == 0)
            {
                error.SetError(lblRutaPDF, "Debes especificar la ruta del archivo xml");
                valido = true;
            }

            if (txtObservacion.TextLength == 0)
            {
                error.SetError(txtObservacion, "Debes especificar la ruta del archivo xml");
                valido = true;
            }

            return valido;
        }

        private bool validaCorreo(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void btnBuscar_XML_Click(object sender, EventArgs e)
        {
            lblRutaXML.Text = BuscarRutaDocumento(true);
        }

        private void btnBuscar_PDF_Click(object sender, EventArgs e)
        {
            lblRutaPDF.Text = BuscarRutaDocumento(false);
        }
    }
}
