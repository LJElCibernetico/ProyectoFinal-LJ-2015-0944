using ProyectoFinal_2015_0944.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoFinal_2015_0944
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
            Application.Run(new Login());
        }
    }
}
