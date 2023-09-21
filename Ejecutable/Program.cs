using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaVista.Formularios;

namespace Ejecutable
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            Application.Run(new frmNomina());
=======
            Application.Run(new frmEmpleado());
>>>>>>> b9257d4f671c61b248788afe5587c7624430bc62
        }
    }
}
