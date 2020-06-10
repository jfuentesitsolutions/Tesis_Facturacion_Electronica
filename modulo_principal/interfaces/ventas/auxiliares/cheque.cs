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
    public partial class cheque : Form
    {
        conexiones_BD.clases.cheques chequ;
        utilitarios.convertir_letra letra=new utilitarios.convertir_letra();
        bool valido = false;

        public cheques Chequ
        {
            get
            {
                return chequ;
            }

            set
            {
                chequ = value;
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

        public cheque()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool validar()
        {
            bool valida = false;
            error.Clear();

            if (txtNumCheque.TextLength == 0)
            {
                error.SetError(txtNumCheque, "Coloque el número de cheque");
                valida = true;
            }
            if (txtLugar.TextLength == 0)
            {
                error.SetError(txtLugar, "Coloque el lugar de emisón del cheque");
                valida = true;
            }
            if (txtValorLetras.TextLength == 0)
            {
                error.SetError(txtValorLetras, "Coloque el valor en letras");
                valida = true;
            }
            if (monto.Value == 0)
            {
                error.SetError(monto, "Coloque un monto valido");
                valida = true;
            }


            return valida;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!validar())
            {
                this.Chequ = new conexiones_BD.clases.cheques("",
                    txtNumCheque.Text,
                    txtLugar.Text,
                    fecha.Value.ToString("yyyy-MM-dd hh:mm:ss"),
                    monto.Value.ToString(),
                    txtValorLetras.Text,
                    "");
                this.Valido = true;

                this.Close();
            }
        }

        private void calcularPrecioLetras(string monto)
        {   
            txtValorLetras.Text=letra.enletras(monto);
        }

        private void monto_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                calcularPrecioLetras(monto.Value.ToString());
            }
            catch
            {

            }
        }
    }
}
