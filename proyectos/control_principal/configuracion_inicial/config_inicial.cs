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

namespace control_principal.configuracion_inicial
{
    public partial class config_inicial : Form
    {

        public config_inicial()
        {
            InitializeComponent();
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            gadgets.movimimientos mov = new gadgets.movimimientos();
            mov.moverFormulario(sender, e, this);
        }

        private void config_inicial_Load(object sender, EventArgs e)
        {
            gadgets.horientaciones_textos.colocarTitulo(panelTitulo, lblEncanezado);
            cargarListas();
            List<string> dato = leerConfiguracion();

            if (dato.Count>0)
            {
                listaSucursal.SelectedValue = dato[0];
                txtDireccion.Text = dato[1];
                txtTelefono.Text = dato[2];
                listaEmpleados.SelectedValue = dato[3];
                fecha.Text = dato[4];
                txtEncargado.Text = dato[5];
                txtNombre_equipo.Text = dato[6];
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!validar())
            {
                guardarConfiguracion();
            }
        }

        private void guardarConfiguracion()
        {
            RegistryKey rk = Registry.CurrentUser.CreateSubKey(@"PuntoVentaGerardo\configura");

            rk.SetValue("numero_sucursal", listaSucursal.Text);
            rk.SetValue("idsucursal", listaSucursal.SelectedValue.ToString());
            rk.SetValue("direccion", txtDireccion.Text);
            rk.SetValue("telefono", txtTelefono.Text);
            rk.SetValue("encargado_sucursal", listaEmpleados.Text);
            rk.SetValue("idempleado", listaEmpleados.SelectedValue.ToString());
            rk.SetValue("fecha_instalacion", fecha.Text);
            rk.SetValue("encargado_instalacion", txtEncargado.Text);
            rk.SetValue("nombre_del_equipo", txtNombre_equipo.Text);
            rk.Close();

            string lectura = (string)Registry.GetValue("HKEY_CURRENT_USER\\PuntoVentaGerardo\\configura", "numero_sucursal", "NE");

            if (lectura.Equals("NE"))
            {
                MessageBox.Show("No se pudo guardar la configuración", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("La configuración se guardo con exíto", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                configuraciones_iniciales padre = (configuraciones_iniciales)this.MdiParent;
                padre.Configurado = true;
               
                this.Close();
            }
        }

        private List<string> leerConfiguracion()
        {
            List<string> datos = new List<string>();

            string lectura = (string)Registry.GetValue("HKEY_CURRENT_USER\\PuntoVentaGerardo\\configura", "idsucursal", "NE");
            if (!lectura.Equals("NE"))
            {
                datos.Add((string)Registry.GetValue("HKEY_CURRENT_USER\\PuntoVentaGerardo\\configura", "idsucursal", "NE"));
                datos.Add((string)Registry.GetValue("HKEY_CURRENT_USER\\PuntoVentaGerardo\\configura", "direccion", "NE"));
                datos.Add((string)Registry.GetValue("HKEY_CURRENT_USER\\PuntoVentaGerardo\\configura", "telefono", "NE"));
                datos.Add((string)Registry.GetValue("HKEY_CURRENT_USER\\PuntoVentaGerardo\\configura", "idempleado", "NE"));
                datos.Add((string)Registry.GetValue("HKEY_CURRENT_USER\\PuntoVentaGerardo\\configura", "fecha_instalacion", "NE"));
                datos.Add((string)Registry.GetValue("HKEY_CURRENT_USER\\PuntoVentaGerardo\\configura", "encargado_instalacion", "NE"));
                datos.Add((string)Registry.GetValue("HKEY_CURRENT_USER\\PuntoVentaGerardo\\configura", "nombre_del_equipo", "NE"));
            }

            return datos;
        }

        private void cargarListas()
        {
            utilitarios.cargandoListas.cargarLista(conexiones_BD.clases.sucursales.datosTabla(),listaSucursal ,"numero_de_sucursal", "idsucursal");
            utilitarios.cargandoListas.cargarLista(conexiones_BD.clases.empleados_sucursales.datosTabla(), listaEmpleados, "nombres", "idempleado_sucursal");
        }

        private bool validar()
        {
            bool valido = false;
            List<TextBox> control = new List<TextBox>();
            control.Add(txtDireccion);
            control.Add(txtTelefono);
            control.Add(txtEncargado);
            control.Add(txtNombre_equipo);

            valido=utilitarios.vaciando_formularios.validando(control, error);

            if (listaSucursal.SelectedIndex == -1)
            {
                valido = true;
                error.SetError(listaSucursal, "No debes dejar este campo en blanco");
            }

            if (listaEmpleados.SelectedIndex == -1)
            {
                valido = true;
                error.SetError(listaEmpleados, "No debes dejar este campo en blanco");
            }

            return valido;
        }
    }
}
