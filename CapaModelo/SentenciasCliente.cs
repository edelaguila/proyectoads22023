using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    public class SentenciasCliente:SentenciasGenerales
    {
        private string tabla;

        public SentenciasCliente()
        {
            this.tabla = "tbl_clientes";
        }

        public void agregarClientes(Dictionary<string, string> parameters)
        {
            string query = this.getQuery(parameters, tabla);
            this.insertarSQL(query);

        }
    }
}
