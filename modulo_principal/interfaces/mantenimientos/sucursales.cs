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
    public partial class sucursales : Form
    {
        sessionManager.secion sesion = sessionManager.secion.Instancia;
        bool modificar = false;
        conexiones_BD.clases.sucursales sucursal;
        utilitarios.cargar_tablas tabla;
        string idsucursal=null;
        bool agregado = false;
        transferencias_internet.xml xm = new transferencias_internet.xml();

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

        public sucursales()
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
                eliminarSucursal();
            }else
            {
                this.Close();
            }
            
        }

        private void sucursales_Load(object sender, EventArgs e)
        {
            gadgets.horientaciones_textos.colocarTitulo(panelTitulo, lblEncanezado);
            if (Modificar)
            {
                btnGuardar.Text="Modificar";
                btnCancelar.Text = "Eliminar";
                habilitar(false);
                cargarTabla();

            }else
            {
                cargarTabla();
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            tabla.FiltrarLocalmente();
        }

        private void cargarTabla()
        {
            tabla = new utilitarios.cargar_tablas(tablaSucursales, txtBuscar, conexiones_BD.clases.sucursales.datosTabla(), "numero_de_sucursal", lblRegistros);
            tabla.cargar();
        }

        private void habilitar(bool con)
        {
            List<Control> control = new List<Control>();
            control.Add(txtSucursal);
            control.Add(txtDireccion);
            control.Add(txtTelefono);
            control.Add(txtEncargado);
            control.Add(btnGuardar);
            control.Add(btnCancelar);
            utilitarios.vaciando_formularios.habilitandoTexbox(control, con);
        }

        private bool validar()
        {
            bool valido = false;
            List<TextBox> control = new List<TextBox>();
            control.Add(txtDireccion);
            control.Add(txtTelefono);
            control.Add(txtEncargado);
            valido =utilitarios.vaciando_formularios.validando(control, error);
            if (txtSucursal.Value == 0)
            {
                valido = true;
                error.SetError(txtSucursal, "Tienen que elegir una sucursal valida");
            }


            return valido;
        }

        private void vaciarDatos()
        {
            List<Control> control = new List<Control>();
            control.Add(txtDireccion);
            control.Add(txtTelefono);
            control.Add(txtEncargado);
            utilitarios.vaciando_formularios.vaciarTexbox(control);
            txtSucursal.Value = 0;
        }

        private bool validandoExistencias()
        {
            List<string> campos = new List<string>();
            List<string> valores = new List<string>();

            campos.Add("numero_de_sucursal");
            valores.Add(txtSucursal.Text);

            sucursal = new conexiones_BD.clases.sucursales(campos, valores);

            if (modificar)
            {
                if (sucursal.validarCamposcondicorOR(true) >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {

            if (sucursal.validarCamposcondicorOR(true) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

            }
        }

        private void guardarSucursal()
        {
            if (!validar())
            {
                if (!validandoExistencias())
                {
                    xm._crearXml("sucursal", Convert.ToInt16(sesion.DatosRegistro[0]), "sucursales.xml");
                    sucursal = new conexiones_BD.clases.sucursales(txtSucursal.Value.ToString(), txtDireccion.Text, txtTelefono.Text, txtEncargado.Text);
                    if (sucursal.guardar(true) > 0)
                    {
                        xm._AñadirSucursal(sucursal, Convert.ToInt16(sesion.DatosRegistro[0]));
                        vaciarDatos();
                        cargarTabla();
                        txtSucursal.Focus();
                        agregado = true;
                    }
                }
            }
        }

        private void modificarSucursal()
        {
            if (!validar())
            {
                sucursal = new conexiones_BD.clases.sucursales(idsucursal, txtSucursal.Value.ToString(), txtDireccion.Text, txtTelefono.Text, txtEncargado.Text);
                if (sucursal.modificar(true) > 0)
                {
                    vaciarDatos();
                    habilitar(false);
                    cargarTabla();
                }
            }
        }

        private void eliminarSucursal()
        {
            if (idsucursal!=null)
            {
                sucursal = new conexiones_BD.clases.sucursales(idsucursal);
                if (sucursal.eliminar(true) > 0)
                {
                    vaciarDatos();
                    habilitar(false);
                    cargarTabla();
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Modificar)
            {
                modificarSucursal();
            }else
            {
                guardarSucursal();
            }
        }

        private void tablaSucursales_Click(object sender, EventArgs e)
        {
            if (modificar)
            {
                idsucursal = tablaSucursales.CurrentRow.Cells[0].Value.ToString();
                txtSucursal.Value = Convert.ToUInt32(tablaSucursales.CurrentRow.Cells[1].Value.ToString());
                txtDireccion.Text = tablaSucursales.CurrentRow.Cells[2].Value.ToString();
                txtTelefono.Text = tablaSucursales.CurrentRow.Cells[3].Value.ToString();
                txtEncargado.Text = tablaSucursales.CurrentRow.Cells[4].Value.ToString();
                habilitar(true);
            }
        }
    }
}
