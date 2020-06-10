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
    public partial class datos_emisor_receptor : Form
    {
        bool valido = false;

        public bool Valido
        {
            get
            {
                return valido;
            }

            set
            {
                valido = value;
            }
        }

        public datos_emisor_receptor()
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

        private void datos_emisor_receptor_Load(object sender, EventArgs e)
        {
            gadgets.horientaciones_textos.colocarTitulo(panelTitulo, lblEncanezado);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!validar())
            {
                this.Valido = true;
                this.Close();
            }
            
        }

        private bool validar()
        {
            bool valido = false;
            error.Clear();
            List<TextBox> textos = new List<TextBox>();
            textos.Add(txtNentrega);
            textos.Add(txtDentrega);
            textos.Add(txtNientrega);
            textos.Add(txtNrecibe);
            textos.Add(txtDrecibe);
            textos.Add(txtNirecibe);

            valido =utilitarios.vaciando_formularios.validando(textos, error);

            return valido;
        }
    }
}
