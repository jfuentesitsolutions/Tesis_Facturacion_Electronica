using FirmarPDF;
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
    public partial class GenerarPDF : Form
    {
        public string Ruta_XML { get; private set; }
        public string Ruta_SelectPDF { get; private set; }
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

            listaRutArchivos = _firma.ObtenerRutasDeArchivosXML();
            listaNomArchivos = _firma.ObtenerNombresDeArchivosXML();


            ListaRutasArchivosXML.DataSource = listaNomArchivos;
            datosListas();
        }

        private void datosListas()
        {
            if (ListaRutasArchivosXML.Text != "" || ListaRutasArchivosXML.Text != null)
            {

                foreach (var item in listaRutArchivos)
                {
                    if (item.Contains(ListaRutasArchivosXML.SelectedItem.ToString()))
                    {
                        lblRutaXML.Text = item.ToString();
                        break;
                    }

                }
            }

            Ruta_XML = lblRutaXML.Text;
        }


        public GenerarPDF()
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

        private string RutaSelecionadaParaPDF()
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

     

        private void btnBuscar_XML_Click(object sender, EventArgs e)
        {
            string RutaXML = BuscarRutaDocumento();
            lblRutaXML.Text = RutaXML;
            Ruta_XML = RutaXML;
            ListaRutasArchivosXML.Text = RutaXML;
        }

        private void btnSelecionarRuta_Click(object sender, EventArgs e)
        {
            string RutaSelectPDF = RutaSelecionadaParaPDF();
            txtRutaSelecionadaPDF.Text = RutaSelectPDF;
            Ruta_SelectPDF = RutaSelectPDF;
        }

        private void btnCrear_PDF_Click(object sender, EventArgs e)
        {

            if (Ruta_XML != null && Ruta_XML != "" && Ruta_SelectPDF != null && Ruta_SelectPDF != "" &&
                txtNombrePDF.Text != null && txtNombrePDF.Text != "")
            {
                GenerarXMLtoPDF _generarPDF = new GenerarXMLtoPDF(Ruta_XML, txtNombrePDF.Text, Ruta_SelectPDF);

                switch (_generarPDF.CrearPDF())
                {
                    case 0:
                        _firma.ActulizarDatosDeRutasArchivosXML(Ruta_XML);
                        CargarDatosFormularios();
                        DialogResult result = MessageBox.Show("El PDF se generó con exito, ¿Desea visualizar el archivo PDF?", "Exito", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (result.Equals(DialogResult.Yes)) {
                          //se visualiza el pdf en un cuadro de dialogo
                            new Visor_PDF(Ruta_SelectPDF + "\\" + txtNombrePDF.Text + ".pdf").ShowDialog();
                        }

                            break;

                    case 1:
                        MessageBox.Show("Error al crear el PDF", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        break;
                    case 2:
                        MessageBox.Show("El archivo xml que selecciono es incorrecto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;

                    case 3:
                        _firma.ActulizarDatosDeRutasArchivosXML(Ruta_XML);
                        CargarDatosFormularios();
                        DialogResult result2 = MessageBox.Show("El PDF se sobrescribio y se genero con exito, ¿Desea visualizar el archivo PDF?", "Exito", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (result2.Equals(DialogResult.Yes))
                        {   //se visualiza el pdf en un cuadro de dialogo
                            new Visor_PDF(Ruta_SelectPDF + "\\" + txtNombrePDF.Text + ".pdf").ShowDialog();
                        }

                        break;

                    case 4:
                        /*este caso solo es de salida */
                        break;
                    case 5:
                        MessageBox.Show("El archivo XML ha sido corrompido y falló en la validación", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;

                    case 6:
                        MessageBox.Show("Ocurrio un error en la creacion del codigo QR", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;

                    default:
                        MessageBox.Show("Indice de error invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;

                }

            }
            else
            {
                int opcion = 0;

                if (Ruta_XML == null || Ruta_XML == "") { opcion = 1; }
                else
                {
                    if (txtNombrePDF.Text == null || txtNombrePDF.Text == "") { opcion = 2; }
                    else
                    {
                        if (Ruta_SelectPDF == null || Ruta_SelectPDF == "") { opcion = 3; }
                    }
                }

                switch (opcion)
                {
                    case 1:
                        {
                            MessageBox.Show("Debe selecionar un XML", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            break;
                        }
                    case 2:
                        {
                            MessageBox.Show("Debe selecionar un nombre para el PDF", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            break;
                        }
                    case 3:
                        {
                            MessageBox.Show("Debe selecionar una ruta para guardar el PDF", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            break;
                        }
                }
            }
        }


        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void btnBuscar_XML_MouseEnter(object sender, EventArgs e)
        {
            this.btnBuscar_XML.Image = global::control_principal.Properties.Resources.folder22;
        }

        private void btnBuscar_XML_MouseLeave(object sender, EventArgs e)
        {
            this.btnBuscar_XML.Image = global::control_principal.Properties.Resources.folder2;
        }

        private void btnSelecionarRuta_MouseEnter(object sender, EventArgs e)
        {
            this.btnSelecionarRuta.Image = global::control_principal.Properties.Resources.folder22;
        }

        private void btnSelecionarRuta_MouseLeave(object sender, EventArgs e)
        {
            this.btnSelecionarRuta.Image = global::control_principal.Properties.Resources.folder2;
        }

        private void btnCrear_PDF_MouseEnter(object sender, EventArgs e)
        {
            this.btnCrear_PDF.Image = global::control_principal.Properties.Resources.crearPDF2;
        }

        private void btnCrear_PDF_MouseLeave(object sender, EventArgs e)
        {
            this.btnCrear_PDF.Image = global::control_principal.Properties.Resources.crearPDF1;
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

        private void label4_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ListaRutasArchivosXML_SelectedValueChanged(object sender, EventArgs e)
        {
            datosListas();
        }


    }
}
