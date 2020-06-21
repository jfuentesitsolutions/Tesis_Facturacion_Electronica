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
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Renderer;
using iText.Layout.Borders;
using iText.Layout.Element;
using iText.Kernel.Geom;
using iText.Layout.Properties;
using iText.Kernel.Pdf.Canvas;


namespace FirmarPDF
{
    public class GenerarXMLtoPDF : Form
    {
        public string PathXML { get; set; } = null;
        public string NombrePDF { get; set; } = null;
        public string RutaSelecPDF { get; set; } = null;
        public System.Drawing.Image Ima { get => ima; set => ima = value; }

        private Comprobante objetoComprobante;
        private System.Drawing.Image ima;
        Bitmap codigo;

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
                /*string path = AppDomain.CurrentDomain.BaseDirectory + "/";
                string pathPDF = AppDomain.CurrentDomain.BaseDirectory;
                string pathHTMLTemp = path + "miHtml.html"; //temporal
                string pathHTMLPlantilla = AppDomain.CurrentDomain.BaseDirectory + "..\\..\\..\\..\\modulo_principal\\FirmarPDF\\PlantillasHTML\\plantilla.html";
                string sHtml = File.ReadAllText(pathHTMLPlantilla);
                string resultHtml = "";*/

                if (!CreacionCodigoQR(objetoComprobante.Sello, pathQR)) return 6;//realiza la creacion del QR 

                /*//aplicamos razor
                
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
                */

