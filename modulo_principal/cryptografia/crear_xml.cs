using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using conexiones_BD.clases.ventas;
using conexiones_BD.clases;
using System.Xml.Serialization;
using System.Xml;
using System.IO;
using System.Xml.Xsl;
using Org.BouncyCastle.Crypto.Parameters;
using Newtonsoft.Json;

namespace cryptografia
{
    public class crear_xml
    {
        private DataTable cliente;
        private DataTable empres;
        private facturas factura;
        private List<detalles_productos_venta_factura> items;
        private Comprobante factura_xml;
        private DataTable resolucion;
        private sessionManager.secion sesion = sessionManager.secion.Instancia;
        private string ruta_certificado;
        private string ruta_almacen;
        private string directorio;
        private string contra;

        public crear_xml(string idcliente, facturas fact, List<detalles_productos_venta_factura> items, 
            string ruta_xml, string contra)
        {
            this.cliente = clientes.clienteXid(idcliente);
            this.factura = fact;
            this.items = items;
            this.empres = empresa.datos_empresa();
            this.factura_xml = new Comprobante();
            this.resolucion = resoluciones.datos_resolucion_activa();
            this.directorio = ruta_xml;
            this.contra = contra;
            
        }

        public crear_xml()
        {

        }

        private void creandoFacturaXml()
        {
            
            factura_xml.Version = factura.Version;
            factura_xml.NumFactura = factura.Num_factura_numero;
            factura_xml.CorrInicio = sesion.Serie + sesion.Serie_inicio;
            factura_xml.CorrFinal = sesion.Serie + sesion.Serie_final;
            factura_xml.FechaExpedicion = factura.Fecha_expedicion;
            factura_xml.FechaOperacion = factura.Fecha_operacion;
            factura_xml.FechaOperacionSpecified = true;
            factura_xml.FormaPago = factura.Idforma_pago;
            factura_xml.NumResolucion = sesion.Resolucion;
            factura_xml.FechaResolucion = resolucion.Rows[0][1].ToString();
            factura_xml.SubTotal = Convert.ToDecimal(factura.Sub_total);
            factura_xml.Descuento = Convert.ToDecimal(factura.Descuento_renta);
            factura_xml.DescuentoSpecified = false;
            factura_xml.Moneda = factura.Moneda;
            factura_xml.Total = Convert.ToDecimal(factura.Total);
            factura_xml.TipoDeComprobante = factura.Idtipo_factura;
            factura_xml.MetodoPago = factura.Metodo_pago;
            factura_xml.MetodoPagoSpecified = true;
            factura_xml.LugarExpedicion = factura.Lugar_expedicion;
            factura_xml.Cantidad_letras = factura.Cantidad_letras;
            factura_xml.Emisor = empre();
            factura_xml.Receptor = client();
            factura_xml.Conceptos = item().ToArray();
            factura_xml.Impuestos = impuestos();
            if (Convert.ToDouble(factura.Total) > 200)
            {
                factura_xml.Mayor200 = mayor200();
            }
            creandoXML(factura_xml);
        }

        private string cadena_original()
        {
            string cadena_ori = "";
            string formato_cadena = Path.GetFullPath("cadenaoriginal_3_3.xslt");
            XslCompiledTransform tran = new XslCompiledTransform(true);
            tran.Load(formato_cadena);

            using (StringWriter sw = new StringWriter())
            using (XmlWriter swm = XmlWriter.Create(sw, tran.OutputSettings))
            {
                tran.Transform(directorio, swm);
                cadena_ori = sw.ToString();
            }

            return cadena_ori;
        }

        public List<bool> firmando_documento()
        {
            this.ruta_almacen = empres.Rows[0][8].ToString();
            this.ruta_certificado = empres.Rows[0][9].ToString();
            firma_digital firma = new firma_digital(ruta_almacen, contra);
            List<bool> listo = new List<bool>();

            if (firma.Verificado)
            {
                string nc, aa, bb, cc;
                firma.leer_certificado(ruta_certificado, out aa, out bb, out cc, out nc);
                factura_xml.NoCertificado = nc;
                creandoFacturaXml();

                if (firma.llave_priva != null)
                {
                    RsaKeyParameters llavePrivada = (RsaKeyParameters)firma.llave_priva;
                    factura_xml.Certificado = firma.certificado_base64(ruta_certificado);
                    factura_xml.Sello = firma.sella_xml(llavePrivada, cadena_original());
                    creandoFacturaXml();
                    listo.Add(true);
                }
                return listo;
            }else
            {
                listo.Add(false);
                return listo;
            }  
        }

