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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            CenterToScreen();
        }

        Conexion cn = new Conexion();

        void AgregaEmpleado()
        {

            string cadena = "INSERT INTO empleados (nombre_completo, puesto, departamento) VALUES ('" + txtNombre.Text + "','" + txtPuesto.Text + "','" + txtDepartamento.Text + "');";
            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();



        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            AgregaEmpleado();

            txtNombre.Text = "";
            txtPuesto.Text = "";
            txtDepartamento.Text = "";
            
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            Registro form2 = new Registro(); // Crear una instancia de Form2
            form2.Show();
        }
    }
}
    