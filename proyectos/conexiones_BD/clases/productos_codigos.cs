using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conexiones_BD.clases
{
    public class productos_codigos:entidad
    {
        string idproducto_codigo, idproducto, idcodigo;

        public string Idcodigo
        {
            get
            {
                return idcodigo;
            }

            set
            {
                idcodigo = value;
            }
        }

        public productos_codigos(string idproducto, string idcodigo)
        {
            this.idproducto = idproducto;
            this.Idcodigo = idcodigo;
            this.cargarDatos(generarCampos(), generarValores(), "productos_codigos");
        }

        public productos_codigos(string idproducto_codigo, string idproducto, string idcodigo)
        {
            this.idproducto_codigo = idproducto_codigo;
            this.idproducto = idproducto;
            this.Idcodigo = idcodigo;
            this.cargarDatosModificados(generarCampos(), generarValores(), "productos_codigos", idproducto_codigo, "idproducto_codigo");
        }

        public productos_codigos(string id)
        {
            this.idproducto_codigo = id;
            base.cargarDatosEliminados("productos_codigos", this.idproducto, "idproducto_codigo");
        }

        public productos_codigos(List<String> c, List<String> v)
        {
            base.busquedaDatos(c, v, "productos_codigos");
        }

        public void cargarNuevamente()
        {
            this.cargarDatos(generarCampos(), generarValores(), "productos_codigos");
        }

        public override List<string> generarCampos()
        {
            List<String> nombre_campos = new List<string>();
            nombre_campos.Add("idproducto");
            nombre_campos.Add("idcodigo");
        
            return nombre_campos;
        }

        public override List<string> generarValores()
        {
            List<String> valores = new List<string>();
            valores.Add(this.idproducto);
            valores.Add(this.Idcodigo);
            return valores;
        }

        
    }
}
