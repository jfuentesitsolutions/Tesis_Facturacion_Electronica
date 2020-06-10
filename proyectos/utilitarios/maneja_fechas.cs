using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace utilitarios
{
    public class maneja_fechas
    {

        public string fechaMysql(DateTimePicker dp)
        {
            DateTime fecha = Convert.ToDateTime(dp.Text.ToString());

            string formto = fecha.ToString("yyyy-MM-dd HH:mm:ss");

            return formto;
        }

        public string fechaCortaMysql(DateTimePicker dp)
        {
            DateTime fecha = Convert.ToDateTime(dp.Value.ToShortDateString());
            string formto = fecha.ToString("yyyy-MM-dd");

            return formto;
        }

        public string fechaMy(string fech)
        {
            DateTime fecha = Convert.ToDateTime(fech);

            string formto = fecha.ToString("yyyy-MM-dd HH:mm:ss");

            return formto;
        }
    }
}
