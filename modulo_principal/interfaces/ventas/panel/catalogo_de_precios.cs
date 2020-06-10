using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelViewer;

namespace interfaces.ventas.panel
{
    public partial class catalogo_de_precios : Form
    {
       
        public catalogo_de_precios()
        {    
            InitializeComponent(); 
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            quitarPestaña();
        }

        private void quitarPestaña()
        {
            Panel pan = (Panel)this.Parent;
            TabPage pagi = (TabPage)pan.Parent;
            TabControl con = (TabControl)pagi.Parent;

            try
            {
                if (con.TabPages.Count > 1)
                {
                    con.TabPages.Remove(con.SelectedTab);
                }

            }
            catch
            {

            }

        }

        

        private void catalogo_de_precios_Load(object sender, EventArgs e)
        {
            excelViewer1.OpenFile(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Google Drive (vfjhovanyitsolutions@gmail.com)\COSTOS Y UTILIDADES\TIENDA JOSE GERARDO\CUADRO DE UTILIDADES JG 2018.xlsx");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            quitarPestaña();
        }

        
    }
}
