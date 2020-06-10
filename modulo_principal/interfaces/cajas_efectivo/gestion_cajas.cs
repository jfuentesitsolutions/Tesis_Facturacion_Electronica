using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfaces.cajas_efectivo
{
    public partial class Imagenes : Form
    {
        sessionManager.secion sesion = sessionManager.secion.Instancia;
        string idcaja="0";
        ListViewGroup grupo1;
        DataTable cajas;
        public Imagenes()
        {
            InitializeComponent();
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Imagenes_Load(object sender, EventArgs e)
        {
            grupo1 = new ListViewGroup("Cajas abiertas", HorizontalAlignment.Center);
            lista_cajas.Groups.Add(grupo1);
            lista_cajas.LargeImageList = lista_imagenes;
            this.colocandoCajasActivas();
        }

        private void colocandoCajasActivas()
        {
            cajas = conexiones_BD.clases.cajas.datosTabla(sesion.DatosRegistro[6]);
            if (cajas.Rows.Count==1)
            {
                lista_cajas.Items.Clear();
                lista_cajas.Items.Add(new ListViewItem(cajas.Rows[0][4].ToString(),0, grupo1));
                lblNombre.Text = cajas.Rows[0][4].ToString();
                efectivo_inicial.Value = Convert.ToDecimal(cajas.Rows[0][5].ToString());
                idcaja = cajas.Rows[0][0].ToString();
                btnAbrir.Enabled = false;
                btnCerrar.Enabled = true;
                btnRevisar.Enabled = true;
            }
            else if(cajas.Rows.Count==0)
            {
                    lista_cajas.Items.Clear();
                    btnCerrar.Enabled = false;
                    btnRevisar.Enabled = false;
                btnAbrir.Enabled = true;
                    lblNombre.Text = sesion.DatosRegistro[6];
                efectivo_inicial.Value = 0;
                efectivo_inicial.Enabled = true;  

            }
            else if (cajas.Rows.Count > 1)
            {
                MessageBox.Show("Hemos detectado mas de una caja con el mismo nombre.\nPorfavor elimine una", "Caja duplicada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lista_cajas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas cambiar la caja?", "Cambio de caja", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                    cajas = conexiones_BD.clases.cajas.datosTabla(lista_cajas.SelectedItems[0].Text);
                btnAbrir.Enabled = false;
                btnCerrar.Enabled = true;
                btnRevisar.Enabled = true;
                    if (cajas.Rows.Count > 0)
                    {
                        idcaja = cajas.Rows[0][0].ToString();
                        lblNombre.Text = cajas.Rows[0][4].ToString();
                        efectivo_inicial.Value = Convert.ToDecimal(cajas.Rows[0][5].ToString());
                    }
            }
        }

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            gadgets.movimimientos mov = new gadgets.movimimientos();
            mov.moverFormulario(sender, e, this);
        }

        

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea aperturar la "+sesion.DatosRegistro[6]+" con un saldo de $"+efectivo_inicial.Value, "Apertura de caja", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                DateTime fecha_hora = DateTime.Now;
                conexiones_BD.clases.cajas cajas = new conexiones_BD.clases.cajas(
                    fecha_hora.ToString("yyyy-MM-dd hh:mm:ss"),
                    fecha_hora.ToString("yyyy-MM-dd hh:mm:ss"),
                    "1",
                    lblNombre.Text,
                    efectivo_inicial.Value.ToString(),
                    sesion.Datos[6]
                    );

                long id = cajas.guardar(false);

                if (id>0)
                {
                    MessageBox.Show("Caja abierta con exíto", "Caja abierta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    colocandoCajasActivas();
                    sesion.Caja_activa = true;
                    sesion.Idcaja = id.ToString();
                }

                
            }
        }

        private void btnRevisar_Click(object sender, EventArgs e)
        {
            revisar_caja frm = new revisar_caja();
            frm.Revisar = true;
            frm.Idcaja = idcaja;
            frm.EfectivoI = efectivo_inicial.Value.ToString();
            Console.WriteLine(idcaja);
            frm.Nombre_caja = lblNombre.Text;
            frm.ShowDialog();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            conexiones_BD.clases.cajas caja = new conexiones_BD.clases.cajas(
                cajas.Rows[0][0].ToString(),
                cajas.Rows[0][1].ToString(),
                "",
                cajas.Rows[0][3].ToString(),
                cajas.Rows[0][4].ToString(),
                cajas.Rows[0][5].ToString(),
                cajas.Rows[0][6].ToString());
            revisar_caja frm = new revisar_caja();
            frm.Idcaja = idcaja;
            frm.EfectivoI = efectivo_inicial.Value.ToString();
            frm.Caja = caja;
            frm.Nombre_caja = lblNombre.Text;
            frm.ShowDialog();

            if (frm.Cerrada)
            {
                colocandoCajasActivas();
                chkTodos.Checked = false;
            }
        }

        private void chkTodos_CheckedChanged(object sender, EventArgs e)
        {
            
            if (chkTodos.Checked)
            {
                cajas = conexiones_BD.clases.cajas.datosTabla();
                lista_cajas.Items.Clear();

                foreach (DataRow fila in cajas.Rows)
                {
                    lista_cajas.Items.Add(new ListViewItem(fila[4].ToString(), 0, grupo1));
                }
            }
            else
            {
                colocandoCajasActivas();
            }
        }

        private void btnCajasC_Click(object sender, EventArgs e)
        {
            cajas_cerradas frm = new cajas_cerradas();
            frm.ShowDialog();
        }
    }
}
