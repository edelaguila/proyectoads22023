using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;
using CapaModeloComprasCXP;

namespace CapaControladorComprasCXP
{
    public class ControladorCOMPRASCXP
    {
        Sentencias sn = new Sentencias();

        public DataTable Buscar(string tabla, string columna, string dato)
        {
            return sn.Buscar(tabla, columna, dato);

        }

        public bool Eliminar(string tabla, string columna, string valor)
        {
            return sn.Eliminar(tabla, columna, valor);
        }

        public DataTable BuscarE(string tabla, string columna)
        {
            return sn.BuscarUltimoID(tabla, columna);

        }

        public DataTable llenarTbl(string tabla)
        {
            OdbcDataAdapter dt = sn.llenarTbl(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public DataTable llenarTblP(string tabla1)
        {
            OdbcDataAdapter dtp = sn.llenarTblP(tabla1);
            DataTable table1 = new DataTable();
            dtp.Fill(table1);
            return table1;
        }

        public List<string> llenarCombo(string columna1, string tabla)
        {
            return sn.llenarCombo(columna1, tabla);
        }



        public bool GuardarDatos(string tabla, Dictionary<string, object> valores)
        {
            return sn.Guardar(tabla, valores);
        }

        public void CargarOpciones2(ComboBox combo)
        {
            // Aquí proporciona las opciones al ComboBox
            combo.Items.Add("Directa");
            combo.Items.Add("Relacionada");
        }

        public DataTable llenarTbl2(String tabla)
        {
            OdbcDataAdapter dt = sn.llenarTbl2(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public int ObtenerSumaDetalleValor()
        {
            return sn.ObtenerSumaDetalleValor();
        }


        public int ObtenerUltimoNumeroOrden(String campoid, String tabla)
        {
            return sn.ObtenerUltimoNumeroOrden(campoid, tabla);
        }

        public DataTable enviar()
        {
            var dt1 = sn.obtener();
            return dt1;
        }

        public string[] items()
        {
            string[] Items = sn.llenarCmb2();
            return Items;
        }

        public string ObtenerDescripcion(string productId)
        {
            return sn.ObtenerDescripcion(productId);
        }

        public decimal ObtenerPrecioUnitario(string productId)
        {
            return sn.ObtenerPrecioUnitario(productId);
        }


        public string ObtenerNombreProveedor(string proveedorID)
        {
            return sn.ObtenerNombreProveedor(proveedorID);
        }

        public string ObtenerDomicilioProveedor(string proveedorID)
        {
            return sn.ObtenerDomicilioProveedor(proveedorID);
        }

        public string ObtenerTelefonoProveedor(string proveedorID)
        {
            return sn.ObtenerTelefonoProveedor(proveedorID);
        }

        public bool InsertarOrdenCompra(int codigo, string fechasolicitud, string fechaentrega, string depa, double subtotal, double iva, double total, string notas, int codProv, string entregara)
        {
            return sn.InsertarOrdenCompra(codigo, fechasolicitud, fechaentrega, depa, subtotal, iva, total, notas, codProv, entregara);
        }

        public void InsertarDatosDetalle(int codDetalle, int cantidad, double totalfila, int codigo, int idproducto)
        {
            sn.InsertarDatosDetalle(codDetalle, cantidad, totalfila, codigo, idproducto);
        }

        public bool InsertarCompra(int codigo, string fechas, string fechae, string departamento, string recibido, double subtotal, double iva, double totalOrden, string notas, int codorden, int codigoprov)
        {
            return sn.InsertarCompra(codigo, fechas, fechae, departamento, recibido, subtotal, iva, totalOrden, notas, codorden, codigoprov);
        }

        public void InsertarDatosDetalleCompra(int codDetalle, int cantidad, double totalfila, int codigo, int idproducto)
        {
            sn.InsertarDatosDetalleCompra(codDetalle, cantidad, totalfila, codigo, idproducto);
        }

        public bool EsCodigoProveedorValido(int codigoProveedor)
        {
            return sn.EsCodigoProveedorValido(codigoProveedor);
        }

        public DataTable ObtenerProveedorPorID(int id)
        {
            return sn.ObtenerProveedorPorID(id);
        }

        public DataTable ObtenerOrdenPorID(int id)
        {
            return sn.ObtenerOrdenPorID(id);
        }


    }
}
