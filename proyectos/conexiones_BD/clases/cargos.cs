using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace conexiones_BD.clases
{
    public class cargos:entidad
    {
        string idcargo, nombre_cargo, descripcion;

        public cargos(string idcargo, string nombre_cargo, string descripcion)
        {
            this.idcargo = idcargo;
            this.nombre_cargo = nombre_cargo;
            this.descripcion = descripcion;

            base.cargarDatosModificados(generarCampos(), generarValores(), "cargos", idcargo,"idcargo");
        }

        public cargos(string nombre_cargo, string descripcion)
        {
            this.nombre_cargo = nombre_cargo;
            this.descripcion = descripcion;
            base.cargarDatos(generarCampos(), generarValores(), "cargos");
        }

        public cargos(string idcargo)
        {
            this.idcargo = idcargo;
            base.cargarDatosEliminados("cargos", idcargo, "idcargo");
        }

        public cargos(List<string> c, List<string> v)
        {
            base.busquedaDatos(c, v, "cargos");
        }

        public override List<string> generarCampos()
        {
            List<string> campos = new List<string>();
            campos.Add("nombre_cargo");
            campos.Add("descripcion");

            return campos;
        }

        public override List<string> generarValores()
        {
            List<string> valores = new List<string>();
            valores.Add(nombre_cargo);
            valores.Add(descripcion);

            return valores;
        }

        public static DataTable datosTabla()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = "select * from cargos;";
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
