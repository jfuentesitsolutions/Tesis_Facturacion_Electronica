using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conexiones_BD.clases
{
    public class codigos : entidad
    {
        string idcodigo, codigo, estado;

        public codigos(string codigo, string estado)
        {
            this.codigo = codigo;
            this.estado = estado;
            this.cargarDatos(generarCampos(), generarValores(), "codigos");  
        }
        public codigos(string id,string codigo, string estado)
        {
            this.idcodigo = id;
            this.codigo = codigo;
            this.estado = estado;
            this.cargarDatos(generarCampos(), generarValores(), "codigos");
        }

        public codigos(List<String> c, List<String> v)
        {
            base.busquedaDatos(c, v, "codigos");
        }

        public override List<string> generarCampos()
        {
            List<string> campos = new List<string>();
            campos.Add("codigo");
            campos.Add("estado");
            return campos;
        }

        public override List<string> generarValores()
        {
            List<string> valores = new List<string>();
            valores.Add(this.codigo);
            valores.Add(this.estado);
            return valores;
        }

        public StringBuilder sentenciaModi()
        {
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("UPDATE codigos SET codigo='"+ codigo +"', estado='" + estado + "' WHERE idcodigo='" + idcodigo + "';");
            return sentencia;
        }

        public bool validarCodigo()
        {
            operaciones op = new operaciones();
            bool valido = false;
            string sentencia = "SELECT * FROM codigos WHERE codigo='" + this.codigo + "';";
            int reg = op.Consultar(sentencia).Rows.Count;
            Console.WriteLine(reg);

            if (reg>0)
            {
                valido = true;   
            }

            return valido;
        }

        public bool validarCodigoActualizar()
        {
            operaciones op = new operaciones();
            bool valido = false;
            string sentencia = "SELECT * FROM codigos WHERE codigo='" + this.codigo + "';";
            int reg = op.Consultar(sentencia).Rows.Count;
            Console.WriteLine(reg);

            if (reg > 1)
            {
                valido = true;

            }

            return valido;
        }

        public static DataTable cargarCodigos(string idpro)
        {
            DataTable datos = null;
            string sentencia = @"select c.idcodigo, c.codigo, c.estado, pc.idproducto_codigo
                                from productos_codigos pc, codigos c
                                where pc.idcodigo = c.idcodigo and pc.idproducto = '" + idpro+@"' and c.estado=1
                                  ; ";
            operaciones op = new operaciones();
            try
            {
                datos = op.Consultar(sentencia);
            }
            catch
            {
                datos = null;
            }


            return datos;
        }

        public static DataTable cargarCodigosTodos(string idpro)
        {
            DataTable datos = null;
            string sentencia = @"select c.idcodigo, c.codigo, c.estado, pc.idproducto_codigo
                                from productos_codigos pc, codigos c
                                where pc.idcodigo = c.idcodigo and pc.idproducto = '" + idpro + @"'
                                  ; ";
            operaciones op = new operaciones();
            try
            {
                datos = op.Consultar(sentencia);
            }
            catch
            {
                datos = null;
            }


            return datos;
        }



    }
}
