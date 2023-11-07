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
<<<<<<< HEAD
        public DataTable ObtenerCuentas()
        {
            return sentencias.ObtenerCuentas();
        }

        public DataTable ObtenerTipoDeTransacciones()
        {
            return sentencias.TipoTransaccionBancaria();
=======

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
>>>>>>> a83717176d203d868d4df89e1ddd063b2894287c
        }
    }
}
