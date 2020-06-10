using ModulosfacturaElectronica.ClasesValidacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace control_principal.ModulosFacturaElectronica
{
    public partial class ValidarXML : Form
    {
        private string Ruta_XML { get;  set; }
        private FirmaElectronica _firma = new FirmaElectronica();
        List<string> listaNomArchivos = new List<string>();
        List<string> listaRutArchivos = new List<string>();

        #region DLL para mover la ventana

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion


        private void CargarDatosFormularios() {
 
            listaRutArchivos = _firma.ObtenerRutasDeArchivosXML();
            listaNomArchivos = _firma.ObtenerNombresDeArchivosXML();


            ListaRutasArchivos.DataSource = listaNomArchivos;
            datosListas();
        }

        private void datosListas() {
            if (ListaRutasArchivos.Text != "" || ListaRutasArchivos.Text != null)
            {

                foreach (var item in listaRutArchivos)
                {
                    if (item.Contains(ListaRutasArchivos.SelectedItem.ToString()))
                    {
                        lblRutaXML.Text = item.ToString();
                        break;
                    }

                }
            }
            Ruta_XML = lblRutaXML.Text;
        }

        public ValidarXML()
        {
            InitializeComponent();
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

        private void btnBuscar_XML_Click(object sender, EventArgs e)
        {
            string RutaXML = BuscarRutaDocumento();
            lblRutaXML.Text = RutaXML;
            Ruta_XML = RutaXML;
            ListaRutasArchivos.Text = RutaXML;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnValidar_XML_Click(object sender, EventArgs e)
        {
           

            if (Ruta_XML != null && Ruta_XML != "")
            {
             
                switch (_firma.VerificarXML(Ruta_XML)) {
                    case 0:
                            _firma.ActulizarDatosDeRutasArchivosXML(Ruta_XML);
                            CargarDatosFormularios();
                            MessageBox.Show("El XML es valido, el contenido no ha sufrido cambios", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                           
                    case 1:
                            MessageBox.Show("La ubicacion del archivo XSLT es incorrecta, o el tipo de archivo seleccionado es incorrecto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            break;
                                   
                    case 2:
                            MessageBox.Show("El archivo XML selecionado es incorrecto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            break;        
                           
                    case 3:
                            MessageBox.Show("El XML es invalido, su contenido ha sido modificado", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            break;              
                        
                    case 4:
                            MessageBox.Show("Error al validar el xml", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                           
                    default:
                            MessageBox.Show("Indice de error invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                            
                        
                }

            }
            else
            {
                MessageBox.Show("Seleccione un archivo XML", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBuscar_XML_MouseEnter(object sender, EventArgs e)
        {
            this.btnBuscar_XML.Image = global::control_principal.Properties.Resources.folder22;
        }

        private void btnBuscar_XML_MouseLeave(object sender, EventArgs e)
        {
            this.btnBuscar_XML.Image = global::control_principal.Properties.Resources.folder2;
        }

        private void btnValidar_XML_MouseEnter(object sender, EventArgs e)
        {
            this.btnValidar_XML.Image = global::control_principal.Properties.Resources.validar_xml2;
        }

        private void btnValidar_XML_MouseLeave(object sender, EventArgs e)
        {
            this.btnValidar_XML.Image = global::control_principal.Properties.Resources.validar_xml;
        }

        private void btn_cancelar_MouseEnter(object sender, EventArgs e)
        {
            this.btn_cancelar.Image = global::control_principal.Properties.Resources.cerrar2;
        }

        private void btn_cancelar_MouseLeave(object sender, EventArgs e)
        {
            this.btn_cancelar.Image = global::control_principal.Properties.Resources.cerrar1;
        }

        private void pnlTxtTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ListaRutasArchivos_SelectedValueChanged(object sender, EventArgs e)
        {
            datosListas();
        }
    }
}
