using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfaces.mantenimientos.auxiliares
{
    public partial class cuentas_proveedores : Form
    {
        string idproveedor="0";
        bool modificar = false;
        conexiones_BD.clases.cuentas_proveedores cuentas;
        utilitarios.cargar_tablas tabla;
        string idcuenta_proveedor=null;
        bool cuentasAgregadas = false;
        DataGridView tabla2=null;

        public string Idproveedor
        {
            get
            {
                return idproveedor;
            }

            set
            {
                idproveedor = value;
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

        public bool CuentasAgregadas
        {
            get
            {
                return cuentasAgregadas;
            }

            set
            {
                cuentasAgregadas = value;
            }
        }

        public DataGridView Tabla2
        {
            get
            {
                return tabla2;
            }

            set
            {
                tabla2 = value;
            }
        }

        public cuentas_proveedores()
        {
            InitializeComponent();
        }

        private void cuentas_proveedores_Load(object sender, EventArgs e)
        {
            gadgets.horientaciones_textos.colocarTitulo(panelTitulo, lblEncanezado);
            if (modificar)
            {
                btnCancel.Text = "Modificar";
                cargarTablas();
                cargarLista();
                habilitar(false);
            }else
            {
                cargarLista();
                lblReg.Visible = false;
                if (tabla2 != null)
                {
                    foreach(DataGridViewRow fila in tabla2.Rows)
                    {
                        tablaCuentas.Rows.Add(fila.Cells[0].Value.ToString(),
                            fila.Cells[1].Value.ToString(),
                            fila.Cells[2].Value.ToString(),
                            fila.Cells[3].Value.ToString(),
                            fila.Cells[4].Value.ToString());
                    }
                }

            }

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

        private void btnBancoNuevo_Click(object sender, EventArgs e)
        {
            bancos banco = new bancos();
            banco.ShowDialog();
            cargarLista();
        }

        private void cargarTablas()
        {
            tabla = new utilitarios.cargar_tablas(tablaCuentas, txtBuscar, conexiones_BD.clases.cuentas_proveedores.datosTabla(Idproveedor), "nombre", lblReg);
            tabla.cargar();
        }

        private void habilitar(bool co)
        {
            List<Control> controles = new List<Control>();
            controles.Add(listaBanco);
            controles.Add(txtNumCuenta);
            controles.Add(btnBancoNuevo);
            controles.Add(btnGuardar);
            controles.Add(agre);
            controles.Add(quit);

            utilitarios.vaciando_formularios.habilitandoTexbox(controles, co);
        }

        private bool validar()
        {
            bool valido = false;
            List<TextBox> controles = new List<TextBox>();
            controles.Add(txtNumCuenta);

            valido = utilitarios.vaciando_formularios.validando(controles, error);

            if (listaBanco.SelectedIndex == -1)
            {
                valido = true;
                error.SetError(listaBanco, "Tienes que elejir un banco");
            }

            return valido;
        }

        private void vaciarDatos()
        {
            List<Control> controles = new List<Control>();
            controles.Add(txtNumCuenta);
            utilitarios.vaciando_formularios.vaciarTexbox(controles);
            listaBanco.SelectedValue = "0";
        }

        private bool validarExistencias(bool actu)
        {
            bool existe = false;

            List<string> campos = new List<string>();
            campos.Add("idbanco");
            campos.Add("numero_cuenta");
            List<string> valores = new List<string>();
            valores.Add(listaBanco.SelectedValue.ToString());
            valores.Add(txtNumCuenta.Text);

            cuentas = new conexiones_BD.clases.cuentas_proveedores(campos, valores);

            if (actu)
            {
                if (cuentas.validarCamposcondicorANDActu(true, 1) > 1)
                {
                    existe = true;
                }
            }
            else
            {
                if (cuentas.validarCamposcondicorAND(true) > 0)
                {
                    existe = true;
                }
            }

            return existe;
        }

        private void guardar()
        {
            if (Modificar)
            {
                if (!validar())
                {
                    if (!validarExistencias(false))
                    {
                        cuentas = new conexiones_BD.clases.cuentas_proveedores(idproveedor, listaBanco.SelectedValue.ToString(),txtNumCuenta.Text);
                        if (cuentas.guardar(true) > 0)
                        {
                            vaciarDatos();
                            cargarTablas();
                            listaBanco.Focus();
                        }
                    }
                }
            }
            else
            {
                if (!validar())
                {
                        tablaCuentas.Rows.Add("0", listaBanco.Text, txtNumCuenta.Text, "0", listaBanco.SelectedValue.ToString());
                        vaciarDatos();
                }
            }
            
        }

        private void modifica()
        {
            if (Modificar)
            {
                if (!validar())
                {
                    if (!validarExistencias(true))
                    {
                        cuentas = new conexiones_BD.clases.cuentas_proveedores(idcuenta_proveedor,idproveedor ,listaBanco.SelectedValue.ToString(), txtNumCuenta.Text);
                        if (cuentas.modificar(true) > 0)
                        {
                            habilitar(false);
                            vaciarDatos();
                            cargarTablas();
                        }

                    }
                }
            }
            
            
        }

        private void eliminar()
        {
            if (idcuenta_proveedor != null)
            {
                cuentas = new conexiones_BD.clases.cuentas_proveedores(idcuenta_proveedor);
                if (cuentas.eliminar(true) > 0)
                {
                    if (tablaCuentas.Rows.Count==0)
                    {
                        habilitar(true);
                    }
                    else{
                        habilitar(false);
                    }
                    
                    vaciarDatos();
                    cargarTablas();
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (tablaCuentas.Rows.Count != 0)
            {
                cuentasAgregadas = true;
                this.Close();
            }else
            {
                MessageBox.Show("Tienen que agregar una cuenta", "No hay cuenta asignada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (!modificar)
            {
                tabla.FiltrarLocalmente();
            }
            
        }

        private void cargarLista()
        {
            utilitarios.cargandoListas.cargarLista(conexiones_BD.clases.bancos.datosTabla(), listaBanco, "nombre", "idbanco");

        }

        private void tablaCuentas_Click(object sender, EventArgs e)
        {
            if (modificar)
            {
                try
                {
                    habilitar(true);
                    idcuenta_proveedor = tablaCuentas.CurrentRow.Cells[0].Value.ToString();
                    listaBanco.SelectedValue = tablaCuentas.CurrentRow.Cells[4].Value.ToString();
                    idproveedor = tablaCuentas.CurrentRow.Cells[3].Value.ToString();
                    txtNumCuenta.Text = tablaCuentas.CurrentRow.Cells[2].Value.ToString();
                }
                catch
                {

                }
                
            }
            

        }

        private void agre_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void quit_Click(object sender, EventArgs e)
        {
            try
            {
                if (Modificar)
                {
                    eliminar();
                }
                else
                {
                    tablaCuentas.Rows.RemoveAt(tablaCuentas.CurrentRow.Index);
                }
            }
            catch
            {

            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (modificar)
            {
                modifica();
            }
            else
            {
                btnGuardar.PerformClick();
            }
        }
    }
}
