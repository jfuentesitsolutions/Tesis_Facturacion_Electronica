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
using System.Xml.Linq;
using System.Xml;
using conexiones_BD.clases;

namespace interfaces.traslados
{
    public partial class traslados_productos : Form
    {
        sessionManager.secion sesion = sessionManager.secion.Instancia;
        utilitarios.cargar_tablas tabla;
        bool busqueda = false;
        int correSiguiente=0, idcorrelativo=0;
        string cantiAn, precioAn;
        transferencias_internet.xml xm = new transferencias_internet.xml();
        

        public traslados_productos()
        {
            InitializeComponent();
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void traslados_productos_Load(object sender, EventArgs e)
        {
            horientaciones_textos.colocarTitulo(panelTitulo, lblEncanezado);
            txtCorrelativo.Text = generaciondecorrelativo();
            this.cargarTablas();
            this.cargarListas();
        }

        private void cargarTablas()
        {
            tabla = new utilitarios.cargar_tablas(tablad, txtBusqueda, conexiones_BD.clases.productos.CARGAR_TABLA_PRODUCTOS_X_SUCURSAL_VENTA(sesion.DatosRegistro[1]), "productoCod");
            tabla.cargarSinContadorRegistros();
        }

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            movimimientos mov = new movimimientos();
            mov.moverFormulario(sender, e, this);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            transferencias_internet.xml xm = new transferencias_internet.xml();
            try
            {
                xm._crearXml("productos", Convert.ToInt16(sesion.DatosRegistro[0]), "productos.xml");

            }
            catch
            {
                MessageBox.Show("Error");
            }
           

        }

        private string generandoCorrelativos(string cS, string idCo)
        {
            string corr = null;
            int numeroDigitos = cS.Length;
            string identifica = "TR" + sesion.DatosRegistro[0] + idCo;

            switch (numeroDigitos)
            {
                case 1:
                    {
                        corr = identifica + "00000" + cS;
                        break;
                    }
                case 2:
                    {
                        corr = identifica + "0000" + cS;
                        break;
                    }
                case 3:
                    {
                        corr = identifica + "000" + cS;
                        break;
                    }
                case 4:
                    {
                        corr = identifica + "00" + cS;
                        break;
                    }
                case 5:
                    {
                        corr = identifica + "0" + cS;
                        break;
                    }
                case 6:
                    {
                        corr = identifica + cS;
                        break;
                    }

            }

            return corr;
        }

