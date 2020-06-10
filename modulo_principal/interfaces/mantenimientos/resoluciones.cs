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
    public partial class resoluciones : Form
    {
        bool modificar = false;
        sessionManager.secion sesion = sessionManager.secion.Instancia;
        utilitarios.cargar_tablas tabla;

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

        public resoluciones()
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

        private void resoluciones_Load(object sender, EventArgs e)
        {
            gadgets.horientaciones_textos.colocarTitulo(panelTitulo, lblEncanezado);
            cargandoTabla();
            if (modificar)
            {
                txtNombre.ReadOnly = true;
                btnGuardar.Text = "Modificar";
            }
        }

        private bool validar()
        {
            bool valido = false;
            error.Clear();
            List<TextBox> textos = new List<TextBox>();
            textos.Add(txtNombre);
            textos.Add(serieConFinal);
            textos.Add(serieCredi);
            textos.Add(txtDescripcion);

            valido = utilitarios.vaciando_formularios.validando(textos, error);

            if (inicioConfinal.Value == 0)
            {
                valido = true;
                error.SetError(inicioConfinal, "No puede quedar a cero el correlativo");
            }

            if (finalConFinal.Value == 0)
            {
                valido = true;
                error.SetError(finalConFinal, "No puede quedar a cero el correlativo");
            }

            if (numSiguiConFinal.Value == 0)
            {
                valido = true;
                error.SetError(numSiguiConFinal, "No puede quedar a cero el numero siguiente");
            }

            if (inicioCredi.Value == 0)
            {
                valido = true;
                error.SetError(inicioCredi, "No puede quedar a cero el correlativo");
            }

            if (finalCredi.Value == 0)
            {
                valido = true;
                error.SetError(finalCredi, "No puede quedar a cero el correlativo");
            }

            if (siguiCredi.Value == 0)
            {
                valido = true;
                error.SetError(siguiCredi, "No puede quedar a cero el numero siguiente");
            }

            return valido;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string activo = "";
            if (chkEstado.Checked)
            {
                activo = "1";
            }
            else
            {
                activo = "2";
            }
            if (!validar())
            {
                if (!modificar)
                {
                    conexiones_BD.clases.resoluciones res = new conexiones_BD.clases.resoluciones(
                        txtNombre.Text,
                        fechaResolucion.Value.ToString("yyyy-MM-dd hh:mm:ss"),
                        serieConFinal.Text,
                        serieCredi.Text,
                        inicioConfinal.Value.ToString(),
                        finalConFinal.Value.ToString(),
                        numSiguiConFinal.Value.ToString(),
                        fechaUltimoConFinal.Value.ToString("yyyy-MM-dd hh:mm:ss"),
                        inicioCredi.Value.ToString(),
                        finalCredi.Value.ToString(),
                        siguiCredi.Value.ToString(),
                        fechaSiguiCredi.Value.ToString("yyyy-MM-dd hh:mm:ss"),
                        txtDescripcion.Text,
                        activo,
                        false
                        );

                    conexiones_BD.operaciones op = new conexiones_BD.operaciones();

                    if (!sesion.Correlativos_activos)
                    {
                        if (op.insertar2(res.sentenciaIngresar()) > 0)
                        {
                            MessageBox.Show("Resolución ingresada", "Ingreso exítoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            sesion.Correlativos_activos = chkEstado.Checked;
                            vaciandoDatos();
                            recargarTabla();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo ingresar la resolución", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }else
                    {
                        MessageBox.Show("No puedes volver a poner una nueva resolución mientra hay una activa", "resolución activa", MessageBoxButtons.OK,MessageBoxIcon.Stop);
                    }
                    
                } else
                {
                    conexiones_BD.clases.resoluciones res = new conexiones_BD.clases.resoluciones(
                        txtNombre.Text,
                        fechaResolucion.Value.ToString("yyyy-MM-dd hh:mm:ss"),
                        serieConFinal.Text,
                        serieCredi.Text,
                        inicioConfinal.Value.ToString(),
                        finalConFinal.Value.ToString(),
                        numSiguiConFinal.Value.ToString(),
                        fechaUltimoConFinal.Value.ToString("yyyy-MM-dd hh:mm:ss"),
                        inicioCredi.Value.ToString(),
                        finalCredi.Value.ToString(),
                        siguiCredi.Value.ToString(),
                        fechaSiguiCredi.Value.ToString("yyyy-MM-dd hh:mm:ss"),
                        txtDescripcion.Text,
                        activo,
                        true
                        );

                    if (res.actualizar_datos())
                    {
                        MessageBox.Show("Resolución modificada", "Modificación exítosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        sesion.Correlativos_activos = chkEstado.Checked;
                        vaciandoDatos();
                        recargarTabla();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo modificar la resolución", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void cargandoTabla()
        {
            tabla = new utilitarios.cargar_tablas(tabla_resoluciones, txtBuscar, conexiones_BD.clases.resoluciones.datos_todas_las_resoluciones(), "numero_resolucion");
            tabla.cargarSinContadorRegistros();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            tabla.FiltrarLocalmenteSinContadorRegistros();
        }

        private void tabla_resoluciones_DoubleClick(object sender, EventArgs e)
        {
            if (modificar && tabla_resoluciones.RowCount != 0)
            {
                txtNombre.Text = tabla_resoluciones.CurrentRow.Cells[0].Value.ToString();
                fechaResolucion.Text = tabla_resoluciones.CurrentRow.Cells[1].Value.ToString();
                serieConFinal.Text = tabla_resoluciones.CurrentRow.Cells[2].Value.ToString();
                serieCredi.Text = tabla_resoluciones.CurrentRow.Cells[3].Value.ToString();
                inicioConfinal.Value = Convert.ToDecimal(tabla_resoluciones.CurrentRow.Cells[4].Value.ToString());
                finalConFinal.Value = Convert.ToDecimal(tabla_resoluciones.CurrentRow.Cells[5].Value.ToString());
                numSiguiConFinal.Value = Convert.ToDecimal(tabla_resoluciones.CurrentRow.Cells[6].Value.ToString());
                fechaUltimoConFinal.Text = tabla_resoluciones.CurrentRow.Cells[7].Value.ToString();
                inicioCredi.Value = Convert.ToDecimal(tabla_resoluciones.CurrentRow.Cells[8].Value.ToString());
                finalCredi.Value = Convert.ToDecimal(tabla_resoluciones.CurrentRow.Cells[9].Value.ToString());
                siguiCredi.Value = Convert.ToDecimal(tabla_resoluciones.CurrentRow.Cells[10].Value.ToString());
                fechaSiguiCredi.Text = tabla_resoluciones.CurrentRow.Cells[11].Value.ToString();
                txtDescripcion.Text = tabla_resoluciones.CurrentRow.Cells[12].Value.ToString();
                if (tabla_resoluciones.CurrentRow.Cells[13].Value.ToString().Equals("SI"))
                {
                    chkEstado.Checked = true;
                }else
                {
                    chkEstado.Checked = false;
                }
            }
        }

        private void recargarTabla()
        {
            tabla_resoluciones.DataSource = null;
            tabla.ContenidoTabla.DataSource = null;
            tabla.TablaDatos = conexiones_BD.clases.resoluciones.datos_todas_las_resoluciones();
            tabla.cargarSinContadorRegistros();
        }

        private void vaciandoDatos()
        {
            List<Control> texto = new List<Control>();
            texto.Add(txtNombre);
            texto.Add(serieConFinal);
            texto.Add(serieCredi);
            texto.Add(txtDescripcion);

            utilitarios.vaciando_formularios.vaciarTexbox(texto);

            inicioConfinal.Value = 0;
            finalConFinal.Value = 0;
            numSiguiConFinal.Value = 0;
            inicioCredi.Value = 0;
            finalCredi.Value = 0;
            siguiCredi.Value = 0;
            chkEstado.Checked = false;

        }
    }
}
