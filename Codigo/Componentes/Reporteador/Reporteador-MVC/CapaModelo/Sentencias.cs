﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;

namespace CapaModelo
{
    public class Sentencias
    {
        Conexion con = new Conexion();

        // obtener datos de una tabla CAPA MODELO

        public OdbcDataAdapter llenarTbl(string tabla)
        {
            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro 
            string sql = "SELECT * FROM " + tabla + "  ;"; 
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion()); 
            return dataTable; 
        }

        public OdbcDataAdapter Eliminardata(string tabla, string fila)
        {
            string sql ="DELETE fila FROM " + tabla + " ;";
        }
    }
}