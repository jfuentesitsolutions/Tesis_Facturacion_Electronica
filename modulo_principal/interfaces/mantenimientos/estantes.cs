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
    public partial class estantes : Form
    {
        bool modificar = false;
        conexiones_BD.clases.estantes estante;
        utilitarios.cargar_tablas tabla;
        string idestante=null;
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

        public estantes()
        {
            InitializeComponent();
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (modificar)
            {
                eliminarEstantes();
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

        private void estantes_Load(object sender, EventArgs e)
        {
            gadgets.horientaciones_textos.colocarTitulo(panelTitulo, lblEncanezado);
            if (modificar)
            {
                btnGuardar.Text = "Modificar";
                btnCancelar.Text = "Eliminar";
                habilitar(false);
                cargarTablas();
            }else
            {
                cargarTablas();
            }
        }

        private void cargarTablas()
        {
            tabla = new utilitarios.cargar_tablas(tablaEstantes, txtBuscar, conexiones_BD.clases.estantes.datosTabla(), "nombre", lblReg);
            tabla.cargar();
        }

        private void habilitar(bool co)
        {
            List<Control> controles = new List<Control>();
            controles.Add(txtEstante);
            controles.Add(txtDescripcion);
            controles.Add(btnGuardar);
            controles.Add(btnCancelar);

            utilitarios.vaciando_formularios.habilitandoTexbox(controles, co);
        }

        private bool validar()
        {
            bool valido = false;
            List<TextBox> controles = new List<TextBox>();
            controles.Add(txtEstante);
            controles.Add(txtDescripcion);

            valido = utilitarios.vaciando_formularios.validando(controles, error);

            return valido;
        }

        private void vaciarDatos()
        {
            List<Control> controles = new List<Control>();
            controles.Add(txtEstante);
            controles.Add(txtDescripcion);

            utilitarios.vaciando_formularios.vaciarTexbox(controles);
        }

        private bool validarExistencias()
        {
            bool existe = false;

            List<string> campos = new List<string>();
            campos.Add("nombre");
            List<string> valores = new List<string>();
            valores.Add(txtEstante.Text);

            estante = new conexiones_BD.clases.estantes(campos, valores);

            if (modificar)
            {
                if (estante.validarCamposcondicorORActu(true, 1) > 1)
                {
                    existe = true;
                }
            }
            else
            {
                if (estante.validarCamposcondicorOR(true) > 0)
                {
                    existe = true;
                }
            }

            return existe;
        }

        private void guardarEstantes()
        {
            if (!validar())
            {
                if (!validarExistencias())
                {
                    estante = new conexiones_BD.clases.estantes(txtEstante.Text, txtDescripcion.Text);
                    if (estante.guardar(true) > 0)
                    {
                        vaciarDatos();
                        cargarTablas();
                        txtEstante.Focus();
                        agregado = true;
                    }
                }
            }
        }

        private void modificarEstantes()
        {
            if (!validar())
            {
                if (!validarExistencias())
                {
                    estante = new conexiones_BD.clases.estantes(idestante, txtEstante.Text, txtDescripcion.Text);
                    if (estante.modificar(true) > 0)
                    {
                        habilitar(false);
                        vaciarDatos();
                        cargarTablas();
                    }
                }
            }
        }

        private void eliminarEstantes()
        {
            if (idestante != null)
            {
                estante = new conexiones_BD.clases.estantes(idestante);
                if (estante.eliminar(true) > 0)
                {
                    habilitar(false);
                    vaciarDatos();
                    cargarTablas();
                }
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            tabla.FiltrarLocalmente();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (modificar)
            {
                modificarEstantes();
            }else
            {
                guardarEstantes();
            }
        }

        private void tablaEstantes_Click(object sender, EventArgs e)
        {
            try
            {
                if (modificar)
                {
                    habilitar(true);
                    idestante = tablaEstantes.CurrentRow.Cells[0].Value.ToString();
                    txtEstante.Text = tablaEstantes.CurrentRow.Cells[1].Value.ToString();
                    txtDescripcion.Text = tablaEstantes.CurrentRow.Cells[2].Value.ToString();
                }
            }
            catch
            {

            }
            
        }
    }
}
