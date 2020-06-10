using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfaces.productos
{
    public partial class precios_productos : Form
    {
        utilitarios.cargar_tablas tabla;
        DataTable productos;

        public DataTable Productos
        {
            get
            {
                return productos;
            }

            set
            {
                productos = value;
            }
        }

        public precios_productos()
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

        private void precios_productos_Load(object sender, EventArgs e)
        {
            
            gadgets.horientaciones_textos.colocarTitulo(panelTitulo, lblEncanezado);
            cargarTablas();
        }

        private void cargarTablas()
        {
            tabla = new utilitarios.cargar_tablas(tablad, txtBusqueda, productos, "productoCod");
            tabla.cargarSinContadorRegistros();
            lblTotal.Text = productos.Rows.Count.ToString()+" productos encontrados.";

        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            tabla.FiltrarLocalmenteSinContadorRegistros();
        }

        private void txtBusqueda_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {         
                    tablad.Focus();
                
            } else if (e.KeyCode== Keys.Enter)
            {
                this.cargarDatos();
            }
        }

        private void tablad_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                txtBusqueda.Focus();
            }else if(e.KeyCode == Keys.Enter){
                this.cargarDatos();
            }
        }

        private void tablad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private List<DataTable> procesarDatos()
        {
            List<DataTable> datos = new List<DataTable>();
            datos.Add(conexiones_BD.clases.marcas.datosTabla());
            datos.Add(conexiones_BD.clases.categorias.datosTabla());
            datos.Add(conexiones_BD.clases.estantes.datosTabla());
            datos.Add(conexiones_BD.clases.utilidades.datosTablaMayoreo());
            datos.Add(conexiones_BD.clases.utilidades.datosTablaDetalle());
            return datos;
        }

        private void cargarDatos()
        {
            if (tablad.Rows.Count != 0)
            {

                using (espera_datos.splash_espera fe = new espera_datos.splash_espera()) {

                    fe.Funcion = procesarDatos;

                    if (fe.ShowDialog() == DialogResult.OK)
                    {
                        List<DataTable> listas = fe.Funcion();
                        producto pr = new producto();

                        pr.txtCodigo.Text = tablad.CurrentRow.Cells[1].Value.ToString();
                        pr.txtNombre.Text = tablad.CurrentRow.Cells[2].Value.ToString();
                        pr.existencia.Value = Convert.ToDecimal(tablad.CurrentRow.Cells[6].Value.ToString());

                        pr.Idmarca = tablad.CurrentRow.Cells[15].Value.ToString();
                        pr.Idcategoria = tablad.CurrentRow.Cells[16].Value.ToString();
                        pr.Idestante = tablad.CurrentRow.Cells[17].Value.ToString();
                        pr.Kardex = tablad.CurrentRow.Cells[18].Value.ToString();
                        
                        
                        if (!tablad.CurrentRow.Cells[19].Value.ToString().Equals(""))
                        {
                            pr.fecha.Value = Convert.ToDateTime(tablad.CurrentRow.Cells[19].Value.ToString());
                        }
                        
                        pr.Marcas = listas[0];
                        pr.Categorias = listas[1];
                        pr.Estantes = listas[2];
                        pr.Mayoreo = listas[3];
                        pr.Detalle = listas[4];


                        pr.Idsuc_produ = tablad.CurrentRow.Cells[0].Value.ToString();
                        pr.Idproducto = tablad.CurrentRow.Cells[14].Value.ToString();

                        pr.Utili_m = tablad.CurrentRow.Cells[20].Value.ToString();
                        pr.Utili_d = tablad.CurrentRow.Cells[21].Value.ToString();
                        pr.Pv = tablad.CurrentRow.Cells[22].Value.ToString();
                        pr.Pc = tablad.CurrentRow.Cells[23].Value.ToString();
                        pr.Pvm = tablad.CurrentRow.Cells[24].Value.ToString();
                        pr.Pcm = tablad.CurrentRow.Cells[25].Value.ToString();


                        pr.ShowDialog();

                        if (tablad.Rows.Count != 0)
                        {
                            tablad.CurrentCell = tablad.Rows[0].Cells[1];
                        }

                        if (pr.Actualiza)
                        {
                            using (espera_datos.carga_tablas es = new espera_datos.carga_tablas())
                            {

                                es.Productos = cargarDatosP;

                                if (es.ShowDialog() == DialogResult.OK)
                                {
                                    productos = es.Productos();
                                    cargarTablas();
                                    txtBusqueda.Focus();
                                }
                                
                              }
                        }
                    }
                    else
                    {
                        MessageBox.Show("La carga de productos a sido cancelada...");
                    }
                }
                    
            }
            else
            {
                txtBusqueda.Text = "";
                txtBusqueda.Focus();
                
            }     
        }

        private DataTable cargarDatosP()
        {
            DataTable datos = conexiones_BD.clases.productos.CARGAR_TABLA_PRODUCTOS_VENT();
            
            return datos;
        }


    }
}
