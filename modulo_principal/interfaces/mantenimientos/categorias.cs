using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfaces.mantenimientos
{
    public partial class categorias : Form
    {

        bool modificar = false;
        conexiones_BD.clases.categorias categoria;
        utilitarios.cargar_tablas tabla;
        string idcategoria = null;
        bool agregado = false;

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

        public categorias()
        {
            InitializeComponent();
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (modificar)
            {
                eliminarCategoria();
            }else
            {
                this.Close();
            }

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            gadgets.movimimientos mov = new gadgets.movimimientos();
            mov.moverFormulario(sender, e, this);
        }

        private void categorias_Load(object sender, EventArgs e)
        {
            gadgets.horientaciones_textos.colocarTitulo(panelTitulo, lblEncanezado);
            if (modificar)
            {
                cargarTablas();
                btnGuardar.Text = "Modificar";
                btnCancelar.Text = "Eliminar";
            }else
            {
                cargarTablas();
            }

        }

        private void cargarTablas()
        {
            tabla = new utilitarios.cargar_tablas(tablaCategoria, txtBuscar, conexiones_BD.clases.categorias.datosTabla(), "nombre_categoria",lblReg);
            tabla.cargar();
        }

        private void habilitar(bool co)
        {
            List<Control> controles = new List<Control>();
            controles.Add(txtCateg);
            controles.Add(txtDescripcion);
            controles.Add(btnGuardar);
            controles.Add(btnCancelar);

            utilitarios.vaciando_formularios.habilitandoTexbox(controles, co);
        }

        private bool validar()
        {
            bool valido = false;
            List<TextBox> controles = new List<TextBox>();
            controles.Add(txtCateg);
            controles.Add(txtDescripcion);

            valido = utilitarios.vaciando_formularios.validando(controles, error);

            return valido;
        }

        private void vaciarDatos()
        {
            List<Control> controles = new List<Control>();
            controles.Add(txtCateg);
            controles.Add(txtDescripcion);

            utilitarios.vaciando_formularios.vaciarTexbox(controles);
        }

        private bool validarExistencias()
        {
            bool existe = false;

            List<string> campos = new List<string>();
            campos.Add("nombre_categoria");
            List<string> valores = new List<string>();
            valores.Add(txtCateg.Text);

            categoria = new conexiones_BD.clases.categorias(campos, valores);

            if (modificar)
            {
                if(categoria.validarCamposcondicorORActu(true, 1) > 1)
                {
                    existe = true;
                }
            }else
            {
                if (categoria.validarCamposcondicorOR(true) > 0)
                {
                    existe = true;
                }
            }

            return existe;
        }

        private void guardarCategoria()
        {
            if (!validar())
            {
                if (!validarExistencias())
                {
                    categoria = new conexiones_BD.clases.categorias(txtCateg.Text, txtDescripcion.Text);
                    if (categoria.guardar(true) > 0)
                    {
                        vaciarDatos();
                        cargarTablas();
                        txtCateg.Focus();
                        agregado = true;
                    }
                }
            }
        }

        private void modificarCategorias()
        {
            if (!validar())
            {
                if (!validarExistencias())
                {
                    categoria = new conexiones_BD.clases.categorias(idcategoria, txtCateg.Text, txtDescripcion.Text);
                    if (categoria.modificar(true) > 0)
                    {
                        habilitar(false);
                        vaciarDatos();
                        cargarTablas();
                    }
                }
            }
        }

        private void eliminarCategoria()
        {
            if (idcategoria != null)
            {
                categoria = new conexiones_BD.clases.categorias(idcategoria);
                if (categoria.eliminar(true) > 0)
                {
                    habilitar(false);
                    vaciarDatos();
                    cargarTablas();
                }
            }
        }

        private void tablaCategoria_Click(object sender, EventArgs e)
        {
            if (modificar)
            {
                idcategoria = tablaCategoria.CurrentRow.Cells[0].Value.ToString();
                txtCateg.Text = tablaCategoria.CurrentRow.Cells[1].Value.ToString();
                txtDescripcion.Text = tablaCategoria.CurrentRow.Cells[2].Value.ToString();

                habilitar(true);

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (modificar)
            {
                modificarCategorias();
            }else
            {
                guardarCategoria();
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            tabla.FiltrarLocalmente();
        }
    }
}
