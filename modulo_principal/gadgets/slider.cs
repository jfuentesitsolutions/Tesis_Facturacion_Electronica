using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gadgets
{
    public class slider
    {
        Panel des;
        PictureBox imagen, fleA, fleAb;
        public slider(Panel p, PictureBox i, PictureBox ar, PictureBox ab)
        {
            des = p;
            imagen = i;
            fleA = ar;
            fleAb = ab;
        }

        public void despliegue()
        {
            if (des.Dock == DockStyle.Fill)
            {
                des.Dock = DockStyle.Bottom;
                fleA.Visible = true;
                fleAb.Visible = false;
                imagen.Visible = true;
            }
            else
            {
                des.Dock = DockStyle.Fill;
                fleA.Visible = false;
                fleAb.Visible = true;
                imagen.Visible = false;

            }

        }
    }
}
