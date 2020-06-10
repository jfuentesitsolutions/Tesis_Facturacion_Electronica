using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfaces.ventas
{
    public partial class ventas : Form
    {
        int conteo = 0;
        public ventas()
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

        private void ventas_Load(object sender, EventArgs e)
        {
            gadgets.horientaciones_textos.colocarTitulo(panelTitulo, lblEncanezado);
            panelLateral.Width = 0;
            colocarPanel(new panel.venta(), true,"");  

        }

        private void menu_Click(object sender, EventArgs e)
        {
            slider();
            gadgets.horientaciones_textos.colocarTitulo(panelTitulo, lblEncanezado);
        }

        private void slider()
        {
            if (panelLateral.Width == 0)
            {
                panelLateral.Width = 157;
                lblTitulo.Visible = true;
            }
            else
            {
                panelLateral.Width = 0;
                lblTitulo.Visible = false;
            }
        }

        private void colocarPanel(object formulario, bool tipo, string nombreP)
        {

            if (tipo)
            {
                Form frm = formulario as Form;
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                Panel panel = new Panel();
                panel.Name = "panel_cental";
                panel.Controls.Add(frm);
                panel.Dock = DockStyle.Fill;
                panel.Tag = frm;
                TabPage pagina = new TabPage("Venta " + (conteo + 1));
                pagina.Controls.Add(panel);
                frm.Show();
                control_ventas.TabPages.Add(pagina);
                control_ventas.SelectedTab = pagina;
                conteo++;
            }else
            {
                Form frm = formulario as Form;
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                Panel panel = new Panel();
                panel.Name = "panel_cental";
                panel.Controls.Add(frm);
                panel.Dock = DockStyle.Fill;
                panel.Tag = frm;
                TabPage pagina = new TabPage(nombreP);
                pagina.Controls.Add(panel);
                frm.Show();
                control_ventas.TabPages.Add(pagina);
                control_ventas.SelectedTab = pagina;
            }
            
            
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            colocarPanel(new panel.venta(),true, "");
            
            slider();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                TabPage paginaActual = control_ventas.SelectedTab;
                if (MessageBox.Show("¿Esta seguro que quiere eliminar la " + paginaActual.Text + "?, Tenga en cuenta que \nPERDERA todos articulos que haya includo en ella.", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    control_ventas.TabPages.Remove(paginaActual);
                    conteo--;
                    slider();
                }
            }
            catch
            {

            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            colocarPanel(new panel.ventas_diarias(), false, "Venta Diaria");
            slider();
        }

        private void control_ventas_ControlAdded(object sender, ControlEventArgs e)
        {
            this.SelectNextControl((Control)sender, true, true, true, true);
        }

        private void control_ventas_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            colocarPanel(new panel.anulacion_de_ventas(), false, "Anulacion de venta");
            slider();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            colocarPanel(new panel.catalogo_de_precios(), false, "Catalogo de precios");
            slider();
        }
    }
}
