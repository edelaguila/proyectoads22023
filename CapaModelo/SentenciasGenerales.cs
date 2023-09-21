using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    public class SentenciasGenerales
    {
        protected Conexion conn;
        private static string baseDatos = "nomina";
        public SentenciasGenerales()
        {
            this.conn = new Conexion();
        }

        public string getColumnsQuery(Dictionary<string, string> parameters, List<string> columns)
        {
            string sql = "(";
            foreach (string str in columns)
            {
                if (parameters.ContainsKey(str))
                {
                    if (!str.Equals(columns.Last()))
                    {
                        sql += str + ",";
                    }
                    else
                    {
                        sql += str;
                    }
                }
            }
            sql += ")";
            sql = sql.Replace(",)", ")");
            return sql;
        }

        public string getQuery(Dictionary<string, string> parameters, string tabla)
        {
            List<string> columns = this.getColumns(tabla);
            string _columns = this.getColumnsQuery(parameters, columns);
            //Se deberia cambiar la tabla a usuarios para el ingreso de datos y la creacion de roles
            string sql = "INSERT INTO tbl_nomina " + _columns + " VALUES (";
            foreach (string col in columns)
            {
                if (parameters.Keys.Contains(col))
                {
                    string str = parameters[col];
                    sql += "'" + str + "'" + ",";
                }
            }
            sql += ");";
            sql = sql.Replace(",)", ")");
            Console.WriteLine(sql);
            return sql;
        }


        public List<string> getColumns(string tableName)
        {
            List<string> columns = new List<string>();
            try
            {
                string query = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA = '" + baseDatos + "' AND TABLE_NAME='" + tableName + "';";
                OdbcCommand cmd = new OdbcCommand(query, this.conn.connection());
                OdbcDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string column = reader.GetString(0);
                    Console.WriteLine("c" + column);
                    columns.Add(column);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return columns;
        }

        public void insertarSQL(string query)
        {
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
