using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using System.Data.Odbc;


{
    public class ControladorBanco
    {
        private SentenciasBanco sentencias ;

        public void InsertarTipoMoneda(string TipoMoneda, string ValorMoneda, string estado)
        {
            sentencias.InsertarTipoMoneda(TipoMoneda, ValorMoneda, estado);
        }
        public DataTable llenarTblMoneda(string tabla)
        {
            return sentencias.llenarTblMoneda(tabla);
        }
        public ControladorBanco()
        {
            sentencias = new SentenciasBanco();
           
        }
        public void InsertarMovimiento(string valorMovimiento, string descripcionMovimiento, string numCuenta, string tipoTransaccion, string estado)
        {
            sentencias.InsertarMovimiento(valorMovimiento, descripcionMovimiento, numCuenta, tipoTransaccion, estado);
        }
        public DataTable llenarTbl(string tabla)
        {
            return sentencias.llenarTbl(tabla);
        }


        public static OdbcConnection ObtenerConexion()
        {
            // Cadena de conexión ODBC
            string connectionString = "DSN=hotelssse";

            OdbcConnection conectar = new OdbcConnection(connectionString);

            conectar.Open(); // Abriendo la conexión
            return conectar; // Regresa la conexión
        }

        public static DataTable ObtenerIdBanco(string Banco)
        {
            DataTable dt = new DataTable();

            string consulta = "SELECT cori_tipo_de_compra FROM tbl_compra WHERE cdes_id_compra = ?"; // Consulta

            using (OdbcConnection connection = ObtenerConexion())
            using (OdbcCommand comandoB = new OdbcCommand(consulta, connection))
            {
                comandoB.Parameters.AddWithValue("cori_tipo_de_compra", Banco); // Agrega los parámetros a la consulta
                OdbcDataAdapter adap = new OdbcDataAdapter(comandoB); // Adaptador
                adap.Fill(dt); // Llena la datatable con el adaptador del comando
            }

            return dt;
        }

        public static DataTable idmoncu(string noCuenta)
        {
            DataTable dt = new DataTable();

            string consulta = "SELECT cdes_id_compra FROM tbl_cuentabanco WHERE cori_noCuenta = ?"; // Consulta

            using (OdbcConnection connection = ObtenerConexion())
            using (OdbcCommand comando = new OdbcCommand(consulta, connection))
            {
                comando.Parameters.AddWithValue("cori_noCuenta", noCuenta); // Parámetros que se agregan a la consulta
                OdbcDataAdapter adap = new OdbcDataAdapter(comando); // Adaptador
                adap.Fill(dt); // Llena la datatable con el adaptador del comando
            }

            return dt;
        }

        public static DataTable ObtenerSaldo(string noCuenta)
        {
            DataTable dt = new DataTable();

            string consulta = "SELECT cdes_saldoDisponible FROM tbl_cuentabanco, tbl_compra WHERE tbl_cuentabanco.cori_noCuenta = ? AND tbl_compra.cdes_id_compra = tbl_cuentabanco.cdes_id_compra;"; // Consulta

            using (OdbcConnection connection = ObtenerConexion())
            using (OdbcCommand comando = new OdbcCommand(consulta, connection))
            {
                comando.Parameters.AddWithValue("cori_noCuenta", noCuenta); // Parámetros que se agregan a la consulta
                OdbcDataAdapter adap = new OdbcDataAdapter(comando); // Adaptador
                adap.Fill(dt); // Llena la datatable con el adaptador del comando
            }

            return dt;
        }

        public static DataTable ObtenertMoneda(string noCuenta)
        {
            DataTable dt = new DataTable();

            string consulta = "SELECT fk_cori_tipo_de_moneda FROM tbl_cuentabanco, tbl_compra WHERE tbl_cuentabanco.cori_noCuenta = ? AND tbl_compra.cdes_id_compra = tbl_cuentabanco.cdes_id_compra;"; // Consulta

            using (OdbcConnection connection = ObtenerConexion())
            using (OdbcCommand comando = new OdbcCommand(consulta, connection))
            {
                comando.Parameters.AddWithValue("cori_noCuenta", noCuenta); // Parámetros que se agregan a la consulta
                OdbcDataAdapter adap = new OdbcDataAdapter(comando); // Adaptador
                adap.Fill(dt); // Llena la datatable con el adaptador del comando
            }

            return dt;
        }

        public static DataTable ValorM(string moneda)
        {
            DataTable dt = new DataTable();

            string consulta = "SELECT cori_valor FROM tbl_moneda WHERE tbl_moneda.tbl_moneda = ?"; // Consulta

            using (OdbcConnection connection = ObtenerConexion())
            using (OdbcCommand comando = new OdbcCommand(consulta, connection))
            {
                comando.Parameters.AddWithValue("cori_nombre", moneda); // Parámetros que se agregan a la consulta
                OdbcDataAdapter adap = new OdbcDataAdapter(comando); // Adaptador
                adap.Fill(dt); // Llena la datatable con el adaptador del comando
            }

            return dt;
        }

        public static void trasladoS(string noCuenta, double saldo)
        {
            string updateQuery = "UPDATE tbl_cuentabanco SET cdes_saldoDisponible = ? WHERE tbl_cuentabanco.cori_noCuenta = ?"; // Consulta

            using (OdbcConnection connection = ObtenerConexion())
            using (OdbcCommand comando = new OdbcCommand(updateQuery, connection))
            {
                comando.Parameters.AddWithValue("saldo", saldo); // Parámetros que se agregan a la consulta
                comando.Parameters.AddWithValue("cori_noCuenta", noCuenta); // Parámetros que se agregan a la consulta
                comando.ExecuteNonQuery(); // Ejecución del query para realizar la actualización
            }
        }

        public static void actualizacion_saldos()
        {
            string updateQuery = "UPDATE tbl_cuentabanco SET cdes_saldoActual = cdes_saldoDisponible;"; // Consulta

            using (OdbcConnection connection = ObtenerConexion())
            using (OdbcCommand comando = new OdbcCommand(updateQuery, connection))
            {
                comando.ExecuteNonQuery(); // Ejecución del query para realizar la actualización
            }
        }
    }
}


    }
}

