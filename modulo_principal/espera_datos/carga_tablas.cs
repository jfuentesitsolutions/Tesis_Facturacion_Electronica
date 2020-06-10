using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace espera_datos
{
    public partial class carga_tablas : Form
    {
        public carga_tablas()
        {
            InitializeComponent();
        }
        bool retorno=true;

        Action accion;
        Func<DataTable> productos;

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

        public Func<DataTable> Productos
        {
            get
            {
                return productos;
            }

            set
            {
                productos = value;
            }
        }

        public bool Retorno
        {
            get
            {
                return retorno;
            }

            set
            {
                retorno = value;
            }
        }

        private void carga_tablas_Shown(object sender, EventArgs e)
        {
            if (retorno)
            {
                Task.Factory.StartNew(Productos).ContinueWith((t) => taskCompleted());
            }else
            {
                Task.Factory.StartNew(accion).ContinueWith((t) => taskCompleted());
            }
            
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
