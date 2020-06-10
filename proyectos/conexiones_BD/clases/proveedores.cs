using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace conexiones_BD.clases
{
    public class proveedores: entidad
    {
        string idproveedor, cod_proveedor, nombre_proveedor, dui, nit, ncr, direccion, telefono, email;

        public proveedores(string idproveedor, string cod_proveedor, string nombre_proveedor, string dui, string nit, string ncr, string direccion, string telefono, string email)
        {
            this.idproveedor = idproveedor;
            this.cod_proveedor = cod_proveedor;
            this.nombre_proveedor = nombre_proveedor;
            this.dui = dui;
            this.nit = nit;
            this.ncr = ncr;
            this.direccion = direccion;
            this.telefono = telefono;
            this.email = email;
            base.cargarDatosModificados(generarCampos(), generarValores(), "proveedores", idproveedor, "idproveedor");
        }

        public proveedores(string cod_proveedor, string nombre_proveedor, string dui, string nit, string ncr, string direccion, string telefono, string email)
        {
            this.cod_proveedor = cod_proveedor;
            this.nombre_proveedor = nombre_proveedor;
            this.dui = dui;
            this.nit = nit;
            this.ncr = ncr;
            this.direccion = direccion;
            this.telefono = telefono;
            this.email = email;
            base.cargarDatos(generarCampos(), generarValores(), "proveedores");
        }

        public proveedores(string idproveedor)
        {
            this.idproveedor = idproveedor;
            base.cargarDatosEliminados("proveedores", idproveedor, "idproveedor");
        }

        public proveedores(List<string> campos, List<string> valores)
        {
            base.busquedaDatos(campos, valores, "proveedores");
        }

        public override List<string> generarCampos()
        {
            List<string> campos = new List<string>();
            campos.Add("cod_proveedor");
            campos.Add("nombre_proveedor");
            campos.Add("dui");
            campos.Add("nit");
            campos.Add("ncr");
            campos.Add("direccion");
            campos.Add("telefono");
            campos.Add("email");
            return campos;
        }

        public override List<string> generarValores()
        {
            List<string> valores = new List<string>();
            valores.Add(cod_proveedor);
            valores.Add(nombre_proveedor);
            valores.Add(dui);
            valores.Add(nit);
            valores.Add(ncr);
            valores.Add(direccion);
            valores.Add(telefono);
            valores.Add(email);
            return valores;
        }

        public static DataTable datosTabla()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = "select * from proveedores;";
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
