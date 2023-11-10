using System;
using System.Windows.Forms;
using CapaControladorBancos;
using System.Data;
namespace CapaVistaBancos
{
    public partial class Tipo_cambio : Form
    {
        ControladorBanco cn = new ControladorBanco();
        string mon = "tbl_registro_moneda";

        public void actualizardatagridView()
        {
            DataTable dt = cn.llenarTblMoneda(mon);
            dataGridView1.DataSource = dt;

        }

        public Tipo_cambio()
        {
            InitializeComponent();
            actualizardatagridView();
        }

        private void btn_salir_dispo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrEmpty(textBox.Text))
            {
                ((TextBox)sender).Text = "1";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea guardar el archivo?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question); //OTTO ADRIAN LOPEZ VENTURA 0901-20-1069

            if (result == DialogResult.Yes)
            {
                //LUIS ALBERTO FRANCO MORAN 0901-20-23979
                // Llamar al Controlador para insertar el movimiento en la base de datos
                cn.InsertarTipoMoneda(textBox4.Text, textBox1.Text, textBox3.Text);

                // Actualizar el DataGridView con los datos actualizados
                actualizardatagridView();

                // Limpiar los TextBox
               


                // Mostrar un mensaje de éxito
                MessageBox.Show("Movimiento realizado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //LUIS ALBERTO FRANCO MORAN 0901-20-23979
                // Limpiar los TextBox si el usuario elige "No"
                

                // Mostrar un mensaje informativo
                MessageBox.Show("No se guardó el archivo.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);//OTTO ADRIAN LOPEZ VENTURA 0901-20-1069 
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Tipo_cambio
            // 
            this.ClientSize = new System.Drawing.Size(584, 401);
            this.Name = "Tipo_cambio";
            this.ResumeLayout(false);

        }
    }
}
