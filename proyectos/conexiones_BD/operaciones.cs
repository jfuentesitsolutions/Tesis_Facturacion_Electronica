using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace conexiones_BD
{
    public class operaciones : Conexion
    {
        sessionManager.secion sesion = sessionManager.secion.Instancia;
        //transacciones y sentencias
        private Int32 Ejecutarsentencia(string sentencia)
        {
            Int32 numeroFilas = 0;

            if (base.conectar())
            {
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = base.Conec;
                comando.CommandText = sentencia;
                try
                {
                    numeroFilas = comando.ExecuteNonQuery();
                }
                catch
                {
                    numeroFilas = 0;
                }
            }

            return numeroFilas;
        }

        private DataTable Ejecutarconsulta(string sentencia)
        {
            DataTable resultado = new DataTable();
            try
            {
                if (base.conectar())
                {
                    MySqlCommand comando = new MySqlCommand();
                    MySqlDataAdapter adaptador = new MySqlDataAdapter();
                    comando.Connection = base.Conec;
                    comando.CommandText = sentencia;
                    comando.CommandType = CommandType.Text;
                    adaptador.SelectCommand = comando;
                    adaptador.Fill(resultado);
                }
            }
            catch (Exception e)
            {
                resultado = new DataTable();
                Console.Write(e.Message);
            }

            return resultado;
        }

        private DataTable comprasClientes(string fi, string ff, int id)
        {
            DataTable resultado = new DataTable();
            try
            {
                if (base.conectar())
                {
                    MySqlCommand comando = new MySqlCommand("comprarXcliente", base.Conec);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("fecha_inicial",fi);
                    comando.Parameters.AddWithValue("fecha_final", ff);
                    comando.Parameters.AddWithValue("id", id);
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                    adaptador.Fill(resultado);

                }
            }
            catch (Exception e)
            {
                resultado = new DataTable();
                Console.Write(e.Message);
            }

            return resultado;
        }
        private DataTable estadisticasCaja(int id)
        {
            DataTable resultado = new DataTable();
            try
            {
                if (base.conectar())
                {
                    MySqlCommand comando = new MySqlCommand("ESTADISTICAS_CAJA", base.Conec);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("id", id);
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                    adaptador.Fill(resultado);

                }
            }
            catch (Exception e)
            {
                resultado = new DataTable();
                Console.Write(e.Message);
            }

            return resultado;
        }
        private DataTable estadisticasClientes(string fi, string ff)
        {
            DataTable resultado = new DataTable();
            try
            {
                if (base.conectar())
                {
                    MySqlCommand comando = new MySqlCommand("estadisticaXcomprasClientes", base.Conec);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("fecha_inicial", fi);
                    comando.Parameters.AddWithValue("fecha_final", ff);
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                    adaptador.Fill(resultado);

                }
            }
            catch (Exception e)
            {
                resultado = new DataTable();
                Console.Write(e.Message);
            }

            return resultado;
        }
        private DataTable estadisticasTodosLosClientes(string fi, string ff)
        {
            DataTable resultado = new DataTable();
            try
            {
                if (base.conectar())
                {
                    MySqlCommand comando = new MySqlCommand("estadisticaXcompras", base.Conec);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("fecha_inicial", fi);
                    comando.Parameters.AddWithValue("fecha_final", ff);
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                    adaptador.Fill(resultado);

                }
            }
            catch (Exception e)
            {
                resultado = new DataTable();
                Console.Write(e.Message);
            }

            return resultado;
        }
        private long Ejecutarsentencia2(string sentencia)
        {
            long numero_insertado = 0;

            if (base.conectar())
            {
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = base.Conec;
                comando.CommandText = sentencia;


                try
                {
                    comando.ExecuteNonQuery();
                    numero_insertado = comando.LastInsertedId;

                }
                catch
                {
                    numero_insertado = 0;
                }
            }




            return numero_insertado;
        }
        private Int32 EjecutartransaccionPermisos_grupos(List<conexiones_BD.clases.permisos_grupos> per, conexiones_BD.clases.grupos gru)
        {
            Int32 numeroFilas = 1;
            MySqlTransaction trans = null;
            long res = 0;

            if (base.conectar())
            {

                try
                {
                    trans = base.Conec.BeginTransaction();
                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = base.Conec;
                    comando.Transaction = trans;

                    comando.CommandText = gru.sentenciaIngresar();
                    comando.ExecuteNonQuery();
                    res = comando.LastInsertedId;
                    Console.WriteLine(res.ToString());

                    foreach (clases.permisos_grupos c in per)
                    {
                        c.Idgrupo = res.ToString();
                        c.cargarNevamente();
                        comando.CommandText = c.sentenciaIngresar();
                        Console.WriteLine(c.sentenciaIngresar());
                        comando.ExecuteNonQuery();
                    }

                    trans.Commit();
                    numeroFilas = Convert.ToInt32(res);

                }
                catch (MySqlException e)
                {
                    Console.WriteLine(e.Message);
                    trans.Rollback();
                    numeroFilas = -1;
                }
            }

            return numeroFilas;
        }
        private Int32 EjecutartransaccionEmpleados_sucursales(clases.empleados em, clases.empleados_sucursales es)
        {
            Int32 numeroFilas = 1;
            MySqlTransaction trans = null;
            long res = 0;

            if (base.conectar())
            {

                try
                {
                    trans = base.Conec.BeginTransaction();
                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = base.Conec;
                    comando.Transaction = trans;

                    comando.CommandText = em.sentenciaIngresar();
                    comando.ExecuteNonQuery();
                    res = comando.LastInsertedId;
                    Console.WriteLine(res.ToString());


                    es.Idempleado = res.ToString();
                    es.cargarNevamente();
                    comando.CommandText = es.sentenciaIngresar();
                    Console.WriteLine(es.sentenciaIngresar());
                    comando.ExecuteNonQuery();


                    trans.Commit();
                    numeroFilas = Convert.ToInt32(res);

                }
                catch (MySqlException e)
                {
                    Console.WriteLine(e.Message);
                    trans.Rollback();
                    numeroFilas = -1;
                }
            }

            return numeroFilas;
        }
        private Int32 EjecutartransaccionCuentas_Proveedores(List<conexiones_BD.clases.cuentas_proveedores> per, clases.proveedores es)
        {
            Int32 numeroFilas = 1;
            MySqlTransaction trans = null;
            long res = 0;

            if (base.conectar())
            {

                try
                {
                    trans = base.Conec.BeginTransaction();
                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = base.Conec;
                    comando.Transaction = trans;

                    comando.CommandText = es.sentenciaIngresar();
                    comando.ExecuteNonQuery();
                    res = comando.LastInsertedId;
                    Console.WriteLine(res.ToString());

                    foreach (clases.cuentas_proveedores c in per)
                    {
                        c.Idproveedor = res.ToString();
                        c.cargarNevamente();
                        comando.CommandText = c.sentenciaIngresar();
                        Console.WriteLine(c.sentenciaIngresar());
                        comando.ExecuteNonQuery();
                    }

                    trans.Commit();
                    numeroFilas = Convert.ToInt32(res);

                }
                catch (MySqlException e)
                {
                    Console.WriteLine(e.Message);
                    trans.Rollback();
                    numeroFilas = -1;
                }
            }

            return numeroFilas;
        }
        private Int32 EjecutartransaccionProductos_Presentaciones_Proveedores(List<clases.proveedores_productos> prove, List<clases.presentaciones_productos> prese, clases.productos pro, clases.sucursales_productos sp, clases.codigos co)
        {
            Int32 numeroFilas = 1;
            MySqlTransaction trans = null;
            long res, res1, res3 = 0;
            clases.productos_codigos pc;

            if (base.conectar())
            {
                try
                {
                    trans = base.Conec.BeginTransaction();
                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = base.Conec;
                    comando.Transaction = trans;

                    comando.CommandText = co.sentenciaIngresar();
                    comando.ExecuteNonQuery();
                    res3 = comando.LastInsertedId;
                    Console.WriteLine(res3.ToString());

                    comando.CommandText = pro.sentenciaIngresar();
                    comando.ExecuteNonQuery();
                    res = comando.LastInsertedId;
                    Console.WriteLine(res.ToString());
                    log_sentensias.escribirBinario(pro.sentenciaIngresar());

                    pc = new clases.productos_codigos(res.ToString(), res3.ToString());

                    comando.CommandText = pc.sentenciaIngresar();
                    comando.ExecuteNonQuery();
                    Console.WriteLine(pc.sentenciaIngresar());


                    foreach (clases.proveedores_productos c in prove)
                    {
                        c.Idproducto = res.ToString();
                        c.cargarNevamente();
                        comando.CommandText = c.sentenciaIngresar();
                        Console.WriteLine(c.sentenciaIngresar());
                        log_sentensias.escribirBinario(c.sentenciaIngresar());
                        comando.ExecuteNonQuery();
                    }

                    sp.Idproducto = res.ToString();
                    sp.cargarNevamente();
                    comando.CommandText = sp.sentenciaIngresar();
                    comando.ExecuteNonQuery();
                    res1 = comando.LastInsertedId;
                    Console.WriteLine(res1.ToString());

                    foreach (clases.presentaciones_productos c in prese)
                    {
                        c.Idsucursal_producto = res1.ToString();
                        c.cargarNevamente();
                        comando.CommandText = c.sentenciaIngresar();
                        Console.WriteLine(c.sentenciaIngresar());
                        comando.ExecuteNonQuery();
                    }

                    trans.Commit();
                    numeroFilas = Convert.ToInt32(res1);

                }
                catch (MySqlException e)
                {
                    Console.WriteLine(e.Message);
                    trans.Rollback();
                    numeroFilas = -1;
                }
            }

            return numeroFilas;
        }
        private Int32 EjecutartransaccionModificarProductos(conexiones_BD.clases.sucursales_productos sp, conexiones_BD.clases.productos p)
        {
            Int32 numeroFilas = 1;
            MySqlTransaction trans = null;

            if (base.conectar())
            {

                try
                {
                    trans = base.Conec.BeginTransaction();
                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = base.Conec;
                    comando.Transaction = trans;


                    comando.CommandText = sp.sentenciaModi().ToString();
                    comando.ExecuteNonQuery();
                    Console.WriteLine(sp.sentenciaModificar());

                    comando.CommandText = p.sentenciaModi().ToString();
                    comando.ExecuteNonQuery();
                    Console.WriteLine(p.sentenciaModificar());
                    log_sentensias.escribirBinario(p.sentenciaModificar());

                    trans.Commit();

                }
                catch (MySqlException e)
                {
                    Console.WriteLine(e.Message);
                    trans.Rollback();
                    numeroFilas = -1;
                }
            }

            return numeroFilas;
        }
        private Int32 EjecutartransaccionEliminarProductos(conexiones_BD.clases.sucursales_productos sp, conexiones_BD.clases.productos p)
        {
            Int32 numeroFilas = 1;
            MySqlTransaction trans = null;

            if (base.conectar())
            {

                try
                {
                    trans = base.Conec.BeginTransaction();
                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = base.Conec;
                    comando.Transaction = trans;


                    comando.CommandText = sp.sentenciaElim().ToString();
                    comando.ExecuteNonQuery();
                    Console.WriteLine(sp.sentenciaElim().ToString());

                    comando.CommandText = p.sentenciaElim().ToString();
                    comando.ExecuteNonQuery();
                    Console.WriteLine(p.sentenciaElim().ToString());

                    trans.Commit();

                }
                catch (MySqlException e)
                {
                    Console.WriteLine(e.Message);
                    trans.Rollback();
                    numeroFilas = -1;
                }
            }

            return numeroFilas;
        }
        // ejecuta la transaccion de la venta de tickets
        private clases.ctrl_errores.errores Ejecutartransaccion_Ventas_tickets(List<clases.ventas.detalles_productos_venta_ticket> dp, clases.ventas.tickets tic)
        {
            MySqlTransaction trans = null;

            clases.ctrl_errores.errores err = new clases.ctrl_errores.errores();

            if (base.conectar())
            {

                try
                {
                    trans = base.Conec.BeginTransaction();
                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = base.Conec;
                    comando.Transaction = trans;

                    comando.CommandText = tic.sentenciaIngresar();
                    comando.ExecuteNonQuery();
                    

                    foreach (clases.ventas.detalles_productos_venta_ticket p in dp)
                    {
                        p.Idventa_ticket = tic.Correlativo;
                        comando.CommandText = p.ingresarProducto();
                        Console.WriteLine(p.ingresarProducto());
                        comando.ExecuteNonQuery();
                    }

                    tic.IdDocu = tic.Correlativo;
                    comando.CommandText = tic.insertarVenta();
                    comando.ExecuteNonQuery();

                    trans.Commit();
                    err.Res = 1;

                }
                catch (MySqlException e)
                {
                    Console.WriteLine(e.Message);
                    trans.Rollback();
                    err.Res = -1;
                    err.Error = e.Message;
                }
            }

            return err;
        }
        // ejecuta la transaccion de la venta de factura
        private clases.ctrl_errores.errores Ejecutartransaccion_Ventas_factura(List<clases.ventas.detalles_productos_venta_factura> dp, clases.ventas.facturas fac)
        {
            MySqlTransaction trans = null;

            clases.ctrl_errores.errores err = new clases.ctrl_errores.errores();

            if (base.conectar())
            {

                try
                {
                    trans = base.Conec.BeginTransaction();
                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = base.Conec;
                    comando.Transaction = trans;

                    comando.CommandText = fac.sentenciaIngresar();
                    comando.ExecuteNonQuery();


                    foreach (clases.ventas.detalles_productos_venta_factura p in dp)
                    {
                        p.Idventa_factura = fac.Numero_factura;
                        comando.CommandText = p.ingresarProducto();
                        Console.WriteLine(p.ingresarProducto());
                        comando.ExecuteNonQuery();
                    }

                    fac.IdDocu = fac.Numero_factura;
                    Console.WriteLine(fac.insertarVenta());
                    comando.CommandText = fac.insertarVenta();
                    comando.ExecuteNonQuery();

                    trans.Commit();
                    err.Res = 1;

                }
                catch (MySqlException e)
                {
                    Console.WriteLine(e.Message);
                    trans.Rollback();
                    err.Res = -1;
                    err.Error = e.Message;
                }
            }

            return err;
        }
        private Int32 EjecutartransaccionAnulaVentaTickets(conexiones_BD.clases.ventas.tickets v, conexiones_BD.clases.ventas.anulaciones a, List<clases.sucursales_productos> pr)
        {
            Int32 numeroFilas = 1;
            MySqlTransaction trans = null;

            if (base.conectar())
            {

                try
                {
                    trans = base.Conec.BeginTransaction();
                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = base.Conec;
                    comando.Transaction = trans;


                    comando.CommandText = v.sentenciaModificaAnulacion().ToString();
                    comando.ExecuteNonQuery();
                    Console.WriteLine(v.sentenciaModificaAnulacion().ToString());

                    comando.CommandText = a.sentenciaIngresar();
                    comando.ExecuteNonQuery();
                    Console.WriteLine(a.sentenciaIngresar());

                    foreach (clases.sucursales_productos p in pr)
                    {
                        comando.CommandText = p.modificarExistenciaProducto().ToString();
                        Console.WriteLine(p.modificarExistenciaProducto().ToString());
                        comando.ExecuteNonQuery();
                    }

                    trans.Commit();

                }
                catch (MySqlException e)
                {
                    Console.WriteLine(e.Message);
                    trans.Rollback();
                    numeroFilas = -1;
                }
            }

            return numeroFilas;
        }
        private Int32 EjecutartransaccionCompras(clases.compras.facturas_compras c, clases.compras.compras cc, List<clases.compras.detalles_compras> com, Dictionary<string, List<clases.presentaciones_productos>> pr)
        {
            Int32 numeroFilas = 1;
            MySqlTransaction trans = null;
            long res = 0;

            if (base.conectar())
            {

                try
                {
                    trans = base.Conec.BeginTransaction();
                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = base.Conec;
                    comando.Transaction = trans;

                    //Insertando la factura
                    comando.CommandText = c.sentenciaIngresar();
                    comando.ExecuteNonQuery();
                    res = comando.LastInsertedId;
                    Console.WriteLine(c.sentenciaIngresar());

                    //Insertando la compra
                    cc.Idfactura = res.ToString();
                    comando.CommandText = cc.ingresarProducto();
                    comando.ExecuteNonQuery();
                    Console.WriteLine(cc.sentenciaIngresar());

                    //Insertando los productos comprados
                    foreach (clases.compras.detalles_compras dc in com)
                    {
                        dc.Idfactura_compra = res.ToString();
                        comando.CommandText = dc.ingresarDetalleCompra();
                        comando.ExecuteNonQuery();
                        Console.WriteLine(dc.sentenciaIngresar());
                    }

                    //modificado los precios de los productos
                    foreach (KeyValuePair<string, List<clases.presentaciones_productos>> listaa in pr)
                    {
                        foreach (clases.presentaciones_productos pre in listaa.Value)
                        {
                            comando.CommandText = pre.cambio_precios().ToString();
                            comando.ExecuteNonQuery();
                            Console.WriteLine(pre.cambio_precios().ToString());
                        }
                    }

                    trans.Commit();

                }
                catch (MySqlException e)
                {
                    Console.WriteLine(e.Message);
                    trans.Rollback();
                    numeroFilas = -1;
                }
            }

            return numeroFilas;
        }
        private Int32 EjecutartransaccionAnulaCompras(clases.compras.compras c, clases.compras.anulaciones_compras ac, List<clases.sucursales_productos> pr)
        {
            Int32 numeroFilas = 1;
            MySqlTransaction trans = null;

            if (base.conectar())
            {

                try
                {
                    trans = base.Conec.BeginTransaction();
                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = base.Conec;
                    comando.Transaction = trans;


                    comando.CommandText = c.sentenciaModificaAnulacion().ToString();
                    comando.ExecuteNonQuery();
                    Console.WriteLine(c.sentenciaModificaAnulacion().ToString());

                    comando.CommandText = ac.sentenciaIngresar();
                    comando.ExecuteNonQuery();
                    Console.WriteLine(ac.sentenciaIngresar());

                    foreach (clases.sucursales_productos p in pr)
                    {
                        comando.CommandText = p.modificarExistenciaProducto().ToString();
                        Console.WriteLine(p.modificarExistenciaProducto().ToString());
                        comando.ExecuteNonQuery();
                    }

                    trans.Commit();

                }
                catch (MySqlException e)
                {
                    Console.WriteLine(e.Message);
                    trans.Rollback();
                    numeroFilas = -1;
                }
            }

            return numeroFilas;
        }
        private Int32 EjecutartransaccionEnvioTraslados(clases.traslados.traslado t, List<clases.traslados.detalle_producto_traslado> pr)
        {
            Int32 numeroFilas = 1;
            MySqlTransaction trans = null;
            long res = 0;

            if (base.conectar())
            {

                try
                {
                    trans = base.Conec.BeginTransaction();
                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = base.Conec;
                    comando.Transaction = trans;


                    comando.CommandText = t.sentenciaIngresar();
                    comando.ExecuteNonQuery();
                    res = comando.LastInsertedId;
                    Console.WriteLine(t.sentenciaIngresar());


                    foreach (clases.traslados.detalle_producto_traslado p in pr)
                    {
                        p.Idtraslado = res.ToString();
                        p.ingresaTraslado();
                        comando.CommandText = p.sentenciaIngresar();
                        Console.WriteLine(p.sentenciaIngresar());
                        comando.ExecuteNonQuery();
                    }

                    trans.Commit();

                }
                catch (MySqlException e)
                {
                    Console.WriteLine(e.Message);
                    trans.Rollback();
                    numeroFilas = -1;
                }
            }

            return numeroFilas;
        }
        private Int32 EjecutartransaccionRecepcioTraslados(clases.traslados.traslado t, List<clases.traslados.detalle_producto_traslado> pr, Dictionary<string, List<clases.presentaciones_productos>> pre)
        {
            Int32 numeroFilas = 1;
            MySqlTransaction trans = null;
            long res = 0;

            if (base.conectar())
            {

                try
                {
                    trans = base.Conec.BeginTransaction();
                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = base.Conec;
                    comando.Transaction = trans;


                    comando.CommandText = t.sentenciaIngresar();
                    comando.ExecuteNonQuery();
                    res = comando.LastInsertedId;
                    Console.WriteLine(t.sentenciaIngresar());


                    foreach (clases.traslados.detalle_producto_traslado p in pr)
                    {
                        p.Idtraslado = res.ToString();
                        p.ingresaTraslado();
                        comando.CommandText = p.sentenciaIngresar();
                        Console.WriteLine(p.sentenciaIngresar());
                        comando.ExecuteNonQuery();
                    }

                    //modificado los precios de los productos
                    foreach (KeyValuePair<string, List<clases.presentaciones_productos>> listaa in pre)
                    {
                        foreach (clases.presentaciones_productos pres in listaa.Value)
                        {
                            comando.CommandText = pres.cambio_precios().ToString();
                            comando.ExecuteNonQuery();
                            Console.WriteLine(pres.cambio_precios().ToString());
                        }
                    }

                    trans.Commit();

                }
                catch (MySqlException e)
                {
                    Console.WriteLine(e.Message);
                    trans.Rollback();
                    numeroFilas = -1;
                }
            }

            return numeroFilas;
        }
        private Int32 EjecutartransaccionRecepcioTraslados2(string idtraslado, List<clases.traslados.detalle_producto_traslado> pr, Dictionary<string, List<clases.presentaciones_productos>> pre)
        {
            Int32 numeroFilas = 1;
            MySqlTransaction trans = null;

            if (base.conectar())
            {

                try
                {
                    trans = base.Conec.BeginTransaction();
                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = base.Conec;
                    comando.Transaction = trans;


                    foreach (clases.traslados.detalle_producto_traslado p in pr)
                    {
                        p.Idtraslado = idtraslado;
                        p.ingresaTraslado();
                        comando.CommandText = p.sentenciaIngresar();
                        Console.WriteLine(p.sentenciaIngresar());
                        comando.ExecuteNonQuery();
                    }

                    //modificado los precios de los productos
                    foreach (KeyValuePair<string, List<clases.presentaciones_productos>> listaa in pre)
                    {
                        foreach (clases.presentaciones_productos pres in listaa.Value)
                        {
                            comando.CommandText = pres.cambio_precios().ToString();
                            comando.ExecuteNonQuery();
                            Console.WriteLine(pres.cambio_precios().ToString());
                        }
                    }

                    trans.Commit();

                }
                catch (MySqlException e)
                {
                    Console.WriteLine(e.Message);
                    trans.Rollback();
                    numeroFilas = -1;
                }
            }

            return numeroFilas;
        }
        private Int32 EjecutartransaccionCodigosProductos(clases.codigos codi, clases.productos_codigos pc)
        {
            Int32 numeroFilas = 1;
            MySqlTransaction trans = null;
            long res = 0;

            if (base.conectar())
            {
                try
                {
                    trans = base.Conec.BeginTransaction();
                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = base.Conec;
                    comando.Transaction = trans;

                    comando.CommandText = codi.sentenciaIngresar();
                    comando.ExecuteNonQuery();
                    res = comando.LastInsertedId;
                    Console.WriteLine(res.ToString());

                    pc.Idcodigo = res.ToString();
                    pc.cargarNuevamente();
                    comando.CommandText = pc.sentenciaIngresar();
                    Console.WriteLine(pc.sentenciaIngresar());
                    comando.ExecuteNonQuery();
                    

                    trans.Commit();
                    numeroFilas = Convert.ToInt32(res);

                }
                catch (MySqlException e)
                {
                    Console.WriteLine(e.Message);
                    trans.Rollback();
                    numeroFilas = -1;
                }
            }

            return numeroFilas;
        }
        private Int32 EjecutartransaccionCierreCaja(clases.cajas caja, clases.cortes_diarios cd, clases.cortes_sucursales cs)
        {
            Int32 numeroFilas = 1;
            MySqlTransaction trans = null;
            long res = 0;

            if (base.conectar())
            {
                try
                {
                    trans = base.Conec.BeginTransaction();
                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = base.Conec;
                    comando.Transaction = trans;

                    comando.CommandText = caja.modificar(); 
                    comando.ExecuteNonQuery();

                    comando.CommandText =cd.sentenciaIngresar();
                    Console.WriteLine(cd.sentenciaIngresar());
                    comando.ExecuteNonQuery();

                    res = comando.LastInsertedId;

                    cs.cargarId(res.ToString());
                    comando.CommandText = cs.sentenciaIngresar();
                    comando.ExecuteNonQuery();

                    res = comando.LastInsertedId;

                    trans.Commit();
                    numeroFilas = Convert.ToInt32(res);

                }
                catch (MySqlException e)
                {
                    Console.WriteLine(e.Message);
                    trans.Rollback();
                    numeroFilas = -1;
                }
            }

            return numeroFilas;
        }

        //encapsuladores
        public Int32 EjecutartransaccionEliminarProducto(conexiones_BD.clases.sucursales_productos sp, conexiones_BD.clases.productos p)
        {
            return EjecutartransaccionEliminarProductos(sp, p);
        }
        public Int32 EjecutartransaccionCodigosProduc(clases.codigos c, clases.productos_codigos pc)
        {
            return EjecutartransaccionCodigosProductos(c, pc);
        }
        public Int32 EjecutartransaccionModificarProducto(conexiones_BD.clases.sucursales_productos sp, conexiones_BD.clases.productos p)
        {
            return EjecutartransaccionModificarProductos(sp, p);
        }
        public Int32 transaccionPermisos_grupos(List<conexiones_BD.clases.permisos_grupos> per, conexiones_BD.clases.grupos gru)
        {
            return EjecutartransaccionPermisos_grupos(per, gru);
        }
        public Int32 transaccionEmpleados_sucursales(clases.empleados em, clases.empleados_sucursales es)
        {
            return EjecutartransaccionEmpleados_sucursales(em, es);
        }
        public Int32 transaccionCuentas_proveedores(List<conexiones_BD.clases.cuentas_proveedores> per, conexiones_BD.clases.proveedores gru)
        {
            return EjecutartransaccionCuentas_Proveedores(per, gru);
        }
        public Int32 transaccionProductos_Presentaciones_Proveedores(List<clases.proveedores_productos> prove, List<clases.presentaciones_productos> prese, clases.productos pro, clases.sucursales_productos sp, clases.codigos co)
        {
            return EjecutartransaccionProductos_Presentaciones_Proveedores(prove, prese, pro, sp, co);
        }
        // Ejecuta las sentencias para crear el ticket en la base de datos...
        public clases.ctrl_errores.errores transaccionVentasTickets(List<clases.ventas.detalles_productos_venta_ticket> dp, clases.ventas.tickets tic)
        {
            return Ejecutartransaccion_Ventas_tickets(dp, tic);
        }
        // Ejecuta las sentencias para crear la factura en la base de datos...
        public clases.ctrl_errores.errores transaccionVentasFacturas(List<clases.ventas.detalles_productos_venta_factura> df, clases.ventas.facturas fac)
        {
            return Ejecutartransaccion_Ventas_factura(df, fac);
        }
        public Int32 transaccionAnulacionVentaTic(conexiones_BD.clases.ventas.tickets v, conexiones_BD.clases.ventas.anulaciones a, List<clases.sucursales_productos> p)
        {
            return EjecutartransaccionAnulaVentaTickets(v, a, p);
        }
        public Int32 transaccionComprarProdu(clases.compras.facturas_compras c, clases.compras.compras cc, List<clases.compras.detalles_compras> com, Dictionary<string, List<clases.presentaciones_productos>> pr)
        {
            return EjecutartransaccionCompras(c, cc, com, pr);
        }
        public Int32 transaccionAnulacionCompras(clases.compras.compras c, clases.compras.anulaciones_compras ac, List<clases.sucursales_productos> pr)
        {
            return EjecutartransaccionAnulaCompras(c, ac, pr);
        }       
        public Int32 transaccionEnvioTraslado(clases.traslados.traslado t, List<clases.traslados.detalle_producto_traslado> pr)
        {
            return EjecutartransaccionEnvioTraslados(t, pr);
        }
        public Int32 transaccionRecepcionTraslado(clases.traslados.traslado t, List<clases.traslados.detalle_producto_traslado> pr, Dictionary<string, List<clases.presentaciones_productos>> pre)
        {
            return EjecutartransaccionRecepcioTraslados(t, pr, pre);
        }
        public Int32 transaccionRecepcionTraslado2(string idtras , List<clases.traslados.detalle_producto_traslado> pr, Dictionary<string, List<clases.presentaciones_productos>> pre)
        {
            return EjecutartransaccionRecepcioTraslados2(idtras, pr, pre);
        }
        public Int32 transaccionCajasCortes(clases.cajas caja, clases.cortes_diarios cd, clases.cortes_sucursales cs)
        {
            return EjecutartransaccionCierreCaja(caja, cd, cs);
        }
        //sentencias y consultas
        public long insertar(string se)
        {
            return Ejecutarsentencia2(se);
        }

        public Int32 insertar2(string se)
        {
            return Ejecutarsentencia(se);
        }
        public Int32 actualizar(string se)
        {
            return Ejecutarsentencia(se);
        }
        public Int32 eliminar(string se)
        {
            return Ejecutarsentencia(se);
        }
        public DataTable mostrarTabla(String se)
        {
            return Ejecutarconsulta(se);
        }
        public DataTable Consultar(String pConsulta)
        {
            return Ejecutarconsulta(pConsulta);
        }

        //utilitarios
        public String probarConexion()
        {
            if (base.conectar())
            {
                return "Conexión exitosa";
                
            }else
            {
                return "No se puedo conectar";
               
            }
        }
        public Boolean usoPrimeravez()
        {
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("select u.idusuario from usuarios u;");

            if (Ejecutarconsulta(sentencia.ToString()).Rows.Count>0)
            {
                return false;
            }else
            {
                return true;
            }

            
        }
        public String obtenerIp()
        {
            if (base.conectar())
            {
                return base.obtenerIpservidor();
            }
            else
            {
                return "No hay conexion al servidor";
            }
        }
        public Boolean conectado()
        {
            Boolean conectad = true;

            if (base.conectar())
            {
                conectad = true;
                base.desconectar();
            }
            else
            {
                conectad = false;
            }
            return conectad;

        }
        public Int32 ingresoPrueba()
        {
            Int32 numeroFilas = 0;

            if (base.conectar())
            {
                string sentencia = @"load data infile 'C:\\Users\\Fuentes\\Google Drive (vfjhovanyitsolutions@gmail.com)\\Sucursales\\Salcoatitan\\nuevos_registros\\prueba.txt'
                                    into table categorias
                                    fields terminated by '->'
                                    lines terminated by '\r\n'
                                    (nombre_categoria,descripcion)";
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = base.Conec;
                comando.CommandText = sentencia;

                try
                {
                    numeroFilas = comando.ExecuteNonQuery();


                }
                catch
                {
                    numeroFilas = 0;
                }
            }

            return numeroFilas;
        }

        //Transacciones por internet

        public Int32 EjecutartransaccionInternetProductos_Presentaciones_Proveedores(ArrayList prove, ArrayList prese, ArrayList pro, ArrayList sp)
        {
            Int32 numeroFilas = 1;
            MySqlTransaction trans = null;

            if (base.conectar())
            {
                try
                {
                    trans = base.Conec.BeginTransaction();
                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = base.Conec;
                    comando.Transaction = trans;

                    foreach (string salida in pro)
                    {
                        comando.CommandText = salida;
                        comando.ExecuteNonQuery();
                        Console.WriteLine(salida);
                    }
                    

                    foreach (string salida in prove)
                    {
                        comando.CommandText = salida;
                        comando.ExecuteNonQuery();
                        Console.WriteLine(salida);
                    }

                    foreach (string salida in sp)
                    {
                        comando.CommandText = salida;
                        comando.ExecuteNonQuery();
                        Console.WriteLine(salida);
                    }


                    foreach (string salida in prese)
                    {
                        comando.CommandText = salida;
                        comando.ExecuteNonQuery();
                        Console.WriteLine(salida);
                    }

                    trans.Commit();
                    numeroFilas = 1;

                }
                catch (MySqlException e)
                {
                    Console.WriteLine(e.Message);
                    trans.Rollback();
                    numeroFilas = -1;
                }
            }

            return numeroFilas;
        }

        //procedimientos almacenados
        public DataTable comprasXcliente(string fi, string ff, int id)
        {
            return comprasClientes(fi, ff, id);
        }
        public DataTable estadisticasXcliente(string fi, string ff)
        {
            return estadisticasClientes(fi, ff);
        }
        public DataTable estadisticasXTodos(string fi, string ff)
        {
            return estadisticasTodosLosClientes(fi, ff);
        }

        public DataTable datoscaja(int id)
        {
            return estadisticasCaja(id);
        }

    }
}
