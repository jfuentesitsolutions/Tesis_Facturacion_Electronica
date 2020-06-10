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
    public partial class tipos_compras : Form
    {
        bool modificar = false;
        conexiones_BD.clases.tipo_compra tipoC;
        utilitarios.cargar_tablas tabla;
        string idtipo_compra=null;

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

        public tipos_compras()
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
                eliminarTipo_compra();
            }else
            {
                this.Close();
            }
            
        }

        private void tipos_compras_Load(object sender, EventArgs e)
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
            tabla = new utilitarios.cargar_tablas(tablaTiposCompras, txtBuscar, conexiones_BD.clases.tipo_compra.datosTabla(), "nombre", lblReg);
            tabla.cargar();
        }

        private void habilitar(bool co)
        {
            List<Control> controles = new List<Control>();
            controles.Add(txtCompra);
            controles.Add(txtDescripcion);
            controles.Add(btnGuardar);
            controles.Add(btnCancelar);

            utilitarios.vaciando_formularios.habilitandoTexbox(controles, co);
        }

        private bool validar()
        {
            bool valido = false;
            List<TextBox> controles = new List<TextBox>();
            controles.Add(txtCompra);
            controles.Add(txtDescripcion);

            valido = utilitarios.vaciando_formularios.validando(controles, error);

            return valido;
        }

        private void vaciarDatos()
        {
            List<Control> controles = new List<Control>();
            controles.Add(txtCompra);
            controles.Add(txtDescripcion);

            utilitarios.vaciando_formularios.vaciarTexbox(controles);
        }

        private bool validarExistencias()
        {
            bool existe = false;

            List<string> campos = new List<string>();
            campos.Add("nombre");
            List<string> valores = new List<string>();
            valores.Add(txtCompra.Text);

            tipoC = new conexiones_BD.clases.tipo_compra(campos, valores);

            if (modificar)
            {
                if (tipoC.validarCamposcondicorORActu(true, 1) > 1)
                {
                    existe = true;
                }
            }
            else
            {
                if (tipoC.validarCamposcondicorOR(true) > 0)
                {
                    existe = true;
                }
            }

            return existe;
        }

        private void guardarTipo_compra()
        {
            if (!validar())
            {
                if (!validarExistencias())
                {
                    tipoC = new conexiones_BD.clases.tipo_compra(txtCompra.Text, txtDescripcion.Text);
                    if (tipoC.guardar(true) > 0)
                    {
                        vaciarDatos();
                        cargarTablas();
                        txtCompra.Focus();
                    }
                }
            }
        }

        private void modificarTipos_compra()
        {
            if (!validar())
            {
                if (!validarExistencias())
                {
                    tipoC = new conexiones_BD.clases.tipo_compra(idtipo_compra, txtCompra.Text, txtDescripcion.Text);
                    if (tipoC.modificar(true) > 0)
                    {
                        habilitar(false);
                        vaciarDatos();
                        cargarTablas();
                    }
                }
            }
        }

        private void eliminarTipo_compra()
        {
            if (idtipo_compra != null)
            {
                tipoC = new conexiones_BD.clases.tipo_compra(idtipo_compra);
                if (tipoC.eliminar(true) > 0)
                {
                    habilitar(false);
                    vaciarDatos();
                    cargarTablas();
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (modificar)
            {
                modificarTipos_compra();
            }else
            {
                guardarTipo_compra();
            }
        }

        private void tablaTiposCompras_Click(object sender, EventArgs e)
        {
            if (modificar)
            {
                idtipo_compra = tablaTiposCompras.CurrentRow.Cells[0].Value.ToString();
                txtCompra.Text = tablaTiposCompras.CurrentRow.Cells[1].Value.ToString();
                txtDescripcion.Text = tablaTiposCompras.CurrentRow.Cells[2].Value.ToString();
                habilitar(true);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            tabla.FiltrarLocalmente();
        }
    }
}
