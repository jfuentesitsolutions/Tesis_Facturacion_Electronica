using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfaces.mantenimientos.negocio
{
    public partial class cambio_precios : Form
    {
        utilitarios.cargar_tablas tabla;
        TextBox te = new TextBox();
        string idsucursal_producto;
        string idpresentacion_producto;
        conexiones_BD.clases.presentaciones_productos pp;
        sessionManager.secion sesion = sessionManager.secion.Instancia;
        public cambio_precios()
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

        private void cambio_precios_Load(object sender, EventArgs e)
        {
            gadgets.horientaciones_textos.colocarTitulo(panelTitulo, lblEncanezado);
            cargandoLista();
            habilitar(false);
        }

        private void cargarTablaPresentaciones()
        {
            te.Text = "";
            tabla = new utilitarios.cargar_tablas(tabla_presentacion_producto, te, conexiones_BD.clases.presentaciones_productos.presentacionesXproducto(idsucursal_producto), "nombre_presentacion");
            tabla.cargarSinContadorRegistros();
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
            utilitarios.cargandoListas.cargarLista(conexiones_BD.clases.presentaciones.datosTabla(), listaPresentacion, "nombre_presentacion", "idpresentacion");

            
        }

        private void chkCodi_CheckedChanged(object sender, EventArgs e)
        {
            cargandoLista();
            limpiar();
            listasBusqueda.Focus();
        }

        private void chkNombre_CheckedChanged(object sender, EventArgs e)
        {
            cargandoLista();
            limpiar();
            listasBusqueda.Focus();
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

        private void habilitar(bool co)
        {
            List<Control> controles = new List<Control>();
            controles.Add(chkM);
            controles.Add(chkD);
            controles.Add(listaPresentacion);
            controles.Add(precio);
            controles.Add(canti);
            controles.Add(btnModifica);

            utilitarios.vaciando_formularios.habilitandoTexbox(controles, co);
        }

        private void precio_Enter(object sender, EventArgs e)
        {
            precio.Select(0, precio.Text.Length);
        }

        private void canti_Enter(object sender, EventArgs e)
        {
            canti.Select(0, canti.Text.Length);
        }

        private void tabla_presentacion_producto_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Right)
                {
                    habilitar(true);
                    idpresentacion_producto = tabla_presentacion_producto.CurrentRow.Cells[0].Value.ToString();
                    listaPresentacion.SelectedValue = tabla_presentacion_producto.CurrentRow.Cells[1].Value.ToString();
                    precio.Text = tabla_presentacion_producto.CurrentRow.Cells[3].Value.ToString();
                    canti.Text = tabla_presentacion_producto.CurrentRow.Cells[5].Value.ToString();
                    if (tabla_presentacion_producto.CurrentRow.Cells[4].Value.ToString().Equals("Detalle"))
                    {
                        chkD.Checked = true;
                        chkD.Focus();
                        chkM.Checked = false;
                    }
                    else
                    {
                        chkD.Checked = false;
                        chkM.Checked = true;
                        chkM.Focus();
                    }

                    if (tabla_presentacion_producto.CurrentRow.Cells[7].Value.ToString().Equals("1"))
                    {
                        chkPriori.Checked = true;
                    }else
                    {
                        chkPriori.Checked = false;
                    }

                }
            }
            catch
            {

            }
            
        }

        private void chkM_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);

            }
        }

        private void chkD_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);

            }
        }

        private void listaPresentacion_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);

            }
        }

        private void precio_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);

            }
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            modificar();
        }

        private void limpiar()
        {
            precio.Value = 0;
            canti.Value = 0;
            txtnombreP.Text = "";
            cargandoLista();
            habilitar(false);
            tabla_presentacion_producto.DataSource = null;
            chkPriori.Checked = false;
            listasBusqueda.Focus();
            
        }

        private void modificar()
        {
            string prio = "2";
            if (chkPriori.Checked)
            {
                prio = "1";
            }
            pp = new conexiones_BD.clases.presentaciones_productos(
                idpresentacion_producto, 
                idsucursal_producto,
                listaPresentacion.SelectedValue.ToString(), 
                canti.Value.ToString(), 
                precio.Value.ToString(), 
                tipoPrese(),
                prio);

            if (pp.modificar(true) > 0)
            {
                limpiar();

            }
        }

        private string tipoPrese()
        {
            if (chkM.Checked)
            {
                return "1";
            }else
            {
                return "2";
            }
        }

        private void cambio_precios_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.L))
            {
                limpiar();
                listasBusqueda.Focus();
            }

            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.N))
            {
                chkNombre.Checked = true;
            }

            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.C))
            {
                chkCodi.Checked = true;
            }
        }
    }
}
