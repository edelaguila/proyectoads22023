
namespace Hoteleria
{
    partial class GestionHuespedes
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
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.lbl_nit = new System.Windows.Forms.Label();
            this.lbl_correo = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.txt_nit = new System.Windows.Forms.TextBox();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.dgv_huespedes = new System.Windows.Forms.DataGridView();
            this.navegador = new CapaVista.Navegador();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_huespedes)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(58, 169);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_nombre.TabIndex = 1;
            this.lbl_nombre.Text = "Nombre";
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Location = new System.Drawing.Point(58, 201);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(44, 13);
            this.lbl_apellido.TabIndex = 2;
            this.lbl_apellido.Text = "Apellido";
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.Location = new System.Drawing.Point(58, 234);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(49, 13);
            this.lbl_telefono.TabIndex = 3;
            this.lbl_telefono.Text = "Telefono";
            // 
            // lbl_nit
            // 
            this.lbl_nit.AutoSize = true;
            this.lbl_nit.Location = new System.Drawing.Point(58, 267);
            this.lbl_nit.Name = "lbl_nit";
            this.lbl_nit.Size = new System.Drawing.Size(25, 13);
            this.lbl_nit.TabIndex = 4;
            this.lbl_nit.Text = "NIT";
            // 
            // lbl_correo
            // 
            this.lbl_correo.AutoSize = true;
            this.lbl_correo.Location = new System.Drawing.Point(58, 293);
            this.lbl_correo.Name = "lbl_correo";
            this.lbl_correo.Size = new System.Drawing.Size(38, 13);
            this.lbl_correo.TabIndex = 5;
            this.lbl_correo.Text = "Correo";
            // 
            // txt_nombre
            // 
            this.txt_nombre.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_nombre.Location = new System.Drawing.Point(133, 162);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(314, 20);
            this.txt_nombre.TabIndex = 6;
            this.txt_nombre.Tag = "cli_nombre";
            // 
            // txt_apellido
            // 
            this.txt_apellido.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_apellido.Location = new System.Drawing.Point(133, 194);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(314, 20);
            this.txt_apellido.TabIndex = 7;
            this.txt_apellido.Tag = "cli_apellido";
            // 
            // txt_telefono
            // 
            this.txt_telefono.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_telefono.Location = new System.Drawing.Point(133, 227);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(314, 20);
            this.txt_telefono.TabIndex = 8;
            this.txt_telefono.Tag = "cli_telefono";
            // 
            // txt_nit
            // 
            this.txt_nit.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_nit.Location = new System.Drawing.Point(133, 260);
            this.txt_nit.Name = "txt_nit";
            this.txt_nit.Size = new System.Drawing.Size(314, 20);
            this.txt_nit.TabIndex = 9;
            this.txt_nit.Tag = "cli_nit";
            // 
            // txt_correo
            // 
            this.txt_correo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_correo.Location = new System.Drawing.Point(133, 290);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(314, 20);
            this.txt_correo.TabIndex = 10;
            this.txt_correo.Tag = "cli_correo";
            // 
            // dgv_huespedes
            // 
            this.dgv_huespedes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_huespedes.Location = new System.Drawing.Point(63, 327);
            this.dgv_huespedes.Name = "dgv_huespedes";
            this.dgv_huespedes.Size = new System.Drawing.Size(623, 150);
            this.dgv_huespedes.TabIndex = 11;
            // 
            // navegador
            // 
            this.navegador.Location = new System.Drawing.Point(23, 12);
            this.navegador.Name = "navegador";
            this.navegador.Size = new System.Drawing.Size(751, 78);
            this.navegador.TabIndex = 16;
            // 
            // GestionHuespedes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 491);
            this.Controls.Add(this.navegador);
            this.Controls.Add(this.dgv_huespedes);
            this.Controls.Add(this.txt_correo);
            this.Controls.Add(this.txt_nit);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_correo);
            this.Controls.Add(this.lbl_nit);
            this.Controls.Add(this.lbl_telefono);
            this.Controls.Add(this.lbl_apellido);
            this.Controls.Add(this.lbl_nombre);
            this.Name = "GestionHuespedes";
            this.Text = "Gestion_Huespedes";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_huespedes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.Label lbl_nit;
        private System.Windows.Forms.Label lbl_correo;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.TextBox txt_nit;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.DataGridView dgv_huespedes;
        private CapaVista.Navegador navegador;
    }
}