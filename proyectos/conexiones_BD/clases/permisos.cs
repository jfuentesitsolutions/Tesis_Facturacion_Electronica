using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace conexiones_BD.clases
{
    public class permisos:entidad
    {
        string idpermiso, nombre, descripcion, nombre_control;

        public permisos(string id, string n, string de, string noc)
        {
            this.idpermiso = id;
            this.nombre = n;
            this.descripcion = de;
            this.nombre_control = noc;

            base.cargarDatosModificados(generarCampos(), generarValores(), "permisos", idpermiso, "idpermiso");
        }

        public permisos(string n, string de, string noc)
        {
            
            this.nombre = n;
            this.descripcion = de;
            this.nombre_control = noc;

            base.cargarDatos(generarCampos(), generarValores(), "permisos");
        }

        public permisos(string id)
        {
            this.idpermiso = id;
            base.cargarDatosEliminados("permisos", idpermiso, "idpermiso");
        }

        public permisos(List<string> c, List<string> v)
        {
            base.busquedaDatos(c, v, "permisos");
        }

        public override List<String> generarCampos()
        {
            List<String> campos = new List<String>();
            campos.Add("nombre");
            campos.Add("descripcion");
            campos.Add("nombre_control");

            return campos;
        }

        public override List<String> generarValores()
        {
            List<String> valores = new List<String>();
            valores.Add(nombre);
            valores.Add(descripcion);
            valores.Add(nombre_control);

            return valores;
        }

        public static DataTable datosTabla()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = "select * from permisos;";
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
