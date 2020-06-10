using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfaces.paneles
{
    public partial class inventarios : Form
    {
        sessionManager.secion sesion = sessionManager.secion.Instancia;
        public inventarios()
        {
            InitializeComponent();
        }

        private void inventarios_Load(object sender, EventArgs e)
        {
            control_permisos.controlador_de_permisos per = new control_permisos.controlador_de_permisos(this.panelOpciones, conexiones_BD.clases.usuarios.permisosAsigandosInventario(sesion.Datos[5]));
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Inventarios.clientes_frecuentes frm = new Inventarios.clientes_frecuentes();
            frm.ShowDialog();
        }

        private void btnFarmacia_Click(object sender, EventArgs e)
        {
            farmacia.Control_de_medicina frm = new farmacia.Control_de_medicina();
            frm.ShowDialog();
        }
    }
}
