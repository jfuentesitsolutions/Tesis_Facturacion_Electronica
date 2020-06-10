using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace conexiones_BD.clases
{
    public class empleados_sucursales:entidad
    {
        string idempleado_sucursal, idsucursal, idempleado;

        public string Idempleado_sucursal
        {
            get
            {
                return idempleado_sucursal;
            }

            set
            {
                idempleado_sucursal = value;
            }
        }

        public string Idsucursal
        {
            get
            {
                return idsucursal;
            }

            set
            {
                idsucursal = value;
            }
        }

        public string Idempleado
        {
            get
            {
                return idempleado;
            }

            set
            {
                idempleado = value;
            }
        }

        public empleados_sucursales(string idempleado_sucursal, string idsucursal, string idempleado)
        {
            this.Idempleado_sucursal = idempleado_sucursal;
            this.Idsucursal = idsucursal;
            this.Idempleado = idempleado;
            base.cargarDatosModificados(generarCampos(), generarValores(), "empleados_sucursales", idempleado_sucursal, "idempleado_sucursal");
        }

        public empleados_sucursales( string idsucursal, string idempleado)
        {
            this.Idsucursal = idsucursal;
            this.Idempleado = idempleado;
            base.cargarDatos(generarCampos(), generarValores(),"empleados_sucursales");
        }

        public empleados_sucursales(string idempleado_sucursal)
        {
            this.Idempleado_sucursal = idempleado_sucursal;
            base.cargarDatosEliminados("empleados_sucursales", idempleado_sucursal, "idempleado_sucursal");
        }

        public empleados_sucursales(List<string> c, List<string> v)
        {
            base.busquedaDatos(c, v, "empleados_sucursales");
        }

        public override List<string> generarCampos()
        {
            List<string> campos = new List<string>();
            campos.Add("idsucursal");
            campos.Add("idempleado");
            return campos;
        }

        public override List<string> generarValores()
        {
            List<string> valores = new List<string>();
            valores.Add(Idsucursal);
            valores.Add(Idempleado);
            return valores;
        }

        public void cargarNevamente()
        {
            base.cargarDatos(generarCampos(), generarValores(), "empleados_sucursales");
        }

        public static DataTable datosTabla()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"select es.idempleado_sucursal, concat(e.nombres, ' ',e.apellidos) as nombres
                        from empleados_sucursales es, empleados e, sucursales s
                        where es.idempleado=e.idempleado and es.idsucursal=s.idsucursal
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
