using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaVista;

namespace EjecucionNomina
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
             Application.Run(new CapaVistaNomina.MenuNomina());
           // Application.Run(new CapaVistaNomina.MenuNomina());
            //Application.Run(new Form1());
        }
    }
}
