using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace utilitarios
{
    public class vaciando_formularios
    {
        static List<Control> controles;
        static ErrorProvider error;


        public static void vaciarTexbox(List<Control> con)
        {
            controles = con;
            foreach(Control c in controles)
            {
                c.Text = "";
            }
        }

        public static void habilitandoTexbox(List<Control> con, bool ta)
        {
            controles = con;
            foreach (Control c in controles)
            {
                c.Enabled=ta;
            }
        }

        public static bool validando(List<TextBox> con, ErrorProvider err)
        {

            error = err;
            bool valido = false;

            string mensaje = "No puedes dejar este campos vacio";
            error.Clear();

            foreach(TextBox c in con)
            {
                if (c.TextLength==0)
                {
                    error.SetError(c,mensaje);
                    valido = true;
                    
                }
            }

            return valido;
        }

        public static bool validandoListas(List<ComboBox> con, ErrorProvider err)
        {

            error = err;
            bool valido = false;

            string mensaje = "Tienes que elegir un item";
            foreach (ComboBox c in con)
            {
                if (c.SelectedIndex == -1)
                {
                    error.SetError(c, mensaje);
                    valido = true;
                }
            }

            return valido;
        }


    }
}
