
namespace CapaVista
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.pn_contenedor = new System.Windows.Forms.Panel();
            this.bt_save_user = new System.Windows.Forms.Button();
            this.id_privilegio = new System.Windows.Forms.TextBox();
            this.nbr_correo = new System.Windows.Forms.TextBox();
            this.nbr_apellido = new System.Windows.Forms.TextBox();
            this.nbr_nombre = new System.Windows.Forms.TextBox();
            this.nbr_usuario = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.pn_contenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(-12, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(594, 530);
            this.panel1.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(12, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(582, 540);
            this.button2.TabIndex = 0;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // pn_contenedor
            // 
            this.pn_contenedor.Controls.Add(this.bt_save_user);
            this.pn_contenedor.Controls.Add(this.id_privilegio);
            this.pn_contenedor.Controls.Add(this.nbr_correo);
            this.pn_contenedor.Controls.Add(this.nbr_apellido);
            this.pn_contenedor.Controls.Add(this.nbr_nombre);
            this.pn_contenedor.Controls.Add(this.nbr_usuario);
            this.pn_contenedor.Location = new System.Drawing.Point(635, 41);
            this.pn_contenedor.Name = "pn_contenedor";
            this.pn_contenedor.Size = new System.Drawing.Size(289, 408);
            this.pn_contenedor.TabIndex = 8;
            // 
            // bt_save_user
            // 
            this.bt_save_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_save_user.Location = new System.Drawing.Point(68, 314);
            this.bt_save_user.Name = "bt_save_user";
            this.bt_save_user.Size = new System.Drawing.Size(173, 42);
            this.bt_save_user.TabIndex = 13;
            this.bt_save_user.Text = "REGISTRAR";
            this.bt_save_user.UseVisualStyleBackColor = true;
            this.bt_save_user.Click += new System.EventHandler(this.bt_save_user_Click_1);
            // 
            // id_privilegio
            // 
            this.id_privilegio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_privilegio.Location = new System.Drawing.Point(41, 247);
            this.id_privilegio.Name = "id_privilegio";
            this.id_privilegio.Size = new System.Drawing.Size(200, 32);
            this.id_privilegio.TabIndex = 12;
            this.id_privilegio.Tag = "id_privilegio";
            // 
            // nbr_correo
            // 
            this.nbr_correo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbr_correo.Location = new System.Drawing.Point(41, 205);
            this.nbr_correo.Name = "nbr_correo";
            this.nbr_correo.Size = new System.Drawing.Size(200, 32);
            this.nbr_correo.TabIndex = 11;
            this.nbr_correo.Tag = "correo";
            // 
            // nbr_apellido
            // 
            this.nbr_apellido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbr_apellido.Location = new System.Drawing.Point(41, 162);
            this.nbr_apellido.Name = "nbr_apellido";
            this.nbr_apellido.Size = new System.Drawing.Size(200, 32);
            this.nbr_apellido.TabIndex = 10;
            this.nbr_apellido.Tag = "apellido";
            // 
            // nbr_nombre
            // 
            this.nbr_nombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbr_nombre.Location = new System.Drawing.Point(41, 121);
            this.nbr_nombre.Name = "nbr_nombre";
            this.nbr_nombre.Size = new System.Drawing.Size(200, 32);
            this.nbr_nombre.TabIndex = 9;
            this.nbr_nombre.Tag = "nombre";
            // 
            // nbr_usuario
            // 
            this.nbr_usuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbr_usuario.Location = new System.Drawing.Point(41, 76);
            this.nbr_usuario.Name = "nbr_usuario";
            this.nbr_usuario.Size = new System.Drawing.Size(200, 32);
            this.nbr_usuario.TabIndex = 8;
            this.nbr_usuario.Tag = "usuario";
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(974, 540);
            this.Controls.Add(this.pn_contenedor);
            this.Controls.Add(this.panel1);
            this.Name = "Registro";
            this.Tag = "fRegistro";
            this.Text = "Registro";
            this.panel1.ResumeLayout(false);
            this.pn_contenedor.ResumeLayout(false);
            this.pn_contenedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel pn_contenedor;
        private System.Windows.Forms.Button bt_save_user;
        private System.Windows.Forms.TextBox id_privilegio;
        private System.Windows.Forms.TextBox nbr_correo;
        private System.Windows.Forms.TextBox nbr_apellido;
        private System.Windows.Forms.TextBox nbr_nombre;
        private System.Windows.Forms.TextBox nbr_usuario;
    }
}