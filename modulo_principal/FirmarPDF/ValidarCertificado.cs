using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Pkcs;
using Org.BouncyCastle.X509;

namespace FirmarPDF
{
    public class ValidarCertificado
    {
        public AsymmetricKeyParameter Key { get; private set; }

        public X509Certificate[] Chain { get; private set; }

        string RutaCompletaDelPfx { get; set; } = null;
        string  ClaveDelPfx { get; set; } = null;

        public ValidarCertificado(string _rutaCompletaDelPfx, string _claveDelPfx = null)
        {
            this.RutaCompletaDelPfx = _rutaCompletaDelPfx;
            this.ClaveDelPfx = _claveDelPfx;

        }

        public int Validar_AlmacenPFX() {

           
                   if (!System.IO.File.Exists(RutaCompletaDelPfx))
                   {
                       return 1; //si no existe el archivo pfx en la ruta guardad en la BD
                   }

                    var file = File.OpenRead(RutaCompletaDelPfx);
                    var password = ClaveDelPfx?.ToCharArray() ?? new char[] { }; //contraseña que posee el alchivo de certificado

            try
            {
               
                    var store = new Pkcs12Store(file, password);
                    var alias = GetCertificateAlias(store);
                    Key = store.GetKey(alias).Key;
                    Chain = store.GetCertificateChain(alias).Select(x => x.Certificate).ToArray();
                

                return 0;//no se encontro nigun error al validar el pfx
            }
            catch (Exception)
            {

                return 2;//si la contraseña insertada es incorrecta
            }

        }

        private static string GetCertificateAlias(Pkcs12Store store)
        {
            foreach (string currentAlias in store.Aliases)
            {
                if (store.IsKeyEntry(currentAlias))
                {
                    return currentAlias;
                }
            }

            return null;
        }
    }
}
