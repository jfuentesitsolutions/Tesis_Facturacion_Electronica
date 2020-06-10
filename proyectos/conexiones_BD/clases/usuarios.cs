using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Xml;

namespace conexiones_BD.clases
{
    public class usuarios:entidad
    {
        string idusuario, usuario, contrasena, idempleado_sucursal, idgrupo, fecha_creacion, estado;

        public usuarios(string idusuario, string usuario, string contraseña, string idempleado_sucursal, string idgrupo, string fecha_creacion, string estado)
        {
            this.idusuario = idusuario;
            this.usuario = usuario;
            this.contrasena = contraseña;
            this.idempleado_sucursal = idempleado_sucursal;
            this.idgrupo = idgrupo;
            this.fecha_creacion = fecha_creacion;
            this.estado = estado;
            base.cargarDatosModificados(generarCampos(), generarValores(), "usuarios", idusuario, "idusuario");
        }

        public usuarios(string idusuario, string usuario, string idempleado_sucursal, string idgrupo, string estado)
        {
            this.idusuario = idusuario;
            this.usuario = usuario;
            this.idempleado_sucursal = idempleado_sucursal;
            this.idgrupo = idgrupo;
            this.estado = estado;
            base.cargarDatosModificados(generarCampos(), generarValores(), "usuarios", idusuario, "idusuario");
        }

        public usuarios(string usuario, string contraseña, string idempleado_sucursal, string idgrupo, string fecha_creacion, string estado)
        {
            this.usuario = usuario;
            this.contrasena = contraseña;
            this.idempleado_sucursal = idempleado_sucursal;
            this.idgrupo = idgrupo;
            this.fecha_creacion = fecha_creacion;
            this.estado = estado;
            base.cargarDatos(generarCampos(), generarValores(), "usuarios");
        }

        public usuarios(string idusuario)
        {
            this.idusuario = idusuario;
            base.cargarDatosEliminados("usuarios", idusuario, "idusuario");
        }

        public usuarios(List<string> c, List<string> v)
        {
            base.busquedaDatos(c, v, "usuarios");
        }

        public override List<string> generarCampos()
        {
            List<string> campos = new List<string>();
            campos.Add("usuario");
            campos.Add("contrasena");
            campos.Add("idempleado_sucursal");
            campos.Add("idgrupo");
            campos.Add("fecha_creacion");
            campos.Add("estado");

            return campos;
        }

        public override List<string> generarValores()
        {
            List<string> valores = new List<string>();
            valores.Add(usuario);
            valores.Add(contrasena);
            valores.Add(idempleado_sucursal);
            valores.Add(idgrupo);
            valores.Add(fecha_creacion);
            valores.Add(estado);

            return valores;
        }

        public static DataTable datos_Usuario(String usuario, String contra)
        {
            DataTable datos = new DataTable();

            String consulta = @"select u.usuario, concat(e.nombres, ' ', e.apellidos) as nomEmplea, e.genero, g.nombre, c.nombre_cargo, g.idgrupo, u.idusuario 
                                from usuarios u, empleados_sucursales es, grupos g, sucursales s, empleados e, cargos c
                                where u.idempleado_sucursal=es.idempleado_sucursal and u.idgrupo=g.idgrupo and
                                es.idsucursal=s.idsucursal and es.idempleado=e.idempleado and e.idcargo=c.idcargo and u.usuario='" + usuario+@"' and u.contrasena=md5('"+contra+ @"') and u.estado=1
                                ;";

            operaciones bd = new operaciones();

            try
            {
                datos = bd.mostrarTabla(consulta);
            }
            catch
            {
                datos = new DataTable();
            }

            return datos;
        }

        public static DataTable permisosAsigandosConfiguracion(string idgrupo)
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"select  p.nombre_control
                from permisos_grupos pg, grupos g, permisos p
                where pg.idgrupo = g.idgrupo and pg.idpermiso = p.idpermiso and pg.idgrupo = '"+idgrupo+ @"' and p.nombre_control like 'p%'
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

        public static DataTable permisosAsigandosInicio(string idgrupo)
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"select  p.nombre_control
                from permisos_grupos pg, grupos g, permisos p
                where pg.idgrupo = g.idgrupo and pg.idpermiso = p.idpermiso and pg.idgrupo = '" + idgrupo + @"' and p.nombre_control like 'btn%'
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

