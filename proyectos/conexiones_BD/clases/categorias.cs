using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace conexiones_BD.clases
{
    public class categorias: entidad
    {
        string idcategoria, nombre_categoria, descripcion;

        public categorias(string idcategoria, string nombre_categoria, string descripcion)
        {
            this.idcategoria = idcategoria;
            this.nombre_categoria = nombre_categoria;
            this.descripcion = descripcion;
            base.cargarDatosModificados(generarCampos(), generarValores(), "categorias", idcategoria, "idcategoria");
        }

        public categorias(string nombre_categoria, string descripcion)
        {
            this.nombre_categoria = nombre_categoria;
            this.descripcion = descripcion;
            base.cargarDatos(generarCampos(), generarValores(), "categorias");
        }

        public categorias(string idcategoria)
        {
            this.idcategoria = idcategoria;
            base.cargarDatosEliminados("categorias", idcategoria, "idcategoria");
        }

        public categorias(List<string> campos, List<string> valores)
        {
            base.busquedaDatos(campos, valores, "categorias");
        }

        public override List<string> generarCampos()
        {
            List<string> campos = new List<string>();
            campos.Add("nombre_categoria");
            campos.Add("descripcion");

            return campos;
        }

        public override List<string> generarValores()
        {
            List<string> valores = new List<string>();
            valores.Add(nombre_categoria);
            valores.Add(descripcion);

            return valores;
        }

        public static DataTable datosTabla()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = "select * from categorias;";
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
