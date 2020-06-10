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
    public partial class codigosXpresentaciones : Form
    {
        sessionManager.secion sesion = sessionManager.secion.Instancia;
        string idsucursal_producto=null;
        utilitarios.cargar_tablas tabla;
        TextBox te = new TextBox();
        public codigosXpresentaciones()
        {
            InitializeComponent();
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

        private void cargandoLista()
        {

            if (chkCodi.Checked)
            {
                if (sesion.Datos[3].Equals("Administradores"))
                {
                    Console.WriteLine(sesion.DatosRegistro[1]);
                    utilitarios.cargandoListas.cargarLista(conexiones_BD.clases.productos.CARGAR_TABLA_PRODUCTOS(), listasBusqueda, "codP", "idSp");
                }
                else
                {
                    utilitarios.cargandoListas.cargarLista(conexiones_BD.clases.productos.CARGAR_TABLA_PRODUCTOS_X_SUCURSAL(sesion.DatosRegistro[1]), listasBusqueda, "codP", "idSp");
                }

            }
            else if (chkNombre.Checked)
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

        }

        private void listasBusqueda_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    DataRowView seleccion = (DataRowView)listasBusqueda.SelectedItem;
                    txtnombreP.Text = seleccion.Row[3].ToString();
                    idsucursal_producto = seleccion.Row[0].ToString();

                    cargarTablaPresentaciones();

                    tabla_presentacion_producto.Focus();
                }
                catch
                {

                }

            }
        }

        private void cargarTablaPresentaciones()
        {
            te.Text = "";
            tabla = new utilitarios.cargar_tablas(tabla_presentacion_producto, te, conexiones_BD.clases.presentaciones_productos.presentacionesXproducto(idsucursal_producto), "nombre_presentacion");
            tabla.cargarSinContadorRegistros();
        }

        private void codigosXpresentaciones_Load(object sender, EventArgs e)
        {
            gadgets.horientaciones_textos.colocarTitulo(panelTitulo, lblEncanezado);

            cargandoLista();
        }

        private void chkCodi_CheckedChanged(object sender, EventArgs e)
        {
            cargandoLista();
            listasBusqueda.Focus();
            txtnombreP.Text = "";
            tabla_presentacion_producto.DataSource = null;
        }

        private void chkNombre_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void codigosXpresentaciones_KeyUp(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.N))
            {
                chkNombre.Checked = true;
            }

            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.C))
            {
                chkCodi.Checked = true;
            }
            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.L))
            {
                cargandoLista();
                listasBusqueda.Focus();
                txtnombreP.Text = "";
                tabla_presentacion_producto.DataSource = null;
            }
        }
    }
}
