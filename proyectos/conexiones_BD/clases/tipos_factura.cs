using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace conexiones_BD.clases
{
    public class tipos_factura:entidad
    {
        string idtipo_factura, nombre;

        public string Idtipo_factura
        {
            get
            {
                return idtipo_factura;
            }

            set
            {
                idtipo_factura = value;
            }
        }

        public tipos_factura(string idtipo_factura, string nombre)
        {
            this.Idtipo_factura = idtipo_factura;
            this.nombre = nombre;
            base.cargarDatosModificados(generarCampos(), generarValores(), "tipos_facturas", idtipo_factura, "idtipo_factura");
        }

        public tipos_factura(string nombre)
        {
            this.nombre = nombre;
            base.cargarDatos(generarCampos(), generarValores(), "tipos_facturas");
        }

        public tipos_factura(List<string> campos, List<string> valores)
        {
            base.busquedaDatos(campos, valores, "tipos_facturas");
        }

        public tipos_factura()
        {
           
        }

        public void cargarParaEliminar()
        {
            base.cargarDatosEliminados("tipos_facturas", idtipo_factura, "idtipo_factura");
        }

        public override List<string> generarCampos()
        {
            List<string> campos = new List<string>();
            campos.Add("nombre");
            return campos;
        }

        public override List<string> generarValores()
        {
            List<string> valores = new List<string>();
            valores.Add(nombre);
            return valores;
        }

        public static DataTable datosTabla()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = "select * from tipos_facturas;";
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
