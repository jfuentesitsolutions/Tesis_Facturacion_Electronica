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
    public partial class bancos : Form
    {
        bool modificar = false;
        conexiones_BD.clases.bancos banco;
        utilitarios.cargar_tablas tabla;
        string idbanco = null;

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

        public bancos()
        {
            InitializeComponent();
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bancos_Load(object sender, EventArgs e)
        {
            gadgets.horientaciones_textos.colocarTitulo(panelTitulo, lblEncanezado);
            if (modificar)
            {
                cargarTablas();
                btnGuardar.Text = "Modificar";
                btnCancelar.Text = "Eliminar";
                habilitar(false);
            }else
            {
                cargarTablas();
            }
        }

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            gadgets.movimimientos mov = new gadgets.movimimientos();
            mov.moverFormulario(sender, e, this);
        }

        private void cargarTablas()
        {
            tabla = new utilitarios.cargar_tablas(tablaBancos, txtBuscar, conexiones_BD.clases.bancos.datosTabla(), "nombre", lblReg);
            tabla.cargar();
        }

        private void habilitar(bool co)
        {
            List<Control> controles = new List<Control>();
            controles.Add(txtBanco);
            controles.Add(txtTelefono);
            controles.Add(btnGuardar);
            controles.Add(btnCancelar);

            utilitarios.vaciando_formularios.habilitandoTexbox(controles, co);
        }

        private bool validar()
        {
            bool valido = false;
            List<TextBox> controles = new List<TextBox>();
            controles.Add(txtBanco);
            controles.Add(txtTelefono);

            valido = utilitarios.vaciando_formularios.validando(controles, error);

            return valido;
        }

        private void vaciarDatos()
        {
            List<Control> controles = new List<Control>();
            controles.Add(txtBanco);
            controles.Add(txtTelefono);

            utilitarios.vaciando_formularios.vaciarTexbox(controles);
        }

        private bool validarExistencias()
        {
            bool existe = false;

            List<string> campos = new List<string>();
            campos.Add("nombre");
            List<string> valores = new List<string>();
            valores.Add(txtBanco.Text);

            banco = new conexiones_BD.clases.bancos(campos, valores);

            if (modificar)
            {
                if (banco.validarCamposcondicorORActu(true, 1) > 1)
                {
                    existe = true;
                }
            }
            else
            {
                if (banco.validarCamposcondicorOR(true) > 0)
                {
                    existe = true;
                }
            }

            return existe;
        }

        private void guardar()
        {
            if (!validar())
            {
                if (!validarExistencias())
                {
                    banco = new conexiones_BD.clases.bancos(txtBanco.Text, txtTelefono.Text);
                    if (banco.guardar(true) > 0)
                    {
                        vaciarDatos();
                        cargarTablas();
                        txtBanco.Focus();
                    }
                }
            }
        }

        private void modifica()
        {
            if (!validar())
            {
                if (!validarExistencias())
                {
                    banco = new conexiones_BD.clases.bancos(idbanco, txtBanco.Text, txtTelefono.Text);
                    if (banco.modificar(true) > 0)
                    {
                        habilitar(false);
                        vaciarDatos();
                        cargarTablas();
                    }
                }
            }
        }

        private void eliminar()
        {
            if (idbanco != null)
            {
                banco = new conexiones_BD.clases.bancos(idbanco);
                if (banco.eliminar(true) > 0)
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

        private void tablaBancos_Click(object sender, EventArgs e)
        {
            if (modificar)
            {
                idbanco = tablaBancos.CurrentRow.Cells[0].Value.ToString();
                txtBanco.Text = tablaBancos.CurrentRow.Cells[1].Value.ToString();
                txtTelefono.Text = tablaBancos.CurrentRow.Cells[2].Value.ToString();
                habilitar(true);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (modificar)
            {
                modifica();
            }else
            {
                guardar();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (modificar)
            {
                eliminar();
            }else
            {
                this.Close();
            }
        }

    }
}
