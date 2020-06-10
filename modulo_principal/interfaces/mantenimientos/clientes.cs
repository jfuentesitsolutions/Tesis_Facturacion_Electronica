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
    public partial class clientes : Form
    {
        bool modificar = false;
        bool nuevoClientes = false;
        bool ingresado = false;

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

        public bool NuevoClientes
        {
            get
            {
                return nuevoClientes;
            }

            set
            {
                nuevoClientes = value;
            }
        }

        public bool Ingresado
        {
            get
            {
                return ingresado;
            }

            set
            {
                ingresado = value;
            }
        }

        conexiones_BD.clases.clientes cliente;
        utilitarios.cargar_tablas tabla;
        string idcliente = null;

        public clientes()
        {
            InitializeComponent();
        }

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            gadgets.movimimientos mov = new gadgets.movimimientos();
            mov.moverFormulario(sender, e, this);
        }

        private void clientes_Load(object sender, EventArgs e)

        {
            gadgets.horientaciones_textos.colocarTitulo(panelTitulo, lblEncanezado);
            if (modificar)
            {
                btnGuardar.Text = "Modificar";
                btnCancelar.Text = "Eliminar";
                cargarListas();
                cargarTablas();
                habilitar(false);

            }else
            {
                cargarListas();
                cargarTablas();
            }
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
           
                this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (modificar)
            {
                eliminar();
            }else
            {
                this.Close();
            }
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (modificar)
            {
                modifica();
            }
            else
            {
                guardar();
            }
        }

        private void cargarTablas()
        {
            tabla = new utilitarios.cargar_tablas(tablaClientes, txtBuscar, conexiones_BD.clases.clientes.datosTabla(), "nombre_cliente", lblReg);
            tabla.cargar();
        }

        private void habilitar(bool co)
        {
            List<Control> controles = new List<Control>();
            controles.Add(txtNombres);
            controles.Add(txtApellidos);
            controles.Add(txtCodigo);
            controles.Add(txtDire);
            controles.Add(txtDui);
            controles.Add(txtNit);
            controles.Add(txtNcr);
            controles.Add(txtRazon);
            controles.Add(txtTel);
            controles.Add(txtEmail);
            controles.Add(listaDes);
            controles.Add(listaGenero);
            controles.Add(btnCraCodigo);
            controles.Add(btnGuardar);
            controles.Add(btnCancelar);
            controles.Add(chkEstado);

            utilitarios.vaciando_formularios.habilitandoTexbox(controles, co);
        }

        private bool validar()
        {
            bool valido = false;
            List<TextBox> controles = new List<TextBox>();
            controles.Add(txtNombres);
            controles.Add(txtApellidos);
            controles.Add(txtCodigo);
            controles.Add(txtDire);
            controles.Add(txtDui);
            controles.Add(txtNit);
            controles.Add(txtNcr);
            controles.Add(txtRazon);
            controles.Add(txtTel);
            controles.Add(txtEmail);

            valido = utilitarios.vaciando_formularios.validando(controles, error);

            if (listaDes.SelectedIndex == -1)
            {
                valido = true;
                error.SetError(listaDes, "Tienes que elegir un tipo de descuento");
            }
            if (listaGenero.SelectedIndex == -1 || listaGenero.SelectedIndex == 0)
            {
                valido = true;
                error.SetError(listaGenero, "Tienes que seleccionar un genero");
            }

            return valido;
        }

        private void vaciarDatos()
        {
            List<Control> controles = new List<Control>();
            controles.Add(txtNombres);
            controles.Add(txtApellidos);
            controles.Add(txtCodigo);
            controles.Add(txtDire);
            controles.Add(txtDui);
            controles.Add(txtNit);
            controles.Add(txtNcr);
            controles.Add(txtRazon);
            controles.Add(txtTel);
            controles.Add(txtEmail);

            utilitarios.vaciando_formularios.vaciarTexbox(controles);

            listaDes.SelectedValue = "0";
            listaGenero.SelectedIndex = 0;
            chkEstado.Checked = false;
        }

        private bool validarExistencias()
        {
            bool existe = false;

            List<string> campos = new List<string>();
            campos.Add("nombre_cliente");
            campos.Add("apellidos_cliente");
            campos.Add("cod_cliente");
            List<string> valores = new List<string>();
            valores.Add(txtNombres.Text);
            valores.Add(txtApellidos.Text);
            valores.Add(txtCodigo.Text);

            cliente = new conexiones_BD.clases.clientes(campos, valores);

            if (modificar)
            {
                if (cliente.validarCamposcondicorANDActu(true, 1) > 1)
                {
                    existe = true;
                }
            }
            else
            {
                if (cliente.validarCamposcondicorAND(true) > 0)
                {
                    existe = true;
                }
            }

            return existe;
        }

        private string estado()
        {
            if (chkEstado.Checked)
            {
                return "1";
            }
            else
            {
                return "2";
            }
        }

        private void guardar()
        {
            if (!validar())
            {
                if (!validarExistencias())
                {
                    utilitarios.maneja_fechas fe = new utilitarios.maneja_fechas();
                    cliente = new conexiones_BD.clases.clientes(txtCodigo.Text, 
                        txtNombres.Text, txtApellidos.Text, txtDire.Text, txtDui.Text, txtNit.Text, txtNcr.Text,
                        txtRazon.Text, txtTel.Text, txtEmail.Text, listaDes.SelectedValue.ToString(),
                        fe.fechaMysql(fecha), listaGenero.SelectedIndex.ToString(), this.estado());
                    if (cliente.guardar(true) > 0)
                    {
                        vaciarDatos();
                        cargarTablas();
                        if (nuevoClientes)
                        {
                            ingresado = true;
                            this.Close();
                        }else
                        {
                            txtNombres.Focus();
                        }
                        
                    }
                }
            }
        }

        private void cargarListas()
        {
            utilitarios.cargandoListas.cargarLista(conexiones_BD.clases.descuentos.datosTabla(), listaDes, "tipo_descuento", "iddescuento");
            utilitarios.cargandoListas.generarListasGenero(listaGenero);
        }

        private void modifica()
        {
            if (!validar())
            {
                if (!validarExistencias())
                {
                    utilitarios.maneja_fechas fe = new utilitarios.maneja_fechas();
                    cliente = new conexiones_BD.clases.clientes(
                        idcliente, 
                        txtCodigo.Text,
                        txtNombres.Text,
                        txtApellidos.Text,
                        txtDire.Text,
                        txtDui.Text,
                        txtNit.Text,
                        txtNcr.Text,
                        txtRazon.Text,
                        txtTel.Text,
                        txtEmail.Text,
                        listaDes.SelectedValue.ToString(),
                        fe.fechaMysql(fecha),
                        listaGenero.SelectedIndex.ToString(),
                        this.estado());
                    if (cliente.modificar(true) > 0)
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
            if (idcliente != null)
            {
                if (MessageBox.Show("¿Desea eliminar este registro?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                {
                    cliente = new conexiones_BD.clases.clientes(idcliente);
                    if (cliente.eliminar(true) > 0)
                    {
                        habilitar(false);
                        vaciarDatos();
                        cargarTablas();
                    }
                }

            }
        }

        private void btnCraCodigo_Click(object sender, EventArgs e)
        {
            if (txtNombres.TextLength != 0 || txtApellidos.TextLength !=0)
            {
                DateTime dia = DateTime.Today;
                string codigo="";
                codigo = txtNombres.Text.Substring(0, 1);
                codigo += txtApellidos.Text.Substring(0, 1);
                codigo += tablaClientes.Rows.Count.ToString();
                codigo += dia.Day.ToString();
                txtCodigo.Text = codigo.ToUpper();
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            tabla.FiltrarLocalmente();
        }

        private void tablaClientes_Click(object sender, EventArgs e)
        {
            if (modificar)
            {
                habilitar(true);
                btnCraCodigo.Enabled = false;
                idcliente = tablaClientes.CurrentRow.Cells[0].Value.ToString();
                txtCodigo.Text = tablaClientes.CurrentRow.Cells[1].Value.ToString();
                txtNombres.Text= tablaClientes.CurrentRow.Cells[2].Value.ToString();
                txtApellidos.Text= tablaClientes.CurrentRow.Cells[3].Value.ToString();
                txtDire.Text = tablaClientes.CurrentRow.Cells[4].Value.ToString();
                txtDui.Text = tablaClientes.CurrentRow.Cells[5].Value.ToString();
                txtNit.Text = tablaClientes.CurrentRow.Cells[6].Value.ToString();
                txtNcr.Text = tablaClientes.CurrentRow.Cells[7].Value.ToString();
                txtRazon.Text = tablaClientes.CurrentRow.Cells[8].Value.ToString();
                txtTel.Text = tablaClientes.CurrentRow.Cells[9].Value.ToString();
                txtEmail.Text = tablaClientes.CurrentRow.Cells[10].Value.ToString();
                listaDes.SelectedValue = tablaClientes.CurrentRow.Cells[12].Value.ToString();
                listaGenero.SelectedItem = tablaClientes.CurrentRow.Cells[14].Value.ToString();
                fecha.Text = tablaClientes.CurrentRow.Cells[13].Value.ToString();
                if (tablaClientes.CurrentRow.Cells[15].Value.Equals("activo"))
                {
                    chkEstado.Checked = true;
                }
                else
                {
                    chkEstado.Checked = false;
                }

            }
        }
    }
}
