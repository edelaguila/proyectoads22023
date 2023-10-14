using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class Form1 : Form
    {
        public Form activeForm;
        public Form1()
        {
            InitializeComponent();
        }

        private void DeduccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frm_deduccion_percepciones dp = new frm_deduccion_percepciones();
            //dp.Show();
            this.abrirFormDentroDePanel(new frm_deduccion());

        }


        private void abrirFormDentroDePanel (Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void liquidacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.abrirFormDentroDePanel(new frm_liquidacion());
        }

        private void percepcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.abrirFormDentroDePanel(new frm_percepciones());
        }
    }
}
