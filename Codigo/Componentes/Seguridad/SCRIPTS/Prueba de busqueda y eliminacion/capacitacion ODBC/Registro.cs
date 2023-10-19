using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc; 
namespace capacitacion_ODBC
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
            Consultar();
            CenterToScreen();
        }

        Conexion cn = new Conexion();

        void Consultar() {

            string cadena = "SELECT * FROM empleados";

            OdbcDataAdapter datos = new OdbcDataAdapter(cadena, cn.conexion());

            DataTable dt = new DataTable();

            datos.Fill(dt);

            dgv_tabla.DataSource = dt;
        }

        void Buscar(string strfiltro)
        {
            string consulta = $"SELECT * FROM empleados WHERE codigo_empleado = '{strfiltro}'";

            OdbcDataAdapter datos = new OdbcDataAdapter(consulta, cn.conexion());

            DataTable dt = new DataTable();

            datos.Fill(dt);

            dgv_tabla.DataSource = dt;
        }

        private void Eliminar(string strcodigo)
        {
            using (OdbcConnection conn = cn.conexion())
            {
                
                string consulta = "DELETE FROM empleados WHERE codigo_empleado = ?";
                using (OdbcCommand cmd = new OdbcCommand(consulta, conn))
                {
                    cmd.Parameters.AddWithValue("strcodigo", strcodigo);
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Registro eliminado correctamente.");
                        // También puedes actualizar la tabla después de la eliminación si es necesario
                        Consultar();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el registro. Verifique el codigo del empleado.");
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Consultar();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string strfiltro = txt_Busqueda.Text; 
            Buscar(strfiltro);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string strcodigo = txt_Busqueda.Text;
           
                Eliminar(strcodigo);
           
        }
    }
}
