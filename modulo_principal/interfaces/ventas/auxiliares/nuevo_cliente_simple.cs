using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfaces.ventas.auxiliares
{
    public partial class nuevo_cliente_simple : Form
    {
        bool ingresado = false;
        string nombre = "";
        bool modificar = false;
        string idcliente, genero;

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

        public DataTable Cli
        {
            get
            {
                return cli;
            }

            set
            {
                cli = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

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

        public string Idcliente
        {
            get
            {
                return idcliente;
            }

            set
            {
                idcliente = value;
            }
        }

        public string Genero
        {
            get
            {
                return genero;
            }

            set
            {
                genero = value;
            }
        }

        DataTable cli = null;
        conexiones_BD.clases.clientes cliente;
        public nuevo_cliente_simple()
        {
            InitializeComponent();
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nuevo_cliente_simple_Load(object sender, EventArgs e)
        {
            gadgets.horientaciones_textos.colocarTitulo(panelTitulo, lblEncanezado);
            cargarListas();
            if (modificar)
            {
                btnGuardar.Text = "Modificar";
                listaGenero.SelectedIndex = listaGenero.FindString(this.genero);
            }
        }

        private void nuevo_cliente_simple_MouseDown(object sender, MouseEventArgs e)
        {
            gadgets.movimimientos mov = new gadgets.movimimientos();
            mov.moverFormulario(sender, e, this);
        }

        private string codigo()
        {
            string cod = "";
            if (txtNombres.TextLength != 0 || txtApellidos.TextLength != 0)
            {
                DateTime dia = DateTime.Today;
                string codigo = "";
                codigo = txtNombres.Text.Substring(0, 1);
                codigo += txtApellidos.Text.Substring(0, 1);
                codigo += cli.Rows.Count.ToString();
                codigo += dia.Day.ToString();
                cod = codigo.ToUpper();
            }

            return cod;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!this.modificar)
            {
                if (!validar())
                {
                    if (!validarExistencias())
                    {
                        utilitarios.maneja_fechas fech = new utilitarios.maneja_fechas();
                        cliente = new conexiones_BD.clases.clientes(
                            codigo(),
                            txtNombres.Text,
                            txtApellidos.Text,
                            txtDire.Text,
                            "-",
                            "-",
                            "-",
                            "-",
                            "-",
                            "-",
                            "1",
                            fech.fechaMysql(fecha),
                            listaGenero.SelectedValue.ToString(),
                            "1");

                        long res=cliente.ingresandoCliente(true);
                        

                        if ( res > 0)
                        {
                            idcliente = res.ToString();
                            System.Console.Write("El codigo asignado al cliente es: "+res);
                            ingresado = true;
                            nombre = txtNombres.Text;
                            this.Close();
                        }else
                        {
                            MessageBox.Show("No se pudo ingresar");
                        }
                    }

                }
            }else
            {
                    if (!validar())
                    {
                        conexiones_BD.clases.clientes cl = new conexiones_BD.clases.clientes(
                        idcliente, txtNombres.Text, txtApellidos.Text, txtDire.Text,
                        listaGenero.SelectedValue.ToString(),
                        "1"
                        );

                    if (cl.actualizarCliente())
                    {
                        ingresado = true;
                        nombre = txtNombres.Text;
                        this.Close();
                    }
                }
            }
            
        }

        private void cargarListas()
        {
            utilitarios.cargandoListas.generarListasGenero(listaGenero);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool validar()
        {
            bool valida = false;

            error.Clear();
            string mensaje = "No puedes dejar este campo en blanco";

            if (txtNombres.TextLength==0)
            {
                valida = true;
                error.SetError(txtNombres, mensaje);
            }

            if (txtApellidos.TextLength == 0)
            {
                valida = true;
                error.SetError(txtApellidos, mensaje);
            }
            if (txtDire.TextLength == 0)
            {
                valida = true;
                error.SetError(txtDire, mensaje);
            }

            if (listaGenero.SelectedIndex == -1 || listaGenero.SelectedIndex == 0)
            {
                valida = true;
                error.SetError(listaGenero, "Tienes que seleccionar un genero");
            }

            return valida;
        }

        private void txtNombres_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txtApellidos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private bool validarExistencias()
        {
            bool existe = false;

            List<string> campos = new List<string>();
            campos.Add("nombre_cliente");
            campos.Add("apellidos_cliente");

            List<string> valores = new List<string>();
            valores.Add(txtNombres.Text);
            valores.Add(txtApellidos.Text);


            cliente = new conexiones_BD.clases.clientes(campos, valores);

            
                if (cliente.validarCamposcondicorAND(true) > 0)
                {
                    existe = true;
                }
            

            return existe;
        }
    }
}
