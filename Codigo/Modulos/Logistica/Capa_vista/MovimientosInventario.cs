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
//using Controlador_InventariosMenu();


namespace Vista_PrototipoMenu
{
   // Controlador cn = new Controlador();
    public partial class MovimientosInventario : Form
    {
        public MovimientosInventario()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            // BOTON ACEPTAR, PARA MANDAR LOS DATOS DE LOS TXT AL DATAGRIDVIEW
            

            // Obtén los valores de los TextBox
            string valor1 = txt_id.Text;
            string valor2 = txt_almacen.Text;
            string valor3 = txt_movimiento.Text;
            string valor4 = txt_doc.Text;
            string valor5 = txt_fecha.Text;
            string valor6 = txt_codigos.Text;
            string valor7 = txt_medida.Text;
            string valor8 = txt_cantidad.Text;
            string valor9 = txt_costo.Text;
            string valor10 = txt_precio.Text;
         

            // Añade los valores al DataGridView
            dgv_inventario.Rows.Add(valor1, valor2, valor3, valor4, valor5, valor6, valor7, valor8, valor9, valor10);

            // Limpia los TextBox después de agregar los datos al DataGridView
            txt_id.Text = "";
            txt_almacen.Text = "";
            txt_movimiento.Text = "";
            txt_doc.Text = "";
            txt_fecha.Text = "";
            txt_codigos.Text = "";
            txt_medida.Text = "";
            txt_cantidad.Text = "";
            txt_cantidad.Text = "";
            txt_costo.Text = "";
            txt_precio.Text = "";
            
        }

        private void btn_quitar_Click(object sender, EventArgs e)
        {
            // BOTON ACEPTAR, PARA MANDAR LOS DATOS DE LOS TXT AL DATAGRIDVIEW
            // Justin Emmanuel Ramos Pennant

            // Verifica si hay al menos una fila seleccionada en el DataGridView
            if (dgv_inventario.SelectedRows.Count > 0)
            {
                // Recorre las filas seleccionadas en reversa para evitar problemas con los índices
                for (int i = dgv_inventario.SelectedRows.Count - 1; i >= 0; i--)
                {
                    dgv_inventario.Rows.RemoveAt(dgv_inventario.SelectedRows[i].Index);
                }
            }
            else
            {
                // Muestra un mensaje si no se ha seleccionado ninguna fila
                MessageBox.Show("Seleccione uno o varios datos antes de remover", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void navegador1_Load(object sender, EventArgs e)
        {

            NavegadorVista.Navegador.idApp = "4100";  //código aplicación asignado al formulario
            navegador1.actual = this;
            navegador1.tabla = dgv_inventario;
            TextBox[] Grupotextbox = { txt_id, txt_almacen, txt_movimiento, txt_doc, txt_fecha, txt_codigos, txt_medida,txt_cantidad,txt_cantidad,
            txt_costo, txt_precio};
            TextBox[] Idtextbox = { txt_id, txt_codigos };
            navegador1.textbox = Grupotextbox;
            navegador1.textboxi = Idtextbox;
           // navegador1.cargar(dgv_inventario, Grupotextbox, cn.getNombreBd());



        }
    }
}
