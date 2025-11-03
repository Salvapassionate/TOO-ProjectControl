using ProyectoTOO.Views;
using ProyectoTOO.Views.Autenticasion;
using ProyectoTOO.Controller;
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
            //Application.Run(new Login());
            //Application.Run(new vistaPrincipal());
            //Application.Run(new FormularioProyecto());
            //Application.Run(new Login());
            //Application.Run(new Registro());
            //Application.Run(new CambiarContraseña



            Login login = new Login();
            Usuario usuario;

            // Obtener usuario logueado
            usuario = login.devolverusuarioLogueado();

            Application.Run(login);

            if (usuario != null)
            {
                // Usuario correcto → abrir formulario principal
                Application.Run(new vistaPrincipal(usuario));
            }
            else
            {
                // Usuario nulo o login cerrado → cerrar aplicación
                Application.Exit();
            }







        }
    }
}
