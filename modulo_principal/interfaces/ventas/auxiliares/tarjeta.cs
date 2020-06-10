using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using conexiones_BD.clases;

namespace interfaces.ventas.auxiliares
{
    public partial class tarjeta : Form
    {
        conexiones_BD.clases.tarjetas tajeta;
        bool valido = false;

        public tarjetas Tajeta
        {
            get
            {
                return tajeta;
            }

            set
            {
                tajeta = value;
            }
        }

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

        public tarjeta()
        {
            InitializeComponent();
        }

        private bool validar()
        {
            bool valido = false;
            error.Clear();

            if (txtNumCheque.TextLength==0)
            {
                error.SetError(txtNumCheque, "Coloca el nombre del titulas");
                valido = true;
            }
            if (txtResolucion.TextLength == 0)
            {
                error.SetError(txtResolucion, "Coloca un numero de resolución de voucher");
                valido = true;
            }
            if (monto.Value == 0)
            {
                error.SetError(monto, "Coloca el monto a pagar");
                valido = true;
            }

            return valido;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!validar())
            {
                this.Tajeta = new conexiones_BD.clases.tarjetas("",
                    txtNumCheque.Text,
                    fecha.Value.ToString("yyyy-MM-dd hh:mm:ss"),
                    txtResolucion.Text,
                    monto.Value.ToString(), "");
                this.valido = true;

                this.Close();
            }
        }
    }
}
