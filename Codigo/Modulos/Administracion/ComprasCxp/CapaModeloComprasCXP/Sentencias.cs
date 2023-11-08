using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModeloComprasCXP
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
            string sql = "SELECT e.id_EncabezadoProveedor, p.id_proveedor, p.pro_Nombre, e.encabezadoProveedor_Factura, co.con_Descripcion, co.con_Tipo, co.con_SerieConcepto, " +
              "e.encabezadoProveedor_FechaEmision, e.encabezadoProveedor_FechaVencimiento, d.detalleProveedor_valor " +
              "FROM tbl_encabezadomovimientoproveedor e " +
              "INNER JOIN tbl_detallemovimientoproveedor d ON e.id_EncabezadoProveedor = d.CodigoEncabezadoProveedor " +
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

        public OdbcDataAdapter llenarTbl2(string tabla)
        {
            string sql = "SELECT * FROM " + tabla + ";";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }

        public int ObtenerSumaDetalleValor()
        {
            string sql = "SELECT SUM(DetalleProveedor_valor) FROM tbl_detallemovimientoproveedor";
            OdbcCommand cmd = new OdbcCommand(sql, con.conexion());

            try
            {
                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    int suma = Convert.ToInt32(result);
                    return suma;
                }
                else
                {
                    // Manejo de caso en el que no se obtiene un valor válido
                    // Puedes retornar un valor predeterminado o manejar la situación según tus necesidades.
                    return 0; // Por ejemplo, se retorna 0 si no se encontraron resultados.
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                // Puedes registrar el error, lanzar una excepción personalizada o manejarlo de otra manera.
                Console.WriteLine("Error en ObtenerSumaDetalleValor: " + ex.Message);
                return 0; // Retorno 0 en caso de error.
            }
        }
        // aqui finaliza mi codificacion

        public int ObtenerUltimoNumeroOrden(string campoid, string tabla)
        {
            int ultimoNumeroOrden = 0;
            Conexion con = new Conexion();
            OdbcConnection conn = con.conexion();

            // Conectar a la base de datos utilizando la clase Conexion
            using (conn)
            {
                // Consulta SQL para obtener el último número de orden
                string query = "SELECT MAX(" + campoid + ") FROM " + tabla + ";";
                using (OdbcCommand cmd = new OdbcCommand(query, conn))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        ultimoNumeroOrden = Convert.ToInt32(result) + 1;
                    }
                    else
                    {
                        ultimoNumeroOrden++;
                    }
                }
            }

            // 'conn' se cerrará automáticamente
            return ultimoNumeroOrden;
        }

        public string[] llenarCmb2()
        {

            string[] Campos = new string[300];
            string[] auto = new string[300];
            int i = 0;
            string sql = "SELECT id_producto, pro_nombre FROM tbl_productos WHERE pro_disponibilidad='si';";

            try
            {
                OdbcCommand command = new OdbcCommand(sql, con.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Campos[i] = reader.GetValue(0).ToString() + "-" + reader.GetValue(1).ToString();
                    i++;
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nError en asignarCombo"); }
            return Campos;
        }
        public DataTable obtener()
        {

            string sql = "SELECT id_producto, pro_nombre FROM tbl_productos WHERE pro_disponibilidad='si';";

            OdbcCommand command = new OdbcCommand(sql, con.conexion());
            OdbcDataAdapter adaptador = new OdbcDataAdapter(command);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            return dt;
        }

        public string ObtenerDescripcion(string productId)
        {
            string descripcion = string.Empty;
            using (OdbcConnection conn = con.conexion())
            {
                string query = "SELECT pro_descripcion FROM tbl_productos WHERE id_producto = " + productId + ";";
                using (OdbcCommand cmd = new OdbcCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("id", productId);
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        descripcion = result.ToString();
                    }
                }
            }
            return descripcion;
        }

        public decimal ObtenerPrecioUnitario(string productId)
        {
            decimal precioUnitario = 0;
            using (OdbcConnection conn = con.conexion())
            {
                string query = "SELECT pro_preciounitario FROM tbl_productos WHERE id_producto = " + productId + ";";
                using (OdbcCommand cmd = new OdbcCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("id", productId);
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        precioUnitario = Convert.ToDecimal(result);
                    }
                }
            }
            return precioUnitario;
        }

        public string ObtenerNombreProveedor(string proveedorID)
        {
            string query = "SELECT pro_Nombre FROM tbl_proveedor WHERE id_proveedor = " + proveedorID + ";";

            using (OdbcConnection conn = con.conexion())
            {
                using (OdbcCommand cmd = new OdbcCommand(query, conn))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        return result.ToString();
                    }
                }
            }

            return string.Empty; // Se irá aquí en caso de no encontrar al proveedor
        }

        public string ObtenerDomicilioProveedor(string proveedorID)
        {
            string query = "SELECT pro_Domicilio FROM tbl_proveedor WHERE id_proveedor = " + proveedorID + ";";

            using (OdbcConnection conn = con.conexion())
            {
                using (OdbcCommand cmd = new OdbcCommand(query, conn))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        return result.ToString();
                    }
                }
            }

            return string.Empty;
        }

        public string ObtenerTelefonoProveedor(string proveedorID)
        {
            string query = "SELECT pro_Telefono FROM tbl_proveedor WHERE id_proveedor = " + proveedorID + ";";

            using (OdbcConnection conn = con.conexion())
            {
                using (OdbcCommand cmd = new OdbcCommand(query, conn))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        return result.ToString();
                    }
                }
            }

            return string.Empty;
        }
    }
}
