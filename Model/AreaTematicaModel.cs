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
    internal class AreaTematicaModel
    {
        private ConexionBD conexion;

        public AreaTematicaModel() {

            conexion = new ConexionBD();
        }


        /// <summary>
        /// Este metodo inserta un area tematica en la tabla areatematica de la base de datos, recibe como parametro un objeto AreaTematica
        /// </summary>
        /// <param name="areaTematica"></param>
        public void insertarAreaTematica(AreaTematica areaTematica)
        {

            try
            {
                string query = "INSERT INTO AreaTematica (nombreArea, descripcionArea) VALUES (@nombreArea, @descripcionArea)";
                MySqlCommand cmd = new MySqlCommand(query, conexion.ObtenerConexion());
                cmd.Parameters.AddWithValue("@nombreArea", areaTematica.NombreArea);
                cmd.Parameters.AddWithValue("@descripcionArea", areaTematica.DescripcionArea);

                conexion.AbrirConexion();
                cmd.ExecuteNonQuery();
                conexion.CerrarConexion();

                MessageBox.Show(
                      "¡ El area tematica se registro exitosamente ! ",// Texto del mensaje
                      "Registro Exitoso",// Titulo del mensaje
                      MessageBoxButtons.OK,         // Tipos de botones: OK, OKCancel, YesNo, YesNoCancel, RetryCancel, AbortRetryIgnore
                      MessageBoxIcon.Information    // Tipo de icono Information, Warning, Error, Question
                );

            }
            catch (Exception)
            {
                MessageBox.Show(
                    "No se pudo guardar el area tematica en la base de datos", // Texto del mensaje
                    "Error al registrar el Area Tematica",// Titulo del mensaje
                    MessageBoxButtons.OK,         // Tipos de botones: OK, OKCancel, YesNo, YesNoCancel, RetryCancel, AbortRetryIgnore
                    MessageBoxIcon.Error    // Tipo de icono Information, Warning, Error, Question
                );
            }

            finally
            {
                conexion.CerrarConexion();
            }
        }

        /// <summary>
        /// Este metodo trae una lista de areas tematicas de la base de datos, devuelve una lista.
        /// </summary>
        /// <returns></returns>
        public List<AreaTematica> listaAreaTematica()
        {
            List<AreaTematica> listaAreasTematicas = new List<AreaTematica>();

            try
            {
                string query = "SELECT idAreaTematica, nombreArea, descripcionArea FROM AreaTematica";
                MySqlCommand cmd = new MySqlCommand(query, conexion.ObtenerConexion());

                conexion.AbrirConexion();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    AreaTematica area = new AreaTematica()
                    {
                        IdAreaTematica = reader.GetInt32("idAreaTematica"),
                        NombreArea = reader.GetString("nombreArea"),
                        DescripcionArea = reader.GetString("descripcionArea")
                    };

                    listaAreasTematicas.Add(area);
                }

                reader.Close();
                conexion.CerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show(
                    "No se pudo obtener la lista de áreas temáticas.\n\nDetalles: ",
                    "Error de consulta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return listaAreasTematicas;
        }
    }
}
