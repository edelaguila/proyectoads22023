using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaModeloBancos;
namespace CapaControladorBancos
{
    public class ControladorBanco
    { //Codigo escrito por Luis Franco, Andrea Corado, Jonathan Arriaga e Isabel Aguirre
        private SentenciasBanco sentencias;

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
        public void InsertarMovimiento(string valorMovimiento, string descripcionMovimiento, string numCuenta, string tipoTransaccion, string estado, string valorTrans, string estadoConciliacion)
        {
            sentencias.InsertarMovimiento(valorMovimiento, descripcionMovimiento, numCuenta, tipoTransaccion, estado, valorTrans, estadoConciliacion);
        }
        public DataTable llenarTbl(string tabla)
        {
            return sentencias.llenarTbl(tabla);
        }

        public DataTable ObtenerCuentas()
        {
            return sentencias.ObtenerCuentas();
        }
        public decimal ObtenerSaldoTotal()
        {
            return sentencias.CalcularSaldoTotal();
        }


        public DataTable ObtenerTipoDeTransacciones()
        {
            return sentencias.TipoTransaccionBancaria();

        }
        public DataTable ObtenerTiposMoneda()
        {
            return sentencias.ObtenerTiposMoneda();
        }

        public DataTable ObtenerBancos()
        {
            return sentencias.ObtenerBancos();
        }

        public DataTable ObtenerTipoCuenta()
        {
            return sentencias.ObtenerTipoCuenta();

        }

        public DataTable valorTrans()
        {
            return sentencias.valorTransaccion();

        }

        public int ObtenerValorTransaccion(string tipoTransaccion)
        {
            return sentencias.ObtenerValorTransaccion(tipoTransaccion);
        }

    }
}

