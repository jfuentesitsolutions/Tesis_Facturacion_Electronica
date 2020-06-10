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
    public partial class formas_pago : Form
    {
        bool modificar = false;
        conexiones_BD.clases.formas_pago fp;
        utilitarios.cargar_tablas tabla;
        string idforma_pago = null;

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

        public formas_pago()
        {
            InitializeComponent();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            gadgets.movimimientos mov = new gadgets.movimimientos();
            mov.moverFormulario(sender, e, this);
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
            }else
            {
                this.Close();
            }
            
        }

        private void formas_pago_Load(object sender, EventArgs e)
        {
            gadgets.horientaciones_textos.colocarTitulo(panelTitulo, lblEncanezado);

            if (modificar)
            {
                btnCancelar.Text = "Eliminar";
                btnGuardar.Text = "Modificar";
                cargarTablas();
                habilitar(false);
            }else
            {
                cargarTablas();
            }
        }

        private void cargarTablas()
        {
            tabla = new utilitarios.cargar_tablas(tablaFormaPago, txtBuscar, conexiones_BD.clases.formas_pago.datosTabla(), "nombre_pago", lblReg);
            tabla.cargar();
        }

        private void habilitar(bool co)
        {
            List<Control> controles = new List<Control>();
            controles.Add(txtFormP);
            controles.Add(btnGuardar);
            controles.Add(btnCancelar);

            utilitarios.vaciando_formularios.habilitandoTexbox(controles, co);
        }

        private bool validar()
        {
            bool valido = false;
            List<TextBox> controles = new List<TextBox>();
            controles.Add(txtFormP);
            valido = utilitarios.vaciando_formularios.validando(controles, error);

            return valido;
        }

        private void vaciarDatos()
        {
            List<Control> controles = new List<Control>();
            controles.Add(txtFormP);

            utilitarios.vaciando_formularios.vaciarTexbox(controles);
        }

        private bool validarExistencias()
        {
            bool existe = false;

            List<string> campos = new List<string>();
            campos.Add("nombre_pago");
            List<string> valores = new List<string>();
            valores.Add(txtFormP.Text);

            fp = new conexiones_BD.clases.formas_pago(campos, valores);

            if (modificar)
            {
                if (fp.validarCamposcondicorORActu(true, 1) > 1)
                {
                    existe = true;
                }
            }
            else
            {
                if (fp.validarCamposcondicorOR(true) > 0)
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
                    fp = new conexiones_BD.clases.formas_pago(txtFormP.Text);
                    if (fp.guardar(true) > 0)
                    {
                        vaciarDatos();
                        cargarTablas();
                        txtFormP.Focus();
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
                    fp = new conexiones_BD.clases.formas_pago(idforma_pago, txtFormP.Text);
                    if (fp.modificar(true) > 0)
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
            if (idforma_pago != null)
            {
                if (MessageBox.Show("¿Desea eliminar este registro?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                {
                    fp = new conexiones_BD.clases.formas_pago();
                    fp.Idforma_pago = this.idforma_pago;
                    fp.cargarParaEliminar();
                    if (fp.eliminar(true) > 0)
                    {
                        habilitar(false);
                        vaciarDatos();
                        cargarTablas();
                    }
                }

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

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            tabla.FiltrarLocalmente();
        }

        private void tablaFormaPago_Click(object sender, EventArgs e)
        {
           
                if (Modificar && tablaFormaPago.RowCount!=0)
                {
                    habilitar(true);
                    idforma_pago = tablaFormaPago.CurrentRow.Cells[0].Value.ToString();
                    txtFormP.Text = tablaFormaPago.CurrentRow.Cells[1].Value.ToString();
                }
            
            
        }
    }
}
