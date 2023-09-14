using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
using System.Security.Cryptography;

namespace CapaModelo
{
    public class Sentencias
    {
        Conexion con = new Conexion();


        //carlos enrique
        public DataTable Buscar(string tabla, string columna, string dato)
        {
            string consulta = $"SELECT * FROM {tabla} WHERE {columna} = '{dato}'";
            OdbcDataAdapter datos = new OdbcDataAdapter(consulta, con.conexion());

            DataTable dt = new DataTable();
            datos.Fill(dt);

            return dt;
        }


        //carlos enrique
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




        //FUNCIÓN PARA MODIFICAR
        //-------------------------------------
        // MODIFICACION DE PERFIL_ENCABEZADO
        //-------------------------------------

        void ModificarPerfilEncabezado(int idPerfil, string nuevoNombre, string nuevaDescripcion, int nuevoEstado)
        {
            string updateQuery = "UPDATE Seguridad.Tbl_Perfil_encabezado SET nombre_perfil = ?, descripcion_perfil = ?, estado_perfil = ? WHERE pk_id_perfil = ?";

            using (OdbcConnection connection = con.conexion())
            using (OdbcCommand consultaPerflEnc = new OdbcCommand(updateQuery, connection))
            {
                consultaPerflEnc.Parameters.AddWithValue("@nombre_perfil", nuevoNombre);
                consultaPerflEnc.Parameters.AddWithValue("@descripcion_perfil", nuevaDescripcion);
                consultaPerflEnc.Parameters.AddWithValue("@estado_perfil", nuevoEstado);
                consultaPerflEnc.Parameters.AddWithValue("@pk_id_perfil", idPerfil);

                try
                {
                    connection.Open();
                    int rowsAffected = consultaPerflEnc.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Perfil modificado con éxito.");
                    }
                    else
                    {
                        Console.WriteLine("Ningún perfil modificado. Verifica el identificador.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al modificar el perfil: " + ex.Message);
                }
            }
        }

        //-------------------------------------
        // MODIFICACION DE USUARIO_APLICACION
        //-------------------------------------

        void ModificarPerfilUsuarioAplicacion(int idUsuario, int idAplicacion, int ingresar, int consulta, int modificar, int eliminar, int imprimir)
        {
            string updateQuery = "UPDATE Seguridad.Tbl_Usuario_aplicacion SET ingresar = ?, consulta = ?, modificar = ?, eliminar = ?, imprimir = ? WHERE pk_id_usuario = ? AND pk_id_aplicacion = ?";

            using (OdbcConnection connection = con.conexion())
            using (OdbcCommand consultaPerUsuApp = new OdbcCommand(updateQuery, connection))
            {
                consultaPerUsuApp.Parameters.AddWithValue("@ingresar", ingresar);
                consultaPerUsuApp.Parameters.AddWithValue("@consulta", consulta);
                consultaPerUsuApp.Parameters.AddWithValue("@modificar", modificar);
                consultaPerUsuApp.Parameters.AddWithValue("@eliminar", eliminar);
                consultaPerUsuApp.Parameters.AddWithValue("@imprimir", imprimir);
                consultaPerUsuApp.Parameters.AddWithValue("@pk_id_usuario", idUsuario);
                consultaPerUsuApp.Parameters.AddWithValue("@pk_id_aplicacion", idAplicacion);

                try
                {
                    connection.Open();
                    int rowsAffected = consultaPerUsuApp.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Permisos de usuario modificados con éxito.");
                    }
                    else
                    {
                        Console.WriteLine("Ningún permiso de usuario modificado. Verifica los identificadores.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al modificar los permisos de usuario: " + ex.Message);
                }
            }
        }


        //-------------------------------------
        // MODIFICACION DE PERFIL_DETALLE
        //-------------------------------------

        void ModificarPerfilDetalle(int idPerfil, int idAplicacion, int ingresar, int consultar, int modificar, int eliminar, int imprimir)
        {
            string updateQuery = "UPDATE Seguridad.Tbl_Perfil_detalle SET ingresar = ?, consultar = ?, modificar = ?, eliminar = ?, imprimir = ? WHERE pk_id_perfil = ? AND pk_id_aplicacion = ?";

            using (OdbcConnection connection = con.conexion())
            using (OdbcCommand consultaPerDetalle = new OdbcCommand(updateQuery, connection))
            {
                consultaPerDetalle.Parameters.AddWithValue("@ingresar", ingresar);
                consultaPerDetalle.Parameters.AddWithValue("@consultar", consultar);
                consultaPerDetalle.Parameters.AddWithValue("@modificar", modificar);
                consultaPerDetalle.Parameters.AddWithValue("@eliminar", eliminar);
                consultaPerDetalle.Parameters.AddWithValue("@imprimir", imprimir);
                consultaPerDetalle.Parameters.AddWithValue("@pk_id_perfil", idPerfil);
                consultaPerDetalle.Parameters.AddWithValue("@pk_id_aplicacion", idAplicacion);

                try
                {
                    connection.Open();
                    int rowsAffected = consultaPerDetalle.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Detalle de perfil modificado con éxito.");
                    }
                    else
                    {
                        Console.WriteLine("Ningún detalle de perfil modificado. Verifica los identificadores.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }


        //-------------------------------------
        // MODIFICACION DE APLICACION A MODULO
        //-------------------------------------

        void ModificarAppModulo(int idAplicacion, int idModulo)
        {
            string updateQuery = "UPDATE Seguridad.Tbl_Aplicacion_a_modulos SET pk_id_modulo = ? WHERE pk_id_aplicacion = ?";

            using (OdbcConnection connection = con.conexion())
            using (OdbcCommand consultaAppModulo = new OdbcCommand(updateQuery, connection))
            {
                consultaAppModulo.Parameters.AddWithValue("@pk_id_modulo", idModulo);
                consultaAppModulo.Parameters.AddWithValue("@pk_id_aplicacion", idAplicacion);

                int rowsAffected = consultaAppModulo.ExecuteNonQuery();

                try
                {
                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Asociación entre aplicación y módulo modificada con éxito.");
                    }
                    else
                    {
                        Console.WriteLine("Ninguna asociación modificada. Verifica los identificadores.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        //MODULO DE ENCRIPTACION SHA256 Jonathan Arriaga
        public string Encriptacion(string str)
        {
            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }
    }
}
