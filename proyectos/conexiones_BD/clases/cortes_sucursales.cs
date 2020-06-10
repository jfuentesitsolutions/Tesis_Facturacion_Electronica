using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conexiones_BD.clases
{
    public class cortes_sucursales:entidad
    {
        string idcorte, idsu, idcor, fecha;

        public cortes_sucursales( string idsu, string idcor, string fecha)
        {
            this.idsu = idsu;
            this.idcor = idcor;
            this.fecha = fecha;
            base.cargarDatos(generarCampos(), generarValores(), "cortes_sucursales");
        }


        public void cargarId(string id)
        {
            this.idcor = id;
            base.cargarDatos(generarCampos(), generarValores(), "cortes_sucursales");
        }

        public override List<string> generarCampos()
        {
            List<string> campos = new List<string>();
            campos.Add("idsucursal");
            campos.Add("idcorte_diario");
            campos.Add("fecha");

            return campos;
        }

        public override List<string> generarValores()
        {
            List<string> valores = new List<string>();
            valores.Add(this.idsu);
            valores.Add(this.idcor);
            valores.Add(this.fecha);

            return valores;
        }
    }
}
