using System;
using System.Data;
using CapaModelo;

namespace CapaControlador
/* AUTORES:
LUIS ALBERTO FRANCO MORAN 0901-20-23979
OTTO ADRIAN LOPEZ VENTURA 0901-20-1069  */
{
    public class Controlador
    {
        private Sentencias sentencias;

        public Controlador()
        {
            sentencias = new Sentencias();
        }

        // Insertar un nuevo registro con archivo de texto
        public void InsertarReporte(string correlativo, string nombreArchivo, string estado, string rutaArchivo)
        {
            sentencias.InsertarReporte(correlativo, nombreArchivo, estado, rutaArchivo);
        }

        // Obtener todos los reportes
        public DataTable ObtenerReportes()
        {
            return sentencias.ObtenerReportes();
        }

        // Actualizar un reporte existente
        public void ActualizarReporte(int idReporte, string correlativo, string nombre, string estado)
        {
            sentencias.ActualizarReporte(idReporte, correlativo, nombre, estado);
        }

        // Eliminar un reporte existente
        public void EliminarReporte(int idReporte)
        {
            sentencias.EliminarReporte(idReporte);
        }

        // Obtener los datos de una tabla específica (llenarTbl)
        public DataTable llenarTbl(string tabla)
        {
            return sentencias.llenarTbl(tabla);
        }
    }
}


