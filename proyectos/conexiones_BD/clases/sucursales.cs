using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Xml;

namespace conexiones_BD.clases
{
    public class sucursales:entidad
    {
        string idsucursal, numero_de_sucursal, direccion, telefono, encargado;

        public sucursales(string idsucursal, string numero_de_sucursal, string direccion, string telefono, string idencargado)
        {
            this.idsucursal = idsucursal;
            this.numero_de_sucursal = numero_de_sucursal;
            this.direccion = direccion;
            this.telefono = telefono;
            this.encargado = idencargado;
            base.cargarDatosModificados(generarCampos(), generarValores(), "sucursales", idsucursal, "idsucursal");
        }

        public sucursales(string numero_de_sucursal, string direccion, string telefono, string idencargado)
        {
            this.numero_de_sucursal = numero_de_sucursal;
            this.direccion = direccion;
            this.telefono = telefono;
            this.encargado = idencargado;
            base.cargarDatos(generarCampos(), generarValores(), "sucursales");
        }

        public sucursales(string idsucursal)
        {
            this.idsucursal = idsucursal;
            base.cargarDatosEliminados("sucursales", idsucursal, "idsucursal");
        }

        public sucursales(List<string> c, List<string> v)
        {
            base.busquedaDatos(c, v, "sucursales");
        }

        public override List<string> generarCampos()
        {
            List<string> campos = new List<string>();
            campos.Add("numero_de_sucursal");
            campos.Add("direccion");
            campos.Add("telefono");
            campos.Add("encargado");
            return campos;
        }

        public override List<string> generarValores()
        {
            List<string> valores = new List<string>();
            valores.Add(numero_de_sucursal);
            valores.Add(direccion);
            valores.Add(telefono);
            valores.Add(encargado);

            return valores;
        }

        public static DataTable datosTabla()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"select * from sucursales;";
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

        public XmlNode crearSucursal(XmlDocument raiz)
        {
            XmlNode sucursal = raiz.CreateElement("sucursal");

            XmlElement e1 = raiz.CreateElement("numero_de_sucursal");
            e1.InnerText = numero_de_sucursal;
            sucursal.AppendChild(e1);

            XmlElement e2 = raiz.CreateElement("direccion");
            e2.InnerText = direccion;
            sucursal.AppendChild(e2);

            XmlElement e3 = raiz.CreateElement("telefono");
            e3.InnerText = telefono;
            sucursal.AppendChild(e3);

            XmlElement e4 = raiz.CreateElement("encargado");
            e4.InnerText = encargado;
            sucursal.AppendChild(e4);

            return sucursal;
        }
    }
}
