using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace conexiones_BD.clases
{
    public class sucursales_productos: entidad
    {
        string idsucursal_producto, idsucursal, idproducto, idutilidadMayoreo, idutilidadDetalles, idestante, existencias, precio_ventaD, precio_compraD, precio_ventaM, precio_compraM, kardex;

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

        public sucursales_productos(string idsucursal_producto, string idsucursal, string idproducto, string idutilidadMayoreo, string idutilidadDetalle, string idestante, string existencias, string precio_ventaD, string precio_compraD, string precio_ventaM, string precio_compraM, string k)
        {
            this.idsucursal_producto = idsucursal_producto;
            this.idsucursal = idsucursal;
            this.Idproducto = idproducto;
            this.idutilidadMayoreo = idutilidadMayoreo;
            this.idutilidadDetalles = idutilidadDetalle;
            this.idestante = idestante;
            this.existencias = existencias;
            this.precio_ventaD = precio_ventaD;
            this.precio_compraD = precio_compraD;
            this.precio_ventaM = precio_ventaM;
            this.precio_compraM = precio_compraM;
            this.kardex = k;
            base.cargarDatosModificados(generarCampos(), generarValores(), "sucursales_productos", idsucursal_producto, "idsucursal_producto");
        }

        public sucursales_productos(string idsucursal, string idproducto, string idutilidadMayoreo, string idutilidadDetalle, string idestante, string existencias, string precio_ventaD, string precio_compraD, string precio_ventaM, string precio_compraM, string k)
        {
            this.idsucursal = idsucursal;
            this.Idproducto = idproducto;
            this.idutilidadMayoreo = idutilidadMayoreo;
            this.idutilidadDetalles = idutilidadDetalle;
            this.idestante = idestante;
            this.existencias = existencias;
            this.precio_ventaD = precio_ventaD;
            this.precio_compraD = precio_compraD;
            this.precio_ventaM = precio_ventaM;
            this.precio_compraM = precio_compraM;
            this.kardex = k;
            base.cargarDatos(generarCampos(), generarValores(), "sucursales_productos");
        }

        public sucursales_productos(string idsucursal_producto)
        {
            this.idsucursal_producto = idsucursal_producto;
            base.cargarDatosEliminados("sucursales_productos", idsucursal_producto, "idsucursal_producto");
        }

        public sucursales_productos(string idsu, string cantidadN)
        {
            idsucursal_producto = idsu;
            existencias = cantidadN;
        }

        public sucursales_productos(List<string> campos, List<string> valores)
        {
            base.busquedaDatos(campos, valores, "sucursales_productos");
        }

        public override List<string> generarCampos()
        {
            List<string> campos = new List<string>();
            campos.Add("idsucursal");
            campos.Add("idproducto");
            campos.Add("idutilidadMayoreo");
            campos.Add("idutilidadDetalles");
            campos.Add("idestante");
            campos.Add("existencias");
            campos.Add("precio_venta");
            campos.Add("precio_compra");
            campos.Add("precio_ventaM");
            campos.Add("precio_compraM");
            campos.Add("kardex");
            return campos;
        }

        public override List<string> generarValores()
        {
            List<string> valores = new List<string>();
            valores.Add(idsucursal);
            valores.Add(Idproducto);
            valores.Add(idutilidadMayoreo);
            valores.Add(idutilidadDetalles);
            valores.Add(idestante);
            valores.Add(existencias);
            valores.Add(precio_ventaD);
            valores.Add(precio_compraD);
            valores.Add(precio_ventaM);
            valores.Add(precio_compraM);
            valores.Add(kardex);
            return valores;     
        }

        public void cargarNevamente()
        {
            base.cargarDatos(generarCampos(), generarValores(), "sucursales_productos");
        }

        public StringBuilder sentenciaModi()
        {
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("UPDATE sucursales_productos SET idsucursal='"+idsucursal+"', idproducto='"+idproducto+"', idutilidadMayoreo='"+idutilidadMayoreo+"', idutilidadDetalles='"+idutilidadDetalles+"', idestante='"+idestante+"', existencias='"+existencias+"', precio_venta='"+precio_ventaD+"', precio_compra='"+precio_compraD+"', precio_ventaM='"+precio_ventaM+"', precio_compraM='"+precio_compraM+ "', kardex='" + kardex + "' WHERE idsucursal_producto='" + idsucursal_producto+"';");
            return sentencia;
        }

        public StringBuilder sentenciaElim()
        {
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("DELETE FROM sucursales_productos WHERE idsucursal_producto='"+idsucursal_producto+"';");
            return sentencia;
        }

        public StringBuilder modificarExistenciaProducto()
        {
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("UPDATE sucursales_productos SET existencias='" + existencias + "' WHERE idsucursal_producto='" + idsucursal_producto + "';");
            return sentencia;
        }


    }
}
