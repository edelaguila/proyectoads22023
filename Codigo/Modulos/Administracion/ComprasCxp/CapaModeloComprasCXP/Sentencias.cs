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

        public bool InsertarOrdenCompra(int codigo, string fechasolicitud, string fechaentrega, string depa, double subtotal, double iva, double total, string notas, int codProv, string entregara)
        {
            string insertQueryOrden = getQueryOrden(codigo, fechasolicitud, fechaentrega, depa, subtotal, iva, total, notas, codProv, entregara);
            using (OdbcConnection conn = con.conexion())
            {
                using (OdbcCommand cmd = new OdbcCommand(insertQueryOrden, conn))
                {
                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                        return false;
                    }
                }
            }
        }

        public string getQueryOrden(int codigo, string fechasolicitud, string fechaentrega, string depa, double subtotal, double iva, double total, string notas, int codProv, string entregara)
        {
            string sql = "insert into tbl_ordenescompra(ord_id,ord_FechaSolicitud,ord_FechaEntrega,ord_deptosolicitante,ord_subtotal,ord_iva,ord_totalOrden,ord_totalLetras,fk_proveedor_id,ord_entregara) values ('" + codigo + "', '" + fechasolicitud + "', '" + fechaentrega + "', '" + depa + "', '" + subtotal + "', '" + iva + "', '" + total + "', '" + notas + "', '" + codProv + "', '" + entregara + "')";
            return sql;
        }

        public bool InsertarDatosDetalle(int codDetalle, int cantidad, double totalfila, int codigo, int idproducto)
        {
            string insertQueryDetalle = getQueryDetalle(codDetalle, cantidad, totalfila, codigo, idproducto);
            using (OdbcConnection conn = con.conexion())
            {
                using (OdbcCommand cmd = new OdbcCommand(insertQueryDetalle, conn))
                {
                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                        return false;
                    }
                }
            }
        }

        public string getQueryDetalle(int codDetalle, int cantidad, double totalfila, int codigo, int idproducto)
        {
            string sql = "insert into tbl_detalleordenescompra(det_id_ordenes,det_cantidad_orde,det_totalPorProducto,fk_det_ord_id,fk_det_producto_id) values ('" + codDetalle + "', '" + cantidad + "', '" + totalfila + "', '" + codigo + "', '" + idproducto + "')";
            return sql;
        }

        public bool InsertarCompra(int codigo, string fechas, string fechae, string departamento, string recibido, double subtotal, double iva, double totalOrden, string notas, int codorden, int codigoprov)
        {
            string insertQueryCompra = getQueryCompra(codigo, fechas, fechae, departamento, recibido, subtotal, iva, totalOrden, notas, codorden, codigoprov);
            using (OdbcConnection conn = con.conexion())
            {
                using (OdbcCommand cmd = new OdbcCommand(insertQueryCompra, conn))
                {
                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                        return false;
                    }
                }
            }
        }

        public string getQueryCompra(int codigo, string fechas, string fechae, string departamento, string recibido, double subtotal, double iva, double totalOrden, string notas, int codorden, int codigoprov)
        {
            string sql = "insert into tbl_compras(com_id,com_fechasolicitud,com_fechaentrega,com_deptosolicitante, com_recibidopor,com_subtotal,com_iva,com_totalcompra,com_totalLetras,fk_ord_id,fk_proveedor_id) values ('" + codigo + "', '" + fechas + "', '" + fechae + "', '" + departamento + "', '" + recibido + "', '" + subtotal + "', '" + iva + "', '" + totalOrden + "', '" + notas + "', '" + codorden + "', '" + codigoprov + "')";
            return sql;
        }

        public bool InsertarDatosDetalleCompra(int codDetalle, int cantidad, double totalfila, int codigo, int idproducto)
        {
            string insertQueryDetalleCompra = getQueryDetalleCompra(codDetalle, cantidad, totalfila, codigo, idproducto);
            using (OdbcConnection conn = con.conexion())
            {
                using (OdbcCommand cmd = new OdbcCommand(insertQueryDetalleCompra, conn))
                {
                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                        return false;
                    }
                }
            }
        }

        public string getQueryDetalleCompra(int codDetalle, int cantidad, double totalfila, int codigo, int idproducto)
        {
            string sql = "insert into tbl_detalle_compras(det_id,det_cantidad_compra,det_totalPorProducto,fk_det_compras_id,fk_det_producto_id) values ('" + codDetalle + "', '" + cantidad + "', '" + totalfila + "', '" + codigo + "', '" + idproducto + "')";
            return sql;
        }

        public bool EsCodigoProveedorValido(int codigoProveedor)
        {
            using (OdbcConnection conn = con.conexion())
            {
                string query = "SELECT COUNT(*) FROM tbl_proveedor WHERE id_proveedor = ?";
                using (OdbcCommand cmd = new OdbcCommand(query, conn))
                {
                    cmd.Parameters.Add("codigoProveedor", OdbcType.Int).Value = codigoProveedor;
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        public DataTable ObtenerProveedorPorID(int id)
        {
            DataTable proveedorData = new DataTable();

            using (OdbcConnection conn = con.conexion())
            {
                string consulta = "SELECT pro_Nombre, pro_Domicilio, pro_Telefono FROM tbl_proveedor WHERE id_proveedor = ?";
                using (OdbcCommand cmd = new OdbcCommand(consulta, conn))
                {
                    cmd.Parameters.AddWithValue("id", id);
                    using (OdbcDataAdapter adapter = new OdbcDataAdapter(cmd))
                    {
                        adapter.Fill(proveedorData);
                    }
                }
            }

            return proveedorData;
        }

        public DataTable ObtenerOrdenPorID(int id)
        {
            DataTable ordenData = new DataTable();

            using (OdbcConnection conn = con.conexion())
            {
                string consulta = "SELECT ord_FechaSolicitud, ord_FechaEntrega,ord_deptosolicitante,fk_proveedor_id FROM tbl_ordenescompra WHERE ord_id = ?";
                using (OdbcCommand cmd = new OdbcCommand(consulta, conn))
                {
                    cmd.Parameters.AddWithValue("id", id);
                    using (OdbcDataAdapter adapter = new OdbcDataAdapter(cmd))
                    {
                        adapter.Fill(ordenData);
                    }
                }
            }

            return ordenData;
        }





    }
}
