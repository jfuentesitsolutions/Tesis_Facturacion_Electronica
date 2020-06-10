using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace control_principal
{
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
        }

        private void splash_Load(object sender, EventArgs e)
        {
            cronometro.Start();
        }

        private void cronometro_Tick(object sender, EventArgs e)
        {
            cronometro.Stop();
            this.Close();
        }

     
    }
}
