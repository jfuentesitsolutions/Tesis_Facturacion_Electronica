using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace conexiones_BD.clases
{
    public class proveedores_productos:entidad
    {
        string idproveedor_producto, idproveedor, idproducto;

        public string Idproducto
        {
            get
            {
                return idproducto;
            }

            set
            {
                idproducto = value;
            }
        }

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

        public proveedores_productos(string idproveedor_producto, string idproveedor, string idproducto)
        {
            this.idproveedor_producto = idproveedor_producto;
            this.Idproveedor = idproveedor;
            this.Idproducto = idproducto;
            base.cargarDatosModificados(generarCampos(), generarValores(), "proveedores_productos", idproveedor_producto, "idproveedor_producto");
        }

        public proveedores_productos(string idproveedor, string idproducto)
        {
            this.Idproveedor = idproveedor;
            this.Idproducto = idproducto;
            base.cargarDatos(generarCampos(), generarValores(), "proveedores_productos");
        }

        public proveedores_productos(string idproveedor_producto)
        {
            this.idproveedor_producto = idproveedor_producto;
            base.cargarDatosEliminados("proveedores_productos", idproveedor_producto, "idproveedor_producto");

        }

        public proveedores_productos(List<string> campos, List<string> valores)
        {
            base.busquedaDatos(campos, valores, "proveedores_productos");
        }

        public override List<string> generarCampos()
        {
            List<string> campos = new List<string>();
            campos.Add("idproveedor");
            campos.Add("idproducto");
            return campos;
        }

        public override List<string> generarValores()
        {
            List<string> valores = new List<string>();
            valores.Add(Idproveedor);
            valores.Add(Idproducto);

           
            return valores;
        }

        public void cargarNevamente()
        {
            base.cargarDatos(generarCampos(), generarValores(), "proveedores_productos");
        }

        public static DataTable datosTabla(string idpro)
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"select pp.idproveedor_producto, pp.idproveedor, p.nombre_proveedor, pr.idproducto
                        from proveedores_productos pp, proveedores p, productos pr
                        where pp.idproveedor = p.idproveedor and pp.idproducto = pr.idproducto and pp.idproducto = '"+idpro+@"'
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
