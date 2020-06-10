using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conexiones_BD.clases.ctrl_errores
{
    public class errores
    {
        Int32 res;
        String error;

        public int Res
        {
            get
            {
                return res;
            }

            set
            {
                res = value;
            }
        }

        public string Error
        {
            get
            {
                return error;
            }

            set
            {
                error = value;
            }
        }
    }
}
