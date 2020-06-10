using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conexiones_BD.clases
{
    public class configuracion_inicial: entidad
    {
        string numero_sucursal, encargado, fecha_instalacion, encargado_instalar;

        public configuracion_inicial(string numero_sucursal, string encargado, string fecha_instalacion, string encargado_instalar)
        {
            this.numero_sucursal = numero_sucursal;
            this.encargado = encargado;
            this.fecha_instalacion = fecha_instalacion;
            this.encargado_instalar = encargado_instalar;
            base.cargarDatos(generarCampos(), generarValores(), "configuracion_inicial");
        }

        public override List<string> generarCampos()
        {
            List<string> campos = new List<string>();
            campos.Add("numero_sucursal");
            campos.Add("encargado");
            campos.Add("fecha_instalacion");
            campos.Add("encargado_instalar");
            return campos;
        }

        public override List<string> generarValores()
        {
            List<string> valores = new List<string>();
            valores.Add(numero_sucursal);
            valores.Add(encargado);
            valores.Add(fecha_instalacion);
            valores.Add(encargado_instalar);
            return valores;

        }

    }
}
