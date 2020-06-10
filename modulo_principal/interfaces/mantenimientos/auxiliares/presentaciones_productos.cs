using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfaces.mantenimientos.auxiliares
{
    public partial class presentaciones_productos : Form
    {
        string idpresentacion, tipo, tipoN;
        Decimal precioM, precioD;
        bool agregado = false;

        public string Idpresentacion
        {
            get
            {
                return idpresentacion;
            }

            set
            {
                idpresentacion = value;
            }
        }

        public string Tipo
        {
            get
            {
                return tipo;
            }

            set
            {
                tipo = value;
            }
        }

        public string TipoN
        {
            get
            {
                return tipoN;
            }

            set
            {
                tipoN = value;
            }
        }

        public decimal PrecioM
        {
            get
            {
                return precioM;
            }

            set
            {
                precioM = value;
            }
        }

        public decimal PrecioD
        {
            get
            {
                return precioD;
            }

            set
            {
                precioD = value;
            }
        }

        public bool Agregado
        {
            get
            {
                return agregado;
            }

            set
            {
                agregado = value;
            }
        }

        public presentaciones_productos()
        {
            InitializeComponent();
        }

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            gadgets.movimimientos mov = new gadgets.movimimientos();
            mov.moverFormulario(sender, e, this);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!validar())
            {
                agregado = true;
                this.Close();
            }
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkM_CheckedChanged(object sender, EventArgs e)
        {
            calcularTipo();
        }

        private void chkD_CheckedChanged(object sender, EventArgs e)
        {
            calcularTipo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void lblPresenta_Click(object sender, EventArgs e)
        {
            auxiliares.paquetes pa = new paquetes();
            pa.ShowDialog();
            if (pa.Convertido)
            {
                canti.Value = Convert.ToDecimal(pa.TotalUnidades.ToString());
            }
        }

        private void precio_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                
            }
        }

        private void precio_Enter(object sender, EventArgs e)
        {
            precio.Select(0, precio.Text.Length);
        }

        private void canti_Enter(object sender, EventArgs e)
        {
            canti.Select(0, canti.Text.Length);
        }

        private void presentaciones_productos_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void presentaciones_productos_Load(object sender, EventArgs e)
        {
            gadgets.horientaciones_textos.colocarTitulo(panelTitulo, lblTitulo);
            calcularTipo();
        }

        private void calcularTipo()
        {
            if (chkM.Checked)
            {
                precio.Value = PrecioM ;
                tipo = "Mayoreo";
                tipoN = "1";
            }else if (chkD.Checked)
            {
                precio.Value = PrecioD;
                tipo = "Detalle";
                tipoN = "2";
            }
        }

        private bool validar()
        {
            bool valido = false;
            string mensaje = "Tienes que especificar una cantidad";
            error.Clear();

            if (canti.Value.ToString().Equals("0"))
            {
                valido = true;
                error.SetError(canti, mensaje);
            }

            return valido;
        }
    }
}
