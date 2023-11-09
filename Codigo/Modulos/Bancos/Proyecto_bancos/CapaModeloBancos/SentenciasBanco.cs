using System;
using System.Data;
using System.Data.Odbc;
using System.Collections.Generic;
namespace CapaModeloBancos
{ //Codigo escrito por Luis Franco, Jonathan Arriaga e Isabel Aguirre
    public class SentenciasBanco
    {
        private ConexionBanco con;

        public SentenciasBanco()
        {
            con = new ConexionBanco();
        }

        public void InsertarMovimiento(string valorMovimiento, string descripcionMovimiento,  string numCuenta, string tipoTransaccion, string estado, string valorTrans, string estadoConciliacion)
        {
            using (OdbcConnection connection = con.AbrirConexion())
            {
                if (connection != null)
                {
                    using (OdbcTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            string insertQuery = "INSERT INTO tbl_movimientosbancarios (movban_valor_transaccion, movban_descripcion_transaccion, fk_movban_num_cuenta, fk_movban_tipo_transaccion, fk_movban_valorTrans, movban_status, movban_fecha_de_ingreso, manag_status_conciliacion) VALUES (?, ?, ?, ?, ?, ?, ?, ?)";
                            using (OdbcCommand cmd = new OdbcCommand(insertQuery, connection, transaction))
                            {
                                cmd.Parameters.AddWithValue("@movban_valor_transaccion", valorMovimiento);
                                cmd.Parameters.AddWithValue("@movban_descripcion_transaccion", descripcionMovimiento);
                                cmd.Parameters.AddWithValue("@fk_movban_num_cuenta", numCuenta);
                                cmd.Parameters.AddWithValue("@fk_movban_tipo_transaccion", tipoTransaccion);
                                cmd.Parameters.AddWithValue("@fk_movban_valorTrans", valorTrans);
                                cmd.Parameters.AddWithValue("@movban_status", estado);
                                cmd.Parameters.AddWithValue("@movban_fecha_de_ingreso", DateTime.Now);
                                cmd.Parameters.AddWithValue("@manag_status_conciliacion", estadoConciliacion);


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

        public decimal CalcularSaldoTotal()
        {
            using (OdbcConnection connection = con.AbrirConexion())
            {
                if (connection != null)
                {
                    string sql = "SELECT movban_valor_transaccion FROM tbl_movimientosbancarios;";
                    using (OdbcCommand cmd = new OdbcCommand(sql, connection))
                    {
                        OdbcDataReader reader = cmd.ExecuteReader();
                        decimal saldoTotal = 0;
                        if (reader.HasRows) // Verificar si la consulta tiene resultados
                        {
                            while (reader.Read())
                            {
                                if (reader.IsDBNull(0))
                                {
                                    continue; // Salta si el valor es nulo
                                }
                                string valorStr = reader[0].ToString();
                                if (decimal.TryParse(valorStr, out decimal valorDecimal))
                                {
                                    saldoTotal += valorDecimal;
                                }
                            }
                        }
                        return saldoTotal;
                    }
                }
                return 0; // Devuelve 0 si no se puede conectar a la base de datos
            }
        }



        public DataTable llenarTbl(string tabla) //Llenar tabla de reportes
        {
            using (OdbcConnection connection = con.AbrirConexion())
            {
                if (connection != null)
                {
                    string sql = "SELECT pk_movban_id_transaccion, movban_valor_transaccion, movban_descripcion_transaccion,fk_movban_valorTrans, fk_movban_num_cuenta, fk_movban_tipo_transaccion, movban_status, movban_fecha_de_ingreso, manag_status_conciliacion FROM  " + tabla + ";";
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




        public DataTable ObtenerTiposMoneda()

        {
            using (OdbcConnection connection = con.AbrirConexion())
            {
                if (connection != null)
                {


                    string sql = "SELECT mon_nomMoneda FROM tbl_monedabanco;";

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
        public DataTable ObtenerCuentas()

        {
            using (OdbcConnection connection = con.AbrirConexion())
            {
                if (connection != null)
                {


                    string sql = "SELECT manac_numero_de_cuenta FROM tbl_mantenimientos_agregar_cuenta;";

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



        public DataTable TipoTransaccionBancaria()
        {
            using (OdbcConnection connection = con.AbrirConexion())
            {
                if (connection != null)
                {
                    string sql = "SELECT movtm_transacciones_existentes  FROM tbl_mantenimientos_tipo_movimiento;";
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

        public DataTable valorTransaccion()
        {
            using (OdbcConnection connection = con.AbrirConexion())
            {
                if (connection != null)
                {
                    string sql = "SELECT movtm_valor_transaccion FROM tbl_mantenimientos_tipo_movimiento;";
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




        public DataTable ObtenerBancos()
        {
            using (OdbcConnection connection = con.AbrirConexion())
            {
                if (connection != null)
                {
                    string sql = "SELECT manag_nombre_banco FROM tbl_mantenimientos_agregar_bancos;";
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



        public DataTable ObtenerTipoCuenta()
        {
            using (OdbcConnection connection = con.AbrirConexion())
            {
                if (connection != null)
                {
                    string sql = "SELECT movtm_transacciones_existentes FROM tbl_mantenimientos_tipo_movimiento;";
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

        /*public List<Banco> ObtenerBanco()
        {
            List<Banco> bancos = new List<Banco>();

            using (OdbcConnection connection = con.AbrirConexion())
            {

                string query = "SELECT ban_id_Banco, fk_ban_Nombre_banco, ban_status FROM tbl_banco";
                using (OdbcCommand command = new OdbcCommand(query, connection))
                {
                    using (OdbcDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Banco banco = new Banco
                            (
                                reader.GetInt32(0),
                                reader.GetInt32(1),
                                reader.GetString(2),
                                reader.GetInt32(3),
                                reader.GetBoolean(4)
                            );
                            bancos.Add(banco);
*/


        public int ObtenerValorTransaccion(string tipoTransaccion)
        {
            int valorTransaccion = 0; // Valor predeterminado (por ejemplo, pasivo)

            using (OdbcConnection connection = con.AbrirConexion())
            {
                if (connection != null)
                {
                    string query = "SELECT movtm_valor_transaccion FROM tbl_mantenimientos_tipo_movimiento WHERE movtm_transacciones_existentes = ?";
                    using (OdbcCommand cmd = new OdbcCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("?", tipoTransaccion);
                        OdbcDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            valorTransaccion = reader.GetInt32(0);
                        }
                    }
                }
            }


            return valorTransaccion;
        }
    }
}
