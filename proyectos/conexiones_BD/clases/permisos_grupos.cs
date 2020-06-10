using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace conexiones_BD.clases
{
    public class permisos_grupos:entidad
    {
        string idpermiso_usuario, idgrupo, idpermiso;


        public string Idgrupo
        {
            get
            {
                return idgrupo;
            }

            set
            {
                idgrupo = value;
            }
        }

        public permisos_grupos(string idpermiso_usuario, string idgrupo, string idpermiso)
        {
            this.idpermiso_usuario = idpermiso_usuario;
            this.idgrupo = idgrupo;
            this.idpermiso = idpermiso;
            base.cargarDatosModificados(generarCampos(), generarValores(), "permisos_grupos", idpermiso_usuario, "idpermiso_usuario");
        }

        public permisos_grupos(string idgrupo, string idpermiso)
        {
            this.idgrupo = idgrupo;
            this.idpermiso = idpermiso;
            base.cargarDatos(generarCampos(), generarValores(), "permisos_grupos");
        }

        public permisos_grupos(string idpermiso_usuario)
        {
            this.idpermiso_usuario = idpermiso_usuario;
            base.cargarDatosEliminados("permisos_grupos", idpermiso_usuario, "idpermiso_usuario");
        }

        public permisos_grupos(List<string> c, List<string> v)
        {
            base.busquedaDatos(c, v, "permisos_grupos");
        }

        public override List<string> generarCampos()
        {
            List<string> campos = new List<string>();
            campos.Add("idgrupo");
            campos.Add("idpermiso");
            return campos;
        }

        public override List<string> generarValores()
        {
            List<string> valores = new List<string>();
            valores.Add(idgrupo);
            valores.Add(idpermiso);
            return valores;
        }

        public void cargarNevamente()
        {
            base.cargarDatos(generarCampos(), generarValores(), "permisos_grupos");
        }

        public static DataTable datosTablaPermisosAasignar(string idgrupo)
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"select p.idpermiso, p.nombre, p.nombre_control
                        from permisos p
                        where p.idpermiso not in (select pg.idpermiso from permisos_grupos pg where pg.idgrupo = '"+idgrupo+@"')
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

        public static DataTable datosTablaPermisosAsignados(string idgrupo)
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"select g.nombre, p.idpermiso, p.nombre as nombreP, p.nombre_control, pg.idpermiso_usuario
                        from permisos_grupos pg, grupos g, permisos p
                        where pg.idgrupo = g.idgrupo and pg.idpermiso = p.idpermiso and pg.idgrupo = '" + idgrupo+@"'
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

    }
}
