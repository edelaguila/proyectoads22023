using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    public class Sentencias : SentenciasGenerales
    {
        private string tabla = "";
        private string PK = "";
        private string x = "";
        public Sentencias()
        {

        }
        public Sentencias(string tabla)
        {
            this.tabla = tabla;
        }
        public void guardar(Dictionary<string, string> parameters)
        {
            string query = this.getQuery(parameters, tabla);
            this.insertarSQL(query);
        }
        public void modificar(Dictionary<string, string> parameters, string pk , int id)
        {
            string query = this.getModificarQuery(parameters, tabla,pk,id);
            this.insertarSQL(query);
        }
    }
}
