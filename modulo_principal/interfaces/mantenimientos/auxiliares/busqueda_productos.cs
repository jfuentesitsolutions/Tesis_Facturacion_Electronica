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
    public partial class busqueda_productos : Form
    {
        utilitarios.cargar_tablas tabla;
        bool listo = false;
        string codigo = "";



        public bool Listo
        {
            get
            {
                return listo;
            }

            set
            {
                listo = value;
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

        public busqueda_productos()
        {
            InitializeComponent();
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            gadgets.movimimientos mov = new gadgets.movimimientos();
            mov.moverFormulario(sender, e, this);
        }

        private void busqueda_productos_Load(object sender, EventArgs e)
        {
            gadgets.horientaciones_textos.colocarTitulo(panelTitulo, lblEncanezado);
            cargarTablas();
        }
        private DataTable cargarDatosP()
        {
            DataTable datos = conexiones_BD.clases.productos.CARGAR_TABLA_PRODUCTOS_VENT();

            return datos;
        }

        private void cargarTablas()
        {
            tabla = new utilitarios.cargar_tablas(tablad, txtBusqueda, cargarDatosP(), "productoCod");
            tabla.cargarSinContadorRegistros();
            

        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            tabla.FiltrarLocalmenteSinContadorRegistros();
        }

        private void txtBusqueda_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                tablad.Focus();

            }
            else if (e.KeyCode == Keys.Enter)
            {
                AgregarCodigo();
            }
        }

        private void tablad_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                txtBusqueda.Focus();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                AgregarCodigo();
            }
        }

        private void tablad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void AgregarCodigo()
        {
            auxiliares.agregaCodigos codi = new auxiliares.agregaCodigos();
            codi.Idproducto = tablad.CurrentRow.Cells[14].Value.ToString();
            codi.txtCodigo.Text = this.codigo;
            codi.ShowDialog();
            if (codi.Listo)
            {
                listo = true;
                this.Close();
            }
        }
    }
}
