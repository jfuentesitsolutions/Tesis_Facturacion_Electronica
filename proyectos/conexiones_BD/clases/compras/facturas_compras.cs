using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conexiones_BD.clases.compras
{
    public class facturas_compras:entidad
    {
        string idfactura_compra, numero_factura, idtipofactura, idusuario, 
        monto_total_neto, descuento_iva, descuento_renta, monto_total, fecha_factura, idproveedor;

        public facturas_compras(string numero_factura, string idtipofactura, string idusuario, string monto_total_neto, string descuento_iva, string descuento_renta, string monto_total, string fecha_factura, string idproveedor)
        {
            this.numero_factura = numero_factura;
            this.idtipofactura = idtipofactura;
            this.idusuario = idusuario;
            this.monto_total_neto = monto_total_neto;
            this.descuento_iva = descuento_iva;
            this.descuento_renta = descuento_renta;
            this.monto_total = monto_total;
            this.fecha_factura = fecha_factura;
            this.idproveedor = idproveedor;
            base.cargarDatos(generarCampos(), generarValores(), "facturas_compras");
        }

        public override List<string> generarCampos()
        {
            List<string> campos = new List<string>();
            campos.Add("numero_factura");
            campos.Add("idtipofactura");
            campos.Add("idusuario");
            campos.Add("monto_total_neto");
            campos.Add("descuento_iva");
            campos.Add("descuento_renta");
            campos.Add("monto_total");
            campos.Add("fecha_factura");
            campos.Add("idproveedor");

            return campos;
        }

        public override List<string> generarValores()
        {
            List<string> valores = new List<string>();
            valores.Add(numero_factura);
            valores.Add(idtipofactura);
            valores.Add(idusuario);
            valores.Add(monto_total_neto);
            valores.Add(descuento_iva);
            valores.Add(descuento_renta);
            valores.Add(monto_total);
            valores.Add(fecha_factura);
            valores.Add(idproveedor);

            return valores;
        }
    }

    
}
