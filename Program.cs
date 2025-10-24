using ProyectoTOO.Views;
using ProyectoTOO.Views.Autenticasion;
using ProyectoTOO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ProyectoTOO
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
            Application.Run(new Login());
            //Application.Run(new FormularioProyecto());
            //Application.Run(new Login());
            //Application.Run(new Registro());
            //Application.Run(new CambiarContraseña());

        }
    }
}
