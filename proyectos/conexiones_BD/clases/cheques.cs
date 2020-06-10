using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conexiones_BD.clases
{
    public class cheques:entidad
    {
        string idcheque, numero_cheque, lugar, fecha, monto, valor_letras, idventa;

        public cheques(string idcheque, string numero_cheque, string lugar, string fecha, string monto, string valor_letras, string idventa)
        {
            this.idcheque = idcheque;
            this.numero_cheque = numero_cheque;
            this.lugar = lugar;
            this.fecha = fecha;
            this.monto = monto;
            this.valor_letras = valor_letras;
            this.idventa = idventa;
            cargarDatos(generarCampos(), generarValores(), "cheques");
        }

        public void cargarDatosNuevamente()
        {
            cargarDatos(generarCampos(), generarValores(), "cheques");
        }

        public override List<string> generarCampos()
        {
            List<string> campos = new List<string>();
            campos.Add("numero_cheque");
            campos.Add("lugar");
            campos.Add("fecha");
            campos.Add("monto");
            campos.Add("valor_letras");
            campos.Add("idventa");

            return campos;
        }

        public override List<string> generarValores()
        {
            List<string> valores = new List<string>();
            valores.Add(this.numero_cheque);
            valores.Add(this.lugar);
            valores.Add(this.fecha);
            valores.Add(this.monto);
            valores.Add(this.valor_letras);
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

        public string Idcheque
        {
            get
            {
                return idcheque;
            }

            set
            {
                idcheque = value;
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

        public string Lugar
        {
            get
            {
                return lugar;
            }

            set
            {
                lugar = value;
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

        public string Numero_cheque
        {
            get
            {
                return numero_cheque;
            }

            set
            {
                numero_cheque = value;
            }
        }

        public string Valor_letras
        {
            get
            {
                return valor_letras;
            }

            set
            {
                valor_letras = value;
            }
        }
    }
}
