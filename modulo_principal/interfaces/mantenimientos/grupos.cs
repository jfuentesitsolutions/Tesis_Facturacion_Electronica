using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfaces.mantenimientos
{
    public partial class grupos : Form
    {
        List<conexiones_BD.clases.permisos_grupos> permiso=null;
        DataTable permisosRestantes;
        DataGridView permisosAsignados;
        string idgrupo=null;
        bool actualizar = false;

        DataTable datos = conexiones_BD.clases.grupos.datosTabla();
        utilitarios.cargar_tablas tabla;

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

        public bool Actualizar
        {
            get
            {
                return actualizar;
            }

            set
            {
                actualizar = value;
            }
        }

        public grupos()
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

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            auxiliares.permisos_grupos pg = new auxiliares.permisos_grupos();

            if (actualizar)
            {
                if (idgrupo==null)
                {

                }else
                {
                    pg.Modificar = true;
                    pg.Idgrupo = idgrupo;
                    pg.ShowDialog();
                }
                
            }
            else
            {

            if (permiso!=null)
            {
                pg.ActualizarPermisos = true;
                pg.PermisosRestantes = permisosRestantes;
                pg.PermisoAsignado = permisosAsignados;
                pg.ShowDialog();
                if (pg.PermisosAsig)
                {
                    permisosAsignados = pg.PermisoAsignado;
                    permisosRestantes = pg.PermisosRestantes;
                    permiso = pg.PermisosAsignados;
                    asignación.Visible = true;
                    Console.WriteLine(permisosAsignados.Rows.Count.ToString());
                    Console.WriteLine(permiso.Count.ToString());
                }
            }
            else
            {
            pg.ShowDialog();
            if (pg.PermisosAsig)
            {
                permisosAsignados = pg.PermisoAsignado;
                permisosRestantes = pg.PermisosRestantes;
                permiso = pg.PermisosAsignados;
                asignación.Visible = true;
                    Console.WriteLine(permisosAsignados.Rows.Count.ToString());
                    Console.WriteLine(permiso.Count.ToString());

                }
            }

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (actualizar)
            {
                eliminarGrupos();
            }else
            {
                this.Close();
            }
            
        }

        private void grupos_Load(object sender, EventArgs e)
        {
            gadgets.horientaciones_textos.colocarTitulo(panelTitulo, lblEncanezado);

            cargarTabla();

            if (actualizar)
            {
                asignación.Visible = true;
                btnGuardar.Text = "Actualizar";
                btnCancelar.Text = "Eliminar";
                habilitandoControles(false);
            }
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (actualizar)
            {
                modificarGrupos();
            }else
            {
                guardandoGrupos();
            }
        }

        private bool validar()
        {
            bool valido = false;
            List<TextBox> controles = new List<TextBox>();
            controles.Add(txtGrupo);
            controles.Add(txtDescripcion);
            valido= utilitarios.vaciando_formularios.validando(controles, error); ;

            if (actualizar)
            {

            }else
            {
            if (permiso==null)
            {
                error.SetError(btnAsignar, "Tienes que asignar permisos al grupo");
                valido = true;
            }
            }

            return valido;
        }

        private void cargarTabla()
        {
            tabla = new utilitarios.cargar_tablas(tablaGrupos, txtBuscar, conexiones_BD.clases.grupos.datosTabla(), "nombre", lblRegistros);
            tabla.cargar();
        }

        private void guardandoGrupos()
        {
            if (validar())
            {

            }else
            {
                if (validarExistencias())
                {

                }else
                {
                    conexiones_BD.operaciones op = new conexiones_BD.operaciones();
                    conexiones_BD.clases.grupos grupo = new conexiones_BD.clases.grupos(txtGrupo.Text, txtDescripcion.Text);

                    if (op.transaccionPermisos_grupos(permiso, grupo) > 0)
                    {
                        MessageBox.Show("Los registros se ingresaron correctamente", "Exíto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tabla = new utilitarios.cargar_tablas(tablaGrupos, txtBuscar, conexiones_BD.clases.grupos.datosTabla(), "nombre", lblRegistros);
                        vaciarTexbox();
                        tabla.cargar(); 
                    }
                    else
                    {
                        MessageBox.Show("Los registros no se ingresaron", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
                
            }
        }

        private bool validarExistencias()
        {
            List<string> campos = new List<string>();
            campos.Add("nombre");

            List<string> valores = new List<string>();
            valores.Add(txtGrupo.Text);

            conexiones_BD.clases.grupos gr = new conexiones_BD.clases.grupos(campos, valores);
            if (gr.validarCamposcondicorOR(true) > 0)
            {
                return true;
            }else
            {
                return false;
            }
            
        }

        private void habilitandoControles(bool con)
        {
            List<Control> control = new List<Control>();
            control.Add(txtGrupo);
            control.Add(txtDescripcion);
            control.Add(btnAsignar);
            control.Add(btnCancelar);
            control.Add(btnGuardar);

            utilitarios.vaciando_formularios.habilitandoTexbox(control, con);

        }

        private void tablaGrupos_Click(object sender, EventArgs e)
        {
            if (actualizar)
            {
                idgrupo = tablaGrupos.CurrentRow.Cells[0].Value.ToString();
                txtGrupo.Text = tablaGrupos.CurrentRow.Cells[1].Value.ToString();
                txtDescripcion.Text = tablaGrupos.CurrentRow.Cells[2].Value.ToString();

                habilitandoControles(true);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            tabla.FiltrarLocalmente();
        }

        private void modificarGrupos()
        {
            if (validar())
            {

            }
            else
            {
                conexiones_BD.clases.grupos gr = new conexiones_BD.clases.grupos(idgrupo, txtGrupo.Text, txtDescripcion.Text);
                if (gr.modificar(true) > 0)
                {
                    vaciarTexbox();
                    habilitandoControles(false);
                    cargarTabla();
                }
            }
        }

        private void eliminarGrupos()
        {
            conexiones_BD.clases.grupos gr = new conexiones_BD.clases.grupos(idgrupo);
            if (gr.eliminar(false) > 0)
            {
                MessageBox.Show("El grupo a sido eliminado.", "Exíto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                vaciarTexbox();
                habilitandoControles(false);
                cargarTabla();
            }else
            {
                MessageBox.Show("No se pudo borrar el grupo es probable que tenga permisos asignados,"+Environment.NewLine+
                    "Si desea borrarlo debe elimimar los permisos asignados","Información", MessageBoxButtons.OK, MessageBoxIcon.Information
                    );
            }
        }

        private void vaciarTexbox()
        {
            List<Control> control = new List<Control>();
            control.Add(txtGrupo);
            control.Add(txtDescripcion);
            asignación.Visible = false;

            utilitarios.vaciando_formularios.vaciarTexbox(control);
        }
    }
}
