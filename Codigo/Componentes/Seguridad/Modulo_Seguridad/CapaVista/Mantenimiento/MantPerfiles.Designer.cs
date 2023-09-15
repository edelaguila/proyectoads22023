
namespace CapaVista.Mantenimiento
{
    partial class MantPerfiles
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
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_ingresar = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.gpb_datos = new System.Windows.Forms.GroupBox();
            this.gpb_estado = new System.Windows.Forms.GroupBox();
            this.rb_inhabilitado = new System.Windows.Forms.RadioButton();
            this.rb_habilitado = new System.Windows.Forms.RadioButton();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.gpb_modificar = new System.Windows.Forms.GroupBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_busqueda = new System.Windows.Forms.TextBox();
            this.lbl_buscar = new System.Windows.Forms.Label();
            this.gpb_datos.SuspendLayout();
            this.gpb_estado.SuspendLayout();
            this.gpb_modificar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(655, 382);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(93, 30);
            this.btn_salir.TabIndex = 35;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(655, 331);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(93, 30);
            this.btn_eliminar.TabIndex = 34;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(655, 280);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(93, 30);
            this.btn_modificar.TabIndex = 33;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Location = new System.Drawing.Point(655, 229);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(93, 30);
            this.btn_actualizar.TabIndex = 32;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.Location = new System.Drawing.Point(655, 178);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(93, 30);
            this.btn_ingresar.TabIndex = 31;
            this.btn_ingresar.Text = "Ingresar";
            this.btn_ingresar.UseVisualStyleBackColor = true;
            this.btn_ingresar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Location = new System.Drawing.Point(655, 127);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(93, 30);
            this.btn_nuevo.TabIndex = 30;
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.UseVisualStyleBackColor = true;
            // 
            // gpb_datos
            // 
            this.gpb_datos.Controls.Add(this.gpb_estado);
            this.gpb_datos.Controls.Add(this.txt_descripcion);
            this.gpb_datos.Controls.Add(this.txt_nombre);
            this.gpb_datos.Controls.Add(this.lbl_descripcion);
            this.gpb_datos.Controls.Add(this.lbl_nombre);
            this.gpb_datos.Controls.Add(this.txt_codigo);
            this.gpb_datos.Controls.Add(this.lbl_codigo);
            this.gpb_datos.Location = new System.Drawing.Point(12, 127);
            this.gpb_datos.Name = "gpb_datos";
            this.gpb_datos.Size = new System.Drawing.Size(605, 382);
            this.gpb_datos.TabIndex = 29;
            this.gpb_datos.TabStop = false;
            this.gpb_datos.Text = "Datos";
            // 
            // gpb_estado
            // 
            this.gpb_estado.Controls.Add(this.rb_inhabilitado);
            this.gpb_estado.Controls.Add(this.rb_habilitado);
            this.gpb_estado.Location = new System.Drawing.Point(9, 246);
            this.gpb_estado.Name = "gpb_estado";
            this.gpb_estado.Size = new System.Drawing.Size(590, 86);
            this.gpb_estado.TabIndex = 20;
            this.gpb_estado.TabStop = false;
            this.gpb_estado.Text = "Estado";
            // 
            // rb_inhabilitado
            // 
            this.rb_inhabilitado.AutoSize = true;
            this.rb_inhabilitado.Location = new System.Drawing.Point(322, 46);
            this.rb_inhabilitado.Name = "rb_inhabilitado";
            this.rb_inhabilitado.Size = new System.Drawing.Size(79, 17);
            this.rb_inhabilitado.TabIndex = 1;
            this.rb_inhabilitado.Text = "Inhabilitado";
            this.rb_inhabilitado.UseVisualStyleBackColor = true;
            // 
            // rb_habilitado
            // 
            this.rb_habilitado.AutoSize = true;
            this.rb_habilitado.Location = new System.Drawing.Point(204, 46);
            this.rb_habilitado.Name = "rb_habilitado";
            this.rb_habilitado.Size = new System.Drawing.Size(72, 17);
            this.rb_habilitado.TabIndex = 0;
            this.rb_habilitado.Text = "Habilitado";
            this.rb_habilitado.UseVisualStyleBackColor = true;
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(159, 137);
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(347, 50);
            this.txt_descripcion.TabIndex = 10;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(159, 90);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(347, 20);
            this.txt_nombre.TabIndex = 9;
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.Location = new System.Drawing.Point(6, 140);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(63, 13);
            this.lbl_descripcion.TabIndex = 6;
            this.lbl_descripcion.Text = "Descripcion";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(6, 93);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_nombre.TabIndex = 4;
            this.lbl_nombre.Text = "Nombre";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(159, 45);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(347, 20);
            this.txt_codigo.TabIndex = 3;
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Location = new System.Drawing.Point(6, 48);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(66, 13);
            this.lbl_codigo.TabIndex = 0;
            this.lbl_codigo.Text = "Codigo Perfil";
            // 
            // gpb_modificar
            // 
            this.gpb_modificar.Controls.Add(this.btn_buscar);
            this.gpb_modificar.Controls.Add(this.txt_busqueda);
            this.gpb_modificar.Controls.Add(this.lbl_buscar);
            this.gpb_modificar.Location = new System.Drawing.Point(12, 12);
            this.gpb_modificar.Name = "gpb_modificar";
            this.gpb_modificar.Size = new System.Drawing.Size(736, 82);
            this.gpb_modificar.TabIndex = 28;
            this.gpb_modificar.TabStop = false;
            this.gpb_modificar.Text = "Modificar";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(512, 19);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(93, 45);
            this.btn_buscar.TabIndex = 2;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_busqueda
            // 
            this.txt_busqueda.Location = new System.Drawing.Point(132, 30);
            this.txt_busqueda.Name = "txt_busqueda";
            this.txt_busqueda.Size = new System.Drawing.Size(374, 20);
            this.txt_busqueda.TabIndex = 1;
            // 
            // lbl_buscar
            // 
            this.lbl_buscar.AutoSize = true;
            this.lbl_buscar.Location = new System.Drawing.Point(75, 33);
            this.lbl_buscar.Name = "lbl_buscar";
            this.lbl_buscar.Size = new System.Drawing.Size(51, 13);
            this.lbl_buscar.TabIndex = 0;
            this.lbl_buscar.Text = "Buscar id";
            // 
            // MantPerfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 527);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.btn_ingresar);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.gpb_datos);
            this.Controls.Add(this.gpb_modificar);
            this.Name = "MantPerfiles";
            this.Text = "MantPerfiles";
            this.gpb_datos.ResumeLayout(false);
            this.gpb_datos.PerformLayout();
            this.gpb_estado.ResumeLayout(false);
            this.gpb_estado.PerformLayout();
            this.gpb_modificar.ResumeLayout(false);
            this.gpb_modificar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Button btn_ingresar;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.GroupBox gpb_datos;
        private System.Windows.Forms.GroupBox gpb_estado;
        private System.Windows.Forms.RadioButton rb_inhabilitado;
        private System.Windows.Forms.RadioButton rb_habilitado;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.GroupBox gpb_modificar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_busqueda;
        private System.Windows.Forms.Label lbl_buscar;
    }
}