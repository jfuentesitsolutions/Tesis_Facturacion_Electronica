using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfaces.ventas.panel
{
    public partial class anulacion_de_ventas : Form
    {
        bool despliegue = false;
        sessionManager.secion sesion = sessionManager.secion.Instancia;
        DataTable vendedor = conexiones_BD.clases.usuarios.datosTabla();
        Action accion;
        public anulacion_de_ventas()
        {
            InitializeComponent();
        }

        private void anulacion_de_ventas_SizeChanged(object sender, EventArgs e)
        {
            if (despliegue)
            {
                if (anulacion.Width == 403)
                {
                    anulacion.Width = 560;
                }
                else
                {
                    anulacion.Width = 403;
                }
            }
            else
            {
                despliegue = true;
            }
        }

        private void quitarPestaña()
        {
            Panel pan = (Panel)this.Parent;
            TabPage pagi = (TabPage)pan.Parent;
            TabControl con = (TabControl)pagi.Parent;

            try
            {
                if (con.TabPages.Count > 1)
                {
                    con.TabPages.Remove(con.SelectedTab);
                }

            }
            catch
            {

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            quitarPestaña();
        }

        private void cargar()
        {
            utilitarios.maneja_fechas fe = new utilitarios.maneja_fechas();
            DataTable docu = conexiones_BD.clases.ventas.tickets.datosTabla(fe.fechaCortaMysql(fecha), sesion.DatosRegistro[1]);
            if (listaDocumentos.SelectedIndex == 0)
            {
                
                if (docu.Rows.Count!=0)
                {
                    utilitarios.cargandoListas.cargarLista(docu, listaDocu, "correlativo", "idventa");
                    listaDocu.SelectedIndex = 0;
                }
                
            }
            else
            {
                
            }
        }

        private void anulacion_de_ventas_Load(object sender, EventArgs e)
        {
            Thread t = new Thread(creandoAccion);
            t.Start();
        }

        private void creandoAccion()
        {
            accion = cargandoTodo;
            if (InvokeRequired)
            {
                Invoke(accion);
            }
        }

        private void cargandoTodo()
        {
            listaDocumentos.SelectedIndex = 0;
            utilitarios.cargandoListas.cargarLista(vendedor, listaVendedor, "usuario", "idusuario");
            int index = listaVendedor.FindStringExact(sesion.Datos[0]);
            listaVendedor.SelectedIndex = index;
            cargar();
        }

        private void fecha_ValueChanged(object sender, EventArgs e)
        {
            listaDocu.DataSource = null;
            cargar();
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            if (!validar())
            {
                if (MessageBox.Show("¿Desea eliminar este documento","Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)==DialogResult.Yes)
                {
                    if (anulando())
                    {
                        fecha.Value = DateTime.Now;
                        reporte.ReportSource = null;
                        txtJustificacion.Text = "";
                    }
                }
            }
        }

        private bool validar()
        {
            bool valido = false;
            error.Clear();
            string mensaje = "No puedes dejar este campo vacio";

            if (listaDocu.SelectedIndex == -1)
            {
                valido = true;
                error.SetError(listaDocu, mensaje);
            }
            if (txtJustificacion.TextLength==0)
            {
                valido = true;
                error.SetError(txtJustificacion, mensaje);
            }
            return valido;
        }

        private void listaDocu_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listaDocu.Items.Count!=0)
                {
                    Reportes.Diseño.anulacion_tick repo = new Reportes.Diseño.anulacion_tick();
                    repo.SetDataSource(conexiones_BD.clases.ventas.ventas.anulacion_ticket(listaDocu.SelectedValue.ToString()));
                    reporte.ReportSource = repo;
                }
                
            }
            catch
            {

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
                exis = Convert.ToInt32(fila[0]);
                cantidad = Convert.ToInt32(fila[2]);
                total = exis + cantidad;

                pro.Add(new conexiones_BD.clases.sucursales_productos(fila[1].ToString(),
                    total.ToString())
                    );
            }
            return pro;
        }
     
        private bool anulando()
        {
            utilitarios.maneja_fechas fe = new utilitarios.maneja_fechas();
            

            bool anulado=false;
            conexiones_BD.clases.ventas.tickets anu = new conexiones_BD.clases.ventas.tickets(listaDocu.SelectedValue.ToString(),"2");
            conexiones_BD.clases.ventas.anulaciones anula = new conexiones_BD.clases.ventas.anulaciones(listaDocu.SelectedValue.ToString(),
                txtJustificacion.Text,
                listaVendedor.SelectedValue.ToString(),
                fe.fechaMysql(fec)
                );
            conexiones_BD.operaciones op = new conexiones_BD.operaciones();
            if (op.transaccionAnulacionVentaTic(anu, anula, modificaExistencias(conexiones_BD.clases.productos.EXISTENCIAS_PRODUCTOS_X_IDVENTA(listaDocu.SelectedValue.ToString())))>0)
            {
                MessageBox.Show("Ticket anulado con éxito", "éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                anulado = true;
            } else
            {
                MessageBox.Show("Se produjo algun error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                anulado = false;
            }

            return anulado;
        }   
    }
}
