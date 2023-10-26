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
namespace CapaVistaLI
{
    public partial class MDI_Logistica_Inventarios : Form
    {

        Controlador cn = new Controlador();
        public MDI_Logistica_Inventarios()
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
        private Form currentForm;
        private readonly MovimientosInventario formMovI = new MovimientosInventario();
        private readonly Muestreo formMue = new Muestreo();
        private readonly Auditoria formAud = new Auditoria();
        private readonly Mantenimiento formMan = new Mantenimiento();
        private readonly TrasladoProductos formTrsP = new TrasladoProductos();
    

        private void MostrarFormEnPanel(Form form)
        {
            CerrarFormActual(); // Close any previously displayed form

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pnl_cont.Controls.Add(form);
            form.Show();
            form.BringToFront(); // Bring the newly added form to the front
            currentForm = form; // Update the currentForm variable with the newly displayed form
        }

        // MÃ©todo para cerrar el formulario actualmente abierto en el panel.
        private void CerrarFormActual()
        {
            if (currentForm != null && !currentForm.IsDisposed)
            {
                currentForm.Hide();
                pnl_cont.Controls.Remove(currentForm);
                currentForm.Hide(); // Dispose of the form when closing it
                currentForm = null; // Reset the currentForm variable
            }
        }
      
        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
        
        private void btnReportes_Click(object sender, EventArgs e)
        {
            showSubMenu(panelseguridad);
        }

        private void btn_mantenimientos_Click(object sender, EventArgs e)
        {
            showSubMenu(panelTranportes);
        }

        private void btnProcesos_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelAuditoria);
        }

        private void btnSeguridad_Click(object sender, EventArgs e)
        {
            showSubMenu(panelayuda);
        }

        private void btninicio_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnayuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "umg.chm");
        }

        private void btn_mov_inv_Click(object sender, EventArgs e)
        {
            //Aplicacion b = new Aplicacion();
            //b.MdiParent = this;
            //b.Show();
            //hideSubMenu();
            MostrarFormEnPanel(formMovI);
        }

        private void btn_mantenimientos_inv_Click(object sender, EventArgs e)
        {
            //Aplicacion b = new Aplicacion();
            //b.MdiParent = this;
            //b.Show();
            //hideSubMenu();
            MostrarFormEnPanel(formMan);
        }

        private void btn_tras_p_Click(object sender, EventArgs e)
        {
            //Aplicacion b = new Aplicacion();
            //b.MdiParent = this;
            //b.Show();
            //hideSubMenu();
            MostrarFormEnPanel(formTrsP);
        }

        private void btn_muestreo_Click(object sender, EventArgs e)
        {
            //Aplicacion b = new Aplicacion();
            //b.MdiParent = this;
            //b.Show();
            //hideSubMenu();
            MostrarFormEnPanel(formMue);
        }

        private void btn_aud_Click(object sender, EventArgs e)
        {
            //Aplicacion b = new Aplicacion();
            //b.MdiParent = this;
            //b.Show();
            //hideSubMenu();
            MostrarFormEnPanel(formAud);
        }
    }
}
