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
    public partial class TrasladoProductos : Form
    {

        Controlador cn = new Controlador();

        public TrasladoProductos()
        {
            InitializeComponent();

            txt_precioUnit.TextChanged += CalcularCostoTotal;
            txt_cantidad.TextChanged += CalcularCostoTotal;
            txt_fecha.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "4005";  //código aplicación asignado al formulario
            navegador1.actual = this;
            navegador1.tabla = dgv_traslaProd;
            TextBox[] Grupotextbox = { txt_idDoc, txt_destino, txt_nombreDoc, txt_fecha, txt_idProc, txt_nombreProc, txt_cantidad, txt_costoTotal, txt_precioUnit };
            TextBox[] Idtextbox = { txt_idDoc, txt_destino };
            navegador1.textbox = Grupotextbox;
            navegador1.textboxi = Idtextbox;
            navegador1.cargar(dgv_traslaProd, Grupotextbox, cn.getNombreBd());
        }

        private void CalcularCostoTotal(object sender, EventArgs e)
        {
            // Verificar si los valores en los cuadros de texto son numéricos
            if (double.TryParse(txt_precioUnit.Text, out double precioUnit) &&
                double.TryParse(txt_cantidad.Text, out double cantidad))
            {
                // Realizar la multiplicación y mostrar el resultado en txt_costoTotal
                double costoTotal = precioUnit * cantidad;
                txt_costoTotal.Text = costoTotal.ToString();
            }
            else
            {
                // Si los valores no son numéricos.
                txt_costoTotal.Text = "En Espera...";
            }
        }
    }
}