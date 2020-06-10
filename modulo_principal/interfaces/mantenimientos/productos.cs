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
    public partial class productos : Form
    {
        sessionManager.secion sesion = sessionManager.secion.Instancia;
        transferencias_internet.xml xm = new transferencias_internet.xml();
        utilitarios.cargar_tablas tabla, tabla2, tabla3;
        conexiones_BD.clases.productos pro;
        conexiones_BD.clases.codigos codi;
        conexiones_BD.clases.sucursales_productos sp;
        conexiones_BD.clases.productos p;
        conexiones_BD.clases.presentaciones_productos prpr;
        conexiones_BD.operaciones op;
        bool selecM = false, selecD = false, cargado = false;
        DataGridView tablaPermisosAsig = null;
        string nombre, codigo, idsucusal_producto, idproducto;

        bool modificar = false;

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

        public productos()
        {
            InitializeComponent();
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void productos_Load(object sender, EventArgs e)
        {
            gadgets.horientaciones_textos.colocarTitulo(panelTitulo, lblEncanezado);
            //xm._crearXml("productos", Convert.ToInt16(sesion.DatosRegistro[0]), "productos.xml");
            if (modificar)
            {
                habilitar(false);
                btnGuardar.Text = "Modificar";
                btnCancelar.Text = "Eliminar";
                cargarTablas();
                cargarListas();
                selecD = true;
                selecM = true;
                txtCodigo.Visible = false;
                listaCodigos.Visible = true;

            }
            else
            {
                cargarTablas();
                cargarListas();
                selecD = true;
                selecM = true;
                txtCodigo.Visible = true;
                listaCodigos.Visible = false;
                btnAgregarCodigo.Visible = false;
            }

            cargado = true;

        }

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            gadgets.movimimientos mov = new gadgets.movimimientos();
            mov.moverFormulario(sender, e, this);
        }

        private void cargarTablas()
        {
            if (sesion.Datos[3].Equals("Administradores"))
            {
                tabla = new utilitarios.cargar_tablas(tablaPro, txtBuscar, conexiones_BD.clases.productos.CARGAR_TABLA_PRODUCTOS(), "nombreP", lblReg);
                tabla.cargarPersonalizado("codP");
                chkNombre.Checked = true;
            }
            else
            {
                /*tabla = new utilitarios.cargar_tablas(tablaPro, txtBuscar, conexiones_BD.clases.productos.CARGAR_TABLA_PRODUCTOS_X_SUCURSAL(sesion.DatosRegistro[1]), "nombreP", lblReg);
                tabla.cargarPersonalizado("codP");
                chkNombre.Checked = true;*/

                tabla = new utilitarios.cargar_tablas(tablaPro, txtBuscar, conexiones_BD.clases.productos.CARGAR_TABLA_PRODUCTOS(), "nombreP", lblReg);
                tabla.cargarPersonalizado("codP");
                chkNombre.Checked = true;
            }


            tabla2 = new utilitarios.cargar_tablas(tabla_presentacion, txtBuscarP, conexiones_BD.clases.presentaciones.datosTabla(), "nombre_presentacion");
            tabla2.cargarSinContadorRegistros();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (modificar)
            {
                modifica();
            }
            else
            {
                guarda();
                
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (chkCodi.Checked)
            {
                tabla.FiltrarLocalmentePersonalizado("codP");
            } else if (chkNombre.Checked)
            {
                tabla.FiltrarLocalmentePersonalizado("nombreP");
            } else if (chkCategoria.Checked)
            {
                tabla.FiltrarLocalmentePersonalizado("nombreC");
            }

        }

        private void txtBuscarP_TextChanged(object sender, EventArgs e)
        {
            tabla2.FiltrarLocalmenteSinContadorRegistros();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            mantenimientos.presentaciones pre = new presentaciones();
            pre.ShowDialog();
            tabla2 = new utilitarios.cargar_tablas(tabla_presentacion, txtBuscarP, conexiones_BD.clases.presentaciones.datosTabla(), "nombre_presentacion");
            tabla2.cargarSinContadorRegistros();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            agrega();
        }

        private void agrega()
        {
            if (modificar)
            {
                if (!validarAgregarPresentacion())
                {
                    auxiliares.presentaciones_productos pp = new auxiliares.presentaciones_productos();
                    pp.PrecioM = precioVM.Value;
                    pp.PrecioD = precioVD.Value;
                    pp.Idpresentacion = tabla_presentacion.CurrentRow.Cells[0].Value.ToString();
                    pp.lblPresenta.Text = tabla_presentacion.CurrentRow.Cells[1].Value.ToString();
                    pp.ShowDialog();

                    if (pp.Agregado)
                    {
                        string priori = "2";
                        if (pp.chkPrioridad.Checked)
                        {
                            priori = "1";
                        }
                        prpr = new conexiones_BD.clases.presentaciones_productos(
                            idsucusal_producto,
                            pp.Idpresentacion,
                            pp.canti.Value.ToString(),
                            Math.Round(pp.precio.Value, 2).ToString(),
                            pp.TipoN,
                            priori,
                            "1"
                            );

                        if (prpr.guardar(false) > 0)
                        {
                            cargarTablaPresentaciones();
                        }
                    }
                }

            }
            else
            {
                try
                {
                    if (!validarAgregarPresentacion())
                    {
                        auxiliares.presentaciones_productos pp = new auxiliares.presentaciones_productos();
                        pp.PrecioM = precioVM.Value;
                        pp.PrecioD = precioVD.Value;
                        pp.Idpresentacion = tabla_presentacion.CurrentRow.Cells[0].Value.ToString();
                        pp.lblPresenta.Text = tabla_presentacion.CurrentRow.Cells[1].Value.ToString();
                        pp.ShowDialog();

                        if (pp.Agregado)
                        {
                            tabla_presentacion_producto.Rows.Add(
                            "0", pp.Idpresentacion, pp.lblPresenta.Text, Math.Round(pp.precio.Value, 2), pp.Tipo, pp.canti.Value, pp.TipoN
                            );
                        }

                    }
                }
                catch
                {

                }
            }
        }

        private bool validarAgregarPresentacion()
        {
            bool valido = false;
            string mensaje = "Tienes que llenar este campo";
            error1.Clear();

            if (txtnombreP.TextLength == 0)
            {
                valido = true;
                error1.SetError(txtnombreP, mensaje);
            }

            if (listaMayoreo.SelectedIndex == -1)
            {
                valido = true;
                error1.SetError(listaMayoreo, mensaje);
            }

            if (listaUtilidadDetalle.SelectedIndex == -1)
            {
                valido = true;
                error1.SetError(listaUtilidadDetalle, mensaje);
            }

            if (precioVM.Value.ToString().Equals("0"))
            {
                valido = true;
                error1.SetError(precioVM, mensaje);
            }

            if (precioVD.Value.ToString().Equals("0"))
            {
                valido = true;
                error1.SetError(precioVD, mensaje);
            }


            return valido;
        }

        private bool validarPrecioMayoreo()
        {
            bool valido = false;
            string mensaje = "Tienes que llenar este campo";
            error2.Clear();

            if (precioCM.Value.ToString().Equals("0"))
            {
                valido = true;
                error2.SetError(precioCM, mensaje);
            }

            return valido;

        }

        private bool validarPrecioDetalle()
        {
            bool valido = false;
            string mensaje = "Tienes que llenar este campo";
            error3.Clear();

            if (precioCD.Value.ToString().Equals("0"))
            {
                valido = true;
                error3.SetError(precioCD, mensaje);
            }

            return valido;

        }

        private void listaMayoreo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (selecM)
            {
                if (!validarPrecioMayoreo())
                {
                    DataRowView fila = (DataRowView)listaMayoreo.SelectedItem;
                    Decimal UtilidadM = Convert.ToDecimal(fila[3].ToString());

                    Decimal precio = (precioCM.Value + (precioCM.Value * UtilidadM));
                    precioVM.Value = precio;
                }
            }

        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            quitar();
        }

        private void quitar()
        {
            if (modificar)
            {
                try
                {
                    if (MessageBox.Show("¿Deseas eliminar esta presentación?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                    {
                        prpr = new conexiones_BD.clases.presentaciones_productos(tabla_presentacion_producto.CurrentRow.Cells[0].Value.ToString());
                        if (prpr.eliminar(false) > 0)
                        {
                            cargarTablaPresentaciones();
                        }
                    }

                }
                catch
                {

                }
            }
            else
            {
                try
                {
                    if (MessageBox.Show("¿Deseas eliminar esta presentación?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                    {

                        tabla_presentacion_producto.Rows.RemoveAt(tabla_presentacion_producto.CurrentRow.Index);
                    }

                }
                catch
                {

                }
            }
        }

        private void btnAgrePro_Click(object sender, EventArgs e)
        {
            auxiliares.proveedores_productos pp = new auxiliares.proveedores_productos();
            if (Modificar)
            {
                pp.Modificar = this.Modificar;
                pp.Idproducto = this.idproducto;
                pp.ShowDialog();

            } else
            {
                if (tablaPermisosAsig == null)
                {
                    pp.ShowDialog();
                    if (pp.Agregrado)
                    {
                        tablaPermisosAsig = pp.tablaProveedores;
                    }
                }
                else
                {
                    pp.TabR = tablaPermisosAsig;
                    pp.ShowDialog();
                    if (pp.Agregrado)
                    {
                        tablaPermisosAsig = pp.tablaProveedores;
                    }
                }
            }
        }

        private void listaUtilidadDetalle_SelectedValueChanged(object sender, EventArgs e)
        {
            if (selecD)
            {
                if (!validarPrecioDetalle())
                {
                    DataRowView fila = (DataRowView)listaUtilidadDetalle.SelectedItem;
                    Decimal UtilidadD = Convert.ToDecimal(fila[3].ToString());

                    Decimal precio = (precioCD.Value + (precioCD.Value * UtilidadD));
                    precioVD.Value = precio;
                }
            }

        }

        private void cargarListas()
        {
            utilitarios.cargandoListas.cargarLista(conexiones_BD.clases.utilidades.datosTablaMayoreo(),
                listaMayoreo, "nombre", "idutilidad_compra");
            utilitarios.cargandoListas.cargarLista(conexiones_BD.clases.utilidades.datosTablaDetalle(),
                listaUtilidadDetalle, "nombre", "idutilidad_compra");
            utilitarios.cargandoListas.cargarLista(conexiones_BD.clases.marcas.datosTabla(),
                listaMarca, "nombre", "idmarca");
            utilitarios.cargandoListas.cargarLista(conexiones_BD.clases.categorias.datosTabla(),
                listaCategoria, "nombre_categoria", "idcategoria");
            utilitarios.cargandoListas.cargarLista(conexiones_BD.clases.estantes.datosTabla(),
                listaEstante, "nombre", "idestante");

            if (sesion.Datos[3].Equals("Administradores"))
            {
                utilitarios.cargandoListas.cargarLista(conexiones_BD.clases.sucursales.datosTabla(),
                listaSucursal, "numero_de_sucursal", "idsucursal");
            }
            else
            {
                utilitarios.cargandoListas.cargarLista(conexiones_BD.clases.sucursales.datosTabla(),
                listaSucursal, "numero_de_sucursal", "idsucursal");
                listaSucursal.SelectedValue = sesion.DatosRegistro[1];
                listaSucursal.Enabled = false;
            }

            utilitarios.cargandoListas.cargarLista(conexiones_BD.clases.categorias.datosTabla(),
                    listaCate, "nombre_categoria", "nombre_categoria");


        }

        private string generandoNuevoCodigo()
        {
            DateTime fecha = DateTime.Today;
            Int32 any = fecha.Year;
            Int32 hor = fecha.Day;
            Random alea = new Random();
            string codigo = any.ToString() + tablaPro.Rows.Count.ToString() + hor.ToString() + alea.Next(1, 1000).ToString();
            return codigo;
        }

        private void precioCM_ValueChanged(object sender, EventArgs e)
        {
            if (listaMayoreo.SelectedIndex != -1)
            {
                DataRowView fila = (DataRowView)listaMayoreo.SelectedItem;
                Decimal UtilidadM = Convert.ToDecimal(fila[3].ToString());

                Decimal precio = (precioCM.Value + (precioCM.Value * UtilidadM));
                precioVM.Value = precio;
            }
        }

        private void precioCD_ValueChanged(object sender, EventArgs e)
        {
            if (listaUtilidadDetalle.SelectedIndex != -1)
            {
                DataRowView fila = (DataRowView)listaUtilidadDetalle.SelectedItem;
                Decimal UtilidadD = Convert.ToDecimal(fila[3].ToString());

                Decimal precio = (precioCD.Value + (precioCD.Value * UtilidadD));
                precioVD.Value = precio;
            }
        }

        private bool validar()
        {
            bool valido = false;
            error4.Clear();
            string mensaje = "Tienes que elegir una opción";
            string mensaje1 = "No puedes dejar este campo a cero";
            string mensaje2 = "Tienes que agregar al menos un proveedor";
            string mensaje3 = "Tienes que ingresar al menos una presentación";
            string mensaje4 = "Tienes que agrear un codigo o más al producto";
            string mensaje5 = "No puedes dejar este campo vacio";

            if (txtnombreP.TextLength == 0)
            {
                valido = true;
                error4.SetError(txtnombreP, mensaje);
            }


            if (Modificar)
            {
                if (listaCodigos.SelectedIndex == -1)
                {
                    valido = true;
                    error4.SetError(listaCodigos, mensaje4);
                }
            }else {

                if (txtCodigo.TextLength == 0)
                {
                    valido = true;
                    error4.SetError(txtCodigo, mensaje5);
                }
            }
            
            if (listaMarca.SelectedIndex == -1)
            {
                valido = true;
                error4.SetError(listaMarca, mensaje);
            }
            if (listaCategoria.SelectedIndex == -1)
            {
                valido = true;
                error4.SetError(listaCategoria, mensaje);
            }
            if (listaSucursal.SelectedIndex == -1)
            {
                valido = true;
                error4.SetError(listaSucursal, mensaje);
            }
            if (listaEstante.SelectedIndex == -1)
            {
                valido = true;
                error4.SetError(listaEstante, mensaje);
            }
            if (!modificar)
            {
                if (tablaPermisosAsig == null)
                {
                    valido = true;
                    error4.SetError(btnAgrePro, mensaje2);
                }
            }
            if (precioCM.Value.ToString().Equals("0"))
            {
                valido = true;
                error4.SetError(precioCM, mensaje1);
            }
            if (precioCD.Value.ToString().Equals("0"))
            {
                valido = true;
                error4.SetError(precioCD, mensaje1);
            }
            if (precioVM.Value.ToString().Equals("0"))
            {
                valido = true;
                error4.SetError(precioVM, mensaje1);
            }
            if (precioVD.Value.ToString().Equals("0"))
            {
                valido = true;
                error4.SetError(precioVD, mensaje1);
            }
            if (existencias.Value.ToString().Equals("0"))
            {
                valido = true;
                error4.SetError(existencias, mensaje1);
            }
            if (listaMayoreo.SelectedIndex == -1)
            {
                valido = true;
                error4.SetError(listaMayoreo, mensaje);
            }
            if (listaUtilidadDetalle.SelectedIndex == -1)
            {
                valido = true;
                error4.SetError(listaUtilidadDetalle, mensaje);
            }
            if (!modificar)
            {
                if (tabla_presentacion_producto.Rows.Count == 0)
                {
                    valido = true;
                    error4.SetError(txtBuscarP, mensaje3);
                }
            }
            

            return valido;
        }

        
        private bool validarExistencias()
        {
            List<string> campos = new List<string>();
            List<string> valores = new List<string>();
            bool valido = false;
            campos.Add("codigo");
            campos.Add("estado");
            
            if (modificar)
            {
                valores.Add(listaCodigos.SelectedValue.ToString());
                valores.Add("1");
            }
            else
            {
                valores.Add(txtCodigo.Text);
                valores.Add("1");
            }
            

            conexiones_BD.clases.codigos pc = new conexiones_BD.clases.codigos(campos, valores);

            if (Modificar)
            {
                conexiones_BD.clases.codigos c = new conexiones_BD.clases.codigos(txtCodigo.Text, "1");
                if (c.validarCodigoActualizar())
                {
                    valido = true;
                    MessageBox.Show("No podemos ingresar el codigo, porque ya esta ingresado en la base", "Codigo duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    valido = false;
                }


            }
            else
            {
                conexiones_BD.clases.codigos c = new conexiones_BD.clases.codigos(txtCodigo.Text, "1");
                if (c.validarCodigo())
                {
                    valido = true;
                    MessageBox.Show("No podemos ingresar el codigo, porque ya esta ingresado en la base", "Codigo duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    valido = false;
                }
            }

            return valido;
        }

        //guarda productos
        private void guarda()
        {
            utilitarios.maneja_fechas fe = new utilitarios.maneja_fechas();
            string kar = "2";

            if (!validar())
            {
                if (!validarExistencias())
                {
                    pro = new conexiones_BD.clases.productos(
                        txtnombreP.Text.ToUpper(),
                        fe.fechaMysql(fecha),
                        listaCategoria.SelectedValue.ToString(),
                        listaMarca.SelectedValue.ToString());

                    codi = new conexiones_BD.clases.codigos(
                        txtCodigo.Text,
                        "1"
                        );

                    if (chkKardex.Checked)
                    {
                        kar = "1";
                    }
                    sp = new conexiones_BD.clases.sucursales_productos(
                        listaSucursal.SelectedValue.ToString(),
                        "0",
                        listaMayoreo.SelectedValue.ToString(),
                        listaUtilidadDetalle.SelectedValue.ToString(),
                        listaEstante.SelectedValue.ToString(),
                        existencias.Value.ToString(),
                        precioVD.Value.ToString(),
                        precioCD.Value.ToString(),
                        precioVM.Value.ToString(),
                        precioCM.Value.ToString(),
                        kar);

                    op = new conexiones_BD.operaciones();
                    if(op.transaccionProductos_Presentaciones_Proveedores(generaProveedores(), generaPresentaciones(), pro, sp, codi) > 0)
                    {
                        MessageBox.Show("Los productos se ingresarón","Exíto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //xm._AñadirProductos(listaCodigos.SelectedValue.ToString(),
                        //txtnombreP.Text.ToUpper(),
                        //fe.fechaMysql(fecha),
                        //listaCategoria.SelectedValue.ToString(),
                        //listaMarca.SelectedValue.ToString(), Convert.ToInt16(sesion.DatosRegistro[0]));
                        //xm._AñadirSucursal_productos(
                        //                listaSucursal.SelectedValue.ToString(),
                        //                "0",
                        //                listaMayoreo.SelectedValue.ToString(),
                        //                listaUtilidadDetalle.SelectedValue.ToString(),
                        //                listaEstante.SelectedValue.ToString(),
                        //                existencias.Value.ToString(),
                        //                precioVD.Value.ToString(),
                        //                precioCD.Value.ToString(),
                        //                precioVM.Value.ToString(),
                        //                precioCM.Value.ToString(),
                        //                kar, listaCodigos.SelectedValue.ToString(), Convert.ToInt16(sesion.DatosRegistro[0]));

                        //this.generarProveedoresBase_datos();
                        //this.generaPresentancionesBase();

                        vaciar();
                    } else
                    {
                        MessageBox.Show("Los productos no se pudierón ingresar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private List<conexiones_BD.clases.proveedores_productos> generaProveedores()
        {
            List<conexiones_BD.clases.proveedores_productos> pro = new List<conexiones_BD.clases.proveedores_productos>();

            foreach (DataGridViewRow fila in tablaPermisosAsig.Rows)
            {
                pro.Add(new conexiones_BD.clases.proveedores_productos(fila.Cells[1].Value.ToString(), "0"));
            }

            return pro;
        }

        //private void generarProveedoresBase_datos()
        //{
        //    foreach (DataGridViewRow fila in tablaPermisosAsig.Rows)
        //    {
        //        xm._AñadirProvedores_productos(fila.Cells[1].Value.ToString(), "0", listaCodigos.SelectedValue.ToString(), Convert.ToInt16(sesion.DatosRegistro[0]));
        //    }
        //}

        private void btnNuevamarca_Click(object sender, EventArgs e)
        {
            mantenimientos.marcas marca = new marcas();
            marca.ShowDialog();
            if (marca.Agregado)
            {
                utilitarios.cargandoListas.cargarLista(conexiones_BD.clases.marcas.datosTabla(),
                listaMarca, "nombre", "idmarca");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            categorias cat = new categorias();
            cat.ShowDialog();
            if (cat.Agregado)
            {
                utilitarios.cargandoListas.cargarLista(conexiones_BD.clases.categorias.datosTabla(),
                listaCategoria, "nombre_categoria", "idcategoria");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sucursales suc = new sucursales();
            suc.ShowDialog();
            if (suc.Agregado)
            {
                if (sesion.Datos[3].Equals("Administradores"))
                {
                    utilitarios.cargandoListas.cargarLista(conexiones_BD.clases.sucursales.datosTabla(),
                    listaSucursal, "numero_de_sucursal", "idsucursal");
                }
                else
                {
                    utilitarios.cargandoListas.cargarLista(conexiones_BD.clases.sucursales.datosTabla(),
                    listaSucursal, "numero_de_sucursal", "idsucursal");
                    listaSucursal.SelectedValue = sesion.DatosRegistro[1];
                    listaSucursal.Enabled = false;
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            estantes est = new estantes();
            est.ShowDialog();
            if (est.Agregado)
            {
                utilitarios.cargandoListas.cargarLista(conexiones_BD.clases.estantes.datosTabla(),
                listaEstante, "nombre", "idestante");
            }
        }

        private void txtnombreP_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void btnGenerarCodigo_Click_1(object sender, EventArgs e)
        {
            //Generacion de codigos

            //if (listaCodigos.SelectedIndex==-1)
            //{
            //    if (MessageBox.Show("¿Quieres que el sistema genere el código?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            //    {
            //        mantenimientos.codigos.codigo_barras cod = new mantenimientos.codigos.codigo_barras();
            //        cod.txtCodigo.Text = generandoNuevoCodigo();
            //        cod.ShowDialog();

            //        if (cod.Guardado)
            //        {
            //            txtCodigo.Text = cod.txtCodigo.Text;
            //        }
            //    }
            //    else
            //    {
            //        mantenimientos.codigos.codigo_barras cod = new mantenimientos.codigos.codigo_barras();
            //        cod.txtCodigo.Text = txtCodigo.Text;
            //        cod.ShowDialog();

            //        if (cod.Guardado)
            //        {
            //            txtCodigo.Text = cod.txtCodigo.Text;
            //        }
            //    }
            //}else
            //{
            //    mantenimientos.codigos.codigo_barras cod = new mantenimientos.codigos.codigo_barras();
            //    cod.txtCodigo.Text = generandoNuevoCodigo();
            //    cod.ShowDialog();

            //    if (cod.Guardado)
            //    {
            //        txtCodigo.Text = cod.txtCodigo.Text;
            //    }
            //}
            
            
        }

        private void precioCM_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);  
            }
            if (e.KeyCode==Keys.Right)
            {
                agrega();
            }
            if (e.KeyCode==Keys.Left)
            {    
                    quitar();
            }
            
        }

        private List<conexiones_BD.clases.presentaciones_productos> generaPresentaciones()
        {
            List<conexiones_BD.clases.presentaciones_productos> pp = new List<conexiones_BD.clases.presentaciones_productos>();

            foreach (DataGridViewRow fila in tabla_presentacion_producto.Rows)
            {
                pp.Add(new conexiones_BD.clases.presentaciones_productos("0", fila.Cells[1].Value.ToString(), fila.Cells[5].Value.ToString(), fila.Cells[3].Value.ToString(), fila.Cells[6].Value.ToString(),"2", "1"));
            }

            return pp;
        }

        private void generaPresentancionesBase()
        {
            foreach (DataGridViewRow fila in tabla_presentacion_producto.Rows)
            {
                xm._AñadirPrese_prod("0", fila.Cells[1].Value.ToString(), fila.Cells[5].Value.ToString(), fila.Cells[3].Value.ToString(), fila.Cells[6].Value.ToString(), "2", listaCodigos.SelectedValue.ToString(), Convert.ToInt16(sesion.DatosRegistro[0]));
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (modificar)
            {
                elimina();
            }else
            {
                this.Close();
            }
        }

        private void precioCM_Enter(object sender, EventArgs e)
        {
            precioCM.Select(0, precioCM.Text.Length);
        }

        private void precioCD_Enter(object sender, EventArgs e)
        {
            precioCD.Select(0, precioCD.Text.Length);
        }

        private void existencias_Enter(object sender, EventArgs e)
        {
            existencias.Select(0, existencias.Text.Length);
        }

        private void chkCategoria_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCategoria.Checked)
            {
                
                txtBuscar.Text = "";
                listaCate.Visible = true;
            }
        }

        private void chkNombre_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNombre.Checked)
            {
                txtBuscar.Visible = true;
                txtBuscar.Text = "";
                listaCate.Visible = false;
            }
        }

        private void chkCodi_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCodi.Checked)
            {
                txtBuscar.Visible = true;
                txtBuscar.Text = "";
                listaCate.Visible = false;

            }
        }

        private void listaCate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cargado)
            {
                try
                {
                    if (listaCate.Items.Count!=0)
                    {
                        txtBuscar.Text = listaCate.SelectedValue.ToString();
                    }
                    
                }
                catch
                {

                }
                
            }
        }

        private void btnAgregarCodigo_Click(object sender, EventArgs e)
        {
            auxiliares.agregaCodigos codi = new auxiliares.agregaCodigos();
            codi.Idproducto = this.idproducto;
            Console.WriteLine(idproducto);
            codi.ShowDialog();
            if (codi.Listo)
            {
                this.cargarCodigos();
            }
        }

        private void habilitar(bool con)
        {
            List<Control> controles = new List<Control>();
            controles.Add(txtnombreP);
            controles.Add(listaCodigos);
            controles.Add(listaMarca);
            controles.Add(listaCategoria);
            controles.Add(listaSucursal);
            controles.Add(listaEstante);
            controles.Add(btnAgrePro);
            controles.Add(precioCM);
            controles.Add(precioVM);
            controles.Add(precioCD);
            controles.Add(precioVD);
            controles.Add(listaMayoreo);
            controles.Add(listaUtilidadDetalle);
            controles.Add(existencias);
            controles.Add(txtBuscarP);
            controles.Add(tabla_presentacion_producto);
            controles.Add(fecha);
            controles.Add(btnGenerarCodigo);
            controles.Add(btnNuevamarca);
            controles.Add(button1);
            controles.Add(button2);
            controles.Add(button3);
            controles.Add(button5);
            controles.Add(tabla_presentacion);
            controles.Add(btnAgregar);
            controles.Add(btnQuitar);
            controles.Add(btnGuardar);
            controles.Add(btnCancelar);
            controles.Add(btnAgregarCodigo);

            utilitarios.vaciando_formularios.habilitandoTexbox(controles, con);
        }

        private void cargarCodigos()
        {
            utilitarios.cargandoListas.cargarLista(conexiones_BD.clases.codigos.cargarCodigos(this.idproducto),
                listaCodigos, "codigo", "idcodigo");
            listaCodigos.SelectedIndex = 0;
        }

        private void tablaPro_Click(object sender, EventArgs e)
        {
            try
            {
                if (modificar)
                {
                    habilitar(true);
                    selecD = false;
                    selecM = false;
                    idsucusal_producto = tablaPro.CurrentRow.Cells[0].Value.ToString();
                    Console.WriteLine(idsucusal_producto);
                    idproducto = tablaPro.CurrentRow.Cells[1].Value.ToString();
                    txtCodigo.Text = tablaPro.CurrentRow.Cells[2].Value.ToString();
                    codigo = tablaPro.CurrentRow.Cells[2].Value.ToString();
                    txtnombreP.Text = tablaPro.CurrentRow.Cells[3].Value.ToString();
                    cargarCodigos();
                    nombre = tablaPro.CurrentRow.Cells[3].Value.ToString();
                    listaCategoria.SelectedValue = tablaPro.CurrentRow.Cells[4].Value.ToString();
                    listaMarca.SelectedValue = tablaPro.CurrentRow.Cells[6].Value.ToString();
                    listaSucursal.SelectedValue = tablaPro.CurrentRow.Cells[8].Value.ToString();
                    listaEstante.SelectedValue = tablaPro.CurrentRow.Cells[10].Value.ToString();
                    fecha.Text = tablaPro.CurrentRow.Cells[12].Value.ToString();
                    precioCM.Value = Convert.ToDecimal(tablaPro.CurrentRow.Cells[19].Value.ToString());
                    listaMayoreo.SelectedValue = tablaPro.CurrentRow.Cells[13].Value.ToString();
                    precioVM.Value = Convert.ToDecimal(tablaPro.CurrentRow.Cells[21].Value.ToString());
                    precioCD.Value = Convert.ToDecimal(tablaPro.CurrentRow.Cells[20].Value.ToString());
                    listaUtilidadDetalle.SelectedValue = tablaPro.CurrentRow.Cells[16].Value.ToString();
                    precioVD.Value = Convert.ToDecimal(tablaPro.CurrentRow.Cells[22].Value.ToString());
                    existencias.Value = Convert.ToDecimal(tablaPro.CurrentRow.Cells[23].Value.ToString());

                    if (tablaPro.CurrentRow.Cells[24].Value.Equals("SI"))
                    {
                        chkKardex.Checked = true;
                    }else
                    {
                        chkKardex.Checked = false;
                    }
                    cargarTablaPresentaciones();
                    selecD = true;
                    selecM = true;
                }
            }
            catch
            {

            }

        }

        private void vaciar()
        {
            selecD = false;
            selecM = false;
            txtnombreP.Text = "";
            listaCodigos.SelectedValue = "0";
            listaMarca.SelectedValue = "0";
            listaCategoria.SelectedValue = "0";
            listaSucursal.SelectedValue = "0";
            listaEstante.SelectedValue = "0";
            tablaPermisosAsig = null;
            precioCM.Value = 0;
            precioVM.Value = 0;
            precioCD.Value = 0;
            precioVD.Value = 0;
            listaMayoreo.SelectedValue = "0";
            listaUtilidadDetalle.SelectedValue = "0";
            existencias.Value = 0;
            txtBuscarP.Text = "";
            if (modificar)
            {
                tabla_presentacion_producto.DataSource = null;
            }
            else
            {
                tabla_presentacion_producto.Rows.Clear();
            }
            
            cargarTablas();
            selecD = true;
            selecM = true;
            txtnombreP.SelectAll();
            txtnombreP.Focus();

        }

        private void modifica()
        {
            utilitarios.maneja_fechas fe = new utilitarios.maneja_fechas();
            string kar = "2";
            if (!validar())
            {
                if (!validarExistencias())
                {
                    if (chkKardex.Checked)
                    {
                        kar = "1";
                    }
                    sp = new conexiones_BD.clases.sucursales_productos(
                           this.idsucusal_producto,
                           listaSucursal.SelectedValue.ToString(),
                           this.idproducto,
                           listaMayoreo.SelectedValue.ToString(),
                           listaUtilidadDetalle.SelectedValue.ToString(),
                           listaEstante.SelectedValue.ToString(),
                           existencias.Value.ToString(),
                           precioVD.Value.ToString(),
                           precioCD.Value.ToString(),
                           precioVM.Value.ToString(),
                           precioCM.Value.ToString(),
                           kar);

                    pro = new conexiones_BD.clases.productos(
                        txtnombreP.Text.ToUpper(),
                        fe.fechaMysql(fecha),
                        listaCategoria.SelectedValue.ToString(),
                        listaMarca.SelectedValue.ToString(),
                         this.idproducto);

                    op = new conexiones_BD.operaciones();
                    if (op.EjecutartransaccionModificarProducto(sp, pro) > 0)
                    {
                        cargarTablas();
                        MessageBox.Show("Se actualizo con exíto", "Exíto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        vaciar();
                        habilitar(false);
                    }
                    
                }
            }
        }

        private void elimina()
        {
            try
            {
                sp = new conexiones_BD.clases.sucursales_productos(idsucusal_producto);
                pro = new conexiones_BD.clases.productos(idproducto);

                op = new conexiones_BD.operaciones();
                if (op.EjecutartransaccionEliminarProducto(sp, pro) > 0)
                {
                    cargarTablas();
                    MessageBox.Show("El producto se elimino con exíto", "Exíto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    vaciar();
                    habilitar(false);
                } else
                {
                    MessageBox.Show("No se puede eliminar es posible que tenga dependencias", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch
            {

            }
        }

        private void cargarTablaPresentaciones()
        {
            tabla3 = new utilitarios.cargar_tablas(tabla_presentacion_producto, new TextBox(), conexiones_BD.clases.presentaciones_productos.presentacionesXproducto(idsucusal_producto),"nombre_presentacion");
            tabla3.cargarSinContadorRegistros();
        }

    }
}
