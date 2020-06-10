using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conexiones_BD.clases
{
    public class tarjetas:entidad
    {
        string idtarjeta, titular, fecha, resolucion, monto, idventa;

        public tarjetas(string idtarjeta, string titular, string fecha, string resolucion, string monto, string idventa)
        {
            this.Idtarjeta = idtarjeta;
            this.Titular = titular;
            this.Fecha = fecha;
            this.Resolucion = resolucion;
            this.Monto = monto;
            this.Idventa = idventa;
            cargarDatos(generarCampos(), generarValores(), "tarjetas");
        }

        public void cargarDatosNuevamente()
        {
            cargarDatos(generarCampos(), generarValores(), "tarjetas");
        }

        public override List<string> generarCampos()
        {
            List<string> campos = new List<string>();
            campos.Add("titular");
            campos.Add("fecha");
            campos.Add("resolucion");
            campos.Add("monto");
            campos.Add("idventa");

            return campos;
        }

        public override List<string> generarValores()
        {
            List<string> valores = new List<string>();
            valores.Add(this.titular);
            valores.Add(this.fecha);
            valores.Add(this.resolucion);
            valores.Add(this.monto);
            valores.Add(this.idventa);

            return valores;
        }

        public string Fecha
        {
            get
            {
                return fecha;
            }

            set
            {
                fecha = value;
            }
        }

        public string Idtarjeta
        {
            get
            {
                return idtarjeta;
            }

            set
            {
                idtarjeta = value;
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

        public string Monto
        {
            get
            {
                return monto;
            }

            set
            {
                monto = value;
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

        public string Titular
        {
            get
            {
                return titular;
            }

            set
            {
                titular = value;
            }
        }
    }
}
