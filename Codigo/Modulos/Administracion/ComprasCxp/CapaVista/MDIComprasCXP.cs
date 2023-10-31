using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;

namespace CapaVista
{
    public partial class MDIComprasCXP : Form
    {
        private string id = "";
        private string nombre = "";
        private string domicilio = "";
        private string telefono = "";
        //private string idord = "";
        //private string fechaS = "";
        //private string fechaE = "";
        //private string solicitante = "";
        //private string proveedor = "";
        //Controlador cn = new Controlador();
        public MDIComprasCXP()
        {
            InitializeComponent();
            //Control para habilitar opciones del menu
            //Button[] apps = {btnaplicaciones};
            //Llamada metodo de libreria Controlador del modulo de Seguridad
            //cn.deshabilitarApps(apps);
            //Llamada metodo de libreria Controlador del modulo de Seguridad
            //cn.getAccesoApp(1002, apps[0]);
        }

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

        private void Abrir(object abrirform)
        {
            if (this.MDI.Controls.Count > 0)
                this.MDI.Controls.RemoveAt(0);

            Form fh = abrirform as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.None;
            this.MDI.Controls.Add(fh);
            this.MDI.Tag = fh;
            fh.Show();
        }

        private void btnmanteniminetos_Click(object sender, EventArgs e)
        {
            showSubMenu(panelTranportes);
        }

        private void btnProcesos_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelAuditoria);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            showSubMenu(panelseguridad);
        }

        private void btnSeguridad_Click(object sender, EventArgs e)
        {
            showSubMenu(panelayuda);
        }

        private void btnayuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "umg.chm");
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btninicio_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnclientes_Click(object sender, EventArgs e)
        {
            //Abrir(new "carpeta"."form"());
            //hideSubMenu();
        }

        private void btnproveedor_Click(object sender, EventArgs e)
        {
            //Abrir(new "carpeta"."form"());
            //hideSubMenu();
        }

        private void btnconcepto_Click(object sender, EventArgs e)
        {
            //Abrir(new "carpeta"."form"());
            //hideSubMenu();
        }

        private void btnmovimientocliente_Click(object sender, EventArgs e)
        {
            Abrir(new Procedimientos.Movimiento_cliente());
            hideSubMenu();
        }

        private void btnmovimientoproveedor_Click(object sender, EventArgs e)
        {
            Abrir(new Procedimientos.Movimiento_Proveedor());
            hideSubMenu();
        }

        private void btnordenescompras_Click(object sender, EventArgs e)
        {
            Abrir(new Procedimientos.OrdenesdeCompra(id, nombre, domicilio, telefono));
            hideSubMenu();
        }

        private void btncompra_Click(object sender, EventArgs e)
        {
            //Abrir(new "carpeta"."form"());
            //hideSubMenu();
        }
    }
}
