using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace gadgets
{
    public class movimimientos
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hand, int msg, int wparam, int lparam);

        public movimimientos()
        {

        }

        public void moverFormulario(Object sender,MouseEventArgs e, Form formu)
        {
            ReleaseCapture();
            SendMessage(formu.Handle, 0x112, 0xf012, 0);
        }
    }
}
