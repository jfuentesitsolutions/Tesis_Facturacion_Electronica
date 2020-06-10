using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfaces.mantenimientos.base_datos
{
    public partial class base_d : Form
    {
        sessionManager.secion sesion = sessionManager.secion.Instancia;
        public base_d()
        {
            InitializeComponent();
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            gadgets.movimimientos mov = new gadgets.movimimientos();
            mov.moverFormulario(sender, e, this);
        }

        private void base_d_Load(object sender, EventArgs e)
        {
            gadgets.horientaciones_textos.colocarTitulo(panelTitulo, lblEncanezado);
        }

        private void btnGenerarCodigo_Click(object sender, EventArgs e)
        {
            guardar.ShowDialog();
            
        }

        private void guardar_FileOk(object sender, CancelEventArgs e)
        {
            string name = guardar.FileName;
            txtRuta.Text = name;
        }

        private void btnRespaldar_Click(object sender, EventArgs e)
        {
            if (txtRuta.TextLength != 0)
            {
                using (espera_datos.carga_tablas fe = new espera_datos.carga_tablas())
                {
                    fe.Accion = respaldardatos;
                    fe.Retorno = false;
                    if (fe.ShowDialog() == DialogResult.OK)
                    {
                        lblRespuesta.Text = "La base se respaldo con éxito";
                        lblRespuesta.ForeColor = Color.Green;
                        txtRuta.Text = "";
                    }else
                    {
                        
                    }
                }
            }
            
        }

        private void respaldardatos()
        {
            
                conexiones_BD.Conexion con = new conexiones_BD.Conexion();
                if (!con.exportar(txtRuta.Text))
                {
                MessageBox.Show("Ocurrio un error con la base de datos", "No se pudo respaldar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            buscar.ShowDialog();
        }

        private void buscar_FileOk(object sender, CancelEventArgs e)
        {
            string name = buscar.FileName;
            txtBu.Text = name;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtBu.TextLength != 0)
            {
                using (espera_datos.carga_tablas fe = new espera_datos.carga_tablas())
                {
                    fe.Accion = importarbase;
                    fe.Retorno = false;
                    if (fe.ShowDialog() == DialogResult.OK)
                    {
                        lblres.Text = "La base se importo con éxito";
                        lblres.ForeColor = Color.Green;
                        txtBu.Text = "";
                    }
                    else
                    {
                        
                    }
                }
            }
        }

        private void importarbase()
        {
            conexiones_BD.Conexion con = new conexiones_BD.Conexion();
            if (!con.importar(txtBu.Text))
            {
                MessageBox.Show("Ocurrio un error con la base de datos", "No se pudo importar", MessageBoxButtons.OK, MessageBoxIcon.Error);   
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
