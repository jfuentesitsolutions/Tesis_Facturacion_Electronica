using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Pkcs;
using Org.BouncyCastle.X509;
using Org.BouncyCastle.Asn1.X509;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Crypto.Parameters;

namespace cryptografia
{
    public class firma_digital
    {
        private AsymmetricKeyParameter llave_privada;
        private Org.BouncyCastle.X509.X509Certificate[] certificado;
        private bool verificado = false;

        //llave privada del pfx
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

        //certificado del pfx aqui esta la llave publica
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

        public bool Verificado
        {
            get
            {
                return verificado;
            }

            set
            {
                verificado = value;
            }
        }

        public  firma_digital(string ruta_del_certificado, string clave_del_certificado = null)
        {
            
            //abrimos el archivo pfx
            using (var file = File.OpenRead(ruta_del_certificado))
            {
                // pasamos la contraseña a un arreglo de chars
                var password = clave_del_certificado?.ToCharArray() ?? new char[] { /* password en blanco */ };

                try
                {
                    // abrimos el pfx y lo almacenamos en un objeto almacen
                    var almacen = new Pkcs12Store(file, password);
                    // sacamos del almacen el nombre del certificado
                    var alias = getCertificado(almacen);
                    // sacamos la llave privada del almacen con el alias obtenido
                    llave_privada = almacen.GetKey(alias).Key;
                    // almacenamos en la variable certificado el certificado del almacen
                    certificado = almacen.GetCertificateChain(alias).Select(x => x.Certificate).ToArray();
                    verificado = true;      
                }
                catch
                {
                    verificado = false;
                }
                
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
            byte[] cadena_ori= Encoding.UTF8.GetBytes(cadena_original);
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
    }
}
