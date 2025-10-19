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

    public class InstitucionModel
    {
        private ConexionBD conexion;
        string mensaje;

        public InstitucionModel()
        {
            conexion = new ConexionBD();
        }

        public void InsertarInstitucion(InstitucionEducativa institucion)
        {

            try
            {
                string query = "INSERT INTO Institucion (nombreInstitucion, correo) VALUES (@nombre, @correo)";
                MySqlCommand cmd = new MySqlCommand(query, conexion.ObtenerConexion());
                cmd.Parameters.AddWithValue("@nombreInstitucion", institucion.NombreInstitucion);
                cmd.Parameters.AddWithValue("@correo", institucion.Correo);

                conexion.AbrirConexion();
                cmd.ExecuteNonQuery();
                conexion.CerrarConexion();

            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al guardar la institucion en la base de datos" + ex,// Texto del mensaje
                    "Error al registrar la Institucion",// Titulo del mensaje
                    MessageBoxButtons.OK,         // Tipos de botones: OK, OKCancel, YesNo, YesNoCancel, RetryCancel, AbortRetryIgnore
                    MessageBoxIcon.Information    // Tipo de icono Information, Warning, Error, Question
                );
            }

            finally
            {
                conexion.CerrarConexion();
            }
        }

        public void EliminarInstitucion(InstitucionEducativa institucion)
        {
            try
            {
                string query = "DELETE FROM Institucion WHERE idInstitucion = @idInstitucion";
                MySqlCommand cmd = new MySqlCommand(query, conexion.ObtenerConexion());
                cmd.Parameters.AddWithValue("@idInstitucion", institucion.IdInstitucion);

                conexion.AbrirConexion();
                int filasAfectadas = cmd.ExecuteNonQuery();
                conexion.CerrarConexion();

                if (filasAfectadas > 0)
                {
                   MessageBox.Show(
                        "Institución eliminada correctamente",// Texto del mensaje
                        "Informacion",// Titulo del mensaje
                        MessageBoxButtons.OK,         // Tipos de botones: OK, OKCancel, YesNo, YesNoCancel, RetryCancel, AbortRetryIgnore
                        MessageBoxIcon.Information    // Tipo de icono Information, Warning, Error, Question
                    );
                }
                else
                {
                    Console.WriteLine("⚠️ No se encontró ninguna institución con ese ID.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Error al eliminar la institución: " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

    }




}
