using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace conexiones_BD.clases
{
    public class bancos: entidad
    {
        string idbanco, nombre, telefono_banco;

        public bancos(string idbanco, string nombre, string telefono_banco)
        {
            this.idbanco = idbanco;
            this.nombre = nombre;
            this.telefono_banco = telefono_banco;
            base.cargarDatosModificados(generarCampos(), generarValores(), "bancos", idbanco, "idbanco");
        }

        public bancos(string nombre, string telefono_banco)
        {
            this.nombre = nombre;
            this.telefono_banco = telefono_banco;
            base.cargarDatos(generarCampos(), generarValores(), "bancos");
        }

        public bancos(string idbanco)
        {
            this.idbanco = idbanco;
            base.cargarDatosEliminados("bancos", idbanco, "idbanco");

        }

        public bancos(List<string> campos, List<string> valores)
        {
            base.busquedaDatos(campos, valores, "bancos");
        }

        public override List<string> generarCampos()
        {
            List<string> campos = new List<string>();
            campos.Add("nombre");
            campos.Add("telefono_banco");
            return campos;
        }

        public override List<string> generarValores()
        {
            List<string> valores = new List<string>();
            valores.Add(nombre);
            valores.Add(telefono_banco);
            return valores;
        }

        public static DataTable datosTabla()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = "select * from bancos;";
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
