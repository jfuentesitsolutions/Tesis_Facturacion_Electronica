using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conexiones_BD
{
    public class farmacias
    {
        public static DataTable datos_productos_farmacia(string idcaja)
        {
            operaciones op = new operaciones();
            try
            {
                return op.Consultar(@"select p.nom_producto, sum(dvt.cantidad) as cantidad, sum(dvt.total) as total,
sp.idsucursal_producto as suc_pro
from detalles_ventas_ticket dvt, ventas_tickets vt, ventas v,
presentaciones_productos pp,
sucursales_productos sp, productos p
where dvt.idventa_ticket = vt.correlativo
and vt.correlativo = v.num_ticket
and dvt.idpresentacion_producto = pp.idpresentacion_producto
and pp.idsucursal_producto = sp.idsucursal_producto
and sp.idproducto = p.idproducto and p.idcategoria = 61 and v.idcaja = "+idcaja+ @"
group by p.nom_producto
union
select p.nom_producto, sum(dvf.cantidad) as cantidad, sum(dvf.total) as total,
sp.idsucursal_producto as suc_pro
from detalles_ventas_factura dvf, ventas_factura vf, ventas v,
presentaciones_productos pp,
sucursales_productos sp, productos p
where dvf.idventa_factura = vf.numero_factura
and vf.numero_factura = v.num_factura
and dvf.idpresentacion_producto = pp.idpresentacion_producto
and pp.idsucursal_producto = sp.idsucursal_producto
and sp.idproducto = p.idproducto and p.idcategoria = 61 and v.idcaja = " + idcaja + @"
group by p.nom_producto
; ");
            }
            catch
            {
                return new DataTable();
            }
        }

        public static DataTable datos_productos_farmacia_periodo(string fechai, string fechaf)
        {
            operaciones op = new operaciones();
            try
            {
                return op.Consultar(@"select p.nom_producto, sum(dvt.cantidad) as cantidad, sum(dvt.total) as total,
sp.idsucursal_producto as suc_pro
from detalles_ventas_ticket dvt, ventas_tickets vt, ventas v, 
presentaciones_productos pp,
sucursales_productos sp, productos p
where dvt.idventa_ticket=vt.correlativo
and vt.correlativo=v.num_ticket
and dvt.idpresentacion_producto=pp.idpresentacion_producto
and pp.idsucursal_producto=sp.idsucursal_producto
and sp.idproducto=p.idproducto 
and p.idcategoria=61 
and vt.fecha between '"+fechai+@" 00:00:00' and '"+fechaf+@" 23:59:59'
group by p.nom_producto
union
select p.nom_producto, sum(dvf.cantidad) as cantidad, sum(dvf.total) as total,
sp.idsucursal_producto as suc_pro
from detalles_ventas_factura dvf, ventas_factura vf, ventas v,
presentaciones_productos pp,
sucursales_productos sp, productos p
where dvf.idventa_factura = vf.numero_factura
and vf.numero_factura = v.num_factura
and dvf.idpresentacion_producto = pp.idpresentacion_producto
and pp.idsucursal_producto = sp.idsucursal_producto
and sp.idproducto = p.idproducto
and p.idcategoria = 61
and vf.fecha between '"+fechai+@" 00:00:00' and '"+fechaf+@" 23:59:59'
group by p.nom_producto
;
                ");
            }
            catch
            {
                return new DataTable();
            }
        }

        public static DataTable datos_productos_id(string idcaja, string idsu)
        {
            operaciones op = new operaciones();
            try
            {
                return op.Consultar(@"select vt.fecha, dvt.idventa_ticket as docu, p.nom_producto, dvt.cantidad_paquete as cant,
concat(pre.nombre_presentacion, 'x', pp.cantidad_unidades) as pre, dvt.precio_venta as preci, dvt.total
from detalles_ventas_ticket dvt, ventas_tickets vt, ventas v,
presentaciones_productos pp, presentaciones pre,
sucursales_productos sp, productos p
where dvt.idventa_ticket = vt.correlativo
and vt.correlativo = v.num_ticket
and dvt.idpresentacion_producto = pp.idpresentacion_producto
and pp.idpresentacion = pre.idpresentacion
and pp.idsucursal_producto = sp.idsucursal_producto
and sp.idproducto = p.idproducto and p.idcategoria = 61 and v.idcaja = "+idcaja+@" and sp.idsucursal_producto = "+idsu+@"
union
select vf.fecha, dvf.idventa_factura as docu, p.nom_producto, dvf.cantidad as canti,
concat(pre.nombre_presentacion, 'x', pp.cantidad_unidades) as pre, dvf.precio_venta as preci, dvf.total
from detalles_ventas_factura dvf, ventas_factura vf, ventas v,
presentaciones_productos pp, presentaciones pre,
sucursales_productos sp, productos p
where dvf.idventa_factura = vf.numero_factura
and vf.numero_factura = v.num_factura
and dvf.idpresentacion_producto = pp.idpresentacion_producto
and pp.idpresentacion = pre.idpresentacion
and pp.idsucursal_producto = sp.idsucursal_producto
and sp.idproducto = p.idproducto and p.idcategoria = 61 and v.idcaja = "+idcaja+@" and sp.idsucursal_producto = "+idsu+@"
; ");
            }
            catch
            {
                return new DataTable();
            }
        }

        public static DataTable datos_productos_id_periodo(string fechai, string fechaf, string idsu)
        {
            operaciones op = new operaciones();
            try
            {
                return op.Consultar(@"select vt.fecha, dvt.idventa_ticket as docu, p.nom_producto, dvt.cantidad_paquete as cant,
concat(pre.nombre_presentacion,'x',pp.cantidad_unidades)  as pre, dvt.precio_venta as preci, dvt.total
from detalles_ventas_ticket dvt, ventas_tickets vt, ventas v,
presentaciones_productos pp, presentaciones pre,
sucursales_productos sp, productos p
where dvt.idventa_ticket = vt.correlativo
and vt.correlativo = v.num_ticket
and dvt.idpresentacion_producto = pp.idpresentacion_producto
and pp.idpresentacion = pre.idpresentacion
and pp.idsucursal_producto = sp.idsucursal_producto
and sp.idproducto = p.idproducto and p.idcategoria = 61
and vt.fecha between '"+fechai+@" 00:00:00' and '"+fechaf+@" 23:59:59'
and sp.idsucursal_producto = "+idsu+@"
union
select vf.fecha, dvf.idventa_factura as docu, p.nom_producto, dvf.cantidad as canti,
concat(pre.nombre_presentacion, 'x', pp.cantidad_unidades) as pre, dvf.precio_venta as preci, dvf.total
from detalles_ventas_factura dvf, ventas_factura vf, ventas v,
presentaciones_productos pp, presentaciones pre,
sucursales_productos sp, productos p
where dvf.idventa_factura = vf.numero_factura
and vf.numero_factura = v.num_factura
and dvf.idpresentacion_producto = pp.idpresentacion_producto
and pp.idpresentacion = pre.idpresentacion
and pp.idsucursal_producto = sp.idsucursal_producto
and sp.idproducto = p.idproducto and p.idcategoria = 61
and vf.fecha between '"+fechai+@" 00:00:00' and '"+fechaf+@" 23:59:59'
and sp.idsucursal_producto = "+idsu+@"
; ");
            }
            catch
            {
                return new DataTable();
            }
        }

        public static DataTable todos_datos_productos_id(string idcaja)
        {
            operaciones op = new operaciones();
            try
            {
                return op.Consultar(@"select vt.fecha, dvt.idventa_ticket as docu, p.nom_producto, dvt.cantidad_paquete as cant,
concat(pre.nombre_presentacion, 'x', pp.cantidad_unidades) as pre, dvt.precio_venta as preci, dvt.total, dvt.cantidad
from detalles_ventas_ticket dvt, ventas_tickets vt, ventas v,
presentaciones_productos pp, presentaciones pre,
sucursales_productos sp, productos p
where dvt.idventa_ticket = vt.correlativo
and vt.correlativo = v.num_ticket
and dvt.idpresentacion_producto = pp.idpresentacion_producto
and pp.idpresentacion = pre.idpresentacion
and pp.idsucursal_producto = sp.idsucursal_producto
and sp.idproducto = p.idproducto and p.idcategoria = 61 and v.idcaja = " + idcaja + @"
union
select vf.fecha, dvf.idventa_factura as docu, p.nom_producto, dvf.cantidad as canti,
concat(pre.nombre_presentacion, 'x', pp.cantidad_unidades) as pre, dvf.precio_venta as preci, dvf.total, dvf.cantidad
from detalles_ventas_factura dvf, ventas_factura vf, ventas v,
presentaciones_productos pp, presentaciones pre,
sucursales_productos sp, productos p
where dvf.idventa_factura = vf.numero_factura
and vf.numero_factura = v.num_factura
and dvf.idpresentacion_producto = pp.idpresentacion_producto
and pp.idpresentacion = pre.idpresentacion
and pp.idsucursal_producto = sp.idsucursal_producto
and sp.idproducto = p.idproducto and p.idcategoria = 61 and v.idcaja = " + idcaja + @"
; ");
            }
            catch
            {
                return new DataTable();
            }
        }

        public static DataTable todos_datos_productos_id_periodo(string fechai, string fechaf)
        {
            operaciones op = new operaciones();
            try
            {
                return op.Consultar(@"select vt.fecha, dvt.idventa_ticket as docu, p.nom_producto, dvt.cantidad_paquete as cant,
concat(pre.nombre_presentacion,'x',pp.cantidad_unidades)  as pre, dvt.precio_venta as preci, dvt.total, dvt.cantidad
from detalles_ventas_ticket dvt, ventas_tickets vt, ventas v,
presentaciones_productos pp, presentaciones pre,
sucursales_productos sp, productos p
where dvt.idventa_ticket = vt.correlativo
and vt.correlativo = v.num_ticket
and dvt.idpresentacion_producto = pp.idpresentacion_producto
and pp.idpresentacion = pre.idpresentacion
and pp.idsucursal_producto = sp.idsucursal_producto
and sp.idproducto = p.idproducto and p.idcategoria = 61
and vt.fecha between '" + fechai + @" 00:00:00' and '" + fechaf + @" 23:59:59'
union
select vf.fecha, dvf.idventa_factura as docu, p.nom_producto, dvf.cantidad as canti,
concat(pre.nombre_presentacion, 'x', pp.cantidad_unidades) as pre, dvf.precio_venta as preci, dvf.total, dvf.cantidad
from detalles_ventas_factura dvf, ventas_factura vf, ventas v,
presentaciones_productos pp, presentaciones pre,
sucursales_productos sp, productos p
where dvf.idventa_factura = vf.numero_factura
and vf.numero_factura = v.num_factura
and dvf.idpresentacion_producto = pp.idpresentacion_producto
and pp.idpresentacion = pre.idpresentacion
and pp.idsucursal_producto = sp.idsucursal_producto
and sp.idproducto = p.idproducto and p.idcategoria = 61
and vf.fecha between '" + fechai + @" 00:00:00' and '" + fechaf + @" 23:59:59'
; ");
            }
            catch
            {
                return new DataTable();
            }
        }

    }
}
