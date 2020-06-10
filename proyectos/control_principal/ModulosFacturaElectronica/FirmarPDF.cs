using conexiones_BD.clases;
using FirmarPDF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace control_principal.ModulosFacturaElectronica
{
    public partial class FirmarPDF : Form
    {
        private string Ruta_PDF { get; set; } = null;
        public string Ruta_guardarPDFirmado { get; set; } = null;
        private bool visible = false;

        #region DLL para mover la ventana

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion


        public FirmarPDF()
        {
            InitializeComponent();
           
        }


        private string BuscarRutaDocumento()
        {
            //Crear cuadro de seleccionar archivo
            OpenFileDialog Carpeta = new OpenFileDialog();

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

        private string RutaSelecionadaParaGuardarPDFFirmado()
        {
            //Crear cuadro de seleccionar archivo
            FolderBrowserDialog Carpeta = new FolderBrowserDialog();

            //verifica si un archivo ha sido selecionado
            if (Carpeta.ShowDialog() == DialogResult.OK)
            {
                //Archivo que hemos seleccionado               
                return Carpeta.SelectedPath;
            }
            else
            {
                return "";
            }

        }


        private void btnBuscar_PDF_Click(object sender, EventArgs e)
        {
            string RutaPDF = BuscarRutaDocumento();
            lblRutaPDF.Text = RutaPDF;
            Ruta_PDF = RutaPDF;
        }

        private void btnSelecionarCarpetaGuardar_Click(object sender, EventArgs e)
        {
            string RutaSelectPDF = RutaSelecionadaParaGuardarPDFFirmado();
            txtRutaGuardarPDFirmado.Text = RutaSelectPDF;
            Ruta_guardarPDFirmado = RutaSelectPDF;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //busca el nombre del pdf dentro del path del mismo
        private string NombrePDFSelecionado(string _pathPDF) {

            string NombrePDF="";

            for (int i = 1; i < _pathPDF.Length; i++)
            {
                string letra = _pathPDF.Substring(_pathPDF.Length - i, 1);

                if (letra.Equals(@"\")) {
                    break;
                }
                NombrePDF = letra + NombrePDF;

            }
            return NombrePDF;

        }

        private void btnFIrmar_PDF_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtContraPFX.Text != null && txtContraPFX.Text != "") {

                    if (Ruta_PDF != null && Ruta_PDF != "")
                    {
                        if (Ruta_guardarPDFirmado != null && Ruta_guardarPDFirmado != "")
                        {
                            Firmante firmante = new Firmante();

                            int indice = firmante.Firmar(Ruta_PDF, Ruta_guardarPDFirmado + "\\Firmado(#)-" + NombrePDFSelecionado(Ruta_PDF), false, txtContraPFX.Text);

                            if (indice == 3)
                            {
                                DialogResult _result = MessageBox.Show("Ya existe una copia firmada del PDF seleccionado, ¿Desea sobrescribir la copia firmada?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                                if (_result.Equals(DialogResult.Yes))
                                {
                                    indice = firmante.Firmar(Ruta_PDF, Ruta_guardarPDFirmado + "\\Firmado(#)-" + NombrePDFSelecionado(Ruta_PDF), true, txtContraPFX.Text);
                                }
                            }

                            switch (indice)
                            {
                                case 0:
                                    MessageBox.Show("El archivo PDF fue firmado exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    break;
                                case 1:
                                    MessageBox.Show("El archivo selecionado no es un archivo PDF", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    break;
                                case 2:
                                    MessageBox.Show("El archivo PDF seleccionado ya esta firmado, seleccione un archivo PDF que no este firmado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    break;
                                case 3:
                                    //este caso solo sirve como metodo de escape
                                    break;
                                case 4:
                                    MessageBox.Show("La ruta del almacenamiento PFX es nula, revise en configuraciones si ha selecionado una ruta para el PFX", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    break;
                                case 5:
                                    MessageBox.Show("La ruta del pfx es incorrecta o el archivo es incorrecto, verificar en configuraciones opcion (empresa)", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    break;
                                case 6:
                                    MessageBox.Show("La contraseña del almacen PFX es incorrecta", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    break;
                                default:
                                    MessageBox.Show("Indice de error invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    break;
                            }

                        }
                        else
                        {
                            MessageBox.Show("Selecione la ruta donde se guardara el PDF firmado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Selecione un archivo PDF", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }

                }
                else
                {
                    MessageBox.Show("Ingrese contraseña", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }

              

            }
            catch
            {
                MessageBox.Show("Error al firmarce el PDF", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnBuscar_PDF_MouseEnter(object sender, EventArgs e)
        {
            this.btnBuscar_PDF.Image = global::control_principal.Properties.Resources.folder22;
        }

        private void btnBuscar_PDF_MouseLeave(object sender, EventArgs e)
        {
            this.btnBuscar_PDF.Image = global::control_principal.Properties.Resources.folder2;

        }

        private void btnFIrmar_PDF_MouseEnter(object sender, EventArgs e)
        {
            this.btnFIrmar_PDF.Image = global::control_principal.Properties.Resources.firmarpdf2;
        }

        private void btnFIrmar_PDF_MouseLeave(object sender, EventArgs e)
        {
            this.btnFIrmar_PDF.Image = global::control_principal.Properties.Resources.firmarpdf;
        }

        private void btn_cancelar_MouseEnter(object sender, EventArgs e)
        {
            this.btn_cancelar.Image = global::control_principal.Properties.Resources.cerrar2;
        }

        private void btn_cancelar_MouseLeave(object sender, EventArgs e)
        {
            this.btn_cancelar.Image = global::control_principal.Properties.Resources.cerrar1;
        }

        private void btnSelecionarCarpetaGuardar_MouseEnter(object sender, EventArgs e)
        {
            this.btnSelecionarCarpetaGuardar.Image = global::control_principal.Properties.Resources.folder22;
        }

        private void btnSelecionarCarpetaGuardar_MouseLeave(object sender, EventArgs e)
        {
            this.btnSelecionarCarpetaGuardar.Image = global::control_principal.Properties.Resources.folder2;
        }

        private void pnlTxtTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label4_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnVisibilidadPass_MouseEnter(object sender, EventArgs e)
        {
            if (visible)
            {
                this.btnVisibilidadPass.Image = global::control_principal.Properties.Resources.visible2;
            }
            else
            {
                this.btnVisibilidadPass.Image = global::control_principal.Properties.Resources.novisible2;
            }
        }

        private void btnVisibilidadPass_MouseLeave(object sender, EventArgs e)
        {
            if (visible)
            {
                this.btnVisibilidadPass.Image = global::control_principal.Properties.Resources.visible;
            }
            else
            {
                this.btnVisibilidadPass.Image = global::control_principal.Properties.Resources.novisible;
            }

        }

        private void btnVisibilidadPass_Click(object sender, EventArgs e)
        {
            if (txtContraPFX.PasswordChar.Equals('●'))
            {
                visible = true;
                txtContraPFX.PasswordChar = '\0';

            }
            else
            {
                visible = false;
                txtContraPFX.PasswordChar = '●';
            }
        }
    }
}
