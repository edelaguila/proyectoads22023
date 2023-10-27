﻿using System;
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
    public partial class MDIComprasyCXP : Form
    {
        Controlador cn = new Controlador();

        public MDIComprasyCXP()
        {
            InitializeComponent();
            //Control para habilitar opciones del menu
            //Button[] apps = {btnaplicaciones};
            //Llamada metodo de libreria Controlador del modulo de Seguridad
            //cn.deshabilitarApps(apps);
            //Llamada metodo de libreria Controlador del modulo de Seguridad
            //cn.getAccesoApp(1002, apps[0]);
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


        private void btninicio_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnmanteniminetos_Click(object sender, EventArgs e)
        {
            showSubMenu(panelTranportes);
        }

        private void btnclientes_Click(object sender, EventArgs e)
        {
            //Cliente b = new Cliente();
            //b.MdiParent = this;
            //b.Show();
            //hideSubMenu();
        }

        private void btnproveedor_Click(object sender, EventArgs e)
        {
            //Proveedor b = new Proveedor();
            //b.MdiParent = this;
            //b.Show();
            //hideSubMenu();
        }

        private void btnconcepto_Click(object sender, EventArgs e)
        {
            //Concepto b = new Concepto();
            //b.MdiParent = this;
            //b.Show();
            //hideSubMenu();
        }

        private void btnProcesos_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelAuditoria);
        }

        private void btnmovimientocliente_Click(object sender, EventArgs e)
        {
            //MovimientoCliente b = new MovimientoCliente();
            //b.MdiParent = this;
            //b.Show();
            //hideSubMenu();
        }

        private void btnmovimientoproveedor_Click(object sender, EventArgs e)
        {
            //MovimientoProveedor b = new MovimientoProveedor();
            //b.MdiParent = this;
            //b.Show();
            //hideSubMenu();
        }

        private void btnordenescompras_Click(object sender, EventArgs e)
        {
            //OrdenesCompras b = new OrdenesCompras();
            //b.MdiParent = this;
            //b.Show();
            //hideSubMenu();
        }

        private void btncompra_Click(object sender, EventArgs e)
        {
            //Compras b = new Compras();
            //b.MdiParent = this;
            //b.Show();
            //hideSubMenu();
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
    }
}
