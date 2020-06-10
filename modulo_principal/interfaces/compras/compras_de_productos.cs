using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using conexiones_BD.clases;
using utilitarios;

namespace interfaces.compras
{
    public partial class compras_de_productos : Form
    {
        sessionManager.secion sesion = sessionManager.secion.Instancia;
        cargar_tablas tabla;
        double ivaa = 0.13;
        string total=null, iva=null;
        bool busqueda = false;
        Dictionary<string, List<presentaciones_productos>> registro = new Dictionary<string, List<presentaciones_productos>>();

        public compras_de_productos()
        {
            InitializeComponent();
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelTitulo_MouseDown(object sender, MouseEventArgs ee)
        {
            gadgets.movimimientos mov = new gadgets.movimimientos();
            mov.moverFormulario(sender, ee, this);
        }

        private void compras_de_productos_Load(object sender, EventArgs e)
        {
            gadgets.horientaciones_textos.colocarTitulo(panelTitulo, lblEncanezado);
            this.cargarListas();
            this.cargarTablas();
        }

        private void compras_de_productos_Resize(object sender, EventArgs e)
        {
            gadgets.horientaciones_textos.colocarTitulo(panelTitulo, lblEncanezado);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void cargarListas()
        {
            cargandoListas.cargarLista(tipos_factura.datosTabla(), listaTipofac, "nombre", "idtipo_factura");
            listaTipofac.SelectedIndex = 2;
            cargandoListas.cargarLista(proveedores.datosTabla(), listaProveedor, "nombre_proveedor", "idproveedor");
            cargandoListas.cargarLista(usuarios.datosTabla(), listaUsu, "usuario", "idusuario");
            int index=listaUsu.FindStringExact(sesion.Datos[0]);
            listaUsu.SelectedIndex = index;
            cargandoListas.cargarLista(sucursales.datosTabla(), listaSucursal, "numero_de_sucursal", "idsucursal");
            listaSucursal.SelectedValue = sesion.DatosRegistro[1];

        }

        private void cargarTablas()
        {
            //tabla = new cargar_tablas(tablad, txtBusqueda, productos.CARGAR_TABLA_PRODUCTOS_X_SUCURSAL_VENTA(sesion.DatosRegistro[1]), "productoCod");
            tabla.cargarSinContadorRegistros();
        }

        private void txtBusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            busqueda = true;
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (busqueda)
            {
                tablad.Visible = true;
                tabla.FiltrarLocalmenteSinContadorRegistros();
                try
                {
                    if (tablad.Rows.Count != 0)
                    {
                        tablad.CurrentCell = tablad.Rows[0].Cells[1];
                    }

                }
                catch
                {

                }
            }
        }

        private void txtBusqueda_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                tablad.Visible = false;
            }
            else if (e.KeyCode == Keys.Down)
            {
                if (txtBusqueda.TextLength != 0)
                {
                    tablad.Focus();
                }
            }
            else if (e.KeyCode == Keys.Enter)
            {
                if (txtBusqueda.TextLength != 0)
                {
                    if (busqueda)
                    {
                        try
                        {
                            colocarPrecios();

                        }
                        catch
                        {

                        }
                    }
                }
            }
        }

