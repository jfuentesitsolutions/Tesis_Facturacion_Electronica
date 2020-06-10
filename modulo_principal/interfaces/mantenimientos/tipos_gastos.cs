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
    public partial class tipos_gastos : Form
    {
        bool modificar = false;
        conexiones_BD.clases.tipos_gastos gasto;
        utilitarios.cargar_tablas tabla;
        string idtipo_gas=null;

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

        public tipos_gastos()
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

        private void tipos_gastos_Load(object sender, EventArgs e)
        {
            gadgets.horientaciones_textos.colocarTitulo(panelTitulo, lblEncanezado);

            if (modificar)
            {
                habilitar(false);
                btnGuardar.Text = "Modificar";
                btnCancelar.Text = "Eliminar";
                cargarTablas();
            }else
            {
                cargarTablas();
            }
        }

        private void cargarTablas()
        {
            tabla = new utilitarios.cargar_tablas(tablaTiposGastos, txtBuscar, conexiones_BD.clases.tipos_gastos.datosTabla(), "nombre", lblReg);
            tabla.cargar();
        }

        private void habilitar(bool co)
        {
            List<Control> controles = new List<Control>();
            controles.Add(txtGasto);
            controles.Add(txtDescripcion);
            controles.Add(btnGuardar);
            controles.Add(btnCancelar);

            utilitarios.vaciando_formularios.habilitandoTexbox(controles, co);
        }

        private bool validar()
        {
            bool valido = false;
            List<TextBox> controles = new List<TextBox>();
            controles.Add(txtGasto);
            controles.Add(txtDescripcion);

            valido = utilitarios.vaciando_formularios.validando(controles, error);

            return valido;
        }

        private void vaciarDatos()
        {
            List<Control> controles = new List<Control>();
            controles.Add(txtGasto);
            controles.Add(txtDescripcion);

            utilitarios.vaciando_formularios.vaciarTexbox(controles);
        }

        private bool validarExistencias()
        {
            bool existe = false;

            List<string> campos = new List<string>();
            campos.Add("nombre");
            List<string> valores = new List<string>();
            valores.Add(txtGasto.Text);

            gasto = new conexiones_BD.clases.tipos_gastos(campos, valores);

            if (modificar)
            {
                if (gasto.validarCamposcondicorORActu(true, 1) > 1)
                {
                    existe = true;
                }
            }
            else
            {
                if (gasto.validarCamposcondicorOR(true) > 0)
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
                    gasto = new conexiones_BD.clases.tipos_gastos(txtGasto.Text, txtDescripcion.Text);
                    if (gasto.guardar(true) > 0)
                    {
                        vaciarDatos();
                        cargarTablas();
                        txtGasto.Focus();
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
                    gasto = new conexiones_BD.clases.tipos_gastos(idtipo_gas, txtGasto.Text, txtDescripcion.Text);
                    if (gasto.modificar(true) > 0)
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
            if (idtipo_gas != null)
            {
                if(MessageBox.Show("¿Desea eliminar este registro?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                {
                    gasto = new conexiones_BD.clases.tipos_gastos(idtipo_gas);
                    if (gasto.eliminar(true) > 0)
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

        private void tablaTiposGastos_Click(object sender, EventArgs e)
        {
            if (modificar)
            {
                habilitar(true);
                idtipo_gas = tablaTiposGastos.CurrentRow.Cells[0].Value.ToString();
                txtGasto.Text = tablaTiposGastos.CurrentRow.Cells[1].Value.ToString();
                txtDescripcion.Text = tablaTiposGastos.CurrentRow.Cells[2].Value.ToString();
            }
        }
    }
}
