using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;


namespace CapaModelo
{
    public class Sentencias
    {
        Conexion con = new Conexion();

     
        //carlos enrique
        public DataTable Buscar(string tabla, string columna, string dato)
        {
            string consulta = $"SELECT * FROM {tabla} WHERE {columna} = '{dato}'";
            OdbcDataAdapter datos = new OdbcDataAdapter(consulta, con.conexion());

            DataTable dt = new DataTable();
            datos.Fill(dt);

            return dt;
        }
        //carlos enrique
        public bool Eliminar(string tabla, string columna, string valor)
        {
            using (OdbcConnection conn = con.conexion())
            {
                string consulta = $"DELETE FROM {tabla} WHERE {columna} = ?";
                using (OdbcCommand cmd = new OdbcCommand(consulta, conn))
                {
                    cmd.Parameters.AddWithValue("valor", valor);
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
        }


    }
}
