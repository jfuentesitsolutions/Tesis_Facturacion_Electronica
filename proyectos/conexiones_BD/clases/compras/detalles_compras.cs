using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conexiones_BD.clases.compras
{
    public class detalles_compras:entidad
    {
        string iddetalle_compra, idsucursal_producto, cantidad, precio_compra_m, precio_compra_d, total, porcentaje_utilidad_M, porcentaje_utilidad_D, idfactura_compra, idutilidadMayoreo, idutilidadDetalle, precio_venta_m, precio_venta_d, cantidad_paquete, presentacion_producto;

        public detalles_compras(string idsucursal_producto, 
            string cantidad, string precio_compra_m, string precio_compra_d, string total, 
            string porcentaje_utilidad_M, string porcentaje_utilidad_D, string idfactura_compra, 
            string idutilidadMayoreo, string idutilidadDetalle, string precio_venta_m, string precio_venta_d,
            string cantidad_paquete, string presentacion_producto)
        {
            this.idsucursal_producto = idsucursal_producto;
            this.cantidad = cantidad;
            this.precio_compra_m = precio_compra_m;
            this.precio_compra_d = precio_compra_d;
            this.total = total;
            this.porcentaje_utilidad_M = porcentaje_utilidad_M;
            this.porcentaje_utilidad_D = porcentaje_utilidad_D;
            this.Idfactura_compra = idfactura_compra;
            this.idutilidadMayoreo = idutilidadMayoreo;
            this.idutilidadDetalle = idutilidadDetalle;
            this.precio_venta_m = precio_venta_m;
            this.precio_venta_d = precio_venta_d;
            this.cantidad_paquete = cantidad_paquete;
            this.presentacion_producto = presentacion_producto;
            base.cargarDatos(generarCampos(), generarValores(), "detalles_compras");
        }

        public string Idfactura_compra
        {
            get
            {
                return idfactura_compra;
            }

            set
            {
                idfactura_compra = value;
            }
        }

        public override List<string> generarCampos()
        {
            List<string> campos = new List<string>();
            campos.Add("idsucursal_producto");
            campos.Add("cantidad");
            campos.Add("precio_compra_m");
            campos.Add("precio_compra_d");
            campos.Add("total");
            campos.Add("porcentaje_utilidad_M");
            campos.Add("porcentaje_utilidad_D");
            campos.Add("idfactura_compra");
            campos.Add("idutilidadMayoreo");
            campos.Add("idutilidadDetalle");
            campos.Add("precio_venta_m");
            campos.Add("precio_venta_d");
            campos.Add("cantidad_paquete");
            campos.Add("presentacion_producto");

            return campos;
        }

        public override List<string> generarValores()
        {
            List<string> valores = new List<string>();
            valores.Add(idsucursal_producto);
            valores.Add(cantidad);
            valores.Add(precio_compra_m);
            valores.Add(precio_compra_d);
            valores.Add(total);
            valores.Add(porcentaje_utilidad_M);
            valores.Add(porcentaje_utilidad_D);
            valores.Add(Idfactura_compra);
            valores.Add(idutilidadMayoreo);
            valores.Add(idutilidadDetalle);
            valores.Add(precio_venta_m);
            valores.Add(precio_venta_d);
            valores.Add(cantidad_paquete);
            valores.Add(presentacion_producto);

            return valores;
        }

        public string ingresarDetalleCompra()
        {
            base.cargarDatos(generarCampos(), generarValores(), "detalles_compras");
            return sentenciaIngresar();
        }
    }
}
