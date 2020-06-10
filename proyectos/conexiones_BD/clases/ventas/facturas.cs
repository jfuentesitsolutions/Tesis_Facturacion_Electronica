using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conexiones_BD.clases.ventas
{
    public class facturas : ventas
    {
        string numero_factura, idforma_pago, idsucursal, fecha_expedicion, fecha_operacion, idtipo_factura, 
            idusuario, sub_total, descuento_total, descuento_iva, descuento_renta, moneda, idcliente, 
            total_ventas_exentas, total_ventas_sujetas, total, metodo_pago, version, resolucion, 
            lugar_expedicion, cantidad_letras, num_factura_numero, nom_per_entrega, nom_pre_recibe, 
            nit_per_entrega, nit_per_recibe, dui_per_entrega, dui_per_recibe, num_cheque, num_transaccion, idventa;

        public string Numero_factura
        {
            get
            {
                return numero_factura;
            }

            set
            {
                numero_factura = value;
            }
        }

        public string Idforma_pago
        {
            get
            {
                return idforma_pago;
            }

            set
            {
                idforma_pago = value;
            }
        }

        public string Idsucursal
        {
            get
            {
                return idsucursal;
            }

            set
            {
                idsucursal = value;
            }
        }

        public string Fecha_expedicion
        {
            get
            {
                return fecha_expedicion;
            }

            set
            {
                fecha_expedicion = value;
            }
        }

        public string Fecha_operacion
        {
            get
            {
                return fecha_operacion;
            }

            set
            {
                fecha_operacion = value;
            }
        }

        public string Idtipo_factura
        {
            get
            {
                return idtipo_factura;
            }

            set
            {
                idtipo_factura = value;
            }
        }

        public string Idusuario
        {
            get
            {
                return idusuario;
            }

            set
            {
                idusuario = value;
            }
        }

        public string Sub_total
        {
            get
            {
                return sub_total;
            }

            set
            {
                sub_total = value;
            }
        }

        public string Descuento_total
        {
            get
            {
                return descuento_total;
            }

            set
            {
                descuento_total = value;
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

        public string Descuento_renta
        {
            get
            {
                return descuento_renta;
            }

            set
            {
                descuento_renta = value;
            }
        }

        public string Moneda
        {
            get
            {
                return moneda;
            }

            set
            {
                moneda = value;
            }
        }

        public string Idcliente
        {
            get
            {
                return idcliente;
            }

            set
            {
                idcliente = value;
            }
        }

        public string Total_ventas_exentas
        {
            get
            {
                return total_ventas_exentas;
            }

            set
            {
                total_ventas_exentas = value;
            }
        }

        public string Total_ventas_sujetas
        {
            get
            {
                return total_ventas_sujetas;
            }

            set
            {
                total_ventas_sujetas = value;
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

        public string Metodo_pago
        {
            get
            {
                return metodo_pago;
            }

            set
            {
                metodo_pago = value;
            }
        }

        public string Version
        {
            get
            {
                return version;
            }

            set
            {
                version = value;
            }
        }

        public string Resolucion
        {
            get
            {
                return resolucion;
            }

            set
            {
                resolucion = value;
            }
        }

        public string Lugar_expedicion
        {
            get
            {
                return lugar_expedicion;
            }

            set
            {
                lugar_expedicion = value;
            }
        }

        public string Cantidad_letras
        {
            get
            {
                return cantidad_letras;
            }

            set
            {
                cantidad_letras = value;
            }
        }

        public string Num_factura_numero
        {
            get
            {
                return num_factura_numero;
            }

            set
            {
                num_factura_numero = value;
            }
        }

        public string Nom_per_entrega
        {
            get
            {
                return nom_per_entrega;
            }

            set
            {
                nom_per_entrega = value;
            }
        }

        public string Nom_pre_recibe
        {
            get
            {
                return nom_pre_recibe;
            }

            set
            {
                nom_pre_recibe = value;
            }
        }

        public string Nit_per_entrega
        {
            get
            {
                return nit_per_entrega;
            }

            set
            {
                nit_per_entrega = value;
            }
        }

        public string Nit_per_recibe
        {
            get
            {
                return nit_per_recibe;
            }

            set
            {
                nit_per_recibe = value;
            }
        }

        public string Dui_per_entrega
        {
            get
            {
                return dui_per_entrega;
            }

            set
            {
                dui_per_entrega = value;
            }
        }

        public string Dui_per_recibe
        {
            get
            {
                return dui_per_recibe;
            }

            set
            {
                dui_per_recibe = value;
            }
        }

        public string Num_cheque
        {
            get
            {
                return num_cheque;
            }

            set
            {
                num_cheque = value;
            }
        }

        public string Num_transaccion
        {
            get
            {
                return num_transaccion;
            }

            set
            {
                num_transaccion = value;
            }
        }

        public string Idventa
        {
            get
            {
                return idventa;
            }

            set
            {
                idventa = value;
            }
        }

        public facturas(string idventa, string idventa_factura, string idsucursal, string anulacion, string idcaja, 
            string numero_factura, string idforma_pago, string fecha_expedicion, string fecha_operacion,
            string idtipo_factura, string idusuario, string sub_total, string descuento_total, 
            string descuento_iva, string descuento_renta, string moneda, string idcliente, 
            string total_ventas_exentas, string total_ventas_sujetas, string total, string metodo_pago, 
            string version, string resolucion, string lugar_expedicion, string cantidad_letras, 
            string num_factura_numero, string nom_per_entrega, string nom_pre_recibe, string nit_per_entrega, 
            string nit_per_recibe, string dui_per_entrega, string dui_per_recibe, string num_cheque, string num_transaccion)
            : base(idventa, idventa_factura, fecha_expedicion, idsucursal, anulacion, idcaja)
        {
            this.idventa = idventa;
            this.Numero_factura = numero_factura;
            this.Idforma_pago = idforma_pago;
            this.Idsucursal = idsucursal;
            this.Fecha_expedicion = fecha_expedicion;
            this.Fecha_operacion = fecha_operacion;
            this.Idtipo_factura = idtipo_factura;
            this.Idusuario = idusuario;
            this.Sub_total = sub_total;
            this.Descuento_total = descuento_total;
            this.Descuento_iva = descuento_iva;
            this.Descuento_renta = descuento_renta;
            this.Moneda = moneda;
            this.Idcliente = idcliente;
            this.Total_ventas_exentas = total_ventas_exentas;
            this.Total_ventas_sujetas = total_ventas_sujetas;
            this.Total = total;
            this.Metodo_pago = metodo_pago;
            this.Version = version;
            this.Resolucion = resolucion;
            this.Lugar_expedicion = lugar_expedicion;
            this.Cantidad_letras = cantidad_letras;
            this.Num_factura_numero = num_factura_numero;
            this.Nom_per_entrega = nom_per_entrega;
            this.Nom_pre_recibe = nom_pre_recibe;
            this.Nit_per_entrega = nit_per_entrega;
            this.Nit_per_recibe = nit_per_recibe;
            this.Dui_per_entrega = dui_per_entrega;
            this.Dui_per_recibe = dui_per_recibe;
            this.Num_cheque = num_cheque;
            this.Num_transaccion = num_transaccion;
            base.cargarDatos(generarCampos(), generarValores(), "ventas_factura");
        }

        public void recargandoDatos()
        {
            base.cargarDatos(generarCampos(), generarValores(), "ventas_factura");
        }

        public facturas(string idventa, string anulado):base(idventa, anulado)
        {

        }

        public override List<string> generarCampos()
        {
            List<string> campos = new List<string>();
            campos.Add("numero_factura");
            campos.Add("idforma_pago");
            campos.Add("idsucursal");
            campos.Add("fecha_expedicion");
            campos.Add("fecha_operacion");
            campos.Add("idtipo_factura");
            campos.Add("idusuario");
            campos.Add("sub_total");
            campos.Add("descuento_total");
            campos.Add("descuento_iva");
            campos.Add("descuento_renta");
            campos.Add("moneda");
            campos.Add("idcliente");
            campos.Add("total_ventas_exentas");
            campos.Add("total_ventas_sujetas");
            campos.Add("total");
            campos.Add("metodo_pago");
            campos.Add("version");
            campos.Add("resolucion");
            campos.Add("lugar_expedicion");
            campos.Add("cantidad_letras");
            campos.Add("num_factura_numero");
            campos.Add("nom_per_entrega");
            campos.Add("nom_pre_recibe");
            campos.Add("nit_per_entrega");
            campos.Add("nit_per_recibe");
            campos.Add("dui_per_entrega");
            campos.Add("dui_per_recibe");
            campos.Add("num_cheque");
            campos.Add("num_transaccion");

            return campos;
        }

        public override List<string> generarValores()
        {
            List<string> valores = new List<string>();
            valores.Add(this.Numero_factura);
            valores.Add(this.Idforma_pago);
            valores.Add(this.Idsucursal);
            valores.Add(this.Fecha_expedicion);
            valores.Add(this.Fecha_operacion);
            valores.Add(this.Idtipo_factura);
            valores.Add(this.Idusuario);
            valores.Add(this.Sub_total);
            valores.Add(this.Descuento_total);
            valores.Add(this.Descuento_iva);
            valores.Add(this.Descuento_renta);
            valores.Add(this.Moneda);
            valores.Add(this.Idcliente);
            valores.Add(this.Total_ventas_exentas);
            valores.Add(this.Total_ventas_sujetas);
            valores.Add(this.Total);
            valores.Add(this.Metodo_pago);
            valores.Add(this.Version);
            valores.Add(this.Resolucion);
            valores.Add(this.Lugar_expedicion);
            valores.Add(this.Cantidad_letras);
            valores.Add(this.Num_factura_numero);
            valores.Add(this.Nom_per_entrega);
            valores.Add(this.Nom_pre_recibe);
            valores.Add(this.Nit_per_entrega);
            valores.Add(this.Nit_per_recibe);
            valores.Add(this.Dui_per_entrega);
            valores.Add(this.Dui_per_recibe);
            valores.Add(this.Num_cheque);
            valores.Add(this.Num_transaccion);

            return valores;
        }

        public override List<string> campos()
        {
            List<string> campos = new List<string>();
            campos.Add("idventa");
            campos.Add("num_factura");
            campos.Add("fecha");
            campos.Add("idsucursal");
            campos.Add("anulacion");
            campos.Add("idcaja");

            return campos;
        }

        public override List<string> valores()
        {
            List<string> valores = new List<string>();
            valores.Add(Idventa);
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
            Consulta = @"select vf.numero_factura as correlativo, vf.fecha_expedicion as fecha, concat(c.nombre_cliente,' ',c.apellidos_cliente) as nombre, v.idventa
                        , vf.idcliente, vf.idtipo_factura, vf.idusuario, vf.idforma_pago, vf.num_factura_numero, vf.*
                        from ventas v, ventas_factura vf, clientes c
                        where v.num_factura = vf.numero_factura and vf.idcliente = c.idcliente
                        and v.fecha>='" + fech + @" 00:00:00' and v.fecha<='" + fech + @" 23:59:59' and v.idsucursal='5'
                        and v.anulacion = 1 order by vf.fecha_expedicion desc
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
