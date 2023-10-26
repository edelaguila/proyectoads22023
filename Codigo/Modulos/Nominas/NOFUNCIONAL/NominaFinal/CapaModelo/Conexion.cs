using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;


namespace CapaModeloNomina
{
   public class Conexion
    {
        public OdbcConnection connection()
        {
            OdbcConnection conn = new OdbcConnection("Dsn=nomina");
            try
            {
                conn.Open();
            }
            catch (OdbcException)
            {
                Console.WriteLine("No Conectó");
            }
            return conn;
        }


        public void disconnect(OdbcConnection conn)
        {
            try
            {
                conn.Close();
            }
            catch (OdbcException)
            {
                Console.WriteLine("No desconectó");
            }
        }
    }


}

