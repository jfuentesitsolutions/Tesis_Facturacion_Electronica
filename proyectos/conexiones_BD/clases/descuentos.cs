using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace conexiones_BD.clases
{
    public class descuentos:entidad
    {
        string iddescuento, tipo_descuento, descuento;

        public descuentos(string iddescuento, string tipo_descuento, string descuento)
        {
            this.iddescuento = iddescuento;
            this.tipo_descuento = tipo_descuento;
            this.descuento = descuento;
            base.cargarDatosModificados(generarCampos(), generarValores(), "descuentos", iddescuento, "iddescuento");
        }

        public descuentos(string iddescuento)
        {
            this.iddescuento = iddescuento;
            base.cargarDatosEliminados("descuentos", iddescuento, "iddescuento");
        }

        public descuentos(string tipo_descuento, string descuento)
        {
            this.tipo_descuento = tipo_descuento;
            this.descuento = descuento;
            base.cargarDatos(generarCampos(), generarValores(), "descuentos");
        }

        public descuentos(List<string> campos, List<string> valores )
        {
            base.busquedaDatos(campos, valores, "descuentos");
        }

        public override List<string> generarCampos()
        {
            List<string> campos = new List<string>();
            campos.Add("tipo_descuento");
            campos.Add("descuento");
            return campos;
        }

        public override List<string> generarValores()
        {
            List<string> valores = new List<string>();
            valores.Add(tipo_descuento);
            valores.Add(descuento);
            return valores;
        }

        public static DataTable datosTabla()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = "select * from descuentos;";
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
