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
        //----------------------------------Auditoria--------------------------------------//
        public bool Insertaudit(float _Pk, float _nUm, float _nom, string _Fech, string _FechS, float _Tip, float _Resev, float _Con, float _Rec, float _Check, float _Serv, float _Tot, float _Man, float _Seg, float _Est)
        {
            try
            {
                using (OdbcConnection con = new OdbcConnection("FIL=MS Access;DSN=Muestra"))
                {
                    OdbcCommand cmd = new OdbcCommand();
                    con.Open();
                    cmd.Connection = con;

                    #region Query
                    string query = @"INSERT INTO tbl_auditoria (pk_id_auditoria,numero_habitacion,nombre_huesped,fechaentrada_habitacion,fechsalidada_habitacion,tipo_habitacion,reservas_habitacion,consumo_habitacion,recepcion_habitacion,checkin_habitacion,serviciosadi_habitacion,total_gasto,mantenimiento_habitacion,seguridad_habitacion,estado_habitacion)VALUE(?,?,?,?,?,?,?,?,?,?,?,?,?,?);";
                    #endregion
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.Add("@pk_id_auditoria", OdbcType.Double).Value = _Pk;
                    cmd.Parameters.Add("@numero_habitacion", OdbcType.Double).Value = _nUm;
                    cmd.Parameters.Add("@nombre_huesped", OdbcType.Double).Value = _nom;
                    cmd.Parameters.Add("@fechaentrada_habitacion", OdbcType.Date).Value = _Fech;
                    cmd.Parameters.Add("@fechsalidada_habitacion", OdbcType.Date).Value = _FechS;
                    cmd.Parameters.Add("@tipo_habitacion", OdbcType.Double).Value = _Tip;
                    cmd.Parameters.Add("@reservas_habitacion", OdbcType.Double).Value = _Resev;
                    cmd.Parameters.Add("@consumo_habitacion", OdbcType.Double).Value = _Con;
                    cmd.Parameters.Add("@recepcion_habitacion", OdbcType.Double).Value = _Rec;
                    cmd.Parameters.Add("@checkin_habitacion", OdbcType.Double).Value = _Check;
                    cmd.Parameters.Add("@serviciosadi_habitacion", OdbcType.Double).Value = _Serv;
                    cmd.Parameters.Add("@total_Gasto", OdbcType.Double).Value = _Tot;
                    cmd.Parameters.Add("@mantenimiento_habitacion", OdbcType.Double).Value = _Man;
                    cmd.Parameters.Add("@seguridad_habitacion", OdbcType.Double).Value = _Seg;
                    cmd.Parameters.Add("@Pk_id_estados", OdbcType.Double).Value = _Est;
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    con.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool UpdateAudi(string PKid, string Num, string Nombre, string _Fech, string _FechS, string Tipo, string Reserva, string Consumo, string Recepcion, string CheckIn, string Servicios, string Total, string Mantenimiento, string Seguridad, string Estado)
        {
            try
            {
                using (OdbcConnection con = new OdbcConnection("FIL=MS Access;DSN=Muestra"))
                {
                    OdbcCommand cmd = new OdbcCommand();
                    con.Open();
                    cmd.Connection = con;

                    #region Query
                    string query = @"INSERT INTO tbl_auditoria (pk_id_auditoria,numero_habitacion,nombre_huesped,fechaentrada_habitacion,fechsalidada_habitacion,tipo_habitacion,reservas_habitacion,consumo_habitacion,recepcion_habitacion,recepcion_habitacion,checkin_habitacion,serviciosadi_habitacion,total_factura,mantenimiento_habitacion,seguridad_habitacion,Pk_id_estados)VALUE(?,?,?,?,?,?,?,?,?,?,?,?,?,?,?);";
                    #endregion
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.Add("@pk_id_auditoria", OdbcType.Int).Value = PKid;
                    cmd.Parameters.Add("@numero_habitacion", OdbcType.Double).Value = Num;
                    cmd.Parameters.Add("@nombre_huesped", OdbcType.Date).Value = Nombre;
                    cmd.Parameters.Add("@fechaentrada_habitacion", OdbcType.Date).Value = _Fech;
                    cmd.Parameters.Add("@fechsalidada_habitacion", OdbcType.Date).Value = _FechS;
                    cmd.Parameters.Add("@tipo_habitacion", OdbcType.VarChar).Value = Tipo;
                    cmd.Parameters.Add("@reservas_habitacion", OdbcType.VarChar).Value = Reserva;
                    cmd.Parameters.Add("@consumo_habitacion", OdbcType.VarChar).Value = Consumo;
                    cmd.Parameters.Add("@recepcion_habitacion", OdbcType.VarChar).Value = Recepcion;
                    cmd.Parameters.Add("@checkin_habitacion", OdbcType.VarChar).Value = CheckIn;
                    cmd.Parameters.Add("@serviciosadi_habitacion", OdbcType.VarChar).Value = Servicios;
                    cmd.Parameters.Add("@total_factura", OdbcType.Double).Value = Total;
                    cmd.Parameters.Add("@mantenimiento_habitacion", OdbcType.VarChar).Value = Mantenimiento;
                    cmd.Parameters.Add("@seguridad_habitacion", OdbcType.VarChar).Value = Seguridad;
                    cmd.Parameters.Add("@Pk_id_estados", OdbcType.VarChar).Value = Estado;
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    con.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool DeleteAudi(string _FechM)
        {
            try
            {
                using (OdbcConnection con = new OdbcConnection("FIL=MS Access;DSN=Muestra"))
                {
                    OdbcCommand cmd = new OdbcCommand();
                    con.Open();
                    cmd.Connection = con;
                    #region Query
                    string query = @"DELETE FROM tbl_auditoria WHERE tbl_auditoria.pk_id_auditoria = ?;";
                    #endregion
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.Add("@pk_id_auditoria", OdbcType.Date).Value = _FechM;
                    cmd.ExecuteNonQuery();

                    cmd.Parameters.Clear();
                    con.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public DataTable SelectAudi()
        {
            DataTable dt = new DataTable();
            using (OdbcDataAdapter adapter = new OdbcDataAdapter("SELECT * FROM tbl_auditoria;", "FIL=MS Access;DSN=Muestra"))
            {
                adapter.SelectCommand.CommandType = CommandType.Text;
                adapter.Fill(dt);
            }
            return dt;
        }
        public DataTable BuscarAud(string data, string col, DataTable dt)
        {
            OdbcConnection con = new OdbcConnection("Dsn=Muestra");
            try
            {
                //DataTable dt = new DataTable();
                String cadenaB = "";
                con.Open();
                cadenaB = " SELECT * FROM tbl_muestreo WHERE " + col + " LIKE ('%" + data.Trim() + "%')";
                OdbcDataAdapter datos = new OdbcDataAdapter(cadenaB, con);
                datos.Fill(dt);
                OdbcCommand comando = new OdbcCommand(cadenaB, con);
                OdbcDataReader leer;
                leer = comando.ExecuteReader();
            }
            catch
            {
                String textalert = " El dato : " + data + " No se encontro ";
                MessageBox.Show(textalert);
            }
            con.Close();
            return dt;
        }
        public DataTable ActualizarAudi(string table, DataTable dt)
        {
            try
            {
                OdbcConnection con = new OdbcConnection("Dsn=Muestra");
                String cadena = "";
                con.Open();
                cadena = "SELECT * FROM " + table;
                OdbcDataAdapter datos = new OdbcDataAdapter(cadena, con);
                datos.Fill(dt);
                OdbcCommand comando = new OdbcCommand(cadena, con);
                OdbcDataReader leer;
                leer = comando.ExecuteReader();
                con.Close();
            }
            catch
            {
                String textalert = " Error al actualizar datos, puede que no haya datos que mostrar ";
                MessageBox.Show(textalert);
            }
            return dt;
        }
        public DataTable BuscarDatoA(string data, string col, DataTable dt)
        {
            OdbcConnection con = new OdbcConnection("Dsn=Muestra");
            try
            {
                //DataTable dt = new DataTable();
                String cadenaB = "";
                con.Open();
                cadenaB = " SELECT * FROM tbl_auditoria WHERE " + col + " LIKE ('%" + data.Trim() + "%')";
                OdbcDataAdapter datos = new OdbcDataAdapter(cadenaB, con);
                datos.Fill(dt);
                OdbcCommand comando = new OdbcCommand(cadenaB, con);
                OdbcDataReader leer;
                leer = comando.ExecuteReader();
            }
            catch
            {
                String textalert = " El dato : " + data + " No se encontro ";
                MessageBox.Show(textalert);
            }
            con.Close();
            return dt;
        }
        //----------------------------------Muestra-------------------------------------//
        public bool InsertMues(string PKid, string NumM, string _Fech, string _FechS, string Mantenimiento, string Inventario, string Servicios, string Seguridad, string Estado)
        {
            try
            {
                using (OdbcConnection con = new OdbcConnection("FIL=MS Access;DSN=Muestra"))
                {
                    OdbcCommand cmd = new OdbcCommand();
                    con.Open();
                    cmd.Connection = con;

                    #region Query
                    string query = @"INSERT INTO tbl_muestreo (pk_id_muestreo,numerohabitacion_muestra,fechaentrada_muestra,fechsalidada_muestra,mantenimientohabitacion_muestra,Inventario_suministros,servicioshabitacion_muestra,seguridadhabitacion_muestra,Pk_id_estados)VALUE(?,?,?,?,?,?,?,?);";
                    #endregion
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.Add("@pk_id_muestreo", OdbcType.Int).Value = PKid;
                    cmd.Parameters.Add("@numerohabitacion_muestra", OdbcType.Int).Value = NumM;
                    cmd.Parameters.Add("@fechaentrada_muestra", OdbcType.Date).Value = _Fech;
                    cmd.Parameters.Add("@fechsalidada_muestra", OdbcType.Date).Value = _FechS;
                    cmd.Parameters.Add("@mantenimientohabitacion_muestra", OdbcType.VarChar).Value = Mantenimiento;
                    cmd.Parameters.Add("@Inventario_suministros", OdbcType.VarChar).Value = Inventario;
                    cmd.Parameters.Add("@servicioshabitacion_muestra", OdbcType.VarChar).Value = Servicios;
                    cmd.Parameters.Add("@seguridadhabitacion_muestra", OdbcType.VarChar).Value = Seguridad;
                    cmd.Parameters.Add("@Pk_id_estados", OdbcType.VarChar).Value = Estado;
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    con.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool UpdateMues(string PKid, string NumM, string _Fech, string _FechS, string Mantenimiento, string Inventario, string Servicios, string Seguridad, string Estado)
        {
            try
            {
                using (OdbcConnection con = new OdbcConnection("FIL=MS Access;DSN=Muestra"))
                {
                    OdbcCommand cmd = new OdbcCommand();
                    con.Open();
                    cmd.Connection = con;

                    #region Query
                    string query = @"INSERT INTO tbl_muestreo (pk_id_muestreo,numerohabitacion_muestra,fechaentrada_muestra,fechsalidada_muestra,mantenimientohabitacion_muestra,Inventario_suministros,servicioshabitacion_muestra,seguridadhabitacion_muestra,Pk_id_estados)VALUE(?,?,?,?,?,?,?,?);";
                    #endregion
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.Add("@pk_id_muestreo", OdbcType.Int).Value = PKid;
                    cmd.Parameters.Add("@numerohabitacion_muestra", OdbcType.Double).Value = NumM;
                    cmd.Parameters.Add("@fechaentrada_muestra", OdbcType.Date).Value = _Fech;
                    cmd.Parameters.Add("@fechsalidada_muestra", OdbcType.Date).Value = _FechS;
                    cmd.Parameters.Add("@mantenimientohabitacion_muestra", OdbcType.VarChar).Value = Mantenimiento;
                    cmd.Parameters.Add("@Inventario_suministros", OdbcType.VarChar).Value = Inventario;
                    cmd.Parameters.Add("@servicioshabitacion_muestra", OdbcType.VarChar).Value = Servicios;
                    cmd.Parameters.Add("@seguridadhabitacion_muestra", OdbcType.VarChar).Value = Seguridad;
                    cmd.Parameters.Add("@Pk_id_estados", OdbcType.VarChar).Value = Estado;
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    con.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool DeleteMues(string _FechM)
        {
            try
            {
                using (OdbcConnection con = new OdbcConnection("FIL=MS Access;DSN=Muestra"))
                {
                    OdbcCommand cmd = new OdbcCommand();
                    con.Open();
                    cmd.Connection = con;
                    #region Query
                    string query = @"DELETE FROM tbl_muestreo WHERE tbl_muestreo.pk_id_muestreo = ?;";
                    #endregion
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.Add("@pk_id_muestreo", OdbcType.Date).Value = _FechM;
                    cmd.ExecuteNonQuery();

                    cmd.Parameters.Clear();
                    con.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public DataTable Selectmues()
        {
            DataTable dt = new DataTable();
            using (OdbcDataAdapter adapter = new OdbcDataAdapter("SELECT * FROM tbl_muestreo;", "FIL=MS Access;DSN=Muestra"))
            {
                adapter.SelectCommand.CommandType = CommandType.Text;
                adapter.Fill(dt);
            }
            return dt;
        }
        public DataTable Buscarmues(string data, string col, DataTable dt)
        {
            OdbcConnection con = new OdbcConnection("Dsn=Muestra");
            try
            {
                //DataTable dt = new DataTable();
                String cadenaB = "";
                con.Open();
                cadenaB = " SELECT * FROM tbl_muestreo WHERE " + col + " LIKE ('%" + data.Trim() + "%')";
                OdbcDataAdapter datos = new OdbcDataAdapter(cadenaB, con);
                datos.Fill(dt);
                OdbcCommand comando = new OdbcCommand(cadenaB, con);
                OdbcDataReader leer;
                leer = comando.ExecuteReader();
            }
            catch
            {
                String textalert = " El dato : " + data + " No se encontro ";
                MessageBox.Show(textalert);
            }
            con.Close();
            return dt;
        }
        public DataTable Actualizarmues(string table, DataTable dt)
        {
            try
            {
                OdbcConnection con = new OdbcConnection("Dsn=Muestra");
                String cadena = "";
                con.Open();
                cadena = "SELECT * FROM " + table;
                OdbcDataAdapter datos = new OdbcDataAdapter(cadena, con);
                datos.Fill(dt);
                OdbcCommand comando = new OdbcCommand(cadena, con);
                OdbcDataReader leer;
                leer = comando.ExecuteReader();
                con.Close();
            }
            catch
            {
                String textalert = " Error al actualizar datos, puede que no haya datos que mostrar ";
                MessageBox.Show(textalert);
            }
            return dt;
        }
        public DataTable BuscarDato(string data, string col, DataTable dt)
        {
            OdbcConnection con = new OdbcConnection("Dsn=Muestra");
            try
            {
                //DataTable dt = new DataTable();
                String cadenaB = "";
                con.Open();
                cadenaB = " SELECT * FROM tbl_muestreo WHERE " + col + " LIKE ('%" + data.Trim() + "%')";
                OdbcDataAdapter datos = new OdbcDataAdapter(cadenaB, con);
                datos.Fill(dt);
                OdbcCommand comando = new OdbcCommand(cadenaB, con);
                OdbcDataReader leer;
                leer = comando.ExecuteReader();
            }
            catch
            {
                String textalert = " El dato : " + data + " No se encontro ";
                MessageBox.Show(textalert);
            }
            con.Close();
            return dt;
        }
    }
}

