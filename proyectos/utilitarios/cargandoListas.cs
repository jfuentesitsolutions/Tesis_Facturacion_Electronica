using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace utilitarios
{
    public class cargandoListas
    {
        public static void cargarLista(DataTable datos, ComboBox lista, string display, string valor)
        {
            lista.DataSource = datos;
            lista.DisplayMember = display;
            lista.ValueMember = valor;
            lista.SelectedValue = "0";
        }

        
    public static void cargarTexbox(DataTable datos, TextBox lista)
    {
            DataTable dato = datos;

            foreach (DataRow fila in dato.Rows)
            {
                lista.AutoCompleteCustomSource.Add(fila[2].ToString());
            }
        }

    public static void establecerValor(ComboBox lista, string valor)
        {
            lista.SelectedValue = valor;
        }

        public static void generarListasGenero(ComboBox l)
        {
            List<string> lista = new List<string>();
            lista.Add("Elija un genero");
            lista.Add("Femenino");
            lista.Add("Masculino");
            l.DataSource = lista;
            l.SelectedIndex = 0;
        }
    }
}
