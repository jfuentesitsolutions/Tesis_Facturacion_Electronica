using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace interfaces.mantenimientos.conexion
{
    public partial class conexion : Form
    {
        public conexion()
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

        private void conexion_Load(object sender, EventArgs e)
        {
            gadgets.horientaciones_textos.colocarTitulo(panelTitulo, lblEncanezado);
            txtDireccionServidor.ReadOnly = true;
            txtDireccionServidor.Text = "localhost";
        }

        private void btnProbar_Click(object sender, EventArgs e)
        {
            if (validar())
            {

            }
            else
            {

                conexiones_BD.Conexion cone = new conexiones_BD.Conexion();
                if (cone.conectarInstantanea(txtDireccionServidor.Text, txtBaseDatos.Text, txtUsuario.Text, txtContrase.Text))
                {
                    if (MessageBox.Show("La conexión se realizo con exíto, ¿Deseas guardar la configuración?", "Exito", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)==DialogResult.Yes)
                    {
                        guardarConexion();
                    }
                }else
                {
                    MessageBox.Show("No se puedo conectar a la base", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void elegirtipoConexion()
        {
            if (chklocal.Checked)
            {
                txtDireccionServidor.ReadOnly = true;
                txtDireccionServidor.Text = "localhost";
            }else if(chkremota.Checked)
            {
                txtDireccionServidor.ReadOnly = false;
                txtDireccionServidor.Text = "";
            }
        }

        private void chklocal_CheckedChanged(object sender, EventArgs e)
        {
            elegirtipoConexion();
        }

        private void chkremota_CheckedChanged(object sender, EventArgs e)
        {
            elegirtipoConexion();
        }

        private bool validar()
        {
            bool valido = false;
            error.Clear();
            string mensaje = "No puedes dejar este campo en blanco";

            if (txtDireccionServidor.TextLength==0)
            {
                valido = true;
                error.SetError(txtDireccionServidor, mensaje);
            }
            if (txtBaseDatos.TextLength == 0)
            {
                valido = true;
                error.SetError(txtBaseDatos, mensaje);
            }
            if (txtUsuario.TextLength == 0)
            {
                valido = true;
                error.SetError(txtUsuario, mensaje);
            }
            if (txtContrase.TextLength == 0)
            {
                valido = true;
                error.SetError(txtContrase, mensaje);
            }

            return valido;
        }

        private void guardarConexion()
        {
            RegistryKey rk = Registry.CurrentUser.CreateSubKey(@"PuntoVentaGerardo\configura");

            rk.SetValue("ipservidor", txtDireccionServidor.Text);
            rk.SetValue("nombre_db", txtBaseDatos.Text);
            rk.SetValue("usuario", txtUsuario.Text);
            rk.SetValue("$$", txtContrase.Text);
            rk.Close();

            string lectura = (string)Registry.GetValue("HKEY_CURRENT_USER\\PuntoVentaGerardo\\configura", "ipservidor", "NE");
            if (lectura.Equals("NE"))
            {
                MessageBox.Show("No se pudo guardar la conexión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            {
                MessageBox.Show("La conexión se guardo con exíto", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            btnProbar.PerformClick();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
