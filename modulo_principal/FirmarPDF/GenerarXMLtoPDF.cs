using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;



namespace FirmarPDF
{
    public class GenerarXMLtoPDF : Form
    {
        public string PathXML { get; set; } = null;
        public string NombrePDF { get; set; } = null;
        public string RutaSelecPDF { get; set; } = null;
        private Comprobante objetoComprobante;


        public GenerarXMLtoPDF(string _PathXML, string _NombrePDF, string _RutaSelecPDF)
        {
            PathXML = _PathXML;
            NombrePDF = _NombrePDF;
            RutaSelecPDF = _RutaSelecPDF;
        }

        public GenerarXMLtoPDF()
        {

        }

        private bool ValidarSiesArchivoXML(string _rutaXML)
        {

            try
            {

                XmlSerializer ObjetoSerializar = new XmlSerializer(typeof(Comprobante));

                using (StreamReader reader = new StreamReader(_rutaXML))
                {
                    //deserializamos el xml
                    objetoComprobante = (Comprobante)ObjetoSerializar.Deserialize(reader);

                }

                return true;
            }
            catch (Exception)
            {

                return false;
            }


        }

        public int CrearPDF()
        {

            try
            {

           
                //valida si el archivo xml que selecionado sea real mente un archivo xml y no de otro tipo
                if (!ValidarSiesArchivoXML(PathXML)) return 2;

                if (!VerificarXML(PathXML, false)) return 5;

                string pathQR = AppDomain.CurrentDomain.BaseDirectory + "QR_Temp.png";
                string path = AppDomain.CurrentDomain.BaseDirectory + "/";
                string pathPDF = AppDomain.CurrentDomain.BaseDirectory;
                string pathHTMLTemp = path + "miHtml.html"; //temporal
                string pathHTMLPlantilla = AppDomain.CurrentDomain.BaseDirectory + "..\\..\\..\\..\\modulo_principal\\FirmarPDF\\PlantillasHTML\\plantilla.html";
                string sHtml = File.ReadAllText(pathHTMLPlantilla);
                string resultHtml = "";

                if (!CreacionCodigoQR(objetoComprobante.Sello, pathQR)) return 6;//realiza la creacion del QR 

                //aplicamos razor
                
                resultHtml = RazorEngine.Razor.Parse(sHtml, objetoComprobante);
                
                //creamos el archivo html temporal con informacion obtenida del xml
                System.IO.File.WriteAllText(pathHTMLTemp, resultHtml);

                string pathWKHTMLTOPDF = AppDomain.CurrentDomain.BaseDirectory + "..\\..\\..\\..\\modulo_principal\\FirmarPDF\\wkhtmltopdf\\wkhtmltopdf.exe";

                ProcessStartInfo oProcessStartInfo = new ProcessStartInfo();
                oProcessStartInfo.UseShellExecute = false;
                oProcessStartInfo.FileName = pathWKHTMLTOPDF;
                //se crea el pdf en una ruta dentro del proyecto
                oProcessStartInfo.Arguments = @"miHtml.html " + NombrePDF + ".pdf";

                using (Process oProcess = Process.Start(oProcessStartInfo))
                {
                    oProcess.WaitForExit();
                }

                //eliminamos el archivo temporal
                System.IO.File.Delete(pathHTMLTemp); //eliminamos el archivo html temporal que se lleno con los datos que contiene el xml

                if (!System.IO.File.Exists(RutaSelecPDF + @"\" + NombrePDF + ".pdf"))
                {
                    //copiamos el pdf creado a la ruta que el usuario a seleccionado 
                    System.IO.File.Copy(pathPDF + NombrePDF + ".pdf", RutaSelecPDF + @"\" + NombrePDF + ".pdf");
                    //elimina el pdf temporal creado
                    System.IO.File.Delete(pathPDF + NombrePDF + ".pdf");
                    // eliminamos el la imagen del codigo qr
                    System.IO.File.Delete(pathQR);
                    return 0;
                }
                else
                {
                    DialogResult a = MessageBox.Show("El pdf ya existe en la ruta selecionada, ¿desea sobrescribir el archivo? ", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (a.Equals(DialogResult.OK))
                    {
                        //elimina el archivo que se sobrescribira
                        System.IO.File.Delete(RutaSelecPDF + @"\" + NombrePDF + ".pdf");
                        //copiamos el pdf creado a la ruta que el usuario a seleccionado 
                        System.IO.File.Copy(pathPDF + NombrePDF + ".pdf", RutaSelecPDF + @"\" + NombrePDF + ".pdf");
                        //elimina el pdf temporal creado
                        System.IO.File.Delete(pathPDF + NombrePDF + ".pdf");
                        // eliminamos el la imagen del codigo qr
                        System.IO.File.Delete(pathQR);
                        return 3;
                    }

                    return 4;
                }

            }
            catch (Exception e)
            {

                Console.Write("Error -- :" + e);
                return 1;

            }

        }

        /********************************CREACION DE CODIGO QR**********************************/

        private bool CreacionCodigoQR(string _selloFactura,string _pathQR) {

            try
            { 
                //instanciamos el codificador QR
                MessagingToolkit.QRCode.Codec.QRCodeEncoder codificadorQR = new MessagingToolkit.QRCode.Codec.QRCodeEncoder();
                codificadorQR.QRCodeScale = 8; //se establece la escala que tendra el qr

                Bitmap bmp = codificadorQR.Encode(_selloFactura);

                bmp.Save(_pathQR);//guardamos una copia temporal del qr en formato png 

                return true;//el qr se creo con exito
            }
            catch (Exception)
            {

                return false;//fallo en la creacion del codigo qr
            }
           
        }

        /*****************************************VALIDACION DE XML*************************************************************************************/
        private System.Xml.Xsl.XslCompiledTransform tran = new System.Xml.Xsl.XslCompiledTransform(true);
        private string cadena_ori = "";

        //Esta funcion verifica si el archivo Xslt es correcto
        private bool VerificacionDeXslt(string _pathXslt)
        {
            try
            {

                tran.Load(_pathXslt);
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }

        //esta funcion verifica si el archivo xml selecionado es correcto
        private bool VerificarArchivoXML(string _xml)
        {
            try
            {
                using (StringWriter sw = new StringWriter())
                using (XmlWriter swm = XmlWriter.Create(sw, tran.OutputSettings))
                {
                    tran.Transform(_xml, swm); // aqui transforma el xml a la cadena original
                    cadena_ori = sw.ToString();
                }

                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }

        public bool VerificarXML(string rutaXML,bool _flag)
        {

            try
            {
           
                /*******************************Obtenemos la cadena original del xml*****************************************/
                string version = ""; // Obtenido del XML 
                string certificado = ""; // Obtenido del XML
                string selloBase64 = ""; // Obtenido del XML
                string pathXslt = Directory.GetCurrentDirectory() + "\\..\\..\\..\\ArchivosFacturaElectronica\\cadenaoriginal_3_3.xslt";

                /*******Esta validacion solo es para la validacion para generar el JSON*****/
                if (_flag)
                {// verifica si el xml selecionado es correcto
                    if (VerificacionDeXslt(pathXslt))
                    {
                        if (!VerificarArchivoXML(rutaXML))
                        {
                            MessageBox.Show("El archivo XML que ha selecionado es incorrecto", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                            return false;
                        }
                    }
                    else {

                        MessageBox.Show("Error en el archivo .xslt", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        return false;
                    }


                }

                if (!_flag)
                {
                    if (!VerificacionDeXslt(pathXslt)) return false; // verifica si el archivo xslt es correcta
                    if (!VerificarArchivoXML(rutaXML)) return false;// verifica si el xml selecionado es correcto
                }
               

                /*********************************Obtenemos la informacion interna del xml*****************************/

                XmlDocument xDoc = new XmlDocument();
                xDoc.Load(@rutaXML);

                XmlNodeList _Comprobante = xDoc.GetElementsByTagName("Comprobante");

                foreach (XmlElement nodo in _Comprobante)
                {
                    version = nodo.GetAttribute("Version");
                    certificado = nodo.GetAttribute("Certificado");
                    selloBase64 = nodo.GetAttribute("Sello");

                }

                /******************************************************************************************************/

                byte[] sello = Convert.FromBase64String(selloBase64);
                X509Certificate2 cert = new X509Certificate2(Convert.FromBase64String(certificado));
                RSACryptoServiceProvider verificador = (RSACryptoServiceProvider)cert.PublicKey.Key;
                HashAlgorithm algoritmoHash = null;
                byte[] hashCadenaOriginal = null;
                bool selloValido = false;

                switch (version)
                {
                    case "3.2":
                        algoritmoHash = SHA1.Create();
                        hashCadenaOriginal = algoritmoHash.ComputeHash(Encoding.UTF8.GetBytes(cadena_ori));
                        selloValido = verificador.VerifyHash(hashCadenaOriginal, "SHA1", sello);
                        break;
                    case "3.3":
                        algoritmoHash = SHA256.Create();
                        hashCadenaOriginal = algoritmoHash.ComputeHash(Encoding.UTF8.GetBytes(cadena_ori));
                        selloValido = verificador.VerifyHash(hashCadenaOriginal, "SHA256", sello);
                        break;
                    default:
                        return false;

                }

                if (selloValido)
                {
                    return true; // el xml no ha sufrido modificaciones y es valido el sello
                }
                else
                {

                    if (!_flag)
                    {
                        return false; // ha sufrido modificaciones 

                    } else {

                        MessageBox.Show("El archivo XML se ha modificado, y no pudo ser validado", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                        return false; // ha sufrido modificaciones 
                    }
                
                }
            }
            catch (Exception)
            {

                return false; // error en elproceso de validacion del xml
            }


        }

/***********************************************************************************************************************************************/


    }
}
