using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace control_principal.configuracion_inicial.cache_conexiones
{
    class cache
    {
        public static DataTable TODO_LOS_EMPLEADOS()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"select e.idempleado, e.codigo_empleado, e.nombres, e.apellidos, u.nombre
                        from empleados e, unidades u
                        where e.idunidad = u.idunidad
                        order by apellidos asc;";
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

        public static DataTable TODO_LOS_GRUPOS()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"select * from grupos;";
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

        public static DataTable TODO_LOS_UNIDADES()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"select * from unidades;";
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
