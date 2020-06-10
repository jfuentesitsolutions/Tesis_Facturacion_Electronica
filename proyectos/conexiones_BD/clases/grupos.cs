using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace conexiones_BD.clases
{
    public class grupos : entidad
    {
        string idgrupo, nombre, descripcion;

        public grupos(string idgrupo, string nombre, string descripcion)
        {
            this.idgrupo = idgrupo;
            this.nombre = nombre;
            this.descripcion = descripcion;
            base.cargarDatosModificados(generarCampos(), generarValores(), "grupos", idgrupo, "idgrupo");
        }

        public grupos(string nombre, string descripcion)
        {
         
            this.nombre = nombre;
            this.descripcion = descripcion;
            base.cargarDatos(generarCampos(), generarValores(), "grupos");
           
        }

        public grupos(string idgrupo)
        {
            this.idgrupo = idgrupo;
            base.cargarDatosEliminados("grupos", idgrupo, "idgrupo");
            
        }

        public grupos(List<string> c, List<string> v)
        {
            base.busquedaDatos(c, v, "grupos");
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
            Consulta = "select * from grupos;";
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
