using MySql.Data.MySqlClient;
using System;
using ProyectoTOO.Controller;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;
using System.Windows.Forms;

namespace ProyectoTOO.Model
{
    /// <summary>
    /// Esta clase es la que se encarga de realizar la conexion hacia la base de datos
    /// </summary>
    public class ConexionBD
    {
        private MySqlConnection conexion;

        //variables de conexion 

        private string servidor = "localhost";
        private string bd = "gestion_proyectos";
        private string usuario = "root";
        private string clave = "Too115";
        private string puerto = "3306";

        /// <summary>
        /// Contructor de la clase BD, Construye una cadena de conexión usando los valores definidos arriba.
        /// </summary>
        public ConexionBD()
        {
            string cadenaConexion = $"Server={servidor};Port={puerto};Database={bd};Uid={usuario};Pwd={clave};";
            conexion = new MySqlConnection(cadenaConexion);
        }

        /// <summary>
        /// Devuelve el objeto MySqlConnection para que otras clases puedan usarlo directamente.
        /// Sirve para ejecutar comandos SQL o consultas desde otra parte del programa.
        /// </summary>
        /// <returns>
        /// Devuelve el objeto MySqlConnection para que otras clases puedan usarlo directamente.
        /// </returns>
        public MySqlConnection ObtenerConexion()
        {
            return conexion;
        }

        /// <summary>
        /// Este metodo abre una conexion hacia la base de datos, consulta si no esta abierta, si no lo esta abre una conexion 
        /// </summary>
        public void AbrirConexion()
        {
            if (conexion.State == System.Data.ConnectionState.Closed)
                conexion.Open();
        }

        /// <summary>
        /// Este metodo se encarga de cerrar la conxion con la base de datos.
        /// </summary>
        public void CerrarConexion()
        {
            if (conexion.State == System.Data.ConnectionState.Open)
                conexion.Close();
        }

    }





}
