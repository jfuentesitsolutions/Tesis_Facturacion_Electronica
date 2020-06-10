using iTextSharp.text.pdf;
using Org.BouncyCastle.Security;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmarPDF
{
    public class ValidacionPDF
    {
        private readonly ValidarCertificado certificado;

        public ValidacionPDF(ValidarCertificado certificado)
        {
            this.certificado = certificado;
        }


       

        public int ValidarDocumentoPDF(string rutaDocumentoFirmado)
        {
            try
            {
                bool pdfFirmado =false;

                using (var reader = new PdfReader(rutaDocumentoFirmado))
                {
                    var campos = reader.AcroFields;
                    var nombresDefirmas = campos.GetSignatureNames();
                    foreach (var nombre in nombresDefirmas)
                    {
                        pdfFirmado = true; //el pdf si esta firmado
                        if (ValidarFirma(campos, nombre))
                        {
                            return 0; // el archivo pdf es valido
                        }
                       
                    }
                }

                if (pdfFirmado)
                {
                    return 1;//el pdf ha sido modificado y no se ha podido validar(si esta firmado)
                }
                else {
                    return 3;//el pdf que seleciono no esta firmado 
                }

                
            }
            catch (Exception)
            {

                return 2; // el archivo seleccionado no es un pdf
            }
          
        }

        private bool ValidarFirma(AcroFields campos, string nombre)
        {
            // Solo se verificará la última revision del documento.

            if (campos.GetRevision(nombre) != campos.TotalRevisions)
                return false;

            // Solo se verificará si la firma es de todo el documento.

            if (!campos.SignatureCoversWholeDocument(nombre))
                return false;

            var firma = campos.VerifySignature(nombre);

            if (!firma.Verify())
                return false;

            foreach (var certificadoDocumento in firma.Certificates)
            {

                foreach (var certificadoDeConfianza in certificado.Chain)
                {
                    try
                    {
                        certificadoDocumento.Verify(certificadoDeConfianza.GetPublicKey());
                        // Si llega hasta aquí, es porque la última firma fue realizada

                        // con el certificado del sistema.

                        return true;
                    }
                    catch (InvalidKeyException)
                    {
                        continue;
                    }
                    catch (Exception ex)
                    {
                        Trace.TraceError("Error: {0}", ex);
                        continue;
                    }
                }
            }

            return false;
        }

    }
}
