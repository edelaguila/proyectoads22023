﻿using System;
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
        //Justin Pennant
        // basado en Guardar
        public bool Modificar(string tabla, Dictionary<string, object> valores, string condicion)
        {
            using (OdbcConnection conn = con.conexion())
            {
                // Construir la consulta SQL para actualizar datos
                string setClause = string.Join(", ", valores.Keys.Select(key => $"{key} = ?"));
                string consulta = $"UPDATE {tabla} SET {setClause} WHERE {condicion}";

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
        //Erick Ramirez
        public DataTable llenarTblBitacora()// metodo  que obtinene el contenio de una tabla
        {
            string consulta = $"SELECT * FROM tbl_bitacora";
            OdbcDataAdapter datos = new OdbcDataAdapter(consulta, con.conexion());
            DataTable dt = new DataTable();
            datos.Fill(dt);
            return dt;
        }

        //--------------------------------


        //MODULO DE ENCRIPTACION SHA256| Jonathan Arriaga
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


        //MODULO PARA LLENADO DE COMBOBOX Jonathan Arriaga
        public List<string> ObtenerDatos(string columna, string tabla)
        {
            List<string> datos = new List<string>();
            try
            {

                string consulta = $"SELECT {columna} FROM {tabla}";

                OdbcCommand command = new OdbcCommand(consulta, con.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string nombre = reader[columna].ToString();
                    datos.Add(nombre);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return datos;
        }

        //BUSQUEDA IDPERFIL
        public DataTable LlenaDGV(string dato)
        {
            string consulta = $"SELECT up.FK_id_perfil AS ID_Perfil_Usuario, pe.nbr_nombre_perfil AS Nombre_Perfil FROM tbl_usuario_perfil AS up INNER JOIN tbl_perfil_encabezado AS pe ON up.FK_id_perfil = pe.PK_id_perfil WHERE up.FK_id_usuario = '{dato}';";
            OdbcDataAdapter datos = new OdbcDataAdapter(consulta, con.conexion());
            DataTable dt = new DataTable();
            datos.Fill(dt);
            return dt;
        }
    }
}
