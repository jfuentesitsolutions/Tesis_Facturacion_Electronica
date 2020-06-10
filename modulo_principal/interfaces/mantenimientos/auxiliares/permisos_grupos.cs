using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using conexiones_BD.clases;

namespace interfaces.mantenimientos.auxiliares
{
    public partial class permisos_grupos : Form
    {

        DataTable datos = conexiones_BD.clases.permisos.datosTabla();
        utilitarios.cargar_tablas tabla, tabla1, tabla2;
        List<conexiones_BD.clases.permisos_grupos> permisosAsignados= new List<conexiones_BD.clases.permisos_grupos>();
        DataTable permisosRestantes = new DataTable();
        DataGridView permisoAsignado = new DataGridView();
        string idgrupo;

        bool permisosAsig=false;
        bool actualizarPermisos=false;
        bool modificar = false;

        public List<conexiones_BD.clases.permisos_grupos> PermisosAsignados
        {
            get
            {
                return permisosAsignados;
            }

            set
            {
                permisosAsignados = value;
            }
        }

        public bool PermisosAsig
        {
            get
            {
                return permisosAsig;
            }

            set
            {
                permisosAsig = value;
            }
        }

        public DataTable PermisosRestantes
        {
            get
            {
                return permisosRestantes;
            }

            set
            {
                permisosRestantes = value;
            }
        }

        public bool ActualizarPermisos
        {
            get
            {
                return actualizarPermisos;
            }

            set
            {
                actualizarPermisos = value;
            }
        }

        public DataGridView PermisoAsignado
        {
            get
            {
                return permisoAsignado;
            }

            set
            {
                permisoAsignado = value;
            }
        }

        public bool Modificar
        {
            get
            {
                return modificar;
            }

            set
            {
                modificar = value;
            }
        }

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

        public permisos_grupos()
        {
            InitializeComponent();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            gadgets.movimimientos mov = new gadgets.movimimientos();
            mov.moverFormulario(sender, e, this);
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void permisos_grupos_Load(object sender, EventArgs e)
        {
            gadgets.horientaciones_textos.colocarTitulo(titulo, lblEncanezado_permisos);

            if (modificar)
            {
                cargarDatosTablasPermisos();
            }else
            {
                if (actualizarPermisos)
                {
                    tabla = new utilitarios.cargar_tablas(tablasPermisos, txtBuscar, permisosRestantes, "descripcion");
                    tabla.cargarSinContadorRegistros();

                    foreach(DataGridViewRow fila in permisoAsignado.Rows)
                    {
                        tabla_permisos_asignados.Rows.Add(fila.Cells[0].Value.ToString(), fila.Cells[1].Value.ToString(), fila.Cells[2].Value.ToString());     
                    }
                }
                else
                {
                    tabla = new utilitarios.cargar_tablas(tablasPermisos, txtBuscar, datos, "descripcion");
                    tabla.cargarSinContadorRegistros();
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
                guardaPermisos();
            
            
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (modificar)
            {
                tabla1.FiltrarLocalmenteSinContadorRegistros();
            }else
            {
                tabla.FiltrarLocalmenteSinContadorRegistros();
            }

            
        }

        private void asignar_Click(object sender, EventArgs e)
        {
            if (modificar)
            {
                agregandoPermiso();
                cargarDatosTablasPermisos();
            }
            else
            {
                asignarNuevosPermisos();
            }
            
        }

        private void asignarNuevosPermisos()
        {
            List<DataGridViewRow> filaSeleccionada = new List<DataGridViewRow>();
            foreach(DataGridViewRow fila in tablasPermisos.Rows)
            {
                if (fila.Selected)
                {
                    filaSeleccionada.Add(fila);
                }
            }

            foreach (DataGridViewRow fila in filaSeleccionada)
            {
                tabla_permisos_asignados.Rows.Add(new object[]
                {
                    fila.Cells[0].Value,
                    fila.Cells[1].Value,
                    fila.Cells[2].Value
                });

                tablasPermisos.Rows.Remove(fila);
            }

        }

        private void quitar_Click(object sender, EventArgs e)
        {
            if (modificar)
            {
                eliminandoPermiso();
                cargarDatosTablasPermisos();
            }else
            {
                quitarPermisos();
            }
            

        }

        private void quitarPermisos()
        {

            List<DataGridViewRow> filasSeleccionadas = new List<DataGridViewRow>();
            

            foreach (DataGridViewRow fila in tabla_permisos_asignados.Rows)
            {
                if (fila.Selected)
                {
                    filasSeleccionadas.Add(fila);
                }
            }

            if (filasSeleccionadas.Count > 0)
            {
                foreach (DataGridViewRow fila in filasSeleccionadas)
                {
                    DataRow fi = tabla.TablaDatos.NewRow();
                    fi[0] = fila.Cells[0].Value.ToString();
                    fi[1] = fila.Cells[1].Value.ToString();
                    fi[2] = fila.Cells[2].Value.ToString();
                    tabla.TablaDatos.Rows.Add(fi);

                    tabla_permisos_asignados.Rows.Remove(fila);
                }

                tabla.cargarSinContadorRegistros();
            }
        }

        public void guardaPermisos()
        {
            if (modificar)
            {
                if (tabla_permisos_asignados.Rows.Count > 0)
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se han asignado permisos", "No hay permisos asignados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
            if (tabla_permisos_asignados.Rows.Count>0)
            {
                foreach(DataGridViewRow fila in tabla_permisos_asignados.Rows)
                {
                    permisosAsignados.Add(new conexiones_BD.clases.permisos_grupos("0", fila.Cells[0].Value.ToString()));
                }

                permisosAsig = true;
                permisosRestantes = tabla.TablaDatos;
                permisoAsignado = tabla_permisos_asignados;
                
                this.Close();
            }else
            {
                MessageBox.Show("No se han asignado permisos", "No hay permisos asignados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
        }

        public void cargarDatosTablasPermisos()
        {
            tabla1 = new utilitarios.cargar_tablas(tablasPermisos, txtBuscar, conexiones_BD.clases.permisos_grupos.datosTablaPermisosAasignar(Idgrupo), "nombre");
            tabla2 = new utilitarios.cargar_tablas(tabla_permisos_asignados, txtBusquedaAsig, conexiones_BD.clases.permisos_grupos.datosTablaPermisosAsignados(Idgrupo), "nombreP");

            tabla1.cargarSinContadorRegistros();
            tabla2.cargarSinContadorRegistros();

        }

        private void txtBusquedaAsig_TextChanged(object sender, EventArgs e)
        {
            if (modificar)
            {
                tabla2.FiltrarLocalmenteSinContadorRegistros();
            }
        }

        private void agregandoPermiso()
        {
            if (tablasPermisos.Rows.Count>0)
            {
                conexiones_BD.clases.permisos_grupos pg = new conexiones_BD.clases.permisos_grupos(idgrupo, tablasPermisos.CurrentRow.Cells[0].Value.ToString());
                pg.guardar(false);
            }
            
        }

        private void eliminandoPermiso()
        {
            try
            {
                conexiones_BD.clases.permisos_grupos pg = new conexiones_BD.clases.permisos_grupos(tabla_permisos_asignados.CurrentRow.Cells[3].Value.ToString());
                pg.eliminar(false);
            }
            catch
            {

            }
            
        }
    }
}
