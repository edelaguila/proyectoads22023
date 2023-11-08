using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace Controlador_PrototipoMenu
{
    public class ControladorInventario
    {
        Modelo_PrototipoMenu.SentenciasInventario sn = new Modelo_PrototipoMenu.SentenciasInventario();
        public DataTable llenartb3(string condicion)
        {
            string consulta = "select * from tbl_consultainteligente where nombre_consulta= " + '"' + condicion + '"';
            OdbcDataAdapter dt = sn.llenartb2(consulta);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        //CREA UN DOCUMENTO PARA REFERENCIAR LA AUDITORIA

        public bool crearDocAuditoria(int no_audito, int cod_Bodega, string fecha, string descripcion)
        {
            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    conn.Open();
                    int estado = 0;

                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "INSERT INTO TBL_Doc_Auditoria VALUES('" + no_audito + "','" + cod_Bodega + "','" + fecha + "','" + descripcion + "','" + estado + "')";
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        return true;
                    }

                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        //ACTUALIZA DOCUMENTO PARA REFERENCIAR LA AUDITORIA
        public bool actualizarDocAuditoria(int no_audito, int cod_bodega, string fecha, string descripcion)
        {
            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    conn.Open();

                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "UPDATE TBL_Doc_Auditoria SET FK_Codigo_bodega = '" + cod_bodega + "', Fecha = '" + fecha + "',  Descripcion = '" + descripcion + "'  WHERE PK_Id_Doc_Auditoria = '" + no_audito + "'";
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        return true;
                    }

                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }




        //INSETAR DETALLE
        public bool insertaDetalle(int doc_audito, int cod_prod, int cantLogica, int cantFisica, int Diferencia)
        {
            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    conn.Open();

                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "INSERT INTO  TBL_muestra_auditoria VALUES('" + doc_audito + "','" + cod_prod + "','" + cantLogica + "','" + cantFisica + "','" + Diferencia + "')";
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        return true;
                    }

                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        //GENERA COPIA DE INVENTARIO SEGUN BODEGA
        public bool generarCopiaInventario(int cod_Auditoria)
        {
            OdbcDataReader dr = null;


            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    conn.Open();

                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "SELECT * FROM TBL_detalleinventariobodega";
                        dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {

                            int code = Convert.ToInt32(dr["FK_Codigo_Producto"].ToString());
                            int logica = Convert.ToInt32(dr["stock"].ToString());
                            int valDef = 0;

                            //INSERT DETALLES
                            insertaDetalle(cod_Auditoria, code, logica, valDef, valDef);



                        }

                        dr.Close();
                        conn.Close();
                        return true;
                    }

                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }












        //OBTIENE EL NUMERO DE DOCUMENTO SIGUIENTE
        public int getNoDoc()
        {
            OdbcDataReader dr = null;

            int no = -1;
            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    conn.Open();

                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "SELECT PK_Id_Doc_Auditoria FROM TBL_Doc_Auditoria";
                        dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                            no = Convert.ToInt32(dr["PK_Id_Doc_Auditoria"].ToString());
                        }

                        dr.Close();
                        conn.Close();

                        if (no == -1)
                        {
                            no = 0;
                        }
                        return no + 1;
                    }

                }
            }
            catch (Exception ex)
            {
                return no;
            }
        }



        //GET BODEGAS
        public DataTable getBodegas()
        {
            DataTable dt = new DataTable();

            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    OdbcDataReader dr;
                    conn.Open();
                    {
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "SELECT * FROM TBL_Bodega";
                            dt.Columns.Add("name");
                            dr = cmd.ExecuteReader();

                            while (dr.Read())
                            {
                                DataRow row = dt.NewRow();
                                row["name"] = dr["Nombre_Bodega"];
                                dt.Rows.Add(row);
                            }

                            dr.Close();
                            conn.Close();
                            return dt;

                        }
                    }

                }
            }
            catch (Exception ex)
            {
                return dt;
            }
        }




        //GET DATOS AUDITORIA
        public DataTable getDatosAudit()
        {
            DataTable dt = new DataTable();

            int a = 0;
            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    OdbcDataReader dr;
                    conn.Open();
                    {
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "SELECT * FROM TBL_Doc_Auditoria";
                            dt.Columns.Add("Id_Doc");
                            dt.Columns.Add("Id_Bodega");
                            dt.Columns.Add("Descripcion");
                            dt.Columns.Add("Fecha");

                            dr = cmd.ExecuteReader();

                            while (dr.Read())
                            {
                                DataRow row = dt.NewRow();
                                row["Id_Doc"] = dr["PK_Id_Doc_Auditoria"].ToString();
                                row["Id_Bodega"] = dr["FK_Codigo_bodega"].ToString();
                                row["Fecha"] = dr["Fecha"].ToString();
                                row["Descripcion"] = dr["Descripcion"].ToString();


                                dt.Rows.Add(row);
                            }

                            dr.Close();
                            conn.Close();
                            return dt;

                        }
                    }

                }
            }
            catch (Exception ex)
            {
                return dt;
            }
        }




        //GET DETALLE AUDITORIA
        public DataTable getDetalleAudit(int no_Audit)
        {
            DataTable dt = new DataTable();


            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    OdbcDataReader dr;
                    conn.Open();
                    {
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "SELECT * FROM TBL_Muestra_Auditoria WHERE PK_Id_Doc_Auditoria = '" + no_Audit + "'";
                            dt.Columns.Add("Id_Doc");
                            dt.Columns.Add("Cod_Producto");
                            dt.Columns.Add("Cantidad_Logica");
                            dt.Columns.Add("Cantidad_Fisica");
                            dt.Columns.Add("Diferencia");

                            dr = cmd.ExecuteReader();

                            while (dr.Read())
                            {
                                DataRow row = dt.NewRow();
                                row["Id_Doc"] = dr["PK_Id_Doc_Auditoria"].ToString();
                                row["Cod_Producto"] = dr["PK_Codigo_Producto"].ToString();
                                row["Cantidad_Logica"] = dr["Cantidad_Logica"].ToString();
                                row["Cantidad_Fisica"] = dr["Cantidad_Fisica"].ToString();
                                row["Diferencia"] = dr["Diferencia"].ToString();
                                dt.Rows.Add(row);
                            }

                            dr.Close();
                            conn.Close();
                            return dt;

                        }
                    }

                }
            }
            catch (Exception ex)
            {
                return dt;
            }
        }




        //OBTIENE EL NUMERO INDICE
        public int getIndexBodega(int ID)
        {
            OdbcDataReader dr = null;
            int no = -1;
            int cont = -1;
            int value = 0;
            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    conn.Open();

                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "SELECT PK_Codigo_bodega FROM TBL_Bodega";
                        dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                            cont++;

                            no = Convert.ToInt32(dr["PK_Codigo_bodega"].ToString());

                            if (no == ID)
                            {
                                value = cont;
                            }
                        }

                        dr.Close();
                        conn.Close();
                        return value;
                    }

                }
            }
            catch (Exception ex)
            {
                return value;
            }
        }

        //OBTIENE CODIGO DE BODEGA
        public int getCodBodega(string name)
        {
            OdbcDataReader dr = null;
            int cod = 0;


            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    conn.Open();

                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "SELECT PK_Codigo_bodega FROM TBL_Bodega WHERE Nombre_Bodega = '" + name + "'";
                        dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                            cod = Convert.ToInt32(dr["PK_Codigo_bodega"].ToString());
                        }

                        dr.Close();
                        conn.Close();
                        return cod;
                    }

                }
            }
            catch (Exception ex)
            {
                return cod;
            }
        }




        //OBTIENE CODIGO Encabezado
        public int getCodigoEncabezado(int codBodega)
        {
            OdbcDataReader dr = null;
            int cod = 0;


            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    conn.Open();

                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "SELECT PK_cod_Enca FROM TBL_encainventariobodega WHERE FK_Codigo_bodega = '" + codBodega + "'";
                        dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                            cod = Convert.ToInt32(dr["PK_cod_Enca"].ToString());
                        }

                        dr.Close();
                        conn.Close();
                        return cod;
                    }

                }
            }
            catch (Exception ex)
            {
                return cod;
            }
        }
        public void CargarComboCtas(ComboBox cbo_boxctas)
        {
            OdbcConnection con = new OdbcConnection("Dsn=colchoneria");
            con.Open();
            OdbcCommand comando = new OdbcCommand("SELECT nombre_cuenta FROM tbl_cuentas", con);
            OdbcDataReader leer = comando.ExecuteReader();
            while (leer.Read())
            {
                cbo_boxctas.Items.Add(leer["nombre_cuenta"].ToString());
            }
        }
    }
}


