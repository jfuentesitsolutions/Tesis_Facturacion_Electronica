using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace utilitarios
{
    public class conectar_excel
    {
        OleDbConnection conector;
        OleDbCommand consulta;
        OleDbDataAdapter adaptador;
        public bool conectar()
        {
            try
            {
                string conexion = "Provider = Microsoft.Jet.OleDb.4.0;Data Source = C:/Users/Fuentes/Google Drive (vfjhovanyitsolutions@gmail.com)/COSTOS Y UTILIDADES/TIENDA JOSE GERARDO/CUADRO DE UTILIDADES JG 2018.xlsx;Extended Properties = \"Excel 8.0;HDR= NO\"";
                conector = default(OleDbConnection);
                conector = new OleDbConnection(conexion);
                conector.Open();

                return true;

            }
            catch
            {
                return false;
            }
        }

        public DataSet datos()
        {
            DataSet dat = new DataSet();
            if (conectar())
            {
                consulta = default(OleDbCommand);
                consulta = new OleDbCommand("select F2,F3,F4,F5,F6,F7,F8,F9,F10,F11 from [unilv nestle fabril KC cereales$]", conector);
                adaptador = new OleDbDataAdapter();
                adaptador.SelectCommand = consulta;

                adaptador.Fill(dat);

                return dat;
            }else
            {
                dat = null;
                return dat;
            }
        }

    }
}
