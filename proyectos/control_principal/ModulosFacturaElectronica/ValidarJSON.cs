﻿using ModulosfacturaElectronica.ClasesValidacion;
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
    public partial class ValidarJSON : Form
    {
        public string Ruta_JSON { get; set; } = null;
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

            listaRutArchivos = _firma.ObtenerRutasDeArchivosJSON();
            listaNomArchivos = _firma.ObtenerNombresDeArchivosJSON();


            ListaRutasArchivosJSON.DataSource = listaNomArchivos;
            datosListas();
        }

        private void datosListas()
        {
            if (ListaRutasArchivosJSON.Text != "" || ListaRutasArchivosJSON.Text != null)
            {

                foreach (var item in listaRutArchivos)
                {
                    if (item.Contains(ListaRutasArchivosJSON.SelectedItem.ToString()))
                    {
                        lblRutaJSON.Text = item.ToString();
                        break;
                    }

                }
            }
            Ruta_JSON = lblRutaJSON.Text;
        }

        public ValidarJSON()
        {
            InitializeComponent();
            CargarDatosFormularios();
        }

        DataTable empresa = conexiones_BD.clases.empresa.datos_empresa();

        private string BuscarRutaDocumento()
        {
            //Crear cuadro de seleccionar archivo
            OpenFileDialog Carpeta = new OpenFileDialog();
            Carpeta.InitialDirectory = empresa.Rows[0][10].ToString();
            Carpeta.DefaultExt = "json";
            Carpeta.Filter = "Text files (*.json)|*.json";
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

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_JSON_Click(object sender, EventArgs e)
        {
            string RutaJson = BuscarRutaDocumento();
            lblRutaJSON.Text = RutaJson;
            Ruta_JSON = RutaJson;
            ListaRutasArchivosJSON.Text = RutaJson;
        }

        private void btnValidarJson_Click(object sender, EventArgs e)
        {
            if (Ruta_JSON != null && Ruta_JSON != "")
            {

                using (espera_datos.splash_espera fe = new espera_datos.splash_espera())
                {
                    fe.Funcion_verificar = verificando;
                    fe.Tipo_operacio = 2;

                    if (fe.ShowDialog() == DialogResult.OK)
                    {
                        switch (fe.Numero)
                        {
                            case 0:
                                MessageBox.Show("El JSON es valido, el contenido no ha sufrido cambios", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            case 1:
                                MessageBox.Show("El archivo que selecciono no es un JSON", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                break;
                            case 2:
                                MessageBox.Show("Error al tratar de encontrar el archivo xslt", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            case 3:
                                MessageBox.Show("Version de comprobate invalida, verifique que la version sea (3.3 ó 3.2) del comprobante", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                break;
                            case 4:
                                MessageBox.Show("El JSON es invalido, su contenido ha sido modificado", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                break;
                            case 5:
                                MessageBox.Show("Error al validarce el JSON", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            default:
                                MessageBox.Show("Indice de error invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                        }
                    }

                }

            }
            else
            {
                MessageBox.Show("Seleccione un archivo JSON", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private int verificando()
        {
            FirmaElectronica validarJson = new FirmaElectronica();
            int respuesta = validarJson.ValidarJSON(Ruta_JSON);
            return respuesta;
        }

        private void btn_cancelar_MouseEnter(object sender, EventArgs e)
        {
            this.btn_cancelar.Image = global::control_principal.Properties.Resources.cerrar2;
        }

        private void btn_cancelar_MouseLeave(object sender, EventArgs e)
        {
            this.btn_cancelar.Image = global::control_principal.Properties.Resources.cerrar1;
        }

        private void btnBuscar_JSON_MouseEnter(object sender, EventArgs e)
        {
            this.btnBuscar_JSON.Image = global::control_principal.Properties.Resources.folder22;
        }

        private void btnBuscar_JSON_MouseLeave(object sender, EventArgs e)
        {
            this.btnBuscar_JSON.Image = global::control_principal.Properties.Resources.folder2;
        }

        private void btnValidarJson_MouseEnter(object sender, EventArgs e)
        {
            this.btnValidarJson.Image = global::control_principal.Properties.Resources.validarJSON2;
        }

        private void btnValidarJson_MouseLeave(object sender, EventArgs e)
        {
            this.btnValidarJson.Image = global::control_principal.Properties.Resources.validarJSON;
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

        private void ListaRutasArchivosJSON_SelectedValueChanged(object sender, EventArgs e)
        {
            datosListas();
        }
    }
}
