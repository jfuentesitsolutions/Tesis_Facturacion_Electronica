using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using conexiones_BD.clases.ventas;

namespace interfaces.ventas.auxiliares
{
    public partial class busquedaArticulos : Form
    {
        utilitarios.cargar_tablas tabla;
        DataTable docu=null;
        bool elegido = false;
        string idventa_tic = null;
        Action accion;
        facturas factura;
        sessionManager.secion sesion = sessionManager.secion.Instancia;

        public DataTable Docu
        {
            get
            {
                return docu;
            }

            set
            {
                docu = value;
            }
        }

        public bool Elegido
        {
            get
            {
                return elegido;
            }

            set
            {
                elegido = value;
            }
        }

        public string Idventa_tic
        {
            get
            {
                return idventa_tic;
            }

            set
            {
                idventa_tic = value;
            }
        }

        public facturas Factura
        {
            get
            {
                return factura;
            }

            set
            {
                factura = value;
            }
        }

        public busquedaArticulos()
        {
            InitializeComponent();
        }

        private void cargarTodo()
        {
            gadgets.horientaciones_textos.colocarTitulo(panelTitulo, lblEncanezado);
            listaDocumentos.SelectedIndex = 0;
            cargarTablas();
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void busquedaArticulos_Load(object sender, EventArgs e)
        {
            Thread t = new Thread(creandoAccion);
            t.Start();
        }

        private void creandoAccion()
        {
            accion = cargarTodo;
            if (InvokeRequired)
            {
                Invoke(accion);
            }
        }

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            gadgets.movimimientos mov = new gadgets.movimimientos();
            mov.moverFormulario(sender, e, this);
        }

        private void cargarTablas()
        {

            switch (listaDocumentos.SelectedIndex)
            {
                case 0: {
                        utilitarios.maneja_fechas fe = new utilitarios.maneja_fechas();
                        tabla = new utilitarios.cargar_tablas(tablaDocumentos, txtBuscar,
                            conexiones_BD.clases.ventas.tickets.datosTabla(fe.fechaCortaMysql(fecha),
                            sesion.DatosRegistro[1]), "correlativo");
                        tabla.cargarSinContadorRegistros();
                        break;
                        }
                case 1:
                    {
                        utilitarios.maneja_fechas fe = new utilitarios.maneja_fechas();
                        tabla = new utilitarios.cargar_tablas(tablaDocumentos, txtBuscar,
                            conexiones_BD.clases.ventas.facturas.datosTabla(fe.fechaCortaMysql(fecha),
                            sesion.DatosRegistro[1]), "correlativo");
                        tabla.cargarSinContadorRegistros();
                        break;
                    }
            }
            
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            tabla.FiltrarLocalmenteSinContadorRegistros();
        }

        private void listaDocumentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarTablas();
        }

        private void tablaDocumentos_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                switch (listaDocumentos.SelectedIndex)
                {
                    case 0:
                        {
                            docu = conexiones_BD.clases.ventas.detalles_productos_venta_ticket.detalle_proTic(tablaDocumentos.CurrentRow.Cells[0].Value.ToString());
                            break;
                        }
                    case 1:
                        {
                            BindingSource select = (BindingSource)tablaDocumentos.DataSource;
                            DataTable data = (DataTable)select.DataSource;
                            DataRow fila=null;
                            foreach (DataRow fila_e in data.Rows)
                            {
                                if (fila_e[0].Equals(tablaDocumentos.CurrentRow.Cells[0].Value))
                                 {
                                    fila = fila_e;
                                }
                            }

                            
                            Console.WriteLine("La catidad de filas es: "+data.Rows.Count);

                            Factura = new facturas(
                                fila[3].ToString(),
                                fila[0].ToString(),
                                fila[2].ToString(),
                                "1",
                                "1",
                                fila[9].ToString(),
                                fila[10].ToString(),
                                fila[12].ToString(),
                                fila[13].ToString(),
                                fila[14].ToString(),
                                fila[15].ToString(),
                                fila[16].ToString(),
                                fila[17].ToString(),
                                fila[18].ToString(),
                                fila[19].ToString(),
                                fila[20].ToString(),
                                fila[21].ToString(),
                                fila[22].ToString(),
                                fila[23].ToString(),
                                fila[24].ToString(),
                                fila[25].ToString(),
                                fila[26].ToString(),
                                fila[27].ToString(),
                                fila[28].ToString(),
                                fila[29].ToString(),
                                fila[30].ToString(),
                                fila[31].ToString(),
                                fila[32].ToString(),
                                fila[33].ToString(),
                                fila[34].ToString(),
                                fila[35].ToString(),
                                fila[36].ToString(),
                                fila[37].ToString(),
                                fila[38].ToString()
                                );
                            docu = detalles_productos_venta_factura.detalle_proTic(fila[0].ToString());
                            break;
                        }
                }     
            }
            catch
            {
                docu = null;
            }

            if (docu != null)
            {
                elegido = true;
                idventa_tic = tablaDocumentos.CurrentRow.Cells[0].Value.ToString();
                this.Close();
            }
        }

        private void fecha_ValueChanged(object sender, EventArgs e)
        {
            cargarTablas();
        }


    }
}
