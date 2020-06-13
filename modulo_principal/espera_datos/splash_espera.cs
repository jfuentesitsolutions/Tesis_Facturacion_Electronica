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
        Func<int> funcion_verificar;
        Func<bool> validando;
        int numero = 1;
        List<DataTable> datos_varios = null;
        DataTable datos = null;
        bool creado = false;

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

        public Func<int> Funcion_verificar { get => funcion_verificar; set => funcion_verificar = value; }
        public int Numero { get => numero; set => numero = value; }
        public Func<bool> Validar { get => validando; set => validando = value; }
        public List<DataTable> Datos_varios { get => datos_varios; set => datos_varios = value; }
        public DataTable Datos { get => datos; set => datos = value; }
        public bool Creado { get => creado; set => creado = value; }

        Action accion;
        Func<List<DataTable>> funcion;
        Func<List<bool>> funcion_listo;
        private void splash_espera_Shown(object sender, EventArgs e)
        {
            switch (tipo_operacio)
            {
                case 0:
                    {
                        Task.Factory.StartNew(Funcion).ContinueWith((t) => taskCompleted(t.Result[0], t.Result));
                        break;
                    }
                case 1:
                    {
                        Task.Factory.StartNew(Funcion_listo).ContinueWith((t) => taskCompleted1(t.Result[0]));
                        break;
                    }
                case 2:
                    {
                        Task.Factory.StartNew(funcion_verificar).ContinueWith((t) => taskCompleted2(t.Result));
                        break;
                    }
                case 3:
                    {
                        Task.Factory.StartNew(validando).ContinueWith((t) => taskCompleted3(t.Result));
                        break;
                    }
            }
            
        }

        private void taskCompleted(DataTable d, List<DataTable> da)
        {
            if (InvokeRequired)
            {
                this.Invoke((MethodInvoker)(() =>
                {
                    Datos_varios = da;
                    Datos = d;
                    Close();
                    DialogResult = DialogResult.OK;
                }));
            }
        }

        private void taskCompleted1(bool r)
        {
            if (InvokeRequired)
            {
                this.Invoke((MethodInvoker)(() =>
                {
                    Creado = r;
                    Close();
                    DialogResult = DialogResult.OK;
                }));
            }
        }

        private void taskCompleted2(int r)
        {
            if (InvokeRequired)
            {
                this.Invoke((MethodInvoker)(() =>
                {
                    Numero = r;
                    Close();
                    DialogResult = DialogResult.OK;
                }));
            }
        }

        private void taskCompleted3(bool r)
        {
            if (InvokeRequired)
            {
                this.Invoke((MethodInvoker)(() =>
                {
                    Creado = r;
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
