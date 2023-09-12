using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace CapaModelo
{
    public class SentenciasRegistros : SentenciasGenerales
    {
        private string tabla;

        public SentenciasRegistros(){
            this.tabla="usuario";


            }

        public void agregarUsuario(Dictionary<string, string> parameters)
        {
            string query = this.getQuery(parameters, tabla);
            this.insertarSQL(query);

        }

       



    }
}
