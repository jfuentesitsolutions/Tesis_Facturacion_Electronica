using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfaces.Reportes.Interfaz
{
    public partial class estadisticas_clientes : Form
    {
        private string fei, fef;

        public string Fei
        {
            get
            {
                return fei;
            }

            set
            {
                fei = value;
            }
        }

        public string Fef
        {
            get
            {
                return fef;
            }

            set
            {
                fef = value;
            }
        }

        public estadisticas_clientes()
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

        private void estadisticas_clientes_Load(object sender, EventArgs e)
        {
            gadgets.horientaciones_textos.colocarTitulo(panelTitulo, lblEncanezado);
            cargarDatos();
        }

        private void cargarDatos()
        {
            grafico.DataSource = conexiones_BD.clases.clientes.estadisticasXcliente(fei, fef);
            cargandoReporte();
        }

        private void cargandoReporte()
        {
            Reportes.Diseño.reporte_mejores_clientes repo = new Diseño.reporte_mejores_clientes();
            repo.SetDataSource(conexiones_BD.clases.clientes.estadisticasTodosClientes(fei, fef));
            visor_reporte.ReportSource = repo;
        }
    }
}
