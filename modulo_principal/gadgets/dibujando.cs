using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace gadgets
{
    public class dibujando
    {
        Pen lapiz=new Pen(Color.FromArgb(54, 60, 71));
        PaintEventArgs evento;
        

        public dibujando(Pen l, PaintEventArgs ev)
        {
            this.lapiz = l;
            this.evento = ev;

        }

        public dibujando()
        {

        }

        public dibujando(PaintEventArgs ev)
        { 
            this.evento = ev;
            
        }

        public void dibujarLineaHorizonta(TextBox texto)
        {
            int xx = texto.Location.X;
            int yy = texto.Location.Y + texto.Height + 1;

            int x = texto.Location.X + texto.Width + 1;
            int y = texto.Location.Y + texto.Height + 1;

            evento.Graphics.DrawLine(lapiz, new Point(xx, yy), new Point(x, y));

        }

        public void dibujarLineaYexpandir(TextBox texto)
        {
            texto.Height = 91;
            texto.Width = 284;

            int xx = texto.Location.X + texto.Width + 1;
            int yy = texto.Location.Y;

            int y = texto.Location.Y + texto.Height + 1;
            int x = texto.Location.X + texto.Width + 1;

            evento.Graphics.DrawLine(lapiz, new Point(xx, yy), new Point(x, y));
        }

       

    }
}
