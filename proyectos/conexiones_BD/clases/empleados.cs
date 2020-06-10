using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace conexiones_BD.clases
{
    public class empleados:entidad
    {
        string idempleado, nombres, apellidos, dui, nit, genero, idcargo, telefono, correo;

        public empleados(string idempleado, string nombres, string apellidos, string dui, string nit, string genero, string idcargo, string telefono, string correo)
        {
            this.idempleado = idempleado;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.dui = dui;
            this.nit = nit;
            this.genero = genero;
            this.idcargo = idcargo;
            this.telefono = telefono;
            this.correo = correo;
            base.cargarDatosModificados(generarCampos(), generarValores(), "empleados", idempleado, "idempleado");
        }

        public empleados(string nombres, string apellidos, string dui, string nit, string genero, string idcargo, string telefono, string correo)
        {
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.dui = dui;
            this.nit = nit;
            this.genero = genero;
            this.idcargo = idcargo;
            this.telefono = telefono;
            this.correo = correo;
            base.cargarDatos(generarCampos(), generarValores(), "empleados");
        }

        public empleados(string idempleado)
        {
            this.idempleado = idempleado;
            base.cargarDatosEliminados("empleados", idempleado, "idempleado");
        }

        public empleados(List<string> c, List<string> v)
        {
            base.busquedaDatos(c, v, "empleados");
        }

        public override List<string> generarCampos()
        {
            List<string> campos = new List<string>();
            campos.Add("nombres");
            campos.Add("apellidos");
            campos.Add("dui");
            campos.Add("nit");
            campos.Add("genero");
            campos.Add("idcargo");
            campos.Add("telefono");
            campos.Add("correo");

            return campos;
        }

        public override List<string> generarValores()
        {
            List<string> valores = new List<string>();
            valores.Add(nombres);
            valores.Add(apellidos);
            valores.Add(dui);
            valores.Add(nit);
            valores.Add(genero);
            valores.Add(idcargo);
            valores.Add(telefono);
            valores.Add(correo);

            return valores;

        }

        public static DataTable datosTabla()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"select e.idempleado ,e.nombres, e.apellidos, e.dui, e.nit, e.idcargo, c.nombre_cargo, e. telefono, e.correo, 
                        e.genero, s.numero_de_sucursal, es.idempleado_sucursal, s.idsucursal
                        from  empleados_sucursales es, sucursales s ,empleados e, cargos c
                        where es.idempleado=e.idempleado and es.idsucursal=s.idsucursal and e.idcargo=c.idcargo
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
