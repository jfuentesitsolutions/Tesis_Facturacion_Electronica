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

namespace interfaces.actualizaciones
{
    public partial class actualiza_productos : Form
    {
        sessionManager.secion sesion = sessionManager.secion.Instancia;
        transferencias_internet.xml xm = new transferencias_internet.xml();
        public actualiza_productos()
        {
            InitializeComponent();
        }

        private void actualiza_productos_Load(object sender, EventArgs e)
        {
            gadgets.horientaciones_textos.colocarTitulo(panelTitulo, lblEncanezado);
            this.cargarProductos();
        }

        private void cargarProductos()
        {
            if (File.Exists(transferencias_internet.nuevos_ingresos.rutas_sucursales(Convert.ToInt16(sesion.DatosRegistro[0])) + "productos.xml"))
            {
                DataSet ba = new DataSet();
                ba.ReadXml(transferencias_internet.nuevos_ingresos.rutas_sucursales(Convert.ToInt16(sesion.DatosRegistro[0])) + "productos.xml");
                if (ba.Tables.Count!=0)
                {
                    tabla_productos.DataSource = ba;
                    tabla_productos.DataMember = "producto";
                    tabla_productos.AutoGenerateColumns = false;
                }
                else
                {
                    tabla_productos.DataSource = null;
                }
            }else
            {
                MessageBox.Show("No se encuentran el archivo xml","Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            gadgets.movimimientos mov = new gadgets.movimimientos();
            mov.moverFormulario(sender, e, this);
        }

        private void tabla_productos_Click(object sender, EventArgs e)
        {
            xm._crearXml("productos", Convert.ToInt16(sesion.DatosRegistro[0]), "productos.xml");
            if (tabla_productos.RowCount != 0)
            {

                if (tabla_Prese.RowCount == 0)
                {
                    List<conexiones_BD.clases.presentaciones_productos> p = xm.Presentaciones_productos(tabla_productos.CurrentRow.Cells[0].Value.ToString());

                    foreach (conexiones_BD.clases.presentaciones_productos pe in p)
                    {
                        tabla_Prese.Rows.Add(
                            pe.Idsucursal_producto,
                            pe.Idpresentacion,
                            pe.Cantidad_unidades,
                            conexiones_BD.clases.presentaciones.presentacion(pe.Idpresentacion),
                            pe.Precio,
                            pe.Tipo,
                            pe.Prioridad
                            );
                    }
                    }
                    else
                    {
                        tabla_Prese.Rows.Clear();
                        List<conexiones_BD.clases.presentaciones_productos> p = xm.Presentaciones_productos(tabla_productos.CurrentRow.Cells[0].Value.ToString());
                        foreach (conexiones_BD.clases.presentaciones_productos pe in p)
                        {
                            tabla_Prese.Rows.Add(
                                pe.Idsucursal_producto,
                                pe.Idpresentacion,
                                pe.Cantidad_unidades,
                                conexiones_BD.clases.presentaciones.presentacion(pe.Idpresentacion),
                                pe.Precio,
                                pe.Tipo,
                                pe.Prioridad
                                );
                    }
                }
            }
        }

        private void btnIngresaTodos_Click(object sender, EventArgs e)
        {
        //    int con = tabla_productos.RowCount;
        //    int cont = 0;
        //    if (tabla_productos.RowCount!=0)
        //    {
        //        xm._crearXml2("producto", transferencias_internet.nuevos_ingresos.rutas_sucursales(Convert.ToInt16(sesion.DatosRegistro[0]))+"productos.xml");
        //        foreach (DataGridViewRow fila in tabla_productos.Rows)
        //        {
        //            if (!validarExistencias(fila.Cells[1].Value.ToString(), fila.Cells[0].Value.ToString()))
        //            {
        //                conexiones_BD.clases.productos pr = new conexiones_BD.clases.productos(
        //                    fila.Cells[0].Value.ToString(),
        //                    fila.Cells[1].Value.ToString(),
        //                    fila.Cells[2].Value.ToString(),
        //                    fila.Cells[3].Value.ToString(),
        //                    fila.Cells[4].Value.ToString()
        //                    );


        //                conexiones_BD.operaciones op = new conexiones_BD.operaciones();
        //                int res = op.transaccionProductos_Presentaciones_Proveedores(xm.Proveedores_productos(fila.Cells[0].Value.ToString()),
        //                    xm.Presentaciones_productos(fila.Cells[0].Value.ToString()),
        //                    pr, xm.sucp(fila.Cells[0].Value.ToString()));

        //                if (res > 0)
        //                {
        //                    xm.Borrar(fila.Cells[0].Value.ToString(), "producto");
        //                    xm.Borrar(fila.Cells[0].Value.ToString(), "sucursal_producto");
        //                    xm.Borrar(fila.Cells[0].Value.ToString(), "proveedor_producto");
        //                    xm.Borrar(fila.Cells[0].Value.ToString(), "presentacion_pro");
        //                    cont++;
        //                }
        //            }
        //        }

        //        if (con==cont)
        //        {
        //            MessageBox.Show("Productos ingresados exitosamente a la base", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            tabla_productos.DataSource = null;
        //        }else
        //        {
        //            cargarProductos();
        //        }
                
        //    }
        }

        private bool validarExistencias(string n, string c)
        {
            List<string> campos = new List<string>();
            List<string> valores = new List<string>();
            bool valido = false;
            campos.Add("nom_producto");
            campos.Add("cod_producto");
            valores.Add(n);
            valores.Add(c);

            conexiones_BD.clases.productos pro = new conexiones_BD.clases.productos(campos, valores);

            
                if (pro.validarCamposcondicorOR(true) > 0)
                {
                    valido = true;
                }
                else
                {
                    valido = false;
                }
            

            return valido;
        }

        private void tabla_productos_DoubleClick(object sender, EventArgs e)
        {
        //    if (tabla_productos.RowCount!=0)
        //    {
        //        if (MessageBox.Show("¿Deseas ingresar este producto?","Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)==DialogResult.Yes)
        //        {
        //            xm._crearXml2("producto", transferencias_internet.nuevos_ingresos.rutas_sucursales(Convert.ToInt16(sesion.DatosRegistro[0])) + "productos.xml");

        //            if (!validarExistencias(tabla_productos.CurrentRow.Cells[1].Value.ToString(), tabla_productos.CurrentRow.Cells[0].Value.ToString()))
        //            {
        //                conexiones_BD.clases.productos pr = new conexiones_BD.clases.productos(
        //                    tabla_productos.CurrentRow.Cells[0].Value.ToString(),
        //                    tabla_productos.CurrentRow.Cells[1].Value.ToString(),
        //                    tabla_productos.CurrentRow.Cells[2].Value.ToString(),
        //                    tabla_productos.CurrentRow.Cells[3].Value.ToString(),
        //                    tabla_productos.CurrentRow.Cells[4].Value.ToString()
        //                    );

        //                conexiones_BD.operaciones op = new conexiones_BD.operaciones();
        //                int res = op.transaccionProductos_Presentaciones_Proveedores(xm.Proveedores_productos(tabla_productos.CurrentRow.Cells[0].Value.ToString()),
        //                    xm.Presentaciones_productos(tabla_productos.CurrentRow.Cells[0].Value.ToString()),
        //                    pr, xm.sucp(tabla_productos.CurrentRow.Cells[0].Value.ToString()));

        //                if (res > 0)
        //                {
        //                    xm.Borrar(tabla_productos.CurrentRow.Cells[0].Value.ToString(), "producto");
        //                    xm.Borrar(tabla_productos.CurrentRow.Cells[0].Value.ToString(), "sucursal_producto");
        //                    xm.Borrar(tabla_productos.CurrentRow.Cells[0].Value.ToString(), "proveedor_producto");
        //                    xm.Borrar(tabla_productos.CurrentRow.Cells[0].Value.ToString(), "presentacion_pro");
        //                    cargarProductos();
        //                    tabla_Prese.Rows.Clear();
        //                }else
        //                {
        //                    MessageBox.Show("No se pudo ingresar el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                }
        //            }   
        //        }
        //    }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (tabla_productos.Rows.Count!=0)
            {
                xm._crearXml2("producto", transferencias_internet.nuevos_ingresos.rutas_sucursales(Convert.ToInt16(sesion.DatosRegistro[0])) + "productos.xml");
                if (MessageBox.Show("Desea eliminar quitar el productos", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                {
                        xm.Borrar(tabla_productos.CurrentRow.Cells[0].Value.ToString(), "producto");
                        xm.Borrar(tabla_productos.CurrentRow.Cells[0].Value.ToString(), "sucursal_producto");
                        xm.Borrar(tabla_productos.CurrentRow.Cells[0].Value.ToString(), "proveedor_producto");
                        xm.Borrar(tabla_productos.CurrentRow.Cells[0].Value.ToString(), "presentacion_pro");
                        cargarProductos();
                        tabla_Prese.Rows.Clear();
                }
            }
        }
    }
}
