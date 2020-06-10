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
    public partial class descuentos : Form
    {
        bool modificar = false;
        conexiones_BD.clases.descuentos des;
        utilitarios.cargar_tablas tabla;
        string iddescuento=null;

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

        public descuentos()
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

        private void descuentos_Load(object sender, EventArgs e)
        {
            gadgets.horientaciones_textos.colocarTitulo(panelTitulo, lblEncanezado);
            if (Modificar)
            {
                habilitar(false);
                cargarTablas();
                btnCancelar.Text = "Eliminar";
                btnGuardar.Text = "Modificar";
            }else
            {
                cargarTablas();
            }
        }

        private void cargarTablas()
        {
            tabla = new utilitarios.cargar_tablas(tablaDescuentos, txtBuscar, conexiones_BD.clases.descuentos.datosTabla(), "tipo_descuento", lblReg);
            tabla.cargar();
        }

        private void habilitar(bool co)
        {
            List<Control> controles = new List<Control>();
            controles.Add(txtDescuento);
            controles.Add(descuento);
            controles.Add(btnGuardar);
            controles.Add(btnCancelar);

            utilitarios.vaciando_formularios.habilitandoTexbox(controles, co);
        }

        private bool validar()
        {
            bool valido = false;
            List<TextBox> controles = new List<TextBox>();
            controles.Add(txtDescuento);

            valido = utilitarios.vaciando_formularios.validando(controles, error);

            if (descuento.Value==0)
            {
                valido = true;
                error.SetError(descuento, "No puedes dejar a cero");
            }

            return valido;
        }

        private void vaciarDatos()
        {
            List<Control> controles = new List<Control>();
            controles.Add(txtDescuento);
            utilitarios.vaciando_formularios.vaciarTexbox(controles);

            descuento.Value = 0;
        }

        private bool validarExistencias()
        {
            bool existe = false;

            List<string> campos = new List<string>();
            campos.Add("tipo_descuento");
            List<string> valores = new List<string>();
            valores.Add(txtDescuento.Text);

            des = new conexiones_BD.clases.descuentos(campos, valores);

            if (Modificar)
            {
                if (des.validarCamposcondicorORActu(true, 1) > 1)
                {
                    existe = true;
                }
            }
            else
            {
                if (des.validarCamposcondicorOR(true) > 0)
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
                    Double desc = Convert.ToInt32(descuento.Value.ToString());
                    Double aux = desc / 100;
                    des = new conexiones_BD.clases.descuentos(txtDescuento.Text, aux.ToString());
                    if (des.guardar(true) > 0)
                    {
                        vaciarDatos();
                        cargarTablas();
                        txtDescuento.Focus();
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
                    Double desc = Convert.ToInt32(descuento.Value.ToString());
                    Double aux = desc / 100;
                    des = new conexiones_BD.clases.descuentos(iddescuento, txtDescuento.Text, aux.ToString());
                    if (des.modificar(true) > 0)
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
            if (iddescuento != null)
            {
                if (MessageBox.Show("¿Desea eliminar este registro?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                {
                    des = new conexiones_BD.clases.descuentos(iddescuento);
                    if (des.eliminar(true) > 0)
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

        private void tablaDescuentos_Click(object sender, EventArgs e)
        {
            if (Modificar)
            {
                Int32 des = Convert.ToInt32(Convert.ToDouble(tablaDescuentos.CurrentRow.Cells[2].Value.ToString()) * 100);
                habilitar(true);
                iddescuento = tablaDescuentos.CurrentRow.Cells[0].Value.ToString();
                txtDescuento.Text = tablaDescuentos.CurrentRow.Cells[1].Value.ToString();
                descuento.Value = Convert.ToDecimal(des.ToString());
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
