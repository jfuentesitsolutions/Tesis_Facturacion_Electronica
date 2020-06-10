using Newtonsoft.Json;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Pkcs;
using Org.BouncyCastle.Security;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace ModulosfacturaElectronica.ClasesValidacion
{
    public class FirmaElectronica : OperacionDB
    {

        private AsymmetricKeyParameter llave_privada;
        private Org.BouncyCastle.X509.X509Certificate[] certificado;
        Org.BouncyCastle.X509.X509Certificate[] chain;


        private System.Xml.Xsl.XslCompiledTransform tran = new System.Xml.Xsl.XslCompiledTransform(true);
        private string cadena_ori = "";
        private string PathXmlTemporal = Directory.GetCurrentDirectory() + "\\xmlTemp.xml";

        public AsymmetricKeyParameter llave_priva
        {
            get
            {
                return llave_privada;
            }

            set
            {
                llave_privada = value;
            }
        }

        public Org.BouncyCastle.X509.X509Certificate[] Certificado
        {
            get
            {
                return certificado;
            }

            set
            {
                certificado = value;
            }
        }

        public Org.BouncyCastle.X509.X509Certificate[] Chain
        {
            get
            {
                return chain;
            }

            set
            {
                chain = value;
            }
        }


        public FirmaElectronica()
        {

        }


        #region Metodos Rutas de Archivos XMl
        /*metodo que sirve para obtener el listado de los nombres de los archivos de las rutas guardadas en la base de datos*/
        public List<string> ObtenerNombresDeArchivosXML() {
            return ObtenerListaNombresXML();
        }

        /*metodo que sirve para obtener las rutas guardadas en la base de datos*/
        public List<string> ObtenerRutasDeArchivosXML() {

           return ConsultarRutasDearchivosXML();
        }

        /*metoodo que sirve para actualizar las rutas guradadas en la base de datos*/
        public bool ActulizarDatosDeRutasArchivosXML(string _rutaArchivo) {
            return ActualizarTablaRutaArchivosXML(_rutaArchivo);
        }
        #endregion


        #region Metodos Rutas de Archivos PDF
        /*metodo que sirve para obtener el listado de los nombres de los archivos de las rutas guardadas en la base de datos*/
        public List<string> ObtenerNombresDeArchivosPDF()
        {
            return ObtenerListaNombresPDF();
        }

        /*metodo que sirve para obtener las rutas guardadas en la base de datos*/
        public List<string> ObtenerRutasDeArchivosPDF()
        {

            return ConsultarRutasDearchivosPDF();
        }

        /*metoodo que sirve para actualizar las rutas guradadas en la base de datos*/
        public bool ActulizarDatosDeRutasArchivosPDF(string _rutaArchivo)
        {
            return ActualizarTablaRutaArchivosPDF(_rutaArchivo);
        }
        #endregion


        #region Metodos Rutas de Archivos JSON
        /*metodo que sirve para obtener el listado de los nombres de los archivos de las rutas guardadas en la base de datos*/
        public List<string> ObtenerNombresDeArchivosJSON()
        {
            return ObtenerListaNombresJSON();
        }

        /*metodo que sirve para obtener las rutas guardadas en la base de datos*/
        public List<string> ObtenerRutasDeArchivosJSON()
        {

            return ConsultarRutasDearchivosJSON();
        }

        /*metoodo que sirve para actualizar las rutas guradadas en la base de datos*/
        public bool ActulizarDatosDeRutasArchivosJSON(string _rutaArchivo)
        {
            return ActualizarTablaRutaArchivosJSON(_rutaArchivo);
        }

        #endregion


        public FirmaElectronica(string ruta_del_certificado, string clave_del_certificado = null)
        {
            using (var file = File.OpenRead(ruta_del_certificado))
            {
                var password = clave_del_certificado?.ToCharArray() ?? new char[] { /* password en blanco */ };

                var almacen = new Pkcs12Store(file, password);
                var alias = getCertificado(almacen);

                llave_privada = almacen.GetKey(alias).Key;
                certificado = almacen.GetCertificateChain(alias).Select(x => x.Certificate).ToArray();
            }
        }

        public bool leer_certificado(string archivo, out string Inicio, out string Final, out string Serie, out string Numero)
        {
            if (archivo.Length < 1)
            {
                Inicio = "";
                Final = "";
                Serie = "INVALIDO";
                Numero = "";
                return false;
            }

            X509Certificate2 objCert = new X509Certificate2(archivo);
            StringBuilder objSB = new StringBuilder("Detalle del certificado: \n\n");

            //Detalle
            objSB.AppendLine("Persona = " + objCert.Subject);
            objSB.AppendLine("Emisor = " + objCert.Issuer);
            objSB.AppendLine("Válido desde = " + objCert.NotBefore.ToString());
            Inicio = objCert.NotBefore.ToString();
            objSB.AppendLine("Válido hasta = " + objCert.NotAfter.ToString());
            Final = objCert.NotAfter.ToString();
            objSB.AppendLine("Tamaño de la clave = " + objCert.PublicKey.Key.KeySize.ToString());
            objSB.AppendLine("Número de serie = " + objCert.SerialNumber);
            Serie = objCert.SerialNumber.ToString();

            objSB.AppendLine("Hash = " + objCert.Thumbprint);
            //Numero = "?";
            string tNumero = "", rNumero = "", tNumero2 = "";

            int X;
            if (Serie.Length < 2)
                Numero = "";
            else
            {
                foreach (char c in Serie)
                {
                    switch (c)
                    {
                        case '0': tNumero += c; break;
                        case '1': tNumero += c; break;
                        case '2': tNumero += c; break;
                        case '3': tNumero += c; break;
                        case '4': tNumero += c; break;
                        case '5': tNumero += c; break;
                        case '6': tNumero += c; break;
                        case '7': tNumero += c; break;
                        case '8': tNumero += c; break;
                        case '9': tNumero += c; break;
                    }
                }
                for (X = 1; X < tNumero.Length; X++)
                {
                    //wNewString = wNewString & Right$(Left$(wCadena, x), 1)
                    X += 1;
                    //rNumero = rNumero + 
                    tNumero2 = tNumero.Substring(0, X);
                    rNumero = rNumero + tNumero2.Substring(tNumero2.Length - 1, 1);// Right$(Left$(wCadena, x), 1)
                }
                Numero = rNumero;

            }

            if (DateTime.Now < objCert.NotAfter && DateTime.Now > objCert.NotBefore)
            {
                return true;
            }



            return false;


        }

        public string sella_xml(RsaKeyParameters llave_pri, string cadena_original)
        {
            byte[] cadena_ori = Encoding.UTF8.GetBytes(cadena_original);
            ISigner firma = SignerUtilities.GetSigner(PkcsObjectIdentifiers.Sha256WithRsaEncryption.Id);
            firma.Init(true, llave_pri);
            firma.BlockUpdate(cadena_ori, 0, cadena_ori.Length);
            byte[] texto_firmado = firma.GenerateSignature();

            string sellodigital = Convert.ToBase64String(texto_firmado);
            return sellodigital;

        }

        public string certificado_base64(string ArchivoCER)
        {
            byte[] Certificado = File.ReadAllBytes(ArchivoCER);
            return Base64_Encode(Certificado);
        }

        string Base64_Encode(byte[] str)
        {
            return Convert.ToBase64String(str);
        }

        private string getCertificado(Pkcs12Store almacen)
        {
            foreach (string currentAlias in almacen.Aliases)
            {
                if (almacen.IsKeyEntry(currentAlias))
                {
                    return currentAlias;
                }
            }

            return null;
        }


        //Esta funcion verifica si el archivo Xslt es correcto
        private bool VerificacionDeXslt(string _pathXslt) {
            try
            {
                
                tran.Load(_pathXslt);//<-- esta funcion necesita estar conectada a internet
                return true;
            }
            catch (Exception)
            {

                return false;
            }
           
        }

        //esta funcion verifica si el archivo xml selecionado es correcto
        private bool VerificarArchivoXML(string _xml) {
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

        public int VerificarXML(string rutaXML)
        {
            try
            {
                /*******************************Obtenemos la cadena original del xml*****************************************/
                string version = "";        
                string certificado = ""; // Obtenido del XML
                string selloBase64 = ""; // Obtenido del XML
               // string pathXslt = Directory.GetCurrentDirectory() + "\\..\\..\\..\\ArchivosFacturaElectronica\\cadenaoriginal_3_3.xslt";
                string pathXslt = Path.GetFullPath("cadenaoriginal_3_3.xslt"); 

                if (!VerificacionDeXslt(pathXslt)) return 1; // verifica si el archivo xslt es correcta

                if (!VerificarArchivoXML(rutaXML)) return 2;// verifica si el xml selecionado es correcto

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
                        return 3;
                     
                }

                if (selloValido)
                {
                    return 0; // el xml no ha sufrido modificaciones y es valido el sello
                }
                else
                {
                    return 3; // ha sufrido modificaciones 
                }
            }
            catch (Exception)
            {

                return 4; // error en elproceso de validacion del xml
            }


        }

        //funcion que sirve para verificar si el archivo selecionado es un json y despues pasarlo a xml
        private bool VerificaElarchivoJson(string _pahtjson) {

            try
            {
                using (StreamReader _json = new StreamReader(_pahtjson)) {//leemos el archivo json y lo gusrdamos en un streamreader
                    string json = _json.ReadToEnd();//pasamos el contenido del streamreader a string
                    XNode node = JsonConvert.DeserializeXNode(json); //convertimos el contenido del json en xml
                    string XmlFormat = node.ToString(); //guardamos el contenido del xml en un string
                    System.IO.File.WriteAllText(PathXmlTemporal, XmlFormat);//creamos un archivo xml temporal
                }

                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }

        public int ValidarJSON(string _RutaJson) {

            try
            {
                /*******************************Obtenemos la cadena original del xml*****************************************/
                string version = "";
                string certificado = ""; // Obtenido del XML
                string selloBase64 = ""; // Obtenido del XML
               //string pathXslt = Directory.GetCurrentDirectory() + "\\..\\..\\..\\ArchivosFacturaElectronica\\cadenaoriginal_3_3.xslt";
                string pathXslt = Path.GetFullPath("cadenaoriginal_3_3.xslt");

                if (!VerificaElarchivoJson(_RutaJson)) return 1; // verifica si el archivo Json es correcto
                if (!VerificacionDeXslt(pathXslt)) return 2; // verifica si el archivo xslt es correcto

                

                using (StringWriter sw = new StringWriter())
                using (XmlWriter swm = XmlWriter.Create(sw, tran.OutputSettings))
                {     
                    tran.Transform(PathXmlTemporal, swm); // aqui transforma el xml a la cadena original
                    cadena_ori = sw.ToString();
                }

                /*********************************Obtenemos la informacion interna del xml*****************************/

                XmlDocument xDoc = new XmlDocument();
                xDoc.Load(PathXmlTemporal);
                System.IO.File.Delete(PathXmlTemporal);//eliminamos el xml temporal

                XmlNodeList _Comprobante = xDoc.GetElementsByTagName("Comprobante");

                foreach (XmlElement nodo in _Comprobante)
                {
                    version = nodo.GetAttribute("Version");
                    certificado = nodo.GetAttribute("Certificado");
                    selloBase64 = nodo.GetAttribute("Sello");

                }

                /*******************************************************************************************************/

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
                        return 3;

                }

                if (selloValido)
                {
                    return 0; // el json no ha sufrido modificaciones y es valido el sello
                }
                else
                {
                    return 4; //el archivo json ha sufrido modificaciones 
                }


          

            }
            catch (Exception)
            {

                return 5;//error al validarce el json
            }
        }
    }
}
