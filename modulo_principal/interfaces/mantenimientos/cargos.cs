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
    public partial class cargos : Form
    {
        bool modificar = false;
        utilitarios.cargar_tablas tabla;
        conexiones_BD.clases.cargos cargo;
        string idcargo=null;
        //bool agregado = false;

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

        public cargos()
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
                eliminarCargos();
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

        private void cargos_Load(object sender, EventArgs e)
        {
            gadgets.horientaciones_textos.colocarTitulo(panelTitulo, lblEncanezado);

            if (modificar)
            {
                cargarTablas();
                habilitar(false);
                btnGuardar.Text = "Modificar";
                btnCancelar.Text = "Eliminar";
            }
            else
            {
                cargarTablas();
            }
        }

        private void cargarTablas()
        {
            tabla = new utilitarios.cargar_tablas(tablaCargos, txtBuscar, conexiones_BD.clases.cargos.datosTabla(), "nombre_cargo", lblRegistro);
            tabla.cargar();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            tabla.FiltrarLocalmente();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (modificar)
            {
                modificarCargos();
            }else
            {
                guardarCargos();
            }
        }

        private void habilitar(bool con)
        {
            List<Control> control = new List<Control>();
            control.Add(txtCargo);
            control.Add(txtDescripcion);
            control.Add(btnGuardar);
            control.Add(btnCancelar);
            utilitarios.vaciando_formularios.habilitandoTexbox(control, con);
        }

        private bool validar()
        {
            List<TextBox> control = new List<TextBox>();
            control.Add(txtCargo);
            control.Add(txtDescripcion);

            return utilitarios.vaciando_formularios.validando(control, error);
        }

        private void vaciarDatos()
        {
            List<Control> control = new List<Control>();
            control.Add(txtCargo);
            control.Add(txtDescripcion);
            utilitarios.vaciando_formularios.vaciarTexbox(control);
        }

        private bool validandoExistencias()
        {
            List<string> campos = new List<string>();
            List<string> valores = new List<string>();

            campos.Add("nombre_cargo");
            valores.Add(txtCargo.Text);

            cargo = new conexiones_BD.clases.cargos(campos, valores);
            if (cargo.validarCamposcondicorOR(true) > 0)
            {
                return true;
            }else
            {
                return false;
            }
        }

        private void guardarCargos()
        {
            if (!validar())
            {
                if (!validandoExistencias())
                {
                    cargo = new conexiones_BD.clases.cargos(txtCargo.Text, txtDescripcion.Text);
                    if (cargo.guardar(true) > 0)
                    {
                        vaciarDatos();
                        cargarTablas();
                        txtCargo.Focus();
                    }
                }
            }
            
        }

        private void modificarCargos()
        {
            if (!validar())
            {
                cargo = new conexiones_BD.clases.cargos(idcargo, txtCargo.Text, txtDescripcion.Text);
                if (cargo.modificar(true) > 0)
                {
                    vaciarDatos();
                    habilitar(false);
                    cargarTablas();
                }
            }
        }

        private void eliminarCargos()
        {
            if (idcargo != null)
            {
                cargo = new conexiones_BD.clases.cargos(idcargo);
                if (cargo.eliminar(true) > 0)
                {
                    vaciarDatos();
                    habilitar(false);
                    cargarTablas();

                }
            }
        }

        private void tablaCargos_Click(object sender, EventArgs e)
        {
            if (modificar)
            {
                habilitar(true);
                idcargo = tablaCargos.CurrentRow.Cells[0].Value.ToString();
                txtCargo.Text = tablaCargos.CurrentRow.Cells[1].Value.ToString();
                txtDescripcion.Text = tablaCargos.CurrentRow.Cells[2].Value.ToString();

            }
        }
    }
}
