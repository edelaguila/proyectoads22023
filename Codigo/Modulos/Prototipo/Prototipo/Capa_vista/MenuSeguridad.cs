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
using CapaVista;

namespace Vista_PrototipoMenu
{
    public partial class MenuSeguridad : Form
    {

        Controlador cn = new Controlador();

        //Método que guarda en un arreglo de tipo botón los botones que se tienen en el formulario. Se les da permiso a los diferentes botones de acuerdo a la función que realice este
        public MenuSeguridad()
        {
            InitializeComponent();
            //Control para habilitar opciones del menu
            //Button[] apps = {btn_deducciones, btn_percepciones, btnaplicaciones};
            //Llamada metodo de libreria Controlador del modulo de Seguridad
            //cn.deshabilitarApps(apps);
            //Llamada metodo de libreria Controlador del modulo de Seguridad
           // Console.WriteLine(apps);
            //cn.getAccesoApp(6001, apps[0]);
            //cn.getAccesoApp(6002, apps[1]);
           // cn.getAccesoApp(6003, apps[2]);

            
            

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
            //Aplicacion b = new Aplicacion();
            //b.MdiParent = this;
            //b.Show();
            //hideSubMenu();
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

        private void MenuSeguridad_Load(object sender, EventArgs e)
        {

        }

        private void btn_deducciones_Click(object sender, EventArgs e)
        {
            frm_deduccion nomded = new CapaVista.frm_deduccion();
            nomded.MdiParent = this;
            nomded.Show();
            hideSubMenu();

        }

        private void btn_percepciones_Click(object sender, EventArgs e)
        {
            frm_percepciones nomperc = new CapaVista.frm_percepciones();
            nomperc.MdiParent = this;
            nomperc.Show();
            hideSubMenu();
        }
    }
}
