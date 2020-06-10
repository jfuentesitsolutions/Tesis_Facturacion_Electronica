using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace conexiones_BD.clases
{
    public class tipos_gastos:entidad
    {
        string idtipo_gasto, nombre, decripcion;

        public tipos_gastos(string idtipo_gasto, string nombre, string decripcion)
        {
            this.idtipo_gasto = idtipo_gasto;
            this.nombre = nombre;
            this.decripcion = decripcion;
            base.cargarDatosModificados(generarCampos(), generarValores(), "tipos_gastos", idtipo_gasto, "idtipo_gasto");
        }

        public tipos_gastos(string idtipo_gasto)
        {
            this.idtipo_gasto = idtipo_gasto;
            base.cargarDatosEliminados("tipos_gastos", idtipo_gasto, "idtipo_gasto");
        }

        public tipos_gastos(string nombre, string decripcion)
        {
            this.nombre = nombre;
            this.decripcion = decripcion;
            base.cargarDatos(generarCampos(), generarValores(), "tipos_gastos");
        }

        public tipos_gastos(List<string> campos, List<string> valores)
        {
            base.busquedaDatos(campos, valores, "tipos_gastos");
        }

        public override List<string> generarCampos()
        {
            List<string> campos = new List<string>();
            campos.Add("nombre");
            campos.Add("decripcion");
            return campos;
        }

        public override List<string> generarValores()
        {
            List<string> valores = new List<string>();
            valores.Add(nombre);
            valores.Add(decripcion);
            return valores;
        }

        public static DataTable datosTabla()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = "select * from tipos_gastos;";
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
