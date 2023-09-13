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

    }
}
