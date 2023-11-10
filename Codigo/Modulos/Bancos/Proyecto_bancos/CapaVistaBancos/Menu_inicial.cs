using System;
using System.Windows.Forms;
using Seguridad_Controlador;

namespace CapaVistaBancos
{
    ////Codigo escrito por Luis Franco
    public partial class Menu_inicial : Form
    {
        Controlador cn = new Controlador();
        public Menu_inicial()
        {
            InitializeComponent();
            //Control para habilitar opciones del menu
            Button[] apps = { btn_MovBancarios, btn_ConciliacionBancaria, btn_cambio, btn_dispo, btn_ordCompras, btn_agregarBanco, btn_agregarCuenta, btn_agregaMov, btn_mant_compras };
            //Llamada metodo de libreria Controlador del modulo de Seguridad
            cn.deshabilitarApps(apps);
            //Llamada metodo de libreria Controlador del modulo de Seguridad
            cn.getAccesoApp(5001, apps[0]);
            cn.getAccesoApp(5002, apps[1]);
            cn.getAccesoApp(5003, apps[2]);
            cn.getAccesoApp(5004, apps[3]);
            cn.getAccesoApp(5005, apps[4]);
            cn.getAccesoApp(5006, apps[5]);
            cn.getAccesoApp(5007, apps[6]);
            cn.getAccesoApp(5008, apps[7]);
            cn.getAccesoApp(5009, apps[8]);
            customizeDesign();
        }




        private void Menu_inicial_Load(object sender, EventArgs e)
        {

        }
        private void customizeDesign()
        {
            pnl_subMenu_mantenimientos.Visible = false;
            pnl_subMenu_movBancarios.Visible = false;
        }
        private void hideSubMenu1()
        {
            if (pnl_subMenu_mantenimientos.Visible == true)
            {
                pnl_subMenu_mantenimientos.Visible = false;
            }

        }
        private void hideSubMenu2()
        {
            if (pnl_subMenu_movBancarios.Visible == true)
            {
                pnl_subMenu_movBancarios.Visible = false;
            }
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu1();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }


        private void showsubMenu2(Panel subMenu2)
        {
            if (subMenu2.Visible == false)
            {
                hideSubMenu2();
                subMenu2.Visible = true;
            }
            else
            {
                subMenu2.Visible = false;
            }
        }


        private void btn_MovBancarios_Click(object sender, EventArgs e)
        {
            cn.setBtitacora("5001", "Movimientos Bancarios");
            Mov_bancarios nmov = new Mov_bancarios();
            openChildForm(nmov);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void btn_mantenimientos_Click(object sender, EventArgs e)
        {
            cn.setBtitacora("5005", "Aut. ordenes compra");
            Ordenes_compra norden = new Ordenes_compra();
            openChildForm(norden);
        }



        private void btn_dispoycambio_Click(object sender, EventArgs e)
        {
            cn.setBtitacora("5003", "Tipo de cambio");
            Tipo_cambio ntipoc = new Tipo_cambio();
            openChildForm(ntipoc);
        }

        private void btn_ConciliacionBancaria_Click(object sender, EventArgs e)
        {
            cn.setBtitacora("5002", "Conciliacion Bancaria");
            Con_bancaria ncon = new Con_bancaria();

            openChildForm(ncon);
        }

        private void btn_ordCompras_Click(object sender, EventArgs e)
        {
            //cn.setBtitacora("5004", "Dipo. diaria");
            //openChildForm(new Dispo_diaria());
        }



        private void button1_Click(object sender, EventArgs e)
        {
            showSubMenu(pnl_subMenu_mantenimientos);
        }

        private void btn_mant_movBancarios_Click_2(object sender, EventArgs e)
        {
            showsubMenu2(pnl_subMenu_movBancarios);
        }

        private void btn_agregarBanco_Click(object sender, EventArgs e)
        {
            cn.setBtitacora("5006", "Mant. Agregar Bancos");
            Mantenimiento_Agregar_Bancos nbanco = new Mantenimiento_Agregar_Bancos();
            openChildForm(nbanco);
        }

        private void btn_agregarCuenta_Click(object sender, EventArgs e)
        {
            cn.setBtitacora("5007", "Mant. Agregar Cuenta");
            Mantenimiento_agregar_cuenta ncuenta = new Mantenimiento_agregar_cuenta();
            openChildForm(ncuenta);
        }

        private void btn_agregaMov_Click(object sender, EventArgs e)
        {
            cn.setBtitacora("5008", "Mant. Agregar Movimiento");
            Mantenimiento_tipoMov ntipo = new Mantenimiento_tipoMov();
            openChildForm(ntipo);
        }

        private void btn_mant_compras_Click(object sender, EventArgs e)
        {
            cn.setBtitacora("5009", "Mant. Agregar orden Compra");
            Mantenimiento_OrdenesdeCompra nordenc = new Mantenimiento_OrdenesdeCompra();
            openChildForm(nordenc);
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
            //ir al formulario principal
        }


        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnl_childForm.Controls.Add(childForm);
            pnl_childForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void pnl_childForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
