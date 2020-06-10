using conexiones_BD.clases;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.security;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmarPDF
{
    public class Firmante
    {
        private DataTable DatosCertificados;
        private string RutaAlmacenPfx {get; set;} = null;

        public Firmante()
        {
            DatosCertificados = empresa.datos_empresa();
        }

        public int Firmar(string rutaDocumentoSinFirma, string rutaDocumentoFirmado,bool ArchivoSobrescrito,string ContraseñaPFX)
        {
            try
            {
                RutaAlmacenPfx = DatosCertificados.Rows[0][8].ToString();

                if (RutaAlmacenPfx==null || RutaAlmacenPfx =="") { return 4; }//verifica que la ruta del pfx no este nula
                

                if (ArchivoSobrescrito) {
                    //elimina el archivo exitente si el usuario elije sobrescribir el archivo
                    System.IO.File.Delete(rutaDocumentoFirmado);
                }

                if (!System.IO.File.Exists(rutaDocumentoFirmado))
                {//verifica si ya existe un archivo que ya este firmado atraves de la ruta 

                    using (var reader = new PdfReader(rutaDocumentoSinFirma))
                    {//aqui se puede verificar si es un archivo pdf

                        ValidarCertificado certificado = new ValidarCertificado(RutaAlmacenPfx, ContraseñaPFX);

                   
                        switch (certificado.Validar_AlmacenPFX()) {
                            case 0:/*caso de escape(si entra este caso es por que el pfx y su contraseña son correctas)*/ break;
                            case 1: return 5;//ocurrio un errror al habrir el pfx(esto pude ser que la ruta es incorrecta o le archivo selecionado sea incorrecto)
                            case 2: return 6;//la contraseña es incorrecta
                        }

                        var validarPDF = new ValidacionPDF(certificado);
                        int docFirmado = validarPDF.ValidarDocumentoPDF(rutaDocumentoSinFirma);

                        //si es una de las 2 opciones quiere decir que el pdf selecionado ya esta firmado y no se podra volver a firmar
                        if (docFirmado == 0 || docFirmado == 1)
                        {
                            return 2;
                        }


                        using (var writer = new FileStream(rutaDocumentoFirmado, FileMode.Create, FileAccess.Write))
                        using (var stamper = PdfStamper.CreateSignature(reader, writer, '\0', null, true))
                        {
                            var signature = stamper.SignatureAppearance;
                            signature.CertificationLevel = PdfSignatureAppearance.CERTIFIED_NO_CHANGES_ALLOWED;
                            signature.Reason = "Firma del sistema";
                            signature.ReasonCaption = "Tipo de firma: ";

                            var signatureKey = new PrivateKeySignature(certificado.Key, DigestAlgorithms.SHA256);
                            var signatureChain = certificado.Chain;
                            var standard = CryptoStandard.CADES;

                            MakeSignature.SignDetached(signature, signatureKey, signatureChain, null, null, null, 0, standard);
                        }
                    }



                    return 0;
                }
                else {

                    return 3;
                }

                 
            }
            catch (Exception)
            {

                return 1;
            }
        
        }


    }
}
