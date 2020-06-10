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
    public partial class visor_reportes : Form
    {
        string encabezado = "";


        public visor_reportes()
        {
            InitializeComponent();
        }

        public string Encabezado
        {
            get
            {
                return encabezado;
            }

            set
            {
                encabezado = value;
            }
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

        private void visor_reportes_Load(object sender, EventArgs e)
        {
            lblEncanezado.Text = encabezado;
            gadgets.horientaciones_textos.colocarTitulo(panelTitulo, lblEncanezado);
        }

       
    }
}
