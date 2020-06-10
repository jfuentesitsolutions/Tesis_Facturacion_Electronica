using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulosfacturaElectronica.ClasesValidacion
{
    public class GenPFX
    {
        private string NomKeyRSA { get; set; }
        private string ContraKey { get; set; }
        private string LogKey { get; set; }
        private string TiempoValides { get; set; }
        private string NomPFX { get; set; }


        public GenPFX(string _NomKeyRSA, string _ContraKey, string _LogKey, string _TiempoValides = null, string _NomPFX = null)
        {
            NomKeyRSA = _NomKeyRSA + ".key";
            ContraKey = _ContraKey;
            LogKey = _LogKey;
            TiempoValides = _TiempoValides;
            NomPFX = _NomPFX + ".pfx";
        }


        public bool creaPFX()
        {
            try
            {
                //creamos objetos Process
                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                System.Diagnostics.Process proc2 = new System.Diagnostics.Process();
                System.Diagnostics.Process proc3 = new System.Diagnostics.Process();


                proc.EnableRaisingEvents = false;
                proc2.EnableRaisingEvents = false;
                proc3.EnableRaisingEvents = false;
                //proc4.EnableRaisingEvents = false;
                //proc5.EnableRaisingEvents = false;

                //para  generar la llave privada
                proc.StartInfo.FileName = "openssl";
                proc.StartInfo.Arguments = "genrsa -des3 -passout pass:" + ContraKey + " -out  C:\\Users\\Mario\\Desktop\\" + NomKeyRSA + " " + LogKey + " ";
                proc.StartInfo.WorkingDirectory = @"D:\Descargas\OpenSSL\bin\";
                proc.Start();
                proc.WaitForExit();



                proc2.StartInfo.FileName = "openssl";
                proc2.StartInfo.Arguments = "rsa -passin pass:" + ContraKey + " -in C:\\Users\\Mario\\Desktop\\" + NomKeyRSA + " -out C:\\Users\\Mario\\Desktop\\llaves.key";
                proc2.StartInfo.WorkingDirectory = @"D:\Descargas\OpenSSL\bin\";
                proc2.Start();
                proc2.WaitForExit();


                proc3.StartInfo.FileName = "openssl";
                proc3.StartInfo.Arguments = "req -new -key C:\\Users\\Mario\\Desktop\\llaves.key -out C:\\Users\\Mario\\Desktop\\certificado.cer -config 'D:\\Descargas\\OpenSSL\\bin\\openssl.cnf' ";
                proc3.StartInfo.WorkingDirectory = @"D:\Descargas\OpenSSL\bin\";
                proc3.Start();
                proc3.WaitForExit();


                /*  
                     req - new - key llaves.key -out certificado.cer -config "D:\Descargas\OpenSSL\bin\openssl.cnf"
                     x509 - req - sha256 - days 1024 -in certificado.cer - signkey llaves.key -out certificado.cer
                     pkcs12 - export -in certificado.cer - inkey llaves.key -out certificado_mape.pfx*/

                proc.Dispose();
                proc2.Dispose();
                proc3.Dispose();


                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }


    }
}
