using conexiones_BD.clases;
using FirmarPDF;
using ModulosfacturaElectronica.ClasesValidacion;
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
    public partial class ValidarPDF : Form
    {
        private string Ruta_PDF { get; set; } = null;
        private DataTable DatosCertificados;
        private bool visible = false;
        private FirmaElectronica _firma = new FirmaElectronica();
        List<string> listaNomArchivos = new List<string>();
        List<string> listaRutArchivos = new List<string>();

        #region DLL para mover la ventana

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion

        private void CargarDatosFormularios()
        {

            listaRutArchivos = _firma.ObtenerRutasDeArchivosPDF();
            listaNomArchivos = _firma.ObtenerNombresDeArchivosPDF();


            ListaRutasArchivosPDF.DataSource = listaNomArchivos;
            datosListas();
        }

        private void datosListas()
        {
            if (ListaRutasArchivosPDF.Text != "" || ListaRutasArchivosPDF.Text != null)
            {

                foreach (var item in listaRutArchivos)
                {
                    if (item.Contains(ListaRutasArchivosPDF.SelectedItem.ToString()))
                    {
                        lblRutaPDF.Text = item.ToString();
                        break;
                    }

                }
            }
            @Ruta_PDF = lblRutaPDF.Text;
        }



        public ValidarPDF()
        {
            InitializeComponent();
            DatosCertificados = empresa.datos_empresa();
            CargarDatosFormularios();
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
        private void btnBuscar_PDF_Click(object sender, EventArgs e)
        {
            string RutaPDF = BuscarRutaDocumento();
            lblRutaPDF.Text = RutaPDF;
            Ruta_PDF = RutaPDF;
            ListaRutasArchivosPDF.Text = RutaPDF;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void brnValidarPDF_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtContraPFX.Text != null && txtContraPFX.Text != "")
                {
                    if (@Ruta_PDF != null && @Ruta_PDF != "")
                    {
                        int documentoValido = -1;
                        string rutaPfx = DatosCertificados.Rows[0][8].ToString();//obtiene la ruta del almacen pfx
                        var certificado = new ValidarCertificado(rutaPfx, txtContraPFX.Text);//obtiene la informacion del certificado que se encuentra dentro del pfx
                        int indicePfxVal = certificado.Validar_AlmacenPFX();//verifica que el archivo pfx sea correcto y su contraseña
                        var validarPDF = new ValidacionPDF(certificado);


                        //verificamos si hay algun error en la validacion del pfx
                        switch (indicePfxVal)
                        {
                            case 0:
                                documentoValido = validarPDF.ValidarDocumentoPDF(@Ruta_PDF); //validamos el pdf y obtenemos un indice de verificacion
                                break;
                            case 1:
                                documentoValido = 4;
                                break;
                            case 2:
                                documentoValido = 5;
                                break;
                            default:
                                documentoValido = -1;//valor de indice invalido
                                break;
                        }

                        switch (documentoValido)
                        {
                            case 0:
                                _firma.ActulizarDatosDeRutasArchivosPDF(@Ruta_PDF);
                                CargarDatosFormularios();
                                MessageBox.Show("El archivo PDF es valido, y no ha sido modificado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            case 1:
                                MessageBox.Show("El archivo PDF ha sido modificado, y no pudo validarse", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                break;
                            case 2:
                                MessageBox.Show("El archivo selecionado no en un PDF, Selecione un archivo PDF", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                break;
                            case 3:
                                MessageBox.Show("El archivo PDF selecionado no esta firmado, Selecione un PDF que este firmado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                break;

                            case 4:
                                MessageBox.Show("Error al tratar de encontrar el archivo pfx en la ruta especificada, porfavor verificar la ruta del pfx en configuraciones opcion (empresa)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            case 5:
                                MessageBox.Show("La contraseña del almacen pfx es incorrecta", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                break;
                            default:
                                MessageBox.Show("Indice de error invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;

                        }

                    }
                    else
                    {
                        MessageBox.Show("Selecione primero un archivo PDF firmado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else {

                    MessageBox.Show("Ingrese una contraseña", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

              

            }
            catch (Exception)
            {

                MessageBox.Show("Error al validar el archivo PDF", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            

        }

        private void btnVisibilidadPass_Click(object sender, EventArgs e)
        {
           
            if (txtContraPFX.PasswordChar.Equals('●'))
            {
                visible = true;
                txtContraPFX.PasswordChar = '\0';
                
            }
            else {
                visible = false;
                txtContraPFX.PasswordChar = '●';
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

        private void brnValidarPDF_MouseEnter(object sender, EventArgs e)
        {
            this.brnValidarPDF.Image = global::control_principal.Properties.Resources.validarpdf2;
        }

        private void brnValidarPDF_MouseLeave(object sender, EventArgs e)
        {
            this.brnValidarPDF.Image = global::control_principal.Properties.Resources.validarpdf;
        }

        private void btn_cancelar_MouseEnter(object sender, EventArgs e)
        {
            this.btn_cancelar.Image = global::control_principal.Properties.Resources.cerrar2;
        }

        private void btn_cancelar_MouseLeave(object sender, EventArgs e)
        {
            this.btn_cancelar.Image = global::control_principal.Properties.Resources.cerrar1;
        }

        private void btnVisibilidadPass_MouseEnter(object sender, EventArgs e)
        {
            if (visible) {
                this.btnVisibilidadPass.Image = global::control_principal.Properties.Resources.visible2;
            }
            else {
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

        private void ListaRutasArchivosPDF_SelectedValueChanged(object sender, EventArgs e)
        {
            datosListas();
        }
    }
}
