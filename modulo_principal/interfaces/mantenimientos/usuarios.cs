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
    public partial class usuarios : Form
    {

        bool modificar = false;
        conexiones_BD.clases.usuarios usuario;
        utilitarios.cargar_tablas tabla;
        string idusuario = null;
        string nombre = null;

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

        public usuarios()
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (modificar)
            {
                EliminarUsuario();
            }else
            {
                this.Close();
            }
            
        }

        private void usuarios_Load(object sender, EventArgs e)
        {
            gadgets.horientaciones_textos.colocarTitulo(panelTitulo, lblEncanezado);
            if (modificar)
            {
                btnGuardar.Text = "Modificar";
                btnCancelar.Text = "Eliminar";
                cargarListas();
                cargarTablas();
                habilitar(false);
                chkCambiarC.Visible = true;
            }else
            {
                cargarTablas();
                cargarListas();
            }
        }

        private void cargarTablas()
        {
            tabla = new utilitarios.cargar_tablas(tabla_usuarios, txtBuscar, conexiones_BD.clases.usuarios.datosTabla(), "usuario", lblRegistro);
            tabla.cargar();
        }

        private void habilitar(bool vis)
        {
            List<Control> controles = new List<Control>();
            controles.Add(chkCambiarC);
            controles.Add(txtNombre);
            controles.Add(txtContra);
            controles.Add(txtRcontra);
            controles.Add(listaEmpleado);
            controles.Add(listaGrupos);
            controles.Add(chkEstado);
            controles.Add(btnGuardar);
            controles.Add(btnCancelar);
            controles.Add(mostrar2);
            controles.Add(mostrar);

            utilitarios.vaciando_formularios.habilitandoTexbox(controles, vis);



        }

        private bool validar()
        {
            bool valido = false;
            List<TextBox> control = new List<TextBox>();
            control.Add(txtNombre);
            if (!modificar)
            {
                control.Add(txtContra);
                control.Add(txtRcontra);
            }
            if (chkCambiarC.Checked)
            {
                control.Add(txtContra);
                control.Add(txtRcontra);
            }
            
            valido = utilitarios.vaciando_formularios.validando(control, error);

            if (listaEmpleado.SelectedIndex == -1)
            {
                valido = true;
                error.SetError(listaEmpleado, "Elija un empleado");
            }

            if (listaGrupos.SelectedIndex == -1)
            {
                valido = true;
                error.SetError(listaGrupos, "Elija un grupo");
            }



            return valido;

        }

        private void vaciar()
        {
            List<Control> control = new List<Control>();
            control.Add(txtNombre);
            control.Add(txtContra);
            control.Add(txtRcontra);
            utilitarios.vaciando_formularios.vaciarTexbox(control);

            listaEmpleado.SelectedValue = "0";
            listaGrupos.SelectedValue = "0";
            mostrar.Checked = false;
            mostrar2.Checked = false;
            chkEstado.Checked = false;

            if (modificar)
            {
                chkCambiarC.Checked = false;
            }

        }

        private void cargarListas()
        {
            utilitarios.cargandoListas.cargarLista(conexiones_BD.clases.empleados_sucursales.datosTabla(),
                listaEmpleado,
                "nombres",
                "idempleado_sucursal");

            utilitarios.cargandoListas.cargarLista(conexiones_BD.clases.grupos.datosTabla(),
                listaGrupos,
                "nombre",
                "idgrupo");
        }

        private void txtRcontra_Leave(object sender, EventArgs e)
        {
            if (txtContra.Text.Equals(txtRcontra.Text))
            {
                coincide.Visible = true;
                noCoincide.Visible = false;
            }else
            {
                txtRcontra.Focus();
                txtRcontra.SelectAll();
                coincide.Visible = false;
                noCoincide.Visible = true;
            }
        }

        private void mostrar_CheckedChanged(object sender, EventArgs e)
        {
            String texto = txtContra.Text;

            txtContra.UseSystemPasswordChar = !mostrar.Checked;
        }

        private void mostrar2_CheckedChanged(object sender, EventArgs e)
        {
            String texto = txtRcontra.Text;

            txtRcontra.UseSystemPasswordChar = !mostrar2.Checked;
        }

        private bool validarExistencias()
        {
            bool valido = false;
            List<string> campos = new List<string>();
            List<string> valores = new List<string>();

            campos.Add("usuario");
            valores.Add(txtNombre.Text);

            usuario = new conexiones_BD.clases.usuarios(campos, valores);
            if (modificar)
            {
                if (txtNombre.Text.Equals(nombre))
                {
                    if (usuario.validarCamposcondicorORActu(true,1) > 1)
                    {
                        valido = true;
                    }
                    else
                    {
                        valido = false;
                    }
                }else
                {
                    if (usuario.validarCamposcondicorOR(true) > 0)
                    {
                        valido = true;
                    }
                    else
                    {
                        valido = false;
                    }
                }
                
            }else
            {
                if (usuario.validarCamposcondicorOR(true) > 0)
                {
                    valido = true;
                }
                else
                {
                    valido = false;
                }
            }

            return valido;
        }

        private void guardarUsuario()
        {
            if (!validar())
            {
                if (!validarExistencias())
                {
                    usuario = new conexiones_BD.clases.usuarios(txtNombre.Text,
                        txtRcontra.Text,
                        listaEmpleado.SelectedValue.ToString(),
                        listaGrupos.SelectedValue.ToString(),
                        "now",
                        estado()
                        );

                    if (usuario.guardar(true) > 0)
                    {
                        vaciar();
                        cargarTablas();
                    }
                }
            }
        }

        private void modificarUsuario()
        {
            
                if (!validar())
                {
                    if (!validarExistencias())
                    {
                    if (chkCambiarC.Checked)
                    {
                        usuario = new conexiones_BD.clases.usuarios(idusuario, txtNombre.Text, txtRcontra.Text, listaEmpleado.SelectedValue.ToString(), listaGrupos.SelectedValue.ToString(), "", estado());
                        if (usuario.modificarConCon(true) > 0)
                        {
                            vaciar();
                            txtRcontra.Text = "";
                            txtContra.Text = "";
                            noCoincide.Visible = false;
                            coincide.Visible = false;
                            cargarTablas();
                            habilitar(false);
                        }

                    }
                    else
                    {
                        usuario = new conexiones_BD.clases.usuarios(idusuario, txtNombre.Text, listaEmpleado.SelectedValue.ToString(), listaGrupos.SelectedValue.ToString(), estado());
                        if (usuario.modificar(true) > 0)
                        {
                            vaciar();
                            txtRcontra.Text = "";
                            txtContra.Text = "";
                            cargarTablas();
                            habilitar(false);
                        }
                    }
                        
                    }
                }
            
        }

        private void EliminarUsuario()
        {
            if (MessageBox.Show("¿Desea eliminar este usuario?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                if (idusuario != null)
                {
                    usuario = new conexiones_BD.clases.usuarios(idusuario);
                    if (usuario.eliminar(true) > 0)
                    {
                        vaciar();
                        txtRcontra.Text = "";
                        txtContra.Text = "";
                        noCoincide.Visible = false;
                        coincide.Visible = false;
                        cargarTablas();
                        habilitar(false);
                    }
                }
            }

            
        }

        private string estado()
        {
            string estado = "";
            if (chkEstado.Checked)
            {
                estado = "1";
            }
            else
            {
                estado = "2";
            }

            return estado;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (modificar)
            {
                modificarUsuario();
            }else
            {
                guardarUsuario();
            }
            
        }

        private void tabla_usuarios_Click(object sender, EventArgs e)
        {
            if (modificar)
            {
                idusuario = tabla_usuarios.CurrentRow.Cells[0].Value.ToString();
                txtNombre.Text = tabla_usuarios.CurrentRow.Cells[1].Value.ToString();
                nombre = tabla_usuarios.CurrentRow.Cells[1].Value.ToString();
                listaEmpleado.SelectedValue = tabla_usuarios.CurrentRow.Cells[4].Value.ToString();
                listaGrupos.SelectedValue = tabla_usuarios.CurrentRow.Cells[5].Value.ToString();
                if (tabla_usuarios.CurrentRow.Cells[2].Value.ToString().Equals("Activo"))
                {
                    chkEstado.Checked = true;
                }else
                {
                    chkEstado.Checked = false;
                }

                habilitar(true);
                txtContra.Enabled = false;
                txtRcontra.Enabled = false;
                mostrar.Enabled = false;
                mostrar2.Enabled = false;
                noCoincide.Visible = false;
                coincide.Visible = false;
                txtContra.Text = "";
                txtRcontra.Text="";
                chkCambiarC.Checked = false;

                
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            tabla.FiltrarLocalmente();
        }

        private void chkCambiarC_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCambiarC.Checked)
            {
                txtContra.Enabled = true;
                txtRcontra.Enabled = true;
                mostrar.Enabled = true;
                mostrar2.Enabled = true;
            }
            else
            {
                txtContra.Enabled = false;
                txtRcontra.Enabled = false;
                mostrar.Enabled = false;
                mostrar2.Enabled = false;
            }
        }




    }
}
