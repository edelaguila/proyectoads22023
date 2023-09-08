using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    public class SentenciasEmpleados
    {
        private Conexion conn;

        public SentenciasEmpleados()
        {
            this.conn = new Conexion();
        }


        public void agregarEmpleado(string nombre, string puesto, string departamento)
        {
            //string sql = "insert into " + tabla + "";
            string query = "insert into empleados(nombre_completo, puesto, departamento)values";
            query += "('" + nombre + "', '" + puesto + "', '" + departamento + "')";
            try
            {
                OdbcCommand cmd = new OdbcCommand(query, this.conn.connection());
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
