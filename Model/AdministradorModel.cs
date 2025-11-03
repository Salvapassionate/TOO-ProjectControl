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
    internal class AdministradorModel
    {
        private ConexionBD conexion = new ConexionBD();

        public bool Registrar(Administrador admin)
        {
            bool resultado = false;

            try
            {
                string query = @"INSERT INTO administrador (nombres, apellidos, institucion, idUsuario) 
                     VALUES (@nombres, @apellidos, @institucion, @idUsuario);";

                MySqlConnection conn = conexion.ObtenerConexion();
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@nombres", admin.Nombre);
                cmd.Parameters.AddWithValue("@apellidos", admin.Apellido);
                cmd.Parameters.AddWithValue("@institucion", admin.Institucion);
                cmd.Parameters.AddWithValue("@idUsuario", admin.IdUser);

                conexion.AbrirConexion();
                cmd.ExecuteNonQuery();
                conexion.CerrarConexion();

                MessageBox.Show(
                      "¡ Administrdor registrado correctamente ! ",// Texto del mensaje
                      "Registro Exitoso",// Titulo del mensaje
                      MessageBoxButtons.OK,         // Tipos de botones: OK, OKCancel, YesNo, YesNoCancel, RetryCancel, AbortRetryIgnore
                      MessageBoxIcon.Information    // Tipo de icono Information, Warning, Error, Question
                );

                resultado = true;

            }
            catch (Exception e)
            {
                MessageBox.Show(
                    "No se pudo registrar el Administrador" + e, // Texto del mensaje
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
    }
}
