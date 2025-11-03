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
    public class InstitucionModel
    {
        private ConexionBD conexion;

        public InstitucionModel()
        {
            conexion = new ConexionBD();
        }

        public void InsertarInstitucion(InstitucionEducativa institucion)
        {

            try
            {
                string query = "INSERT INTO Institucion (nombreInstitucion, correoInstitucion, direccion, descripcion ) VALUES (@nombreInstitucion, @correoInstitucion, @direccion, @descripcion)";
                MySqlCommand cmd = new MySqlCommand(query, conexion.ObtenerConexion());

                cmd.Parameters.AddWithValue("@nombreInstitucion", institucion.NombreInstitucion);
                cmd.Parameters.AddWithValue("@correo", institucion.CorreoInstitucion);
                cmd.Parameters.AddWithValue("@correo", institucion.Direccion);
                cmd.Parameters.AddWithValue("@correo", institucion.Descripcion);

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


        public List<InstitucionEducativa> listaInstitusiones()
        {
            List<InstitucionEducativa> listaInst = new List<InstitucionEducativa>();

            try
            {
                string query = "SELECT idInstitucion, nombreInstitucion, correoInstitucion, direccion, descripcion FROM Institucion";
                MySqlCommand cmd = new MySqlCommand(query, conexion.ObtenerConexion());

                conexion.AbrirConexion();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    InstitucionEducativa institucion = new InstitucionEducativa()
                    {
                        IdInstitucion = reader.GetInt32("idInstitucion"),
                        NombreInstitucion = reader.GetString("nombreInstitucion"),
                        CorreoInstitucion = reader.GetString("correoInstitucion"),
                        Direccion = reader.GetString("direccion"),
                        Descripcion = reader.GetString("descripcion")
                    };

                    listaInst.Add(institucion);
                }

                reader.Close();
                conexion.CerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show(
                    "No se pudo obtener la lista de Instituciones educativas." + e,
                    "Error de consulta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return listaInst;
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
