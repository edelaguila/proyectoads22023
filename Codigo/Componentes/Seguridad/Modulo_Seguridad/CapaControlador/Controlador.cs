using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModelo;
using System.Data.Odbc;
using System.Data;

namespace CapaControlador
{
    public class Controlador
    {
        Sentencias sn = new Sentencias();

        //carlos enrique
     public DataTable Buscar(string tabla, string columna, string dato)
        {
           return sn.Buscar(tabla, columna, dato);
        }

        //carlos enrique
        public bool Eliminar(string tabla, string columna, string valor)
        {
            return sn.Eliminar(tabla, columna, valor);
        }
        public bool GuardarDatos(string tabla, Dictionary<string, object> valores)
        {
            return sn.Guardar(tabla, valores);
        }

        //Justin Pennant
        public bool Modificar(string tabla, Dictionary<string, object> valores, string condicion)
        {
            return sn.Modificar(tabla, valores, condicion);
        }


        //Jonathan Arriaga
        public string Encriptacion(string str)
        {
            return sn.Encriptacion(str);
        }

        //Jonathan Arriaga 
        public List<string> ObtenerDatos(string columna, string tabla)
        {
            return sn.ObtenerDatos(columna, tabla);
        }
        /*//carlos enrique
        public DataTable llenarTblBitacora(string tabla)
        {
            OdbcDataAdapter dt = sn.llenarTblBitacora(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }*/

        public DataTable Llenardatagrid(string dato)
        {
            return sn.LlenaDGV(dato);
        }
    }
}
