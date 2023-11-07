using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControladorVentasCXC;
using Seguridad_Controlador;
namespace CapaVistaVentasCXC
{
    public partial class MDIVentasCXC : Form
    {
        Controlador_VentasCXC cn = new Controlador_VentasCXC();
        Controlador cns = new Controlador();

        public MDIVentasCXC()
        {
            InitializeComponent();

            //Control para habilitar opciones del menu
            //Button[] apps = { btnclientes, btnconcepto, btnmovimientocliente, btncotizaciones, btnpedido, btnfactura };
            //Llamada metodo de libreria Controlador del modulo de Seguridad

            //cns.deshabilitarApps(apps);
            //Llamada metodo de libreria Controlador del modulo de Seguridad

            //cns.getAccesoApp(3001, apps[1]);
            //cns.getAccesoApp(3002, apps[2]);
            //cns.getAccesoApp(3003, apps[3]);
            //cns.getAccesoApp(3004, apps[4]);
            //cns.getAccesoApp(3005, apps[5]);
            //cns.getAccesoApp(3006, apps[6]);
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
            Abrir(new Mantenimientos.Clientes());
            hideSubMenu();
        }

        private void btnconcepto_Click(object sender, EventArgs e)
        {
            Abrir(new Mantenimientos.Concepto());
            hideSubMenu();
        }

        private void btnmovimientocliente_Click(object sender, EventArgs e)
        {
            Abrir(new Procedimientos.Movimiento_Cliente());
            hideSubMenu();
        }

        private void btncotizaciones_Click(object sender, EventArgs e)
        {
            //Abrir(new "carpeta"."form"());
            //hideSubMenu();
        }

        private void btnpedido_Click(object sender, EventArgs e)
        {
            //Abrir(new "carpeta"."form"());
            //hideSubMenu();
        }

        private void btnfactura_Click(object sender, EventArgs e)
        {
            //Abrir(new "carpeta"."form"());
            //hideSubMenu();
        }
    }
}
