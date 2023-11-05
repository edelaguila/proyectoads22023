
namespace Vista_PrototipoMenu
{
    partial class frmGestionHuespedes
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
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this._navegador = new NavegadorVista.Navegador();
            this.txt_nit = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(625, 220);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(100, 20);
            this.txt_telefono.TabIndex = 14;
            this.txt_telefono.Tag = "cli_telefono";
            // 
            // txt_correo
            // 
            this.txt_correo.Location = new System.Drawing.Point(500, 220);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(100, 20);
            this.txt_correo.TabIndex = 13;
            this.txt_correo.Tag = "cli_correo";
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(369, 220);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(100, 20);
            this.txt_apellido.TabIndex = 12;
            this.txt_apellido.Tag = "cli_apellido";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(230, 220);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre.TabIndex = 11;
            this.txt_nombre.Tag = "cli_nombre";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(97, 220);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 20);
            this.txt_id.TabIndex = 10;
            this.txt_id.Tag = "cli_id";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(97, 332);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(703, 132);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.Tag = "tbl_cliente";
            // 
            // _navegador
            // 
            this._navegador.Location = new System.Drawing.Point(117, 27);
            this._navegador.Name = "_navegador";
            this._navegador.Size = new System.Drawing.Size(574, 152);
            this._navegador.TabIndex = 15;
            // 
            // txt_nit
            // 
            this.txt_nit.Location = new System.Drawing.Point(749, 220);
            this.txt_nit.Name = "txt_nit";
            this.txt_nit.Size = new System.Drawing.Size(100, 20);
            this.txt_nit.TabIndex = 16;
            this.txt_nit.Tag = "cli_nit";
            // 
            // frmGestionHuespedes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 512);
            this.Controls.Add(this.txt_nit);
            this.Controls.Add(this._navegador);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.txt_correo);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmGestionHuespedes";
            this.Text = "frmGestionHuespedes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.DataGridView dataGridView1;
        private NavegadorVista.Navegador _navegador;
        private System.Windows.Forms.TextBox txt_nit;
    }
}