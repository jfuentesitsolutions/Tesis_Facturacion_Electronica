using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace control_principal.configuracion_inicial
{
    public partial class tabla_empleados : Form
    {
        BindingSource _empleados = new BindingSource();
        private String idempleado, nempleado;
        private Boolean seleccionado = false;

        public string Idempleado
        {
            get
            {
                return idempleado;
            }

            set
            {
                idempleado = value;
            }
        }

        public string Nempleado
        {
            get
            {
                return nempleado;
            }

            set
            {
                nempleado = value;
            }
        }

        public bool Seleccionado
        {
            get
            {
                return seleccionado;
            }

            set
            {
                seleccionado = value;
            }
        }

        private void FiltrarLocalmente()
        {
            if (txtBuscar.TextLength == 0)
            {
                _empleados.RemoveFilter();
            }
            else
            {
                _empleados.Filter = "nombres LIKE '%" + txtBuscar.Text + "%'";
            }
            tablaEmpleados.AutoGenerateColumns = false;
            tablaEmpleados.DataSource = _empleados;

        }

        private void cargarEmpleados()
        {
            try
            {
                _empleados.DataSource = cache_conexiones.cache.TODO_LOS_EMPLEADOS();
                FiltrarLocalmente();
            }
            catch
            {

            }
        }

        private void tabla_empleados_Load(object sender, EventArgs e)
        {
            cargarEmpleados();
        }

        private void tablaEmpleados_DoubleClick(object sender, EventArgs e)
        {
            seleccionado = true;
            idempleado = tablaEmpleados.CurrentRow.Cells[0].Value.ToString();
            Nempleado = tablaEmpleados.CurrentRow.Cells[2].Value.ToString() + " " + tablaEmpleados.CurrentRow.Cells[3].Value.ToString();
            this.Dispose();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }

        public tabla_empleados()
        {
            InitializeComponent();
        }

    }
}
