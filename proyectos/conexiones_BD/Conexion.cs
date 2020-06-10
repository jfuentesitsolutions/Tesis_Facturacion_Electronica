using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.IO;
using Microsoft.Win32;

namespace conexiones_BD
{
    public class Conexion
    {
        private MySqlConnection conec;
        string server, dbase, usu, contra;
        protected MySqlConnection Conec
        {
            get
            {
                return conec;
            }

            set
            {
                conec = value;
            }
        }

        public Boolean conectar()
        {
            cargarDatosRegistro();
            Boolean conectado = false;
            String cadena = "Server="+server+";Port=3306;Database="+dbase+";Uid="+usu+";Pwd="+contra+";";
            Conec = new MySqlConnection();
            Conec.ConnectionString = cadena;

            try
            {
                Conec.Open();
                conectado = true;
            }
            catch
            {
                conectado = false;
            }

            return conectado;
        }

        public void desconectar()
        {
            try
            {
                if (Conec.State == System.Data.ConnectionState.Open)
                {
                    Conec.Close();
                }
            }
            catch
            {

            }

        }

        protected String obtenerIpservidor()
        {
            return Conec.DataSource.ToString();
        }

        public Boolean conectarInstantanea(string s, string db, string u, string con)
        {
            Boolean conectado = false;
            String cadena = "Server=" + s + ";Port=3306;Database=" + db + ";Uid=" + u + ";Pwd="+con+";";
            Conec = new MySqlConnection();
            Conec.ConnectionString = cadena;

            try
            {
                Conec.Open();
                conectado = true;
            }
            catch
            {
                conectado = false;
            }

            return conectado;
        }

        private void cargarDatosRegistro()
        {
            server = (string)Registry.GetValue("HKEY_CURRENT_USER\\PuntoVentaGerardo\\configura", "ipservidor", "NE");
            dbase = (string)Registry.GetValue("HKEY_CURRENT_USER\\PuntoVentaGerardo\\configura", "nombre_db", "NE");
            usu = (string)Registry.GetValue("HKEY_CURRENT_USER\\PuntoVentaGerardo\\configura", "usuario", "NE");
            contra = (string)Registry.GetValue("HKEY_CURRENT_USER\\PuntoVentaGerardo\\configura", "$$", "NE");
        }

        public bool exportar(String ruta)
        {
            cargarDatosRegistro();
            string constring = "server="+ server + ";user="+ usu + ";pwd="+ contra + ";database="+ dbase + ";";
            string file = ruta;
            using (MySqlConnection conn = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        try
                        {
                            cmd.Connection = conn;
                            conn.Open();
                            mb.ExportToFile(file);
                            mb.ImportInfo.DatabaseDefaultCharSet = "latin1";
                            conn.Close();
                            return true;
                        }
                        catch
                        {
                            return false;
                        }
                        
                    }
                }
            }
        }

        public bool importar(String ruta)
        {
            cargarDatosRegistro();
            string constring = "server=" + server + ";user=" + usu + ";pwd=" + contra + ";database=" + dbase + ";";
            string file = ruta;
            using (MySqlConnection conn = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        try
                        {
                            cmd.Connection = conn;
                            conn.Open();
                            mb.ImportFromFile(file);
                            conn.Close();
                            return true;
                        }
                        catch
                        {
                            return false;
                        }
                        
                    }
                }
            }
        }

        }
    }
