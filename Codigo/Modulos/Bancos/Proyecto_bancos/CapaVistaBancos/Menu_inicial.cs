using System;
using System.Windows.Forms;

namespace CapaVistaBancos
{
    ////Codigo escrito por Luis Franco
    public partial class Menu_inicial : Form
    {
        public Menu_inicial()
        {
            InitializeComponent();
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
            Mov_bancarios nmov = new Mov_bancarios();
            openChildForm(nmov);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void btn_mantenimientos_Click(object sender, EventArgs e)
        {
            Ordenes_compra norden = new Ordenes_compra();
            openChildForm(norden);
        }



        private void btn_dispoycambio_Click(object sender, EventArgs e)
        {
            Tipo_cambio ntipoc = new Tipo_cambio();
            openChildForm(ntipoc);
        }

        private void btn_ConciliacionBancaria_Click(object sender, EventArgs e)
        {
            Con_bancaria ncon = new Con_bancaria();
            openChildForm(ncon);
        }

        private void btn_ordCompras_Click(object sender, EventArgs e)
        {
            openChildForm(new Dispo_diaria());
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
            Mantenimiento_Agregar_Bancos nbanco = new Mantenimiento_Agregar_Bancos();
            openChildForm(nbanco);
        }

        private void btn_agregarCuenta_Click(object sender, EventArgs e)
        {
            Mantenimiento_agregar_cuenta ncuenta = new Mantenimiento_agregar_cuenta();
            openChildForm(ncuenta);
        }

        private void btn_agregaMov_Click(object sender, EventArgs e)
        {
            Mantenimiento_tipoMov ntipo = new Mantenimiento_tipoMov();
            openChildForm(ntipo);
        }

        private void btn_mant_compras_Click(object sender, EventArgs e)
        {
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
