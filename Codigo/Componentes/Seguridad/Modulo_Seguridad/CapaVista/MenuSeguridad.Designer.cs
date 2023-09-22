﻿
namespace CapaVista
{
    partial class MenuSeguridad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aplicacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignacionDeUsuarioAAplicacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignacionDePerfilesAUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignacionDePerfilesAAplicacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambioDeContrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bitacoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mDIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1644, 754);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seguridadToolStripMenuItem,
            this.mantenimientoToolStripMenuItem,
            this.asignacionesToolStripMenuItem,
            this.cambioDeContrToolStripMenuItem,
            this.bitacoraToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1644, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.seguridadToolStripMenuItem.Text = "Inicio";
            this.seguridadToolStripMenuItem.Click += new System.EventHandler(this.seguridadToolStripMenuItem_Click);
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.aplicacionesToolStripMenuItem,
            this.modulosToolStripMenuItem,
            this.perfilesToolStripMenuItem});
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // aplicacionesToolStripMenuItem
            // 
            this.aplicacionesToolStripMenuItem.Name = "aplicacionesToolStripMenuItem";
            this.aplicacionesToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.aplicacionesToolStripMenuItem.Text = "Aplicaciones";
            this.aplicacionesToolStripMenuItem.Click += new System.EventHandler(this.aplicacionesToolStripMenuItem_Click);
            // 
            // modulosToolStripMenuItem
            // 
            this.modulosToolStripMenuItem.Name = "modulosToolStripMenuItem";
            this.modulosToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.modulosToolStripMenuItem.Text = "Modulos";
            this.modulosToolStripMenuItem.Click += new System.EventHandler(this.modulosToolStripMenuItem_Click);
            // 
            // perfilesToolStripMenuItem
            // 
            this.perfilesToolStripMenuItem.Name = "perfilesToolStripMenuItem";
            this.perfilesToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.perfilesToolStripMenuItem.Text = "Perfiles";
            this.perfilesToolStripMenuItem.Click += new System.EventHandler(this.perfilesToolStripMenuItem_Click);
            // 
            // asignacionesToolStripMenuItem
            // 
            this.asignacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asignacionDeUsuarioAAplicacionesToolStripMenuItem,
            this.asignacionDePerfilesAUsuariosToolStripMenuItem,
            this.asignacionDePerfilesAAplicacionesToolStripMenuItem});
            this.asignacionesToolStripMenuItem.Name = "asignacionesToolStripMenuItem";
            this.asignacionesToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.asignacionesToolStripMenuItem.Text = "Procesos";
            this.asignacionesToolStripMenuItem.Click += new System.EventHandler(this.asignacionesToolStripMenuItem_Click);
            // 
            // asignacionDeUsuarioAAplicacionesToolStripMenuItem
            // 
            this.asignacionDeUsuarioAAplicacionesToolStripMenuItem.Name = "asignacionDeUsuarioAAplicacionesToolStripMenuItem";
            this.asignacionDeUsuarioAAplicacionesToolStripMenuItem.Size = new System.Drawing.Size(346, 26);
            this.asignacionDeUsuarioAAplicacionesToolStripMenuItem.Text = "Asignacion de Aplicaciones a Usuarios";
            this.asignacionDeUsuarioAAplicacionesToolStripMenuItem.Click += new System.EventHandler(this.asignacionDeUsuarioAAplicacionesToolStripMenuItem_Click);
            // 
            // asignacionDePerfilesAUsuariosToolStripMenuItem
            // 
            this.asignacionDePerfilesAUsuariosToolStripMenuItem.Name = "asignacionDePerfilesAUsuariosToolStripMenuItem";
            this.asignacionDePerfilesAUsuariosToolStripMenuItem.Size = new System.Drawing.Size(346, 26);
            this.asignacionDePerfilesAUsuariosToolStripMenuItem.Text = "Asignacion de Perfiles a Usuarios";
            this.asignacionDePerfilesAUsuariosToolStripMenuItem.Click += new System.EventHandler(this.asignacionDePerfilesAUsuariosToolStripMenuItem_Click);
            // 
            // asignacionDePerfilesAAplicacionesToolStripMenuItem
            // 
            this.asignacionDePerfilesAAplicacionesToolStripMenuItem.Name = "asignacionDePerfilesAAplicacionesToolStripMenuItem";
            this.asignacionDePerfilesAAplicacionesToolStripMenuItem.Size = new System.Drawing.Size(346, 26);
            this.asignacionDePerfilesAAplicacionesToolStripMenuItem.Text = "Asignacion de Aplicaciones a Perfiles";
            this.asignacionDePerfilesAAplicacionesToolStripMenuItem.Click += new System.EventHandler(this.asignacionDePerfilesAAplicacionesToolStripMenuItem_Click);
            // 
            // cambioDeContrToolStripMenuItem
            // 
            this.cambioDeContrToolStripMenuItem.Name = "cambioDeContrToolStripMenuItem";
            this.cambioDeContrToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.cambioDeContrToolStripMenuItem.Text = "Seguridad";
            this.cambioDeContrToolStripMenuItem.Click += new System.EventHandler(this.cambioDeContrToolStripMenuItem_Click);
            // 
            // bitacoraToolStripMenuItem
            // 
            this.bitacoraToolStripMenuItem.Name = "bitacoraToolStripMenuItem";
            this.bitacoraToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.bitacoraToolStripMenuItem.Text = "Reportes";
            this.bitacoraToolStripMenuItem.Click += new System.EventHandler(this.bitacoraToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayudaToolStripMenuItem1,
            this.mDIToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.ayudaToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem1
            // 
            this.ayudaToolStripMenuItem1.Name = "ayudaToolStripMenuItem1";
            this.ayudaToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.ayudaToolStripMenuItem1.Text = "Ayuda";
            this.ayudaToolStripMenuItem1.Click += new System.EventHandler(this.ayudaToolStripMenuItem1_Click);
            // 
            // mDIToolStripMenuItem
            // 
            this.mDIToolStripMenuItem.Name = "mDIToolStripMenuItem";
            this.mDIToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.mDIToolStripMenuItem.Text = "MDI";
            this.mDIToolStripMenuItem.Click += new System.EventHandler(this.mDIToolStripMenuItem_Click);
            // 
            // MenuSeguridad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1644, 782);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MenuSeguridad";
            this.Text = "Consulta";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aplicacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perfilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignacionDeUsuarioAAplicacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignacionDePerfilesAUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignacionDePerfilesAAplicacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambioDeContrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bitacoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mDIToolStripMenuItem;
    }
}