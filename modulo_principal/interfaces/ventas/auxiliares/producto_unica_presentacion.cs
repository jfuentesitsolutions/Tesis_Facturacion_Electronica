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
    public partial class producto_unica_presentacion : Form
    {
        string idpresentacion_poroducto, total, utilidad, tipoUtilidad, precio, codigo, cantidadInter, sucursal_producto;
        bool llenado = false;
        bool modificar = false;
        double iva_descontado = 0.00;
        int tipo_factura=0;
        public producto_unica_presentacion()
        {
            InitializeComponent();
        }

        public string Idpresentacion_poroducto
        {
            get
            {
                return idpresentacion_poroducto;
            }

            set
            {
                idpresentacion_poroducto = value;
            }
        }

        public string TipoUtilidad
        {
            get
            {
                return tipoUtilidad;
            }

            set
            {
                tipoUtilidad = value;
            }
        }

        public string Total
        {
            get
            {
                return total;
            }

            set
            {
                total = value;
            }
        }

        private void txtCantidad_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!valida())
                {
                    if (!revisarExistencias())
                    {
                        Llenado = true;
                        calculos();
                        this.Close();
                    }
                }
            }
        }

        public string Utilidad
        {
            get
            {
                return utilidad;
            }

            set
            {
                utilidad = value;
            }
        }

        public bool Modificar
        {
            get
            {
                return modificar;
            }

            set
            {
                modificar = value;
            }
        }

        public bool Llenado
        {
            get
            {
                return llenado;
            }

            set
            {
                llenado = value;
            }
        }

        public string Precio
        {
            get
            {
                return precio;
            }

            set
            {
                precio = value;
            }
        }

        public string Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;
            }
        }

        public string CantidadInter
        {
            get
            {
                return cantidadInter;
            }

            set
            {
                cantidadInter = value;
            }
        }

        private void producto_unica_presentacion_Load(object sender, EventArgs e)
        {
            if (!valida())
            {
                if (!revisarExistencias())
                {
                    Llenado = true;
                    calculos();
                    this.Close();
                }
            }
        }

        public string Sucursal_producto
        {
            get
            {
                return sucursal_producto;
            }

            set
            {
                sucursal_producto = value;
            }
        }

        public double Iva_descontado
        {
            get
            {
                return iva_descontado;
            }

            set
            {
                iva_descontado = value;
            }
        }

        public int Tipo_factura
        {
            get
            {
                return tipo_factura;
            }

            set
            {
                tipo_factura = value;
            }
        }

        private void producto_unica_presentacion_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCantidad_Enter(object sender, EventArgs e)
        {
            txtCantidad.Select(0, txtCantidad.Text.Length);
        }

        private bool valida()
        {
            bool valido = false;
            error.Clear();

            if (txtCantidad.Value == 0)
            {
                valido = true;
                error.SetError(txtCantidad, "No puedes a cero la cantidad");
            }

            return valido;
        }

        private void calculos()
        {
            int cantidad = Convert.ToInt32(txtCantidad.Value);
            double preci = Convert.ToDouble(precio);
            

            switch (Tipo_factura)
            {
                case 2:
                    {
                        double tota = ((cantidad * preci) / 1.13);
                        Console.WriteLine(tota);
                        iva_descontado = Math.Round(tota * 0.13, 2);
                        total = Math.Round(tota, 2).ToString();
                        break;
                    }
                case 5:
                    {
                        double tota = ((cantidad * preci) / 1.13);
                        iva_descontado = Math.Round(tota * 0.13, 2);
                        total = Math.Round(tota, 2).ToString();
                        break;
                    }
                default:
                    {
                        double tota = cantidad * preci;
                        total = tota.ToString();
                        break;
                    }
            }

            double uti = Convert.ToDouble(tipoUtilidad);
            double utili = uti * preci;
            utilidad = utili.ToString();
        }

        private bool revisarExistencias()
        {
            bool existencias = false;

            if (Convert.ToUInt32(lblExis.Text) < (Convert.ToInt32(txtCantidad.Value)*Convert.ToInt32(cantidadInter)))
            {
                MessageBox.Show("No hay existencias suficientes", "No hay existencias", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCantidad.Value = 0;
                existencias = true;
            }
            else
            {
                existencias = false;
            }

            return existencias;
        }
    }
}
