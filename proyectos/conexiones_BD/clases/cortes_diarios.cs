using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conexiones_BD.clases
{
    public class cortes_diarios:entidad
    {
        string idcorte, total, total_anulado, 
            total_ganan, idusu, gastos_ope, 
            idca, totavtic, totalvf, total_com, total_c_anulado;

        public cortes_diarios(string total, 
            string total_anulado, 
            string total_ganan, 
            string idusu, 
            string gastos_ope, 
            string idca, 
            string totavtic, 
            string totalvf, 
            string total_com, 
            string tca)
        {
            this.total = total;
            this.total_anulado = total_anulado;
            this.total_ganan = total_ganan;
            this.idusu = idusu;
            this.gastos_ope = gastos_ope;
            this.idca = idca;
            this.totavtic = totavtic;
            this.totalvf = totalvf;
            this.total_com = total_com;
            this.total_c_anulado = tca;
            base.cargarDatos(generarCampos(), generarValores(), "cortes_diarios");
        }

        public override List<string> generarCampos()
        {
            List<string> campos = new List<string>();
            campos.Add("total");
            campos.Add("total_ventas_anuladas");
            campos.Add("total_ganancia");
            campos.Add("idusuario");
            campos.Add("gastos_operativos");
            campos.Add("idcaja");
            campos.Add("total_ventas_tickets");
            campos.Add("total_ventas_facturas");
            campos.Add("total_compras");
            campos.Add("total_compras_anuladas");

            return campos;
        }

        public override List<string> generarValores()
        {
            List<string> valores = new List<string>();
            valores.Add(this.total);
            valores.Add(this.total_anulado);
            valores.Add(this.total_ganan);
            valores.Add(this.idusu);
            valores.Add(this.gastos_ope);
            valores.Add(this.idca);
            valores.Add(this.totavtic);
            valores.Add(this.totalvf);
            valores.Add(this.total_com);
            valores.Add(this.total_c_anulado);
            return valores;
        }

        public static DataTable datosCajasCerradas()
        {
            string sentencia = @"select c.idcaja, c.fecha_cierre, cd.total, c.nombre_equipo, c.efectivo_inicial, cast(c.idcaja as char(45)) as idl
from cortes_diarios cd, cajas c
where cd.idcaja=c.idcaja and c.estado=2;";

            operaciones op = new operaciones();
            try
            {
                return op.Consultar(sentencia);
            }
            catch
            {
                return new DataTable();
            }

        }

        public static DataTable datosCaja(string idcaja)
        {
            string sentencia = @"select total_ventas_tickets as vt, total_ventas_facturas as vf, total_ventas_anuladas as anula_v,
total_compras_anuladas as anula_c, gastos_operativos as gastos, total_compras as compra, total_ganancia as gana from cortes_diarios where idcaja='" + idcaja+"';";

            operaciones op = new operaciones();
            try
            {
                return op.Consultar(sentencia);
            }
            catch
            {
                return new DataTable();
            }
        }
    }
}
