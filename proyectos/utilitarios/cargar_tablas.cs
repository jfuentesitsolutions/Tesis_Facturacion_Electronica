using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace utilitarios
{
    public class cargar_tablas
    {
        BindingSource _contenidoTabla= new BindingSource();
        DataGridView tabla;
        TextBox busqueda;
        DataTable tablaDatos;
        Label registros;
        private String campoAfiltrar;

        public string CampoAfiltrar
        {
            get
            {
                return campoAfiltrar;
            }

            set
            {
                campoAfiltrar = value;
            }
        }

        public DataTable TablaDatos
        {
            get
            {
                return tablaDatos;
            }

            set
            {
                tablaDatos = value;
            }
        }

        public BindingSource ContenidoTabla
        {
            get
            {
                return _contenidoTabla;
            }

            set
            {
                _contenidoTabla = value;
            }
        }

        public TextBox Busqueda
        {
            get
            {
                return busqueda;
            }

            set
            {
                busqueda = value;
            }
        }

        public cargar_tablas(DataGridView tabla, TextBox busqueda, DataTable tablaDatos, String campobusqueda, Label reg)
        {
            this.tabla = tabla;
            this.Busqueda = busqueda;
            this.TablaDatos = tablaDatos;
            this.CampoAfiltrar = campobusqueda;
            this.registros = reg;
        }

        public cargar_tablas(DataGridView tabla, TextBox busqueda, DataTable tablaDatos, String campobusqueda)
        {
            this.tabla = tabla;
            this.Busqueda = busqueda;
            this.TablaDatos = tablaDatos;
            this.CampoAfiltrar = campobusqueda;
        }

        public void FiltrarLocalmente()
        {
            if (Busqueda.TextLength == 0)
            {
                ContenidoTabla.RemoveFilter();
            }
            else
            {
                string buscar = CampoAfiltrar + " LIKE '%" + Busqueda.Text + "%'";
                ContenidoTabla.Filter = buscar;
            }
            tabla.AutoGenerateColumns = false;
            tabla.DataSource = ContenidoTabla;
            registros.Text = tabla.Rows.Count.ToString() + " registros encontrados";
        }

        public void FiltrarLocalmentePersonalizado(string camp)
        {
            if (Busqueda.TextLength == 0)
            {
                ContenidoTabla.RemoveFilter();
            }
            else
            {
                string buscar = camp + " LIKE '%" + Busqueda.Text + "%'";
                ContenidoTabla.Filter = buscar;
            }
            tabla.AutoGenerateColumns = false;
            tabla.DataSource = ContenidoTabla;
            registros.Text = tabla.Rows.Count.ToString() + " registros encontrados";
        }

        public void FiltrarLocalmenteSinContadorRegistros()
        {
            if (Busqueda.TextLength == 0)
            {
                ContenidoTabla.RemoveFilter();
            }
            else
            {
                string buscar = CampoAfiltrar + " LIKE '%" + Busqueda.Text + "%'";
                ContenidoTabla.Filter = buscar;
            }
            tabla.AutoGenerateColumns = false;
            tabla.DataSource = ContenidoTabla;

           
        }

        public void cargar()
        {
            try
            {
                ContenidoTabla.DataSource = TablaDatos;
                FiltrarLocalmente();
            }
            catch
            {

            }
        }

        public void cargarPersonalizado(string cam)
        {
            try
            {
                ContenidoTabla.DataSource = TablaDatos;
                FiltrarLocalmentePersonalizado(cam);

            }
            catch
            {

            }
        }

        public void cargarSinContadorRegistros()
        {
            try
            {
                ContenidoTabla.DataSource = TablaDatos;
                FiltrarLocalmenteSinContadorRegistros();
            }
            catch
            {

            }
        }

        public void mostrar()
        {
            foreach (DataRow row in tablaDatos.Rows)
            {
                foreach (DataColumn column in tablaDatos.Columns)
                {
                    Console.WriteLine(row[column]);
                }
            }
        }

        public static void correlativoTabla(DataGridView tabla)
        {
            int conteo = 1;
            if (tabla.Rows.Count != 0)
            {
                foreach (DataGridViewRow fila in tabla.Rows)
                {
                    fila.Cells[0].Value = conteo.ToString();
                    conteo++;
                }
            }
            
        }
    }
}
