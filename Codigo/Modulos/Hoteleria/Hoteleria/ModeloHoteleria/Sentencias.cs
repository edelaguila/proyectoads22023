using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

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
    }
}
