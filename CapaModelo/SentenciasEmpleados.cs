using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    public class SentenciasEmpleados : SentenciasGenerales
    {
        private string tabla;

        public SentenciasEmpleados()
        {
            this.tabla = "empleados";
        }

        public void agregarEmpleado(Dictionary<string, string> parameters)
        {
            string query = this.getQuery(parameters, tabla);
            this.insertarSQL(query);
        }

    }
}
