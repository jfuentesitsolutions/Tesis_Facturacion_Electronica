using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace utilitarios
{
    public class manejandoCadenas
    {
        public static string[] cortarPalabras(string oracion)
        {
            Char delimiter = ' ';
            String[] palabras = oracion.Split(delimiter);

            return palabras;
        }
    }
}
