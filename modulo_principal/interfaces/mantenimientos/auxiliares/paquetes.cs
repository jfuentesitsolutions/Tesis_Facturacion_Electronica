using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfaces.mantenimientos.auxiliares
{
    public partial class paquetes : Form
    {
        Int32 totalUnidades;
        bool convertido = false;

        public int TotalUnidades
        {
            get
            {
                return totalUnidades;
            }

            set
            {
                totalUnidades = value;
            }
        }

        public bool Convertido
        {
            get
            {
                return convertido;
            }

            set
            {
                convertido = value;
            }
        }

        public paquetes()
        {
            InitializeComponent();
        }

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            gadgets.movimimientos mov = new gadgets.movimimientos();
            mov.moverFormulario(sender, e, this);
        }

        private void paquetes_Load(object sender, EventArgs e)
        {
            gadgets.horientaciones_textos.colocarTitulo(panelTitulo, lblTitulo);
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool validar()
        {
            bool valido = false;
            string mensaje = "Tienes que especificar una cantidad";
            error.Clear();

            if (NPa.Value.ToString().Equals("0"))
            {
                valido = true;
                error.SetError(NPa, mensaje);
            }

            if (Nu.Value.ToString().Equals("0"))
            {
                valido = true;
                error.SetError(Nu, mensaje);
            }

            return valido;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!validar())
            {
                totalUnidades = (Convert.ToInt32(NPa.Value.ToString()) * Convert.ToInt32(Nu.Value.ToString()));
                convertido = true;
                this.Close();
            }
        }
    }
}
