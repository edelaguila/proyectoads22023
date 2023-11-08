
namespace Vista_PrototipoMenu
{
    partial class Dato
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Dgv_Data_Docs = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Data_Docs)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(161)))), ((int)(((byte)(116)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(918, 459);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(219)))), ((int)(((byte)(200)))));
            this.panel2.Controls.Add(this.Dgv_Data_Docs);
            this.panel2.Location = new System.Drawing.Point(13, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(884, 432);
            this.panel2.TabIndex = 61;
            // 
            // Dgv_Data_Docs
            // 
            this.Dgv_Data_Docs.AllowUserToDeleteRows = false;
            this.Dgv_Data_Docs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_Data_Docs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Data_Docs.Location = new System.Drawing.Point(16, 20);
            this.Dgv_Data_Docs.Margin = new System.Windows.Forms.Padding(2);
            this.Dgv_Data_Docs.Name = "Dgv_Data_Docs";
            this.Dgv_Data_Docs.ReadOnly = true;
            this.Dgv_Data_Docs.RowTemplate.Height = 24;
            this.Dgv_Data_Docs.Size = new System.Drawing.Size(847, 382);
            this.Dgv_Data_Docs.TabIndex = 7;
            this.Dgv_Data_Docs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Data_Docs_CellContentClick);
            // 
            // Dato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 487);
            this.Controls.Add(this.panel1);
            this.Name = "Dato";
            this.Text = "Dato";
            this.Load += new System.EventHandler(this.Dato_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Data_Docs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView Dgv_Data_Docs;
    }
}