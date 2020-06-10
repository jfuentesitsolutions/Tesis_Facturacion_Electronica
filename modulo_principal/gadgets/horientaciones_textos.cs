using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace gadgets
{
    public static class horientaciones_textos
    {

        public static void colocarTitulo(Panel p, Label t)
        {
            int posicion = (p.Width / 2) - (t.Width / 2);
            Point punto = new Point(posicion, 13);
            t.Location = punto;
        }
    }
}
