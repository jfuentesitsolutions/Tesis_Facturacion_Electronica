using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace conexiones_BD.clases
{
    public class utilidades:entidad
    {
        string idutilidad_compra, nombre, porcentaje, idtipo_compra;

        public utilidades(string idutilidad_compra, string nombre, string porcentaje, string idtipo_compra)
        {
            this.idutilidad_compra = idutilidad_compra;
            this.nombre = nombre;
            this.porcentaje = porcentaje;
            this.idtipo_compra = idtipo_compra;
            base.cargarDatosModificados(generarCampos(), generarValores(), "utilidades_compras", idutilidad_compra, "idutilidad_compra");
        }

        public utilidades(string nombre, string porcentaje, string idtipo_compra)
        {
            this.nombre = nombre;
            this.porcentaje = porcentaje;
            this.idtipo_compra = idtipo_compra;
            base.cargarDatos(generarCampos(), generarValores(), "utilidades_compras");
        }

        public utilidades(string idutilidad_compra)
        {
            this.idutilidad_compra = idutilidad_compra;
            base.cargarDatosEliminados("utilidades_compras", idutilidad_compra, "idutilidad_compra");
        }

        public utilidades(List<string> campos, List<string> valores)
        {
            base.busquedaDatos(campos, valores, "utilidades_compras");
        }

        public override List<string> generarCampos()
        {
            List<string> campos = new List<string>();
            campos.Add("nombre");
            campos.Add("porcentaje");
            campos.Add("idtipo_compra");
            return campos;
        }

        public override List<string> generarValores()
        {
            List<string> valores = new List<string>();
            valores.Add(nombre);
            valores.Add(porcentaje);
            valores.Add(idtipo_compra);
            return valores;
        }

        public static DataTable datosTabla()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"select uc.idutilidad_compra, uc.nombre, uc.porcentaje*100 as porcen, uc.porcentaje, uc.idtipo_compra, tc.nombre as nombreT
                        from utilidades_compras uc, tipo_compras tc
                        where uc.idtipo_compra = tc.idtipo_compra
                        ; ";
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

        public static DataTable datosTablaMayoreo()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"select uc.idutilidad_compra, uc.nombre, uc.porcentaje*100 as porcen, uc.porcentaje, uc.idtipo_compra, tc.nombre as nombreT
                        from utilidades_compras uc, tipo_compras tc
                        where uc.idtipo_compra=tc.idtipo_compra and tc.idtipo_compra='1'
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

        public static DataTable datosTablaDetalle()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"select uc.idutilidad_compra, uc.nombre, uc.porcentaje*100 as porcen, uc.porcentaje, uc.idtipo_compra, tc.nombre as nombreT
                        from utilidades_compras uc, tipo_compras tc
                        where uc.idtipo_compra=tc.idtipo_compra and tc.idtipo_compra='3'
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
