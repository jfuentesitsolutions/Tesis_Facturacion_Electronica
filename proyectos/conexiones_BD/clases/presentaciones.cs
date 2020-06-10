using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace conexiones_BD.clases
{
    public class presentaciones: entidad
    {
        string idpresentacion, nombre_presentacion, descripcion, estado;

        public presentaciones(string idpresentacion, string nombre_presentacion, string descripcion, string estado)
        {
            this.idpresentacion = idpresentacion;
            this.nombre_presentacion = nombre_presentacion;
            this.descripcion = descripcion;
            this.estado = estado;
            base.cargarDatosModificados(generarCampos(), generarValores(), "presentaciones", idpresentacion, "idpresentacion");
        }

        public presentaciones(string nombre_presentacion, string descripcion, string estado)
        {
            this.nombre_presentacion = nombre_presentacion;
            this.descripcion = descripcion;
            this.estado = estado;
            base.cargarDatos(generarCampos(), generarValores(), "presentaciones");
        }

        public presentaciones(string idpresentacion)
        {
            this.idpresentacion = idpresentacion;
            base.cargarDatosEliminados("presentaciones", idpresentacion, "idpresentacion");
        }

        public presentaciones(List<string> campos, List<string> valores)
        {
            base.busquedaDatos(campos, valores,"presentaciones");
        }

        public override List<string> generarCampos()
        {
            List<string> campos = new List<string>();
            campos.Add("nombre_presentacion");
            campos.Add("descripcion");
            campos.Add("estado");
            return campos;
        }

        public override List<string> generarValores()
        {
            List<string> valores = new List<string>();
            valores.Add(nombre_presentacion);
            valores.Add(descripcion);
            valores.Add(estado);
            return valores;
        }

        public static DataTable datosTabla()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = "select * from presentaciones;";
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

        public static string presentacion(string id)
        {
            string prese = "";
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"select p.nombre_presentacion
                        from presentaciones p
                        where p.idpresentacion = '"+id+@" and estado=1'
                        ; ";
            conexiones_BD.operaciones oOperacion = new conexiones_BD.operaciones();
            try
            {
                Datos = oOperacion.Consultar(Consulta);
                prese = Datos.Rows[0][0].ToString();
            }
            catch
            {
                Datos = new DataTable();
            }

            return prese;
        }
    }
}
