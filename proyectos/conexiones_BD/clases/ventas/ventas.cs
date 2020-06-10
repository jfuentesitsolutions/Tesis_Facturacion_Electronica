using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace conexiones_BD.clases.ventas
{
    public abstract class ventas: entidad
    {
        protected string idventa, idDocu, fecha, idsucursal, idcaja;
        private string anulacion;

        public ventas(string idventa, string anula)
        {
            this.idventa = idventa;
            this.anulacion = anula;
        }

        public ventas(string idventa, string idventa_ticket, string fecha, string idsucursal, string anulacion, string idca)
        {
            this.idventa = idventa;
            this.IdDocu = idventa_ticket; // este es el correlativo
            this.fecha = fecha;
            this.idsucursal = idsucursal;
            this.Anulacion = anulacion;
            this.idcaja = idca; 
        }

        public string IdDocu
        {
            get
            {
                return idDocu;
            }

            set
            {
                idDocu = value;
            }
        }

        protected string Anulacion
        {
            get
            {
                return anulacion;
            }

            set
            {
                anulacion = value;
            }
        }

        public abstract List<string> campos();

        public abstract List<string> valores();

        public string insertarVenta()
        {
            base.cargarDatos(campos(), valores(), "ventas");
            return base.sentenciaIngresar();
        }

        public static DataTable ventas_diarias(string fecha, string idsu)
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"select concat(v.fecha) as ticket, vt.correlativo, vt.fecha, vt.monto_total
                from ventas v, ventas_tickets vt
                where v.num_ticket = vt.correlativo and v.fecha >= '"+fecha+@" 00:00:00' and v.fecha <= '"+fecha+ @" 23:59:59' and v.idsucursal='"+idsu+@"' and v.anulacion=1
                union
                select concat(v.fecha) as ticket, vf.numero_factura, vf.fecha, vf.monto_total
                 from ventas v, ventas_factura vf
                 where v.num_factura = vf.numero_factura and v.fecha >= '" + fecha+" 00:00:00' and v.fecha <= '"+fecha+ @" 23:59:59' and v.idsucursal='" + idsu + @"'and v.anulacion=1
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

        public static DataTable anulacion_ticket(string idventa)
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"select vt.correlativo, v.fecha, concat(c.nombre_cliente,' ',c.apellidos_cliente) as nom, p.nom_producto, pre.nombre_presentacion,
                        dvt.cantidad_paquete, dvt.precio_venta, dvt.total, vt.monto_total_neto, vt.efectivo, vt.cambio, u.usuario, fp.nombre_pago
                        from ventas v, ventas_tickets vt, detalles_ventas_ticket dvt, sucursales_productos sp, presentaciones_productos pp,
                        clientes c, productos p, presentaciones pre, usuarios u, formas_pagos fp
                        where v.num_ticket = vt.correlativo
                        and vt.idcliente = c.idcliente
                        and dvt.idventa_ticket = vt.correlativo
                        and vt.idusuario = u.idusuario
                        and vt.idforma_pago = fp.idforma_pago
                        and dvt.idsucursal_producto = sp.idsucursal_producto
                        and dvt.idpresentacion_producto = pp.idpresentacion_producto
                        and sp.idproducto = p.idproducto
                        and pp.idpresentacion = pre.idpresentacion
                        and v.idventa = '"+idventa+@"'
                        ;
            ";
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

        public StringBuilder sentenciaModificaAnulacion()
        {
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("UPDATE ventas SET anulacion='" + Anulacion + "' WHERE idventa='" + idventa + "';");
            return sentencia;   
        }



    }
}
