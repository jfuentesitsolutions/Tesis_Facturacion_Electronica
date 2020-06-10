using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace conexiones_BD.clases
{
    public class clientes : entidad
    {
        string idcliente, cod_cliente, nombre_cliente, apellidos_cliente, direccion, dui, nit, ncr, razon_social, telefono, correo, iddescuento, fecha_ingreso, genero, estado;

        public string Cod_cliente
        {
            get
            {
                return cod_cliente;
            }

            set
            {
                cod_cliente = value;
            }
        }

        public string Nombre_cliente
        {
            get
            {
                return nombre_cliente;
            }

            set
            {
                nombre_cliente = value;
            }
        }

        public clientes(string idcliente, string cod_cliente, string nombre_cliente, string apellidos_cliente, string direccion, 
            string dui, string nit, string ncr, string razon_social, string telefono, string correo, string iddescuento, string fecha_ingreso, string genero, string est)
        {
            this.idcliente = idcliente;
            this.Cod_cliente = cod_cliente;
            this.Nombre_cliente = nombre_cliente;
            this.apellidos_cliente = apellidos_cliente;
            this.direccion = direccion;
            this.dui = dui;
            this.nit = nit;
            this.ncr = ncr;
            this.razon_social = razon_social;
            this.telefono = telefono;
            this.correo = correo;
            this.iddescuento = iddescuento;
            this.fecha_ingreso = fecha_ingreso;
            this.genero = genero;
            this.estado = est;
            base.cargarDatosModificados(generarCampos(), generarValores(), "clientes", idcliente, "idcliente");
        }

        public clientes(string id, string nombres, string apellidos, string direcc, string gen, string est)
        {
            idcliente = id;
            Nombre_cliente = nombres;
            apellidos_cliente = apellidos;
            direccion = direcc;
            genero = gen;
            estado = est;
        
        }

        public clientes(string cod_cliente, string nombre_cliente,
            string apellidos_cliente, string direccion, string dui, string nit,
            string ncr, string razon_social, string telefono, string correo,
            string iddescuento, string fecha_ingreso, string genero, string est)
        {
            this.Cod_cliente = cod_cliente;
            this.Nombre_cliente = nombre_cliente;
            this.apellidos_cliente = apellidos_cliente;
            this.direccion = direccion;
            this.dui = dui;
            this.nit = nit;
            this.ncr = ncr;
            this.razon_social = razon_social;
            this.telefono = telefono;
            this.correo = correo;
            this.iddescuento = iddescuento;
            this.fecha_ingreso = fecha_ingreso;
            this.genero = genero;
            this.estado = est;
            base.cargarDatos(generarCampos(), generarValores(), "clientes");
        }

        public clientes(string idcliente)
        {
            this.idcliente = idcliente;
            base.cargarDatosEliminados("clientes", idcliente, "idcliente");
        }

        public clientes(List<string> campos, List<string> valores)
        {
            base.busquedaDatos(campos, valores, "clientes");
        }

        public override List<string> generarCampos()
        {
            List<string> campos = new List<string>();
            campos.Add("cod_cliente");
            campos.Add("nombre_cliente");
            campos.Add("apellidos_cliente");
            campos.Add("direccion");
            campos.Add("dui");
            campos.Add("nit");
            campos.Add("ncr");
            campos.Add("razon_social");
            campos.Add("telefono");
            campos.Add("correo");
            campos.Add("iddescuento");
            campos.Add("fecha_ingreso");
            campos.Add("genero");
            campos.Add("estado");
            return campos;
        }

        public override List<string> generarValores()
        {
            List<string> valores = new List<string>();
            valores.Add(Cod_cliente);
            valores.Add(Nombre_cliente);
            valores.Add(apellidos_cliente);
            valores.Add(direccion);
            valores.Add(dui);
            valores.Add(nit);
            valores.Add(ncr);
            valores.Add(razon_social);
            valores.Add(telefono);
            valores.Add(correo);
            valores.Add(iddescuento);
            valores.Add(fecha_ingreso);
            valores.Add(genero);
            valores.Add(estado);
            return valores;
        }

        public static DataTable datosTabla()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"select *, d.tipo_descuento as nombres_des, concat(c.nombre_cliente, ' ', c.apellidos_cliente) as nom
                        from clientes c, descuentos d
                        where c.iddescuento = d.iddescuento
                        ; ";
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

        public bool actualizarCliente()
        {
            bool actualiza = false;
            StringBuilder sentencia = new StringBuilder("UPDATE clientes SET ");
            sentencia.Append("nombre_cliente ='" + this.Nombre_cliente + "', ");
            sentencia.Append("apellidos_cliente ='" + this.apellidos_cliente + "', ");
            sentencia.Append("direccion ='" + this.direccion + "', ");
            sentencia.Append("genero='"+this.genero+"',");
            sentencia.Append("estado ='" + this.estado + "' WHERE(idcliente='" + idcliente + "');");

            conexiones_BD.operaciones op = new operaciones();
            Console.WriteLine(sentencia.ToString());

            if (op.actualizar(sentencia.ToString()) > 0)
            {
                actualiza = true;
            }
            else
            {
                actualiza = false;
            }

            return actualiza;
        }

        public static DataTable datosClientes()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"select concat(e.nombre_cliente,' ', e.apellidos_cliente) as nombre, 
                        e.nombre_cliente, e.apellidos_cliente, e.idcliente, e.cod_cliente, e.direccion,
                        e.genero
                        from clientes e where e.estado=1
                        ; ";
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

        public static DataTable datosClientes2()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"select concat(e.nombre_cliente,' ', e.apellidos_cliente) as nombre, 
                        e.nombre_cliente, e.apellidos_cliente, e.idcliente, e.cod_cliente, e.direccion,
                        e.genero
                        from clientes e where e.estado=1
                        ; ";
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

        public static DataTable ventasXcliente(string id, string fechai, string fechaf)
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Console.WriteLine(fechai +" "+fechaf);
            Consulta = @"select sumasVentas("+id+",'"+fechai+"','"+fechaf+"');";
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

        public static DataTable detalleventasXclientes(int id, string fechai, string fechaf)
        {
            DataTable Datos = new DataTable();
            conexiones_BD.operaciones oOperacion = new conexiones_BD.operaciones();
            try
            {
                Datos = oOperacion.comprasXcliente(fechai, fechaf, id);
            }
            catch
            {
                Datos = new DataTable();
            }

            return Datos;
        }

        public static DataTable estadisticasXcliente(string fechai, string fechaf)
        {
            DataTable Datos = new DataTable();
            conexiones_BD.operaciones oOperacion = new conexiones_BD.operaciones();
            try
            {
                Datos = oOperacion.estadisticasXcliente(fechai, fechaf);
            }
            catch
            {
                Datos = new DataTable();
            }

            return Datos;
        }

        public static DataTable clienteXid(string idcliente)
        {
            DataTable Datos = new DataTable();
            operaciones oOperacion = new operaciones();
            string sentencia = "select * from clientes where idcliente='"+idcliente+"'";
            try
            {
                Datos = oOperacion.Consultar(sentencia);
            }
            catch
            {
                Datos = new DataTable();
            }

            return Datos;
        }

        public static DataTable estadisticasTodosClientes(string fechai, string fechaf)
        {
            DataTable Datos = new DataTable();
            conexiones_BD.operaciones oOperacion = new conexiones_BD.operaciones();
            try
            {
                Datos = oOperacion.estadisticasXTodos(fechai, fechaf);
            }
            catch
            {
                Datos = new DataTable();
            }

            return Datos;
        }

        public long ingresandoCliente(bool r)
        {
            StringBuilder sentencia = new StringBuilder(@"INSERT clientes (cod_cliente, nombre_cliente, 
                apellidos_cliente, direccion, dui, nit, ncr, razon_social, telefono, correo, iddescuento, fecha_ingreso, genero, estado) VALUES (");
            sentencia.Append("'" + cod_cliente + "',");
            sentencia.Append("'" + nombre_cliente + "',");
            sentencia.Append("'" + apellidos_cliente + "',");
            sentencia.Append("'" + direccion + "',");
            sentencia.Append("'" + dui + "',");
            sentencia.Append("'" + nit + "',");
            sentencia.Append("'" + ncr + "',");
            sentencia.Append("'" + razon_social + "',");
            sentencia.Append("'" + telefono + "',");
            sentencia.Append("'" + correo + "',");
            sentencia.Append("'" + iddescuento + "',");
            sentencia.Append("'" + fecha_ingreso + "',");
            sentencia.Append("'" + genero + "',");
            sentencia.Append("'" + estado + "');");

            conexiones_BD.operaciones op = new operaciones();
            long respuesta = op.insertar(sentencia.ToString());

            if (respuesta > 0)
            {
                if (r)
                {
                    MessageBox.Show("El registro se ingreso correctamente", "Registro ingresado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo ingresar el registro", "No se pudo agregar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return respuesta;

            }
            else
            {
                return respuesta = 0;
            }
        }
    }
}
