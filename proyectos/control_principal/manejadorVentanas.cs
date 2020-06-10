using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace control_principal
{
    class manejadorVentanas: ApplicationContext
    {
        public manejadorVentanas()
        {
            if (splash())
            {
                if (login())
                {
                    principal nu = new principal();
                    nu.ShowDialog();
                }
            }
        }

        private Boolean splash()
        {
            Boolean comprobacion = true;
            splash spl = new splash();
            spl.ShowDialog();
            return comprobacion;
        }

        private Boolean login()
        {
            Boolean verificado = false;

            login lo = new login();
            lo.ShowDialog();
            verificado = lo.Autorizado;
            return verificado;
        }

    }
}
