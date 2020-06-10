using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;


namespace gadgets
{
    public class tablas
    {
        BindingSource _datosTabla;
        DataGridView tabla;
        TextBox busqueda;

        public tablas(DataGridView t)
        {
            this.tabla = t;
            _datosTabla = new BindingSource();
        }

        public void generarTabla(string campo_buscar, TextBox b, DataTable datos)
        {
            try
            {
                _datosTabla.DataSource = datos;
                filtrando(campo_buscar, b);
            }
            catch
            {

            }
        }

        public void filtrando(string campo_buscar, TextBox b)
        {
            this.busqueda = b;

            if (busqueda.TextLength == 0)
            {
                _datosTabla.RemoveFilter();
            }
            else
            {
                _datosTabla.Filter = campo_buscar+" LIKE '%" + busqueda.Text + "%'";
            }
            tabla.AutoGenerateColumns = false;
            tabla.DataSource = _datosTabla;
        }


    }
}
