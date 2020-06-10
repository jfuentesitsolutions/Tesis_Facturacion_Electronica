using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conexiones_BD.clases
{
    public class resoluciones:entidad
    {
        string numero_resolucion, fecha_resolucion, serie_autorizada_consumidor_final, serie_autorizada_credito_fiscal, inicio_fact, final_fact, numero_siguiente_fact, fecha_ultimo_fact, inicio_credi, final_credi, numero_siguiente_credi, fecha_ultimo_credi, descripcion, activo;

        public resoluciones() { }

        public resoluciones(string numero_registro)
        {
            cargarDatosEliminados("resoluciones", numero_registro, "numero_resolucion");
        }

        public resoluciones(string numero_resolucion, string fecha_resolucion, 
            string serie_autorizada_consumidor_final, string serie_autorizada_credito_fiscal, 
            string inicio_fact, string final_fact, string numero_siguiente_fact, string fecha_ultimo_fact,
            string inicio_credi, string final_credi, string numero_siguiente_credi, string fecha_ultimo_credi, 
            string descripcion, string activo, bool actualizar)
        {
            this.numero_resolucion = numero_resolucion;
            this.fecha_resolucion = fecha_resolucion;
            this.serie_autorizada_consumidor_final = serie_autorizada_consumidor_final;
            this.serie_autorizada_credito_fiscal = serie_autorizada_credito_fiscal;
            this.inicio_fact = inicio_fact;
            this.final_fact = final_fact;
            this.numero_siguiente_fact = numero_siguiente_fact;
            this.fecha_ultimo_fact = fecha_ultimo_fact;
            this.inicio_credi = inicio_credi;
            this.final_credi = final_credi;
            this.numero_siguiente_credi = numero_siguiente_credi;
            this.fecha_ultimo_credi = fecha_ultimo_credi;
            this.descripcion = descripcion;
            this.activo = activo;
            if (!actualizar)
            {
                cargarDatos(generarCampos(), generarValores(), "resoluciones");
            }
        }

        public override List<string> generarCampos()
        {
            List<string> campos = new List<string>();
            campos.Add("numero_resolucion");
            campos.Add("fecha_resolucion");
            campos.Add("serie_autorizada_consumidor_final");
            campos.Add("serie_autorizada_credito_fiscal");
            campos.Add("inicio_fact");
            campos.Add("final_fact");
            campos.Add("numero_siguiente_fact");
            campos.Add("fecha_ultimo_fact");
            campos.Add("inicio_credi");
            campos.Add("final_credi");
            campos.Add("numero_siguiente_credi");
            campos.Add("fecha_ultimo_credi");
            campos.Add("descripcion");
            campos.Add("activo");

            return campos;
        }

        public override List<string> generarValores()
        {
            List<string> valores = new List<string>();
            valores.Add(this.numero_resolucion);
            valores.Add(this.fecha_resolucion);
            valores.Add(this.serie_autorizada_consumidor_final);
            valores.Add(this.serie_autorizada_credito_fiscal);
            valores.Add(this.inicio_fact);
            valores.Add(this.final_fact);
            valores.Add(this.numero_siguiente_fact);
            valores.Add(this.fecha_ultimo_fact);
            valores.Add(this.inicio_credi);
            valores.Add(this.final_credi);
            valores.Add(this.numero_siguiente_credi);
            valores.Add(this.fecha_ultimo_credi);
            valores.Add(this.descripcion);
            valores.Add(this.activo);

            return valores;
        }

        public static DataTable datos_resolucion_activa()
        {
            String Consulta;
            Consulta = "select * from resoluciones where activo=1;";
            operaciones oOperacion = new operaciones();

            try
            {
                using (DataTable dato = oOperacion.Consultar(Consulta))
                {
                    return dato;
                }
            }
            catch
            {
                return new DataTable();
            }
            
        }

        public static DataTable datos_todas_las_resoluciones()
        {
            String Consulta;
            Consulta = "select * from resoluciones;";
            conexiones_BD.operaciones oOperacion = new conexiones_BD.operaciones();
            try
            {
                using (DataTable dato = oOperacion.Consultar(Consulta))
                {
                    return dato;
                }
            }
            catch
            {
                return new DataTable();
            }

        }

        public bool actualizar_datos()
        {
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("update resoluciones set fecha_resolucion='" + fecha_resolucion + "',");
            sentencia.Append("serie_autorizada_consumidor_final='" + serie_autorizada_consumidor_final + "',");
            sentencia.Append("serie_autorizada_credito_fiscal='" + serie_autorizada_credito_fiscal + "',");
            sentencia.Append("inicio_fact='" + inicio_fact + "',");
            sentencia.Append("final_fact='" + final_fact + "',");
            sentencia.Append("numero_siguiente_fact='" + numero_siguiente_fact + "',");
            sentencia.Append("fecha_ultimo_fact='" +  fecha_ultimo_fact + "',");
            sentencia.Append("inicio_credi='" + inicio_credi + "',");
            sentencia.Append("final_credi='" + final_credi + "',");
            sentencia.Append("numero_siguiente_credi='" + numero_siguiente_credi + "',");
            sentencia.Append("fecha_ultimo_credi='" + fecha_ultimo_credi + "',");
            sentencia.Append("descripcion='" + descripcion + "',");
            sentencia.Append("activo='" + activo + "' ");
            sentencia.Append("where (numero_resolucion='" + numero_resolucion + "');");

            operaciones op = new operaciones();
            if (op.actualizar(sentencia.ToString()) > 0)
            {
                return true;
            }
            else
            {
               return false;
            }

        }
    }
}
