using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace conexiones_BD.clases
{
    public class cuentas_proveedores:entidad
    {
        string idcuenta_proveedor, idproveedor, idbanco, numero_cuenta;

        public string Idproveedor
        {
            get
            {
                return idproveedor;
            }

            set
            {
                idproveedor = value;
            }
        }

        public cuentas_proveedores(string idcuenta_proveedor, string idproveedor, string idbanco, string numero_cuenta)
        {
            this.idcuenta_proveedor = idcuenta_proveedor;
            this.Idproveedor = idproveedor;
            this.idbanco = idbanco;
            this.numero_cuenta = numero_cuenta;
            base.cargarDatosModificados(generarCampos(), generarValores(), "cuentas_proveedores", idcuenta_proveedor, "idcuenta_proveedor");
        }

        public cuentas_proveedores(string idproveedor, string idbanco, string numero_cuenta)
        {
            this.Idproveedor = idproveedor;
            this.idbanco = idbanco;
            this.numero_cuenta = numero_cuenta;
            base.cargarDatos(generarCampos(), generarValores(), "cuentas_proveedores");
        }

        public cuentas_proveedores(string idcuenta_proveedor)
        {
            this.idcuenta_proveedor = idcuenta_proveedor;
            base.cargarDatosEliminados("cuentas_proveedores", idcuenta_proveedor, "idcuenta_proveedor");
        }

        public cuentas_proveedores(List<string> campos, List<string> valores)
        {
            base.busquedaDatos(campos, valores, "cuentas_proveedores");
        }

        public override List<string> generarCampos()
        {
            List<string> campos = new List<string>();
            campos.Add("idproveedor");
            campos.Add("idbanco");
            campos.Add("numero_cuenta");
            return campos;
        }

        public override List<string> generarValores()
        {
            List<string> valores = new List<string>();
            valores.Add(Idproveedor);
            valores.Add(idbanco);
            valores.Add(numero_cuenta);
            return valores;
        }

        public static DataTable datosTabla(string idprove)
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"select  cp.idcuenta_proveedor, b.nombre, cp.numero_cuenta, p.idproveedor, b.idbanco
                        from cuentas_proveedores cp, proveedores p, bancos b
                        where cp.idproveedor = p.idproveedor and cp.idbanco = b.idbanco and cp.idproveedor = '" + idprove+@"'
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

        public void cargarNevamente()
        {
            base.cargarDatos(generarCampos(), generarValores(), "cuentas_proveedores");
        }
    }
}
