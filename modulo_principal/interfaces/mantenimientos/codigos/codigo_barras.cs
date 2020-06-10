using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BarcodeLib;
using System.Drawing.Imaging;

namespace interfaces.mantenimientos.codigos
{
    public partial class codigo_barras : Form
    {
        bool guardado;

        public bool Guardado
        {
            get
            {
                return guardado;
            }

            set
            {
                guardado = value;
            }
        }

        public codigo_barras()
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

        private void codigo_barras_Load(object sender, EventArgs e)
        {
            gadgets.horientaciones_textos.colocarTitulo(panelTitulo, lblEncanezado);
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            BarcodeLib.Barcode codigo = new BarcodeLib.Barcode();
            codigo.IncludeLabel = true;
            panel_codigo.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE128, txtCodigo.Text, Color.Black, Color.White, 271, 100);
            btnGuardar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Image imagen = (Image)panel_codigo.BackgroundImage.Clone();

            SaveFileDialog caja = new SaveFileDialog();
            caja.AddExtension = true;
            caja.Filter = "Imagen PNG (*.png)|*.png";
            caja.ShowDialog();
            if (!string.IsNullOrEmpty(caja.FileName))
            {
                try
                {
                    imagen.Save(caja.FileName, ImageFormat.Png);
                    Guardado = true;
                    this.Close();
                }
                catch
                {

                }

            }
            imagen.Dispose();
        }
    }
}
