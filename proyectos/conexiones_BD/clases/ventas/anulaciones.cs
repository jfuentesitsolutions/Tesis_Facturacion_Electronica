using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace conexiones_BD.clases.ventas
{
    public class anulaciones:entidad
    {
        string idanulacion_venta, idventa, justificicacion, idusuario, fecha;

        public anulaciones(string idventa, string justificicacion, string idusuario, string fecha)
        {
            this.idventa = idventa;
            this.justificicacion = justificicacion;
            this.idusuario = idusuario;
            this.fecha = fecha;
            base.cargarDatos(generarCampos(), generarValores(), "anulaciones_ventas");
        }

        public override List<string> generarCampos()
        {
            List<string> campos = new List<string>();
            campos.Add("idventa");
            campos.Add("justificicacion");
            campos.Add("idusuario");
            campos.Add("fecha");

            return campos;

        }

        public override List<string> generarValores()
        {
            List<string> valores = new List<string>();
            valores.Add(idventa);
            valores.Add(justificicacion);
            valores.Add(idusuario);
            valores.Add(fecha);

            return valores;
        }

        
    }
}
