using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfaces.correo
{
    public partial class envio : Form
    {
        string ruta_xml, ruta_pdf;
        bool enviado;
        public envio()
        {
            InitializeComponent();
        }

        public string Ruta_xml { get => ruta_xml; set => ruta_xml = value; }
        public string Ruta_pdf { get => ruta_pdf; set => ruta_pdf = value; }
        public bool Enviado { get => enviado; set => enviado = value; }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void envio_Load(object sender, EventArgs e)
        {
            gadgets.horientaciones_textos.colocarTitulo(panelTitulo, lblEncanezado);
        }

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            gadgets.movimimientos mov = new gadgets.movimimientos();
            mov.moverFormulario(sender, e, this);
        }

        private bool validar()
        {
            bool valido = false;
            error.Clear();

            if (!validaCorreo(txtCorreo.Text))
            {
                error.SetError(txtCorreo, "Coloque un correo valido");
                valido = true;
            }

            if (txtObservaciones.TextLength == 0)
            {
                error.SetError(txtObservaciones, "Coloque una obervación.");
                valido = true;
            }

            return valido;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (!validar())
            {
                utilitarios.envio_correo correo = new utilitarios.envio_correo(txtCorreo.Text, "Esta una prueba", txtObservaciones.Text, ruta_xml, ruta_pdf);

                using (espera_datos.splash_espera fe = new espera_datos.splash_espera())
                {
                    fe.Validar = correo.enviar_correo;
                    fe.Tipo_operacio = 3;

                    if (fe.ShowDialog() == DialogResult.OK)
                    {
                        if (fe.Creado)
                        {
                            MessageBox.Show("Correo enviado con exíto.", "Correo enviado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            enviado = true;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo enviar el correo, revise su conexión a internet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            enviado = false;
                        }
                    }
                }
            }
        }

        private bool validaCorreo(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
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
                return false;
            }
        }
    }
}
