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
    public partial class splash_espera : Form
    {
        public splash_espera()
        {
            InitializeComponent();
        }
        private int tipo_operacio=0;
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

        public Func<List<DataTable>> Funcion
        {
            get
            {
                return funcion;
            }

            set
            {
                funcion = value;
            }
        }


        public int Tipo_operacio
        {
            get
            {
                return tipo_operacio;
            }

            set
            {
                tipo_operacio = value;
            }
        }

        public Func<List<bool>> Funcion_listo
        {
            get
            {
                return funcion_listo;
            }

            set
            {
                funcion_listo = value;
            }
        }

        Action accion;

        Func<List<DataTable>> funcion;
        Func<List<bool>> funcion_listo;

        private void splash_espera_Shown(object sender, EventArgs e)
        {
            switch (tipo_operacio)
            {
                case 0:
                    {
                        Task.Factory.StartNew(Funcion).ContinueWith((t) => taskCompleted());
                        break;
                    }
                case 1:
                    {
                        Task.Factory.StartNew(Funcion_listo).ContinueWith((t) => taskCompleted());
                        break;
                    }
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void splash_espera_Load(object sender, EventArgs e)
        {
            
        }
    }
}
