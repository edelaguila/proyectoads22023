
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
            this.nbr_usuario = new System.Windows.Forms.TextBox();
            this.nbr_nombre = new System.Windows.Forms.TextBox();
            this.nbr_apellido = new System.Windows.Forms.TextBox();
            this.nbr_correo = new System.Windows.Forms.TextBox();
            this.id_privilegio = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nbr_usuario
            // 
            this.nbr_usuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbr_usuario.Location = new System.Drawing.Point(622, 109);
            this.nbr_usuario.Name = "nbr_usuario";
            this.nbr_usuario.Size = new System.Drawing.Size(200, 32);
            this.nbr_usuario.TabIndex = 0;
            this.nbr_usuario.Tag = "usuario";
            // 
            // nbr_nombre
            // 
            this.nbr_nombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbr_nombre.Location = new System.Drawing.Point(622, 154);
            this.nbr_nombre.Name = "nbr_nombre";
            this.nbr_nombre.Size = new System.Drawing.Size(200, 32);
            this.nbr_nombre.TabIndex = 1;
            this.nbr_nombre.Tag = "nombre";
            // 
            // nbr_apellido
            // 
            this.nbr_apellido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbr_apellido.Location = new System.Drawing.Point(622, 195);
            this.nbr_apellido.Name = "nbr_apellido";
            this.nbr_apellido.Size = new System.Drawing.Size(200, 32);
            this.nbr_apellido.TabIndex = 2;
            this.nbr_apellido.Tag = "apellido";
            // 
            // nbr_correo
            // 
            this.nbr_correo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbr_correo.Location = new System.Drawing.Point(622, 238);
            this.nbr_correo.Name = "nbr_correo";
            this.nbr_correo.Size = new System.Drawing.Size(200, 32);
            this.nbr_correo.TabIndex = 3;
            this.nbr_correo.Tag = "correo";
            // 
            // id_privilegio
            // 
            this.id_privilegio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_privilegio.Location = new System.Drawing.Point(622, 280);
            this.id_privilegio.Name = "id_privilegio";
            this.id_privilegio.Size = new System.Drawing.Size(200, 32);
            this.id_privilegio.TabIndex = 4;
            this.id_privilegio.Tag = "id_privilegio";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(632, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 42);
            this.button1.TabIndex = 5;
            this.button1.Text = "REGISTRAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(958, 524);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.id_privilegio);
            this.Controls.Add(this.nbr_correo);
            this.Controls.Add(this.nbr_apellido);
            this.Controls.Add(this.nbr_nombre);
            this.Controls.Add(this.nbr_usuario);
            this.Name = "Registro";
            this.Text = "Registro";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nbr_usuario;
        private System.Windows.Forms.TextBox nbr_nombre;
        private System.Windows.Forms.TextBox nbr_apellido;
        private System.Windows.Forms.TextBox nbr_correo;
        private System.Windows.Forms.TextBox id_privilegio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
    }
}