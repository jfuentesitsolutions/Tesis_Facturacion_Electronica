using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Xml;

namespace conexiones_BD.clases.traslados
{
    public class detalle_producto_traslado:entidad
    {
        string idproducto_traslado, idsucursal_producto, cantidad, recibido, idtraslado, 
            correla, cantidad_presentacion, nombre_presentacion, cod_producto, nombre;

        public string Idtraslado
        {
            get
            {
                return idtraslado;
            }

            set
            {
                idtraslado = value;
            }
        }

        public string Idsucursal_producto
        {
            get
            {
                return idsucursal_producto;
            }

            set
            {
                idsucursal_producto = value;
            }
        }

        public string Cantidad
        {
            get
            {
                return cantidad;
            }

            set
            {
                cantidad = value;
            }
        }

        public string Recibido
        {
            get
            {
                return recibido;
            }

            set
            {
                recibido = value;
            }
        }

        public string Correla
        {
            get
            {
                return correla;
            }

            set
            {
                correla = value;
            }
        }

        public string Cantidad_presentacion
        {
            get
            {
                return cantidad_presentacion;
            }

            set
            {
                cantidad_presentacion = value;
            }
        }

        public string Nombre_presentacion
        {
            get
            {
                return nombre_presentacion;
            }

            set
            {
                nombre_presentacion = value;
            }
        }

        public string Cod_producto
        {
            get
            {
                return cod_producto;
            }

            set
            {
                cod_producto = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public detalle_producto_traslado(string idsucursal_producto, string cantidad, string recibido, string idtraslado, string correl, string cantidad_presentacion, string nombre_presentacion, string cod)
        {
            this.Idsucursal_producto = idsucursal_producto;
            this.Cantidad = cantidad;
            this.Recibido = recibido;
            this.Idtraslado = idtraslado;
            this.Correla = correl;
            this.Cantidad_presentacion = cantidad_presentacion;
            this.Nombre_presentacion = nombre_presentacion;
            this.Cod_producto = cod;
            

            base.cargarDatos(generarCampos(), generarValores(), "detalle_productos_traslados");
        }

        public detalle_producto_traslado(string idsucursal_producto, string cantidad, string recibido, string idtraslado, string correl, string cantidad_presentacion, string nombre_presentacion, string cod, string nombre)
        {
            this.Idsucursal_producto = idsucursal_producto;
            this.Cantidad = cantidad;
            this.Recibido = recibido;
            this.Idtraslado = idtraslado;
            this.Correla = correl;
            this.Cantidad_presentacion = cantidad_presentacion;
            this.Nombre_presentacion = nombre_presentacion;
            this.Cod_producto = cod;
            this.nombre = nombre;


            base.cargarDatos(generarCampos(), generarValores(), "detalle_productos_traslados");
        }

        public override List<string> generarCampos()
        {
            List<string> campos = new List<string>();
            campos.Add("idsucursal_producto");
            campos.Add("cantidad");
            campos.Add("recibido");
            campos.Add("idtraslado");
            campos.Add("cantidad_presentacion");
            campos.Add("nombre_presentacion");
            campos.Add("cod_producto");

            return campos;
        }

        public override List<string> generarValores()
        {
            List<string> valores = new List<string>();
            valores.Add(Idsucursal_producto);
            valores.Add(Cantidad);
            valores.Add(Recibido);
            valores.Add(Idtraslado);
            valores.Add(Cantidad_presentacion);
            valores.Add(Nombre_presentacion);
            valores.Add(Cod_producto);

            return valores;
        }

        public XmlNode detalleTraslados(XmlDocument raiz)
        {
            XmlNode traslado = raiz.CreateElement("detalle_traslado");

            XmlElement e1 = raiz.CreateElement("idsucursal_producto");
            e1.InnerText = Idsucursal_producto;
            traslado.AppendChild(e1);

            XmlElement e2 = raiz.CreateElement("cantidad");
            e2.InnerText = Cantidad;
            traslado.AppendChild(e2);

            XmlElement e3 = raiz.CreateElement("recibido");
            e3.InnerText = Recibido;
            traslado.AppendChild(e3);

            XmlElement e4 = raiz.CreateElement("idtraslado");
            e4.InnerText = Idtraslado;
            traslado.AppendChild(e4);

            XmlElement e5 = raiz.CreateElement("correlativos_traslados");
            e5.InnerText = Correla;
            traslado.AppendChild(e5);

            XmlElement e6 = raiz.CreateElement("cantidad_presentacion");
            e6.InnerText = Cantidad_presentacion;
            traslado.AppendChild(e6);

            XmlElement e7 = raiz.CreateElement("nombre_presentacion");
            e7.InnerText = Nombre_presentacion;
            traslado.AppendChild(e7);

            XmlElement e8 = raiz.CreateElement("codigo_productos");
            e8.InnerText = Cod_producto;
            traslado.AppendChild(e8);

            XmlElement e9 = raiz.CreateElement("nombre");
            e9.InnerText = nombre;
            traslado.AppendChild(e9);

            return traslado;
        }

        public string ingresaTraslado()
        {
            base.cargarDatos(generarCampos(), generarValores(), "detalle_productos_traslados");
            return sentenciaIngresar();
        }

    }
}