        private void colocarPrecios()
        {
            try
            {
                DataGridViewRow seleccion = tablad.CurrentRow;
                auxiliares.producto_unica_presentacion frm = new auxiliares.producto_unica_presentacion();
                frm.Idsp = seleccion.Cells[0].Value.ToString();
                frm.lblExis.Text = seleccion.Cells[6].Value.ToString();
                frm.lblNombre.Text = seleccion.Cells[2].Value.ToString();
                frm.Idud = seleccion.Cells[14].Value.ToString();
                frm.Idum = seleccion.Cells[15].Value.ToString();
                frm.Codigo = seleccion.Cells[1].Value.ToString();

                frm.ShowDialog();
                if (frm.Listo)
                {
                    try
                    {
                        registro.Add(frm.Idsp, frm.Presenta);
                        if (!productoRepetidos(frm.Idsp))
                        {
                            DataRowView comprDetalle = (DataRowView)frm.listaPresentaciones.SelectedItem;
                            DataRowView detalle = (DataRowView)frm.listaUDetalle.SelectedItem;
                            DataRowView mayoreo = (DataRowView)frm.listaUMayoreo.SelectedItem;
                            tabla_articulos.Rows.Add(
                                "",
                                frm.Codigo,
                                frm.lblNombre.Text,
                                frm.listaPresentaciones.Text,
                                frm.txtCantidad.Value.ToString(),
                                frm.compraMayoreo.Value.ToString(),
                                frm.compraDetalle.Value.ToString(),
                                Math.Round(Convert.ToDouble(frm.compraMayoreo.Value) * Convert.ToInt32(frm.txtCantidad.Value), 2).ToString(),
                                frm.lblExis.Text,
                                mayoreo[3].ToString(),
                                detalle[3].ToString(),
                                comprDetalle[2].ToString(),
                                frm.Idsp,
                                frm.listaUDetalle.SelectedValue.ToString(),
                                frm.listaUMayoreo.SelectedValue.ToString(),
                                frm.ventaMayoreo.Value.ToString(),
                                frm.ventaDetalle.Value.ToString(),
                                comprDetalle[3].ToString(),
                                Image.FromFile(Environment.CurrentDirectory + @"\\refresh.png"),
                                Image.FromFile(Environment.CurrentDirectory + @"\\delete.png")
                                );


                            cargar_tablas.correlativoTabla(tabla_articulos);
                            calcularTotal();
                        }
                        else
                        {
                            txtBusqueda.Text = "";
                            tablad.Visible = false;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Ya se agrego ese producto al detalle", "Repetido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    txtBusqueda.Text = "";
                    tablad.Visible = false;
                }else
                {
                    txtBusqueda.Text = "";
                    tablad.Visible = false;
                }
            }
            catch
            {

            }

        }

        private void tablad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void tablad_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                try
                {
                    if (busqueda)
                    {
                        colocarPrecios();
                        txtBusqueda.Text = "";
                        txtBusqueda.Focus();
                        tablad.Visible = false;
                        busqueda = false;
                    }

                }
                catch
                {

                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                busqueda = false;
                txtBusqueda.Text = "";
                txtBusqueda.Focus();
                tablad.Visible = false;

            }
        }

        private bool productoRepetidos(string idsp)
        {
            bool repetido = false;

            if (tabla_articulos.RowCount != 0)
            {
                foreach (DataGridViewRow fila in tabla_articulos.Rows)
                {
                    if (fila.Cells[12].Value.ToString().Equals(idsp))
                    {
                        repetido = true;
                        break;
                    }
                }
            }
            return repetido;
        }

        private void tabla_articulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tabla_articulos.Rows.Count!=0)
            {
                if (tabla_articulos.Columns[e.ColumnIndex].Name == "eli")
                {
                    if (MessageBox.Show("¿Desea eliminar el producto?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                    {
                        registro.Remove(tabla_articulos.CurrentRow.Cells[12].Value.ToString());
                        tabla_articulos.Rows.RemoveAt(tabla_articulos.CurrentRow.Index);
                        calcularTotal();
                    }
                }
                else if (tabla_articulos.Columns[e.ColumnIndex].Name == "modi")
                {
                    if (MessageBox.Show("¿Desea modificar el detalle del producto?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                    {
                        auxiliares.producto_unica_presentacion frm = new auxiliares.producto_unica_presentacion();
                        frm.Idsp = tabla_articulos.CurrentRow.Cells[12].Value.ToString();
                        frm.lblExis.Text = tabla_articulos.CurrentRow.Cells[8].Value.ToString();
                        frm.lblNombre.Text = tabla_articulos.CurrentRow.Cells[2].Value.ToString();
                        frm.Idud = tabla_articulos.CurrentRow.Cells[13].Value.ToString();
                        frm.Idum = tabla_articulos.CurrentRow.Cells[14].Value.ToString();
                        frm.Codigo = tabla_articulos.CurrentRow.Cells[1].Value.ToString();
                        frm.PrecioCD = tabla_articulos.CurrentRow.Cells[6].Value.ToString();
                        frm.PrecioCM = tabla_articulos.CurrentRow.Cells[5].Value.ToString();
                        frm.Canti = tabla_articulos.CurrentRow.Cells[4].Value.ToString();
                        frm.Prese= tabla_articulos.CurrentRow.Cells[3].Value.ToString();
                        frm.Presenta = registro[tabla_articulos.CurrentRow.Cells[12].Value.ToString()];

                        registro.Remove(tabla_articulos.CurrentRow.Cells[12].Value.ToString());
                        frm.Modificar = true;

                        frm.ShowDialog();
                        {
                            if (frm.Listo)
                            {
                                try
                                {
                                    registro.Add(frm.Idsp, frm.Presenta);
                                    
                                        DataRowView comprDetalle = (DataRowView)frm.listaPresentaciones.SelectedItem;
                                        DataRowView detalle = (DataRowView)frm.listaUDetalle.SelectedItem;
                                        DataRowView mayoreo = (DataRowView)frm.listaUMayoreo.SelectedItem;

                                        tabla_articulos.CurrentRow.Cells[1].Value = frm.Codigo;
                                        tabla_articulos.CurrentRow.Cells[2].Value = frm.lblNombre.Text;
                                        tabla_articulos.CurrentRow.Cells[3].Value = frm.listaPresentaciones.Text;
                                        tabla_articulos.CurrentRow.Cells[4].Value = frm.txtCantidad.Value.ToString();
                                        tabla_articulos.CurrentRow.Cells[5].Value = frm.compraMayoreo.Value.ToString();
                                        tabla_articulos.CurrentRow.Cells[6].Value = frm.compraDetalle.Value.ToString();
                                        tabla_articulos.CurrentRow.Cells[7].Value = Math.Round(Convert.ToDouble(frm.compraMayoreo.Value) * Convert.ToInt32(frm.txtCantidad.Value), 2).ToString();
                                        tabla_articulos.CurrentRow.Cells[8].Value = frm.lblExis.Text;
                                        tabla_articulos.CurrentRow.Cells[9].Value = mayoreo[3].ToString();
                                        tabla_articulos.CurrentRow.Cells[10].Value = detalle[3].ToString();
                                        tabla_articulos.CurrentRow.Cells[11].Value = comprDetalle[2].ToString();
                                        tabla_articulos.CurrentRow.Cells[12].Value = frm.Idsp;
                                        tabla_articulos.CurrentRow.Cells[13].Value = frm.listaUDetalle.SelectedValue.ToString();
                                        tabla_articulos.CurrentRow.Cells[14].Value = frm.listaUMayoreo.SelectedValue.ToString();
                                        tabla_articulos.CurrentRow.Cells[15].Value = frm.ventaMayoreo.Value.ToString();
                                        tabla_articulos.CurrentRow.Cells[16].Value = frm.ventaDetalle.Value.ToString();

                                    cargar_tablas.correlativoTabla(tabla_articulos);
                                    calcularTotal();
                                   
                                }
                                catch
                                {
                                    MessageBox.Show("Ya se agrego ese producto al detalle", "Repetido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                txtBusqueda.Text = "";
                                tablad.Visible = false;
                            }
                        }
                    }
                    
                }
            }
        }

        private bool validar()
        {
            bool valido = false;
            error.Clear();
            string mensaje = "No puedes dejar en blanco este campo";

            if (listaTipofac.SelectedIndex == -1)
            {
                valido = true;
                error.SetError(listaTipofac, mensaje);
            }
            if (listaProveedor.SelectedIndex == -1)
            {
                valido = true;
                error.SetError(listaProveedor, mensaje);
            }
            if (txtNumeroFac.TextLength==0)
            {
                valido = true;
                error.SetError(txtNumeroFac, mensaje);
            }
            if (tabla_articulos.RowCount == 0)
            {
                valido = true;
                error.SetError(tabla_articulos, "Tienes que agregar un articulos");
            }
            return valido;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!validar())
            {
                ingresandoDatos();
            }
        }

        private List<conexiones_BD.clases.compras.detalles_compras> generarDetallesProductos()
        {
            List<conexiones_BD.clases.compras.detalles_compras> dc = new List<conexiones_BD.clases.compras.detalles_compras>();
            foreach(DataGridViewRow fila in tabla_articulos.Rows)
            {
                dc.Add(
                    new conexiones_BD.clases.compras.detalles_compras(fila.Cells[12].Value.ToString(),
                    (Convert.ToInt32(fila.Cells[4].Value.ToString()) * Convert.ToInt32(fila.Cells[11].Value.ToString())).ToString(),
                    fila.Cells[5].Value.ToString(),
                    fila.Cells[6].Value.ToString(),
                    fila.Cells[7].Value.ToString(),
                    fila.Cells[9].Value.ToString(),
                    fila.Cells[10].Value.ToString(),
                    "0",
                    fila.Cells[14].Value.ToString(),
                    fila.Cells[13].Value.ToString(),
                    fila.Cells[15].Value.ToString(),
                    fila.Cells[16].Value.ToString(),
                    fila.Cells[4].Value.ToString(),
                    fila.Cells[17].Value.ToString()
                    )
                    );
            }

            return dc;
        }

        private void ingresandoDatos()
        {
            maneja_fechas fech = new maneja_fechas();
            conexiones_BD.clases.compras.facturas_compras fc = new conexiones_BD.clases.compras.facturas_compras(
                txtNumeroFac.Text,
                listaTipofac.SelectedValue.ToString(),
                listaUsu.SelectedValue.ToString(),
                lblTotalNeto.Text,
                iva,
                "0.0",
                total,
                fech.fechaMysql(fechaFactura),
                listaProveedor.SelectedValue.ToString());

            conexiones_BD.clases.compras.compras c = new conexiones_BD.clases.compras.compras(
                "0",
                listaSucursal.SelectedValue.ToString(),
                fech.fechaMysql(fechaActual),
                "1",
                sesion.Idcaja);

            conexiones_BD.operaciones op = new conexiones_BD.operaciones();

            if (op.transaccionComprarProdu(fc,c,this.generarDetallesProductos(),registro)>0)
            {
                MessageBox.Show("La compra se ingreso correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fechaActual.Value = DateTime.Now;
                registro = new Dictionary<string, List<presentaciones_productos>>();
                tabla_articulos.Rows.Clear();
                cargarTablas();
                txtNumeroFac.Text = "";
                listaProveedor.SelectedIndex = -1;

            }else
            {
                MessageBox.Show("La compra no se pudo ingresar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReimprimir_Click(object sender, EventArgs e)
        {
            
        }

        private void calcularTotal()
        {
            if (tabla_articulos.RowCount!=0)
            {
                double precio = 0;
                foreach (DataGridViewRow fila in tabla_articulos.Rows)
                {
                    precio += Convert.ToDouble(fila.Cells[7].Value);
                }

                lblCantidad_de_articulos.Text = "Cantidad de articulos " + tabla_articulos.Rows.Count;
                lblTotalNeto.Text = precio.ToString();
                lblDecIva.Text = Math.Round((precio * ivaa),2).ToString();
                iva = Math.Round((precio * ivaa), 2).ToString();
                lblTotal.Text = "$ " + calcularIva(precio);
                total = calcularIva(precio);
            }
        }

        private string calcularIva(double precio)
        {
            double pre = precio;
            double total = Math.Round(pre-(pre * ivaa),2);
            return total.ToString();

        }

    }
}
