using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace utilitarios
{
    public partial class barra_progreso : Form
    {
        DataTable tabla;
        bool cargados;
        public DataTable Tabla
        {
            get
            {
                return tabla;
            }

            set
            {
                tabla = value;
            }
        }

        public bool Cargados
        {
            get
            {
                return cargados;
            }

            set
            {
                cargados = value;
            }
        }

        public barra_progreso()
        {
            InitializeComponent();
        }

        public barra_progreso(DataTable reg)
        {
            this.Tabla = reg;
            InitializeComponent();
        }

        private void barra_progreso_Load(object sender, EventArgs e)
        {
            barraDeprogreso();
        }

        private void barraDeprogreso()
        {
            barra.Minimum = 1;
            barra.Maximum = Tabla.Rows.Count;

            barra.Value = 1;
            barra.Step = 1;

            for (int x = 1; x <= Tabla.Rows.Count; x++)
            {
                barra.PerformStep();
            }

            cargados = true;
            this.Close();
        }
    }
}
