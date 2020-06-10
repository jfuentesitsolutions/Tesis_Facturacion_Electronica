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
    public partial class tabla_unidades : Form
    {
        BindingSource _unidades = new BindingSource();
        private String idunidad, nunidad;
        private Boolean seleccionado = false;

        public string Idunidad
        {
            get
            {
                return idunidad;
            }

            set
            {
                idunidad = value;
            }
        }

        public string Nunidad
        {
            get
            {
                return nunidad;
            }

            set
            {
                nunidad = value;
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

        public tabla_unidades()
        {
            InitializeComponent();
        }

        private void FiltrarLocalmente()
        {
            if (txtBuscar.TextLength == 0)
            {
                _unidades.RemoveFilter();
            }
            else
            {
                _unidades.Filter = "nombre LIKE '%" + txtBuscar.Text + "%'";
            }
            tablaUnidades.AutoGenerateColumns = false;
            tablaUnidades.DataSource = _unidades;

        }

        private void cargarUnidades()
        {
            try
            {
                _unidades.DataSource = cache_conexiones.cache.TODO_LOS_UNIDADES();
                FiltrarLocalmente();
            }
            catch
            {

            }
        }

        private void tabla_unidades_Load(object sender, EventArgs e)
        {
                cargarUnidades();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }

        private void tablaUnidades_DoubleClick(object sender, EventArgs e)
        {
            seleccionado = true;
            idunidad = tablaUnidades.CurrentRow.Cells[0].Value.ToString();
            nunidad = tablaUnidades.CurrentRow.Cells[2].Value.ToString();
            this.Dispose();
        }
    }
}
