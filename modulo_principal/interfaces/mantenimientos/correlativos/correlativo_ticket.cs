using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfaces.mantenimientos.correlativos
{
    public partial class correlativo_ticket : Form
    {
        utilitarios.cargar_tablas tabla;
        sessionManager.secion sesion = sessionManager.secion.Instancia;
        public correlativo_ticket()
        {
            InitializeComponent();
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void correlativo_ticket_Load(object sender, EventArgs e)
        {
            gadgets.horientaciones_textos.colocarTitulo(panelTitulo, lblEncanezado);
            cargar();
        }

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            gadgets.movimimientos mov = new gadgets.movimimientos();
            mov.moverFormulario(sender, e, this);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (!validar())
            {
                DataTable correlativos = conexiones_BD.clases.ventas.correlativos_tickets.datosTabla(listaSucursal.SelectedValue.ToString());
                if (correlativos.Rows.Count==0)
                {
                    string activo;
                    if (chekActivo.Checked)
                    {
                        activo = "1";
                    }
                    else
                    {
                        activo = "2";
                    }
                    utilitarios.maneja_fechas fe = new utilitarios.maneja_fechas();
                    conexiones_BD.clases.ventas.correlativos_tickets co = new conexiones_BD.clases.ventas.correlativos_tickets(listaSucursal.SelectedValue.ToString(), numInicio.Value.ToString(), numFinal.Value.ToString(),
                        "1", fe.fechaMysql(fecha), txtDescripcion.Text, activo
                        );

                    if (co.guardar(true)>0)
                    {
                        listaSucursal.SelectedValue = sesion.DatosRegistro[1];
                        txtDescripcion.Text = "";
                        chekActivo.Checked = false;
                        cargar();
                    }
                }else
                {
                    
                    MessageBox.Show("No puedes ingresar un nuevo correlativo\n porque ya hay activos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void cargar()
        {
            tabla = new utilitarios.cargar_tablas(tablaCorrelativos, new TextBox(), conexiones_BD.clases.ventas.correlativos_tickets.datosTablaCorrelativo(), "nus");
            tabla.cargarSinContadorRegistros();
            utilitarios.cargandoListas.cargarLista(conexiones_BD.clases.sucursales.datosTabla(), listaSucursal, "numero_de_sucursal", "idsucursal");
            listaSucursal.SelectedValue = sesion.DatosRegistro[1];
            numInicio.Value = 1;
            numFinal.Value = 999999;
        }

        private bool validar()
        {
            bool valido = false;
            error.Clear();
            string mensaje = "No puedes dejar este espacio en blanco";

            if (listaSucursal.SelectedIndex == -1)
            {
                valido = true;
                error.SetError(listaSucursal, mensaje);
            }
            if (numInicio.Value==0)
            {
                valido = true;
                error.SetError(numInicio, mensaje);
            }
            if (numFinal.Value == 0)
            {
                valido = true;
                error.SetError(numFinal, mensaje);
            }
            if (txtDescripcion.TextLength == 0)
            {
                valido = true;
                error.SetError(txtDescripcion, mensaje);
            }
            
            return valido;
        }
    }
}
