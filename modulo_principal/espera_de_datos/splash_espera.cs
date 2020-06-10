using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace espera_de_datos
{
    public partial class splash_espera : Form
    {
        string titulo;

        public string Titulo
        {
            get
            {
                return titulo;
            }

            set
            {
                titulo = value;
            }
        }

        public Action Accion
        {
            get
            {
                return accion;
            }

            set
            {
                accion = value;
            }
        }

        Action accion;
        public splash_espera()
        {
            InitializeComponent();
        }

        private void splash_espera_Shown(object sender, EventArgs e)
        {
            lblMensaje.Text = titulo;
            Task.Factory.StartNew(accion).ContinueWith((t) => taskCompleted());
        }

        private void taskCompleted()
        {
            if (InvokeRequired)
            {
                this.Invoke((MethodInvoker)(() =>
                {
                    Close();
                    DialogResult = DialogResult.OK;
                }));
            }
        }
    }
}
