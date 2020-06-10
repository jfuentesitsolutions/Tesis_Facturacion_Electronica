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
    public partial class cobrar : Form
    {
        bool cobrado = false;
        conexiones_BD.clases.tarjetas tarjeta;
        conexiones_BD.clases.cheques cheque;

        public bool Cobrado
        {
            get
            {
                return cobrado;
            }

            set
            {
                cobrado = value;
            }
        }

        public tarjetas Tarjeta
        {
            get
            {
                return tarjeta;
            }

            set
            {
                tarjeta = value;
            }
        }

        public cheques Cheque
        {
            get
            {
                return cheque;
            }

            set
            {
                cheque = value;
            }
        }

        public cobrar()
        {
            InitializeComponent();
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cobrar_Load(object sender, EventArgs e)
        {
            gadgets.horientaciones_textos.colocarTitulo(panelTitulo, lblEncanezado);
            //efec.Select(0, efec.Text.Length);
            txtefe.Text = efec.Value.ToString();
            listaMetodoPago.SelectedIndex = 0;
        }

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            gadgets.movimimientos mov = new gadgets.movimimientos();
            mov.moverFormulario(sender, e, this);
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            if (!validar())
            {
                utilitarios.convertir_letra letra = new utilitarios.convertir_letra();
                Console.WriteLine(letra.enletras(txtefe.Text));
                cobrado = true;
                this.Close();
            }
        }

        private bool validar()
        {
            bool valido = false;
            error.Clear();

            if (efec.Value == 0)
            {
                valido = true;
                error.SetError(efec, "Digita una cantidad");
            }

            return valido;
        }

        private void calcularCambio()
        {
            double total = Convert.ToDouble(lblTotala.Text);
            double efect = Convert.ToDouble(txtefe.Text);

            double aux = efect - total;
            double cambio = Math.Round(aux, 2);

            lblCambio.Text = cambio.ToString();

        }

        private void txtefe_TextChanged(object sender, EventArgs e)
        {
            try
            {
                calcularCambio();
            }
            catch
            {

            }
        }

        private void txtefe_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCobrar.PerformClick();
            }
        }

        private void listaMetodoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listaMetodoPago.SelectedIndex)
            {
                case 1:
                    {
                        tarjeta tar = new tarjeta();
                        tar.ShowDialog();
                        if (tar.Valido)
                        {
                            Tarjeta = tar.Tajeta;
                            txtefe.Text = tar.monto.Value.ToString();
                        }
                        
                        break;
                    }
                case 2:
                    {
                        cheque che = new cheque();
                        che.ShowDialog();
                        if (che.Valido)
                        {
                            cheque = che.Chequ;
                            txtefe.Text = che.monto.Value.ToString();
                        }
                        
                        break;
                    }
            }
        }
    }
}
