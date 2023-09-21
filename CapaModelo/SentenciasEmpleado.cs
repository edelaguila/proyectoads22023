using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    public class SentenciasEmpleado : SentenciasGenerales
    {
        private string tabla;

        public SentenciasEmpleado()
        {
            this.tabla = "tbl_empleado";
        }

        public void agregarEmpleado(Dictionary<string, string> parameters)
        {
            string query = this.getQuery(parameters, tabla);
            this.insertarSQL(query);
        }
    }
}
