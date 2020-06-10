using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace conexiones_BD.clases.ventas
{
    public class detalles_productos_venta_factura:entidad
    {
        string iddetalle, idpresentacion_producto, cantidad, precio_venta, total, utilidad, 
            idventa_factura, descuento_iva, codigo, idsucursal_producto, cantidad_paquete, nombre, presentacion;

        public string Idventa_factura
        {
            get
            {
                return idventa_factura;
            }

            set
            {
                idventa_factura = value;
            }
        }

        public string Iddetalle
        {
            get
            {
                return iddetalle;
            }

            set
            {
                iddetalle = value;
            }
        }

        public string Idpresentacion_producto
        {
            get
            {
                return idpresentacion_producto;
            }

            set
            {
                idpresentacion_producto = value;
            }
        }

        public string Cantidad
        {
            get
            {
                return cantidad;
            }

            set
            {
                cantidad = value;
            }
        }

        public string Precio_venta
        {
            get
            {
                return precio_venta;
            }

            set
            {
                precio_venta = value;
            }
        }

        public string Total
        {
            get
            {
                return total;
            }

            set
            {
                total = value;
            }
        }

        public string Utilidad
        {
            get
            {
                return utilidad;
            }

            set
            {
                utilidad = value;
            }
        }

        public string Descuento_iva
        {
            get
            {
                return descuento_iva;
            }

            set
            {
                descuento_iva = value;
            }
        }

        public string Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;
            }
        }

        public string Idsucursal_producto
        {
            get
            {
                return idsucursal_producto;
            }

            set
            {
                idsucursal_producto = value;
            }
        }

        public string Cantidad_paquete
        {
            get
            {
                return cantidad_paquete;
            }

            set
            {
                cantidad_paquete = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Presentacion
        {
            get
            {
                return presentacion;
            }

            set
            {
                presentacion = value;
            }
        }

        public detalles_productos_venta_factura(string iddetalle, string idpresentacion_producto, 
            string cantidad, string precio_venta, string total, string utilidad, string idventa_factura, 
            string descuento_iva, string codigo, string idsucursal_producto, string cantidad_paquete,
            string nombre, string presentacion)
        {
            this.Iddetalle = iddetalle;
            this.Idpresentacion_producto = idpresentacion_producto;
            this.Cantidad = cantidad;
            this.Precio_venta = precio_venta;
            this.Total = total;
            this.Utilidad = utilidad;
            this.Idventa_factura = idventa_factura;
            this.Descuento_iva = descuento_iva;
            this.Codigo = codigo;
            this.Idsucursal_producto = idsucursal_producto;
            this.Cantidad_paquete = cantidad_paquete;
            this.nombre = nombre;
            this.presentacion = presentacion;
        }

        public override List<string> generarCampos()
        {
            List<string> campos = new List<string>();
            campos.Add("idpresentacion_producto");
            campos.Add("cantidad");
            campos.Add("precio_venta");
            campos.Add("total");
            campos.Add("utilidad");
            campos.Add("idventa_factura");
            campos.Add("descuento_iva");
            campos.Add("codigo");
            campos.Add("idsucursal_producto");
            campos.Add("cantidad_paquete");

            return campos;
        }

        public override List<string> generarValores()
        {
            List<string> campos = new List<string>();
            campos.Add(Idpresentacion_producto);
            campos.Add(Cantidad);
            campos.Add(Precio_venta);
            campos.Add(Total);
            campos.Add(Utilidad);
            campos.Add(idventa_factura);
            campos.Add(Descuento_iva);
            campos.Add(Codigo);
            campos.Add(Idsucursal_producto);
            campos.Add(Cantidad_paquete);

            return campos;
        }

        public string ingresarProducto()
        {
            base.cargarDatos(generarCampos(), generarValores(), "detalles_ventas_factura");
            return sentenciaIngresar();
        }

        public static DataTable detalle_proTic(string id)
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"select dvf.cantidad_paquete, 
                            dvf.idpresentacion_producto,
                            dvf.utilidad,
                            dvf.idsucursal_producto,
                            p.nombre_presentacion, 
                            dvf.cantidad,
                            pr.nom_producto,  
                            pp.precio, 
                            dvf.total, 
                            vf.numero_factura as correlativo,  
                            concat(cll.nombre_cliente,' ',cll.apellidos_cliente) as nombre,
                            cll.direccion, 
                            codi.codigo as cod_producto, 
                            dvf.descuento_iva
                            from ventas v, ventas_factura vf, detalles_ventas_factura dvf, presentaciones_productos pp, sucursales_productos sp, 
                            presentaciones p, productos pr, clientes cll, codigos codi, productos_codigos proco
                            where v.num_factura = vf.numero_factura
                            and proco.idproducto=pr.idproducto
                            and proco.idcodigo=codi.idcodigo
                            and dvf.idventa_factura = vf.numero_factura
                            and dvf.idpresentacion_producto = pp.idpresentacion_producto
                            and pp.idsucursal_producto = sp.idsucursal_producto
                            and sp.idproducto = pr.idproducto
                            and pp.idpresentacion = p.idpresentacion
                            and dvf.idventa_factura = '"+id+@"' 
                            and vf.idcliente=cll.idcliente 
                            and dvf.codigo=codi.codigo
                            and codi.estado=1                        
                            ; ";

            conexiones_BD.operaciones oOperacion = new conexiones_BD.operaciones();
            try
            {
                Datos = oOperacion.Consultar(Consulta);
            }
            catch
            {
                Datos = new DataTable();
            }

            return Datos;
        }
    }
}
