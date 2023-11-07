
namespace CapaVistaComprasCXP.Procedimientos
{
    partial class BuscarOrdenCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarOrdenCompra));
            this.btn_seleccionar = new System.Windows.Forms.Button();
            this.dgv_orden = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_buscarOrden = new System.Windows.Forms.Button();
            this.txt_Orden = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orden)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_seleccionar
            // 
            this.btn_seleccionar.Location = new System.Drawing.Point(539, 33);
            this.btn_seleccionar.Name = "btn_seleccionar";
            this.btn_seleccionar.Size = new System.Drawing.Size(75, 23);
            this.btn_seleccionar.TabIndex = 39;
            this.btn_seleccionar.Text = "Seleccionar";
            this.btn_seleccionar.UseVisualStyleBackColor = true;
            this.btn_seleccionar.Click += new System.EventHandler(this.btn_seleccionar_Click);
            // 
            // dgv_orden
            // 
            this.dgv_orden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_orden.Location = new System.Drawing.Point(31, 81);
            this.dgv_orden.Name = "dgv_orden";
            this.dgv_orden.Size = new System.Drawing.Size(583, 150);
            this.dgv_orden.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "ID de la órden compra";
            // 
            // btn_buscarOrden
            // 
            this.btn_buscarOrden.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_buscarOrden.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_buscarOrden.BackgroundImage")));
            this.btn_buscarOrden.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscarOrden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscarOrden.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscarOrden.Image")));
            this.btn_buscarOrden.Location = new System.Drawing.Point(329, 34);
            this.btn_buscarOrden.Margin = new System.Windows.Forms.Padding(0);
            this.btn_buscarOrden.Name = "btn_buscarOrden";
            this.btn_buscarOrden.Size = new System.Drawing.Size(23, 20);
            this.btn_buscarOrden.TabIndex = 36;
            this.btn_buscarOrden.UseVisualStyleBackColor = false;
            this.btn_buscarOrden.Click += new System.EventHandler(this.btn_buscarOrden_Click);
            // 
            // txt_Orden
            // 
            this.txt_Orden.Location = new System.Drawing.Point(172, 34);
            this.txt_Orden.Name = "txt_Orden";
            this.txt_Orden.Size = new System.Drawing.Size(180, 20);
            this.txt_Orden.TabIndex = 35;
            // 
            // BuscarOrdenCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 260);
            this.Controls.Add(this.btn_seleccionar);
            this.Controls.Add(this.dgv_orden);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_buscarOrden);
            this.Controls.Add(this.txt_Orden);
            this.Name = "BuscarOrdenCompra";
            this.Text = "BuscarOrdenCompra";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orden)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_seleccionar;
        private System.Windows.Forms.DataGridView dgv_orden;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_buscarOrden;
        private System.Windows.Forms.TextBox txt_Orden;
    }
}