        public bool creando_json(string directorio_xml, string directorio_json)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(directorio_xml);
                File.Delete(directorio_xml);
                string json = JsonConvert.SerializeXmlNode(doc);
                File.WriteAllText(directorio_json, json);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void creandoXML(Comprobante fac)
        {
            XmlSerializerNamespaces nombre = new XmlSerializerNamespaces();
            nombre.Add("cfdi", "http://www.dat.gob.mx/cfd/3");
            nombre.Add("tfd", "http://www.dat.gob.mx/cfd/3");
            nombre.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");

            XmlSerializer serializar = new XmlSerializer(typeof(Comprobante));

            string xmln = "";

            using (var sw = new codificar(Encoding.UTF8))
            {
                using (XmlWriter writer = XmlWriter.Create(sw))
                {
                    serializar.Serialize(writer, fac, nombre);
                    xmln = sw.ToString();
                }
            }

            File.WriteAllText(directorio, xmln);
            
        }

        private ComprobanteEmisor empre()
        {
            ComprobanteEmisor empre = new ComprobanteEmisor();
            empre.NRC = empres.Rows[0][2].ToString(); 
            empre.NombreEmpresa = empres.Rows[0][1].ToString();
            empre.RazonSocial = empres.Rows[0][3].ToString();
            empre.Denominacion = empres.Rows[0][4].ToString();
            empre.Giro = empres.Rows[0][5].ToString();
            empre.Direccion_Local = empres.Rows[0][6].ToString();
            empre.Nit = empres.Rows[0][7].ToString();
            

            return empre;
        }

        private ComprobanteReceptor client()
        {
            ComprobanteReceptor cli = new ComprobanteReceptor();
            cli.Nombre_Cliente = cliente.Rows[0][2].ToString() + " " + cliente.Rows[0][3].ToString();
            cli.NRC = cliente.Rows[0][7].ToString();
            cli.Denominacion = cliente.Rows[0][1].ToString();
            cli.Razon_Social = cliente.Rows[0][8].ToString();
            cli.Giro = cliente.Rows[0][8].ToString();
            cli.Direccion = cliente.Rows[0][4].ToString();
            cli.Nit = cliente.Rows[0][6].ToString();

            return cli;
        }

        private List<ComprobanteConcepto> item()
        {
            List<ComprobanteConcepto> ite = new List<ComprobanteConcepto>();
            foreach(detalles_productos_venta_factura it in items)
            {
                ComprobanteConcepto con = new ComprobanteConcepto();
                con.Cantidad = Convert.ToDecimal(it.Cantidad);
                con.Descripcion = it.Nombre+" "+it.Presentacion;
                con.Precio_Unitario = Convert.ToDecimal(it.Precio_venta);
                con.Monto_Total = Convert.ToDecimal(it.Total);
                con.Descuento = Convert.ToDecimal(it.Descuento_iva);
                con.DescuentoSpecified = true;
                con.Condiciones = it.Codigo;

                ite.Add(con);
            }

            return ite;
        }

        private ComprobanteImpuestos impuestos()
        {
            ComprobanteImpuestos impuesto = new ComprobanteImpuestos();
            impuesto.Total_Iva = Convert.ToDecimal(factura.Descuento_iva);
            impuesto.Total_Iva_Specified = true;
            impuesto.Total_Renta = Convert.ToDecimal(factura.Descuento_renta);
            impuesto.Total_Renta_Specified = true;

            return impuesto;
        }

        private ComprobanteMayor200 mayor200()
        {
            ComprobanteMayor200 mayo = new ComprobanteMayor200();
            mayo.Nombre_persona_entrega = factura.Nom_per_entrega;
            mayo.Nombre_persona_recibe = factura.Nom_pre_recibe;
            mayo.Dui_persona_entrega = factura.Dui_per_entrega;
            mayo.Dui_persona_recibe = factura.Dui_per_recibe;
            mayo.Nit_persona_entrega = factura.Nit_per_entrega;
            mayo.Nit_persona_recibe = factura.Nit_per_recibe;

            return mayo;
        }

        
    }
}
