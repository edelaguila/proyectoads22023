
namespace CapaVista
{
    partial class MDIParent1
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
            this.components = new System.ComponentModel.Container();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.percepcionesYDeduccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liquidacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.mantenimientoToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1097, 31);
            this.menuStrip1.TabIndex = 76;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.percepcionesYDeduccionesToolStripMenuItem,
            this.liquidacionesToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(100, 27);
            this.toolStripMenuItem1.Text = "Nomina";
            // 
            // percepcionesYDeduccionesToolStripMenuItem
            // 
            this.percepcionesYDeduccionesToolStripMenuItem.Name = "percepcionesYDeduccionesToolStripMenuItem";
            this.percepcionesYDeduccionesToolStripMenuItem.Size = new System.Drawing.Size(379, 28);
            this.percepcionesYDeduccionesToolStripMenuItem.Text = "Percepciones y Deducciones";
            this.percepcionesYDeduccionesToolStripMenuItem.Click += new System.EventHandler(this.percepcionesYDeduccionesToolStripMenuItem_Click);
            // 
            // liquidacionesToolStripMenuItem
            // 
            this.liquidacionesToolStripMenuItem.Name = "liquidacionesToolStripMenuItem";
            this.liquidacionesToolStripMenuItem.Size = new System.Drawing.Size(379, 28);
            this.liquidacionesToolStripMenuItem.Text = "Liquidaciones";
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(169, 27);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            this.mantenimientoToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(110, 27);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // MDIParent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1097, 849);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MDIParent1";
            this.Text = "Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem percepcionesYDeduccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liquidacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
    }
}



