using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conexiones_BD.clases
{
    public class cajas:entidad
    {
        string id, fecha_a, fecha_c, estado, nombre_equi, efectivo_i, idusu;

        public string Fecha_c
        {
            get
            {
                return fecha_c;
            }

            set
            {
                fecha_c = value;
            }
        }

        public string Estado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
            }
        }

        public cajas(){  }

        public cajas(string id, string fecha_a, string fecha_c, string estado, string nombre_equi, string efectivo_i, string idusu)
        {
            this.id = id;
            this.fecha_a = fecha_a;
            this.Fecha_c = fecha_c;
            this.Estado = estado;
            this.nombre_equi = nombre_equi;
            this.efectivo_i = efectivo_i;
            this.idusu = idusu;
        }

        public cajas(string fecha_a, string fecha_c, string estado, string nombre_equi, string efectivo_i, string idusu)
        {
            this.fecha_a = fecha_a;
            this.Fecha_c = fecha_c;
            this.Estado = estado;
            this.nombre_equi = nombre_equi;
            this.efectivo_i = efectivo_i;
            this.idusu = idusu;
            base.cargarDatos(generarCampos(), generarValores(), "cajas");
        }

        public override List<string> generarCampos()
        {
            List<string> campos = new List<string>();
            campos.Add("fecha_apertura");
            campos.Add("fecha_cierre");
            campos.Add("estado");
            campos.Add("nombre_equipo");
            campos.Add("efectivo_inicial");
            campos.Add("idusuario");

            return campos;
        }

        public override List<string> generarValores()
        {
            List<string> valores = new List<string>();
            valores.Add(fecha_a);
            valores.Add(Fecha_c);
            valores.Add(Estado);
            valores.Add(nombre_equi);
            valores.Add(efectivo_i);
            valores.Add(idusu);

            return valores;
        }

        public static DataTable datosTabla(string nombre)
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = "select * from cajas where estado=1 and nombre_equipo='"+nombre+"';";
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

        public static DataTable datosTabla()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = "select * from cajas where estado=1";
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

        public string modificar()
        {
            return "UPDATE cajas SET fecha_cierre='"+Fecha_c+"', estado='"+estado+"' WHERE idcaja='"+id+"';";
        }
    }
}
