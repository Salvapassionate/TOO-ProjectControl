using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

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
        public static bool SoloLetras(string texto)
        {
            return Regex.IsMatch(texto, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$");
        }

        /// <summary>
        /// Verifica si la cadena contiene solo números
        /// </summary>
        /// <param name="texto"></param>
        /// <returns></returns>
        public static bool SoloNumeros(string texto)
        {
            return Regex.IsMatch(texto, @"^\d+$");
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
    }
}
