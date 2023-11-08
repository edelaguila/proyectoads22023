using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Collections;
using System.Data;

namespace Modelo_PrototipoMenu
{
    public class SentenciasInventario
    {
        Controlador_PrototipoMenu.ControladorInventario dataL = new Controlador_PrototipoMenu.ControladorInventario();
        Modelo_PrototipoMenu.Conexion con = new Modelo_PrototipoMenu.Conexion();
        public OdbcDataAdapter llenartb2(string sql)
        {
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());
            return datatable;
        }
        //CREAR DOCUMENTO AUDITORIA
        public bool crearDocAuditoria(int no_audito, int cod_Bodega, string fecha, string descripcion)
        {
            return dataL.crearDocAuditoria(no_audito, cod_Bodega, fecha, descripcion);
        }

        //OBTENER DOCUMENTO SIGUIENTE
        public int getNoDoc()
        {
            return dataL.getNoDoc();
        }

        //ACTUALIZA DOCUMENTO PARA REFERENCIAR LA AUDITORIA
        public bool actualizarDocAuditoria(int no_audito, int cod_Bodega, string fecha, string descripcion)
        {
            return dataL.actualizarDocAuditoria(no_audito, cod_Bodega, fecha, descripcion);
        }


        //GET BODEGAS
        public DataTable getBodegas()
        {
            return dataL.getBodegas();
        }

        //GET INDEX
        public int getIndexBodega(int id)
        {
            return dataL.getIndexBodega(id);
        }


        //OBTIENE CODIGO DE BODEGA
        public int getCodBodega(string name)
        {
            return dataL.getCodBodega(name);
        }




        //GET DATOS AUDITORIA
        public DataTable getDatosAudit()
        {
            return dataL.getDatosAudit();
        }


        //GET DETALLE AUDITORIA
        public DataTable getDetalleAudit(int no_Audit)
        {
            return dataL.getDetalleAudit(no_Audit);
        }



        //OBTIENE CODIGO Encabezado
        public int getCodigoEncabezado(int codBodega)
        { return dataL.getCodigoEncabezado(codBodega); }


        //GENERA COPIA DE INVENTARIO
        public bool generarCopiaInventario(int cod_Auditoria)
        { return dataL.generarCopiaInventario(cod_Auditoria); }
    }
}
