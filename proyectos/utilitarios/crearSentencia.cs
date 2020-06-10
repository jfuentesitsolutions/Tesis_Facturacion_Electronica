using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace utilitarios
{
    public class crearSentencia
    {
        StringBuilder sentencia=new StringBuilder();
        string tabla;
        List<String> campos;
        List<String> valores;
        string id;
        String oracion = "";

        public crearSentencia(List<String> ca ,List<String> va, string t,  string i)
        {
            this.campos = ca;
            this.valores = va;
            this.tabla = t;
            this.id=i;
        }

        public crearSentencia(List<String> ca, List<String> va, string t)
        {
            this.campos = ca;
            this.valores = va;
            this.tabla = t;
        }

        public crearSentencia(string t)
        {
            this.tabla = t;
        }

        public crearSentencia(string t, string i)
        {
            this.tabla = t;
            this.id = i;

        }

        public StringBuilder sentenciaInsertar()
        {
            this.sentencia.Clear();
            this.sentencia.Append("INSERT INTO "+tabla+" (");
            foreach (String campo in campos)
            {
                this.sentencia.Append(campo+",");
            }

            quitarUltimoCaracter();

            this.sentencia.Append(") VALUES(");

            foreach (String valor in valores)
            {
                sentencia.Append("'"+valor+"',");
            }

            quitarUltimoCaracter();
            this.sentencia.Append(");");

            return sentencia;
        }

        private void quitarUltimoCaracter()
        {
            string aux;
            aux = this.sentencia.ToString();
            aux = aux.Remove(aux.Length - 1);

            this.sentencia.Clear();
            this.sentencia.Append(aux);
        }

        public StringBuilder sentenciaValidacion(List<String> campo, List<String> va)
        {
            this.sentencia.Clear();
            sentencia.Append("SELECT * FROM " + this.tabla + " WHERE ");

           
                foreach (String c in campo)
                {
                    sentencia.Append(c + "=.' OR ");
                
                }

                partirSentencia(va);
                quitarUltimoCaracter();
                quitarUltimoCaracter();
                quitarUltimoCaracter();
                quitarUltimoCaracter();

                sentencia.Append(";");

            
            return sentencia;
        }

        public StringBuilder sentenciaValidaciondeMultipleCampo(List<String> campo, List<String> va)
        {
            this.sentencia.Clear();
            sentencia.Append("SELECT * FROM " + this.tabla + " WHERE ");
            foreach (String c in campo)
            {
                sentencia.Append(c + "=.' AND ");

            }

            partirSentencia(va);
            quitarUltimoCaracter();
            quitarUltimoCaracter();
            quitarUltimoCaracter();
            quitarUltimoCaracter();
            quitarUltimoCaracter();

            sentencia.Append(";");

            return sentencia;
        }

        private void partirSentencia(List<String> va)
        {
            
            String[] partes = sentencia.ToString().Split('.');
            int contador = 0;

            foreach (String v in va)
            {
                partes[contador] += "'" + v;
                contador++;
            }

            foreach (String p in partes)
            {
                oracion += p;
            }

            sentencia.Clear();
            sentencia.Append(oracion);
        }

        public StringBuilder sentenciaModificar(String idcampo)
        {
            this.sentencia.Clear();
            this.sentencia.Append("UPDATE "+this.tabla+" SET ");
            foreach (String c in this.campos)
            {
                sentencia.Append(c + "=.', ");
            }

            partirSentencia(this.valores);
            quitarUltimoCaracter();
            quitarUltimoCaracter();

            sentencia.Append(" WHERE "+idcampo+"='"+this.id+"'");
            sentencia.Append(";");
            return sentencia;
        }

        public StringBuilder sentenciaEliminar(String idcampo)
        {
            this.sentencia.Clear();

            sentencia.Append("DELETE FROM "+this.tabla+" WHERE "+idcampo+"='"+this.id+"';");

            return this.sentencia;
        }

        


    }
}
