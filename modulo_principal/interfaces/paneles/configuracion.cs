using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfaces.paneles
{
    public partial class configuracion : Form
    {
        sessionManager.secion sesion = sessionManager.secion.Instancia;
        public configuracion()
        {
            InitializeComponent();
        }

        private void arribaEmpl_Click(object sender, EventArgs e)
        {
            gadgets.slider fun = new gadgets.slider(DetallesE, imagenE, arribaEmpl, abajoEm);
            fun.despliegue();
        }

        private void abajoEm_Click(object sender, EventArgs e)
        {
            gadgets.slider fun = new gadgets.slider(DetallesE, imagenE, arribaEmpl, abajoEm);
            fun.despliegue();
        }

        private void arribaPer_Click(object sender, EventArgs e)
        {
            gadgets.slider fun = new gadgets.slider(detallePer, imagenPer, arribaPer, abajoPer);
            fun.despliegue();
        }

        private void abajoPer_Click(object sender, EventArgs e)
        {
            gadgets.slider fun = new gadgets.slider(detallePer, imagenPer, arribaPer, abajoPer);
            fun.despliegue();
        }

        private void arribaC_Click(object sender, EventArgs e)
        {
            gadgets.slider fun = new gadgets.slider(detallesCar, imagenC, arribaC, abajoC);
            fun.despliegue();
        }

        private void abajoC_Click(object sender, EventArgs e)
        {
            gadgets.slider fun = new gadgets.slider(detallesCar, imagenC, arribaC, abajoC);
            fun.despliegue();
        }

        private void pictureBox39_Click(object sender, EventArgs e)
        {
            gadgets.slider fun = new gadgets.slider(detallesUsua, imagenUsuarios, pictureBox39, abajoUsu);
            fun.despliegue();
        }

        private void abajoUsu_Click(object sender, EventArgs e)
        {
            gadgets.slider fun = new gadgets.slider(detallesUsua, imagenUsuarios, pictureBox39, abajoUsu);
            fun.despliegue();
        }

        private void arribaMarca_Click(object sender, EventArgs e)
        {
            gadgets.slider fun = new gadgets.slider(destallesMa, imagenMarca, arribaMarca, abajoMarca);
            fun.despliegue();
        }

        private void abajoMarca_Click(object sender, EventArgs e)
        {
            gadgets.slider fun = new gadgets.slider(destallesMa, imagenMarca, arribaMarca, abajoMarca);
            fun.despliegue();
        }

        private void arribaPro_Click(object sender, EventArgs e)
        {
            gadgets.slider fun = new gadgets.slider(destallePro, imagenProductos, arribaPro, abajoPro);
            fun.despliegue();
        }

        private void abajoPro_Click(object sender, EventArgs e)
        {
            gadgets.slider fun = new gadgets.slider(destallePro, imagenProductos, arribaPro, abajoPro);
            fun.despliegue();
        }

        private void arribaCat_Click(object sender, EventArgs e)
        {
            gadgets.slider fun = new gadgets.slider(detallesCat, imagenCate, arribaCat, abajoCat);
            fun.despliegue();
        }

        private void abajoCat_Click(object sender, EventArgs e)
        {
            gadgets.slider fun = new gadgets.slider(detallesCat, imagenCate, arribaCat, abajoCat);
            fun.despliegue();
        }

        private void arribaEsta_Click(object sender, EventArgs e)
        {
            gadgets.slider fun = new gadgets.slider(detallesEsta, imagenEsta, arribaEsta, abajoEstan);
            fun.despliegue();
        }

        private void abajoEstan_Click(object sender, EventArgs e)
        {
            gadgets.slider fun = new gadgets.slider(detallesEsta, imagenEsta, arribaEsta, abajoEstan);
            fun.despliegue();
        }

        private void arribaPres_Click(object sender, EventArgs e)
        {
            gadgets.slider fun = new gadgets.slider(detallesPres, imagenPrese, arribaPres, abajoPres);
            fun.despliegue();
        }

        private void abajoPres_Click(object sender, EventArgs e)
        {
            gadgets.slider fun = new gadgets.slider(detallesPres, imagenPrese, arribaPres, abajoPres);
            fun.despliegue();
        }

        private void arribaUti_Click(object sender, EventArgs e)
        {
            gadgets.slider fun = new gadgets.slider(detallesUtili, imgUtili, arribaUti, abajoUti);
            fun.despliegue();
        }

        private void abajoUti_Click(object sender, EventArgs e)
        {
            gadgets.slider fun = new gadgets.slider(detallesUtili, imgUtili, arribaUti, abajoUti);
            fun.despliegue();
        }

        private void arrivaProv_Click(object sender, EventArgs e)
        {
            gadgets.slider fun = new gadgets.slider(detallesProv, imagenProve, arrivaProv, abajoProv);
            fun.despliegue();
        }

        private void abajoProv_Click(object sender, EventArgs e)
        {
            gadgets.slider fun = new gadgets.slider(detallesProv, imagenProve, arrivaProv, abajoProv);
            fun.despliegue();
        }

        private void arribaDesc_Click(object sender, EventArgs e)
        {
            gadgets.slider fun = new gadgets.slider(detallesDesc, imagenDesc, arribaDesc, abajoDesc);
            fun.despliegue();
        }

        private void abajoDesc_Click(object sender, EventArgs e)
        {
            gadgets.slider fun = new gadgets.slider(detallesDesc, imagenDesc, arribaDesc, abajoDesc);
            fun.despliegue();
        }

        private void arribaTiposC_Click(object sender, EventArgs e)
        {
            gadgets.slider fun = new gadgets.slider(detallesTiposC, imagenTiposC, arribaTiposC, abajoTiposC);
            fun.despliegue();
        }

        private void abajoTiposC_Click(object sender, EventArgs e)
        {
            gadgets.slider fun = new gadgets.slider(detallesTiposC, imagenTiposC, arribaTiposC, abajoTiposC);
            fun.despliegue();
        }

        private void arribaSuc_Click(object sender, EventArgs e)
        {
            gadgets.slider fun = new gadgets.slider(detallesSuc, imagenSucur, arribaSuc, abajoSuc);
            fun.despliegue();
        }

        private void abajoSuc_Click(object sender, EventArgs e)
        {
            gadgets.slider fun = new gadgets.slider(detallesSuc, imagenSucur, arribaSuc, abajoSuc);
            fun.despliegue();
        }

        private void arribaTiposF_Click(object sender, EventArgs e)
        {
            gadgets.slider fun = new gadgets.slider(detalesTiposF, imagenTiposF, arribaTiposF, abajoTiposF);
            fun.despliegue();
        }

        private void abajoTiposF_Click(object sender, EventArgs e)
        {
            gadgets.slider fun = new gadgets.slider(detalesTiposF, imagenTiposF, arribaTiposF, abajoTiposF);
            fun.despliegue();
        }

        private void arribaFormasP_Click(object sender, EventArgs e)
        {
            gadgets.slider fun = new gadgets.slider(detallesFormasP, imagenFormasP, arribaFormasP, abajoFormasP);
            fun.despliegue();
        }

        private void abajoFormasP_Click(object sender, EventArgs e)
        {
            gadgets.slider fun = new gadgets.slider(detallesFormasP, imagenFormasP, arribaFormasP, abajoFormasP);
            fun.despliegue();
        }

        private void arribaClientes_Click(object sender, EventArgs e)
        {
            gadgets.slider fun = new gadgets.slider(detallesClientes, imagenClientes, arribaClientes, abajoClientes);
            fun.despliegue();
        }

        private void abajoClientes_Click(object sender, EventArgs e)
        {
            gadgets.slider fun = new gadgets.slider(detallesClientes, imagenClientes, arribaClientes, abajoClientes);
            fun.despliegue();
        }

        private void arribaTiposG_Click(object sender, EventArgs e)
        {
            gadgets.slider fun = new gadgets.slider(detallesTipoG, imagenTiposG, arribaTiposG, abajoTiposG);
            fun.despliegue();
        }

        private void abajoTiposG_Click(object sender, EventArgs e)
        {
            gadgets.slider fun = new gadgets.slider(detallesTipoG, imagenTiposG, arribaTiposG, abajoTiposG);
            fun.despliegue();
        }

        private void btnAgregaMar_Click(object sender, EventArgs e)
        {
            mantenimientos.marcas mar = new mantenimientos.marcas();
            mar.ShowDialog();
        }

        private void btnAgregaCat_Click(object sender, EventArgs e)
        {
            mantenimientos.categorias cat = new mantenimientos.categorias();
            cat.ShowDialog();
        }

        private void btnAgregaEst_Click(object sender, EventArgs e)
        {
            mantenimientos.estantes est = new mantenimientos.estantes();
            est.ShowDialog();
        }

        private void btnAgregaProvee_Click(object sender, EventArgs e)
        {
            mantenimientos.proveedores pro = new mantenimientos.proveedores();
            pro.ShowDialog();
        }

        private void btnAgregaC_Click(object sender, EventArgs e)
        {
            mantenimientos.cargos car = new mantenimientos.cargos();
            car.ShowDialog();
        }

        private void btnAgregaPer_Click(object sender, EventArgs e)
        {
            mantenimientos.permisos per = new mantenimientos.permisos();
            per.Actualizar = false;
            per.ShowDialog();
        }

        private void btnAgregaDesc_Click(object sender, EventArgs e)
        {
            mantenimientos.descuentos des = new mantenimientos.descuentos();
            des.ShowDialog();
        }

        private void btnAgregaTiposF_Click(object sender, EventArgs e)
        {
            mantenimientos.tipos_facturas tp = new mantenimientos.tipos_facturas();
            tp.ShowDialog();
        }

        private void btnAgregaFormaP_Click(object sender, EventArgs e)
        {
            mantenimientos.formas_pago fp = new mantenimientos.formas_pago();
            fp.ShowDialog();
        }

        private void btnAgregaTiposG_Click(object sender, EventArgs e)
        {
            mantenimientos.tipos_gastos tg = new mantenimientos.tipos_gastos();
            tg.ShowDialog();
        }

        private void btnAgregaPres_Click(object sender, EventArgs e)
        {
            mantenimientos.presentaciones p = new mantenimientos.presentaciones();
            p.ShowDialog();
        }

        private void btnAgregaTiposC_Click(object sender, EventArgs e)
        {
            mantenimientos.tipos_compras tc = new mantenimientos.tipos_compras();
            tc.ShowDialog();
        }

        private void btnAgregaU_Click(object sender, EventArgs e)
        {
            mantenimientos.usuarios u = new mantenimientos.usuarios();
            u.ShowDialog();
        }

        private void btnAgregaGrupo_Click(object sender, EventArgs e)
        {
            mantenimientos.grupos g = new mantenimientos.grupos();
            g.ShowDialog();
        }

        private void arribaGrupo_Click(object sender, EventArgs e)
        {
            gadgets.slider fun = new gadgets.slider(detallesGrupos, imagenGrupos, arribaGrupo, abajoGrupo);
            fun.despliegue();

        }

        private void abajoGrupo_Click(object sender, EventArgs e)
        {
            gadgets.slider fun = new gadgets.slider(detallesGrupos, imagenGrupos, arribaGrupo, abajoGrupo);
            fun.despliegue();
        }

        private void btnAgregaEm_Click(object sender, EventArgs e)
        {
            mantenimientos.empleados em = new mantenimientos.empleados();
            em.ShowDialog();
        }

        private void btnAgregaUtili_Click(object sender, EventArgs e)
        {
            mantenimientos.utilidades u = new mantenimientos.utilidades();
            u.ShowDialog();
        }

        private void btnAgregaSucu_Click(object sender, EventArgs e)
        {
            mantenimientos.sucursales suc = new mantenimientos.sucursales();
            suc.ShowDialog();
        }

        private void btnAgregaCl_Click(object sender, EventArgs e)
        {
            mantenimientos.clientes cl = new mantenimientos.clientes();
            cl.ShowDialog();
        }

        private void btnAgregaPro_Click(object sender, EventArgs e)
        {
            mantenimientos.productos pr = new mantenimientos.productos();
            pr.ShowDialog();
        }

        private void btnModifiPer_Click(object sender, EventArgs e)
        {
            mantenimientos.permisos per = new mantenimientos.permisos();
            per.Actualizar = true;
            per.lblEncanezado.Text = "Modificando los permisos";
            per.Show();
        }

        private void btnModiGrupo_Click(object sender, EventArgs e)
        {
            mantenimientos.grupos g = new mantenimientos.grupos();
            g.Actualizar = true;
            g.lblEncanezado.Text="Modificando los grupos";
            g.ShowDialog();
        }

        private void configuracion_Load(object sender, EventArgs e)
        {
            control_permisos.controlador_de_permisos per= new control_permisos.controlador_de_permisos(this.panel_central, conexiones_BD.clases.usuarios.permisosAsigandosConfiguracion(sesion.Datos[5]));
            
        }

        private void btnModificaC_Click(object sender, EventArgs e)
        {
            mantenimientos.cargos car = new mantenimientos.cargos();
            car.Modificar = true;
            car.ShowDialog();
        }

        private void btnModiSuc_Click(object sender, EventArgs e)
        {
            mantenimientos.sucursales suc = new mantenimientos.sucursales();
            suc.Modificar = true;
            suc.ShowDialog();
        }

        private void btnModiEm_Click(object sender, EventArgs e)
        {
            mantenimientos.empleados emp = new mantenimientos.empleados();
            emp.Modificar = true;
            emp.lblEncanezado.Text = "Modificar y eliminar empleados";
            emp.ShowDialog();
        }

        private void btnModiU_Click(object sender, EventArgs e)
        {
            mantenimientos.usuarios usu = new mantenimientos.usuarios();
            usu.Modificar = true;
            usu.lblEncanezado.Text = "Modificar y eliminar usuarios";
            usu.ShowDialog();
        }

        private void btnModiCat_Click(object sender, EventArgs e)
        {
            mantenimientos.categorias categ = new mantenimientos.categorias();
            categ.lblEncanezado.Text = "Modicar o eliminar una categoria.";
            categ.Modificar = true;
            categ.ShowDialog();
        }

        private void btnModiEsta_Click(object sender, EventArgs e)
        {
            mantenimientos.estantes es = new mantenimientos.estantes();
            es.lblEncanezado.Text = "Modicar o eliminar un estante.";
            es.Modificar = true;
            es.ShowDialog();
        }

        private void btnModiMarc_Click(object sender, EventArgs e)
        {
            mantenimientos.marcas mar = new mantenimientos.marcas();
            mar.lblEncanezado.Text = "Modicar o eliminar una marca";
            mar.Modificar = true;
            mar.ShowDialog();
        }

        private void btnModiTipoC_Click(object sender, EventArgs e)
        {
            mantenimientos.tipos_compras ti = new mantenimientos.tipos_compras();
            ti.lblEncanezado.Text = "Modicar o eliminar un tipo de compra.";
            ti.Modificar = true;
            ti.ShowDialog();
        }

        private void btnModiUtili_Click(object sender, EventArgs e)
        {
            mantenimientos.utilidades ti = new mantenimientos.utilidades();
            ti.lblEncanezado.Text = "Modicar o eliminar utilidades.";
            ti.Modificar = true;
            ti.ShowDialog();
        }

        private void btnModiPrese_Click(object sender, EventArgs e)
        {
            mantenimientos.presentaciones ti = new mantenimientos.presentaciones();
            ti.lblEncanezado.Text = "Modicar o eliminar presentaciones.";
            ti.Modificar = true;
            ti.ShowDialog();
        }

        private void arribaBanco_Click(object sender, EventArgs e)
        {
            gadgets.slider fun = new gadgets.slider(detallesBancos, imagenBanco, arribaBanco, abajoBanco);
            fun.despliegue();
        }

        private void abajoBanco_Click(object sender, EventArgs e)
        {
            gadgets.slider fun = new gadgets.slider(detallesBancos, imagenBanco, arribaBanco, abajoBanco);
            fun.despliegue();
        }

        private void btnModificarBanco_Click(object sender, EventArgs e)
        {
            mantenimientos.bancos ti = new mantenimientos.bancos();
            ti.lblEncanezado.Text = "Modicar o eliminar bancos.";
            ti.Modificar = true;
            ti.ShowDialog();
        }

        private void btnAbanco_Click(object sender, EventArgs e)
        {
            mantenimientos.bancos ban = new mantenimientos.bancos();
            ban.ShowDialog();
        }

        private void btnModiProve_Click(object sender, EventArgs e)
        {
            mantenimientos.proveedores ti = new mantenimientos.proveedores();
            ti.lblEncanezado.Text = "Modicar o eliminar proveedores.";
            ti.Modificar = true;
            ti.ShowDialog();
        }

        private void btnModificaP_Click(object sender, EventArgs e)
        {
            mantenimientos.productos pro = new mantenimientos.productos();
            pro.Modificar = true;
            pro.lblEncanezado.Text = "Modificar o eliminar productos";
            pro.ShowDialog();
                
        }

        private void btnModiTipoG_Click(object sender, EventArgs e)
        {
            mantenimientos.tipos_gastos gast = new mantenimientos.tipos_gastos();
            gast.Modificar = true;
            gast.lblEncanezado.Text = "Modifica o elimina un tipo de gasto";
            gast.ShowDialog();
        }

        private void btnModiDesc_Click(object sender, EventArgs e)
        {
            mantenimientos.descuentos desc = new mantenimientos.descuentos();
            desc.Modificar = true;
            desc.lblEncanezado.Text = "Modifica o elimina un descuento";
            desc.ShowDialog();
        }

        private void btnModiTiposF_Click(object sender, EventArgs e)
        {
            mantenimientos.tipos_facturas t = new mantenimientos.tipos_facturas();
            t.Modificar = true;
            t.lblEncanezado.Text = "Modifica o elimina un tipo de factura";
            t.ShowDialog();
        }

        private void btnModiFormasP_Click(object sender, EventArgs e)
        {
            mantenimientos.formas_pago fp = new mantenimientos.formas_pago();
            fp.Modificar = true;
            fp.lblEncanezado.Text = "Modifica o elimina una forma de pago";
            fp.ShowDialog();
        }

        private void btnModiC_Click(object sender, EventArgs e)
        {
            mantenimientos.clientes fp = new mantenimientos.clientes();
            fp.Modificar = true;
            fp.lblEncanezado.Text = "Modifica o elimina un cliente";
            fp.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mantenimientos.correlativos.correlativo_ticket frm = new mantenimientos.correlativos.correlativo_ticket();
            frm.ShowDialog();
        }

        private void arribaCorre_Click(object sender, EventArgs e)
        {
            gadgets.slider fun = new gadgets.slider(detalleCorrelativo, imagenCorre, arribaCorre, abajoCorre);
            fun.despliegue();
        }

        private void abajoCorre_Click(object sender, EventArgs e)
        {
            gadgets.slider fun = new gadgets.slider(detalleCorrelativo, imagenCorre, arribaCorre, abajoCorre);
            fun.despliegue();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            cajas_efectivo.Imagenes gestion_caja = new cajas_efectivo.Imagenes();
            gestion_caja.ShowDialog();
        }

        private void arribaCaja_Click(object sender, EventArgs e)
        {
            gadgets.slider fun = new gadgets.slider(detalleCaja, imagenCaja, arribaCaja, abajoCaja);
            fun.despliegue();
        }

        private void abajoCaja_Click(object sender, EventArgs e)
        {
            gadgets.slider fun = new gadgets.slider(detalleCaja, imagenCaja, arribaCaja, abajoCaja);
            fun.despliegue();
        }

        private void arribaResolu_Click(object sender, EventArgs e)
        {
            gadgets.slider fun = new gadgets.slider(detalleResolucion, imagenResolu, arribaResolu, abajoResolu);
            fun.despliegue();
        }

        private void abajoResolu_Click(object sender, EventArgs e)
        {
            gadgets.slider fun = new gadgets.slider(detalleResolucion, imagenResolu, arribaResolu, abajoResolu);
            fun.despliegue();
        }

        private void arribaEmpresa_Click(object sender, EventArgs e)
        {
            gadgets.slider fun = new gadgets.slider(detalleEmpresa, imagenEmpresa, arribaEmpresa, abajoEmpresa);
            fun.despliegue();
        }

        private void abajoEmpresa_Click(object sender, EventArgs e)
        {
            gadgets.slider fun = new gadgets.slider(detalleEmpresa, imagenEmpresa, arribaEmpresa, abajoEmpresa);
            fun.despliegue();
        }

        private void btnAbrirEmpre_Click(object sender, EventArgs e)
        {
            mantenimientos.empresa empre = new mantenimientos.empresa();
            empre.Actualizar = sesion.Empresa_activa;
            empre.ShowDialog();
        }

        private void btnAgreResolu_Click(object sender, EventArgs e)
        {
            mantenimientos.resoluciones res = new mantenimientos.resoluciones();
            if (!sesion.Correlativos_activos)
            {
                res.ShowDialog();
            }else
            {
                MessageBox.Show("Ya hay una resolución activa, ingrese a modificar para cambiar la resolución", "Resolución activa", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            
        }

        private void btnModiResolu_Click(object sender, EventArgs e)
        {
            mantenimientos.resoluciones res = new mantenimientos.resoluciones();
            res.Modificar = true;
            res.ShowDialog();
        }

        
    }
}
