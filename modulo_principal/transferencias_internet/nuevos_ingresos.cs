using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace transferencias_internet
{
    public class nuevos_ingresos
    {
        
        private void crearArchivo(string sentencia, string tipo, int sucur)
        {
            string path = rutas_sucursales(sucur) + tipo + ".txt";
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(sentencia);
                }
            }else
            {
                using (StreamWriter w = File.AppendText(path))
                {
                    w.WriteLine(sentencia);
                }
            }
        }

        public void borrarArchivo(string archivo, int sucursal)
        {
            string path =  rutas_sucursales(sucursal) + archivo + ".txt";
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }

        public static string rutas_sucursales(int Nsucursal)
        {
            string ruta = "";

            switch (Nsucursal)
            {
                case 1:
                    {
                        ruta= Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Google Drive (vfjhovanyitsolutions@gmail.com)\Sucursales\Juayua_1\nuevos_registros\";
                        break;
                    }
                case 2:
                    {
                        ruta = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Google Drive (vfjhovanyitsolutions@gmail.com)\Sucursales\Juayua_2\nuevos_registros\";
                        break;
                    }
                case 3:
                    {
                        ruta = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Google Drive (vfjhovanyitsolutions@gmail.com)\Sucursales\Salcoatitan\nuevos_registros\";
                        break;
                    }
                case 4:
                    {
                        ruta = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Google Drive (vfjhovanyitsolutions@gmail.com)\Sucursales\Juayua_3\nuevos_registros\";
                        break;
                    }
                case 5:
                    {
                        ruta = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Google Drive (vfjhovanyitsolutions@gmail.com)\Sucursales\La majada\nuevos_registros\";
                        break;
                    }
            }

            return ruta;
        }

        public List<string> guardarArchivos(int suc, string nombreArchivo)
        {
            List<string> rutas = new List<string>();
            switch (suc)
            {
                case 1:
                    {
                        rutas.Add(rutas_sucursales(2) + nombreArchivo);
                        rutas.Add(rutas_sucursales(3) + nombreArchivo);
                        rutas.Add(rutas_sucursales(4) + nombreArchivo);
                        rutas.Add(rutas_sucursales(5) + nombreArchivo);
                        break;
                    }
                case 2:
                    {
                        rutas.Add(rutas_sucursales(1) + nombreArchivo);
                        rutas.Add(rutas_sucursales(3) + nombreArchivo);
                        rutas.Add(rutas_sucursales(4) + nombreArchivo);
                        rutas.Add(rutas_sucursales(5) + nombreArchivo);
                        break;
                    }
                case 3:
                    {
                        rutas.Add(rutas_sucursales(2) + nombreArchivo);
                        rutas.Add(rutas_sucursales(1) + nombreArchivo);
                        rutas.Add(rutas_sucursales(4) + nombreArchivo);
                        rutas.Add(rutas_sucursales(5) + nombreArchivo);
                        break;
                    }
                case 4:
                    {
                        rutas.Add(rutas_sucursales(2) + nombreArchivo);
                        rutas.Add(rutas_sucursales(3) + nombreArchivo);
                        rutas.Add(rutas_sucursales(1) + nombreArchivo);
                        rutas.Add(rutas_sucursales(5) + nombreArchivo);
                        break;
                    }
                case 5:
                    {
                        rutas.Add(rutas_sucursales(2) + nombreArchivo);
                        rutas.Add(rutas_sucursales(3) + nombreArchivo);
                        rutas.Add(rutas_sucursales(4) + nombreArchivo);
                        rutas.Add(rutas_sucursales(1) + nombreArchivo);
                        break;
                    }
            }

            return rutas;
        }

        private bool existencia_archivo(string ruta)
        {
            bool existe = false;
            if (File.Exists(ruta))
            {
                existe = true;
            }

            return existe;
        }

    }
}
