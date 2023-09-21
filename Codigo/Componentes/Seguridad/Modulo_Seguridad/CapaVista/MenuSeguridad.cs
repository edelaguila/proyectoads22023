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
using System.IO;
using System.Diagnostics;

namespace CapaVista
{
    public partial class MenuSeguridad : Form
    {



        private void Abrir(object abrirform)
        {
            if (this.panel1.Controls.Count > 0)
                this.panel1.Controls.RemoveAt(0);

            Form fh = abrirform as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.None;
            this.panel1.Controls.Add(fh);
            this.panel1.Tag = fh;
            fh.Show();
        }


        public MenuSeguridad()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrir(new MantUsuario());
        }

        private void aplicacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrir(new Mantenimiento.MantAplicaciones());
        }

        private void modulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrir(new Mantenimiento.MantModulos());
        }

        private void perfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrir(new Mantenimiento.MantPerfiles());
        }

        private void asignacionDeUsuarioAAplicacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrir(new Asignaciones.AsigAplicaUsuario());
        }

        private void asignacionDePerfilesAUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrir(new Asignaciones.AsigPerfUsuario());
        }

        private void asignacionDePerfilesAAplicacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrir(new Asignaciones.AsigAplicaPerfiles());
        }

        private void cambioDeContrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrir(new CambioContraseña());
        }

        private void bitacoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrir(new Bitacora());
        }

        private void asignacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void seguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login Lg = new Login();
            Lg.Show();
            this.Hide();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
        }

        private void ayudaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "ComponenteSeguridadAyuda/AyudaSeguridad.chm", "Ayuda.html");
            //Help.ShowHelp(this, "C:/Users/rayju/OneDrive/Escritorio/GitHub AnotherWork/proyectoads22023/Codigo/Componentes/Seguridad/Modulo_Seguridad/CapaVista/bin/Debug/ComponenteSeguridadAyuda/AyudaSeguridad.chm", "Ayuda.html");
        }

        private void mDIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "ComponenteSeguridadAyuda/AyudaSeguridad.chm", "MDI.html");
            //Help.ShowHelp(this, "C:/Users/rayju/OneDrive/Escritorio/GitHub AnotherWork/proyectoads22023/Codigo/Componentes/Seguridad/Modulo_Seguridad/CapaVista/bin/Debug/ComponenteSeguridadAyuda/AyudaSeguridad.chm", "Ayuda.html");
        }
    }
}
