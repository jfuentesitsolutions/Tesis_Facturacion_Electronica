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
    public partial class proveedores_productos : Form
    {
        utilitarios.cargar_tablas tabla;
        conexiones_BD.clases.proveedores_productos pp;
        bool agregrado = false;
        DataGridView tabR = null;
        bool modificar = false;
        string idproducto;
        public bool Agregrado
        {
            get
            {
                return agregrado;
            }

            set
            {
                agregrado = value;
            }
        }

        public DataGridView TabR
        {
            get
            {
                return tabR;
            }

            set
            {
                tabR = value;
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

        public string Idproducto
        {
            get
            {
                return idproducto;
            }

            set
            {
                idproducto = value;
            }
        }

        public proveedores_productos()
        {
            InitializeComponent();
        }

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            gadgets.movimimientos mov = new gadgets.movimimientos();
            mov.moverFormulario(sender, e, this);
        }

        private void proveedores_productos_Load(object sender, EventArgs e)
        {
            gadgets.horientaciones_textos.colocarTitulo(panelTitulo, lblTitulo);
            utilitarios.cargandoListas.cargarLista(conexiones_BD.clases.proveedores.datosTabla(), listaProveedores, "nombre_proveedor", "idproveedor");

            if (modificar)
            {
                cargarTablaPro();

            }else
            {
                if (tabR != null)
                {
                    foreach (DataGridViewRow fila in tabR.Rows)
                    {
                        tablaProveedores.Rows.Add(
                            fila.Cells[0].Value.ToString(),
                            fila.Cells[1].Value.ToString(),
                            fila.Cells[2].Value.ToString(),
                            fila.Cells[3].Value.ToString()
                            );
                    }
                }
            }
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgr_Click(object sender, EventArgs e)
        {
            if (modificar)
            {
                if (!verificarRepetido())
                {
                    pp = new conexiones_BD.clases.proveedores_productos(
                    listaProveedores.SelectedValue.ToString(),
                    idproducto
                    );

                    if (pp.guardar(false) > 0)
                    {
                        cargarTablaPro();
                    }
                }

            }
            else
            {
                if (!verificarRepetido())
                {
                    if (listaProveedores.SelectedIndex != -1)
                    {
                        tablaProveedores.Rows.Add(
                    "0", listaProveedores.SelectedValue.ToString(), listaProveedores.Text,
                    "0"
                    );
                    }
                }
            }
            
            
        }

        private bool verificarRepetido()
        {
            bool repetido = false;
            if (tablaProveedores.Rows.Count != 0)
            {
                foreach(DataGridViewRow fila in tablaProveedores.Rows)
                {
                    if (fila.Cells[1].Value.ToString().Equals(listaProveedores.SelectedValue.ToString()))
                    {
                        repetido = true;
                    }
                }
            }

            return repetido;
        }

        private void btnEli_Click(object sender, EventArgs e)
        {
            if (modificar)
            {
                try
                {
                    pp = new conexiones_BD.clases.proveedores_productos(
                    tablaProveedores.CurrentRow.Cells[0].Value.ToString()
                    );

                    if (pp.eliminar(false) > 0)
                    {
                        cargarTablaPro();
                    }
                }
                catch
                {

                }
            }
            else
            {
                try
                {
                    tablaProveedores.Rows.RemoveAt(tablaProveedores.CurrentRow.Index);
                }
                catch
                {

                }
            }
            
        }

        private bool validar()
        {
            bool valido = false;
            error.Clear();
            if (tablaProveedores.Rows.Count==0)
            {
                valido = true;
                error.SetError(tablaProveedores, "Tienes que agregar un proveedor");
            }

            return valido;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (modificar)
            {
                this.Close();
            }else
            {
                if (!validar())
                {
                    Agregrado = true;
                    this.Close();
                }
            }
            
        }

        private void cargarTablaPro()
        {
            tabla = new utilitarios.cargar_tablas(tablaProveedores, new TextBox(), conexiones_BD.clases.proveedores_productos.datosTabla(idproducto), "nombre_proveedor");
            tabla.cargarSinContadorRegistros();
        }
    }
}
