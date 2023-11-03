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

        public DataTable Buscar(string tabla, string columna, string dato)
        {
            string consulta = $"SELECT * FROM {tabla} WHERE {columna} = '{dato}'";
            OdbcDataAdapter datos = new OdbcDataAdapter(consulta, con.conexion());

            DataTable dt = new DataTable();
            datos.Fill(dt);

            return dt;
        }

        public OdbcDataAdapter llenarTbl(string tabla)
        {
            // Utiliza INNER JOINs para unir las tablas y obtener los datos necesarios.
            string sql = "SELECT e.id_EncabezadoCliente, e.encabezadoCliente_FechaEmision, e.encabezadoCliente_FechaVencimiento, c.cli_nombre, co.con_Descripcion, co.con_SerieConcepto " +
             "FROM tbl_encabezadoMovimientoCliente e " +
             "INNER JOIN tbl_detalleMovimientoCliente d ON e.id_EncabezadoCliente = d.CodigoEncabezadoCliente " +
             "INNER JOIN tbl_cliente c ON e.CodigoCliente = c.id_cliente " +
             "INNER JOIN tbl_concepto co ON d.CodigoConceptoCliente = co.id_concepto;";


            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }


        public OdbcDataAdapter llenarTblP(string tabla1)
        {
            // Utiliza INNER JOINs para unir las tablas y obtener los datos necesarios.
            string sql = "SELECT e.id_EncabezadoProveedor, e.encabezadoProveedor_FechaEmision, e.encabezadoProveedor_FechaVencimiento, p.pro_Nombre, co.con_Descripcion, co.con_SerieConcepto " +
              "FROM tbl_encabezadoMovimientoProveedor e " +
              "INNER JOIN tbl_detalleMovimientoProveedor d ON e.id_EncabezadoProveedor = d.CodigoEncabezadoProveedor " +
              "INNER JOIN tbl_proveedor p ON e.CodigoProveedor = p.id_proveedor " +
              "INNER JOIN tbl_concepto co ON d.CodigoConceptoProveedor = co.id_concepto;";


            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }



        public List<string> llenarCombo(string columna1, string tabla)
        {
            List<string> datos = new List<string>();
            try
            {

                string consulta = $"SELECT {columna1} FROM {tabla}";

                OdbcCommand command = new OdbcCommand(consulta, con.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string ID = reader[columna1].ToString();                
                    datos.Add(ID);                
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return datos;
        }

        public bool Guardar(string tabla, Dictionary<string, object> valores)
        {
            using (OdbcConnection conn = con.conexion())
            {
                // Construir la consulta SQL para insertar datos
                string columnas = string.Join(", ", valores.Keys);
                string parametros = string.Join(", ", valores.Keys.Select(key => "?"));
                string consulta = $"INSERT INTO {tabla} ({columnas}) VALUES ({parametros})";

                using (OdbcCommand cmd = new OdbcCommand(consulta, conn))
                {
                    // Agregar parámetros con sus valores correspondientes
                    foreach (var kvp in valores)
                    {
                        cmd.Parameters.AddWithValue(kvp.Key, kvp.Value);
                    }

                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
        }



        public DataTable BuscarUltimoID(string tabla, string columna)
        {
            string consulta = $"SELECT MAX({columna}) AS MaxID FROM {tabla}";
            OdbcDataAdapter datos = new OdbcDataAdapter(consulta, con.conexion());

            DataTable dt = new DataTable();
            datos.Fill(dt);

            return dt;
        }


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
