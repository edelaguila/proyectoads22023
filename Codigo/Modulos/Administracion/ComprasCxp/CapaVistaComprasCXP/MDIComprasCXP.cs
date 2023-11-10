using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaComprasCXP
{
    public partial class MDIComprasCXP : Form
    {
        private string id = "";
        private string nombre = "";
        private string domicilio = "";
        private string telefono = "";
        private string idord = "";
        private string fechaS = "";
        private string fechaE = "";
        private string solicitante = "";
        private string proveedor = "";

        //ControladorCOMPRASCXP cn = new ControladorCOMPRASCXP();
        public MDIComprasCXP()
        {
            InitializeComponent();
            //Control para habilitar opciones del menu
            Button[] apps = { btnproveedor, btnconcepto, btnmovimientoproveedor, btnordenescompras, btncompra };
            //Llamada metodo de libreria Controlador del modulo de Seguridad
            //cns.deshabilitarApps(apps);
            //Llamada metodo de libreria Controlador del modulo de Seguridad
            //cns.getAccesoApp(2001, apps[1]);
            //cns.getAccesoApp(2002, apps[2]);
            //cns.getAccesoApp(2003, apps[3]);
            //cns.getAccesoApp(2004, apps[4]);
            //cns.getAccesoApp(2005, apps[5]);
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
            if (this.panelMDI.Controls.Count > 0)
                this.panelMDI.Controls.RemoveAt(0);

            Form fh = abrirform as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.None;
            this.panelMDI.Controls.Add(fh);
            this.panelMDI.Tag = fh;
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

        private void btnconcepto_Click(object sender, EventArgs e)
        {
            Abrir(new Mantenimientos.Concepto());
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
            Abrir(new Procedimientos.Compras(idord, fechaS, fechaE, solicitante, proveedor));
            hideSubMenu();
        }

        private void btnproveedor_Click(object sender, EventArgs e)
        {
            Abrir(new Mantenimientos.Proveedores());
            hideSubMenu();
        }
    }
}
