using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulosfacturaElectronica.ClasesValidacion
{
    public class Codificar : StringWriter
    {
        private readonly Encoding enco;
        public override Encoding Encoding
        {
            get
            {
                return this.enco;
            }
        }
        public Codificar(Encoding en) : base()
        {
            this.enco = en;
        }

    }
}
