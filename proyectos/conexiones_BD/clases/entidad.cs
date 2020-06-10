using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conexiones_BD.clases
{
    public class entidad
    {
        private List<String> nombres_campos;
        private List<String> valores_campos;

        private List<String> nombres_campos_b;
        private List<String> valores_campos_b;

        private String tabla, identidad, nombre_id_campo ;
        private operaciones op = new operaciones();


        protected virtual void cargarDatos(List<String> nc, List<String> vc, String nombre_tabla)
        {
            this.nombres_campos = nc;
            this.valores_campos = vc;
            this.tabla = nombre_tabla;
        }

        protected virtual void cargarDatosModificados(List<String> nc, List<String> vc, String nombre_tabla, String id, String ncid)
        {
            this.nombres_campos = nc;
            this.valores_campos = vc;
            this.tabla = nombre_tabla;
            this.identidad = id;
            this.nombre_id_campo = ncid;
        }

        protected virtual void cargarDatosEliminados(String ta, String ide, String ncid)
        {
            this.tabla = ta;
            this.identidad = ide;
            this.nombre_id_campo = ncid;

        }

        protected virtual void busquedaDatos(List<String> nc, List<String> vc, String nombre_tabla)
        {
            this.nombres_campos_b = nc;
            this.valores_campos_b = vc;
            this.tabla = nombre_tabla;
        }

        public virtual long guardar(bool mensaje)
        {
            long id_guardado = 0;
            utilitarios.crearSentencia sentencia = new utilitarios.crearSentencia(nombres_campos, valores_campos, tabla);
            id_guardado = op.insertar(sentencia.sentenciaInsertar().ToString());
            Console.WriteLine(sentencia.sentenciaInsertar().ToString());

            if (mensaje)
            {
                if (id_guardado>0)
                {
                    MessageBox.Show("El registro se ingreso correctamente", "Registro ingresado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }else
                {
                    MessageBox.Show("No se pudo ingresar el registro", "No se pudo agregar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            
            return id_guardado;
        }

        public virtual Int32 modificar(bool mensaje)
        {
            Int32 modificado = 0;
            utilitarios.crearSentencia sentencia = new utilitarios.crearSentencia(nombres_campos, valores_campos, tabla, identidad);
            modificado = op.actualizar(sentencia.sentenciaModificar(nombre_id_campo).ToString());
            Console.WriteLine(sentencia.sentenciaModificar(nombre_id_campo).ToString());

            if (mensaje)
            {
                if (modificado > 0)
                {
                    MessageBox.Show("El registro se modifico con exíto", "Registro modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                } else
                {
                    MessageBox.Show("El registro no se pudo modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            


            return modificado;
        }

        public virtual Int32 eliminar(bool mensaje)
        {
            Int32 eliminado = 0;
            utilitarios.crearSentencia sentencia = new utilitarios.crearSentencia(tabla, identidad);
            eliminado = op.eliminar(sentencia.sentenciaEliminar(nombre_id_campo).ToString());

            if (mensaje)
            {
                if (eliminado > 0)
                {
                    MessageBox.Show("El registro fue eliminado con exíto", "Registro eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }else
                {
                    MessageBox.Show("No se pudo eliminar el registro", "Error al eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return eliminado;
        }

        public virtual Int32 validarCamposcondicorOR(bool mensaje)
        {
            Int32 valido = 0;
            utilitarios.crearSentencia sentencia = new utilitarios.crearSentencia(tabla);

            valido = op.Consultar(sentencia.sentenciaValidacion(nombres_campos_b, valores_campos_b).ToString()).Rows.Count;
            Console.WriteLine(sentencia.sentenciaValidacion(nombres_campos_b, valores_campos_b).ToString());

            if (mensaje)
            {
                if (valido > 0)
                {
                    MessageBox.Show("Ya se encuentra ese registro en la base de datos", "Registro duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return valido;

        }

        public virtual Int32 validarCamposcondicorORActu(bool mensaje, int limite_resul)
        {
            Int32 valido = 0;
            utilitarios.crearSentencia sentencia = new utilitarios.crearSentencia(tabla);

            valido = op.Consultar(sentencia.sentenciaValidacion(nombres_campos_b, valores_campos_b).ToString()).Rows.Count;
            //Console.WriteLine(sentencia.sentenciaValidacion(nombres_campos_b, valores_campos_b).ToString());

            if (mensaje)
            {
                if (valido > limite_resul)
                {
                    MessageBox.Show("Ya se encuentra ese registro en la base de datos", "Registro duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return valido;

        }

        public virtual Int32 validarCamposcondicorAND(bool mensaje)
        {
            Int32 valido = 0;

            utilitarios.crearSentencia sentencia = new utilitarios.crearSentencia(tabla);
            valido = op.Consultar(sentencia.sentenciaValidaciondeMultipleCampo(nombres_campos_b, valores_campos_b).ToString()).Rows.Count;
            //Console.WriteLine(sentencia.sentenciaValidaciondeMultipleCampo(nombres_campos_b, valores_campos_b).ToString());

            if (mensaje)
            {
                if (valido>0)
                {
                    MessageBox.Show("Ya se encuentra ese registro en la base de datos","Registro duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return valido;

        }

        public virtual Int32 validarCamposcondicorANDActu(bool mensaje, int limite_resul)
        {
            Int32 valido = 0;

            utilitarios.crearSentencia sentencia = new utilitarios.crearSentencia(tabla);
            valido = op.Consultar(sentencia.sentenciaValidaciondeMultipleCampo(nombres_campos_b, valores_campos_b).ToString()).Rows.Count;
            //Console.WriteLine(sentencia.sentenciaValidaciondeMultipleCampo(nombres_campos_b, valores_campos_b).ToString());

            if (mensaje)
            {
                if (valido > limite_resul)
                {
                    MessageBox.Show("Ya se encuentra ese registro en la base de datos", "Registro duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return valido;

        }

        public virtual List<string> generarCampos()
        {
            List<string> campos = new List<string>();
            return campos;
        }

        public virtual List<string> generarValores()
        {
            List<string> valores = new List<string>();
            return valores;
        }

        public string sentenciaIngresar()
        {
            utilitarios.crearSentencia sentencia = new utilitarios.crearSentencia(nombres_campos, valores_campos, tabla);
            Console.WriteLine(sentencia.sentenciaInsertar().ToString());
            return sentencia.sentenciaInsertar().ToString();
        }

        public string sentenciaEliminar()
        {
            utilitarios.crearSentencia sentencia = new utilitarios.crearSentencia(nombres_campos, valores_campos, tabla, identidad);
            Console.WriteLine(sentencia.sentenciaEliminar(nombre_id_campo).ToString());
            return sentencia.sentenciaEliminar(nombre_id_campo).ToString();
        }

        public string sentenciaModificar()
        {
            utilitarios.crearSentencia sentencia = new utilitarios.crearSentencia(nombres_campos, valores_campos, tabla, identidad);
            Console.WriteLine(sentencia.sentenciaModificar(nombre_id_campo).ToString());
            return sentencia.sentenciaModificar(nombre_id_campo).ToString();
        }

    }
}
