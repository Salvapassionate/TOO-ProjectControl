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
    internal class InvestigadorModel
    {

        private ConexionBD conexion = new ConexionBD();

        public bool Registrar(Investigador investigador)
        {
            bool resultado = false;

            try
            {
                string query = @"INSERT INTO investigador (nombres, apellidos, institucion, idUsuario) 
                     VALUES (@nombres, @apellidos, @institucion, @idUsuario);";

                MySqlConnection conn = conexion.ObtenerConexion();
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@nombres", investigador.Nombre);
                cmd.Parameters.AddWithValue("@apellidos", investigador.Apellido);
                cmd.Parameters.AddWithValue("@institucion", investigador.Institucion);
                cmd.Parameters.AddWithValue("@idUsuario", investigador.IdUser);

                conexion.AbrirConexion();
                cmd.ExecuteNonQuery();
                conexion.CerrarConexion();

                MessageBox.Show(
                      "¡ Investigador registrado correctamente ! ",// Texto del mensaje
                      "Registro Exitoso",// Titulo del mensaje
                      MessageBoxButtons.OK,         // Tipos de botones: OK, OKCancel, YesNo, YesNoCancel, RetryCancel, AbortRetryIgnore
                      MessageBoxIcon.Information    // Tipo de icono Information, Warning, Error, Question
                );

                resultado = true;

            }
            catch (Exception e)
            {
                MessageBox.Show(
                    "No se pudo registrar el Investigador" + e, // Texto del mensaje
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
