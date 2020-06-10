using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Xml;

namespace conexiones_BD.clases.traslados
{
    public class traslado:entidad
    {
        string idtraslado, idsucursal_envio, idsucursal_llegada, observaciones, fecha_envio, fecha_recepcion, 
            validada, correlativos_traslados;

        public traslado(string idsucursal_envio, string idsucursal_llegada, string observaciones, string fecha_envio, 
            string fecha_recepcion, string validada, string correlativos_traslados)
        {
            this.idsucursal_envio = idsucursal_envio;
            this.idsucursal_llegada = idsucursal_llegada;
            this.observaciones = observaciones;
            this.fecha_envio = fecha_envio;
            this.fecha_recepcion = fecha_recepcion;
            this.validada = validada;
            this.correlativos_traslados = correlativos_traslados;
            base.cargarDatos(generarCampos(), generarValores(), "traslados");
        }

        public override List<string> generarCampos()
        {
            List<string> campos = new List<string>();
            campos.Add("idsucursal_envio");
            campos.Add("idsucursal_llegada");
            campos.Add("observaciones");
            campos.Add("fecha_envio");
            campos.Add("fecha_recepcion");
            campos.Add("validada");
            campos.Add("correlativos_traslados");

            return campos;
        }

        public override List<string> generarValores()
        {
            List<string> valores = new List<string>();
            valores.Add(idsucursal_envio);
            valores.Add(idsucursal_llegada);
            valores.Add(observaciones);
            valores.Add(fecha_envio);
            valores.Add(fecha_recepcion);
            valores.Add(validada);
            valores.Add(correlativos_traslados);
            return valores;
        }

        public XmlNode crearTraslado(XmlDocument raiz)
        {
            XmlNode traslado = raiz.CreateElement("traslado");

            XmlElement e1 = raiz.CreateElement("idsucursal_envio");
            e1.InnerText = idsucursal_envio;
            traslado.AppendChild(e1);

            XmlElement e2 = raiz.CreateElement("idsucursal_llegada");
            e2.InnerText = idsucursal_llegada;
            traslado.AppendChild(e2);

            XmlElement e3 = raiz.CreateElement("observaciones");
            e3.InnerText = observaciones;
            traslado.AppendChild(e3);

            XmlElement e4 = raiz.CreateElement("fecha_envio");
            e4.InnerText = fecha_envio;
            traslado.AppendChild(e4);

            XmlElement e5 = raiz.CreateElement("fecha_recepcion");
            e5.InnerText = fecha_recepcion;
            traslado.AppendChild(e5);

            XmlElement e6 = raiz.CreateElement("validada");
            e6.InnerText = validada;
            traslado.AppendChild(e6);

            XmlElement e7 = raiz.CreateElement("correlativos_traslados");
            e7.InnerText = correlativos_traslados;
            traslado.AppendChild(e7);

            return traslado;
        }

        public static DataTable datosTabla(string idsucursal)
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = "select * from correlativos_traslados where idsucursal='" + idsucursal + "' and activos=1;";
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

        public static bool actualizaCorrelativos(string numerosiguiente, string id)
        {
            bool actualizado = false;
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("UPDATE correlativos_traslados set ");
            sentencia.Append("numero_siguiente='" + numerosiguiente + "',");
            sentencia.Append("fecha_ultimo=now() ");
            sentencia.Append("WHERE idcorrelativo_traslado='" + id + "';");
            operaciones op = new operaciones();

            if (op.actualizar(sentencia.ToString()) > 0)
            {
                actualizado = true;
            }

            return actualizado;
        }

        public static DataTable datosTablaCorrelativo()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"select ct.idcorrelativo_traslado as idc, s.numero_de_sucursal as nus, ct.numero_siguiente as ns, ct.final as f, ct.activos as act
                            from correlativos_traslados ct, sucursales s
                            where ct.idsucursal=s.idsucursal
                            ;";
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

        public static DataTable exitsenciaCorrelativo(string corre)
        {
            
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"select t.idtraslado
                        from traslados t
                        where t.correlativos_traslados='"+corre+@"'
                        ;
                        ";
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

    }
}
