using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfaces.panel_inicio
{
    public partial class inicio : Form
    {
        sessionManager.secion secion = sessionManager.secion.Instancia;
        public inicio()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            label2.Text = DateTime.Now.ToShortDateString();
            label3.Text = DateTime.Now.ToString("dddd").ToUpper();
        }

        private void inicio_Load(object sender, EventArgs e)
        {
            timer1.Start();
            ponerDatosUsuarios();
            ponerdatosSucursal();
            verificandoCaja();

            control_permisos.controlador_de_permisos per = new control_permisos.controlador_de_permisos(this.panel_opciones, conexiones_BD.clases.usuarios.permisosAsigandosInicio(secion.Datos[5]));
        }

        private void btnAbajo_Click(object sender, EventArgs e)
        {
            panelContenido.Dock = DockStyle.Fill;
            btnAbajo.Visible = false;
            btnArriba.Visible = true;
            lblUsuario.Visible = false;
            imgNina.Location = new Point(78, 13);
            imgNino.Location = new Point(78, 13);
        }

        private void btnArriba_Click(object sender, EventArgs e)
        {
            panelContenido.Dock = DockStyle.Top;
            btnAbajo.Visible = true;
            btnArriba.Visible = false;
            lblUsuario.Visible = true;
            imgNina.Location = new Point(18, 13);
            imgNino.Location = new Point(18, 13);
        }

        private void ponerDatosUsuarios()
        {
            if (secion.Datos[2].Equals("Femenino"))
            {
                imgNina.Visible = true;
            }
            else
            {
                imgNino.Visible = true;
            }
            lblUsuario.Text = secion.Datos[0];
            lblUsu.Text = secion.Datos[0];
            lblGrupos.Text = secion.Datos[3];
            lblCargo.Text = secion.Datos[4];
            lblNombreem.Text = secion.Datos[1];
        }

        private void ponerdatosSucursal()
        {
            lblSucursal.Text = secion.DatosRegistro[0];
            lblSuc.Text = secion.DatosRegistro[0];
            lblDirec.Text = secion.DatosRegistro[2];
            lblTelefono.Text = secion.DatosRegistro[3];
            lblEncargado.Text = secion.DatosRegistro[4];
            lblNombre_Equi.Text = secion.DatosRegistro[6];
        }

        private void btnAbajoss_Click(object sender, EventArgs e)
        {
            lblSucursal.Visible = false;
            lblEncabezado.Visible = false;
            btnAbajoss.Visible = false;
            btnArribas.Visible = true;
            imgsucu.Location = new Point(75, 13);
            panelContenidoS.Dock = DockStyle.Fill;
        }

        private void btnArribas_Click(object sender, EventArgs e)
        {
            lblSucursal.Visible = true;
            lblEncabezado.Visible = true;
            btnAbajoss.Visible = true;
            btnArribas.Visible = false;
            imgsucu.Location = new Point(18, 13);
            panelContenidoS.Dock = DockStyle.Top;
        }

        private void btnAgregaPresentaciones_Click_1(object sender, EventArgs e)
        {
            mantenimientos.procesos_iniciales.agregaPresentaciones ap = new mantenimientos.procesos_iniciales.agregaPresentaciones();
            ap.ShowDialog();
        }

        private void btnREs_Click(object sender, EventArgs e)
        {
            mantenimientos.base_datos.base_d dato = new mantenimientos.base_datos.base_d();
            dato.ShowDialog();  
        }

        private void btnPresentacion_Click(object sender, EventArgs e)
        {
            mantenimientos.procesos_iniciales.codigosXpresentaciones dato = new mantenimientos.procesos_iniciales.codigosXpresentaciones();
            dato.ShowDialog();
        }

        private void btnActualiza_Click(object sender, EventArgs e)
        {
            actualizaciones.actualiza_productos frm = new actualizaciones.actualiza_productos();
            frm.ShowDialog();
        }

        private void btnTraslado_Click(object sender, EventArgs e)
        {
            traslados.recepcion_traslados frm = new traslados.recepcion_traslados();
            frm.ShowDialog();
            /*hilos_conexion.productos_hilos hil = new hilos_conexion.productos_hilos();
            hil.ShowDialog();*/
        }

        private void verificandoCaja()
        {
            DataTable caja = conexiones_BD.clases.cajas.datosTabla(secion.DatosRegistro[6]);
            if (caja.Rows.Count>0)
            {
                tipo_caja.Image = Properties.Resources.caja_abierta;
                lbl_estado_caja.Text = "Caja abierta";
                secion.Caja_activa = true;
                secion.Idcaja = caja.Rows[0][0].ToString();
            }else
            {
                tipo_caja.Image = Properties.Resources.caja_cerrada;
                lbl_estado_caja.Text = "No hay caja abierta";
                secion.Caja_activa = false;
                secion.Idcaja = "0";
            }

        }
    }
}
