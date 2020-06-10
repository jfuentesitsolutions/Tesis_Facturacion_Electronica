using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace control_principal.ModulosFacturaElectronica
{
    public partial class Visor_PDF : Form
    {

        public Visor_PDF(string _RutaPDF)
        {
            InitializeComponent();
            VisorDel_PDF.src = _RutaPDF;
        }
    }
}
