﻿
namespace CapaVistaComprasCXP.Procedimientos
{
    partial class BuscarProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarProveedor));
            this.btn_seleccionar = new System.Windows.Forms.Button();
            this.dgv_proveedores = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_buscarProveedor = new System.Windows.Forms.Button();
            this.txt_Prov = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_proveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_seleccionar
            // 
            this.btn_seleccionar.Location = new System.Drawing.Point(390, 25);
            this.btn_seleccionar.Name = "btn_seleccionar";
            this.btn_seleccionar.Size = new System.Drawing.Size(75, 23);
            this.btn_seleccionar.TabIndex = 34;
            this.btn_seleccionar.Text = "Seleccionar";
            this.btn_seleccionar.UseVisualStyleBackColor = true;
            this.btn_seleccionar.Click += new System.EventHandler(this.btn_seleccionar_Click);
            // 
            // dgv_proveedores
            // 
            this.dgv_proveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_proveedores.Location = new System.Drawing.Point(37, 75);
            this.dgv_proveedores.Name = "dgv_proveedores";
            this.dgv_proveedores.Size = new System.Drawing.Size(428, 150);
            this.dgv_proveedores.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Nombre Proveedor";
            // 
            // btn_buscarProveedor
            // 
            this.btn_buscarProveedor.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_buscarProveedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_buscarProveedor.BackgroundImage")));
            this.btn_buscarProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscarProveedor.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscarProveedor.Image")));
            this.btn_buscarProveedor.Location = new System.Drawing.Point(311, 27);
            this.btn_buscarProveedor.Margin = new System.Windows.Forms.Padding(0);
            this.btn_buscarProveedor.Name = "btn_buscarProveedor";
            this.btn_buscarProveedor.Size = new System.Drawing.Size(23, 20);
            this.btn_buscarProveedor.TabIndex = 31;
            this.btn_buscarProveedor.UseVisualStyleBackColor = false;
            this.btn_buscarProveedor.Click += new System.EventHandler(this.btn_buscarProveedor_Click);
            // 
            // txt_Prov
            // 
            this.txt_Prov.Location = new System.Drawing.Point(154, 27);
            this.txt_Prov.Name = "txt_Prov";
            this.txt_Prov.Size = new System.Drawing.Size(180, 20);
            this.txt_Prov.TabIndex = 30;
            // 
            // BuscarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 248);
            this.Controls.Add(this.btn_seleccionar);
            this.Controls.Add(this.dgv_proveedores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_buscarProveedor);
            this.Controls.Add(this.txt_Prov);
            this.Name = "BuscarProveedor";
            this.Text = "BuscarProveedor";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_proveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_seleccionar;
        private System.Windows.Forms.DataGridView dgv_proveedores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_buscarProveedor;
        private System.Windows.Forms.TextBox txt_Prov;
    }
}