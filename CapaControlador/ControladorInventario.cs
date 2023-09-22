using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModelo;
using System.Data;
using System.Data.Odbc;

namespace CapaControlador
{
    public class ControladorInventario
    {
        public SentenciasInventario snInventario;

        public ControladorInventario()
        {
            //this.snInventario = new SentenciasInventario();
        }



        public void agregarInventario(Dictionary<string, string> parameters)
        {
            this.snInventario.agregarInventario(parameters);

        }

        public List<string> getColumns(string tabla)
        {
            return this.snInventario.getColumns(tabla);
        }

        public DataTable llenarTbl(string tabla)
        {
            OdbcDataAdapter dt = snInventario.llenarTbl(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }


    }
}
