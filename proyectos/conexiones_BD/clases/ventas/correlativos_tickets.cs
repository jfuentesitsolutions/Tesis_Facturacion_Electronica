using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace conexiones_BD.clases.ventas
{
    public class correlativos_tickets:entidad
    {
        string idcorrelativo_ticket, idsucursal, inicio, final, numero_siguiente, 
            fecha_ultimo, descripcion, activos;

        public correlativos_tickets(string idcorrelativo_ticket, string idsucursal, string inicio, string final, string numero_siguiente, string fecha_ultimo, string descripcion, string activo)
        {
            this.idcorrelativo_ticket = idcorrelativo_ticket;
            this.idsucursal = idsucursal;
            this.inicio = inicio;
            this.final = final;
            this.numero_siguiente = numero_siguiente;
            this.fecha_ultimo = fecha_ultimo;
            this.descripcion = descripcion;
            base.cargarDatos(generarCampos(), generarValores(), "correlativos_ticket");
        }

        public correlativos_tickets(string idsucursal, string inicio, string final, string numero_siguiente, string fecha_ultimo, string descripcion, string activo)
        {
            this.idsucursal = idsucursal;
            this.inicio = inicio;
            this.final = final;
            this.numero_siguiente = numero_siguiente;
            this.fecha_ultimo = fecha_ultimo;
            this.descripcion = descripcion;
            this.activos = activo;
            base.cargarDatos(generarCampos(), generarValores(), "correlativos_ticket");
        }

        public override List<string> generarCampos()
        {
            List<string> campos = new List<string>();
            campos.Add("idsucursal");
            campos.Add("inicio");
            campos.Add("final");
            campos.Add("numero_siguiente");
            campos.Add("fecha_ultimo");
            campos.Add("descripcion");
            campos.Add("activos");


            return campos;
        }

        public override List<string> generarValores()
        {
            List<string> valores = new List<string>();
            valores.Add(idsucursal);
            valores.Add(inicio);
            valores.Add(final);
            valores.Add(numero_siguiente);
            valores.Add(fecha_ultimo);
            valores.Add(descripcion);
            valores.Add(activos);
            return valores;
        }

        public static DataTable datosTabla(string idsucursal)
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = "select * from correlativos_ticket where idsucursal='"+idsucursal+ "' and activos=1;";
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

        public static bool actualizaCorrelativos(string numerosiguiente, string id)
        {
            bool actualizado = false;
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("UPDATE correlativos_ticket set ");
            sentencia.Append("numero_siguiente='" + numerosiguiente + "',");
            sentencia.Append("fecha_ultimo=now() ");
            sentencia.Append("WHERE idcorrelativo_ticket='"+id+"';");
            operaciones op = new operaciones();

            if (op.actualizar(sentencia.ToString()) > 0)
            {
                actualizado = true;
            }

            return actualizado;
        }

        public static DataTable datosTablaCorrelativo()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"select ct.idcorrelativo_ticket as idc, s.numero_de_sucursal as nus, ct.numero_siguiente as ns, ct.final as f, ct.activos as act
                            from correlativos_ticket ct, sucursales s
                            where ct.idsucursal=s.idsucursal
                            ;";
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
