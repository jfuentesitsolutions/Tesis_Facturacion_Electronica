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

namespace interfaces.Inventarios
{
    public partial class clientes_frecuentes : Form
    {
        cargar_tablas tabla, detalles;
        private string fi, ff;

        public clientes_frecuentes()
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

        private void clientes_frecuentes_Load(object sender, EventArgs e)
        {
            gadgets.horientaciones_textos.colocarTitulo(panelTitulo, lblEncanezado);
            cargandoTablas();

            DateTime fec = fechaFinal.Value;
            fechaInicio.Text = "01/01/"+fec.Year;
            utilitarios.maneja_fechas fecha = new maneja_fechas();
            fi = fec.Year.ToString() + "-01-01 00:00:00";
            ff = fecha.fechaCortaMysql(fechaFinal) + " 23:59:59";

            activandoAreaDetalles(false);
        }

        private void txtBusquedaClientes_TextChanged(object sender, EventArgs e)
        {
            tabla.FiltrarLocalmenteSinContadorRegistros();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBusquedaClientes.Text = "";
        }

        private void cargandoTablas()
        {
            tabla = new cargar_tablas(tabla_Clientes, txtBusquedaClientes, conexiones_BD.clases.clientes.datosClientes2(), "nombre");
            tabla.cargarSinContadorRegistros();
        }

        private void txtBusquedaClientes_Enter(object sender, EventArgs e)
        {
            activandoAreaDetalles(false);
        }

        private void tabla_Clientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tabla_Clientes.RowCount != 0)
            {
                colocandoDatosClientes();
                activandoAreaDetalles(true);
            }
        }

        private void activandoAreaDetalles(bool tipo)
        {
            grpDatos.Visible = tipo;
            grpFechas.Visible = tipo;
            grpDescripcion.Visible = tipo;
        }

        private void colocandoDatosClientes()
        {
            txtNombre.Text = tabla_Clientes.CurrentRow.Cells[0].Value.ToString();
            txtDireccion.Text = tabla_Clientes.CurrentRow.Cells[1].Value.ToString();
            txtCodigo.Text = tabla_Clientes.CurrentRow.Cells[3].Value.ToString();
            colocandoDetallesdeVentas();
            
             
        }

        private void colocandoDetallesdeVentas()
        {
            utilitarios.maneja_fechas fecha = new maneja_fechas();
            DateTime fec = fechaFinal.Value;
            string fechai=fec.Year.ToString()+"-01-01 00:00:00";
            string fechaf=fecha.fechaCortaMysql(fechaFinal)+" 23:59:59";
            Console.WriteLine(fechaf);
            lblTotal.Text = "$" + conexiones_BD.clases.clientes.ventasXcliente(tabla_Clientes.CurrentRow.Cells[2].Value.ToString(), fechai, fechaf).Rows[0][0].ToString();
            cargandoCompras(fechai, fechaf);
        }

        private void fechaInicio_ValueChanged(object sender, EventArgs e)
        {
            utilitarios.maneja_fechas fecha = new maneja_fechas(); 
            DateTime fec = fechaInicio.Value;
            string fechai = fecha.fechaCortaMysql(fechaInicio) + " 00:00:00";
            string fechaf = fecha.fechaCortaMysql(fechaFinal) + " 23:59:59";
            DataTable dato = conexiones_BD.clases.clientes.ventasXcliente(tabla_Clientes.CurrentRow.Cells[2].Value.ToString(), fechai, fechaf);

            if (dato.Rows.Count == 0)
            {
                MessageBox.Show("No existe comprar en esas fechas", "No hay compras", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lblTotal.Text = "$" + dato.Rows[0][0].ToString();
                cargandoCompras(fechai, fechaf);
            }

            
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            int id = (int)tabla_Clientes.CurrentRow.Cells[2].Value;
            Reportes.Interfaz.visor_reportes frm = new Reportes.Interfaz.visor_reportes();
            frm.Encabezado = "Reporte de cliente";
            Reportes.Diseño.reporte_comprasXcliente repo= new Reportes.Diseño.reporte_comprasXcliente();
            repo.SetDataSource(conexiones_BD.clases.clientes.detalleventasXclientes(id, fi, ff));
            repo.SetParameterValue("nombre_cliente", txtNombre.Text);
            repo.SetParameterValue("fecha_inicial", fi);
            repo.SetParameterValue("fecha_final", ff);
            repo.SetParameterValue("direccion", txtDireccion.Text);
            repo.SetParameterValue("monto_total", lblTotal.Text);
            frm.reporte.ReportSource=repo;

            frm.ShowDialog();

        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            Reportes.Interfaz.estadisticas_clientes frm = new Reportes.Interfaz.estadisticas_clientes();
            frm.Fei = fi;
            frm.Fef = ff;
            frm.ShowDialog();
        }

        private void cargandoCompras(string fi, string ff)
        {
            int id = (int)tabla_Clientes.CurrentRow.Cells[2].Value;
            detalles = new cargar_tablas(tabla_detalles, new TextBox(), conexiones_BD.clases.clientes.detalleventasXclientes(id, fi, ff), "correlativo");
            detalles.cargarSinContadorRegistros();
        }
    }
}
