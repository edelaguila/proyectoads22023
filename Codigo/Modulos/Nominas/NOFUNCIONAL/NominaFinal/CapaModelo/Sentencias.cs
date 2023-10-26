using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace CapaModeloNomina
{


    public class Empleado
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Sueldo { get; set; }
        public string Cargo { get; set; }
    }

    public class Sentencias
    {
        public Conexion con;


        public Sentencias()
        {
            con = new Conexion();
        }

        private string connectionString = "Dsn=nomina";

        public Empleado BuscarEmpleadoPorID(int idEmpleado)
        {
            Empleado empleadoEncontrado = null;

            using (OdbcConnection conn = new OdbcConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string consulta = "SELECT emp_nombre, emp_apellido, emp_sueldo, cargo FROM tbl_empleado WHERE Pk_id_empleado = ?";
                    using (OdbcCommand cmd = new OdbcCommand(consulta, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", idEmpleado);

                        using (OdbcDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                empleadoEncontrado = new Empleado
                                {
                                    ID = idEmpleado,
                                    Nombre = reader["emp_nombre"].ToString(),
                                    Apellido = reader["emp_apellido"].ToString(),
                                    Sueldo = reader["emp_sueldo"].ToString(),
                                    Cargo = reader["cargo"].ToString(),
                                };
                            }
                        }
                    }
                }
                catch (OdbcException ex)
                {
                    Console.WriteLine("Error al buscar el empleado: " + ex.Message);
                }
            }

            return empleadoEncontrado;
        }

        public void InsertarDeduccion(int idEmpleado, int sueldoBase, string impuestos, string otrosDescuentos, int sueldoFinal, int prestamoAnticipo)
        {
            using (OdbcConnection connection = con.connection())
            {
                if (connection != null)
                {
                    using (OdbcTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            string insertQuery = "INSERT INTO tbl_deducciones (`tbl_empleado_Pk_id_empleado`, `ded_emp_sueldoB`, `ded_impuestos`, `ded_ded_otros`, `ded_sueldo_final`, `ded_prestamo/anticipo`) VALUES (?, ?, ?, ?, ?, ?)";
                            using (OdbcCommand cmd = new OdbcCommand(insertQuery, connection, transaction))
                            {
                                cmd.Parameters.AddWithValue("@tbl_empleado_Pk_id_empleado", idEmpleado);
                                cmd.Parameters.AddWithValue("@ded_emp_sueldoB", sueldoBase);
                                cmd.Parameters.AddWithValue("@ded_impuestos", impuestos);
                                cmd.Parameters.AddWithValue("@ded_ded_otros", otrosDescuentos);
                                cmd.Parameters.AddWithValue("@ded_sueldo_final", sueldoFinal);
                                cmd.Parameters.AddWithValue("@ded_prestamo/anticipo", prestamoAnticipo);

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
