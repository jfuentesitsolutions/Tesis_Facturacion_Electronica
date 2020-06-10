using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace conexiones_BD.clases.ventas
{
    public class detalles_productos_venta_ticket:entidad
    {
        string iddetalle_ventas_ticket, idpresentacion_producto, cantidad, 
            precio_venta, total, utilidad, idventa_ticket, idsucursal_producto,
            cantidad_paquete, codigo;

        public detalles_productos_venta_ticket(string iddetalle_ventas_ticket, string idpresentacion_producto, string cantidad, string precio_venta, string total, string utilidad, string idventa_ticket, string idsuc, string capa, string cod)
        {
            this.iddetalle_ventas_ticket = iddetalle_ventas_ticket;
            this.idpresentacion_producto = idpresentacion_producto;
            this.cantidad = cantidad;
            this.precio_venta = precio_venta;
            this.total = total;
            this.utilidad = utilidad;
            this.Idventa_ticket = idventa_ticket;
            this.idsucursal_producto = idsuc;
            this.cantidad_paquete = capa;
            this.codigo = cod;
        }

        public string Idventa_ticket
        {
            get
            {
                return idventa_ticket;
            }

            set
            {
                idventa_ticket = value;
            }
        }

        public override List<string> generarCampos()
        {
            List<string> campos = new List<string>();
            campos.Add("idpresentacion_producto");
            campos.Add("cantidad");
            campos.Add("precio_venta");
            campos.Add("total");
            campos.Add("utilidad");
            campos.Add("idventa_ticket");
            campos.Add("idsucursal_producto");
            campos.Add("cantidad_paquete");
            campos.Add("codigo");

            return campos;
        }

        public override List<string> generarValores()
        {
            List<string> campos = new List<string>();
            campos.Add(idpresentacion_producto);
            campos.Add(cantidad);
            campos.Add(precio_venta);
            campos.Add(total);
            campos.Add(utilidad);
            campos.Add(idventa_ticket);
            campos.Add(idsucursal_producto);
            campos.Add(cantidad_paquete);
            campos.Add(codigo);

            return campos;
        }

        public string ingresarProducto()
        {
            base.cargarDatos(generarCampos(), generarValores(), "detalles_ventas_ticket");
            return sentenciaIngresar();
        }

        public static DataTable detalle_proTic(string id)
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"select dvt.cantidad_paquete, p.nombre_presentacion, 
                        pr.nom_producto,  pp.precio, dvt.total, vt.fecha, vt.correlativo, vt.monto_total_neto, 
                        vt.efectivo, vt.cambio, ci.contenido, concat(cll.nombre_cliente,' ',cll.apellidos_cliente) as nombre,
                        cll.direccion, corr.inicio, corr.final, vt.idcorrelativo, codi.codigo as cod_producto, sp.kardex
                        from ventas v, ventas_tickets vt, detalles_ventas_ticket dvt, presentaciones_productos pp, sucursales_productos sp, 
                        presentaciones p, productos pr, citas ci, clientes cll, correlativos_ticket corr, codigos codi, productos_codigos proco
                        where v.idventa = vt.correlativo
                        and proco.idproducto=pr.idproducto
                        and proco.idcodigo=codi.idcodigo
                        and dvt.idventa_ticket = vt.correlativo
                        and dvt.idpresentacion_producto = pp.idpresentacion_producto
                        and pp.idsucursal_producto = sp.idsucursal_producto
                        and sp.idproducto = pr.idproducto
                        and pp.idpresentacion = p.idpresentacion
                        and dvt.idventa_ticket = '"+id+ @"' and vt.idcita=ci.idcita and vt.idcliente=cll.idcliente and vt.idcorrelativo = corr.idcorrelativo_ticket
                        and dvt.codigo=codi.codigo
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
