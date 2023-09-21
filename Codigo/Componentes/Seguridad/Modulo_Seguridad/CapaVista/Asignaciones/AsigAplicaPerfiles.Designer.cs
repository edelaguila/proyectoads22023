
namespace CapaVista.Asignaciones
{
    partial class AsigAplicaPerfiles
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_columna_Perfiles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_columna_Aplicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_columna_Ingresar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgv_columna_Consultar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgv_columna_Modificar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgv_columna_Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgv_columna_Imprimir = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(822, 443);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(822, 414);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Finalizar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_columna_Perfiles,
            this.dgv_columna_Aplicacion,
            this.dgv_columna_Ingresar,
            this.dgv_columna_Consultar,
            this.dgv_columna_Modificar,
            this.dgv_columna_Eliminar,
            this.dgv_columna_Imprimir});
            this.dataGridView1.Location = new System.Drawing.Point(13, 196);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(803, 270);
            this.dataGridView1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(890, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "ASIGNACION DE APLICACIONES A PERFILES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBox1.Location = new System.Drawing.Point(12, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(804, 114);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(714, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(488, 67);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(168, 21);
            this.comboBox3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(535, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Aplicaciones";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(257, 67);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(196, 21);
            this.comboBox2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Modulos";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(25, 67);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Perfiles";
            // 
            // dgv_columna_Perfiles
            // 
            this.dgv_columna_Perfiles.HeaderText = "Perfiles";
            this.dgv_columna_Perfiles.MinimumWidth = 6;
            this.dgv_columna_Perfiles.Name = "dgv_columna_Perfiles";
            this.dgv_columna_Perfiles.Width = 125;
            // 
            // dgv_columna_Aplicacion
            // 
            this.dgv_columna_Aplicacion.HeaderText = "Aplicacion";
            this.dgv_columna_Aplicacion.MinimumWidth = 6;
            this.dgv_columna_Aplicacion.Name = "dgv_columna_Aplicacion";
            this.dgv_columna_Aplicacion.Width = 125;
            // 
            // dgv_columna_Ingresar
            // 
            this.dgv_columna_Ingresar.HeaderText = "Ingresar";
            this.dgv_columna_Ingresar.MinimumWidth = 6;
            this.dgv_columna_Ingresar.Name = "dgv_columna_Ingresar";
            this.dgv_columna_Ingresar.Width = 125;
            // 
            // dgv_columna_Consultar
            // 
            this.dgv_columna_Consultar.HeaderText = "Consultar";
            this.dgv_columna_Consultar.MinimumWidth = 6;
            this.dgv_columna_Consultar.Name = "dgv_columna_Consultar";
            this.dgv_columna_Consultar.Width = 125;
            // 
            // dgv_columna_Modificar
            // 
            this.dgv_columna_Modificar.HeaderText = "Modificar";
            this.dgv_columna_Modificar.MinimumWidth = 6;
            this.dgv_columna_Modificar.Name = "dgv_columna_Modificar";
            this.dgv_columna_Modificar.Width = 125;
            // 
            // dgv_columna_Eliminar
            // 
            this.dgv_columna_Eliminar.HeaderText = "Eliminar";
            this.dgv_columna_Eliminar.MinimumWidth = 6;
            this.dgv_columna_Eliminar.Name = "dgv_columna_Eliminar";
            this.dgv_columna_Eliminar.Width = 125;
            // 
            // dgv_columna_Imprimir
            // 
            this.dgv_columna_Imprimir.HeaderText = "Imprimir";
            this.dgv_columna_Imprimir.MinimumWidth = 6;
            this.dgv_columna_Imprimir.Name = "dgv_columna_Imprimir";
            this.dgv_columna_Imprimir.Width = 125;
            // 
            // AsigAplicaPerfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 479);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "AsigAplicaPerfiles";
            this.Text = "AsigAplicaPerfiles";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_columna_Perfiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_columna_Aplicacion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgv_columna_Ingresar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgv_columna_Consultar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgv_columna_Modificar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgv_columna_Eliminar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgv_columna_Imprimir;
    }
}