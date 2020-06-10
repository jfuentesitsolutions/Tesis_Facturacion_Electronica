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
    public partial class presentaciones : Form
    {
        bool modificar = false;
        conexiones_BD.clases.presentaciones presentacion;
        utilitarios.cargar_tablas tabla;
        string idpresentacion = null;

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

        public presentaciones()
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
            if (Modificar)
            {
                eliminar();
            }else
            {
                this.Close();
            }
           
        }

        private void presentaciones_Load(object sender, EventArgs e)
        {
            gadgets.horientaciones_textos.colocarTitulo(panelTitulo, lblEncanezado);
            if (Modificar)
            {
                btnGuardar.Text = "Modificar";
                btnCancelar.Text = "Eliminar";
                habilitar(false);
                cargarTablas();
                
            }else
            {
                cargarTablas();
                chkEstado.Checked = true;
            }
        }

        private void cargarTablas()
        {
            tabla = new utilitarios.cargar_tablas(tablaPresentaciones, txtBuscar, conexiones_BD.clases.presentaciones.datosTabla(), "nombre_presentacion", lblReg);
            tabla.cargar();
        }

        private void habilitar(bool co)
        {
            List<Control> controles = new List<Control>();
            controles.Add(txtPresentacion);
            controles.Add(txtDescripcion);
            controles.Add(btnGuardar);
            controles.Add(btnCancelar);
            controles.Add(chkEstado);

            utilitarios.vaciando_formularios.habilitandoTexbox(controles, co);
        }

        private bool validar()
        {
            bool valido = false;
            List<TextBox> controles = new List<TextBox>();
            controles.Add(txtPresentacion);
            controles.Add(txtDescripcion);

            valido = utilitarios.vaciando_formularios.validando(controles, error);

            return valido;
        }

        private void vaciarDatos()
        {
            List<Control> controles = new List<Control>();
            controles.Add(txtPresentacion);
            controles.Add(txtDescripcion);

            utilitarios.vaciando_formularios.vaciarTexbox(controles);
        }

        private bool validarExistencias()
        {
            bool existe = false;

            List<string> campos = new List<string>();
            campos.Add("nombre_presentacion");
            List<string> valores = new List<string>();
            valores.Add(txtPresentacion.Text);

            presentacion = new conexiones_BD.clases.presentaciones(campos, valores);

            if (Modificar)
            {
                if (presentacion.validarCamposcondicorORActu(true, 1) > 1)
                {
                    existe = true;
                }
            }
            else
            {
                if (presentacion.validarCamposcondicorOR(true) > 0)
                {
                    existe = true;
                }
            }

            return existe;
        }

        private String estado()
        {
            string esta = null;
            if (chkEstado.Checked)
            {
                esta = "1";
            }else
            {
                esta = "2";
            }

            return esta;
        }

        private void guardar()
        {
            if (!validar())
            {
                if (!validarExistencias())
                {
                    presentacion = new conexiones_BD.clases.presentaciones(txtPresentacion.Text, txtDescripcion.Text, estado());
                    if (presentacion.guardar(true) > 0)
                    {
                        vaciarDatos();
                        cargarTablas();
                        txtPresentacion.Focus();
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
                    presentacion = new conexiones_BD.clases.presentaciones(idpresentacion, txtPresentacion.Text, txtDescripcion.Text, estado());
                    if (presentacion.modificar(true) > 0)
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
            if (idpresentacion != null)
            {
                presentacion = new conexiones_BD.clases.presentaciones(idpresentacion);
                if (presentacion.eliminar(true) > 0)
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

        private void tablaPresentaciones_Click(object sender, EventArgs e)
        {
            if (Modificar)
            {
                idpresentacion = tablaPresentaciones.CurrentRow.Cells[0].Value.ToString();
                txtPresentacion.Text = tablaPresentaciones.CurrentRow.Cells[1].Value.ToString();
                txtDescripcion.Text = tablaPresentaciones.CurrentRow.Cells[2].Value.ToString();
                habilitar(true);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Modificar)
            {
                modifica();
            }else
            {
                guardar();
            }
        }
    }
}
