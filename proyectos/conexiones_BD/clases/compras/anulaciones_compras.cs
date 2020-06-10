using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace conexiones_BD.clases.compras
{
    public class anulaciones_compras:entidad
    {
        string idanulacion_compra, idcompra, justificacion, idusuario, fecha;

        public anulaciones_compras(string idcompra, string justificacion, string idusuario, string fecha)
        {
            this.idcompra = idcompra;
            this.justificacion = justificacion;
            this.idusuario = idusuario;
            this.fecha = fecha;
            base.cargarDatos(generarCampos(), generarValores(), "anulaciones_compras");
        }

        public override List<string> generarCampos()
        {
            List<string> campos = new List<string>();
            campos.Add("idcompra");
            campos.Add("justificacion");
            campos.Add("idusuario");
            campos.Add("fecha");

            return campos;
        }

        public override List<string> generarValores()
        {
            List<string> valores = new List<string>();
            valores.Add(idcompra);
            valores.Add(justificacion);
            valores.Add(idusuario);
            valores.Add(fecha);

            return valores;
        }

    }
}
