using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace conexiones_BD.clases.ventas
{
    public class tickets:ventas
    {
        string idforma_pago, correlativo, idusuario, monto_total_neto, descuentos, monto_total, idc, efectivo,
            cambio, idcliente, idcorrelativo;

        public string Correlativo
        {
            get
            {
                return correlativo;
            }

            set
            {
                correlativo = value;
            }
        }

        public tickets(string idventa, string idventa_ticket, string fecha, string idsucursal, string anulacion,
            string idforma_pago, string correlativo, string idusuario, string monto_total_neto, string descuentos,
            string monto_total, string idcita, string efectivo, string cambio, string idclien, string idcor, string idcaja
            )
            : base(idventa,idventa_ticket, fecha, idsucursal, anulacion, idcaja)
        {
            this.idforma_pago = idforma_pago;
            this.Correlativo = correlativo;
            this.idusuario = idusuario;
            this.monto_total_neto = monto_total_neto;
            this.descuentos = descuentos;
            this.monto_total = monto_total;
            this.idc = idcita;
            this.efectivo = efectivo;
            this.cambio = cambio;
            this.idcliente = idclien;
            this.idcorrelativo = idcor;
            base.cargarDatos(generarCampos(), generarValores(), "ventas_tickets");
        }


        public tickets(string idventa, string anulado):base(idventa,anulado)
        {
        }

        public override List<string> generarCampos()
        {
            List<string> campos = new List<string>();
            campos.Add("correlativo");
            campos.Add("idforma_pago");
            campos.Add("idsucursal");
            campos.Add("fecha");
            campos.Add("idusuario");
            campos.Add("monto_total_neto");
            campos.Add("descuentos");
            campos.Add("monto_total");
            campos.Add("idcita");
            campos.Add("efectivo");
            campos.Add("cambio");
            campos.Add("idcliente");
            campos.Add("idcorrelativo");

            return campos;
        }

        public override List<string> generarValores()
        {
            List<string> valores = new List<string>();
            valores.Add(this.Correlativo);
            valores.Add(this.idforma_pago);
            valores.Add(base.idsucursal);
            valores.Add(base.fecha);
            valores.Add(this.idusuario);
            valores.Add(this.monto_total_neto);
            valores.Add(this.descuentos);
            valores.Add(this.monto_total);
            valores.Add(this.idc);
            valores.Add(this.efectivo);
            valores.Add(this.cambio);
            valores.Add(this.idcliente);
            valores.Add(this.idcorrelativo);

            return valores;
        }

        public override List<string> campos()
        {
            List<string> campos = new List<string>();
            campos.Add("idventa");
            campos.Add("num_ticket");
            campos.Add("fecha");
            campos.Add("idsucursal");
            campos.Add("anulacion");
            campos.Add("idcaja");

            return campos;
        }

        public override List<string> valores()
        {
            List<string> valores = new List<string>();
            valores.Add(correlativo);
            valores.Add(base.idDocu);
            valores.Add(base.fecha);
            valores.Add(base.idsucursal);
            valores.Add(base.Anulacion);
            valores.Add(base.idcaja);

            return valores;
        }

        public static DataTable datosTabla(string fech, string idsu)
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"select vt.correlativo, vt.fecha, concat(c.nombre_cliente,' ',c.apellidos_cliente) as nombre, v.idventa
                from ventas v, ventas_tickets vt, clientes c
                where v.idventa = vt.correlativo and vt.idcliente = c.idcliente
                and v.fecha>='" + fech+@" 00:00:00' and v.fecha<='"+fech+ @" 23:59:59' and v.idsucursal='" + idsu + @"'
                and v.anulacion = 1 order by vt.fecha desc
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
