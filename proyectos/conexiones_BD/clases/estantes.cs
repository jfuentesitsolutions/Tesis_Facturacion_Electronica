using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace conexiones_BD.clases
{
    public class estantes: entidad
    {
        string idestante, nombre, descripcion;

        public estantes(string idestante, string nombre, string descripcion)
        {
            this.idestante = idestante;
            this.nombre = nombre;
            this.descripcion = descripcion;
            base.cargarDatosModificados(generarCampos(), generarValores(), "estantes", idestante, "idestante");
        }

        public estantes(string nombre, string descripcion)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            base.cargarDatos(generarCampos(), generarValores(), "estantes");
        }

        public estantes(string idestante)
        {
            this.idestante = idestante;
            base.cargarDatosEliminados("estantes", idestante, "idestante");
        }

        public estantes(List<string> campos, List<string> valores)
        {
            base.busquedaDatos(campos, valores, "estantes");
        }

        public override List<string> generarCampos()
        {
            List<string> campos = new List<string>();
            campos.Add("nombre");
            campos.Add("descripcion");

            return campos;
        }

        public override List<string> generarValores()
        {
            List<string> valores = new List<string>();
            valores.Add(nombre);
            valores.Add(descripcion);

            return valores;
        }

        public static DataTable datosTabla()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = "select * from estantes;";
            operaciones oOperacion = new operaciones();
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