        private string generaciondecorrelativo()
        {
            string corre = null;
            DataTable correlativos = conexiones_BD.clases.traslados.traslado.datosTabla(sesion.DatosRegistro[1]);
            Int32 limite = 0;
            Int32 correlativoActual = 0;
            Int32 correlativoSiguiente = 0;

            if (correlativos == null)
            {
                MessageBox.Show("No se han establecido correlativos para esta sucursal", "Error de correlativos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                correlativoActual = Convert.ToInt32(correlativos.Rows[0][4].ToString());

                limite = Convert.ToInt32(correlativos.Rows[0][3].ToString());
                if (correlativoActual + 1 == limite)
                {
                    MessageBox.Show("Ya se alcanso el limite de tickets emitidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    correSiguiente = correlativoActual + 1;
                    Console.WriteLine(correlativoSiguiente);
                    corre = generandoCorrelativos(correlativoActual.ToString(),correlativos.Rows[0][0].ToString());
                    idcorrelativo = Convert.ToInt16(correlativos.Rows[0][0].ToString());
                }

            }

            return corre;
        }

        private string guardarCorrelativo(string correlativoS, string idcorre, string coorreactual)
        {
            string corre="";
            if (conexiones_BD.clases.traslados.traslado.actualizaCorrelativos(correlativoS, idcorre))
            {
                corre = generandoCorrelativos(coorreactual, idcorre);
            }
            else
            {
                MessageBox.Show("Setecto un problema al generar el correlativo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return corre;
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (busqueda)
            {
                tablad.Visible = true;
                tabla.FiltrarLocalmenteSinContadorRegistros();
                try
                {
                    if (tablad.Rows.Count != 0)
                    {
                        tablad.CurrentCell = tablad.Rows[0].Cells[1];
                    }

                }
                catch
                {

                }
            }
        }

        private void txtBusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            busqueda = true;
            if (e.KeyCode == Keys.Add)
            {
                if (tabla_articulos.Rows.Count != 0)
                {
                    e.SuppressKeyPress = true;
                    tabla_articulos.Focus();
                    colocarEnelutimoRegistro();
                }

            }
        }

        private void colocarEnelutimoRegistro()
        {
            if (tabla_articulos.Rows.Count != 0)
            {
                tabla_articulos.CurrentCell = tabla_articulos.Rows[tabla_articulos.Rows.Count - 1].Cells[4];
            }
        }

        private void txtBusqueda_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                tablad.Visible = false;
            }
            else if (e.KeyCode == Keys.Down)
            {
                if (txtBusqueda.TextLength != 0)
                {
                    tablad.Focus();
                }
            }
            else if (e.KeyCode == Keys.Enter)
            {
                if (txtBusqueda.TextLength != 0)
                {
                    if (busqueda)
                    {
                        try
                        {
                            cantidadProductos2();
                            colocarFoco();
                        }
                        catch
                        {

                        }
                    }
                }
            }
        }

        private void colocarFoco()
        {
            txtBusqueda.Text = "";
            txtBusqueda.Focus();
            busqueda = false;
            tablad.Visible = false;
        }

        private void cantidadProductos2()
        {
            ventas.auxiliares.producto_unica_presentacion pu = new ventas.auxiliares.producto_unica_presentacion();
            DataGridViewRow seleccion = tablad.CurrentRow;
            ventas.auxiliares.productos_mas_presentaciones puu = new ventas.auxiliares.productos_mas_presentaciones();

            //si el articulos solo tiene una presentacion
            if (seleccion.Cells[3].Value.ToString().Equals("1"))
            {

                pu.Idpresentacion_poroducto = seleccion.Cells[8].Value.ToString();
                if (seleccion.Cells[11].Value.ToString().Equals("Detalle"))
                {
                    pu.TipoUtilidad = seleccion.Cells[9].Value.ToString();
                }
                else
                {
                    pu.TipoUtilidad = seleccion.Cells[10].Value.ToString();
                }
                pu.Sucursal_producto = seleccion.Cells[0].Value.ToString();
                pu.Codigo = seleccion.Cells[1].Value.ToString();
                pu.lblExis.Text = seleccion.Cells[6].Value.ToString();
                pu.lblNombre.Text = seleccion.Cells[2].Value.ToString();
                pu.lblPres.Text = seleccion.Cells[7].Value.ToString();
                pu.lblPrecio.Text = "$" + seleccion.Cells[5].Value.ToString();
                pu.Precio = seleccion.Cells[5].Value.ToString();
                pu.txtCantidad.Value = 1;
                pu.CantidadInter = "1";

                pu.ShowDialog();

                if (pu.Llenado)
                {
                    //si la tabla esta vacia
                    if (tabla_articulos.Rows.Count == 0)
                    { 
                        tabla_articulos.Rows.Add(
                        "",
                        pu.Codigo,
                        pu.lblNombre.Text,
                        pu.lblPres.Text,
                        pu.txtCantidad.Value.ToString(),
                        pu.Precio,
                        pu.Total,
                        pu.Idpresentacion_poroducto,
                        pu.Utilidad,
                        "",
                        "1",
                        pu.lblExis.Text,
                        pu.Sucursal_producto,
                        "0"
                        );

                        colocarEnelutimoRegistro();
                    }
                    else
                    {
                        //si el articulo no esta repetido
                        if (!productoRepetido(pu.Idpresentacion_poroducto, pu.txtCantidad.Value.ToString()))
                        {
                            tabla_articulos.Rows.Add(
                        "",
                        pu.Codigo,
                        pu.lblNombre.Text,
                        pu.lblPres.Text,
                        pu.txtCantidad.Value.ToString(),
                        pu.Precio,
                        pu.Total,
                        pu.Idpresentacion_poroducto,
                        pu.Utilidad,
                        "",
                        "1",
                        pu.lblExis.Text,
                        pu.Sucursal_producto,
                        "0"
                        );
                            colocarEnelutimoRegistro();
                        }
                    }

                    utilitarios.cargar_tablas.correlativoTabla(tabla_articulos);
                    calcularTotales();
                }
                //cuando hay mas de dos presentaciones
            }
            else
            {
                puu.Sucursal_producto = seleccion.Cells[0].Value.ToString();
                puu.IdsucursalProducto = seleccion.Cells[0].Value.ToString();
                puu.Codigo = seleccion.Cells[1].Value.ToString();
                puu.UtilidadD = seleccion.Cells[9].Value.ToString();
                puu.UtiliadM = seleccion.Cells[10].Value.ToString();
                puu.lblExis.Text = seleccion.Cells[6].Value.ToString();
                puu.lblNombre.Text = seleccion.Cells[2].Value.ToString();

                puu.ShowDialog();

                if (puu.Llenado)
                {
                    if (tabla_articulos.Rows.Count == 0)
                    {
                        tabla_articulos.Rows.Add(
                        "",
                        puu.Codigo,
                        puu.lblNombre.Text,
                        puu.Presentacion,
                        puu.txtCantidad.Value.ToString(),
                        puu.Precio,
                        puu.Total,
                        puu.Idpresentacion_poroducto,
                        puu.Utilidad,
                        "",
                        puu.Cantidad_interna,
                        puu.lblExis.Text,
                        puu.Sucursal_producto,
                        puu.UtilidadD,
                        puu.UtiliadM
                        );
                        colocarEnelutimoRegistro();
                    }
                    else
                    {

                        if (!revisarExistencias(puu.IdsucursalProducto, puu.txtCantidad.Value.ToString(), puu.Cantidad_interna))
                        {
                            if (!productoRepetido(puu.Idpresentacion_poroducto, puu.txtCantidad.Value.ToString()))
                            {
                                tabla_articulos.Rows.Add(
                            "",
                            puu.Codigo,
                            puu.lblNombre.Text,
                            puu.Presentacion,
                            puu.txtCantidad.Value.ToString(),
                            puu.Precio,
                            puu.Total,
                            puu.Idpresentacion_poroducto,
                            puu.Utilidad,
                            "",
                            puu.Cantidad_interna,
                            puu.lblExis.Text,
                            puu.Sucursal_producto,
                            puu.UtilidadD,
                            puu.UtiliadM
                            );
                                colocarEnelutimoRegistro();
                            }
                        }



                    }
                }
                utilitarios.cargar_tablas.correlativoTabla(tabla_articulos);
                calcularTotales();

            }
        }

        private bool productoRepetido(string idpr_pro, string cant)
        {
            bool encontrado = false;

            foreach (DataGridViewRow fila in tabla_articulos.Rows)
            {
                if (fila.Cells[7].Value.Equals(idpr_pro))
                {
                    Int32 canA = Convert.ToInt32(fila.Cells[4].Value);
                    Int32 canN = Convert.ToInt32(cant);

                    Int32 canInt = Convert.ToInt32(fila.Cells[10].Value);
                    Int32 exis = Convert.ToInt32(fila.Cells[11].Value);

                    Int32 canTN = canA + canN;
                    Int32 tN = (canA * canInt) + (canN * canInt);

                    if (tN > exis)
                    {
                        MessageBox.Show("No hay existencias", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        encontrado = true;
                    }
                    else
                    {
                        fila.Cells[4].Value = canTN.ToString();
                        fila.Cells[6].Value = recalcularTotalProducto(fila.Cells[4].Value.ToString(), fila.Cells[5].Value.ToString());
                        encontrado = true;
                    }
                }
            }




            return encontrado;
        }

        private string recalcularTotalProducto(string canti, string pre)
        {
            string total = "";
            double ca = Convert.ToDouble(canti);
            double prec = Convert.ToDouble(pre);
            double tota = Math.Round(ca * prec, 2, MidpointRounding.AwayFromZero);
            Console.WriteLine(ca);
            Console.WriteLine(pre);

            total = tota.ToString();

            return total;
        }

        private bool revisarExistencias(string idsucur, string canN, string canI)
        {
            bool existen = false;
            int cantidadReg = 0;
            double conte = 0;
            Int32 exis = 0;
            double caN = Convert.ToDouble(canN);
            double caI = Convert.ToDouble(canI);

            foreach (DataGridViewRow fila in tabla_articulos.Rows)
            {
                if (fila.Cells[12].Value.Equals(idsucur))
                {
                    conte += (Convert.ToDouble(fila.Cells[4].Value.ToString()) * Convert.ToDouble(fila.Cells[10].Value.ToString()));
                    exis = Convert.ToInt32(fila.Cells[11].Value.ToString());
                    cantidadReg++;
                }
            }

            if (cantidadReg > 0)
            {
                conte += (caN * caI);
                Console.WriteLine(conte + "hola");
                Console.WriteLine(exis + "Exist");

                if (conte > exis)
                {
                    MessageBox.Show("No hay existencias", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    existen = true;
                }
                else
                {
                    existen = false;
                }
            }
            else
            {
                existen = false;
            }



            return existen;
        }

        private void calcularTotales()
        {
            double precio = 0;
            foreach (DataGridViewRow fila in tabla_articulos.Rows)
            {
                precio += Convert.ToDouble(fila.Cells[6].Value);
            }

            //lblCantidad_de_articulos.Text = "Cantidad de articulos " + tabla_articulos.Rows.Count;
            //lblSubt.Text = precio.ToString();
            //lblIva.Text = "0.0";
            //lblDescuento.Text = "0.0";
            //lblTotal.Text = "$ " + precio.ToString();
            //total = precio.ToString();
        }

        private void tablad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void tablad_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                try
                {
                    if (busqueda)
                    {
                        cantidadProductos2();
                        txtBusqueda.Text = "";
                        txtBusqueda.Focus();
                        tablad.Visible = false;
                        busqueda = false;
                    }

                }
                catch
                {

                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                busqueda = false;
                txtBusqueda.Text = "";
                txtBusqueda.Focus();
                tablad.Visible = false;

            }
        }

        private void tabla_articulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tabla_articulos.Columns[e.ColumnIndex].Name == "prese")
            {
                try
                {


                    if (MessageBox.Show("¿Cambiar presentación?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        if (tabla_articulos.Rows[e.RowIndex].Cells[13].Value.ToString().Equals("0"))
                        {
                            MessageBox.Show("No hay presentaciones", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            ventas.auxiliares.productos_mas_presentaciones puu = new ventas.auxiliares.productos_mas_presentaciones();
                            puu.Sucursal_producto = tabla_articulos.Rows[e.RowIndex].Cells[12].Value.ToString();
                            puu.IdsucursalProducto = tabla_articulos.Rows[e.RowIndex].Cells[12].Value.ToString();
                            puu.Codigo = tabla_articulos.Rows[e.RowIndex].Cells[1].Value.ToString();
                            puu.UtilidadD = tabla_articulos.Rows[e.RowIndex].Cells[13].Value.ToString();
                            puu.UtiliadM = tabla_articulos.Rows[e.RowIndex].Cells[14].Value.ToString();
                            puu.lblExis.Text = tabla_articulos.Rows[e.RowIndex].Cells[11].Value.ToString();
                            puu.lblNombre.Text = tabla_articulos.Rows[e.RowIndex].Cells[2].Value.ToString();
                            puu.txtCantidad.Text = tabla_articulos.Rows[e.RowIndex].Cells[4].Value.ToString();

                            puu.ShowDialog();

                            if (puu.Llenado)
                            {
                                if (tabla_articulos.Rows.Count == 0)
                                {
                                    tabla_articulos.Rows.Add(
                                    "",
                                    puu.Codigo,
                                    puu.lblNombre.Text,
                                    puu.Presentacion,
                                    puu.txtCantidad.Value.ToString(),
                                    puu.Precio,
                                    puu.Total,
                                    puu.Idpresentacion_poroducto,
                                    puu.Utilidad,
                                    "",
                                    puu.Cantidad_interna,
                                    puu.lblExis.Text,
                                    puu.Sucursal_producto,
                                    puu.UtilidadD,
                                    puu.UtiliadM
                                    );

                                    tabla_articulos.Rows.RemoveAt(e.RowIndex);
                                    calcularTotales();
                                    utilitarios.cargar_tablas.correlativoTabla(tabla_articulos);
                                }
                                else
                                {

                                    if (!revisarExistencias(puu.IdsucursalProducto, puu.txtCantidad.Value.ToString(), puu.Cantidad_interna))
                                    {
                                        if (!productoRepetido(puu.Idpresentacion_poroducto, puu.txtCantidad.Value.ToString()))
                                        {
                                            tabla_articulos.Rows.Add(
                                        "",
                                        puu.Codigo,
                                        puu.lblNombre.Text,
                                        puu.Presentacion,
                                        puu.txtCantidad.Value.ToString(),
                                        puu.Precio,
                                        puu.Total,
                                        puu.Idpresentacion_poroducto,
                                        puu.Utilidad,
                                        "",
                                        puu.Cantidad_interna,
                                        puu.lblExis.Text,
                                        puu.Sucursal_producto,
                                        puu.UtilidadD,
                                        puu.UtiliadM
                                        );
                                            tabla_articulos.Rows.RemoveAt(e.RowIndex);
                                            calcularTotales();
                                            utilitarios.cargar_tablas.correlativoTabla(tabla_articulos);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                catch
                {

                }

            }
        }

        private void tabla_articulos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (tabla_articulos.Columns[e.ColumnIndex].Name == "canti")
            {
                double canN = 0;
                double canNU = 0;
                int canNuu = 0;

                if (tabla_articulos.Rows[e.RowIndex].Cells[13].Value.ToString().Equals("0"))
                {

                    try
                    {
                        canN = Convert.ToDouble(tabla_articulos.Rows[e.RowIndex].Cells[4].Value.ToString()) * Convert.ToInt32(tabla_articulos.Rows[e.RowIndex].Cells[10].Value.ToString());
                        canNuu = Convert.ToInt32(tabla_articulos.Rows[e.RowIndex].Cells[4].Value.ToString());

                        if (!revisarExistencias2(tabla_articulos.Rows[e.RowIndex].Cells[12].Value.ToString(), canN.ToString(), tabla_articulos.Rows[e.RowIndex].Cells[10].Value.ToString()))
                        {
                            Int32 exist = Convert.ToInt32(tabla_articulos.Rows[e.RowIndex].Cells[11].Value.ToString());

                            if (canN == exist || canN < exist)
                            {
                                tabla_articulos.Rows[e.RowIndex].Cells[6].Value = recalcularTotalProducto(canNuu.ToString(), tabla_articulos.Rows[e.RowIndex].Cells[5].Value.ToString());
                                calcularTotales();
                                colocarFoco();
                            }
                            else
                            {
                                MessageBox.Show("No hay existencias", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                tabla_articulos.Rows[e.RowIndex].Cells[4].Value = cantiAn;
                            }
                        }
                        else
                        {
                            tabla_articulos.Rows[e.RowIndex].Cells[4].Value = cantiAn;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("No puedes agregar esa cantidad", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        canN = Convert.ToInt32(cantiAn);
                        tabla_articulos.Rows[e.RowIndex].Cells[4].Value = cantiAn;
                        tabla_articulos.Rows[e.RowIndex].Cells[6].Value = recalcularTotalProducto(cantiAn.ToString(), tabla_articulos.Rows[e.RowIndex].Cells[5].Value.ToString());

                    }

                }
                else
                {
                    try
                    {
                        canN = Convert.ToDouble(tabla_articulos.Rows[e.RowIndex].Cells[4].Value.ToString()) * Convert.ToInt32(tabla_articulos.Rows[e.RowIndex].Cells[10].Value.ToString());
                        canNU = Convert.ToDouble(tabla_articulos.Rows[e.RowIndex].Cells[4].Value.ToString());
                        Console.WriteLine(canN);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Debes ingresar una cantidad valida", "No es numero", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        canN = Convert.ToInt32(cantiAn);
                        tabla_articulos.Rows[e.RowIndex].Cells[4].Value = cantiAn;
                    }

                    if (!revisarExistencias2(tabla_articulos.Rows[e.RowIndex].Cells[12].Value.ToString(), canN.ToString(), tabla_articulos.Rows[e.RowIndex].Cells[10].Value.ToString()))
                    {
                        Int32 exist = Convert.ToInt32(tabla_articulos.Rows[e.RowIndex].Cells[11].Value.ToString());


                        if (canN == exist || canN < exist)
                        {
                            tabla_articulos.Rows[e.RowIndex].Cells[6].Value = recalcularTotalProducto(canNU.ToString(), tabla_articulos.Rows[e.RowIndex].Cells[5].Value.ToString());
                            calcularTotales();
                            colocarFoco();
                        }
                        else
                        {
                            MessageBox.Show("No hay existencias", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            tabla_articulos.Rows[e.RowIndex].Cells[4].Value = cantiAn;
                        }
                    }
                    else
                    {
                        tabla_articulos.Rows[e.RowIndex].Cells[4].Value = cantiAn;
                    }
                }
            }
            else if (tabla_articulos.Columns[e.ColumnIndex].Name == "preci")
            {

                if (MessageBox.Show("¿Deseas cambiar el precio de la presentación?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    string precioN = tabla_articulos.Rows[e.RowIndex].Cells[5].Value.ToString();
                    if (!conexiones_BD.clases.presentaciones_productos.cambio_precio(tabla_articulos.Rows[e.RowIndex].Cells[5].Value.ToString(), tabla_articulos.Rows[e.RowIndex].Cells[7].Value.ToString()))
                    {
                        tabla_articulos.Rows[e.RowIndex].Cells[5].Value = precioN;
                        calcularTotales();
                    }
                    tabla_articulos.Rows[e.RowIndex].Cells[6].Value = recalcularTotalProducto(tabla_articulos.Rows[e.RowIndex].Cells[4].Value.ToString(), tabla_articulos.Rows[e.RowIndex].Cells[5].Value.ToString());
                    cargarTablas();
                    txtBusqueda.Text = "";
                    txtBusqueda.Focus();
                    busqueda = false;
                    tablad.Visible = false;
                    calcularTotales();
                }
                else
                {
                    string precioN = tabla_articulos.Rows[e.RowIndex].Cells[5].Value.ToString();
                    tabla_articulos.Rows[e.RowIndex].Cells[5].Value = precioN;
                    tabla_articulos.Rows[e.RowIndex].Cells[6].Value = recalcularTotalProducto(tabla_articulos.Rows[e.RowIndex].Cells[4].Value.ToString(), tabla_articulos.Rows[e.RowIndex].Cells[5].Value.ToString());
                    cargarTablas();
                    txtBusqueda.Text = "";
                    txtBusqueda.Focus();
                    busqueda = false;
                    tablad.Visible = false;
                    calcularTotales();
                }
            }
        }

        private void tabla_articulos_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (tabla_articulos.Columns[e.ColumnIndex].Name == "canti")
            {
                cantiAn = tabla_articulos.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            else if (tabla_articulos.Columns[e.ColumnIndex].Name == "preci")
            {
                precioAn = tabla_articulos.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }

        private void tabla_articulos_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (tabla_articulos.Rows.Count != 0)
                {
                    if (MessageBox.Show("¿Desea quitar este producto?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                    {
                        tabla_articulos.Rows.RemoveAt(tabla_articulos.CurrentRow.Index);
                        calcularTotales();
                    }
                }
            }
            catch
            {

            }
        }

        private bool revisarExistencias2(string idsucur, string canN, string canI)
        {
            bool existen = false;
            int cantidadReg = 0;
            double conte = 0;
            Int32 exis = 0;
            double caN = Convert.ToDouble(canN);
            double caI = Convert.ToDouble(canI);

            foreach (DataGridViewRow fila in tabla_articulos.Rows)
            {
                if (fila.Cells[12].Value.Equals(idsucur))
                {
                    conte += (Convert.ToDouble(fila.Cells[4].Value.ToString()) * Convert.ToDouble(fila.Cells[10].Value.ToString()));
                    exis = Convert.ToInt32(fila.Cells[11].Value.ToString());
                    cantidadReg++;
                }
            }

            if (cantidadReg > 1)
            {
                conte += (caN * caI);
                conte = conte - caN;
                Console.WriteLine(conte + "hola");
                Console.WriteLine(exis + "Exist");

                if (conte > exis)
                {
                    MessageBox.Show("No hay existencias", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    existen = true;
                }
                else
                {
                    existen = false;
                }
            }
            else
            {
                existen = false;
            }



            return existen;
        }

        private List<conexiones_BD.clases.traslados.detalle_producto_traslado> retornoProductos()
        {
            List<conexiones_BD.clases.traslados.detalle_producto_traslado> dp = new List<conexiones_BD.clases.traslados.detalle_producto_traslado>();

            foreach (DataGridViewRow fila in tabla_articulos.Rows)
            {
                double cantidad = Convert.ToDouble(fila.Cells[4].Value.ToString()) * Convert.ToDouble(fila.Cells[10].Value.ToString());
                double can = Convert.ToDouble(fila.Cells[4].Value.ToString());
                conexiones_BD.clases.traslados.detalle_producto_traslado dt = new conexiones_BD.clases.traslados.detalle_producto_traslado(
                    fila.Cells[12].Value.ToString(), cantidad.ToString(), "2", "0", txtCorrelativo.Text, can.ToString(),
                    fila.Cells[3].Value.ToString(), fila.Cells[1].Value.ToString());
                dt.Nombre = fila.Cells[2].Value.ToString();
                dp.Add(
                    dt
                    );
            }


            return dp;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!validar())
            {
                if (listaSucurLlegada.SelectedValue.ToString().Equals(listaSucurSalida.SelectedValue.ToString()))
                {
                    MessageBox.Show("No puede efectuar el traslado a la misma sucursal", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }else
                {
                    enviandoTraslado();
                }
            }   
        }

        private bool validar()
        {
            bool valido = false;
            error.Clear();
            string mensaje = "No puedes dejar este campo en blanco";

            if (listaSucurLlegada.SelectedIndex==-1)
            {
                valido = true;
                error.SetError(listaSucurLlegada, mensaje);
            }

            if (tabla_articulos.RowCount==0)
            {
                valido = true;
                error.SetError(tabla_articulos, "Tienes que agregar articulos para trasladar");
            }
            if (txtObservaciones.TextLength==0)
            {
                valido = true;
                error.SetError(txtObservaciones, mensaje);
            }

            return valido;
        }

        private void cargarListas()
        {
            utilitarios.cargandoListas.cargarLista(conexiones_BD.clases.sucursales.datosTabla(), listaSucurSalida, "numero_de_sucursal", "idsucursal");
            listaSucurSalida.SelectedValue = sesion.DatosRegistro[1];
            utilitarios.cargandoListas.cargarLista(conexiones_BD.clases.sucursales.datosTabla(), listaSucurLlegada, "numero_de_sucursal", "idsucursal");
            

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
        }

        private void enviandoTraslado()
        {
            utilitarios.maneja_fechas fech = new maneja_fechas();
            conexiones_BD.clases.traslados.traslado tras = new conexiones_BD.clases.traslados.traslado(
                listaSucurSalida.SelectedValue.ToString(),
                listaSucurLlegada.SelectedValue.ToString(),
                txtObservaciones.Text, fech.fechaMysql(fechaActual),
                fech.fechaMysql(fechaActual), "2", txtCorrelativo.Text);

            conexiones_BD.operaciones op = new conexiones_BD.operaciones();

            if (op.transaccionEnvioTraslado(tras, retornoProductos()) > 0)
            {
                enviantroTrasladoXinternet(tras, retornoProductos());
                MessageBox.Show("El traslado se ingreso éxitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listaSucurLlegada.SelectedIndex = -1;
                tabla_articulos.Rows.Clear();
                txtObservaciones.Text = "";
                fechaActual.Value = DateTime.Now;
                txtCorrelativo.Text= guardarCorrelativo(correSiguiente.ToString(), idcorrelativo.ToString(), correSiguiente.ToString());
            }else
            {
                MessageBox.Show("El traslado no se ingreso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void enviantroTrasladoXinternet(conexiones_BD.clases.traslados.traslado tras, List<conexiones_BD.clases.traslados.detalle_producto_traslado> pro)
        {
            xm._crearXml2("traslados", transferencias_internet.nuevos_ingresos.rutas_sucursales(Convert.ToInt16(listaSucurLlegada.Text)) + "traslados.xml");

            xm._AñadirTraslados(tras);
            xm._AñadirPresentacionesTraslados(actualizaPrePro());
            xm._AñadirProductos_traslados(pro);

        }

        private List<conexiones_BD.clases.presentaciones_productos> actualizaPrePro()
        {
            List<conexiones_BD.clases.presentaciones_productos> pr = new List<conexiones_BD.clases.presentaciones_productos>();
            foreach (DataGridViewRow fila in tabla_articulos.Rows)
            {
                DataTable pre = conexiones_BD.clases.presentaciones_productos.presentaciones_producto(fila.Cells[12].Value.ToString());
                foreach (DataRow fi in pre.Rows)
                {
                    conexiones_BD.clases.presentaciones_productos prese = new conexiones_BD.clases.presentaciones_productos(fi[1].ToString(), fi[2].ToString(), fi[3].ToString(),
                        fi[4].ToString(), fi[5].ToString(), fi[6].ToString(),"1");
                    prese.Cod_producto = fila.Cells[1].Value.ToString();
                    prese.Correla = txtCorrelativo.Text;
                    pr.Add(prese);
                }
            }

                return pr;
        }

        
    }
}
