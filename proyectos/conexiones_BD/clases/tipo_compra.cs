using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace conexiones_BD.clases
{
    public class tipo_compra:entidad
    {
        string idtipo_compra, nombre, descripcion;

        public tipo_compra(string idtipo_compra, string nombre, string descripcion)
        {
            this.idtipo_compra = idtipo_compra;
            this.nombre = nombre;
            this.descripcion = descripcion;
            base.cargarDatosModificados(generarCampos(), generarValores(), "tipo_compras", idtipo_compra, "idtipo_compra");
        }

        public tipo_compra( string nombre, string descripcion)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            base.cargarDatos(generarCampos(), generarValores(), "tipo_compras");
        }

        public tipo_compra(string idtipo_compra)
        {
            this.idtipo_compra = idtipo_compra;
            base.cargarDatosEliminados("tipo_compras", idtipo_compra, "idtipo_compra");
        }

        public tipo_compra(List<string> campos, List<string> valores)
        {
            base.busquedaDatos(campos, valores, "tipo_compras");
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
            Consulta = "select * from tipo_compras;";
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
