using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using utilitarios;
using gadgets;
using conexiones_BD.clases;

namespace interfaces.compras.auxiliares
{
    public partial class producto_unica_presentacion : Form
    {
        string idsp = null;
        string idud, idum, prese, precioCD, precioCM, canti;
        string codigo = null;
        bool cargado = false, modificar=false;
        List<presentaciones_productos> presenta= new List<presentaciones_productos>();
        bool listo = false;

        public string Idsp
        {
            get
            {
                return idsp;
            }

            set
            {
                idsp = value;
            }
        }

        public string Idud
        {
            get
            {
                return idud;
            }

            set
            {
                idud = value;
            }
        }

        public string Idum
        {
            get
            {
                return idum;
            }

            set
            {
                idum = value;
            }
        }

        public string Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;
            }
        }

        public List<presentaciones_productos> Presenta
        {
            get
            {
                return presenta;
            }

            set
            {
                presenta = value;
            }
        }

        public bool Listo
        {
            get
            {
                return listo;
            }

            set
            {
                listo = value;
            }
        }

        public string Prese
        {
            get
            {
                return prese;
            }

            set
            {
                prese = value;
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

        public string PrecioCD
        {
            get
            {
                return precioCD;
            }

            set
            {
                precioCD = value;
            }
        }

        public string PrecioCM
        {
            get
            {
                return precioCM;
            }

            set
            {
                precioCM = value;
            }
        }

        public string Canti
        {
            get
            {
                return canti;
            }

            set
            {
                canti = value;
            }
        }

        public producto_unica_presentacion()
        {
            InitializeComponent();
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            if (!validar())
            {
                generarNuevosPrecios();
                Listo = true;
                this.Close();
            }
        }

        private void producto_unica_presentacion_Load(object sender, EventArgs e)
        {
            horientaciones_textos.colocarTitulo(panelTitulo, lblExis);
            
            if (modificar)
            {
                compraMayoreo.Value = Convert.ToDecimal(precioCM);
                compraDetalle.Value = Convert.ToDecimal(precioCD);
                txtCantidad.Value = Convert.ToDecimal(canti);
                this.cargarListas();
                calcularPreciosventas2();
                this.cargarTablas();
                this.colocarPreciosModificados();
            }else
            {
                this.cargarListas();
                this.cargarTablas();
            }
        }

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            movimimientos mov = new movimimientos();
            mov.moverFormulario(sender, e, this);
        }

        private void cargarListas()
        {
            if (modificar)
            {
                cargandoListas.cargarLista(presentaciones_productos.presentacionesXproductoXcantidad(Idsp), listaPresentaciones, "nombre", "idsp");
                int index = listaPresentaciones.FindStringExact(prese);
                listaPresentaciones.SelectedIndex = index;
                cargandoListas.cargarLista(utilidades.datosTablaDetalle(), listaUDetalle, "nombre", "idutilidad_compra");
                listaUDetalle.SelectedValue = Idud;
                cargandoListas.cargarLista(utilidades.datosTablaMayoreo(), listaUMayoreo, "nombre", "idutilidad_compra");
                listaUMayoreo.SelectedValue = Idum;
                cargado = true;
            }
            else
            {
                cargandoListas.cargarLista(presentaciones_productos.presentacionesXproductoXcantidad(Idsp), listaPresentaciones, "nombre", "idsp");
                listaPresentaciones.SelectedIndex = 0;
                cargandoListas.cargarLista(utilidades.datosTablaDetalle(), listaUDetalle, "nombre", "idutilidad_compra");
                listaUDetalle.SelectedValue = Idud;
                cargandoListas.cargarLista(utilidades.datosTablaMayoreo(), listaUMayoreo, "nombre", "idutilidad_compra");
                listaUMayoreo.SelectedValue = Idum;
                cargado = true;
            }
            
        }

        private void btnAgr_Click(object sender, EventArgs e)
        {
            mantenimientos.procesos_iniciales.agregaPresentaciones ap = new mantenimientos.procesos_iniciales.agregaPresentaciones();
            ap.Codigo = codigo;
            ap.ShowDialog();
            if (ap.IngresadoN)
            {
                cargado = false;
                cargarTablas();
                cargarListas();
                cargado = true;
            }
        }

        private void cargarTablas()
        {
            if (tabla_presentaciones.RowCount==0)
            {
                DataTable pro_pre = presentaciones_productos.presentacionesXproducto(idsp);
                foreach (DataRow fila in pro_pre.Rows)
                {
                    tabla_presentaciones.Rows.Add(
                        fila[0].ToString(),
                        fila[2].ToString(),
                        fila[4].ToString(),
                        fila[3].ToString(),
                        fila[5].ToString()
                        );
                }
            }else
            {
                tabla_presentaciones.Rows.Clear();
                DataTable pro_pre = presentaciones_productos.presentacionesXproducto(idsp);
                foreach (DataRow fila in pro_pre.Rows)
                {
                    tabla_presentaciones.Rows.Add(
                        fila[0].ToString(),
                        fila[2].ToString(),
                        fila[4].ToString(),
                        fila[3].ToString(),
                        fila[5].ToString()
                        );
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!validar())
            {
                generarNuevosPrecios();
                Listo = true;
                this.Close();
            }
        }

        private bool validar()
        {
            bool valido = false;
            error.Clear();
            string mensaje = "Tienen que seleccionar una presentación.";
            string mensaje2 = "No puedes dejar el valor a 0";

            if (listaPresentaciones.SelectedValue==null)
            {
                valido = true;
                error.SetError(listaPresentaciones, mensaje);
            }
            if (compraMayoreo.Value==0)
            {
                valido = true;
                error.SetError(compraMayoreo, mensaje2);
            }
            if (compraDetalle.Value == 0)
            {
                valido = true;
                error.SetError(compraDetalle, mensaje2);
            }
            if (txtCantidad.Value == 0)
            {
                valido = true;
                error.SetError(txtCantidad, mensaje2);
            }
            if (ventaMayoreo.Value == 0)
            {
                valido = true;
                error.SetError(ventaMayoreo, mensaje2);
            }
            if (ventaDetalle.Value == 0)
            {
                valido = true;
                error.SetError(ventaDetalle, mensaje2);
            }


            return valido;
        }

        private void calcularPreciosventas()
        {
            DataRowView detalle = (DataRowView)listaUDetalle.SelectedItem;
            DataRowView mayoreo = (DataRowView)listaUMayoreo.SelectedItem;
            DataRowView comprDetalle = (DataRowView)listaPresentaciones.SelectedItem;

            
            double utiM=0.0, utiD=0.0;
            double pcM = 0.0, pcD = 0.0;

            utiM = Convert.ToDouble(mayoreo[3].ToString());
            utiD = Convert.ToDouble(detalle[3].ToString());
            pcM = Convert.ToDouble(compraMayoreo.Value);

            compraDetalle.Value = Round(Convert.ToDecimal(Math.Round((pcM / Convert.ToInt32(comprDetalle[2].ToString())), 2, MidpointRounding.AwayFromZero)));
            pcD = Convert.ToDouble(compraDetalle.Value);

            ventaMayoreo.Value = Convert.ToDecimal(Math.Round(((utiM * pcM) + pcM),2,MidpointRounding.AwayFromZero));
            ventaDetalle.Value = Convert.ToDecimal(Math.Round(((utiD * pcD) + pcD), 2, MidpointRounding.AwayFromZero));

            recalcularTotalesPresentaciones();
            redondearTabla();
        }

        private void calcularPreciosventas2()
        {
            DataRowView detalle = (DataRowView)listaUDetalle.SelectedItem;
            DataRowView mayoreo = (DataRowView)listaUMayoreo.SelectedItem;
            DataRowView comprDetalle = (DataRowView)listaPresentaciones.SelectedItem;


            double utiM = 0.0, utiD = 0.0;
            double pcM = 0.0, pcD = 0.0;

            utiM = Convert.ToDouble(mayoreo[3].ToString());
            utiD = Convert.ToDouble(detalle[3].ToString());
            pcM = Convert.ToDouble(compraMayoreo.Value);  
            pcD = Convert.ToDouble(compraDetalle.Value);

            ventaMayoreo.Value = Convert.ToDecimal(Math.Round(((utiM * pcM) + pcM), 2, MidpointRounding.AwayFromZero));
            ventaDetalle.Value = Convert.ToDecimal(Math.Round(((utiD * pcD) + pcD), 2, MidpointRounding.AwayFromZero));

            recalcularTotalesPresentaciones();
            redondearTabla();
        }

        private decimal Round(decimal value)
        {
            return Math.Round(value * 20) / 20;
        }

        private void recalcularTotalesPresentaciones()
        {
            DataRowView comprDetalle = (DataRowView)listaPresentaciones.SelectedItem;
            double precio = Convert.ToDouble(ventaDetalle.Value);
            double precio2 = Convert.ToDouble(ventaMayoreo.Value);
            Int32 cantidadP = Convert.ToInt32(comprDetalle[2].ToString());

            if (tabla_presentaciones.RowCount!=0)
            {
                foreach (DataGridViewRow fila in tabla_presentaciones.Rows)
                {
                    if (fila.Cells[4].Value.ToString().Equals("Detalle"))
                    {
                        Int32 cantidad = Convert.ToInt32(fila.Cells[3].Value);
                        if (cantidad<=cantidadP)
                        {
                            double pre = Math.Round((cantidad * precio), 2);
                            fila.Cells[2].Value = pre.ToString();
                        }
                         
                    }else
                    {
                        Int32 cantidad = Convert.ToInt32(fila.Cells[3].Value);
                        if (cantidad<=cantidadP)
                        {
                            int tota = cantidadP / cantidad;
                            decimal pre = Round(Convert.ToDecimal(Math.Round((precio2 / tota), 2)));
                            fila.Cells[2].Value = pre.ToString();
                        }
                        
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (presenta.Count==0)
            {
                this.Close();
            }else
            {
                this.generarNuevosPrecios();
                listo = true;
                this.Close();
            }
        }

        private void compraMayoreo_Leave(object sender, EventArgs e)
        {
            calcularPreciosventas();
        }

        private void compraDetalle_Leave(object sender, EventArgs e)
        {
            calcularPreciosventas2();
        }

        private void listaUDetalle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cargado)
            {
                calcularPreciosventas2();
            }
            
        }

        private void listaUMayoreo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cargado)
            {
                calcularPreciosventas2();
            }
            
        }

        private void compraMayoreo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void listaPresentaciones_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void compraMayoreo_Enter(object sender, EventArgs e)
        {
            compraMayoreo.Select(0, compraMayoreo.Text.Length);
        }

        private void compraDetalle_Enter(object sender, EventArgs e)
        {
            compraDetalle.Select(0, compraDetalle.Text.Length);
        }

        private void txtCantidad_Enter(object sender, EventArgs e)
        {
            txtCantidad.Select(0, txtCantidad.Text.Length);
        }

        private void redondearTabla()
        {
            foreach (DataGridViewRow fila in tabla_presentaciones.Rows)
            {
                if (!fila.Cells[4].Value.ToString().Equals("Detalle"))
                {
                    Int32 entera = (Int32)Convert.ToDouble(fila.Cells[2].Value.ToString());
                    if (entera==0)
                    {
                        fila.Cells[2].Value = Math.Round(Convert.ToDouble(fila.Cells[2].Value));
                    }else
                    {
                        fila.Cells[2].Value = Math.Round(Convert.ToDouble(fila.Cells[2].Value), 1, MidpointRounding.AwayFromZero);
                    }
                }  
            }
        }

        private void generarNuevosPrecios()
        {
            Presenta = new List<presentaciones_productos>();
            try
            {
                foreach (DataGridViewRow fila in tabla_presentaciones.Rows)
                {
                    presenta.Add(new presentaciones_productos(fila.Cells[0].Value.ToString(), fila.Cells[2].Value.ToString()));
                }
            }
            catch
            {

            }
        }

        private void colocarPreciosModificados()
        {
            int aux = presenta.Count;
            int aux2 = aux;
            if (tabla_presentaciones.RowCount!=0)
            {
                foreach(DataGridViewRow  fila in tabla_presentaciones.Rows)
                {
                    fila.Cells[2].Value = presenta[aux-aux2].Precio;
                    aux2--;
                }
            }
        }
    }
}
