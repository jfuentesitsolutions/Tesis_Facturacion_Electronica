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
    public partial class empresa : Form
    {
        bool actualizar = false;
        string idempresa;
        sessionManager.secion sesion = sessionManager.secion.Instancia;

        public bool Actualizar
        {
            get
            {
                return actualizar;
            }

            set
            {
                actualizar = value;
            }
        }

        public string Idempresa
        {
            get
            {
                return idempresa;
            }

            set
            {
                idempresa = value;
            }
        }

        public empresa()
        {
            InitializeComponent();
        }

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            gadgets.movimimientos mov = new gadgets.movimimientos();
            mov.moverFormulario(sender, e, this);
        }

        private void empresa_Load(object sender, EventArgs e)
        {
            gadgets.horientaciones_textos.colocarTitulo(panelTitulo, lblEncanezado);
            if (Actualizar)
            {
                DataTable datos = conexiones_BD.clases.empresa.datos_empresa();
                if (datos.Rows.Count != 0)
                {
                    idempresa = datos.Rows[0][0].ToString();
                    txtNombre.Text= datos.Rows[0][1].ToString();
                    txtNRC.Text = datos.Rows[0][2].ToString();
                    txtRazon.Text = datos.Rows[0][3].ToString();
                    txtDenomi.Text = datos.Rows[0][4].ToString();
                    txtGiro.Text = datos.Rows[0][5].ToString();
                    txtNit.Text = datos.Rows[0][6].ToString();
                    txtDireccion.Text = datos.Rows[0][7].ToString();
                    txtPfx.Text = datos.Rows[0][8].ToString().Replace("\\", @"\\");
                    txtCerti.Text = datos.Rows[0][9].ToString().Replace("\\", @"\\");

                    btnGuarda.Text = "Modificar";
                }
            }
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool validar()
        {
            List<TextBox> text = new List<TextBox>();
            text.Add(txtNombre);
            text.Add(txtNRC);
            text.Add(txtRazon);
            text.Add(txtDenomi);
            text.Add(txtGiro);
            text.Add(txtNit);
            text.Add(txtDireccion);
            text.Add(txtCerti);
            text.Add(txtPfx);

            return utilitarios.vaciando_formularios.validando(text, error);
        }

        private void btnGuarda_Click(object sender, EventArgs e)
        {
            if (!validar())
            {
                if (!Actualizar)
                {

                    conexiones_BD.clases.empresa empresa = new conexiones_BD.clases.empresa(
                    txtNombre.Text,
                    txtNRC.Text,
                    txtRazon.Text,
                    txtDenomi.Text,
                    txtGiro.Text,
                    txtDireccion.Text,
                    txtNit.Text,
                    txtCerti.Text,
                    txtPfx.Text,
                    false
                    );
                    if (empresa.guardar(true) > 0)
                    {
                        sesion.Empresa_activa = true;
                        this.Close();
                    }

                }else
                {
                    
                    conexiones_BD.clases.empresa empresa = new conexiones_BD.clases.empresa(
                    txtNombre.Text,
                    txtNRC.Text,
                    txtRazon.Text,
                    txtDenomi.Text,
                    txtGiro.Text,
                    txtDireccion.Text,
                    txtNit.Text,
                    txtCerti.Text,
                    txtPfx.Text,
                    true
                    );

                    if (empresa.actualizando_empresa(idempresa))
                    {
                        MessageBox.Show("La información de la empresa se modifico con exíto", "Información modificada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    } else
                    {
                        MessageBox.Show("La información de la empresa no se pudo modificar", "Error al mmodificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
   
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar_certificado.InitialDirectory = @"C:\";
            buscar_certificado.Filter = "pfx files (*.cer)|*.cer";
            buscar_certificado.FilterIndex = 2;
            buscar_certificado.FileName = "certificado.cer";
            buscar_certificado.RestoreDirectory = true;

            if (buscar_certificado.ShowDialog() == DialogResult.OK)
            {
                txtCerti.Text = buscar_certificado.FileName.Replace("\\",@"\\");
            }
        }

        private void btnBuscar2_Click(object sender, EventArgs e)
        {
            buscar_pfx.InitialDirectory = @"C:\";
            buscar_pfx.Filter = "pfx files (*.pfx)|*.pfx";
            buscar_pfx.FilterIndex = 2;
            buscar_pfx.FileName = "certificado.pfx";
            buscar_pfx.RestoreDirectory = true;

            if (buscar_pfx.ShowDialog() == DialogResult.OK)
            {
                txtPfx.Text = buscar_pfx.FileName.Replace("\\", @"\\");
            }
        }
    }
}
