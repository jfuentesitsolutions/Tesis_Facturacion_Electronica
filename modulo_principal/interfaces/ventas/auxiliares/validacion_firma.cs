using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfaces.ventas.auxiliares
{
    public partial class validacion_firma : Form
    {
        bool vali = false;

        public bool Vali
        {
            get
            {
                return vali;
            }

            set
            {
                vali = value;
            }
        }

        public validacion_firma()
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

        private void validacion_firma_Load(object sender, EventArgs e)
        {
            gadgets.horientaciones_textos.colocarTitulo(panelTitulo, lblEncanezado);
        }

        private void chkMostrar_CheckedChanged(object sender, EventArgs e)
        {
            String texto = txtContrase.Text;

            txtContrase.UseSystemPasswordChar = !chkMostrar.Checked;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (!validar())
            {
                vali = true;
                this.Close();
            }
        }

        private bool validar()
        {
            bool valido = false;
            error.Clear();

            if (txtContrase.Text.Length == 0)
            {
                error.SetError(txtContrase, "Coloca una contraseña");
                valido = true;
            }

            if (listaTipoFactura.SelectedIndex == -1)
            {
                error.SetError(listaTipoFactura, "Elije un tipo de documento");
                valido = true;
            }

            return valido;
        }
    }
}
