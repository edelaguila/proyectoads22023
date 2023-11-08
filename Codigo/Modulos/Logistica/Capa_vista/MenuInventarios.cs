using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista_PrototipoMenu;
using Seguridad_Controlador;  // Agregar cuando se vincule la DLL de seguridad 

namespace Vista_PrototipoMenu
{

    public partial class MenuInventarios : Form
    {

        Controlador cn = new Controlador();  // Agregar cuando se vincule la DLL de seguridad 

        //Método que guarda en un arreglo de tipo botón los botones que se tienen en el formulario. Se les da permiso a los diferentes botones de acuerdo a la función que realice este
        public MenuInventarios()
        {
            InitializeComponent();
            //Control para habilitar opciones del menu
            //Button[] apps = {btnaplicaciones, btnPerfiles}; // Agregar cuando se vincule la DLL de seguridad 
            //Llamada metodo de libreria Controlador del modulo de Seguridad
            //cn.deshabilitarApps(apps); // Agregar cuando se vincule la DLL de seguridad 
            //Llamada metodo de libreria Controlador del modulo de Seguridad
            //cn.getAccesoApp(4001, apps[0]); // Agregar cuando se vincule la DLL de seguridad 
            //cn.getAccesoApp(4002, apps[1]);
        }

        //Validaciones que si son visibles los panales los oculta
        private void hideSubMenu()
        {

            if (panelTranportes.Visible == true)
                panelTranportes.Visible = false;
            if (PanelAuditoria.Visible == true)
                PanelAuditoria.Visible = false;
            if (panelseguridad.Visible == true)
                panelseguridad.Visible = false;
            if (panelayuda.Visible == true)
                panelayuda.Visible = false;
        }
        //Método que valida si el submenu no es visible oculta el submenu
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        //Método que muestra el panel indicado
        private void btnmanteniminetos_Click(object sender, EventArgs e)
        {
            showSubMenu(panelTranportes);
        }
        //Método que muestra el panel indicado
        private void btnProcesos_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelAuditoria);
            
        }
        //Método que muestra el panel indicado
        private void btnSeguridad_Click(object sender, EventArgs e)
        {
            showSubMenu(panelayuda);
        }
        //Método que muestra el panel indicado
        private void btnReportes_Click(object sender, EventArgs e)
        {
            showSubMenu(panelseguridad);
        }
        //Método que muestra el formulario indicado
        //Método que muestra el formulario indicado
        private void btnaplicaciones_Click(object sender, EventArgs e)
        {

        }
        //Método que muestra el formulario indicado

        private void btninicio_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Método que oculta el formulario
        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Método que muestra el formulario indicado
        private void btnayuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "umg.chm");
        }



        private void btn_movimientos_Click(object sender, EventArgs e)
        {
            MovimientosInventario m = new MovimientosInventario();
            m.MdiParent = this;
            m.Show();
            hideSubMenu();
        }

        private void btn_mantenimientos_Click(object sender, EventArgs e)
        {
            Mantenimiento form = new Mantenimiento();
            form.MdiParent = this;
            form.Show();
            hideSubMenu();
        }

        private void btn_traslados_Click(object sender, EventArgs e)
        {
            TrasladoProductos form = new TrasladoProductos();
            form.MdiParent = this;
            form.Show();
            hideSubMenu();
        }

        private void btn_muestreo_Click(object sender, EventArgs e)
        {
            DataGridView dgv = new DataGridView();
            Muestreo form = new Muestreo(dgv);
            form.MdiParent = this;
            form.Show();
            hideSubMenu();
        }

        private void btn_auditoria_Click(object sender, EventArgs e)
        {
            Auditoria form = new Auditoria();
            form.MdiParent = this; // 'this' se refiere al formulario actual como el formulario principal
            form.Show();
            hideSubMenu();

        }
    }
}

