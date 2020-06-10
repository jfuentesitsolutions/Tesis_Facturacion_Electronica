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
    public partial class ventas_diarias : Form
    {
        bool despliegue = false;
        sessionManager.secion sesion = sessionManager.secion.Instancia;
        Action accion;
        
        public ventas_diarias()
        {
            InitializeComponent();
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            utilitarios.maneja_fechas fe = new utilitarios.maneja_fechas();

            Reportes.Diseño.reporteVentasaldia repo = new Reportes.Diseño.reporteVentasaldia();
            repo.SetDataSource(conexiones_BD.clases.ventas.ventas.ventas_diarias(fe.fechaCortaMysql(fecha), sesion.DatosRegistro[1]));
            ventas.ReportSource = repo;
            calcularTotalVentas();
        }

        private void ventas_diarias_SizeChanged(object sender, EventArgs e)
        {
            if (despliegue)
            {
                Console.WriteLine(this.Width);
                if (this.Width == 1092)
                {
                    ventas.Width = 728;
                }
                else
                {
                    
                    ventas.Width = 570;
                }
            }else
            {
                Console.WriteLine("DEspliegue:" + this.Width);
                Console.WriteLine(this.Width);
                despliegue = true;
            }
            
        }

        private void ventas_diarias_Load(object sender, EventArgs e)
        {
            Thread t = new Thread(creandoAccion);
            t.Start();
        }


        private void creandoAccion()
        {
            accion = cargarTodo;
            if (InvokeRequired)
            {
                Invoke(accion);
            }
        }

        private void cargarTodo()
        {
            utilitarios.maneja_fechas fe = new utilitarios.maneja_fechas();
            Reportes.Diseño.reporteVentasaldia repo = new Reportes.Diseño.reporteVentasaldia();
            repo.SetDataSource(conexiones_BD.clases.ventas.ventas.ventas_diarias(fe.fechaCortaMysql(fecha), sesion.DatosRegistro[1]));
            ventas.ReportSource = repo;
            calcularTotalVentas();
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            quitarPestaña();
        }

        private void calcularTotalVentas()
        {
            double suma = 0;
            double tic = 0;
            double fac = 0;
            utilitarios.maneja_fechas fe = new utilitarios.maneja_fechas();
            DataTable dato = conexiones_BD.clases.ventas.ventas.ventas_diarias(fe.fechaCortaMysql(fecha), sesion.DatosRegistro[1]);

            foreach (DataRow fila in dato.Rows)
            {
                suma += Convert.ToDouble(fila[3].ToString());

                char[] ti = fila[0].ToString().ToArray();
                if (ti[0]=='T')
                {
                    tic += Convert.ToDouble(fila[3].ToString());
                }else if(ti[0] == 'F')
                {
                    fac += Convert.ToDouble(fila[3].ToString());
                }
            }

            lblTotal.Text = String.Format("{0:c}", suma);
            lblTic.Text = String.Format("{0:c}", tic);
            lblFac.Text = String.Format("{0:c}", fac);
        }
    }
}
