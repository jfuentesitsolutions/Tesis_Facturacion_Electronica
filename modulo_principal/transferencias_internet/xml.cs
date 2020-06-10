using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace transferencias_internet
{
    public class xml
    {
        XmlDocument doc;
        string rutaXml;

        public void _crearXml(string nodoRaiz, int suc, string nombreArchivo)
        {
            nuevos_ingresos n = new nuevos_ingresos();

            foreach (string r in n.guardarArchivos(suc, nombreArchivo))
            {
                this.rutaXml = r;
                doc = new XmlDocument();
                if (!File.Exists(r))
                {

                    XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
                    XmlNode root = doc.DocumentElement;
                    doc.InsertBefore(xmlDeclaration, root);


                    XmlNode element1 = doc.CreateElement(nodoRaiz);
                    doc.AppendChild(element1);
                    doc.Save(r);
                }
            }
        }

        public void _crearXml2(string nodoRaiz, string ruta)
        {
                 this.rutaXml = ruta;
                doc = new XmlDocument();
                if (!File.Exists(ruta))
                {

                    XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
                    XmlNode root = doc.DocumentElement;
                    doc.InsertBefore(xmlDeclaration, root);

                    XmlNode element1 = doc.CreateElement(nodoRaiz);
                    doc.AppendChild(element1);
                    doc.Save(ruta);
                }
            
        }

        public void _AñadirProductos(string cp, string np, string fp, string ic, string idmr, int suc)
        {
            nuevos_ingresos n = new nuevos_ingresos();

            foreach(string r in n.guardarArchivos(suc, "productos.xml"))
            {
                doc.Load(r);

                XmlNode producto = _Crear_Productos(cp, np, fp, ic, idmr);

                XmlNode nodoRaiz = doc.DocumentElement;

                nodoRaiz.InsertAfter(producto, nodoRaiz.LastChild);

                doc.Save(r);
            }
            
        }

        public void _AñadirProvedores_productos(string idproveedor, string idproducto, string codi_p, int suc)
        {
            nuevos_ingresos n = new nuevos_ingresos();

            foreach (string r in n.guardarArchivos(suc, "productos.xml"))
            {
                doc.Load(r);

                XmlNode pro_pro = _Crear_Proveedor_productos(idproveedor, idproducto, codi_p);

                XmlNode nodoRaiz = doc.DocumentElement;

                nodoRaiz.InsertAfter(pro_pro, nodoRaiz.LastChild);

                doc.Save(r);
            }
                
        }

        public void _AñadirSucursal_productos(string idsucursal, string idproducto,
            string idutilidadMayoreo, string idutilidadDetalle, string idestante, string existencias,
            string precio_ventaD, string precio_compraD, string precio_ventaM, string precio_compraM, string k, string codi_producto, int suc)
        {

            nuevos_ingresos n = new nuevos_ingresos();

            foreach (string r in n.guardarArchivos(suc,"productos.xml"))
            {
                doc.Load(r);

                XmlNode pro_pro = _Crear_sucursal_producto(idsucursal, idproducto, idutilidadMayoreo,
                    idutilidadDetalle, idestante, existencias, precio_ventaD, precio_compraD, precio_ventaM, precio_compraM, k, codi_producto);

                XmlNode nodoRaiz = doc.DocumentElement;

                nodoRaiz.InsertAfter(pro_pro, nodoRaiz.LastChild);

                doc.Save(r);
            }
                
        }

        public void _AñadirPrese_prod(string idsucursal_producto, string idpresentacion, string cantidad_unidades,
            string precio, string tipo, string pri, string codi_producto, int suc)
        {
            nuevos_ingresos n = new nuevos_ingresos();

            foreach (string r in n.guardarArchivos(suc,"productos.xml"))
            {
                doc.Load(r);

                XmlNode pro_pro = _Crear_presentacion_productos(idsucursal_producto, idpresentacion, cantidad_unidades, precio, tipo,
                    pri, codi_producto);

                XmlNode nodoRaiz = doc.DocumentElement;

                nodoRaiz.InsertAfter(pro_pro, nodoRaiz.LastChild);

                doc.Save(r);
            }
                
        }

        public void _AñadirSucursal(conexiones_BD.clases.sucursales s, int suc)
        {
            nuevos_ingresos n = new nuevos_ingresos();
            conexiones_BD.clases.sucursales sucur = s;

            foreach (string r in n.guardarArchivos(suc, "sucursales.xml"))
            {
                doc.Load(r);

                XmlNode sucursal = sucur.crearSucursal(doc);

                XmlNode nodoRaiz = doc.DocumentElement;

                nodoRaiz.InsertAfter(sucursal, nodoRaiz.LastChild);

                doc.Save(r);
            }

        }

        public void _AñadirTraslados(conexiones_BD.clases.traslados.traslado s)
        {
            nuevos_ingresos n = new nuevos_ingresos();
            conexiones_BD.clases.traslados.traslado tras = s;

                doc.Load(rutaXml);

                XmlNode sucursal = tras.crearTraslado(doc);

                XmlNode nodoRaiz = doc.DocumentElement;

                nodoRaiz.InsertAfter(sucursal, nodoRaiz.LastChild);

                doc.Save(rutaXml);
        }

        public void _AñadirProductos_traslados(List<conexiones_BD.clases.traslados.detalle_producto_traslado> dt)
        {

            foreach (conexiones_BD.clases.traslados.detalle_producto_traslado dtp in dt)
            {
                doc.Load(rutaXml);

                XmlNode sucursal = dtp.detalleTraslados(doc);

                XmlNode nodoRaiz = doc.DocumentElement;

                nodoRaiz.InsertAfter(sucursal, nodoRaiz.LastChild);

                doc.Save(rutaXml);
            } 

            
        }

        public void _AñadirPresentaciones(List<conexiones_BD.clases.presentaciones_productos> pre)
        {
            nuevos_ingresos n = new nuevos_ingresos();

            foreach (conexiones_BD.clases.presentaciones_productos pr in pre)
            {
                doc.Load(rutaXml);

                XmlNode prest = pr.creaPresentaPro(doc);

                XmlNode nodoRaiz = doc.DocumentElement;

                nodoRaiz.InsertAfter(prest, nodoRaiz.LastChild);

                doc.Save(rutaXml);
            }
  
        }

        public void _AñadirPresentacionesTraslados(List<conexiones_BD.clases.presentaciones_productos> pre)
        {
            nuevos_ingresos n = new nuevos_ingresos();

            foreach (conexiones_BD.clases.presentaciones_productos pr in pre)
            {
                doc.Load(rutaXml);

                XmlNode prest = pr.creaPresentaProTras(doc);

                XmlNode nodoRaiz = doc.DocumentElement;

                nodoRaiz.InsertAfter(prest, nodoRaiz.LastChild);

                doc.Save(rutaXml);
            }

        }

        private XmlNode _Crear_Productos(string cp, string np, string fp, string ic, string idm)
        {

            XmlNode producto = doc.CreateElement("producto");


            XmlElement xc = doc.CreateElement("codigo_productos");
            xc.InnerText = cp;
            producto.AppendChild(xc);


            XmlElement xnombre = doc.CreateElement("nombre_producto");
            xnombre.InnerText = np;
            producto.AppendChild(xnombre);


            XmlElement xf = doc.CreateElement("fecha_ingreso");
            xf.InnerText = fp;
            producto.AppendChild(xf);


            XmlElement xidc = doc.CreateElement("id_categoria");
            xidc.InnerText = ic;
            producto.AppendChild(xidc);

            XmlElement xdim = doc.CreateElement("id_marca");
            xdim.InnerText = idm;
            producto.AppendChild(xdim);


            return producto;
        }

        private XmlNode _Crear_Proveedor_productos(string idproveedor, string idproducto, string codi_p)
        {

            XmlNode pro_pro = doc.CreateElement("proveedor_producto");


            XmlElement xp = doc.CreateElement("idproveedor");
            xp.InnerText = idproveedor;
            pro_pro.AppendChild(xp);


            XmlElement cip = doc.CreateElement("idproducto");
            cip.InnerText = idproducto;
            pro_pro.AppendChild(cip);


            XmlElement co = doc.CreateElement("codigo_productos");
            co.InnerText = codi_p;
            pro_pro.AppendChild(co);


            return pro_pro;
        }

        private XmlNode _Crear_sucursal_producto(string idsucursal, string idproducto, 
            string idutilidadMayoreo, string idutilidadDetalle, string idestante, string existencias, 
            string precio_ventaD, string precio_compraD, string precio_ventaM, string precio_compraM, string k, string codi_producto)
        {

            XmlNode suc_pro = doc.CreateElement("sucursal_producto");


            XmlElement e1 = doc.CreateElement("idsucursal");
            e1.InnerText = idsucursal;
            suc_pro.AppendChild(e1);


            XmlElement e2 = doc.CreateElement("idproducto");
            e2.InnerText = idproducto;
            suc_pro.AppendChild(e2);

            XmlElement e3 = doc.CreateElement("idutilidadM");
            e3.InnerText = idutilidadMayoreo;
            suc_pro.AppendChild(e3);

            XmlElement e4 = doc.CreateElement("idutilidadD");
            e4.InnerText = idutilidadDetalle;
            suc_pro.AppendChild(e4);

            XmlElement e5 = doc.CreateElement("idestante");
            e5.InnerText = idestante;
            suc_pro.AppendChild(e5);

            XmlElement e6 = doc.CreateElement("existencias");
            e6.InnerText = existencias;
            suc_pro.AppendChild(e6);

            XmlElement e7 = doc.CreateElement("precio_ventaD");
            e7.InnerText = precio_ventaD;
            suc_pro.AppendChild(e7);

            XmlElement e8 = doc.CreateElement("precio_compraD");
            e8.InnerText = precio_compraD;
            suc_pro.AppendChild(e8);

            XmlElement e9 = doc.CreateElement("precio_ventaM");
            e9.InnerText = precio_ventaM;
            suc_pro.AppendChild(e9);

            XmlElement e10 = doc.CreateElement("precio_compraM");
            e10.InnerText = precio_compraM;
            suc_pro.AppendChild(e10);

            XmlElement e11 = doc.CreateElement("k");
            e11.InnerText = k;
            suc_pro.AppendChild(e11);

            XmlElement e12 = doc.CreateElement("codigo_productos");
            e12.InnerText = codi_producto;
            suc_pro.AppendChild(e12);


            return suc_pro;
        }

        private XmlNode _Crear_presentacion_productos(string idsucursal_producto, string idpresentacion, string cantidad_unidades,
            string precio, string tipo, string pri, string codi_producto)
        {

            XmlNode prese_pro = doc.CreateElement("presentacion_pro");


            XmlElement e1 = doc.CreateElement("idsucursal_producto");
            e1.InnerText = idsucursal_producto;
            prese_pro.AppendChild(e1);


            XmlElement e2 = doc.CreateElement("idpresentacion");
            e2.InnerText = idpresentacion;
            prese_pro.AppendChild(e2);

            XmlElement e3 = doc.CreateElement("cantidad_unidades");
            e3.InnerText = cantidad_unidades;
            prese_pro.AppendChild(e3);

            XmlElement e4 = doc.CreateElement("precio");
            e4.InnerText = precio;
            prese_pro.AppendChild(e4);

            XmlElement e5 = doc.CreateElement("tipo");
            e5.InnerText = tipo;
            prese_pro.AppendChild(e5);

            XmlElement e6 = doc.CreateElement("pri");
            e6.InnerText = pri;
            prese_pro.AppendChild(e6);

            XmlElement e7 = doc.CreateElement("codigo_productos");
            e7.InnerText = codi_producto;
            prese_pro.AppendChild(e7);

            return prese_pro;
        }

        public void _ReadXml()
        {

            doc.Load(rutaXml);

            XmlNodeList listaEmpleados = doc.SelectNodes("productos/sucursal_producto");

            XmlNode unEmpleado;

            for (int i = 0; i < listaEmpleados.Count; i++)
            {

                unEmpleado = listaEmpleados.Item(i);

                string id = unEmpleado.SelectSingleNode("idsucursal").InnerText;
                string nombre = unEmpleado.SelectSingleNode("idproducto").InnerText;

                Console.Write("Id: {0}, Nombre: {1}\n", id, nombre);

            }


        }

        public List<conexiones_BD.clases.presentaciones_productos> Presentaciones_productos(string id_borrar)
        {
            List<conexiones_BD.clases.presentaciones_productos> pres = new List<conexiones_BD.clases.presentaciones_productos>();
            doc.Load(rutaXml);

            XmlNodeList prese_pro = doc.SelectNodes("productos/presentacion_pro");

            XmlNode pre_p;

            foreach (XmlNode item in prese_pro)
            {

                if (item.SelectSingleNode("codigo_productos").InnerText == id_borrar)
                {

                    pre_p = item;

                    pres.Add(new conexiones_BD.clases.presentaciones_productos(
                        pre_p.SelectSingleNode("idsucursal_producto").InnerText,
                        pre_p.SelectSingleNode("idpresentacion").InnerText,
                        pre_p.SelectSingleNode("cantidad_unidades").InnerText,
                        pre_p.SelectSingleNode("precio").InnerText,
                        pre_p.SelectSingleNode("tipo").InnerText,
                        pre_p.SelectSingleNode("pri").InnerText,
                        "1"
                        ));
                }
            }

            return pres;
        }

        public List<conexiones_BD.clases.proveedores_productos> Proveedores_productos(string id_borrar)
        {
            List<conexiones_BD.clases.proveedores_productos> pres = new List<conexiones_BD.clases.proveedores_productos>();
            doc.Load(rutaXml);

            XmlNodeList prese_pro = doc.SelectNodes("productos/proveedor_producto");

            XmlNode pre_p;

            foreach (XmlNode item in prese_pro)
            {

                if (item.SelectSingleNode("codigo_productos").InnerText == id_borrar)
                {

                    pre_p = item;

                    pres.Add(new conexiones_BD.clases.proveedores_productos(
                        pre_p.SelectSingleNode("idproveedor").InnerText,
                        pre_p.SelectSingleNode("idproducto").InnerText
                        ));
                }
            }

            return pres;
        }

        public conexiones_BD.clases.sucursales_productos sucp(string id_borrar)
        {
            conexiones_BD.clases.sucursales_productos sp=null;
            doc.Load(rutaXml);

            XmlNodeList prese_pro = doc.SelectNodes("productos/sucursal_producto");

            XmlNode pre_p;
            foreach (XmlNode item in prese_pro)
            {

                if (item.SelectSingleNode("codigo_productos").InnerText == id_borrar)
                {

                    pre_p = item;

                    sp = new conexiones_BD.clases.sucursales_productos(
                        pre_p.SelectSingleNode("idsucursal").InnerText,
                        pre_p.SelectSingleNode("idproducto").InnerText,
                        pre_p.SelectSingleNode("idutilidadM").InnerText,
                        pre_p.SelectSingleNode("idutilidadD").InnerText,
                        pre_p.SelectSingleNode("idestante").InnerText,
                        pre_p.SelectSingleNode("existencias").InnerText,
                        pre_p.SelectSingleNode("precio_ventaD").InnerText,
                        pre_p.SelectSingleNode("precio_compraD").InnerText,
                        pre_p.SelectSingleNode("precio_ventaM").InnerText,
                        pre_p.SelectSingleNode("precio_compraM").InnerText,
                        pre_p.SelectSingleNode("k").InnerText
                        );
                }
            }

            return sp;
        }

        public void Borrar(string id_borrar, string baseD)
        {
            doc.Load(rutaXml);

            XmlNode productos = doc.DocumentElement;

            XmlNodeList listaProductos = doc.SelectNodes("productos/"+baseD);

            foreach (XmlNode item in listaProductos)
            {

                if (item.SelectSingleNode("codigo_productos").InnerText == id_borrar)
                {

                    XmlNode nodoOld = item;

                    productos.RemoveChild(nodoOld);
                }
            }

            doc.Save(rutaXml);
        }

        public void BorrarTraslados(string id_borrar, string baseD, string items)
        {
            doc.Load(rutaXml);

            XmlNode productos = doc.DocumentElement;

            XmlNodeList listaProductos = doc.SelectNodes("traslados/" + baseD);

            foreach (XmlNode item in listaProductos)
            {

                if (item.SelectSingleNode(items).InnerText == id_borrar)
                {
                    XmlNode nodoOld = item;

                    productos.RemoveChild(nodoOld);
                }
            }

            doc.Save(rutaXml);
        }

        public void BorrarTrasladosdetalles(string id_borrar,string borra2, string baseD, string items, string items2)
        {
            doc.Load(rutaXml);

            XmlNode productos = doc.DocumentElement;

            XmlNodeList listaProductos = doc.SelectNodes("traslados/" + baseD);

            foreach (XmlNode item in listaProductos)
            {

                if (item.SelectSingleNode(items).InnerText == id_borrar && item.SelectSingleNode(items2).InnerText == borra2)
                {
                    XmlNode nodoOld = item;

                    productos.RemoveChild(nodoOld);
                }
            }

            doc.Save(rutaXml);
        }

        public List<conexiones_BD.clases.traslados.detalle_producto_traslado> productosTraslados(string idcorr)
        {
            List<conexiones_BD.clases.traslados.detalle_producto_traslado> detras = new List<conexiones_BD.clases.traslados.detalle_producto_traslado>();
            doc.Load(rutaXml);


            XmlNodeList pro = doc.SelectNodes("traslados/detalle_traslado");

            XmlNode pre_p;

            foreach (XmlNode item in pro)
            {

                if (item.SelectSingleNode("correlativos_traslados").InnerText == (idcorr))
                {
                    pre_p = item;
                    
                    detras.Add(new conexiones_BD.clases.traslados.detalle_producto_traslado(
                        pre_p.SelectSingleNode("idsucursal_producto").InnerText,
                        pre_p.SelectSingleNode("cantidad").InnerText,
                        pre_p.SelectSingleNode("recibido").InnerText,
                        pre_p.SelectSingleNode("idtraslado").InnerText,
                        pre_p.SelectSingleNode("correlativos_traslados").InnerText,
                        pre_p.SelectSingleNode("cantidad_presentacion").InnerText,
                        pre_p.SelectSingleNode("nombre_presentacion").InnerText,
                        pre_p.SelectSingleNode("codigo_productos").InnerText,
                        pre_p.SelectSingleNode("nombre").InnerText
                        ));
                }
            }

            return detras;
        }

        public List<conexiones_BD.clases.presentaciones_productos> presetacionesTraslados(string id_borrar, string corre)
        {
            List<conexiones_BD.clases.presentaciones_productos> pres = new List<conexiones_BD.clases.presentaciones_productos>();
            doc.Load(rutaXml);

            XmlNodeList prese_pro = doc.SelectNodes("traslados/presentacion_pro");

            XmlNode pre_p;

            foreach (XmlNode item in prese_pro)
            {

                if (item.SelectSingleNode("codigo_productos").InnerText == id_borrar && item.SelectSingleNode("correlativo").InnerText == corre)
                {

                    pre_p = item;
                    conexiones_BD.clases.presentaciones_productos p = new conexiones_BD.clases.presentaciones_productos(
                        pre_p.SelectSingleNode("idsucursal_producto").InnerText,
                        pre_p.SelectSingleNode("idpresentacion").InnerText,
                        pre_p.SelectSingleNode("cantidad_unidades").InnerText,
                        pre_p.SelectSingleNode("precio").InnerText,
                        pre_p.SelectSingleNode("tipo").InnerText,
                        pre_p.SelectSingleNode("pri").InnerText,
                        "1"
                        );
                    p.Cod_producto = pre_p.SelectSingleNode("codigo_productos").InnerText;

                    pres.Add(p);
                }
            }

            return pres;
        }



    }
}
