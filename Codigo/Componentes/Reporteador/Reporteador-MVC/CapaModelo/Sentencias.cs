using System;
using System.Data;
using System.Data.Odbc;
using System.IO;

namespace CapaModelo
{
    public class Sentencias
    {
        private Conexion con;

        public Sentencias()
        {
            con = new Conexion();
        }

        // Insertar un nuevo registro con archivo de texto
        public void InsertarReporte(string correlativo, string nombreArchivo, string estado, string rutaArchivo)
        {
            using (OdbcConnection connection = con.AbrirConexion())
            {
                if (connection != null)
                {
                    using (OdbcTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            // Leer el contenido del archivo
                            string contenidoArchivo = File.ReadAllText(rutaArchivo);

                            string insertQuery = "INSERT INTO reportes (correlativo, nombre, estado, fecha, archivo) VALUES (?, ?, ?, ?, ?)";
                            using (OdbcCommand cmd = new OdbcCommand(insertQuery, connection, transaction))
                            {
                                cmd.Parameters.AddWithValue("@correlativo", correlativo);
                                cmd.Parameters.AddWithValue("@nombre", nombreArchivo);
                                cmd.Parameters.AddWithValue("@estado", estado);
                                cmd.Parameters.AddWithValue("@fecha", DateTime.Now);
                                cmd.Parameters.AddWithValue("@archivo", contenidoArchivo);

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

        // Leer registros existentes
        public DataTable ObtenerReportes()
        {
            using (OdbcConnection connection = con.AbrirConexion())
            {
                if (connection != null)
                {
                    string selectQuery = "SELECT id_reporte, correlativo, nombre, estado, fecha FROM reportes";
                    using (OdbcCommand cmd = new OdbcCommand(selectQuery, connection))
                    {
                        DataTable dataTable = new DataTable();
                        using (OdbcDataAdapter adapter = new OdbcDataAdapter(cmd))
                        {
                            adapter.Fill(dataTable);
                        }
                        return dataTable;
                    }
                }
                else
                {
                    return null;
                }
            }
        }

        // Actualizar un registro existente
        public void ActualizarReporte(int idReporte, string correlativo, string nombre, string estado)
        {
            using (OdbcConnection connection = con.AbrirConexion())
            {
                if (connection != null)
                {
                    using (OdbcTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            string updateQuery = "UPDATE reportes SET correlativo=?, nombre=?, estado=? WHERE id_reporte=?";
                            using (OdbcCommand cmd = new OdbcCommand(updateQuery, connection, transaction))
                            {
                                cmd.Parameters.AddWithValue("@correlativo", correlativo);
                                cmd.Parameters.AddWithValue("@nombre", nombre);
                                cmd.Parameters.AddWithValue("@estado", estado);
                                cmd.Parameters.AddWithValue("@id_reporte", idReporte);

                                cmd.ExecuteNonQuery();
                            }

                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            Console.WriteLine($"Error al actualizar el registro: {ex.Message}");
                        }
                    }
                }
            }
        }

        // Eliminar un registro existente
        public void EliminarReporte(int idReporte)
        {
            using (OdbcConnection connection = con.AbrirConexion())
            {
                if (connection != null)
                {
                    using (OdbcTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            string deleteQuery = "DELETE FROM reportes WHERE id_reporte=?";
                            using (OdbcCommand cmd = new OdbcCommand(deleteQuery, connection, transaction))
                            {
                                cmd.Parameters.AddWithValue("@id_reporte", idReporte);

                                cmd.ExecuteNonQuery();
                            }

                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            Console.WriteLine($"Error al eliminar el registro: {ex.Message}");
                        }
                    }
                }
            }
        }

        // El método llenarTbl que mencionaste previamente
        public DataTable llenarTbl(string tabla)
        {
            using (OdbcConnection connection = con.AbrirConexion())
            {
                if (connection != null)
                {
                    string sql = "SELECT id_reporte, correlativo, nombre, estado, fecha FROM  " + tabla + ";";
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
    }
}


    