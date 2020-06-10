using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using utilitarios;
using gadgets;
using conexiones_BD.clases.compras;

namespace interfaces.compras
{
    public partial class anular_compra : Form
    {
        sessionManager.secion sesion = sessionManager.secion.Instancia;
        DataTable vendedor = conexiones_BD.clases.usuarios.datosTabla();
        DataTable productos = new DataTable();
        public anular_compra()
        {
            InitializeComponent();
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void anular_compra_Load(object sender, EventArgs e)
        {
            horientaciones_textos.colocarTitulo(panelTitulo, lblEncanezado);
            this.cargarLista();
        }

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            movimimientos mov = new movimimientos();
            mov.moverFormulario(sender, e, this);
        }

        private void cargarLista()
        {
            maneja_fechas fecha = new maneja_fechas();
            cargandoListas.cargarLista(conexiones_BD.clases.compras.compras.factura_ingresadas(fecha.fechaCortaMysql(fechaa)), listaDocu, "numero_factura", "numero_factura");
            if (listaDocu.Items.Count!=0)
            {
                listaDocu.SelectedIndex = 0;
                cargarFactura();
            }else
            {
                listaDocu.Text = "";
            }
            utilitarios.cargandoListas.cargarLista(vendedor, listaVendedor, "usuario", "idusuario");
            int index = listaVendedor.FindStringExact(sesion.Datos[0]);
            listaVendedor.SelectedIndex = index;
        }

        private void cargarFactura()
        {

            try
            {
                if (listaDocu.Items.Count != 0)
                {
                    productos = conexiones_BD.clases.compras.compras.facturas_ingresadas_sin_anular(sesion.DatosRegistro[1], listaDocu.SelectedValue.ToString());
                    Reportes.Diseño.facturas_compras repo = new Reportes.Diseño.facturas_compras();
                    repo.SetDataSource(productos);
                    reporte.ReportSource = repo;
                }else
                {
                    MessageBox.Show("No hay facturas ingresadas en esa fecha", "No hay registros", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    reporte.ReportSource = null;
                }

            }
            catch
            {
                
            }
            
            
        }

        private void listaDocu_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listaDocu.Items.Count != 0)
                {
                    cargarFactura();
                }
            }
            catch
            {

            }
        }

        private void fechaa_ValueChanged(object sender, EventArgs e)
        {
            listaDocu.DataSource = null;
            cargarLista();
            cargarFactura();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            if (!validar())
            {
                if (MessageBox.Show("¿Deseas anular la factura número: "+productos.Rows[0][1].ToString(),"Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                {
                    anulandoFactura();
                }
            }
        }

        private void anulandoFactura()
        {
            utilitarios.maneja_fechas f = new maneja_fechas();
            if (productos != null)
            {
                conexiones_BD.clases.compras.compras c = new conexiones_BD.clases.compras.compras(productos.Rows[0][18].ToString(), "2");
                anulaciones_compras ac = new anulaciones_compras(productos.Rows[0][18].ToString(), txtJustificacion.Text, listaVendedor.SelectedValue.ToString(), f.fechaMysql(fec));
                conexiones_BD.operaciones op = new conexiones_BD.operaciones();
                if (op.transaccionAnulacionCompras(c, ac, modificaExistencias(productos)) > 0)
                {
                    MessageBox.Show("La factura se anulo con éxito", "Anulación éxitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.cargarLista();
                    this.cargarFactura();


                } else
                {
                    MessageBox.Show("La factura no se pudo anular", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                

            }
        }

        private List<conexiones_BD.clases.sucursales_productos> modificaExistencias(DataTable p)
        {
            List<conexiones_BD.clases.sucursales_productos> pro = new List<conexiones_BD.clases.sucursales_productos>();
            int exis = 0;
            int cantidad = 0;
            int total = 0;

            foreach (DataRow fila in p.Rows)
            {
                exis = Convert.ToInt32(fila[17]);
                cantidad = Convert.ToInt32(fila[10]);
                total = exis - cantidad;

                pro.Add(new conexiones_BD.clases.sucursales_productos(fila[14].ToString(),
                    total.ToString())
                    );
            }
            return pro;
        }

        private bool validar()
        {
            bool valido = false;
            error.Clear();
            string mensaje = "Tienes que especificar una justificación";

            if (txtJustificacion.TextLength == 0)
            {
                valido = true;
                error.SetError(txtJustificacion, mensaje);
            }

            return valido;
        }
    }
}