        public static DataTable permisosAsigandosNegocio(string idgrupo)
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"select  p.nombre_control
                from permisos_grupos pg, grupos g, permisos p
                where pg.idgrupo = g.idgrupo and pg.idpermiso = p.idpermiso and pg.idgrupo = '" + idgrupo + @"' and p.nombre_control like 'nego%'
                     ; ";
            Console.WriteLine(Consulta);
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

        public static DataTable permisosAsigandosInventario(string idgrupo)
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"select  p.nombre_control
                from permisos_grupos pg, grupos g, permisos p
                where pg.idgrupo = g.idgrupo and pg.idpermiso = p.idpermiso and pg.idgrupo = '" + idgrupo + @"' and p.nombre_control like 'inve%'
                     ; ";
            Console.WriteLine(Consulta);
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
            Consulta = @"select u.idusuario, u.usuario, u.idempleado_sucursal, concat(e.nombres,' ', e.apellidos) as nombres,
                        u.idgrupo, u.estado, g.nombre
                        from usuarios u, empleados_sucursales es, empleados e, sucursales s, grupos g
                        where u.idempleado_sucursal = es.idempleado_sucursal and u.idgrupo = g.idgrupo
                        and es.idempleado = e.idempleado and es.idsucursal = s.idsucursal
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

        public override long guardar(bool mensaje)
        {
            long id_guardado = 0;
            operaciones op = new operaciones();
            StringBuilder sentencia = new StringBuilder();
            
            sentencia.Append(@"INSERT INTO usuarios (usuario, contrasena, idempleado_sucursal, idgrupo, fecha_creacion, estado) 
                            VALUES ('"+usuario+"', md5('"+contrasena+"'), '"+idempleado_sucursal+"', '"+idgrupo+"', now(), '"+estado+"');");

            Console.WriteLine(sentencia.ToString());

            id_guardado = op.insertar(sentencia.ToString());

            if (mensaje)
            {
                if (id_guardado > 0)
                {
                    MessageBox.Show("El registro se ingreso correctamente", "Registro ingresado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo ingresar el registro", "No se pudo agregar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            return id_guardado;
        }

        public override int modificar(bool mensaje)
        {
            int id_guardado = 0;
            operaciones op = new operaciones();
            StringBuilder sentencia = new StringBuilder();

            sentencia.Append(@"UPDATE usuarios 
                             SET usuario='"+usuario+@"', 
                            idempleado_sucursal='"+idempleado_sucursal+@"',
                            idgrupo='"+idgrupo+@"',
                            estado='"+estado+@"' 
                             WHERE idusuario='"+idusuario+"';");
            Console.WriteLine(sentencia.ToString());

            id_guardado = op.actualizar(sentencia.ToString());

            if (mensaje)
            {
                if (id_guardado > 0)
                {
                    MessageBox.Show("El registro se ingreso correctamente", "Registro ingresado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo ingresar el registro", "No se pudo agregar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            return id_guardado;
        }

        public int modificarConCon(bool mensaje)
        {
            int id_guardado = 0;
            operaciones op = new operaciones();
            StringBuilder sentencia = new StringBuilder();

            sentencia.Append(@"UPDATE usuarios 
                             SET usuario='" + usuario + @"', 
                            contrasena=md5('"+contrasena+@"'),
                            idempleado_sucursal='" + idempleado_sucursal + @"',
                            idgrupo='" + idgrupo + @"',
                            estado='" + estado + @"' 
                             WHERE idusuario='" + idusuario + "';");
            Console.WriteLine(sentencia.ToString());

            id_guardado = op.actualizar(sentencia.ToString());

            if (mensaje)
            {
                if (id_guardado > 0)
                {
                    MessageBox.Show("El registro se ingreso correctamente", "Registro ingresado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo ingresar el registro", "No se pudo agregar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            return id_guardado;
        }

        public XmlNode crearUsuario(XmlDocument raiz)
        {
            XmlNode usuarios = raiz.CreateElement("usuario");

            XmlElement e1 = raiz.CreateElement("usuario");
            e1.InnerText = usuario;
            usuarios.AppendChild(e1);

            return usuarios;
        }
    }
}
