namespace Hoteleria
{
    partial class GestionHabitaciones
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionHabitaciones));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_empleados = new System.Windows.Forms.Label();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.combo = new System.Windows.Forms.ComboBox();
            this.combo2 = new System.Windows.Forms.ComboBox();
            this.comboEmpleados = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.comboClientes = new System.Windows.Forms.ComboBox();
            this.txt_id_empleado = new System.Windows.Forms.TextBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.txt_ideva = new System.Windows.Forms.TextBox();
            this.txt_estado = new System.Windows.Forms.TextBox();
            this.navegador1 = new CapaVista.Navegador();
            this.txt_id_cliente = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(406, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "CheckIn y CheckOut";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 451);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre Cliente";
            this.label2.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 386);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Numero Habitacion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Fecha";
            // 
            // lbl_empleados
            // 
            this.lbl_empleados.AutoSize = true;
            this.lbl_empleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_empleados.Location = new System.Drawing.Point(180, 451);
            this.lbl_empleados.Name = "lbl_empleados";
            this.lbl_empleados.Size = new System.Drawing.Size(62, 13);
            this.lbl_empleados.TabIndex = 12;
            this.lbl_empleados.Text = "Empleado";
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estado.Location = new System.Drawing.Point(22, 502);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(110, 13);
            this.lbl_estado.TabIndex = 15;
            this.lbl_estado.Text = "Estado de Calidad";
            // 
            // combo
            // 
            this.combo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.combo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.combo.FormattingEnabled = true;
            this.combo.Location = new System.Drawing.Point(183, 403);
            this.combo.Margin = new System.Windows.Forms.Padding(2);
            this.combo.Name = "combo";
            this.combo.Size = new System.Drawing.Size(143, 21);
            this.combo.TabIndex = 17;
            this.combo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // combo2
            // 
            this.combo2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.combo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combo2.FormattingEnabled = true;
            this.combo2.Location = new System.Drawing.Point(25, 402);
            this.combo2.Margin = new System.Windows.Forms.Padding(2);
            this.combo2.Name = "combo2";
            this.combo2.Size = new System.Drawing.Size(129, 21);
            this.combo2.TabIndex = 18;
            this.combo2.Tag = "in_id_habitacion";
            // 
            // comboEmpleados
            // 
            this.comboEmpleados.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboEmpleados.FormattingEnabled = true;
            this.comboEmpleados.Location = new System.Drawing.Point(182, 469);
            this.comboEmpleados.Margin = new System.Windows.Forms.Padding(2);
            this.comboEmpleados.Name = "comboEmpleados";
            this.comboEmpleados.Size = new System.Drawing.Size(143, 21);
            this.comboEmpleados.TabIndex = 19;
            this.comboEmpleados.SelectedIndexChanged += new System.EventHandler(this.comboEmpleados_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(180, 388);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Tipo de Habitacion";
            // 
            // fecha
            // 
            this.fecha.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaption;
            this.fecha.Location = new System.Drawing.Point(25, 338);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(129, 20);
            this.fecha.TabIndex = 22;
            this.fecha.Tag = "eva_fecha";
            this.fecha.Value = new System.DateTime(2023, 10, 24, 0, 0, 0, 0);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 185);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descripcion.Location = new System.Drawing.Point(378, 214);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(74, 13);
            this.lbl_descripcion.TabIndex = 6;
            this.lbl_descripcion.Text = "Descripcion";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_descripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_descripcion.Location = new System.Drawing.Point(381, 233);
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(290, 311);
            this.txt_descripcion.TabIndex = 23;
            this.txt_descripcion.Tag = "eva_descripcion";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(381, 146);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(66, 17);
            this.checkBox1.TabIndex = 24;
            this.checkBox1.Text = "CheckIn";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(468, 146);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(72, 17);
            this.checkBox2.TabIndex = 25;
            this.checkBox2.Text = "Checkout";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // comboClientes
            // 
            this.comboClientes.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboClientes.FormattingEnabled = true;
            this.comboClientes.Location = new System.Drawing.Point(25, 469);
            this.comboClientes.Margin = new System.Windows.Forms.Padding(2);
            this.comboClientes.Name = "comboClientes";
            this.comboClientes.Size = new System.Drawing.Size(129, 21);
            this.comboClientes.TabIndex = 28;
            this.comboClientes.Visible = false;
            // 
            // txt_id_empleado
            // 
            this.txt_id_empleado.Location = new System.Drawing.Point(224, 517);
            this.txt_id_empleado.Name = "txt_id_empleado";
            this.txt_id_empleado.Size = new System.Drawing.Size(30, 20);
            this.txt_id_empleado.TabIndex = 30;
            this.txt_id_empleado.Tag = "eva_id_empleado";
            this.txt_id_empleado.Visible = false;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(468, 182);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(65, 17);
            this.checkBox3.TabIndex = 32;
            this.checkBox3.Text = "Registro";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Checked = true;
            this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4.Location = new System.Drawing.Point(381, 182);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(79, 17);
            this.checkBox4.TabIndex = 31;
            this.checkBox4.Text = "Evaluacion";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // txt_ideva
            // 
            this.txt_ideva.Location = new System.Drawing.Point(185, 517);
            this.txt_ideva.Name = "txt_ideva";
            this.txt_ideva.Size = new System.Drawing.Size(28, 20);
            this.txt_ideva.TabIndex = 34;
            this.txt_ideva.Tag = "in_id_evaluacion";
            this.txt_ideva.Visible = false;
            // 
            // txt_estado
            // 
            this.txt_estado.Location = new System.Drawing.Point(25, 518);
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.Size = new System.Drawing.Size(129, 20);
            this.txt_estado.TabIndex = 35;
            this.txt_estado.Tag = "eva_estado_calidad";
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(25, 12);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(751, 78);
            this.navegador1.TabIndex = 33;
            // 
            // txt_id_cliente
            // 
            this.txt_id_cliente.Location = new System.Drawing.Point(260, 518);
            this.txt_id_cliente.Name = "txt_id_cliente";
            this.txt_id_cliente.Size = new System.Drawing.Size(28, 20);
            this.txt_id_cliente.TabIndex = 36;
            this.txt_id_cliente.Tag = "in_id_cliente";
            this.txt_id_cliente.Visible = false;
            // 
            // GestionHabitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 548);
            this.Controls.Add(this.txt_id_cliente);
            this.Controls.Add(this.txt_estado);
            this.Controls.Add(this.txt_ideva);
            this.Controls.Add(this.navegador1);
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
            this.Name = "GestionHabitaciones";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_empleados;
        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.ComboBox combo;
        private System.Windows.Forms.ComboBox combo2;
        private System.Windows.Forms.ComboBox comboEmpleados;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.ComboBox comboClientes;
        private System.Windows.Forms.TextBox txt_id_empleado;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private CapaVista.Navegador navegador1;
        private System.Windows.Forms.TextBox txt_ideva;
        private System.Windows.Forms.TextBox txt_estado;
        private System.Windows.Forms.TextBox txt_id_cliente;
    }
}

