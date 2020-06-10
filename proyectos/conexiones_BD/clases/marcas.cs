using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace conexiones_BD.clases
{
    public class marcas: entidad
    {
        string idmarca, nombre, descripcion;

        public marcas(string idmarca, string nombre, string descripcion)
        {
            this.idmarca = idmarca;
            this.nombre = nombre;
            this.descripcion = descripcion;
            base.cargarDatosModificados(generarCampos(), generarValores(), "marcas", idmarca, "idmarca");
        }

        public marcas( string nombre, string descripcion)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            base.cargarDatos(generarCampos(), generarValores(), "marcas");
        }

        public marcas(string idmarca)
        {
            this.idmarca = idmarca;
            base.cargarDatosEliminados("marcas", idmarca, "idmarca");
        }

        public marcas(List<string> campos, List<string> valores)
        {
            base.busquedaDatos(campos, valores, "marcas");
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
            Consulta = "select * from marcas;";
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
