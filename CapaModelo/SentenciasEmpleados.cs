using Microsoft.SqlServer.Server;
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

        public string getQuery(Dictionary<string, string> parameters)
        {
            List<string> columns = this.getColumns("empleados");
            string _columns = this.getColumnsQuery(parameters, columns);
            string sql = "INSERT INTO empleados " + _columns + " VALUES (";
            foreach (var item in parameters)
            {
                if (item.Value != parameters.Values.Last())
                {
                    sql += "'" + item.Value.ToString() + "'" + ",";
                }
                else
                {

                    sql += "'" + item.Value.ToString() + "'";
                }
            }
            sql += ");";
            Console.WriteLine("sql: " + sql);
            return sql;
        }


        public List<string> getColumns(string tableName)
        {
            List<string> columns = new List<string>();
            try
            {
                string query = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA = 'controlempleados' AND TABLE_NAME='empleados';";
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


        public void agregarEmpleado(Dictionary<string, string> parameters)
        {
            //string sql = "insert into " + tabla + "";
            string query = this.getQuery(parameters);
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
