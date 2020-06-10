using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulosfacturaElectronica.ClasesValidacion
{
    public class OperacionDB : conexiones_BD.Conexion
    {

        DataTable Datosregistros = new DataTable();

        #region Metodos de ejecucion de consultas y sentencias SQL

        private List<string> EjecutarConsulta(string _consulta)
        {

            List<string> Lista_Rutas = new List<string>();

            Datosregistros = datosTablaRutaRchivos(_consulta);

            foreach (DataRow item in Datosregistros.Rows)
            {
                var a = item[1].ToString();
                Lista_Rutas.Add(item[1].ToString());// <-- lleno la lista solo con los rutas de la tabla (rutas_archivos_recientes) 
            }

            if (Lista_Rutas.Equals(null)) {

                return null;
            }

            return Lista_Rutas;
        }


        private Int32 Ejecutarsentencia(string sentencia)
        {
            Int32 numeroFilas = 0;

            if (base.conectar())
            {
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = base.Conec;
                comando.CommandText = sentencia;
                try
                {
                    numeroFilas = comando.ExecuteNonQuery();
                }
                catch
                {
                    numeroFilas = 0;
                }
            }

            return numeroFilas;
        }

        //obtenemos los datos de la tabla (rutas_archivos_recientes) de la DB
        private static DataTable datosTablaRutaRchivos(string _Consulta)
        {
            DataTable Datos = new DataTable();
            String Consulta = _Consulta;
            conexiones_BD.operaciones oOperacion = new conexiones_BD.operaciones();
            try
            {
                Datos = oOperacion.Consultar(Consulta);
            }
            catch
            {
                Datos = new DataTable();
            }

            return Datos;
        }

        #endregion


        #region Metodos para la gestion de las rutas de archivos XML

        public List<string> ConsultarRutasDearchivosXML() {
            return EjecutarConsulta("select * from rutas_archivos_xml order by id desc;");//<-- le enviamos la consulta sql para obtener las rutas guardadas de la base de datos
        }

        //metodo que verifica que el archivo no este repetido en la base de datos y si lo esta lo reemplazamos con el nuevo
        private bool EliminarArchivoRepetido(string _ruta) {
  
            foreach (var item in ObtenerListaNombresXML())
            {
                if (_ruta.Contains(item))
                {
                    int id = 0;

                    foreach (DataRow item2 in Datosregistros.Rows)
                    {
                        if (item2[1].ToString().Contains(item))
                        {
                            id = Int32.Parse(item2[0].ToString());
                        }
                    }

                    string DeletRepet = "delete from rutas_archivos_xml where id = " + id + ";"; //<-- elimina el archivo repetido

                    if (Ejecutarsentencia(DeletRepet) > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;

                    }
                    break;
                }

            }
            return true;
        }

        public bool ActualizarTablaRutaArchivosXML(string _ruta) {

           
                List<string> registrosRuta = new List<string>();
                registrosRuta = ConsultarRutasDearchivosXML();

                int CantReg = registrosRuta.Count; //devuelve la cantidad de registros de la tabla (rutas_archivos_recientes)

                //verifico que la ruta que seleecione ya esta guardada en la BD 
                if (!registrosRuta.Contains(_ruta))
                {

                if(!EliminarArchivoRepetido(_ruta)) return false;//<-- verifica que el archivo no se cuentre duplicaod en la case de datos 

                    if (CantReg == 5)
                    {

                        string DeleteOldReg = "delete from rutas_archivos_xml limit 1;";
                        string AddNewReg = "insert into rutas_archivos_xml(ruta_xml) value('" + _ruta + "');";
                        string NewReg = AddNewReg.Replace(@"\", @"\\");

                        if (Ejecutarsentencia(DeleteOldReg) > 0)
                        {
                            if (Ejecutarsentencia(NewReg) > 0)
                            {
                                return true; //la insercion de la ruta  se hiso con exito
                            }
                            else
                            {
                                return false; //ocurrio un error en la actualizacion de la tabla 
                            }

                        }
                        else
                        {
                            return false; //ocurrio un error en la actualizacion de la tabla 
                        }

                    }
                    else
                    {
                        string AddNewReg = null;
                        AddNewReg = "insert into rutas_archivos_xml(ruta_xml) value('" + _ruta + "');";
                        string NewReg = AddNewReg.Replace(@"\", @"\\");

                        if (Ejecutarsentencia(NewReg) > 0)
                        {
                            return true; //la insercion de la ruta  se hiso con exito
                        }
                        else
                        {
                            return false; //ocurrio un error en la actualizacion de la tabla 
                        }
                    }
                }
                else
                {
                    return false;
                }
            
          
          
     
        }

        public List<string> ObtenerListaNombresXML()
        {

            List<string> lista = new List<string>();

            foreach (var item in ConsultarRutasDearchivosXML())
            {
                int LogNomArchivo = 0;
                for (int i = item.Length; i > 0; i--)
                {
                    if (item.Substring(i - 1, 1).Equals("\\"))
                    {
                        break;
                    }
                    LogNomArchivo++;
                }

                string nombre1 = item.Substring(item.Length - LogNomArchivo);

                lista.Add(nombre1);
            }
            return lista;
        }

        #endregion


        #region Metodos para la gestion de las rutas de archivos PDF

        public List<string> ConsultarRutasDearchivosPDF()
        {
            return EjecutarConsulta("select * from rutas_archivos_pdf order by id desc;");//<-- le enviamos la consulta sql para obtener las rutas guardadas de la base de datos
        }

        private bool EliminarArchivoRepetidoPDF(string _ruta)
        {

            foreach (var item in ObtenerListaNombresPDF())
            {
                if (_ruta.Contains(item))
                {
                    int id = 0;

                    foreach (DataRow item2 in Datosregistros.Rows)
                    {
                        if (item2[1].ToString().Contains(item))
                        {
                            id = Int32.Parse(item2[0].ToString());
                        }
                    }

                    string DeletRepet = "delete from rutas_archivos_pdf where id = " + id + ";"; //<-- elimina el archivo repetido

                    if (Ejecutarsentencia(DeletRepet) > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;

                    }
                    break;
                }

            }
            return true;
        }

        public bool ActualizarTablaRutaArchivosPDF(string _ruta)
        {


            List<string> registrosRuta = new List<string>();
            registrosRuta = ConsultarRutasDearchivosPDF();

            int CantReg = registrosRuta.Count; //devuelve la cantidad de registros de la tabla (rutas_archivos_recientes)

            //verifico que la ruta que seleecione ya esta guardada en la BD 
            if (!registrosRuta.Contains(_ruta))
            {

                if (!EliminarArchivoRepetidoPDF(_ruta)) return false;//<-- verifica que el archivo no se cuentre duplicaod en la case de datos 

                if (CantReg == 5)
                {

                    string DeleteOldReg = "delete from rutas_archivos_pdf limit 1;";
                    string AddNewReg = "insert into rutas_archivos_pdf(ruta_pdf) value('" + _ruta + "');";
                    string NewReg = AddNewReg.Replace(@"\", @"\\");

                    if (Ejecutarsentencia(DeleteOldReg) > 0)
                    {
                        if (Ejecutarsentencia(NewReg) > 0)
                        {
                            return true; //la insercion de la ruta  se hiso con exito
                        }
                        else
                        {
                            return false; //ocurrio un error en la actualizacion de la tabla 
                        }

                    }
                    else
                    {
                        return false; //ocurrio un error en la actualizacion de la tabla 
                    }

                }
                else
                {
                    string AddNewReg = null;
                    AddNewReg = "insert into rutas_archivos_pdf(ruta_pdf) value('" + _ruta + "');";
                    string NewReg = AddNewReg.Replace(@"\", @"\\");

                    if (Ejecutarsentencia(NewReg) > 0)
                    {
                        return true; //la insercion de la ruta  se hiso con exito
                    }
                    else
                    {
                        return false; //ocurrio un error en la actualizacion de la tabla 
                    }
                }
            }
            else
            {
                return false;
            }

        }

        public List<string> ObtenerListaNombresPDF()
        {

            List<string> lista = new List<string>();

            foreach (var item in ConsultarRutasDearchivosPDF())
            {
                int LogNomArchivo = 0;
                for (int i = item.Length; i > 0; i--)
                {
                    if (item.Substring(i - 1, 1).Equals("\\"))
                    {
                        break;
                    }
                    LogNomArchivo++;
                }

                string nombre1 = item.Substring(item.Length - LogNomArchivo);

                lista.Add(nombre1);
            }
            return lista;
        }

        #endregion


        #region Metodos para la gestion de las rutas de archivos JSON

        public List<string> ConsultarRutasDearchivosJSON()
        {
            return EjecutarConsulta("select * from rutas_archivos_json order by id desc;");//<-- le enviamos la consulta sql para obtener las rutas guardadas de la base de datos
        }

        private bool EliminarArchivoRepetidoJSON(string _ruta)
        {

            foreach (var item in ObtenerListaNombresJSON())
            {
                if (_ruta.Contains(item))
                {
                    int id = 0;

                    foreach (DataRow item2 in Datosregistros.Rows)
                    {
                        if (item2[1].ToString().Contains(item))
                        {
                            id = Int32.Parse(item2[0].ToString());
                        }
                    }

                    string DeletRepet = "delete from rutas_archivos_json where id = " + id + ";"; //<-- elimina el archivo repetido

                    if (Ejecutarsentencia(DeletRepet) > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;

                    }
                    break;
                }

            }
            return true;
        }

        public bool ActualizarTablaRutaArchivosJSON(string _ruta)
        {

            List<string> registrosRuta = new List<string>();
            registrosRuta = ConsultarRutasDearchivosJSON();

            int CantReg = registrosRuta.Count; //devuelve la cantidad de registros de la tabla (rutas_archivos_recientes)

            //verifico que la ruta que seleecione ya esta guardada en la BD 
            if (!registrosRuta.Contains(_ruta))
            {

                if (!EliminarArchivoRepetidoJSON(_ruta)) return false;//<-- verifica que el archivo no se cuentre duplicaod en la case de datos 

                if (CantReg == 5)
                {

                    string DeleteOldReg = "delete from rutas_archivos_json limit 1;";
                    string AddNewReg = "insert into rutas_archivos_json(ruta_json) value('" + _ruta + "');";
                    string NewReg = AddNewReg.Replace(@"\", @"\\");

                    if (Ejecutarsentencia(DeleteOldReg) > 0)
                    {
                        if (Ejecutarsentencia(NewReg) > 0)
                        {
                            return true; //la insercion de la ruta  se hiso con exito
                        }
                        else
                        {
                            return false; //ocurrio un error en la actualizacion de la tabla 
                        }

                    }
                    else
                    {
                        return false; //ocurrio un error en la actualizacion de la tabla 
                    }

                }
                else
                {
                    string AddNewReg = null;
                    AddNewReg = "insert into rutas_archivos_json(ruta_json) value('" + _ruta + "');";
                    string NewReg = AddNewReg.Replace(@"\", @"\\");

                    if (Ejecutarsentencia(NewReg) > 0)
                    {
                        return true; //la insercion de la ruta  se hiso con exito
                    }
                    else
                    {
                        return false; //ocurrio un error en la actualizacion de la tabla 
                    }
                }
            }
            else
            {
                return false;
            }

        }

        public List<string> ObtenerListaNombresJSON()
        {

            List<string> lista = new List<string>();

            foreach (var item in ConsultarRutasDearchivosJSON())
            {
                int LogNomArchivo = 0;
                for (int i = item.Length; i > 0; i--)
                {
                    if (item.Substring(i - 1, 1).Equals("\\"))
                    {
                        break;
                    }
                    LogNomArchivo++;
                }

                string nombre1 = item.Substring(item.Length - LogNomArchivo);

                lista.Add(nombre1);
            }
            return lista;
        }

        #endregion

    }
}
