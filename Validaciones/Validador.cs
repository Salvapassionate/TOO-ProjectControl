using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Drawing;

namespace ProyectoTOO.Validaciones
{
    /// <summary>
    /// Esta clase se ha desarrollado para realizar validaciones
    /// </summary>
    public static class Validador
    {
        /// <summary>
        /// Verifica si un texto NO está vacío ni solo contiene espacios
        /// </summary>
        /// <param name="texto"></param>
        /// <returns></returns>
        public static bool EsTextoValido(string texto)
        {
            return !string.IsNullOrWhiteSpace(texto);
        }

        /// <summary>
        /// Verifica si una cadena contiene solo letras (sin números)
        /// </summary>
        /// <param name="texto"></param>
        /// <returns></returns>
        public static void SoloLetras(string texto, KeyPressEventArgs e, TextBox  cajaTexto)
        {
            // Verifica si el carácter es letra o tecla de control (como Backspace)
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                cajaTexto.BackColor = Color.MistyRose;//Cabiamos el color de fondo del Textbox
                cajaTexto.ForeColor = Color.Black;

                e.Handled = true; // Cancela la tecla
                MessageBox.Show(
                    "¡ Solo se puede agragar texto, por ejemplo Biologia ! ",// Texto del mensaje
                    "Advertencia",// Titulo del mensaje
                    MessageBoxButtons.OK,         // Tipos de botones: OK, OKCancel, YesNo, YesNoCancel, RetryCancel, AbortRetryIgnore
                    MessageBoxIcon.Warning    // Tipo de icono Information, Warning, Error, Question
                );
            }
            else
            {
                // Restaurar color normal si el valor es válido
                cajaTexto.BackColor = Color.FromArgb(54, 73, 96);
                cajaTexto.ForeColor = Color.White;
            }

        }

        /// <summary>
        /// Verifica si la cadena contiene solo números del 0 al 9
        /// </summary>
        /// <param name="texto"></param>
        /// <returns></returns>
        public static void SoloNumeros(string texto, KeyPressEventArgs e, TextBox cajaTexto)
        {
            // Verifica si el carácter es número o tecla de control (como Backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Cambiar el color del fondo para indicar error
                cajaTexto.BackColor = Color.MistyRose;
                cajaTexto.ForeColor = Color.Black;

                // Cancelar la tecla
                e.Handled = true;

                // Mostrar mensaje de advertencia
                MessageBox.Show(
                    "¡ Solo se permiten números del 0 al 9 !",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            else
            {
                // Restaurar color normal si el valor es válido
                cajaTexto.BackColor = Color.FromArgb(54, 73, 96);
                cajaTexto.ForeColor = Color.White;
            }
        }

        /// <summary>
        /// Verifica si un número está dentro de un rango permitido
        /// </summary>
        /// <param name="numero"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static bool NumeroEnRango(int numero, int min, int max)
        {
            return numero >= min && numero <= max;
        }

        /// <summary>
        /// Verifica si un correo electrónico tiene formato válido
        /// </summary>
        /// <param name="correo"></param>
        /// <returns></returns>
        public static bool EsCorreoValido(string correo)
        {
            return Regex.IsMatch(correo, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        /// <summary>
        /// Verifica si una contraseña cumple reglas mínimas (mayúscula, minúscula, número, largo)
        /// </summary>
        /// <param name="contrasena"></param>
        /// <returns></returns>
        public static bool EsContrasenaSegura(string contrasena)
        {
            return Regex.IsMatch(contrasena, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$");
        }

        /// <summary>
        /// Verifica si una fecha no es futura
        /// </summary>
        /// <param name="fecha"></param>
        /// <returns></returns>
        public static bool FechaNoFutura(DateTime fecha)
        {
            return fecha <= DateTime.Now;
        }

        public static void MarcarError(TextBox txt)
        {
            Graphics g = txt.CreateGraphics();
            Pen p = new Pen(Color.Red, 2);
            Rectangle rect = new Rectangle(0, 0, txt.Width - 1, txt.Height - 1);
            g.DrawRectangle(p, rect);
            g.Dispose();
        }
    }
}
