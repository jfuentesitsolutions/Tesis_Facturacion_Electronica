using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace conexiones_BD.clases
{
    public class productos: entidad 
    {
        string idproducto, nom_producto, fecha_ingreso, idcategoria, idmarca;

        public productos(string np, string fp, string ic, string idm)
        {
            this.nom_producto = np;
            this.fecha_ingreso = fp;
            this.idcategoria = ic;
            this.idmarca = idm;

            base.cargarDatos(generarCampos(), generarValores(), "productos");
            
        }

        public productos(string np, string fp, string ic, string idm, string id)
        {
            this.nom_producto = np;
            this.fecha_ingreso = fp;
            this.idcategoria = ic;
            this.idmarca = idm;
            this.idproducto = id;

            base.cargarDatosModificados(generarCampos(), generarValores(), "productos", idproducto, "idproducto");

        }

        public productos(string id)
        {
            this.idproducto = id;
            base.cargarDatosEliminados("productos", this.idproducto, "idproducto");
        }

        public productos(List<String> c, List<String> v)
        {
            base.busquedaDatos(c, v, "productos");
        }

        public static DataTable CARGAR_TABLA_PRODUCTOS_X_SUCURSAL(string idsuc)
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"select sp.idsucursal_producto as idSp, p.idproducto as idP ,p.cod_producto as codP,p.nom_producto as nombreP,
                        c.idcategoria as idC, c.nombre_categoria as nombreC, m.idmarca as idM, m.nombre as nombreM,
                        s.idsucursal as idS, s.numero_de_sucursal as numeroS, e.idestante as idE, e.nombre as nombreE,
                        p.fecha_ingreso as fechaI, ucc.idtipo_compra as idUtiM, ucc.nombre as UtiM, ucc.porcentaje as PUtiM,
                        uc.idutilidad_compra as idUtiD, uc.nombre as UtiD, uc.porcentaje as PUtiD,
                        sp.precio_compraM as precioCM, sp.precio_compra as precioCD, sp.precio_ventaM as precioVM, sp.precio_venta as precioVD, sp.existencias as exis, sp.kardex
                        from sucursales_productos sp, sucursales s, productos p, utilidades_compras uc, utilidades_compras ucc ,estantes e, categorias c, marcas m
                        where sp.idsucursal=s.idsucursal 
                        and sp.idproducto=p.idproducto 
                        and sp.idutilidadDetalles=uc.idutilidad_compra 
                        and sp.idutilidadMayoreo=ucc.idutilidad_compra
                        and sp.idestante=e.idestante and sp.idsucursal='" + idsuc+@"'
                        and p.idcategoria=c.idcategoria
                        and p.idmarca=m.idmarca
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

        public static DataTable CARGAR_TABLA_PRODUCTOS()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"select sp.idsucursal_producto as idSp, p.idproducto as idP ,codi.codigo as codP, p.nom_producto as nombreP,
                            c.idcategoria as idC, c.nombre_categoria as nombreC, m.idmarca as idM, m.nombre as nombreM,
                            s.idsucursal as idS, s.numero_de_sucursal as numeroS, e.idestante as idE, e.nombre as nombreE,
                            p.fecha_ingreso as fechaI, ucc.idutilidad_compra as idUtiM, ucc.nombre as UtiM, ucc.porcentaje as PUtiM,
                            uc.idutilidad_compra as idUtiD, uc.nombre as UtiD, uc.porcentaje as PUtiD,
                            sp.precio_compraM as precioCM, sp.precio_compra as precioCD, sp.precio_ventaM as precioVM, sp.precio_venta as precioVD, sp.existencias as exis, sp.kardex
                            from sucursales_productos sp, sucursales s, productos p, utilidades_compras uc, utilidades_compras ucc ,estantes e, categorias c, marcas m, codigos codi, productos_codigos proco
                            where sp.idsucursal=s.idsucursal 
                            and proco.idproducto=p.idproducto
                            and proco.idcodigo=codi.idcodigo
                            and sp.idproducto=p.idproducto 
                            and sp.idutilidadDetalles=uc.idutilidad_compra 
                            and sp.idutilidadMayoreo=ucc.idutilidad_compra
                            and sp.idestante=e.idestante
                            and p.idcategoria=c.idcategoria
                            and p.idmarca=m.idmarca
                            group by nombreP
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

        public override List<string> generarCampos()
        {
            List<String> nombre_campos = new List<string>();
            nombre_campos.Add("nom_producto");
            nombre_campos.Add("fecha_ingreso");
            nombre_campos.Add("idcategoria");
            nombre_campos.Add("idmarca");

            return nombre_campos;
        }

        public override List<string> generarValores()
        {
            List<String> valor = new List<string>();
            valor.Add(this.nom_producto);
            valor.Add(this.fecha_ingreso);
            valor.Add(this.idcategoria);
            valor.Add(this.idmarca);

            return valor;
        }

        public StringBuilder sentenciaModi()
        {
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("UPDATE productos SET nom_producto='"+nom_producto+"', fecha_ingreso='"+fecha_ingreso+"', idcategoria='"+idcategoria+"', idmarca='"+idmarca+"' WHERE idproducto='"+idproducto+"';");
            return sentencia;
        }

        public StringBuilder sentenciaElim()
        {
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("DELETE FROM productos WHERE idproducto='"+idproducto+"';");
            return sentencia;
        }

        public static DataTable CARGAR_TABLA_PRODUCTOS_X_SUCURSAL_VENTA(string idsuc)
        {
            
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"select pp.idsucursal_producto as idsp ,codi.codigo as codigo, pr.nom_producto as nombre, count(*) as cantipre, concat(codi.codigo,' < -|-> ',pr.nom_producto) as productoCod,
                            pp.precio, sp.existencias, p.nombre_presentacion as prese, pp.idpresentacion_producto as prepro, u.porcentaje as ud, uu.porcentaje as um,
                            pp.tipo, concat('$',pp.precio) as pre, u.idutilidad_compra as idud, uu.idutilidad_compra as idum
                            from presentaciones_productos pp, sucursales_productos sp, presentaciones p, productos pr, utilidades_compras u, utilidades_compras uu, codigos codi, productos_codigos proco
                            where pp.idsucursal_producto = sp.idsucursal_producto 
                            and proco.idproducto=pr.idproducto
                            and proco.idcodigo=codi.idcodigo
                            and pp.idpresentacion = p.idpresentacion 
                            and sp.idproducto = pr.idproducto
                            and sp.idutilidadDetalles = u.idutilidad_compra 
                            and sp.idutilidadMayoreo = uu.idutilidad_compra
                            and codi.estado=1
                            and pp.estado=1
                            group by codi.codigo
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

        public static DataTable CARGAR_TABLA_PRODUCTOS_VENT()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"select pp.idsucursal_producto as idsp ,codi.codigo as codigo, pr.nom_producto as nombre, count(*) as cantipre, concat(codi.codigo,' < -|-> ',pr.nom_producto) as productoCod,
                            pp.precio, sp.existencias, p.nombre_presentacion as prese, pp.idpresentacion_producto as prepro, u.porcentaje as ud, uu.porcentaje as um,
                            pp.tipo, concat('$',pp.precio) as pre, u.idutilidad_compra as idud, uu.idutilidad_compra as idum, pr.idproducto, pr.idmarca, pr.idcategoria, sp.idestante, sp.kardex, pr.fecha_ingreso,
                            sp.idutilidadMayoreo, sp.idutilidadDetalles, sp.precio_venta, sp.precio_compra, sp.precio_ventaM, sp.precio_compraM
                            from presentaciones_productos pp, sucursales_productos sp, presentaciones p, productos pr, utilidades_compras u, utilidades_compras uu, codigos codi, productos_codigos proco
                            where pp.idsucursal_producto = sp.idsucursal_producto 
                            and proco.idproducto=pr.idproducto
                            and proco.idcodigo=codi.idcodigo
                            and pp.idpresentacion = p.idpresentacion 
                            and sp.idproducto = pr.idproducto
                            and sp.idutilidadDetalles = u.idutilidad_compra and sp.idutilidadMayoreo = uu.idutilidad_compra
                            group by pr.nom_producto
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

        public static DataTable CARGAR_TABLA_PRODUCTOS_X_PRESENTACION_X_SUCURSAL_VENTA(string idsuc)
        {

            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"select pp.idsucursal_producto as idsp ,codi.codigo as codigo, pr.nom_producto as nombre,
                            pp.precio, sp.existencias, p.nombre_presentacion as prese, pp.idpresentacion_producto as prepro, u.porcentaje as ud, uu.porcentaje as um,
                            pp.tipo, pp.cantidad_unidades as cin
                            from presentaciones_productos pp, sucursales_productos sp, presentaciones p, productos pr, utilidades_compras u, utilidades_compras uu, codigos codi, productos_codigos proco
                            where pp.idsucursal_producto=sp.idsucursal_producto 
                            and proco.idproducto=pr.idproducto
                            and proco.idcodigo=codi.idcodigo
                            and pp.idpresentacion=p.idpresentacion 
                            and sp.idproducto=pr.idproducto
                            and sp.idutilidadDetalles=u.idutilidad_compra 
                            and sp.idutilidadMayoreo=uu.idutilidad_compra
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

        public static DataTable CARGAR_TABLA_PRODUCTOS_VENT_X_PRESENTACION()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"select pp.idsucursal_producto as idsp ,pr.cod_producto as codigo, pr.nom_producto as nombre,
                        pp.precio, sp.existencias, p.nombre_presentacion as prese, pp.idpresentacion_producto as prepro, u.porcentaje as ud, uu.porcentaje as um,
                        pp.tipo, pp.cantidad_unidades as cin
                        from presentaciones_productos pp, sucursales_productos sp, presentaciones p, productos pr, utilidades_compras u, utilidades_compras uu
                        where pp.idsucursal_producto=sp.idsucursal_producto and pp.idpresentacion=p.idpresentacion and sp.idproducto=pr.idproducto
                        and sp.idutilidadDetalles=u.idutilidad_compra and sp.idutilidadMayoreo=uu.idutilidad_compra
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

        public static DataTable EXISTENCIAS_PRODUCTOS_X_IDVENTA(string idventa)
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"select sp.existencias, sp.idsucursal_producto, dvt.cantidad
                            from ventas v, detalles_ventas_ticket dvt, sucursales_productos sp
                            where v.idventa_ticket=dvt.idventa_ticket
                            and dvt.idsucursal_producto=sp.idsucursal_producto
                            and v.anulacion=1
                            and v.idventa='"+idventa+@"'
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
