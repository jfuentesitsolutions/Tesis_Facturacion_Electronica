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
    public partial class utilidades : Form
    {
        bool modificar = false;
        conexiones_BD.clases.utilidades utilidad;
        utilitarios.cargar_tablas tabla;
        string idutilidad = null;
        string porcentaje;

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

        public utilidades()
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
                eliminarUtilidad();
            }else
            {
                this.Close();
            }
            
        }

        private void utilidades_Load(object sender, EventArgs e)
        {
            gadgets.horientaciones_textos.colocarTitulo(panelTitulo, lblEncanezado);
            if (modificar)
            {
                cargarListas();
                cargarTablas();
                btnGuardar.Text = "Modificar";
                btnCancelar.Text = "Eliminar";
                habilitar(false);
            }
            else
            {
                cargarListas();
                cargarTablas();
            }
        }

        private void cargarTablas()
        {
            tabla = new utilitarios.cargar_tablas(tablaUtilidades, txtBuscar, conexiones_BD.clases.utilidades.datosTabla(), "nombre", lblReg);
            tabla.cargar();
        }

        private void habilitar(bool co)
        {
            List<Control> controles = new List<Control>();
            controles.Add(txtUtilidad);
            controles.Add(txtPorcen);
            controles.Add(listaTipoCompra);
            controles.Add(btnGuardar);
            controles.Add(btnCancelar);

            utilitarios.vaciando_formularios.habilitandoTexbox(controles, co);
        }

        private bool validar()
        {
            bool valido = false;
            List<TextBox> controles = new List<TextBox>();
            controles.Add(txtUtilidad);
            valido = utilitarios.vaciando_formularios.validando(controles, error);

            if (txtPorcen.Value == 0)
            {
                valido = true;
                error.SetError(txtPorcen, "La cantidad no puede quedar a cero.");
            }
            if (listaTipoCompra.SelectedIndex==-1)
            {
                valido = true;
                error.SetError(listaTipoCompra, "Elije un tipo de compra.");
            }


            return valido;
        }

        private void vaciarDatos()
        {
            List<Control> controles = new List<Control>();
            controles.Add(txtUtilidad);
            txtPorcen.Value = 0;
            listaTipoCompra.SelectedValue = "0";

            utilitarios.vaciando_formularios.vaciarTexbox(controles);
        }

        private bool validarExistencias()
        {
            bool existe = false;

            List<string> campos = new List<string>();
            campos.Add("nombre");
            List<string> valores = new List<string>();
            valores.Add(txtUtilidad.Text);

            utilidad = new conexiones_BD.clases.utilidades(campos, valores);

            if (modificar)
            {
                if (utilidad.validarCamposcondicorORActu(true, 1) > 1)
                {
                    existe = true;
                }
            }
            else
            {
                if (utilidad.validarCamposcondicorOR(true) > 0)
                {
                    existe = true;
                }
            }

            return existe;
        }

        private void guardarUtilidad()
        {
            if (!validar())
            {
                if (!validarExistencias())
                {
                    porcentaje = Convert.ToString(txtPorcen.Value / 100);
                    utilidad = new conexiones_BD.clases.utilidades(txtUtilidad.Text, porcentaje,listaTipoCompra.SelectedValue.ToString());
                    if (utilidad.guardar(true) > 0)
                    {
                        vaciarDatos();
                        cargarTablas();
                        txtUtilidad.Focus();
                    }
                }
            }
        }

        private void modificarUtilidad()
        {
            if (!validar())
            {
                if (!validarExistencias())
                {
                    porcentaje = Convert.ToString(txtPorcen.Value / 100);
                    utilidad = new conexiones_BD.clases.utilidades(idutilidad, txtUtilidad.Text, porcentaje, listaTipoCompra.SelectedValue.ToString());
                    if (utilidad.modificar(true) > 0)
                    {
                        habilitar(false);
                        vaciarDatos();
                        cargarTablas();
                    }
                }
            }
        }

        private void eliminarUtilidad()
        {
            if (utilidad != null)
            {
                utilidad = new conexiones_BD.clases.utilidades(idutilidad);
                if (utilidad.eliminar(true) > 0)
                {
                    habilitar(false);
                    vaciarDatos();
                    cargarTablas();
                }
            }
        }

        private void cargarListas()
        {
            utilitarios.cargandoListas.cargarLista(conexiones_BD.clases.tipo_compra.datosTabla(),
                listaTipoCompra,
                "nombre",
                "idtipo_compra");
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            tabla.FiltrarLocalmente();
        }

        private void tablaUtilidades_Click(object sender, EventArgs e)
        {
            if (modificar)
            {
                idutilidad = tablaUtilidades.CurrentRow.Cells[0].Value.ToString();
                txtUtilidad.Text = tablaUtilidades.CurrentRow.Cells[1].Value.ToString();
                txtPorcen.Value = Convert.ToInt32(tablaUtilidades.CurrentRow.Cells[2].Value.ToString());
                listaTipoCompra.SelectedValue = tablaUtilidades.CurrentRow.Cells[4].Value.ToString();
                habilitar(true);

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (modificar)
            {
                modificarUtilidad();
            }else
            {
                guardarUtilidad();
            }
        }
    }
}