                if (!System.IO.File.Exists(RutaSelecPDF + @"\" + NombrePDF + ".pdf"))
                {
                    /*//copiamos el pdf creado a la ruta que el usuario a seleccionado 
                    System.IO.File.Copy(pathPDF + NombrePDF + ".pdf", RutaSelecPDF + @"\" + NombrePDF + ".pdf");
                    //elimina el pdf temporal creado
                    System.IO.File.Delete(pathPDF + NombrePDF + ".pdf");
                    // eliminamos el la imagen del codigo qr
                    System.IO.File.Delete(pathQR);*/

                    //Aqui va en metodo que crea el pdf
                    this.creando_pdf();
                    return 0;
                }
                else
                {
                    DialogResult a = MessageBox.Show("El pdf ya existe en la ruta selecionada, ¿desea sobrescribir el archivo? ", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (a.Equals(DialogResult.OK))
                    {
                        /*//elimina el archivo que se sobrescribira
                        System.IO.File.Delete(RutaSelecPDF + @"\" + NombrePDF + ".pdf");
                        //copiamos el pdf creado a la ruta que el usuario a seleccionado 
                        System.IO.File.Copy(pathPDF + NombrePDF + ".pdf", RutaSelecPDF + @"\" + NombrePDF + ".pdf");
                        //elimina el pdf temporal creado
                        System.IO.File.Delete(pathPDF + NombrePDF + ".pdf");
                        // eliminamos el la imagen del codigo qr
                        System.IO.File.Delete(pathQR);*/
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

                codigo = codificadorQR.Encode(_selloFactura);

                codigo.Save(_pathQR);//guardamos una copia temporal del qr en formato png 

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
                string pathXslt = System.IO.Path.GetFullPath("cadenaoriginal_3_3.xslt");

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

        private void creando_pdf()
        {
            var archivo = System.IO.Path.Combine(RutaSelecPDF, NombrePDF + ".pdf");//combinacion de la ruta y el nombre del archivo
            Console.WriteLine(archivo.ToString());
            try
            {
                using (var writer = new PdfWriter(archivo)) //creacion de archivo
                {
                    using (var pdf = new PdfDocument(writer))   //creacion del documento
                    {
                        var doc = new Document(pdf, PageSize.LETTER); //Cracion del documento
                        doc.SetMargins(20, 20, 20, 20);

                        var tabla_principal = new Table(new float[] { 25 });
                        tabla_principal.SetWidth(UnitValue.CreatePercentValue(100)); // Define que la tabla estara en toda la pagina menos en los margenes

                        iText.Layout.Element.Image logo = new iText.Layout.Element.Image(iText.IO.Image.ImageDataFactory.Create(ima, Color.Transparent));

                        Table tabla_encabezado = new Table(new float[] { 1, 1, 1 });
                        Paragraph parrafo_empresa = new Paragraph().SetTextAlignment(TextAlignment.CENTER);
                        parrafo_empresa.Add("Tesis factura electronica\n");
                        parrafo_empresa.Add("Giro: " + objetoComprobante.Emisor.Giro + ".\n");
                        parrafo_empresa.Add("Dirección: " + objetoComprobante.Emisor.Direccion_Local + ".\n");
                        parrafo_empresa.Add("Telefonos: 2401-8785/7624-8080.\n");
                        parrafo_empresa.Add("Correo: jfuentes@gmail.com");

                        Paragraph informacion_empresa = new Paragraph("TecnoCode\n Sistema de ventas y generación de facturas");

                        Cell Logo = new Cell().Add(logo.SetWidth(110).SetHeight(100).SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER)).
                            Add(informacion_empresa).SetBorder(Border.NO_BORDER).SetTextAlignment(TextAlignment.CENTER).SetVerticalAlignment(VerticalAlignment.BOTTOM);
                        Cell Empresa = new Cell().Add(parrafo_empresa).SetBorder(Border.NO_BORDER).SetVerticalAlignment(VerticalAlignment.BOTTOM);

                        iText.Layout.Element.Image codigo_qr = new iText.Layout.Element.Image(iText.IO.Image.ImageDataFactory.Create(codigo, Color.Transparent));
                        Cell qr = new Cell().Add(new Paragraph("Codigo QR").SetTextAlignment(TextAlignment.CENTER)).Add(codigo_qr.SetWidth(110).SetHeight(100).SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER)).SetBorder(Border.NO_BORDER);

                        Paragraph tipo_documento = new Paragraph();

                        string cadena = objetoComprobante.CorrInicio;
                        int longitudCadena = objetoComprobante.CorrInicio.Length;
                        string tipofactura = "---NULL---";
                        //comporbacion del tipo de factura selecionada
                        for (int i = longitudCadena - 1; i > 0; i--)
                        {

                            if (cadena.Substring(i, 1).Equals("C"))
                            {
                                tipofactura = "COMPROBANTE DE CREDITO FISCAL";
                                break;
                            }

                            if (cadena.Substring(i, 1).Equals("F"))
                            {
                                tipofactura = "COMPROBANTE DE CONSUMIDOR FINAL";
                                break;
                            }

                        }

                        tipo_documento.Add("   " + tipofactura + "   \n").SetTextAlignment(TextAlignment.CENTER).SetBold();
                        Paragraph resolucion = new Paragraph();
                        resolucion.Add("" + objetoComprobante.CorrInicio + " AL " + objetoComprobante.CorrFinal + "").SetTextAlignment(TextAlignment.CENTER).SetFontSize(10);
                        Paragraph numero = new Paragraph();
                        numero.Add("N° " + objetoComprobante.NumFactura + "\n").SetFontColor(iText.Kernel.Colors.ColorConstants.RED).SetTextAlignment(TextAlignment.CENTER);
                        Paragraph anexos = new Paragraph();
                        anexos.Add("REGISTRO N°. " + objetoComprobante.Emisor.Nrc + "\nNIT. " + objetoComprobante.Emisor.Nit + "").SetTextAlignment(TextAlignment.CENTER);

                        Cell correlativo = new Cell().Add(tipo_documento).Add(resolucion).Add(numero).Add(anexos);
                        correlativo.SetBorder(Border.NO_BORDER);
                        correlativo.SetNextRenderer(new RoundedCornersCellRenderer(correlativo));

                        Cell General = new Cell().Add(correlativo).SetBorder(Border.NO_BORDER).Add(qr);
                        tabla_encabezado.AddCell(Logo).SetMargin(5).AddCell(Empresa).AddCell(General);
                        Cell division = new Cell().Add(new Paragraph("__________________________________________________________________________________").SetTextAlignment(TextAlignment.CENTER));

                        Table cliente = new Table(new UnitValue[] { UnitValue.CreatePercentValue(50), UnitValue.CreatePercentValue(10), UnitValue.CreatePercentValue(40) });
                        cliente.SetWidth(UnitValue.CreatePercentValue(100));
                        List<Text> textos = new List<Text>();
                        textos.Add(new Text("CLIENTE: ").SetBold());
                        textos.Add(new Text("DIRECCIÓN: ").SetBold());
                        textos.Add(new Text("MUNICIPIO: ").SetBold());
                        textos.Add(new Text("DEPTO: ").SetBold());
                        textos.Add(new Text("N° DE NOTA DE REMISIÓN ANTERIOR: ").SetBold());
                        textos.Add(new Text("FECHA DE NOTA DE REMISIÓN ANTERIOR: ").SetBold());
                        textos.Add(new Text("FECHA: ").SetBold());
                        textos.Add(new Text("REGISTRO: ").SetBold());
                        textos.Add(new Text("NIT: ").SetBold());
                        textos.Add(new Text("GIRO: ").SetBold());
                        textos.Add(new Text("COND. DE PAGO: ").SetBold());
                        textos.Add(new Text("VENTA A CUENTA DE: ").SetBold());

                        Paragraph info_cliente1 = new Paragraph(textos[0]).Add(objetoComprobante.Receptor.Nombre_Cliente + "\n");
                        info_cliente1.Add(textos[1]).Add(objetoComprobante.Receptor.Direccion + "\n");
                        info_cliente1.Add(textos[2]).Add(" ");
                        info_cliente1.Add(textos[3]).Add("\n");
                        info_cliente1.Add(textos[4]).Add("\n");
                        info_cliente1.Add(textos[5]).Add("");

                        Paragraph info_cliente2 = new Paragraph(textos[6]).Add(objetoComprobante.FechaExpedicion + "\n");
                        info_cliente2.Add(textos[7]).Add(objetoComprobante.Receptor.Nrc_Cliente + "\n");
                        info_cliente2.Add(textos[8]).Add(objetoComprobante.Receptor.Nit_Cliente + "\n");
                        info_cliente2.Add(textos[9]).Add(objetoComprobante.Receptor.Giro_Cliente + "\n");
                        info_cliente2.Add(textos[10]).Add(objetoComprobante.CondicionesDePago + "\n");
                        info_cliente2.Add(textos[11]).Add("-");
                        Cell cli = new Cell().Add(info_cliente1).SetBorder(Border.NO_BORDER);
                        Cell cli2 = new Cell().SetBorder(Border.NO_BORDER);
                        Cell cli3 = new Cell().Add(info_cliente2).SetBorder(Border.NO_BORDER);
                        cliente.AddCell(cli).AddCell(cli2).AddCell(cli3);

                        Cell cuadro_cliente = new Cell().Add(cliente);
                        cuadro_cliente.SetBorder(Border.NO_BORDER);
                        cuadro_cliente.SetNextRenderer(new RoundedCornersCellRenderer(cuadro_cliente));

                        Table tabla_clientes = new Table(1).SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);
                        tabla_clientes.SetWidth(UnitValue.CreatePercentValue(97));
                        tabla_clientes.SetMarginBottom(5);
                        tabla_clientes.AddCell(cuadro_cliente);

                        Table tabla_detalles_facturas = new Table(1).SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);
                        tabla_detalles_facturas.SetWidth(UnitValue.CreatePercentValue(97));
                        Cell detalles_factura = new Cell();
                        detalles_factura.SetBorder(Border.NO_BORDER);
                        detalles_factura.SetNextRenderer(new RoundedCornersCellRenderer(detalles_factura));
                        Table contenido_detalle = new Table(UnitValue.CreatePercentArray(new float[] { 5, 55, 10, 10, 10, 10 }));
                        contenido_detalle.SetWidth(UnitValue.CreatePercentValue(100)).SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);
                        contenido_detalle.AddHeaderCell(new Cell().Add(new Paragraph("N°").SetTextAlignment(TextAlignment.CENTER).SetFontSize(10).
                            SetFontColor(iText.Kernel.Colors.ColorConstants.WHITE)).
                            SetBorder(Border.NO_BORDER).SetVerticalAlignment(iText.Layout.Properties.VerticalAlignment.MIDDLE).
                            SetBackgroundColor(iText.Kernel.Colors.PatternColor.ConvertCmykToRgb(new iText.Kernel.Colors.DeviceCmyk(22, 16, 0, 73))));
                        contenido_detalle.AddHeaderCell(new Cell().Add(new Paragraph("DESCRIPCIÓN").SetTextAlignment(TextAlignment.CENTER).SetFontSize(10).
                            SetFontColor(iText.Kernel.Colors.ColorConstants.WHITE)).
                            SetBorder(Border.NO_BORDER).SetVerticalAlignment(iText.Layout.Properties.VerticalAlignment.MIDDLE).
                            SetBackgroundColor(iText.Kernel.Colors.PatternColor.ConvertCmykToRgb(new iText.Kernel.Colors.DeviceCmyk(22, 16, 0, 73))));
                        contenido_detalle.AddHeaderCell(new Cell().Add(new Paragraph("PRECIO UNITARIO").SetTextAlignment(TextAlignment.CENTER).SetFontSize(10).
                            SetFontColor(iText.Kernel.Colors.ColorConstants.WHITE)).
                            SetBorder(Border.NO_BORDER).SetVerticalAlignment(iText.Layout.Properties.VerticalAlignment.MIDDLE).
                            SetBackgroundColor(iText.Kernel.Colors.PatternColor.ConvertCmykToRgb(new iText.Kernel.Colors.DeviceCmyk(22, 16, 0, 73))));
                        contenido_detalle.AddHeaderCell(new Cell().Add(new Paragraph("VENTAS NO SUJETAS").SetTextAlignment(TextAlignment.CENTER).SetFontSize(10).
                            SetFontColor(iText.Kernel.Colors.ColorConstants.WHITE)).
                            SetBorder(Border.NO_BORDER).SetVerticalAlignment(iText.Layout.Properties.VerticalAlignment.MIDDLE).
                            SetBackgroundColor(iText.Kernel.Colors.PatternColor.ConvertCmykToRgb(new iText.Kernel.Colors.DeviceCmyk(22, 16, 0, 73))));
                        contenido_detalle.AddHeaderCell(new Cell().Add(new Paragraph("VENTAS EXENTAS").SetTextAlignment(TextAlignment.CENTER).SetFontSize(10).
                            SetFontColor(iText.Kernel.Colors.ColorConstants.WHITE)).
                            SetBorder(Border.NO_BORDER).SetVerticalAlignment(iText.Layout.Properties.VerticalAlignment.MIDDLE).
                            SetBackgroundColor(iText.Kernel.Colors.PatternColor.ConvertCmykToRgb(new iText.Kernel.Colors.DeviceCmyk(22, 16, 0, 73))));
                        contenido_detalle.AddHeaderCell(new Cell().Add(new Paragraph("VENTAS AFECTAS").SetTextAlignment(TextAlignment.CENTER).SetFontSize(10).
                            SetFontColor(iText.Kernel.Colors.ColorConstants.WHITE)).
                            SetBorder(Border.NO_BORDER).SetVerticalAlignment(iText.Layout.Properties.VerticalAlignment.MIDDLE).
                            SetBackgroundColor(iText.Kernel.Colors.PatternColor.ConvertCmykToRgb(new iText.Kernel.Colors.DeviceCmyk(22, 16, 0, 73))));

                        /* List<productos> listas = new List<productos>();
                         listas.Add(new productos("1", "FLEIKOS OJUELAS DE MAIZ IRA 26 BOLSA", "$0.88", "$0", "$0", "$0.88"));
                         listas.Add(new productos("1", "TANG DE JAMAICA CAJA", "$2.79", "$0", "$0", "$2.79"));

                         foreach (productos p in listas)
                         {*/

                        var salir = objetoComprobante.Conceptos.Length;//obtiene la cantidad de productos totales
                        var cont = 0;
                        decimal suma_VentasNoSujetas = 0;
                        decimal suma_Ventas_Exentas = 0;


                        while (salir != 0)
                        {
                            contenido_detalle.AddCell(new Cell().Add(new Paragraph(objetoComprobante.Conceptos[cont].Cantidad.ToString()).SetTextAlignment(TextAlignment.CENTER)).SetBorder(Border.NO_BORDER).
                                SetBackgroundColor(iText.Kernel.Colors.PatternColor.ConvertCmykToRgb(new iText.Kernel.Colors.DeviceCmyk(0, 0, 0, 11)))).
                                AddCell(new Cell().Add(new Paragraph(objetoComprobante.Conceptos[cont].Descripcion.ToString()).SetTextAlignment(TextAlignment.CENTER)).SetBorder(Border.NO_BORDER)).
                                AddCell(new Cell().Add(new Paragraph("$"+objetoComprobante.Conceptos[cont].Precio_Unitario.ToString()).SetTextAlignment(TextAlignment.CENTER)).SetBorder(Border.NO_BORDER).
                                SetBackgroundColor(iText.Kernel.Colors.PatternColor.ConvertCmykToRgb(new iText.Kernel.Colors.DeviceCmyk(0, 0, 0, 11)))).
                                AddCell(new Cell().Add(new Paragraph("$"+objetoComprobante.Conceptos[cont].Ventas_No_Sujetas.ToString()).SetTextAlignment(TextAlignment.CENTER)).SetBorder(Border.NO_BORDER)).
                                AddCell(new Cell().Add(new Paragraph("$"+objetoComprobante.Conceptos[cont].Ventas_Exentas.ToString()).SetTextAlignment(TextAlignment.CENTER)).SetBorder(Border.NO_BORDER).
                                SetBackgroundColor(iText.Kernel.Colors.PatternColor.ConvertCmykToRgb(new iText.Kernel.Colors.DeviceCmyk(0, 0, 0, 11)))).
                                AddCell(new Cell().Add(new Paragraph("$"+objetoComprobante.Conceptos[cont].Monto_Total.ToString()).SetTextAlignment(TextAlignment.CENTER)).SetBorder(Border.NO_BORDER));

                            /*}*/

                            suma_VentasNoSujetas = objetoComprobante.Conceptos[cont].Ventas_No_Sujetas + suma_VentasNoSujetas;
                            suma_Ventas_Exentas = objetoComprobante.Conceptos[cont].Ventas_Exentas + suma_Ventas_Exentas;
                            cont++;
                            salir--;
                        }

                        Text texto = new Text("SON:").SetBold();
                        Text texto2 = new Text("SUMAS:").SetBold();


                        contenido_detalle.AddCell(new Cell(1, 2).Add(new Paragraph(texto).Add(" " + objetoComprobante.Cantidad_letras)).
                            SetBorderTop(Border.NO_BORDER).SetBorderRight(Border.NO_BORDER).SetBorderLeft(Border.NO_BORDER).
                            SetBackgroundColor(iText.Kernel.Colors.PatternColor.ConvertCmykToRgb(new iText.Kernel.Colors.DeviceCmyk(0, 0, 0, 28)))).
                            AddCell(new Cell().Add(new Paragraph(texto2)).SetBorderTop(Border.NO_BORDER).SetBorderRight(Border.NO_BORDER).SetBorderLeft(Border.NO_BORDER).
                            SetBackgroundColor(iText.Kernel.Colors.PatternColor.ConvertCmykToRgb(new iText.Kernel.Colors.DeviceCmyk(0, 0, 0, 28)))).
                            AddCell(new Cell().Add(new Paragraph("$ " + suma_VentasNoSujetas).SetTextAlignment(TextAlignment.CENTER)).SetBorderTop(Border.NO_BORDER).SetBorderRight(Border.NO_BORDER).SetBorderLeft(Border.NO_BORDER).
                            SetBackgroundColor(iText.Kernel.Colors.PatternColor.ConvertCmykToRgb(new iText.Kernel.Colors.DeviceCmyk(0, 0, 0, 28)))).
                            AddCell(new Cell().Add(new Paragraph("$ " + suma_Ventas_Exentas).SetTextAlignment(TextAlignment.CENTER)).SetBorderTop(Border.NO_BORDER).SetBorderRight(Border.NO_BORDER).SetBorderLeft(Border.NO_BORDER).
                            SetBackgroundColor(iText.Kernel.Colors.PatternColor.ConvertCmykToRgb(new iText.Kernel.Colors.DeviceCmyk(0, 0, 0, 28)))).
                            AddCell(new Cell().Add(new Paragraph("$ " + objetoComprobante.SubTotal).SetTextAlignment(TextAlignment.CENTER)).SetBorderTop(Border.NO_BORDER).SetBorderRight(Border.NO_BORDER).SetBorderLeft(Border.NO_BORDER).
                            SetBackgroundColor(iText.Kernel.Colors.PatternColor.ConvertCmykToRgb(new iText.Kernel.Colors.DeviceCmyk(0, 0, 0, 28))));


                        Cell operaciones_superior = new Cell(5, 2);
                        operaciones_superior.SetBorder(Border.NO_BORDER);
                        operaciones_superior.SetNextRenderer(new RoundedCornersCellRenderer(operaciones_superior));
                        operaciones_superior.Add(new Table(UnitValue.CreatePercentArray(new float[] { 50, 50 })).SetWidth(UnitValue.CreatePercentValue(100)).
                            AddCell(new Cell(1, 2).Add(new Paragraph("OPERACIÓN SUPERIOR A $11,428.57").SetTextAlignment(TextAlignment.CENTER)).
                            SetBorder(Border.NO_BORDER)).AddCell(new Cell().Add(new Paragraph("ENTREGO: ")).SetBorder(Border.NO_BORDER)).
                            AddCell(new Cell().Add(new Paragraph("RECIBIO: ")).SetBorder(Border.NO_BORDER)).
                            AddCell(new Cell().Add(new Paragraph("DUI: ")).SetBorder(Border.NO_BORDER)).
                            AddCell(new Cell().Add(new Paragraph("DUI: ")).SetBorder(Border.NO_BORDER)).
                            AddCell(new Cell().Add(new Paragraph("FIRMA:")).SetBorder(Border.NO_BORDER)).
                            AddCell(new Cell().Add(new Paragraph("FIRMA:")).SetBorder(Border.NO_BORDER)).
                            AddCell(new Cell().Add(new Paragraph("EXTRANGERO:")).SetBorder(Border.NO_BORDER)).
                            AddCell(new Cell().Add(new Paragraph("EXTRANGERO:")).SetBorder(Border.NO_BORDER)));
                        contenido_detalle.AddCell(operaciones_superior);

                        contenido_detalle.AddCell(new Cell(1, 3).Add(new Paragraph("13% DE I.V.A")).SetBorder(Border.NO_BORDER).SetBold().
                            SetBackgroundColor(iText.Kernel.Colors.PatternColor.ConvertCmykToRgb(new iText.Kernel.Colors.DeviceCmyk(0, 0, 0, 11)))).
                            AddCell(new Cell().Add(new Paragraph("$ " + objetoComprobante.Impuestos.Total_Iva).SetTextAlignment(TextAlignment.CENTER)).SetBorder(Border.NO_BORDER)).
                            AddCell(new Cell(1, 3).Add(new Paragraph("SUB-TOTAL")).SetBorder(Border.NO_BORDER).SetBold().
                            SetBackgroundColor(iText.Kernel.Colors.PatternColor.ConvertCmykToRgb(new iText.Kernel.Colors.DeviceCmyk(0, 0, 0, 11)))).
                            AddCell(new Cell().Add(new Paragraph("$ " + objetoComprobante.SubTotal).SetTextAlignment(TextAlignment.CENTER)).SetBorder(Border.NO_BORDER)).
                            AddCell(new Cell(1, 3).Add(new Paragraph("VENTAS EXENTAS")).SetBorder(Border.NO_BORDER).SetBold().
                            SetBackgroundColor(iText.Kernel.Colors.PatternColor.ConvertCmykToRgb(new iText.Kernel.Colors.DeviceCmyk(0, 0, 0, 11)))).
                            AddCell(new Cell().Add(new Paragraph("").SetTextAlignment(TextAlignment.CENTER)).SetBorder(Border.NO_BORDER)).
                            AddCell(new Cell(1, 3).Add(new Paragraph("(-)IVA RETENIDO")).SetBorder(Border.NO_BORDER).SetBold().
                            SetBackgroundColor(iText.Kernel.Colors.PatternColor.ConvertCmykToRgb(new iText.Kernel.Colors.DeviceCmyk(0, 0, 0, 11)))).
                            AddCell(new Cell().Add(new Paragraph("").SetTextAlignment(TextAlignment.CENTER)).SetBorder(Border.NO_BORDER)).
                            AddCell(new Cell(1, 3).Add(new Paragraph("VENTAS NO SUJETAS")).SetBorder(Border.NO_BORDER).SetBold().
                            SetBackgroundColor(iText.Kernel.Colors.PatternColor.ConvertCmykToRgb(new iText.Kernel.Colors.DeviceCmyk(0, 0, 0, 11)))).
                            AddCell(new Cell().Add(new Paragraph("").SetTextAlignment(TextAlignment.CENTER)).SetBorder(Border.NO_BORDER));

                        contenido_detalle.AddCell(new Cell(1, 2).Add(new Paragraph("Cancelado el,____________ de ___________ de 20____")).SetBorder(Border.NO_BORDER)).
                            AddCell(new Cell(1, 3).Add(new Paragraph("VENTA TOTAL").SetFontColor(iText.Kernel.Colors.ColorConstants.RED)).SetBorder(Border.NO_BORDER).
                            SetBackgroundColor(iText.Kernel.Colors.PatternColor.ConvertCmykToRgb(new iText.Kernel.Colors.DeviceCmyk(0, 0, 0, 28)))).
                            AddCell(new Cell().Add(new Paragraph("$ " + objetoComprobante.Total).SetTextAlignment(TextAlignment.CENTER).SetFontColor(iText.Kernel.Colors.ColorConstants.RED)).SetBorder(Border.NO_BORDER).
                            SetBackgroundColor(iText.Kernel.Colors.PatternColor.ConvertCmykToRgb(new iText.Kernel.Colors.DeviceCmyk(0, 0, 0, 28))));
                        detalles_factura.Add(contenido_detalle);
                        tabla_detalles_facturas.AddCell(detalles_factura);

                        Cell contenido = new Cell().Add(tabla_encabezado).Add(division).Add(tabla_clientes).Add(tabla_detalles_facturas);
                        contenido.SetBorder(Border.NO_BORDER);
                        contenido.SetNextRenderer(new RoundedCornersCellRenderer(contenido));

                        tabla_principal.AddCell(contenido);
                        doc.Add(tabla_principal);
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

            //Firmado del documento
            using (espera_datos.splash_espera fe = new espera_datos.splash_espera())
            {
                fe.Funcion_verificar = firmar;
                fe.Tipo_operacio = 2;

                if (fe.ShowDialog() == DialogResult.OK)
                {
                    int indice = fe.Numero;

                    if (indice == 3)
                    {
                        DialogResult _result = MessageBox.Show("Ya existe una copia firmada del PDF seleccionado, ¿Desea sobrescribir la copia firmada?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                        if (_result.Equals(DialogResult.Yes))
                        {
                            using (espera_datos.splash_espera fe2 = new espera_datos.splash_espera())
                            {
                                fe2.Funcion_verificar = firmar;
                                fe2.Tipo_operacio = 2;

                                if (fe2.ShowDialog() == DialogResult.OK)
                                {
                                    indice = fe2.Numero;
                                }
                            }
                        }
                    }

                    switch (indice)
                    {
                        case 0:
                            //MessageBox.Show("El archivo PDF fue firmado exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            }
        }

        private int firmar()
        {
            Firmante firmante = new Firmante();
            return firmante.Firmar(RutaSelecPDF + NombrePDF + ".pdf", RutaSelecPDF + "Firmado(#)-" + NombrePDF + ".pdf", false, "1234");
        }

        private class RoundedCornersCellRenderer : CellRenderer
        {
            public RoundedCornersCellRenderer(Cell modelElement)
                : base(modelElement)
            { }

            public override void DrawBorder(DrawContext drawContext)
            {
                iText.Kernel.Geom.Rectangle rectangle = this.GetOccupiedAreaBBox();
                float llx = rectangle.GetX() + 1;
                float lly = rectangle.GetY() + 1;
                float urx = rectangle.GetX() + this.GetOccupiedAreaBBox().GetWidth() - 1;
                float ury = rectangle.GetY() + this.GetOccupiedAreaBBox().GetHeight() - 1;
                Console.WriteLine("Coordenadas de los puntos " + llx + " " + lly + " " + urx + " " + ury);

                PdfCanvas canvas = drawContext.GetCanvas();
                float r = 4;
                float b = 0.4477f;
                canvas.MoveTo(llx + r, lly).LineTo(urx - r, lly).
                    CurveTo(urx - r * b, lly, urx, lly + r * b, urx, lly + r).
                    LineTo(urx, ury - r).CurveTo(urx, ury - r * b, urx - r * b, ury, urx - r, ury).
                    LineTo(llx + r, ury).CurveTo(llx + r * b, ury, llx, ury - r * b, llx, ury - r).
                    LineTo(llx, lly + r).CurveTo(llx, lly + r * b, llx + r * b, lly, llx + r, lly).Stroke();
                base.DrawBorder(drawContext);
            }
        }
    }
}
