using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfaces.mantenimientos.procesos_iniciales
{
    public partial class agregaPresentaciones : Form
    {
        bool lista = false;
        string idsucursal_producto=null, idproducto;
        utilitarios.cargar_tablas tabla, tabla2;
        conexiones_BD.clases.presentaciones_productos prpr;
        TextBox te = new TextBox();
        sessionManager.secion sesion = sessionManager.secion.Instancia;
        string codigo = null;
        bool ingresadoN = false;

        public string Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;
            }
        }

        public bool IngresadoN
        {
            get
            {
                return ingresadoN;
            }

            set
            {
                ingresadoN = value;
            }
        }

        public agregaPresentaciones()
        {
            InitializeComponent();
        }

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            gadgets.movimimientos mov = new gadgets.movimimientos();
            mov.moverFormulario(sender, e, this);
        }

        private void agregaPresentaciones_Load(object sender, EventArgs e)
        {
            gadgets.horientaciones_textos.colocarTitulo(panelTitulo, lblEncanezado);

            cargandoLista();
            tabla2 = new utilitarios.cargar_tablas(tabla_presentacion, txtBuscarP, conexiones_BD.clases.presentaciones.datosTabla(), "nombre_presentacion");
            tabla2.cargarSinContadorRegistros();
            if (codigo != null)
            {
                listasBusqueda.Text = codigo;
                cargandoProductos();
            }
            
            
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            ingresadoN = true;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ingresadoN = true;
            this.Close();
        }

        private void cargandoLista()
        {
            lista = false;

            if (chkCodi.Checked)
            {
                if (sesion.Datos[3].Equals("Administradores"))
                {
                    utilitarios.cargandoListas.cargarLista(conexiones_BD.clases.productos.CARGAR_TABLA_PRODUCTOS(), listasBusqueda, "codP", "idSp");
                }
                else
                {
                    utilitarios.cargandoListas.cargarLista(conexiones_BD.clases.productos.CARGAR_TABLA_PRODUCTOS_X_SUCURSAL(sesion.DatosRegistro[1]), listasBusqueda, "codP", "idSp");
                }

            } else if (chkNombre.Checked)
            {
                
                if (sesion.Datos[3].Equals("Administradores"))
                {
                    utilitarios.cargandoListas.cargarLista(conexiones_BD.clases.productos.CARGAR_TABLA_PRODUCTOS(), listasBusqueda, "nombreP", "idSp");
                }
                else
                {
                    utilitarios.cargandoListas.cargarLista(conexiones_BD.clases.productos.CARGAR_TABLA_PRODUCTOS_X_SUCURSAL(sesion.DatosRegistro[1]), listasBusqueda, "nombreP", "idSp");
                }
            }

            utilitarios.cargandoListas.cargarLista(conexiones_BD.clases.marcas.datosTabla(),
                listaMarca, "nombre", "idmarca");
            utilitarios.cargandoListas.cargarLista(conexiones_BD.clases.categorias.datosTabla(),
                listaCategoria, "nombre_categoria", "idcategoria");
            utilitarios.cargandoListas.cargarLista(conexiones_BD.clases.estantes.datosTabla(),
                listaEstante, "nombre", "idestante");
            utilitarios.cargandoListas.cargarLista(conexiones_BD.clases.sucursales.datosTabla(),
                listaSucursal, "numero_de_sucursal", "idsucursal");
            lista = true;
        }

        private void chkCodi_CheckedChanged(object sender, EventArgs e)
        {
            cargandoLista();
        }

        private void chkNombre_CheckedChanged(object sender, EventArgs e)
        {
            cargandoLista();
        }

        private void txtBuscarP_TextChanged(object sender, EventArgs e)
        {
            tabla2.FiltrarLocalmenteSinContadorRegistros();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            agregar();
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
                quitar();  
        }

        private void txtBuscarP_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                agregar();
            }
            if (e.KeyCode == Keys.Left)
            {
                quitar();
            }
            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.L))
            {
                Listo.PerformClick();
                listasBusqueda.Focus();
            }
        }

        private void listasBusqueda_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cargandoProductos();               
            }
            
        }

        private void cargandoProductos()
        {
            try
            {
                DataRowView seleccion = (DataRowView)listasBusqueda.SelectedItem;
                txtnombreP.Text = seleccion.Row[3].ToString();
                txtCodigo.Text = seleccion.Row[2].ToString();
                listaMarca.SelectedValue = seleccion.Row[6].ToString();
                listaCategoria.SelectedValue = seleccion.Row[4].ToString();
                listaSucursal.SelectedValue = seleccion.Row[8].ToString();
                listaEstante.SelectedValue = seleccion.Row[10].ToString();
                fecha.Text = seleccion.Row[12].ToString();
                idsucursal_producto = seleccion.Row[0].ToString();
                idproducto = seleccion.Row[1].ToString();

                cargarTablaPresentaciones();

                txtBuscarP.Focus();
            }
            catch
            {
                if (MessageBox.Show("Deseas crear un producto nuevo", "No exite producto", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    mantenimientos.productos pr = new productos();
                    pr.listaCodigos.Text = listasBusqueda.Text;
                    pr.ShowDialog();
                }
            }
        }

        private void cargarTablaPresentaciones()
        {
            te.Text = "";
            tabla = new utilitarios.cargar_tablas(tabla_presentacion_producto,te, conexiones_BD.clases.presentaciones_productos.presentacionesXproducto(idsucursal_producto), "nombre_presentacion");
            tabla.cargarSinContadorRegistros();
        }

        private void Listo_Click(object sender, EventArgs e)
        {
            lista = false;
            listasBusqueda.SelectedValue = "0";
            txtnombreP.Text = "";
            txtCodigo.Text = "";
            listaMarca.SelectedValue = "0";
            listaCategoria.SelectedValue = "0";
            listaEstante.SelectedValue = "0";
            listaSucursal.SelectedValue = "0";
            fecha.Value=DateTime.Now;
            txtBuscarP.Text = "";
            tabla_presentacion_producto.DataSource = null;

            lista = true;
        }

        private void agregar()
        {
            if(!validar()){
                auxiliares.presentaciones_productos pp = new auxiliares.presentaciones_productos();
                pp.Idpresentacion = tabla_presentacion.CurrentRow.Cells[0].Value.ToString();
                pp.lblPresenta.Text = tabla_presentacion.CurrentRow.Cells[1].Value.ToString();
                pp.ShowDialog();

                if (pp.Agregado)
                {
                    string priori="2";
                    if (pp.chkPrioridad.Checked)
                    {
                        priori = "1";
                    }
                    prpr = new conexiones_BD.clases.presentaciones_productos(
                        idsucursal_producto,
                        pp.Idpresentacion,
                        pp.canti.Value.ToString(),
                        Math.Round(pp.precio.Value, 2).ToString(),
                        pp.TipoN,
                        priori,
                        "1"
                        );

                    if (prpr.guardar(false) > 0)
                    {
                        cargarTablaPresentaciones();
                        txtBuscarP.SelectAll();
                        txtBuscarP.Focus();
                    }
                }
            }
            
        }

        private void agregarProducto_Click(object sender, EventArgs e)
        {
            mantenimientos.productos pr = new productos();
            pr.listaCodigos.Text = listasBusqueda.Text;
            pr.ShowDialog();
        }

        private void agregaPresentaciones_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Escape)
            {
                this.Close();
            }
        }

        private void quitar()
        {
            if (tabla_presentacion_producto.Rows.Count!=0)
            {
                if (MessageBox.Show("¿Desea quitar esta presentación?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                {
                    try
                    {
                        prpr = new conexiones_BD.clases.presentaciones_productos(tabla_presentacion_producto.CurrentRow.Cells[0].Value.ToString());
                        if (prpr.eliminar(false) > 0)
                        {
                            cargarTablaPresentaciones();
                        }
                    }
                    catch
                    {

                    }
                }
            }
           
        }

        private bool validar()
        {
            error.Clear();
            bool valido=false;
            if(listasBusqueda.SelectedIndex == -1)
            {
                valido = true;
                error.SetError(listasBusqueda, "Busca un producto");
            }

            return valido;
        }

    }
}
