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
    public partial class permisos : Form
    {
        private bool actualizar;
        private string idpermiso;
        
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
        public string Idpermiso
        {
            get
            {
                return idpermiso;
            }

            set
            {
                idpermiso = value;
            }
        }

        conexiones_BD.clases.permisos permiso;
        utilitarios.cargar_tablas tabla;

        public permisos()
        {
            InitializeComponent();
            
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            gadgets.movimimientos mov = new gadgets.movimimientos();
            mov.moverFormulario(sender, e, this);
                
        }

        private void permisos_Load(object sender, EventArgs e)
        {
            gadgets.horientaciones_textos.colocarTitulo(panelTitulo, lblEncanezado);
            
            tabla = new utilitarios.cargar_tablas(tablaPermisos, txtBuscar, conexiones_BD.clases.permisos.datosTabla(), "nombre", lblNumeroR);
            tabla.cargar();

            if (actualizar)
            {
                btnGuardar.Text = "Actualizar";
                btnCancelar.Text = "Eliminar";
                Habilitando(false);
            }
        }

        private void guardarNuevoPermiso()
        {

            if (validarExistencia())
            {

            }else
            {
            permiso = new conexiones_BD.clases.permisos(txtPermiso.Text, txtDescripcion.Text, txtControl.Text);
            long res = permiso.guardar(true);
                if (res>0) {
                    tabla = new utilitarios.cargar_tablas(tablaPermisos, txtBuscar, conexiones_BD.clases.permisos.datosTabla(), "nombre", lblNumeroR);
                    tabla.cargar();
                    vaciando();
                }
            }

        }

        private void modificarPermisos()
        {
            permiso = new conexiones_BD.clases.permisos(idpermiso, txtPermiso.Text, txtDescripcion.Text, txtControl.Text);
            Int32 res = permiso.modificar(true);
            if (res>0)
            {
                tabla = new utilitarios.cargar_tablas(tablaPermisos, txtBuscar, conexiones_BD.clases.permisos.datosTabla(), "nombre", lblNumeroR);
                tabla.cargar();
                vaciando();
                Habilitando(false);
            }

        }

        private void eliminarPermisos()
        {
            permiso = new conexiones_BD.clases.permisos(idpermiso);
            Int32 res = permiso.eliminar(true);

            if (res > 0)
            {
                tabla = new utilitarios.cargar_tablas(tablaPermisos, txtBuscar, conexiones_BD.clases.permisos.datosTabla(), "nombre", lblNumeroR);
                tabla.cargar();
                vaciando();
                Habilitando(false);
            }
        }

        private void vaciando()
        {
            List<Control> c = new List<Control>();
            c.Add(txtPermiso);
            c.Add(txtDescripcion);
            c.Add(txtControl);


            utilitarios.vaciando_formularios.vaciarTexbox(c);

            txtPermiso.Focus();
        }

        private void Habilitando(bool r)
        {
            List<Control> c = new List<Control>();
            c.Add(txtPermiso);
            c.Add(txtDescripcion);
            c.Add(txtControl);
            c.Add(btnGuardar);
            c.Add(btnCancelar);

            utilitarios.vaciando_formularios.habilitandoTexbox(c, r);

        }

        private bool validarExistencia()
        {
            List<string> campos = new List<string>();
            campos.Add("nombre");
            campos.Add("nombre_control");

            List<string> valores = new List<string>();
            valores.Add(txtPermiso.Text);
            valores.Add(txtControl.Text);

            permiso = new conexiones_BD.clases.permisos(campos, valores);

            if (actualizar)
            {
                if (permiso.validarCamposcondicorAND(true) >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (permiso.validarCamposcondicorOR(true) > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            
        }

        private void tablaPermisos_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (actualizar)
                {
                    idpermiso = tablaPermisos.CurrentRow.Cells[0].Value.ToString();
                    txtPermiso.Text = tablaPermisos.CurrentRow.Cells[1].Value.ToString();
                    txtDescripcion.Text = tablaPermisos.CurrentRow.Cells[2].Value.ToString();
                    txtControl.Text = tablaPermisos.CurrentRow.Cells[3].Value.ToString();

                    btnGuardar.Enabled = true;
                    btnCancelar.Enabled = true;
                    Habilitando(true);
                }
            }
            catch
            {

            }
        }

        private void txtBuscar_TextChanged_1(object sender, EventArgs e)
        {
            tabla.FiltrarLocalmente();
        }

        private bool validar()
        {
            List<TextBox> textos = new List<TextBox>();
            textos.Add(txtPermiso);
            textos.Add(txtControl);
            textos.Add(txtDescripcion);

            return utilitarios.vaciando_formularios.validando(textos, error);

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validar())
            {

            }
            else
            {
                if (actualizar)
                {
                    if (validarExistencia())
                    {

                    }
                    else
                    {
                        if (MessageBox.Show("Es posible que algun registro se duplique." + Environment.NewLine + " ¿Deseas modificar el registro?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                        {
                            modificarPermisos();
                        }
                    }


                }
                else
                {
                    guardarNuevoPermiso();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (actualizar)
            {
                if (MessageBox.Show("¿Deseas eliminar este registro?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                {
                    eliminarPermisos();
                }
            }
            else
            {
                this.Close();
            }
        }
    }
}
