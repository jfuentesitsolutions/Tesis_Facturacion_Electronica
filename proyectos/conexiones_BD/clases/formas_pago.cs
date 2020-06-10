using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace conexiones_BD.clases
{
    public class formas_pago:entidad
    {
        string idforma_pago, nombre_pago;

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

        public formas_pago()
        {

        }

        public formas_pago(string idforma_pago, string nombre_pago)
        {
            this.Idforma_pago = idforma_pago;
            this.nombre_pago = nombre_pago;
            base.cargarDatosModificados(generarCampos(), generarValores(), "formas_pagos", idforma_pago, "idforma_pago");
        }

        public formas_pago(string nombre_pago)
        {
            this.nombre_pago = nombre_pago;
            base.cargarDatos(generarCampos(), generarValores(), "formas_pagos");
        }

        public void cargarParaEliminar()
        {
            base.cargarDatosEliminados("formas_pagos", Idforma_pago, "idforma_pago");
        }

        public formas_pago(List<string> campos, List<string> valores)
        {
            base.busquedaDatos(campos, valores, "formas_pagos");
        }

        public static DataTable datosTabla()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = "select * from formas_pagos;";
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

        public override List<string> generarCampos()
        {
            List<string> campos = new List<string>();
            campos.Add("nombre_pago");
            return campos;
        }

        public override List<string> generarValores()
        {
            List<string> valores = new List<string>();
            valores.Add(nombre_pago);
            return valores;
        }
    }
}
