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
        DataTable datos;

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

        public DataTable Datos { get => datos; set => datos = value; }

        private void carga_tablas_Shown(object sender, EventArgs e)
        {
            if (retorno)
            {
                Task.Factory.StartNew(Productos).ContinueWith((t) => taskCompleted(t.Result));
            }else
            {
                Task.Factory.StartNew(accion).ContinueWith((t) => taskCompleted1());
            }
            
        }

        private void taskCompleted(DataTable p)
        {
            if (InvokeRequired)
            {
                this.Invoke((MethodInvoker)(() =>
                {
                    datos = p;
                    Close();
                    DialogResult = DialogResult.OK;
                }));
            }
        }

        private void taskCompleted1()
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
