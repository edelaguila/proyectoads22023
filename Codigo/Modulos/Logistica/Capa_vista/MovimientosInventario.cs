using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Seguridad_Controlador;



namespace Vista_PrototipoMenu
{
   
    public partial class MovimientosInventario : Form
    {
        Controlador cn = new Controlador();
        public MovimientosInventario()
        {
            InitializeComponent();
        }

        private void txt_doc_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void navegador3_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "4001";  //código aplicación asignado al formulario
            navegador3.actual = this;
            navegador3.tabla = dgv_inventario;
            TextBox[] Grupotextbox = { txt_id, txt_almacen, txt_movimiento, txt_doc, txt_fecha, txt_codigos, txt_medida,txt_cantidad,
            txt_costo, txt_precio};
            TextBox[] Idtextbox = { txt_id, txt_almacen };
            navegador3.textbox = Grupotextbox;
            navegador3.textboxi = Idtextbox;
            navegador3.cargar(dgv_inventario, Grupotextbox, cn.getNombreBd());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string textoSeleccionado = cmb_tipomov.SelectedItem.ToString();
            txt_movimiento.Text = textoSeleccionado;
        }

        private void label15_Click(object sender, EventArgs e)
        {
           


        }

        private void MovimientosInventario_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_suma_Click(object sender, EventArgs e)
        {
            double suma2 = 0;
            double suma = 0;
            for (int i = 0; i < dgv_inventario.Rows.Count; i++)
            {
                suma += Convert.ToDouble(dgv_inventario.Rows[i].Cells["mov_costo"].Value);
                suma2 += Convert.ToDouble(dgv_inventario.Rows[i].Cells["mov_preciou"].Value);
            }

            label15.Text = suma.ToString();
            label16.Text = suma2.ToString();

        }
    }
}