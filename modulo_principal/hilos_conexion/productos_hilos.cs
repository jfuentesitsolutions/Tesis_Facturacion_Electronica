using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hilos_conexion
{
    public partial class productos_hilos : Form
    {
        utilitarios.cargar_tablas tabla;
        Action accion;

        public productos_hilos()
        {
            InitializeComponent();
        }

        

        private void creandoaccion()
        {
            this.accion = cargardatos;
            if (InvokeRequired)
            {
                Invoke(accion);
            }
        }

        public void cargardatos()
        {
            tabla = new utilitarios.cargar_tablas(tablad, new TextBox(), conexiones_BD.clases.productos.CARGAR_TABLA_PRODUCTOS_VENT(), "productoCod");
            tabla.cargarSinContadorRegistros();
        }

        private void productos_hilos_Load(object sender, EventArgs e)
        {
            Thread t = new Thread(creandoaccion);
            t.Start();
        }
    }
}
