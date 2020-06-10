using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace conexiones_BD.clases.compras
{
    public class compras:entidad
    {
        string idcompra, idfactura, idsucursal, fecha_ingreso, anulacion, idcaja;

        public compras(string idfactura, string idsucursal, string fecha_ingreso, string anulacion,string idc)
        {
            this.Idfactura = idfactura;
            this.idsucursal = idsucursal;
            this.fecha_ingreso = fecha_ingreso;
            this.anulacion = anulacion;
            this.idcaja = idc;
            base.cargarDatos(generarCampos(), generarValores(), "compras");
        }

        public compras(string idcom, string anulacion)
        {
            this.idcompra = idcom;
            this.anulacion = anulacion;
        }
            
        public string Idfactura
        {
            get
            {
                return idfactura;
            }

            set
            {
                idfactura = value;
            }
        }

        public override List<string> generarCampos()
        {
            List<string> campos = new List<string>();
            campos.Add("idfactura");
            campos.Add("idsucursal");
            campos.Add("fecha_ingreso");
            campos.Add("anulacion");
            campos.Add("idcaja");

            return campos;
        }

        public override List<string> generarValores()
        {
            List<string> valores = new List<string>();
            valores.Add(Idfactura);
            valores.Add(idsucursal);
            valores.Add(fecha_ingreso);
            valores.Add(anulacion);
            valores.Add(idcaja);

            return valores;
        }

        public string ingresarProducto()
        {
            base.cargarDatos(generarCampos(), generarValores(), "compras");
            return sentenciaIngresar();
        }

        public static DataTable factura_ingresadas(string fecha)
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"select fc.numero_factura
                        from compras c, facturas_compras fc
                        where c.idfactura = fc.idfactura_compra and c.anulacion = 1
                        and c.fecha_ingreso >= '"+fecha+@" 00:00:00' and c.fecha_ingreso <= '"+fecha+@" 23:60:00'
                        ; ";
            operaciones oOperacion = new operaciones();
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

        public static DataTable facturas_ingresadas_sin_anular(string idsucursal, string num_fac)
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"select c.fecha_ingreso, fc.numero_factura, tf.nombre, u.usuario, p.nombre_proveedor, fc.monto_total_neto,
                    fc.descuento_iva, fc.monto_total, prese.nombre_presentacion, pp.nom_producto, dt.cantidad, dt.cantidad_paquete,
                    dt.precio_compra_m, dt.precio_compra_d, sp.idsucursal_producto, s.numero_de_sucursal, dt.total, sp.existencias, c.idcompra
                    from compras c, facturas_compras fc, detalles_compras dt, tipos_facturas tf, usuarios u,
                    proveedores p, sucursales_productos sp, productos pp, presentaciones_productos prp, presentaciones prese,
                    sucursales s
                    where c.idfactura=fc.idfactura_compra and dt.idfactura_compra=fc.idfactura_compra
                    and fc.idtipofactura=tf.idtipo_factura and fc.idusuario=u.idusuario
                    and fc.idproveedor=p.idproveedor and dt.idsucursal_producto=sp.idsucursal_producto
                    and sp.idproducto=pp.idproducto and dt.presentacion_producto=prp.idpresentacion_producto
                    and prp.idpresentacion=prese.idpresentacion and c.idsucursal=s.idsucursal
                    and c.anulacion=1 and fc.numero_factura='" + num_fac+@"' and c.idsucursal='"+idsucursal+@"'
                    ;";
            operaciones oOperacion = new operaciones();
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

        public StringBuilder sentenciaModificaAnulacion()
        {
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("UPDATE compras SET anulacion='" + anulacion + "' WHERE idcompra='" + idcompra + "';");
            return sentencia;
        }

    }
}
