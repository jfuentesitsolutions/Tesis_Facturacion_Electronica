using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfaces.cajas_efectivo
{
    public partial class cajas_cerradas : Form
    {
        utilitarios.cargar_tablas tabla;
        DataTable registros;
        public cajas_cerradas()
        {
            InitializeComponent();
        }

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            gadgets.movimimientos mov = new gadgets.movimimientos();
            mov.moverFormulario(sender, e, this);
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cajas_cerradas_Load(object sender, EventArgs e)
        {
            cargandoDatos();
        }

        private void cargandoDatos()
        {
            registros = conexiones_BD.clases.cortes_diarios.datosCajasCerradas();
            tabla = new utilitarios.cargar_tablas(tablas_cajas_cerradas, txtBuscar, registros, "idl");
            tabla.cargarSinContadorRegistros();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            tabla.FiltrarLocalmenteSinContadorRegistros();
        }

        private void tablas_cajas_cerradas_DoubleClick(object sender, EventArgs e)
        {
            if (tablas_cajas_cerradas.RowCount!=0)
            {
                cargandoReporte();
            }
        }

        private void cargandoReporte()
        {
            Reportes.Diseño.reporteCortes repocaja = new Reportes.Diseño.reporteCortes();
            string ica= tablas_cajas_cerradas.CurrentRow.Cells[0].Value.ToString();
            repocaja.SetDataSource(conexiones_BD.clases.cortes_diarios.datosCaja(ica));
            repocaja.SetParameterValue("encabezado", "COPIA DE REPORTE DE CAJA");
            repocaja.SetParameterValue("fecha", DateTime.Now.ToString());
            repocaja.SetParameterValue("idcaja", "Numero de ID de la caja: " + ica);
            repocaja.SetParameterValue("total", tablas_cajas_cerradas.CurrentRow.Cells[2].Value.ToString());
            repocaja.SetParameterValue("efect_ini", tablas_cajas_cerradas.CurrentRow.Cells[4].Value.ToString());
            reportes_cortes.ReportSource=repocaja;
        }


    }
}
