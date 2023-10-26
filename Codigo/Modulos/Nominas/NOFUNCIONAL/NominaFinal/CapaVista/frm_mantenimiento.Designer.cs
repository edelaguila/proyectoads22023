namespace CapaVista
{
    partial class frm_mantenimiento
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
            this.txt_cargo_empleado = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_apellido_empleado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nombre_empleado = new System.Windows.Forms.TextBox();
            this.txt_id_empleado = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.navegador1 = new CapaVista.Navegador();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_cargo_empleado
            // 
            this.txt_cargo_empleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cargo_empleado.Location = new System.Drawing.Point(384, 273);
            this.txt_cargo_empleado.Name = "txt_cargo_empleado";
            this.txt_cargo_empleado.Size = new System.Drawing.Size(234, 34);
            this.txt_cargo_empleado.TabIndex = 87;
            this.txt_cargo_empleado.Tag = "cargo";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(785, 131);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(101, 34);
            this.btn_buscar.TabIndex = 85;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(132, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 30);
            this.label4.TabIndex = 83;
            this.label4.Text = "Apellido_Empleado";
            // 
            // txt_apellido_empleado
            // 
            this.txt_apellido_empleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apellido_empleado.Location = new System.Drawing.Point(384, 230);
            this.txt_apellido_empleado.Name = "txt_apellido_empleado";
            this.txt_apellido_empleado.Size = new System.Drawing.Size(234, 34);
            this.txt_apellido_empleado.TabIndex = 82;
            this.txt_apellido_empleado.Tag = "emp_apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(133, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 30);
            this.label3.TabIndex = 81;
            this.label3.Text = "Cargo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(133, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 30);
            this.label2.TabIndex = 80;
            this.label2.Text = "Nombre_Empleado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 30);
            this.label1.TabIndex = 79;
            this.label1.Text = "ID_Empleado";
            // 
            // txt_nombre_empleado
            // 
            this.txt_nombre_empleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_empleado.Location = new System.Drawing.Point(384, 178);
            this.txt_nombre_empleado.Name = "txt_nombre_empleado";
            this.txt_nombre_empleado.Size = new System.Drawing.Size(234, 34);
            this.txt_nombre_empleado.TabIndex = 78;
            this.txt_nombre_empleado.Tag = "emp_nombre";
            // 
            // txt_id_empleado
            // 
            this.txt_id_empleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_empleado.Location = new System.Drawing.Point(384, 127);
            this.txt_id_empleado.Name = "txt_id_empleado";
            this.txt_id_empleado.Size = new System.Drawing.Size(234, 34);
            this.txt_id_empleado.TabIndex = 77;
            this.txt_id_empleado.Tag = "Pk_id_empleado";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(129, 328);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(590, 153);
            this.dataGridView1.TabIndex = 88;
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(22, 11);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(989, 91);
            this.navegador1.TabIndex = 89;
            // 
            // frm_mantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 493);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_cargo_empleado);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_apellido_empleado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nombre_empleado);
            this.Controls.Add(this.txt_id_empleado);
            this.Name = "frm_mantenimiento";
            this.Text = "frm_mantenimiento";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_cargo_empleado;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_apellido_empleado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nombre_empleado;
        private System.Windows.Forms.TextBox txt_id_empleado;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Navegador navegador1;
    }
}