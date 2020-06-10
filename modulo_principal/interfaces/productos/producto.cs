using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfaces.productos
{

    public partial class producto : Form
    {
        string idsuc_produ, idproducto, idpresentacion_producto, utili_m, utili_d, pv, pc, pvm, pcm, 
            idmarca, idcategoria, idestante, kardex;
        DataTable presentaciones, presentacion, proveedores, marcas, categorias, estantes, mayoreo, detalle;
        conexiones_BD.clases.presentaciones_productos prpr;
        conexiones_BD.clases.proveedores_productos pr;
        conexiones_BD.clases.sucursales_productos sp;
        conexiones_BD.clases.productos pro;
        conexiones_BD.operaciones op;
        utilitarios.cargar_tablas tablas_presentaciones, tabla_proveedores;
        bool actualizarTablas = true, actualiza=false;
        sessionManager.secion sesion = sessionManager.secion.Instancia;
        

        public string Idsuc_produ
        {
            get
            {
                return idsuc_produ;
            }

            set
            {
                idsuc_produ = value;
            }
        }

        public string Idproducto
        {
            get
            {
                return idproducto;
            }

            set
            {
                idproducto = value;
            }
        }

        public string Utili_m
        {
            get
            {
                return utili_m;
            }

            set
            {
                utili_m = value;
            }
        }

        public string Utili_d
        {
            get
            {
                return utili_d;
            }

            set
            {
                utili_d = value;
            }
        }

        public string Pv
        {
            get
            {
                return pv;
            }

            set
            {
                pv = value;
            }
        }

        public string Pc
        {
            get
            {
                return pc;
            }

            set
            {
                pc = value;
            }
        }

        public string Pvm
        {
            get
            {
                return pvm;
            }

            set
            {
                pvm = value;
            }
        }

        public string Pcm
        {
            get
            {
                return pcm;
            }

            set
            {
                pcm = value;
            }
        }

        public bool Actualiza
        {
            get
            {
                return actualiza;
            }

            set
            {
                actualiza = value;
            }
        }

        public DataTable Marcas
        {
            get
            {
                return marcas;
            }

            set
            {
                marcas = value;
            }
        }

        public DataTable Categorias
        {
            get
            {
                return categorias;
            }

            set
            {
                categorias = value;
            }
        }

        public DataTable Estantes
        {
            get
            {
                return estantes;
            }

            set
            {
                estantes = value;
            }
        }

        public DataTable Mayoreo
        {
            get
            {
                return mayoreo;
            }

            set
            {
                mayoreo = value;
            }
        }

        public DataTable Detalle
        {
            get
            {
                return detalle;
            }

            set
            {
                detalle = value;
            }
        }

        public string Idmarca
        {
            get
            {
                return idmarca;
            }

            set
            {
                idmarca = value;
            }
        }

        public string Idcategoria
        {
            get
            {
                return idcategoria;
            }

            set
            {
                idcategoria = value;
            }
        }

        public string Idestante
        {
            get
            {
                return idestante;
            }

            set
            {
                idestante = value;
            }
        }

        public string Kardex
        {
            get
            {
                return kardex;
            }

            set
            {
                kardex = value;
            }
        }

        public producto()
        {
            InitializeComponent();
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarCodigo_Click(object sender, EventArgs e)
        {
            mantenimientos.auxiliares.agregaCodigos codi = new mantenimientos.auxiliares.agregaCodigos();
            codi.Idproducto = this.idproducto;
            Console.WriteLine(idproducto);
            codi.ShowDialog();

            if (codi.Listo)
            {
                cargarCodigos();
            }
        }

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            gadgets.movimimientos mov = new gadgets.movimimientos();
            mov.moverFormulario(sender, e, this);
        }

        private void tabla_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (tabla.SelectedIndex == 1)
            {
                if (actualizarTablas || tabla_presentacion_producto.RowCount == 0)
                {
                    this.cargarTablaPresentaciones();
                }
                
            } else if (tabla.SelectedIndex == 2)
            {
                if(actualizarTablas || tablaProveedores.RowCount == 0)
                {
                    this.cargarTablasProveedores();
                }

            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            mantenimientos.procesos_iniciales.agregaPresentaciones pre = new mantenimientos.procesos_iniciales.agregaPresentaciones();
            pre.Codigo = txtCodigo.Text;
            pre.ShowDialog();

            if (pre.IngresadoN)
            {
                cargarTablaPresentaciones();
            }
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            if (precio.Value!=0)
            {
                if (MessageBox.Show("¿Deseas modificar esta presentación?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                {
                    modificar();
                }
            }
            
        }

        private bool verificarRepetido()
        {
            bool repetido = false;
            if (tablaProveedores.Rows.Count != 0)
            {
                foreach (DataGridViewRow fila in tablaProveedores.Rows)
                {
                    if (fila.Cells[1].Value.ToString().Equals(listaProveedores.SelectedValue.ToString()))
                    {
                        repetido = true;
                    }
                }
            }

            return repetido;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas modicar la información del producto?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                modifica();
            }
        }

        private void btnAgr_Click(object sender, EventArgs e)
        {
            if (listaProveedores.SelectedIndex != -1)
            {
                if (!verificarRepetido())
                {
                    pr = new conexiones_BD.clases.proveedores_productos(
                    listaProveedores.SelectedValue.ToString(),
                    idproducto
                    );

                    if (pr.guardar(false) > 0)
                    {
                        cargarTablasProveedores();
                    }
                }
            }
        }

        private void btnEli_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Desea quitar este proveedor?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                {
                    if (tablaProveedores.RowCount != 0)
                    {
                        pr = new conexiones_BD.clases.proveedores_productos(
                        tablaProveedores.CurrentRow.Cells[0].Value.ToString()
                        );

                        if (pr.eliminar(false) > 0)
                        {
                            cargarTablasProveedores();
                        }
                    }
                }
                
            }
            catch
            {

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (chkD.Checked || chkM.Checked)
            {
                if (MessageBox.Show("¿Desea quitar esta presentación?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                {
                    try
                    {
                        prpr = new conexiones_BD.clases.presentaciones_productos(tabla_presentacion_producto.CurrentRow.Cells[0].Value.ToString());
                        if (prpr.eliminar(false) > 0)
                        {
                            cargarTablaPresentaciones();
                        }
                    }
                    catch
                    {

                    }
                }
            }
        }

        private void producto_Load(object sender, EventArgs e)
        {
            gadgets.horientaciones_textos.colocarTitulo(panelTitulo, lblEncanezado);
            cargarListas();
            cargandoUtilidades();
        }

        private void cargarListas()
        {
            utilitarios.cargandoListas.cargarLista(marcas, listaMarca, "nombre", "idmarca");
            //utilitarios.cargandoListas.establecerValor(pr.listaMarca, tablad.CurrentRow.Cells[15].Value.ToString());
            utilitarios.cargandoListas.cargarLista(categorias, listaCategoria, "nombre_categoria", "idcategoria");
            //utilitarios.cargandoListas.establecerValor(pr.listaCategoria, tablad.CurrentRow.Cells[16].Value.ToString());
            utilitarios.cargandoListas.cargarLista(estantes, listaEstante, "nombre", "idestante");


            utilitarios.cargandoListas.cargarLista(mayoreo, listaMayoreo, "nombre", "idutilidad_compra");
            utilitarios.cargandoListas.cargarLista(detalle, listaUtilidadDetalle, "nombre", "idutilidad_compra");
            cargarCodigos();
            cargarValores();
        }

        private void cargarCodigos()
        {
            DataTable codigos = conexiones_BD.clases.codigos.cargarCodigos(this.idproducto);
            
            if (codigos.Rows.Count>0)
            {
                utilitarios.cargandoListas.cargarLista(codigos,
                listaCodigos, "codigo", "idcodigo");
                listaCodigos.SelectedIndex = 0;
            }else
            {
                listaCodigos.DataSource = null;
                listaCodigos.Items.Add("No existen codigos activos");
            }
            
        }

        private void cargarValores()
        {
            listaMarca.SelectedValue = idmarca;
            listaCategoria.SelectedValue = idcategoria;

            if (!idestante.Equals(""))
            {
                listaEstante.SelectedValue = idestante;
            }
            if (kardex.Equals("SI"))
            {
                chkKardex.Checked = true;
            }
            

        }

        private void tabla_presentacion_producto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tabla_presentacion_producto.RowCount != 0)
            {
                idpresentacion_producto = tabla_presentacion_producto.CurrentRow.Cells[0].Value.ToString();
                listaPresentacion.SelectedValue = tabla_presentacion_producto.CurrentRow.Cells[1].Value.ToString();
                precio.Text = tabla_presentacion_producto.CurrentRow.Cells[3].Value.ToString();
                canti.Text = tabla_presentacion_producto.CurrentRow.Cells[5].Value.ToString();
                if (tabla_presentacion_producto.CurrentRow.Cells[4].Value.ToString().Equals("Detalle"))
                {
                    chkD.Checked = true;
                    chkD.Focus();
                    chkM.Checked = false;
                }
                else
                {
                    chkD.Checked = false;
                    chkM.Checked = true;
                    chkM.Focus();
                }

                if (tabla_presentacion_producto.CurrentRow.Cells[7].Value.ToString().Equals("1"))
                {
                    chkPriori.Checked = true;
                }
                else
                {
                    chkPriori.Checked = false;
                }

                if (tabla_presentacion_producto.CurrentRow.Cells[8].Value.ToString().Equals("Activo"))
                {
                    chkEstado.Checked = true;
                }else
                {
                    chkEstado.Checked = false;
                }
            }
        }

        private void cargarTablaPresentaciones()
        {
            presentaciones = conexiones_BD.clases.presentaciones_productos.presentacionesXproducto(Idsuc_produ);
            presentacion = conexiones_BD.clases.presentaciones.datosTabla();
            utilitarios.cargandoListas.cargarLista(presentacion, listaPresentacion, "nombre_presentacion", "idpresentacion");
            tablas_presentaciones = new utilitarios.cargar_tablas(tabla_presentacion_producto, new TextBox(), presentaciones, "nombre_presentacion");
            tablas_presentaciones.cargarSinContadorRegistros();
            actualizarTablas = false;
        }

        private void cargarTablasProveedores()
        {
            proveedores = conexiones_BD.clases.proveedores.datosTabla();
            utilitarios.cargandoListas.cargarLista(proveedores, listaProveedores, "nombre_proveedor", "idproveedor");
            tabla_proveedores = new utilitarios.cargar_tablas(tablaProveedores, new TextBox(), conexiones_BD.clases.proveedores_productos.datosTabla(idproducto), "nombre_proveedor");
            tabla_proveedores.cargarSinContadorRegistros();
            actualizarTablas = false;
        }

        private void cargandoUtilidades()
        {
            precioCM.Value = Convert.ToDecimal(pcm);
            precioVM.Value = Convert.ToDecimal(pvm);
            precioCD.Value = Convert.ToDecimal(pc);
            precioVD.Value = Convert.ToDecimal(pv);

            if (utili_m.Equals(""))
            {
                listaMayoreo.SelectedValue = 2;
            }else
            {
                listaMayoreo.SelectedValue = utili_m;
            }

            if (utili_d.Equals(""))
            {
                listaUtilidadDetalle.SelectedValue = 4;
            }else
            {
                listaUtilidadDetalle.SelectedValue = utili_d;
            }

            actualizarTablas = false;
        }

        private void modificar()
        {
            string prio = "2", esta="2";
            if (chkPriori.Checked)
            {
                prio = "1";
            }
            if (chkEstado.Checked)
            {
                esta = "1";
            }
            prpr = new conexiones_BD.clases.presentaciones_productos(
                idpresentacion_producto,
                idsuc_produ,
                listaPresentacion.SelectedValue.ToString(),
                canti.Value.ToString(),
                precio.Value.ToString(),
                tipoPrese(),
                prio,
                esta);

            if (prpr.modificar(true) > 0)
            {
                limpiar();

            }
        }

        private void limpiar()
        {
            precio.Value = 0;
            canti.Value = 0;
            tabla_presentacion_producto.DataSource = null;
            chkPriori.Checked = false;
            chkM.Checked = false;
            chkD.Checked = false;
            cargarTablaPresentaciones();
        }

        private string tipoPrese()
        {
            if (chkM.Checked)
            {
                return "1";
            }
            else
            {
                return "2";
            }
        }

        private bool validar()
        {
            bool valido = false;
            error4.Clear();
            string mensaje = "Tienes que elegir una opción";
            string mensaje1 = "No puedes dejar este campo a cero";

            if (txtCodigo.TextLength == 0)
            {
                valido = true;
                error4.SetError(txtCodigo, mensaje);
            }
            if (txtNombre.TextLength == 0)
            {
                valido = true;
                error4.SetError(txtNombre, mensaje);
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
            if (listaEstante.SelectedIndex == -1)
            {
                valido = true;
                error4.SetError(listaEstante, mensaje);
            }
            
            
            if (existencia.Value.ToString().Equals("0"))
            {
                valido = true;
                error4.SetError(existencia, mensaje1);
            }

            return valido;
        }

        private void modifica()
        {
            utilitarios.maneja_fechas fe = new utilitarios.maneja_fechas();
            string kar = "2";
            if (!validar())
            {
               
                    if (chkKardex.Checked)
                    {
                        kar = "1";
                    }
                    sp = new conexiones_BD.clases.sucursales_productos(
                           this.idsuc_produ,
                           sesion.DatosRegistro[1],
                           this.idproducto,
                           listaMayoreo.SelectedValue.ToString(),
                           listaUtilidadDetalle.SelectedValue.ToString(),
                           listaEstante.SelectedValue.ToString(),
                           existencia.Value.ToString(),
                           precioVD.Value.ToString(),
                           precioCD.Value.ToString(),
                           precioVM.Value.ToString(),
                           precioCM.Value.ToString(),
                           kar);
                

                    pro = new conexiones_BD.clases.productos(
                        txtNombre.Text.ToUpper(),
                        fe.fechaMysql(fecha),
                        listaCategoria.SelectedValue.ToString(),
                        listaMarca.SelectedValue.ToString(),
                        this.idproducto);

                    op = new conexiones_BD.operaciones();
                    if (op.EjecutartransaccionModificarProducto(sp, pro) > 0)
                    {     
                        MessageBox.Show("Se actualizo con exíto", "Exíto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Actualiza = true;
                }
            }
        }
    }
}
