using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using conexiones_BD.clases;

namespace interfaces.traslados
{
    public partial class recepcion_traslados : Form
    {
        sessionManager.secion sesion = sessionManager.secion.Instancia;
        transferencias_internet.xml xm = new transferencias_internet.xml();
        BindingSource _datos = new BindingSource();
        Dictionary<string, List<presentaciones_productos>> registro = new Dictionary<string, List<presentaciones_productos>>();
        int cantidadElejida = 0;
        public recepcion_traslados()
        {
            InitializeComponent();
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void recepcion_traslados_Load(object sender, EventArgs e)
        {
            gadgets.horientaciones_textos.colocarTitulo(panelTitulo, lblEncanezado);
            cargarTablaTraslados();
        }

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            gadgets.movimimientos mov = new gadgets.movimimientos();
            mov.moverFormulario(sender, e, this);
        }

        private void cargarTablaTraslados()
        {
            if (File.Exists(transferencias_internet.nuevos_ingresos.rutas_sucursales(Convert.ToInt16(sesion.DatosRegistro[0])) + "traslados.xml"))
            {
                DataSet ba = new DataSet();
                ba.ReadXml(transferencias_internet.nuevos_ingresos.rutas_sucursales(Convert.ToInt16(sesion.DatosRegistro[0])) + "traslados.xml");


                if (ba.Tables.Count != 0)
                {
                    DataTableCollection tables = ba.Tables;
                    DataView view1 = new DataView(tables[0]);

                    _datos.DataSource = view1;

                    filtarLocalmente();
                }
                else
                {
                    tabla_traslados.DataSource = null;
                }
            }
            else
            {
                MessageBox.Show("No se encuentran el archivo xml", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tabla_traslados_Click(object sender, EventArgs e)
        {
            if (tabla_traslados.RowCount != 0)
            {
                colocarProductosTraslado();
            }
        }

        private void colocarProductosTraslado()
        {
            xm._crearXml2("traslados", transferencias_internet.nuevos_ingresos.rutas_sucursales(Convert.ToInt16(sesion.DatosRegistro[0])) + "traslados.xml");
            if (tablaDetalles.RowCount == 0)
            {
                List<conexiones_BD.clases.traslados.detalle_producto_traslado> p = xm.productosTraslados(tabla_traslados.CurrentRow.Cells[6].Value.ToString());


                foreach (conexiones_BD.clases.traslados.detalle_producto_traslado pe in p)
                {
                    tablaDetalles.Rows.Add(
                        "0",
                        pe.Idsucursal_producto,
                        pe.Nombre,
                        pe.Cantidad,
                        pe.Recibido,
                        pe.Idtraslado,
                        pe.Correla,
                        pe.Cantidad_presentacion,
                        pe.Nombre_presentacion,
                        pe.Cod_producto,
                        false
                        );
                }
            }
            else
            {
                tablaDetalles.Rows.Clear();
                List<conexiones_BD.clases.traslados.detalle_producto_traslado> p = xm.productosTraslados(tabla_traslados.CurrentRow.Cells[6].Value.ToString());
                foreach (conexiones_BD.clases.traslados.detalle_producto_traslado pe in p)
                {
                    tablaDetalles.Rows.Add(
                        "0",
                        pe.Idsucursal_producto,
                        pe.Nombre,
                        pe.Cantidad,
                        pe.Recibido,
                        pe.Idtraslado,
                        pe.Correla,
                        pe.Cantidad_presentacion,
                        pe.Nombre_presentacion,
                        pe.Cod_producto,
                        false
                        );
                }
            }

        }

        private void tablaDetalles_Click(object sender, EventArgs e)
        {
            DataTable pres_codi = new DataTable();
            if (tablaDetalles.Rows.Count != 0)
            {
                xm._crearXml2("traslados", transferencias_internet.nuevos_ingresos.rutas_sucursales(Convert.ToInt16(sesion.DatosRegistro[0])) + "traslados.xml");
                if (tablaDetalles.RowCount != 0)
                {

                    if (tabla_Prese.RowCount == 0)
                    {
                        List<conexiones_BD.clases.presentaciones_productos> p = xm.presetacionesTraslados(tablaDetalles.CurrentRow.Cells[9].Value.ToString(), tablaDetalles.CurrentRow.Cells[6].Value.ToString());
                        pres_codi = conexiones_BD.clases.presentaciones_productos.presentaciones_productoXCodigo(tablaDetalles.CurrentRow.Cells[9].Value.ToString());

                        foreach (conexiones_BD.clases.presentaciones_productos pe in p)
                        {
                            foreach (DataRow fila in pres_codi.Rows)
                            {
                                if (pe.Idpresentacion.Equals(fila[1].ToString()))
                                {
                                    tabla_Prese.Rows.Add(
                                pe.Idsucursal_producto,
                                pe.Idpresentacion,
                                pe.Cantidad_unidades,
                                conexiones_BD.clases.presentaciones.presentacion(pe.Idpresentacion),
                                pe.Precio,
                                pe.Tipo,
                                pe.Prioridad,
                                pe.Cod_producto
                                );

                                }
                            }
                        }


                    }
                    else
                    {
                        tabla_Prese.Rows.Clear();
                        List<conexiones_BD.clases.presentaciones_productos> p = xm.presetacionesTraslados(tablaDetalles.CurrentRow.Cells[9].Value.ToString(), tablaDetalles.CurrentRow.Cells[6].Value.ToString());
                        pres_codi = conexiones_BD.clases.presentaciones_productos.presentaciones_productoXCodigo(tablaDetalles.CurrentRow.Cells[9].Value.ToString());

                        foreach (conexiones_BD.clases.presentaciones_productos pe in p)
                        {
                            foreach (DataRow fila in pres_codi.Rows)
                            {
                                if (pe.Idpresentacion.Equals(fila[1].ToString()))
                                {
                                    tabla_Prese.Rows.Add(
                                pe.Idsucursal_producto,
                                pe.Idpresentacion,
                                pe.Cantidad_unidades,
                                conexiones_BD.clases.presentaciones.presentacion(pe.Idpresentacion),
                                pe.Precio,
                                pe.Tipo,
                                pe.Prioridad,
                                pe.Cod_producto
                                );

                                }
                            }
                        }
                    }
                }
            }

        }

        private void filtarLocalmente()
        {
            if (txtBuscar.TextLength == 0)
            {
                _datos.RemoveFilter();
            }
            else
            {
                _datos.Filter = "correlativos_traslados LIKE '%" + txtBuscar.Text + "%'"; ;
            }

            tabla_traslados.DataSource = _datos;
            tabla_traslados.AutoGenerateColumns = false;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            filtarLocalmente();
        }

        private List<conexiones_BD.clases.traslados.detalle_producto_traslado> retornoProductos()
        {
            List<conexiones_BD.clases.traslados.detalle_producto_traslado> dp = new List<conexiones_BD.clases.traslados.detalle_producto_traslado>();


            foreach (DataGridViewRow fila in tablaDetalles.Rows)
            {
                bool valido = (bool)fila.Cells["valida"].Value;
                if (valido)
                {
                    double cantidad = Convert.ToDouble(Convert.ToDouble(fila.Cells[3].Value.ToString()));
                    double can = Convert.ToDouble(fila.Cells[7].Value.ToString());

                    conexiones_BD.clases.traslados.detalle_producto_traslado dt = new conexiones_BD.clases.traslados.detalle_producto_traslado(
                        fila.Cells[1].Value.ToString(), cantidad.ToString(), "1", "0", fila.Cells[6].Value.ToString(), can.ToString(),
                        fila.Cells[8].Value.ToString(), fila.Cells[9].Value.ToString());

                    dp.Add(
                        dt
                        );
                }

            }


            return dp;
        }

        private void btnRecibir_Click(object sender, EventArgs e)
        {
            if (!validar())
            {
                enviandoTraslado();   
            }
        }

        private bool validar()
        {
            cantidadElejida = 0;
            bool valido = false;
            error.Clear();
            string mensaje = "No hay productos en el detalle";

            if (tablaDetalles.Rows.Count == 0)
            {
                valido = true;
                error.SetError(tablaDetalles, mensaje);
            }

            contar();
            if (cantidadElejida == 0)
            {
                valido = true;
                error.SetError(tablaDetalles, mensaje);
            }

            return valido;
        }

        private void enviandoTraslado()
        {
            DataTable existencia = conexiones_BD.clases.traslados.traslado.exitsenciaCorrelativo(tabla_traslados.CurrentRow.Cells[6].Value.ToString());
            utilitarios.maneja_fechas fech = new utilitarios.maneja_fechas();
            conexiones_BD.clases.traslados.traslado tras = new conexiones_BD.clases.traslados.traslado(
                tabla_traslados.CurrentRow.Cells[0].Value.ToString(),
                tabla_traslados.CurrentRow.Cells[1].Value.ToString(),
                tabla_traslados.CurrentRow.Cells[2].Value.ToString(),
                tabla_traslados.CurrentRow.Cells[3].Value.ToString(),
                tabla_traslados.CurrentRow.Cells[4].Value.ToString(), "1",
                tabla_traslados.CurrentRow.Cells[6].Value.ToString());

            conexiones_BD.operaciones op = new conexiones_BD.operaciones();
            actualizandoPresentaciones_productos();

            if (existencia.Rows.Count != 0)
            {
                if (op.transaccionRecepcionTraslado2(existencia.Rows[0][0].ToString(), retornoProductos(), registro) > 0)
                {

                    MessageBox.Show("El traslado se actualizo éxitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    registro.Clear();
                    quitandoPresentaciones_detalles();
                }
                else
                {
                    MessageBox.Show("El traslado no se actualizo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                if (op.transaccionRecepcionTraslado(tras, retornoProductos(), registro) > 0)
                {

                    MessageBox.Show("El traslado se ingreso éxitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    registro.Clear();
                    quitandoPresentaciones_detalles();
                }
                else
                {
                    MessageBox.Show("El traslado no se ingreso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void actualizandoPresentaciones_productos()
        {
            foreach (DataGridViewRow filaa in tablaDetalles.Rows)
            {
                DataTable pres_codi = new DataTable();
                bool valido = (bool)filaa.Cells["valida"].Value;
                List<presentaciones_productos> presenta = new List<presentaciones_productos>();
                if (valido)
                {
                    List<presentaciones_productos> p = xm.presetacionesTraslados(filaa.Cells[9].Value.ToString(), filaa.Cells[6].Value.ToString());
                    pres_codi = presentaciones_productos.presentaciones_productoXCodigo(filaa.Cells[9].Value.ToString());

                    foreach (presentaciones_productos pe in p)
                    {
                        foreach (DataRow fila in pres_codi.Rows)
                        {
                            if (pe.Idpresentacion.Equals(fila[1].ToString()))
                            {
                                presenta.Add(new presentaciones_productos(fila[3].ToString(), pe.Precio));
                            }
                        }
                    }

                    registro.Add(filaa.Cells[9].Value.ToString(), presenta);
                }   
            }
            
        }

        private void quitandoPresentaciones_detalles()
        {
            xm._crearXml2("traslados", transferencias_internet.nuevos_ingresos.rutas_sucursales(Convert.ToInt16(sesion.DatosRegistro[0])) + "traslados.xml");
            int contador = 0;
            foreach(DataGridViewRow fila in tablaDetalles.Rows)
            {
                bool valido = (bool)fila.Cells["valida"].Value;
                if (valido)
                {
                    xm.BorrarTrasladosdetalles(fila.Cells[9].Value.ToString(), fila.Cells[6].Value.ToString(), "detalle_traslado", "codigo_productos", "correlativos_traslados");
                    xm.BorrarTrasladosdetalles(fila.Cells[9].Value.ToString(), fila.Cells[6].Value.ToString(), "presentacion_pro", "codigo_productos", "correlativo");
                    contador++;
                }
            }

                if (tablaDetalles.RowCount == contador)
                {
                    xm.BorrarTraslados(tabla_traslados.CurrentRow.Cells[6].Value.ToString(), "traslado", "correlativos_traslados");
                }

            cargarTablaTraslados();
            tablaDetalles.Rows.Clear();
            tabla_Prese.Rows.Clear();
        }

        private void contar()
        {
            foreach(DataGridViewRow fila in tablaDetalles.Rows)
            {
                bool valido = (bool)fila.Cells["valida"].Value;
                if (valido)
                {
                    cantidadElejida++;
                }
            }
        }

    }
}
