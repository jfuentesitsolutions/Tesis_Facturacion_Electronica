using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transferencias_internet
{
    public class log_sentensias
    {
        public static void escribirBinario(string sentencia)
        {
            if (File.Exists("ArchivoBinario.bin"))
            {
                // Crea objeto `FileStream` para referenciar un archivo binario -ArchivoBinario.bin-:
                using (FileStream fs = new FileStream("ArchivoBinario.bin", FileMode.Append))
                {
                    // Escritura sobre el archivo binario `ArchivoBinario.bin` usando un 
                    // objeto de la clase `BinaryWriter`:
                    using (StreamWriter bw = new StreamWriter(fs, Encoding.UTF8))
                    {
                        // Escritura de datos de naturaleza primitiva:
                        bw.WriteLine(sentencia);

                        bw.Close();
                    }
                    fs.Close();
                }
            }
            else
            {
                // Crea objeto `FileStream` para referenciar un archivo binario -ArchivoBinario.bin-:
                using (FileStream fs = new FileStream("ArchivoBinario.bin", FileMode.Create))
                {
                    // Escritura sobre el archivo binario `ArchivoBinario.bin` usando un 
                    // objeto de la clase `BinaryWriter`:
                    using (StreamWriter bw = new StreamWriter(fs, Encoding.UTF8))
                    {
                        // Escritura de datos de naturaleza primitiva:
                        bw.WriteLine(sentencia);


                        bw.Close();
                    }
                    fs.Close();
                }
            }
        }
    }
}
