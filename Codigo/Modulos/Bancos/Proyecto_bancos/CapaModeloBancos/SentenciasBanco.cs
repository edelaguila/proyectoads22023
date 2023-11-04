using System;
using System.Data;
using System.Data.Odbc;

namespace CapaModeloBancos
{
    public class SentenciasBanco
    {
        private ConexionBanco con;

        public SentenciasBanco()
        {
            con = new ConexionBanco();
        }

        public void InsertarMovimiento(string valorMovimiento, string descripcionMovimiento,  string numCuenta, string tipoTransaccion, string estado)
        {
            using (OdbcConnection connection = con.AbrirConexion())
            {
                if (connection != null)
                {
                    using (OdbcTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            string insertQuery = "INSERT INTO tbl_movimientosbancarios (movban_valor_transaccion, movban_descripcion_transaccion, fk_movban_num_cuenta, fk_movban_tipo_transaccion, movban_status, movban_fecha_de_ingreso) VALUES (?, ?, ?, ?, ?, ?)";
                            using (OdbcCommand cmd = new OdbcCommand(insertQuery, connection, transaction))
                            {
                                cmd.Parameters.AddWithValue("@movban_valor_transaccion", valorMovimiento);
                                cmd.Parameters.AddWithValue("@movban_descripcion_transaccion", descripcionMovimiento);
                                cmd.Parameters.AddWithValue("@fk_movban_num_cuenta", numCuenta);
                                cmd.Parameters.AddWithValue("@fk_movban_tipo_transaccion", tipoTransaccion);
                                cmd.Parameters.AddWithValue("@movban_status", estado);
                                cmd.Parameters.AddWithValue("@movban_fecha_de_ingreso", DateTime.Now);


                                cmd.ExecuteNonQuery();
                            }

                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            Console.WriteLine($"Error al insertar el registro: {ex.Message}");
                        }
                    }
                }
            }
        }

        public DataTable llenarTbl(string tabla) //Llenar tabla de reportes
        {
            using (OdbcConnection connection = con.AbrirConexion())
            {
                if (connection != null)
                {
                    string sql = "SELECT pk_movban_id_transaccion, movban_valor_transaccion, movban_descripcion_transaccion, fk_movban_num_cuenta, fk_movban_tipo_transaccion, movban_status, movban_fecha_de_ingreso FROM  " + tabla + ";";
                    OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, connection);
                    DataTable table = new DataTable();
                    dataTable.Fill(table);
                    return table;
                }
                else
                {
                    return null;
                }
            }
        }

        public DataTable llenarTblMoneda(string tabla) //Llenar tabla de reportes
        {
            using (OdbcConnection connection = con.AbrirConexion())
            {
                if (connection != null)
                {
                    string sql = "SELECT regmon_id_Moneda, regmon_Tipo_moneda, regmon_Valor_moneda, regmon_fecha_de_registro, regmon_status FROM  " + tabla + ";";
                    OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, connection);
                    DataTable table = new DataTable();
                    dataTable.Fill(table);
                    return table;
                }
                else
                {
                    return null;
                }
            }
        }
        public void InsertarTipoMoneda(string TipoMoneda, string ValorMoneda, string estado)
        {
            using (OdbcConnection connection = con.AbrirConexion())
            {
                if (connection != null)
                {
                    using (OdbcTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            string insertQuery = "INSERT INTO tbl_registro_moneda (regmon_Tipo_moneda, regmon_Valor_moneda, regmon_fecha_de_registro, regmon_status) VALUES (?, ?, ?, ?)";
                            using (OdbcCommand cmd = new OdbcCommand(insertQuery, connection, transaction))
                            {
                                cmd.Parameters.AddWithValue("@regmon_Tipo_moneda", TipoMoneda);
                                cmd.Parameters.AddWithValue("@regmon_Valor_moneda", ValorMoneda);
                                cmd.Parameters.AddWithValue("@regmon_fecha_de_registro", DateTime.Now);
                                cmd.Parameters.AddWithValue("@regmon_status", estado);
                        


                                cmd.ExecuteNonQuery();
                            }

                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            Console.WriteLine($"Error al insertar el registro: {ex.Message}");
                        }
                    }
                }
            }
        }


    }
}
