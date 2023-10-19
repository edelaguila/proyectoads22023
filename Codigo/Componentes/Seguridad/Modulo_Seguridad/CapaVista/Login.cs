using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;

namespace CapaVista
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            textBox1.Focus();
        }

        Controlador cn = new Controlador();


        public void LoginIngresar()
        {

            
            string dato = textBox1.Text;
            string tabla = "tbl_usuario";
            string columna = "nbr_username_usuario";
            DataTable dt = cn.Buscar(tabla, columna, dato);

           

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0]; // Tomamos la primera fila (si hay resultados)

                // Llenamos los controles con los valores del resultado
                string Usuario = row["nbr_username_usuario"].ToString();
                string Contraseña= row["nbr_password_usuario"].ToString();

                if ((Usuario.Equals(textBox1.Text)) && (Contraseña.Equals(cn.Encriptacion(textBox2.Text))))
                {
                    // Acceso a Menu Principal
                    MessageBox.Show("Bienvenido");
                    MenuSeguridad Mens = new MenuSeguridad();
                    Mens.Show();
                    this.Hide();
                }
                else
                {
                    //Limpieza de los controles si condicion no se cumple
                    textBox1.Text = string.Empty;
                    textBox2.Text = string.Empty;
                    textBox1.Focus();
                    MessageBox.Show("Usuario y/o contraseña incorrectas");
                }

            }
            else
            {
                // Limpiamos los controles si no se encontraron resultados
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
                textBox1.Focus();
                MessageBox.Show("Usuario y/o contraseña incorrectas");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginIngresar();
        }
    }
}
