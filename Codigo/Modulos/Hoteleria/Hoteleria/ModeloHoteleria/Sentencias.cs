using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using ModeloHoteleria.templates;
using System.Data.SqlClient;

namespace ModeloHoteleria
{
    public class Sentencias : Conexion
    {
        public Conexion conn;
        public Sentencias()
        {
            this.conn = new Conexion();
        }


        public List<TipoHabitacion> getTiposHabitacion()
        {
            List<TipoHabitacion> listaResultados = new List<TipoHabitacion>();
            try
            {
                string tabla = "tbl_tipohabitacion";
                string query = "SELECT * FROM " + tabla;
                OdbcCommand command = new OdbcCommand(query, this.conn.connection());
                OdbcDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (!reader.IsDBNull(0) && !reader.IsDBNull(1) && !reader.IsDBNull(2) && !reader.IsDBNull(3) && !reader.IsDBNull(4))
                    {
                        int id = Convert.ToInt32(reader["thab_id"]);
                        string nombre = reader["thab_nombre"].ToString();
                        string descripcion = reader["thab_descripcion"].ToString();
                        double precio = Convert.ToDouble(reader["thab_precio"]);
                        int capacidad = Convert.ToInt32(reader["thab_capacidad"]);

                        TipoHabitacion tipoHabitacion = new TipoHabitacion(id, nombre, descripcion, precio, capacidad);
                        listaResultados.Add(tipoHabitacion);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return listaResultados;
        }



        public List<Habitacion> getHabitaciones()
        {
            List<Habitacion> listaHabitaciones = new List<Habitacion>();
            try
            {
                string tabla = "tbl_habitacion";
                string query = "SELECT * FROM " + tabla;
                OdbcCommand command = new OdbcCommand(query, this.conn.connection());
                OdbcDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Habitacion habitacion = new Habitacion();
                    habitacion.id = Convert.ToInt32(reader["hab_id"]);
                    habitacion.numero = Convert.ToInt32(reader["hab_numero"]);
                    habitacion.tipo = Convert.ToInt32(reader["hab_tipo"]);
                    habitacion.estado = Convert.ToInt32(reader["hab_estado"]);
                    listaHabitaciones.Add(habitacion);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return listaHabitaciones;
        }

        public List<Empleado> ObtenerEmpleados()
        {
            List<Empleado> empleados = new List<Empleado>();

            string query = "SELECT emp_id, emp_nombre, emp_apellido, emp_correo, emp_telefono, emp_nit FROM tbl_empleado";
            OdbcCommand command = new OdbcCommand(query, this.conn.connection());

            try
            {
                OdbcDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Empleado empleado = new Empleado
                    (
                         Convert.ToInt32(reader["emp_id"]),
                         reader["emp_nombre"].ToString(),
                         reader["emp_apellido"].ToString(),
                         reader["emp_correo"].ToString(),
                         reader["emp_telefono"].ToString(),
                          reader["emp_nit"].ToString()
                    );
                    empleados.Add(empleado);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return empleados;
        }
        public List<Cliente> ObtenerClientes()
        {
            List<Cliente> clientes = new List<Cliente>();

            string query = "SELECT cli_id, cli_nombre, cli_apellido, cli_correo, cli_telefono, cli_nit FROM tbl_cliente";
            OdbcCommand command = new OdbcCommand(query, this.conn.connection());
            try
            {
                OdbcDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Cliente cliente = new Cliente
                    (
                         Convert.ToInt32(reader["cli_id"]),
                         reader["cli_nombre"].ToString(),
                         reader["cli_apellido"].ToString(),
                         reader["cli_correo"].ToString(),
                         reader["cli_telefono"].ToString(),
                         reader["cli_nit"].ToString()
                    );
                    clientes.Add(cliente);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return clientes;
        }
        public int ObtenerUltimaId()
        {
            int ultimaId = -1; // Valor predeterminado en caso de que no haya ninguna fila en la tabla

            string query = "SELECT MAX(eva_id) as UltimaId FROM tbl_evaluacion";

            OdbcCommand command = new OdbcCommand(query, this.conn.connection());
            try
            {
                OdbcDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    if (reader["UltimaId"] != DBNull.Value)
                    {
                        ultimaId = Convert.ToInt32(reader["UltimaId"]);
                    }
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return ultimaId;
        }


    }
}
