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
    public partial class proveedores : Form
    {
        bool modificar = false;
        conexiones_BD.clases.proveedores proveedor;
        utilitarios.cargar_tablas tabla;
        string idproveedor = null;
        DataGridView tablacuentas=null;
        conexiones_BD.operaciones op;

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

        public proveedores()
        {
            InitializeComponent();
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

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            gadgets.movimimientos mov = new gadgets.movimimientos();
            mov.moverFormulario(sender, e, this);
        }

        private void proveedores_Load(object sender, EventArgs e)
        {
            gadgets.horientaciones_textos.colocarTitulo(panelTitulo, lblEncanezado);
            if (Modificar)
            {
                btnGuardar.Text = "Modificar";
                btnCancelar.Text = "Eliminar";
                cargarTablas();
                habilitar(false);
            }else
            {
                cargarTablas();
                cargaLista();
            }
        }

        private void btnCuentas_proveedores_Click(object sender, EventArgs e)
        {
            if (Modificar)
            {
                auxiliares.cuentas_proveedores cuenta = new auxiliares.cuentas_proveedores();
                cuenta.Modificar = this.Modificar;
                cuenta.Idproveedor = idproveedor;
                cuenta.ShowDialog();
                if (cuenta.CuentasAgregadas)
                {
                    asignación.Visible = true; 
                }
            }
            else
            {
                auxiliares.cuentas_proveedores cuenta = new auxiliares.cuentas_proveedores();
                cuenta.Tabla2 = this.tablacuentas;
                cuenta.ShowDialog();
                if (cuenta.CuentasAgregadas)
                {
                    asignación.Visible = true;
                    tablacuentas = cuenta.tablaCuentas;
                }
            }
        }

        private void cargarTablas()
        {
            tabla = new utilitarios.cargar_tablas(tablaProveedores, txtBuscar, conexiones_BD.clases.proveedores.datosTabla(), "nombre_proveedor", lblReg);
            tabla.cargar();
        }

        private void cargaLista()
        {
            utilitarios.cargandoListas.cargarTexbox(conexiones_BD.clases.proveedores.datosTabla(), txtProveedor);
        }

        private void habilitar(bool co)
        {
            List<Control> controles = new List<Control>();
            controles.Add(txtCodigo);
            controles.Add(txtProveedor);
            controles.Add(txtDui);
            controles.Add(txtNit);
            controles.Add(txtNcr);
            controles.Add(txtDireccion);
            controles.Add(txtTelefono);
            controles.Add(txtCorreo);
            controles.Add(btnCancelar);
            controles.Add(btnGuardar);
            controles.Add(btnCuentas_proveedores);

            utilitarios.vaciando_formularios.habilitandoTexbox(controles, co);
        }

        private bool validar()
        {
            bool valido = false;
            List<TextBox> controles = new List<TextBox>();
            controles.Add(txtCodigo);
            controles.Add(txtProveedor);
            controles.Add(txtDui);
            controles.Add(txtNit);
            controles.Add(txtNcr);
            controles.Add(txtDireccion);
            controles.Add(txtTelefono);
            controles.Add(txtCorreo);

            valido = utilitarios.vaciando_formularios.validando(controles, error);

            if (Modificar)
            {

            }else
            {
                if (tablacuentas == null || tablacuentas.Rows.Count == 0)
                {
                    valido = true;
                    error.SetError(btnCuentas_proveedores, "Tienes que asignar almenos una cuenta");
                }
            }
            

            return valido;
        }

        private void vaciarDatos()
        {
            List<Control> controles = new List<Control>();
            controles.Add(txtCodigo);
            controles.Add(txtProveedor);
            controles.Add(txtDui);
            controles.Add(txtNit);
            controles.Add(txtNcr);
            controles.Add(txtDireccion);
            controles.Add(txtTelefono);
            controles.Add(txtCorreo);
            tablacuentas = null;
            asignación.Visible = false;

            utilitarios.vaciando_formularios.vaciarTexbox(controles);
        }

        private bool validarExistencias()
        {
            bool existe = false;

            List<string> campos = new List<string>();
            campos.Add("cod_proveedor");
            campos.Add("nombre_proveedor");
            List<string> valores = new List<string>();
            valores.Add(txtCodigo.Text);
            valores.Add(txtProveedor.Text);

            proveedor = new conexiones_BD.clases.proveedores(campos, valores);

            if (Modificar)
            {
                if (proveedor.validarCamposcondicorORActu(true, 1) > 1)
                {
                    existe = true;
                }
            }
            else
            {
                if (proveedor.validarCamposcondicorOR(true) > 0)
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
                    proveedor = new conexiones_BD.clases.proveedores(txtCodigo.Text, txtProveedor.Text,
                        txtDui.Text, txtNit.Text, txtNcr.Text, txtDireccion.Text, txtTelefono.Text, txtCorreo.Text);
                    List<conexiones_BD.clases.cuentas_proveedores> cuen = new List<conexiones_BD.clases.cuentas_proveedores>();
                    foreach(DataGridViewRow fila in tablacuentas.Rows)
                    {
                        cuen.Add(new conexiones_BD.clases.cuentas_proveedores("0",fila.Cells[4].Value.ToString(), fila.Cells[2].Value.ToString()));
                    }

                    op = new conexiones_BD.operaciones();
                    if(op.transaccionCuentas_proveedores(cuen, proveedor) > 0)
                    {
                        MessageBox.Show("El proveedor se ingreso correctamente", "Exíto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        vaciarDatos();
                        cargarTablas();
                    }else
                    {
                        MessageBox.Show("No se puedo ingresar el proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    proveedor = new conexiones_BD.clases.proveedores(idproveedor, txtCodigo.Text, txtProveedor.Text,
                        txtDui.Text, txtNit.Text, txtNcr.Text, txtDireccion.Text, txtTelefono.Text, txtCorreo.Text);
                    if (proveedor.modificar(true) > 0)
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
            if (idproveedor != null)
            {
                proveedor = new conexiones_BD.clases.proveedores(idproveedor);
                if (proveedor.eliminar(true) > 0)
                {

                    habilitar(false);
                    vaciarDatos();
                    cargarTablas();
                }
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

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            tabla.FiltrarLocalmente();
        }

        private void tablaProveedores_Click(object sender, EventArgs e)
        {
            if (Modificar)
            {
                habilitar(true);

                asignación.Visible = true;
                idproveedor = tablaProveedores.CurrentRow.Cells[0].Value.ToString();
                txtCodigo.Text = tablaProveedores.CurrentRow.Cells[1].Value.ToString();
                txtProveedor.Text = tablaProveedores.CurrentRow.Cells[2].Value.ToString();
                txtDui.Text = tablaProveedores.CurrentRow.Cells[3].Value.ToString();
                txtNit.Text = tablaProveedores.CurrentRow.Cells[4].Value.ToString();
                txtNcr.Text = tablaProveedores.CurrentRow.Cells[5].Value.ToString();
                txtDireccion.Text = tablaProveedores.CurrentRow.Cells[6].Value.ToString();
                txtTelefono.Text = tablaProveedores.CurrentRow.Cells[7].Value.ToString();
                txtCorreo.Text = tablaProveedores.CurrentRow.Cells[8].Value.ToString();
            }
        }
    }
}
