using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace interfaces.control_permisos
{
    public class controlador_de_permisos
    {
        Panel con;
        DataTable datos;
        public controlador_de_permisos(Panel c, DataTable da)
        {
            con = c;
            datos = da;
            AsignarPermisos();
        }

        private void AsignarPermisos()
        {
                foreach (DataRow fila in datos.Rows)
                {
                    ((Panel)con.Controls[fila[0].ToString()]).Visible = true;
                }

        }
    }
}
