using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using conexiones_BD;

namespace cache_manager
{
    public class cache
    {
        public static DataTable datos_Usuario(String usuario, String contra)
        {
            DataTable datos = new DataTable();

            String consulta = @"select u.idusuario, u.usuario, u.contrase, 
                            concat(e.nombres,' ',e.apellidos) as nombre, e.telefono, g.idgrupo, g.nombre_grupo, e.idempleado
                            from usuarios u, empleados e, grupos g
                            where
                            u.idempleado = e.idempleado and
                            u.idgrupo = g.idgrupo and
                            u.usuario = '" + usuario + @"' and 
                            u.contrase = md5('" + contra + @"') and
                            u.estado = 1
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

        public static DataTable TODOS_LOS_USUARIOS()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"select u.idusuario, u.usuario, concat(e.nombres, ' ', e.apellidos) as nombre, g.nombre_grupo as grupo, u.fecha_creacion, u.idempleado, g.idgrupo
                        from usuarios u, empleados e, grupos g
                        where u.idgrupo=g.idgrupo and u.idempleado=e.idempleado and u.estado=1
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

        public static DataTable TODOS_LOS_EMPLEADOS()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = "select * from empleados";
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

        public static DataTable TODOS_LOS_CATALOGOS()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"select * from catalogo;";
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

        public static DataTable TODAS_LAS_CATEGORIAS()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"select * from categorias;";
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

        public static DataTable TODOS_LOS_PROVEEDORES()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"select * from proveedores;";
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

        public static DataTable CATEGORIAS(string idproveedor)
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"select  pc.idproveedor_categoria as id, c.idcategoria, c.nombre, p.nombre_comercial
                        from categorias c, proveedores p, proveedores_categorias pc
                        where pc.idproveedor=p.idproveedor and pc.idcategoria=c.idcategoria and pc.idproveedor='"+idproveedor+@"'
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

        public static DataTable TODOS_LOS_PRODUCTOS()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"select p.idproducto, p.cod_producto, p.nombre_producto, p.precio_compra, concat('$ ',p.precio_compra) as precio, c.codigo_presupuestario, c.idcatalogo
                        , p.existencia, pp.nombre_comercial, pp.idproveedor, p.fecha_creacion
                        from productos p, catalogo c, proveedores pp
                        where p.idcatalogo=c.idcatalogo and p.idproveedor=pp.idproveedor
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

        public static DataTable TODOS_LOS_PRODUCTOS2()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"select p.idproducto, p.cod_producto, p.nombre_producto, p.precio_compra, p.idcatalogo, p.existencia, p.idproveedor,
                        pp.nombre_comercial, c.descripcion
                        from productos p, proveedores pp, catalogo c
                        where p.idcatalogo=c.idcatalogo and p.idproveedor=pp.idproveedor
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

        public static DataTable TODOS_LOS_TIPOS_DE_DOCUMENTOS()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"select * from tipos_documentos;";
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

        public static DataTable TODAS_LAS_UNIDADES()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"select u.idunidad, u.nombre 
                        from unidades u;";
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

        public static DataTable ENTRADAS_NO_VALIDADAS()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"select e.identrada, e.fecha_entrada, e.numero_documento, e.precio_total, e.descuento, e.precio_con_descuento, p.nombre_comercial, td.nombre_documento 
                        from entradas e, proveedores p, tipos_documentos td 
                        where e.idproveedor=p.idproveedor and e.id_tipo_documento=td.idtipo_documento and e.aprovacion=2; ";
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

        public static DataTable REQUISICIONES_NO_ENTREGADAS()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"select s.idsalida from salidas s where s.entregado=2; ";
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

        public static DataTable NUMEROS_DOCUMENTOS()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"select e.numero_documento as numero
                        from entradas e  where e.aprovacion='2';";
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

        public static DataTable DOCUMENTO(String docum)
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"select e.id_tipo_documento,e.numero_documento,e.fecha_entrada,e.idproveedor, pp.nombre_comercial , e.descuento, e.precio_total, e.precio_con_descuento, e.aprovacion, e.entregado,
                        ep.identrada_producto,  p.nombre_producto, ep.cantidad, ep.precio_compra, ep.precio_total, ep.idproducto, p.existencia
                        from entradas_productos ep, productos p, entradas e, proveedores pp
                        where ep.identrada=e.identrada and ep.idproducto=p.idproducto and e.idproveedor=pp.idproveedor 
                        and e.aprovacion=2
                        and e.identrada='" + docum+@"'
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

        public static DataTable DOCUMENTO2(String docum)
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"select e.id_tipo_documento,e.numero_documento,e.fecha_entrada,e.idproveedor, pp.nombre_comercial , e.descuento, e.precio_total, e.precio_con_descuento, e.aprovacion, e.entregado,
                        ep.identrada_producto,  p.nombre_producto, ep.cantidad, ep.precio_compra, ep.precio_total, ep.idproducto, p.existencia
                        from entradas_productos ep, productos p, entradas e, proveedores pp
                        where ep.identrada=e.identrada and ep.idproducto=p.idproducto and e.idproveedor=pp.idproveedor 
                        and e.anulado=2
                        and e.identrada='" + docum + @"'
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

        public static DataTable REQUISICION(String docum)
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"select s.idsalida, s.fecha_salida, s.numero_requisicion, s.idunidad, s.cantidad_total, s.justificacion, sp.idsalida_producto,sp. cantidad ,p.idproducto, p.nombre_producto, p.existencia 
                        from salidas_productos sp, salidas s, productos p
                        where sp.idsalida=s.idsalida and sp.idproducto=p.idproducto and sp.idsalida='"+docum+@"';
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

        public static DataTable PRODUCTOS_DOCUMENTO(String docum)
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"select ep.identrada_producto, ep.cantidad, ep.precio_compra, ep.precio_total,ep.identrada,p.idproducto, p.nombre_producto, p.existencia
                        from entradas_productos ep, productos p
                        where ep.idproducto=p.idproducto and identrada='" + docum+@"'
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

        public static DataTable PRODUCTOS_DOCUMENTO2(String docum)
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"select sp.idsalida_producto, sp.cantidad, p.idproducto, p.nombre_producto, p.existencia
                        from salidas_productos sp, productos p
                        where sp.idproducto=p.idproducto and sp.idsalida='"+docum+@"'
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

        public static DataTable TODAS_LAS_REQUISCIONES()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"select s.idsalida as id, s.fecha_salida as fecha, s.numero_requisicion as numero, s.cantidad_total as total,
                        s.idunidad as idu, u.nombre, s.justificacion
                        from salidas s, unidades u
                        where s.idunidad=u.idunidad and s.entregado=2;
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

        public static DataTable PROVEEDOR(string id)
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"select * from proveedores where idproveedor='"+id+"';";
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

        public static DataTable MOVIMIENTO_ENTRADAS_PRODUCTOS(string id)
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"select e.fecha_entrada, e.numero_documento, ep.cantidad, ep.precio_compra, ep.precio_total, t.nombre_documento,pp.nombre_comercial ,u.usuario, ve.fecha, e.anulado
                        from entradas_productos ep, entradas e, proveedores pp, productos p, tipos_documentos t, validaciones_entradas ve, usuarios u
                        where ep.identrada=e.identrada and ep.idproducto=p.idproducto and e.id_tipo_documento=t.idtipo_documento and e.idproveedor=pp.idproveedor
                        and ve.identrada=e.identrada and ve.idusuario=u.idusuario and ep.idproducto='" + id+@"' order by e.fecha_entrada desc
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

        public static DataTable MOVIMIENTO_SALIDAS_PRODUCTOS(string id)
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"select s.fecha_salida, s.numero_requisicion, s.cantidad_total, s.justificacion, u.nombre,  vs.fecha, us.usuario, s.anulado
                        from salidas_productos sp, salidas s, unidades u, productos p, validaciones_salidas vs, usuarios us
                        where sp.idsalida=s.idsalida and sp.idproducto=p.idproducto and s.idunidad=u.idunidad and vs.idsalida=s.idsalida and vs.idusuario=us.idusuario
                        and sp.idproducto='" + id+@"' order by s.fecha_salida desc
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

        public static DataTable ENTRADAS_SIN_ANULAR()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"select s.identrada, s.fecha_entrada,  s.id_tipo_documento, td.nombre_documento, s.numero_documento, s.precio_total, s.descuento, s.precio_con_descuento,
                        p.nombre_comercial, s.idproveedor
                        from entradas s, tipos_documentos td, proveedores p
                        where s.id_tipo_documento = td.idtipo_documento and s.idproveedor = p.idproveedor and s.anulado = 2 and s.aprovacion = 1;
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

        public static DataTable SALIDAS_SIN_ANULAR()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"select s.idsalida, s.fecha_salida, s.idunidad, u.nombre, s.numero_requisicion, s.cantidad_total, s.justificacion
                        from salidas s, unidades u
                        where s.idunidad=u.idunidad and s.anulado=2 and s.entregado=1
                        ;
                        ";
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

        public static DataTable SALIDAS_ANULADAS()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"select ass.idanulacion_salida, s.numero_requisicion, uu.nombre, u.usuario, ass.fecha, ass.justificacion
                            from anulaciones_salidas ass, salidas s, usuarios u, unidades uu
                            where ass.idsalida=s.idsalida and s.idunidad=uu.idunidad and ass.idusuario=u.idusuario
                            ;
                        ";
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


        public static DataTable ENTRADAS_ANULADAS()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"select ae.idanulacion_entrada,e.numero_documento,p.nombre_comercial,u.usuario,ae.fecha, ae.justificacion 
                        from anulaciones_entradas ae, entradas e, usuarios u, proveedores p
                        where ae.identrada=e.identrada and ae.idusuario=u.idusuario and e.idproveedor=p.idproveedor
                        order by ae.fecha desc                        
                        ;
                        ";
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
