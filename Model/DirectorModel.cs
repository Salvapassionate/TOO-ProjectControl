using MySql.Data.MySqlClient;
using ProyectoTOO.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTOO.Model
{
    internal class DirectorModel
    {

        private ConexionBD conexion = new ConexionBD();

        public bool Registrar(DirectorProyecto director)
        {
            bool resultado = false;

            try
            {
                string query = @"INSERT INTO directorproyecto (nombres, apellidos, institucion, idUsuario) 
                     VALUES (@nombres, @apellidos, @institucion, @idUsuario);";

                MySqlConnection conn = conexion.ObtenerConexion();
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@nombres", director.Nombre);
                cmd.Parameters.AddWithValue("@apellidos", director.Apellido);
                cmd.Parameters.AddWithValue("@institucion", director.Institucion);
                cmd.Parameters.AddWithValue("@idUsuario", director.IdUser);

                conexion.AbrirConexion();
                cmd.ExecuteNonQuery();
                conexion.CerrarConexion();

                MessageBox.Show(
                      "¡ Director registrado correctamente ! ",// Texto del mensaje
                      "Registro Exitoso",// Titulo del mensaje
                      MessageBoxButtons.OK,         // Tipos de botones: OK, OKCancel, YesNo, YesNoCancel, RetryCancel, AbortRetryIgnore
                      MessageBoxIcon.Information    // Tipo de icono Information, Warning, Error, Question
                );

                resultado = true;

            }
            catch (Exception)
            {
                MessageBox.Show(
                    "No se pudo registrar el Director", // Texto del mensaje
                    "Error al registrar el Director",// Titulo del mensaje
                    MessageBoxButtons.OK,         // Tipos de botones: OK, OKCancel, YesNo, YesNoCancel, RetryCancel, AbortRetryIgnore
                    MessageBoxIcon.Error    // Tipo de icono Information, Warning, Error, Question
                );
            }

            finally
            {
                conexion.CerrarConexion();
            }



            return resultado;
        }

        public DirectorProyecto buscarDirectorActivo()
        {

            DirectorProyecto director = null;

            try
            {

               

                string query = "SELECT * FROM directorproyecto WHERE idDirectorProyecto = @idDirectorProyecto";

                MySqlConnection conn = conexion.ObtenerConexion();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idDirectorProyecto", "");

                conexion.AbrirConexion();
                var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    director = new DirectorProyecto
                    {
                        IdDirectorProyecto = reader.GetInt32("idDirectorProyecto"),
                        Nombre = reader.GetString("nombres"),
                        Apellido = reader.GetString("apellidos"),
                        Institucion = reader.GetString("institucion"),
                        IdUser = reader.GetString("idUsuario"),

                    };
                }

                reader.Close();
                conexion.CerrarConexion();

            }
            catch (Exception)
            {
                MessageBox.Show(
                    "¡No se encontro el director !", // Texto del mensaje
                    "Advertencia",// Titulo del mensaje
                    MessageBoxButtons.OK,         // Tipos de botones: OK, OKCancel, YesNo, YesNoCancel, RetryCancel, AbortRetryIgnore
                    MessageBoxIcon.Warning    // Tipo de icono Information, Warning, Error, Question
                );
            }

            finally
            {
                conexion.CerrarConexion();
            }



            return director;

        }





    }
}
