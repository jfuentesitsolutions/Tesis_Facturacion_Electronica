using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conexiones_BD.clases
{
    public class empresa:entidad
    {
        string nombre_empresa, nrc, razon_social, denominacion, giro, direccion_local, nit, ruta_almacen_pfx, ruta_certificado;

        public empresa(string nombre_empresa, string nrc, string razon_social, string denominacion, string giro, 
            string direccion_local, string nit, string ruta_certificado, string ruta_almacen_pfx, bool actualizar)
        {
            this.nombre_empresa = nombre_empresa;
            this.nrc = nrc;
            this.razon_social = razon_social;
            this.denominacion = denominacion;
            this.giro = giro;
            this.direccion_local = direccion_local;
            this.nit = nit;
            this.ruta_certificado = ruta_certificado;
            this.ruta_almacen_pfx = ruta_almacen_pfx;
            if (!actualizar)
            {
                cargarDatos(generarCampos(), generarValores(), "empresa");
            }
        }

        public empresa(string idempresa)
        {
            cargarDatosEliminados("empresa", idempresa, "idempresa");
        }

        public override List<string> generarCampos()
        {
            List<string> campos = new List<string>();
            campos.Add("nombre_empresa");
            campos.Add("nrc");
            campos.Add("razon_social");
            campos.Add("denominacion");
            campos.Add("giro");
            campos.Add("direccion_local");
            campos.Add("nit");
            campos.Add("ruta_almacen_pfx");
            campos.Add("ruta_certificado");

            return campos;
        }

        public override List<string> generarValores()
        {
            List<string> valores = new List<string>();
            valores.Add(this.nombre_empresa);
            valores.Add(this.nrc);
            valores.Add(this.razon_social);
            valores.Add(this.denominacion);
            valores.Add(this.giro);
            valores.Add(this.direccion_local);
            valores.Add(this.nit);
            valores.Add(this.ruta_almacen_pfx);
            valores.Add(this.ruta_certificado);

            return valores;
        }

        public static DataTable datos_empresa()
        {
            string consulta = "select * from empresa;";
            operaciones op = new operaciones();

            try
            {
                using(DataTable datos = op.Consultar(consulta))
                {
                    return datos;
                }
            }
            catch
            {
                return new DataTable();
            }
            
        }

        public bool actualizando_empresa(string idempresa)
        {
            StringBuilder sentencia = new StringBuilder("update empresa set ");
            sentencia.Append("nombre_empresa='"+nombre_empresa+"',");
            sentencia.Append("nrc='" + nrc + "',");
            sentencia.Append("razon_social='" + razon_social + "',");
            sentencia.Append("denominacion='" + denominacion + "',");
            sentencia.Append("giro='" + giro + "',");
            sentencia.Append("direccion_local='" + direccion_local + "',");
            sentencia.Append("nit='" + nit + "',");
            sentencia.Append("ruta_almacen_pfx='" + ruta_almacen_pfx + "',");
            sentencia.Append("ruta_certificado='" + ruta_certificado + "' ");
            sentencia.Append("where (idempresa='"+idempresa+"');");

            operaciones op = new operaciones();

            if (op.actualizar(sentencia.ToString()) > 0)
            {
                return true;
            }else { return false;  }
        }
    }
}
