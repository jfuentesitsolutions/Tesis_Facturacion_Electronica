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
    public partial class tipos_facturas : Form
    {
        bool modificar = false;
        conexiones_BD.clases.tipos_factura tf;
        utilitarios.cargar_tablas tabla;
        string idtipo_fac = null;

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

        public tipos_facturas()
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
                eliminar();
            }
            else
            {
                this.Close();
            }
            
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            gadgets.movimimientos mov = new gadgets.movimimientos();
            mov.moverFormulario(sender, e, this);
        }

        private void tipos_facturas_Load(object sender, EventArgs e)
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
            tabla = new utilitarios.cargar_tablas(tablaTiposFactura, txtBuscar, conexiones_BD.clases.tipos_factura.datosTabla(), "nombre", lblReg);
            tabla.cargar();
        }

        private void habilitar(bool co)
        {
            List<Control> controles = new List<Control>();
            controles.Add(txtTipo_fac);
            controles.Add(btnGuardar);
            controles.Add(btnCancelar);

            utilitarios.vaciando_formularios.habilitandoTexbox(controles, co);
        }

        private bool validar()
        {
            bool valido = false;
            List<TextBox> controles = new List<TextBox>();
            controles.Add(txtTipo_fac);

            valido = utilitarios.vaciando_formularios.validando(controles, error);

            return valido;
        }

        private void vaciarDatos()
        {
            List<Control> controles = new List<Control>();
            controles.Add(txtTipo_fac);

            utilitarios.vaciando_formularios.vaciarTexbox(controles);
        }

        private bool validarExistencias()
        {
            bool existe = false;

            List<string> campos = new List<string>();
            campos.Add("nombre");
            List<string> valores = new List<string>();
            valores.Add(txtTipo_fac.Text);

            tf = new conexiones_BD.clases.tipos_factura(campos, valores);

            if (modificar)
            {
                if (tf.validarCamposcondicorORActu(true, 1) > 1)
                {
                    existe = true;
                }
            }
            else
            {
                if (tf.validarCamposcondicorOR(true) > 0)
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
                    tf = new conexiones_BD.clases.tipos_factura(txtTipo_fac.Text);
                    if (tf.guardar(true) > 0)
                    {
                        vaciarDatos();
                        cargarTablas();
                        txtTipo_fac.Focus();
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
                    tf = new conexiones_BD.clases.tipos_factura(idtipo_fac, txtTipo_fac.Text);
                    if (tf.modificar(true) > 0)
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
            if (idtipo_fac != null)
            {
                if (MessageBox.Show("¿Desea eliminar este registro?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                {
                    tf = new conexiones_BD.clases.tipos_factura();
                    tf.Idtipo_factura = idtipo_fac;
                    tf.cargarParaEliminar();
                    if (tf.eliminar(true) > 0)
                    {
                        habilitar(false);
                        vaciarDatos();
                        cargarTablas();
                    }
                }

            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            tabla.FiltrarLocalmente();
        }

        private void tablaTiposFactura_Click(object sender, EventArgs e)
        {
            if (modificar)
            {
                habilitar(true);
                idtipo_fac = tablaTiposFactura.CurrentRow.Cells[0].Value.ToString();
                txtTipo_fac.Text= tablaTiposFactura.CurrentRow.Cells[1].Value.ToString();
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
    }
}
