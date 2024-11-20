using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace Trabajo_final
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Biblioteca biblioteca = new Biblioteca();
            Controller controller = new Controller();
            controller.importarCatalogo(biblioteca);
            Application.Run(new UserControl1(biblioteca));
        }
    }
}
