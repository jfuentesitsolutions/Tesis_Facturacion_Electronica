using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace control_principal
{
    public partial class configuraciones_iniciales : Form
    {

        conexiones_BD.Conexion con = new conexiones_BD.Conexion();
        string dires, based, usu, cont;

        bool configurado=false;

        public bool Configurado
        {
            get
            {
                return configurado;
            }

            set
            {
                configurado = value;
            }
        }

        public configuraciones_iniciales()
        {
            InitializeComponent();
        }

        public void cheCarForm(Form frmhijo, Form frmpapa)
        {
            Int32 c=0;
            bool cargado = false;

            foreach (Form llamado in frmpapa.MdiChildren)
            {        
                c++;   
            }

            if (c>0)
            {
                cargado = true;
                
            }

            if (!cargado)
            {
                frmhijo.MdiParent = frmpapa;
                frmhijo.Location = new Point(0,0);
                frmhijo.Show();
            }
        }

        private void configuraciones_iniciales_Load(object sender, EventArgs e)
        {
            gadgets.horientaciones_textos.colocarTitulo(panelSuperior, lblTitulo);
        }  

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            gadgets.movimimientos mov = new gadgets.movimimientos();
            mov.moverFormulario(sender, e, this);
        }

        private void btnGrupos_Click_1(object sender, EventArgs e)
        {

            if (pruebaConexion())
            {
                interfaces.mantenimientos.empresa empre = new interfaces.mantenimientos.empresa();
                cheCarForm(empre, this);
            }else
            {
                MessageBox.Show("No hay conexión con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

            
        }

        private bool pruebaConexion()
        {
            cargarDatosRegistro();
            bool detectado = false;

            try
            {
                detectado = con.conectarInstantanea(dires, based, usu, cont);
            }
            catch
            { 
                detectado = false; 
            }

            return detectado;
        }

        private void btnUnidades_Click_1(object sender, EventArgs e)
        {
            if (pruebaConexion())
            {
                interfaces.mantenimientos.sucursales suc = new interfaces.mantenimientos.sucursales();
                cheCarForm(suc, this);
            }else
            {
                MessageBox.Show("No hay conexión con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnEmpleados_Click_1(object sender, EventArgs e)
        {
            if (pruebaConexion())
            {
                interfaces.mantenimientos.empleados emp = new interfaces.mantenimientos.empleados();
                cheCarForm(emp, this);
            }else
            {
                MessageBox.Show("No hay conexión con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnUsuarios_Click_1(object sender, EventArgs e)
        {
            if (pruebaConexion())
            {
                interfaces.mantenimientos.usuarios usu = new interfaces.mantenimientos.usuarios();
                cheCarForm(usu, this);
            }else
            {
                MessageBox.Show("No hay conexión con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnConexion_Click_1(object sender, EventArgs e)
        {
            cargarDatosRegistro();
            bool detectado = false;

            try
            {
                detectado=con.conectarInstantanea(dires, based, usu, cont);
            }
            catch
            {
                detectado = false;
            }

            if (detectado)
            {
                if(MessageBox.Show("Ya esta conectado a una base, ¿Desea conectar a otra?","Conctado a la base "+based, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                {
                    interfaces.mantenimientos.conexion.conexion c = new interfaces.mantenimientos.conexion.conexion();
                    cheCarForm(c, this);
                }
            } else
            {
            interfaces.mantenimientos.conexion.conexion c = new interfaces.mantenimientos.conexion.conexion();
            cheCarForm(c, this);
            }
        }

        private void btnConfigurar_Click(object sender, EventArgs e)
        {
            if (pruebaConexion())
            {
                configuracion_inicial.config_inicial coi = new configuracion_inicial.config_inicial();
                cheCarForm(coi, this);
            }else
            {
                MessageBox.Show("No hay conexión con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void configuraciones_iniciales_FormClosing(object sender, FormClosingEventArgs e)
        {
            string lectura = (string)Registry.GetValue("HKEY_CURRENT_USER\\PuntoVentaGerardo\\configura", "ipservidor", "NE");
            string lectura2 = (string)Registry.GetValue("HKEY_CURRENT_USER\\PuntoVentaGerardo\\configura", "numero_sucursal", "NE");
            if (lectura==null || lectura.Equals("NE"))
            {
                if(MessageBox.Show("No has configurado la conexión a la base. ¿Deseas configurarla en este momento?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                {
                    btnConexion.PerformClick();
                    e.Cancel = true;
                }
            } else if(lectura2 == null || lectura2.Equals("NE"))
            {
                if (MessageBox.Show("No has establecido la configuraciones principales. ¿Deseas configurarlas en este momento?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                {
                    btnConfigurar.PerformClick();
                    e.Cancel = true;
                }
            }
            
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            interfaces.mantenimientos.base_datos.base_d dato = new  interfaces.mantenimientos.base_datos.base_d();
            cheCarForm(dato, this);
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPermisos_Click(object sender, EventArgs e)
        {
            interfaces.mantenimientos.permisos per = new interfaces.mantenimientos.permisos();
            per.Actualizar = false;
            cheCarForm(per,this);
        }

        private void cargarDatosRegistro()
        {
            dires = (string)Registry.GetValue("HKEY_CURRENT_USER\\PuntoVentaGerardo\\configura", "ipservidor", "NE");
            based = (string)Registry.GetValue("HKEY_CURRENT_USER\\PuntoVentaGerardo\\configura", "nombre_db", "NE");
            usu = (string)Registry.GetValue("HKEY_CURRENT_USER\\PuntoVentaGerardo\\configura", "usuario", "NE");
            cont = (string)Registry.GetValue("HKEY_CURRENT_USER\\PuntoVentaGerardo\\configura", "$$", "NE");
        }
    }
}
