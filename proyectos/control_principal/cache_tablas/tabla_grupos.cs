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
    public partial class tabla_grupos : Form
    {
        BindingSource _grupos = new BindingSource();
        private String idgrupo, ngrupo;
        private Boolean seleccionado = false;

        public string Idgrupo
        {
            get
            {
                return idgrupo;
            }

            set
            {
                idgrupo = value;
            }
        }

        public string Ngrupo
        {
            get
            {
                return ngrupo;
            }

            set
            {
                ngrupo = value;
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
                _grupos.RemoveFilter();
            }
            else
            {
                _grupos.Filter = "nombre_grupo LIKE '%" + txtBuscar.Text + "%'";
            }
            tablaGrupos.AutoGenerateColumns = false;
            tablaGrupos.DataSource = _grupos;

        }

        private void cargarGrupos()
        {
            try
            {
                _grupos.DataSource = cache_conexiones.cache.TODO_LOS_GRUPOS();
                FiltrarLocalmente();
            }
            catch
            {

            }
        }

        public tabla_grupos()
        {
            InitializeComponent();
        }

        private void tablaGrupos_DoubleClick(object sender, EventArgs e)
        {
            seleccionado = true;
            idgrupo = tablaGrupos.CurrentRow.Cells[0].Value.ToString();
            ngrupo = tablaGrupos.CurrentRow.Cells[1].Value.ToString();
            this.Dispose();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }

        private void tabla_grupos_Load(object sender, EventArgs e)
        {
            cargarGrupos();
        }
    }
}
