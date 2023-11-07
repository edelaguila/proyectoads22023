
namespace Vista_PrototipoMenu
{
    partial class frmChequeo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChequeo));
            this.txt_id_cliente = new System.Windows.Forms.TextBox();
            this.txt_estado = new System.Windows.Forms.TextBox();
            this.txt_ideva = new System.Windows.Forms.TextBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.txt_id_empleado = new System.Windows.Forms.TextBox();
            this.comboClientes = new System.Windows.Forms.ComboBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.comboEmpleados = new System.Windows.Forms.ComboBox();
            this.combo2 = new System.Windows.Forms.ComboBox();
            this.combo = new System.Windows.Forms.ComboBox();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.lbl_empleados = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_id_cliente
            // 
            this.txt_id_cliente.Location = new System.Drawing.Point(314, 412);
            this.txt_id_cliente.Name = "txt_id_cliente";
            this.txt_id_cliente.Size = new System.Drawing.Size(28, 20);
            this.txt_id_cliente.TabIndex = 59;
            this.txt_id_cliente.Tag = "in_id_cliente";
            this.txt_id_cliente.Visible = false;
            // 
            // txt_estado
            // 
            this.txt_estado.Location = new System.Drawing.Point(79, 412);
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.Size = new System.Drawing.Size(129, 20);
            this.txt_estado.TabIndex = 58;
            this.txt_estado.Tag = "eva_estado_calidad";
            // 
            // txt_ideva
            // 
            this.txt_ideva.Location = new System.Drawing.Point(239, 411);
            this.txt_ideva.Name = "txt_ideva";
            this.txt_ideva.Size = new System.Drawing.Size(28, 20);
            this.txt_ideva.TabIndex = 57;
            this.txt_ideva.Tag = "in_id_evaluacion";
            this.txt_ideva.Visible = false;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(522, 76);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(65, 17);
            this.checkBox3.TabIndex = 56;
            this.checkBox3.Text = "Registro";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Checked = true;
            this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4.Location = new System.Drawing.Point(435, 76);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(79, 17);
            this.checkBox4.TabIndex = 55;
            this.checkBox4.Text = "Evaluacion";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // txt_id_empleado
            // 
            this.txt_id_empleado.Location = new System.Drawing.Point(278, 411);
            this.txt_id_empleado.Name = "txt_id_empleado";
            this.txt_id_empleado.Size = new System.Drawing.Size(30, 20);
            this.txt_id_empleado.TabIndex = 54;
            this.txt_id_empleado.Tag = "eva_id_empleado";
            this.txt_id_empleado.Visible = false;
            // 
            // comboClientes
            // 
            this.comboClientes.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboClientes.FormattingEnabled = true;
            this.comboClientes.Location = new System.Drawing.Point(79, 363);
            this.comboClientes.Margin = new System.Windows.Forms.Padding(2);
            this.comboClientes.Name = "comboClientes";
            this.comboClientes.Size = new System.Drawing.Size(129, 21);
            this.comboClientes.TabIndex = 53;
            this.comboClientes.Visible = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(522, 40);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(72, 17);
            this.checkBox2.TabIndex = 52;
            this.checkBox2.Text = "Checkout";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(435, 40);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(66, 17);
            this.checkBox1.TabIndex = 51;
            this.checkBox1.Text = "CheckIn";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_descripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_descripcion.Location = new System.Drawing.Point(435, 127);
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(290, 311);
            this.txt_descripcion.TabIndex = 50;
            this.txt_descripcion.Tag = "eva_descripcion";
            // 
            // fecha
            // 
            this.fecha.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaption;
            this.fecha.Location = new System.Drawing.Point(79, 232);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(129, 20);
            this.fecha.TabIndex = 49;
            this.fecha.Tag = "eva_fecha";
            this.fecha.Value = new System.DateTime(2023, 10, 24, 0, 0, 0, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(234, 282);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 13);
            this.label9.TabIndex = 48;
            this.label9.Text = "Tipo de Habitacion";
            // 
            // comboEmpleados
            // 
            this.comboEmpleados.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboEmpleados.FormattingEnabled = true;
            this.comboEmpleados.Location = new System.Drawing.Point(236, 363);
            this.comboEmpleados.Margin = new System.Windows.Forms.Padding(2);
            this.comboEmpleados.Name = "comboEmpleados";
            this.comboEmpleados.Size = new System.Drawing.Size(143, 21);
            this.comboEmpleados.TabIndex = 47;
            // 
            // combo2
            // 
            this.combo2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.combo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combo2.FormattingEnabled = true;
            this.combo2.Location = new System.Drawing.Point(79, 296);
            this.combo2.Margin = new System.Windows.Forms.Padding(2);
            this.combo2.Name = "combo2";
            this.combo2.Size = new System.Drawing.Size(129, 21);
            this.combo2.TabIndex = 46;
            this.combo2.Tag = "in_id_habitacion";
            // 
            // combo
            // 
            this.combo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.combo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.combo.FormattingEnabled = true;
            this.combo.Location = new System.Drawing.Point(237, 297);
            this.combo.Margin = new System.Windows.Forms.Padding(2);
            this.combo.Name = "combo";
            this.combo.Size = new System.Drawing.Size(143, 21);
            this.combo.TabIndex = 45;
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estado.Location = new System.Drawing.Point(76, 396);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(110, 13);
            this.lbl_estado.TabIndex = 44;
            this.lbl_estado.Text = "Estado de Calidad";
            // 
            // lbl_empleados
            // 
            this.lbl_empleados.AutoSize = true;
            this.lbl_empleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_empleados.Location = new System.Drawing.Point(234, 345);
            this.lbl_empleados.Name = "lbl_empleados";
            this.lbl_empleados.Size = new System.Drawing.Size(62, 13);
            this.lbl_empleados.TabIndex = 43;
            this.lbl_empleados.Text = "Empleado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(76, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Fecha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(76, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Numero Habitacion";
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descripcion.Location = new System.Drawing.Point(432, 108);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(74, 13);
            this.lbl_descripcion.TabIndex = 40;
            this.lbl_descripcion.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Nombre Cliente";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(460, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 25);
            this.label1.TabIndex = 38;
            this.label1.Text = "CheckIn y CheckOut";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(79, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 185);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // frmChequeo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_id_cliente);
            this.Controls.Add(this.txt_estado);
            this.Controls.Add(this.txt_ideva);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.txt_id_empleado);
            this.Controls.Add(this.comboClientes);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboEmpleados);
            this.Controls.Add(this.combo2);
            this.Controls.Add(this.combo);
            this.Controls.Add(this.lbl_estado);
            this.Controls.Add(this.lbl_empleados);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_descripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmChequeo";
            this.Text = "frmChequeo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_id_cliente;
        private System.Windows.Forms.TextBox txt_estado;
        private System.Windows.Forms.TextBox txt_ideva;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.TextBox txt_id_empleado;
        private System.Windows.Forms.ComboBox comboClientes;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboEmpleados;
        private System.Windows.Forms.ComboBox combo2;
        private System.Windows.Forms.ComboBox combo;
        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.Label lbl_empleados;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}