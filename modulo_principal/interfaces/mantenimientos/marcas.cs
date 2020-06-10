using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace interfaces.mantenimientos
{
    public partial class marcas : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hand, int msg, int wparam, int lparam);


        bool modificar = false;
        conexiones_BD.clases.marcas marca;
        utilitarios.cargar_tablas tabla;
        string idmarca = null;
        bool agregado = false;

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

        public marcas()
        {
            InitializeComponent();
        }
        private void marcas_Load(object sender, EventArgs e)
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

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            gadgets.movimimientos mov = new gadgets.movimimientos();
            mov.moverFormulario(sender, e, this);
            
        }

        private void cargarTablas()
        {
            tabla = new utilitarios.cargar_tablas(tablaMarcas, txtBuscar, conexiones_BD.clases.marcas.datosTabla(), "nombre", lblReg);
            tabla.cargar();
        }

        private void habilitar(bool co)
        {
            List<Control> controles = new List<Control>();
            controles.Add(txtMarca);
            controles.Add(txtDescripcion);
            controles.Add(btnGuardar);
            controles.Add(btnCancelar);

            utilitarios.vaciando_formularios.habilitandoTexbox(controles, co);
        }

        private bool validar()
        {
            bool valido = false;
            List<TextBox> controles = new List<TextBox>();
            controles.Add(txtMarca);
            controles.Add(txtDescripcion);

            valido = utilitarios.vaciando_formularios.validando(controles, error);

            return valido;
        }

        private void vaciarDatos()
        {
            List<Control> controles = new List<Control>();
            controles.Add(txtMarca);
            controles.Add(txtDescripcion);

            utilitarios.vaciando_formularios.vaciarTexbox(controles);
        }

        private bool validarExistencias()
        {
            bool existe = false;

            List<string> campos = new List<string>();
            campos.Add("nombre");
            List<string> valores = new List<string>();
            valores.Add(txtMarca.Text);

            marca = new conexiones_BD.clases.marcas(campos, valores);

            if (modificar)
            {
                if (marca.validarCamposcondicorORActu(true, 1) > 1)
                {
                    existe = true;
                }
            }
            else
            {
                if (marca.validarCamposcondicorOR(true) > 0)
                {
                    existe = true;
                }
            }

            return existe;
        }

        private void guardarMarca()
        {
            if (!validar())
            {
                if (!validarExistencias())
                {
                    marca = new conexiones_BD.clases.marcas(txtMarca.Text, txtDescripcion.Text);
                    if (marca.guardar(true) > 0)
                    {
                        vaciarDatos();
                        cargarTablas();
                        txtMarca.Focus();
                        Agregado = true;
                    }
                }
            }
        }

        private void modificarMarca()
        {
            if (!validar())
            {
                if (!validarExistencias())
                {
                    marca = new conexiones_BD.clases.marcas(idmarca, txtMarca.Text, txtDescripcion.Text);
                    if (marca.modificar(true) > 0)
                    {
                        habilitar(false);
                        vaciarDatos();
                        cargarTablas();
                    }
                }
            }
        }

        private void eliminarMarca()
        {
            if (idmarca != null)
                {
                    marca = new conexiones_BD.clases.marcas(idmarca);
                    if (marca.eliminar(true) > 0)
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

        private void tablaMarcas_Click(object sender, EventArgs e)
        {
            try
            {
                if (modificar)
                {
                    idmarca = tablaMarcas.CurrentRow.Cells[0].Value.ToString();
                    txtMarca.Text = tablaMarcas.CurrentRow.Cells[1].Value.ToString();
                    txtDescripcion.Text = tablaMarcas.CurrentRow.Cells[2].Value.ToString();
                    habilitar(true);
                }
            }
            catch
            {

            }
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (modificar)
            {
                modificarMarca();
            }else
            {
                guardarMarca();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (modificar)
            {
                eliminarMarca();
            }else
            {
                this.Close();
            }
        }
    }
}
