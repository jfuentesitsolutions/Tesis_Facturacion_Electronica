using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfaces.farmacia
{
    public partial class Control_de_medicina : Form
    {
        utilitarios.cargar_tablas tabla, tabla2;
        sessionManager.secion sesion = sessionManager.secion.Instancia;
        public Control_de_medicina()
        {
            InitializeComponent();
            this.adecuandoPanel();
        }

        private void Control_de_medicina_Load(object sender, EventArgs e)
        {
            gadgets.horientaciones_textos.colocarTitulo(panelTitulo, lblEncanezado);
            this.activandoControles();
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

        private void adecuandoPanel()
        {
            if (this.Width == 972)
            {
                this.Width = 470;
                this.StartPosition = FormStartPosition.CenterParent;
                this.panel_derecho.Visible = false;
            }
        }

        private void activandoControles()
        {
            if (chkCaja_activa.Checked)
            {
                fechaInicial.Enabled = false;
                fechaFinal.Enabled = false;
                btnBuscar.Enabled = false;
                this.cargandoTabla1();

            } else
            {
                fechaInicial.Enabled = true;
                fechaFinal.Enabled = true;
                btnBuscar.Enabled = true;

                if (sesion.Caja_activa)
                {
                    tabla.TablaDatos = null;
                    tabla.ContenidoTabla = null;
                    tabla_detalle_venta.DataSource = null;
                }

            }
        }

        private void cargandoTabla1()
        {
            if (sesion.Caja_activa)
            {
                tabla = new utilitarios.cargar_tablas(tabla_detalle_venta, txtBusqueda, conexiones_BD.farmacias.datos_productos_farmacia(sesion.Idcaja), "nom_producto");
                tabla.cargarSinContadorRegistros();
            }
            else
            {
                MessageBox.Show("No se ha detectado apertura de caja.\nsi desea ver registros habilite la opción periodo\nluego elija el periodo y presione buscar", "No hay caja activa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                chkCaja_activa.Enabled = false;
                if (tabla != null)
                {
                    tabla.TablaDatos = null;
                    tabla.ContenidoTabla = null;
                    tabla_detalle_venta.DataSource = null;
                }
            }

        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (tabla != null)
            {
                if (tabla.TablaDatos != null)
                {
                    tabla.FiltrarLocalmenteSinContadorRegistros();
                }

            }
        }

        private void chkPeriodo_CheckedChanged(object sender, EventArgs e)
        {
            this.activandoControles();
        }

        private void chkCaja_activa_CheckedChanged(object sender, EventArgs e)
        {

            this.activandoControles();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (sesion.Caja_activa)
            {
                tabla.TablaDatos = conexiones_BD.farmacias.datos_productos_farmacia_periodo(fechaInicial.Value.ToString("yyyy-MM-dd"), fechaFinal.Value.ToString("yyyy-MM-dd"));
                tabla.ContenidoTabla = new BindingSource();
                tabla.cargarSinContadorRegistros();
            } else
            {
                tabla = new utilitarios.cargar_tablas(tabla_detalle_venta, txtBusqueda, conexiones_BD.farmacias.datos_productos_farmacia_periodo(fechaInicial.Value.ToString("yyyy-MM-dd"), fechaFinal.Value.ToString("yyyy-MM-dd")), "nom_producto");
                tabla.cargarSinContadorRegistros();
            }


        }

        private void tabla_detalle_venta_Click(object sender, EventArgs e)
        {

            if (tabla_detalle_venta.RowCount != 0)
            {
                this.cargandoTabla2(tabla_detalle_venta.CurrentRow.Cells[3].Value.ToString());
                lblNombre.Text = tabla_detalle_venta.CurrentRow.Cells[0].Value.ToString();
                if (this.Width != 972)
                {
                    this.Width = 972;
                    panel_derecho.Visible = true;
                    gadgets.horientaciones_textos.colocarTitulo(panelTitulo, lblEncanezado);
                    this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
                    this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
                }

            }
        }

        private void btnImprimirReporte_Click(object sender, EventArgs e)
        {
            mostrarReporte();
        }

        private void mostrarReporte()
        {
            if (tabla_detalle_venta.RowCount != 0)
            {
                Reportes.Interfaz.visor_reportes frm = new Reportes.Interfaz.visor_reportes();
                frm.Encabezado = "Reporte de ventas de medicina";
                Reportes.Diseño.reporte_ventas_medicina repo_farmacia = new Reportes.Diseño.reporte_ventas_medicina();

                if (!sesion.Caja_activa || chkPeriodo.Checked)
                {
                    repo_farmacia.SetDataSource(conexiones_BD.farmacias.todos_datos_productos_id_periodo(fechaInicial.Value.ToString("yyyy-MM-dd"), fechaFinal.Value.ToString("yyyy-MM-dd")));
                    repo_farmacia.SetParameterValue("encabezado", "REPORTE VENTA DE MEDICINA");
                    repo_farmacia.SetParameterValue("fecha", "De: " + fechaInicial.Value.ToString("dd-MM-yyyy") + " A " + fechaFinal.Value.ToString("dd-MM-yyyy"));
                    frm.reporte.ReportSource = repo_farmacia;
                }
                else
                {
                    repo_farmacia.SetDataSource(conexiones_BD.farmacias.todos_datos_productos_id(sesion.Idcaja));
                    repo_farmacia.SetParameterValue("encabezado", "REPORTE VENTA DE MEDICINA");
                    repo_farmacia.SetParameterValue("fecha", "Caja número: "+sesion.Idcaja);
                    frm.reporte.ReportSource = repo_farmacia;
                }
                


                frm.ShowDialog();
            }

        }

        private DataSet datosSubReporte()
        {

            DataSet datos = new DataSet();
            BindingSource dato = tabla_detalle_venta.DataSource as BindingSource;
            DataTable da = dato.DataSource as DataTable;

            datos.Tables.Add(da);


            return datos;
        }

        private void cargandoTabla2(string idsuc)
        {
            if (sesion.Caja_activa)
            {
                if (chkCaja_activa.Checked)
                {
                    if (tabla2 == null)
                    {
                        tabla2 = new utilitarios.cargar_tablas(tabla_detalles, new TextBox(), conexiones_BD.farmacias.datos_productos_id(sesion.Idcaja, idsuc), "");
                        tabla2.cargarSinContadorRegistros();
                    }
                    else
                    {
                        tabla2.TablaDatos = conexiones_BD.farmacias.datos_productos_id(sesion.Idcaja, idsuc);
                        tabla2.ContenidoTabla = new BindingSource();
                        tabla2.cargarSinContadorRegistros();
                    }
                }else if (chkPeriodo.Checked)
                {
                    if (tabla2 == null)
                    {
                        tabla2 = new utilitarios.cargar_tablas(tabla_detalles, new TextBox(), conexiones_BD.farmacias.datos_productos_id_periodo(fechaInicial.Value.ToString("yyyy-MM-dd"), fechaFinal.Value.ToString("yyyy-MM-dd"), idsuc), "");
                        tabla2.cargarSinContadorRegistros();
                    }
                    else
                    {
                        tabla2.TablaDatos = conexiones_BD.farmacias.datos_productos_id_periodo(fechaInicial.Value.ToString("yyyy-MM-dd"), fechaFinal.Value.ToString("yyyy-MM-dd"), idsuc);
                        tabla2.ContenidoTabla = new BindingSource();
                        tabla2.cargarSinContadorRegistros();
                    }
                }   
            }else
            {
                if (tabla2 == null)
                {
                    tabla2 = new utilitarios.cargar_tablas(tabla_detalles, new TextBox(), conexiones_BD.farmacias.datos_productos_id_periodo(fechaInicial.Value.ToString("yyyy-MM-dd"), fechaFinal.Value.ToString("yyyy-MM-dd"), idsuc), "");
                    tabla2.cargarSinContadorRegistros();
                }
                else
                {
                    tabla2.TablaDatos = conexiones_BD.farmacias.datos_productos_id_periodo(fechaInicial.Value.ToString("yyyy-MM-dd"), fechaFinal.Value.ToString("yyyy-MM-dd"), idsuc);
                    tabla2.ContenidoTabla = new BindingSource();
                    tabla2.cargarSinContadorRegistros();

                }
                
            }
            
        }
    }
}
