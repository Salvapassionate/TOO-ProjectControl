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
    
    internal class ProyectoModel
    {
        private ConexionBD conexion;

        public ProyectoModel()
        {
            conexion = new ConexionBD();
        }

        /// <summary>
        /// Este metodo agraga un nuevo proyecto a la base de datos, recibe un Proyecto como parametro
        /// </summary>
        /// <param name="proyecto"></param>
        public void insertarProyecto(Proyecto proyecto)
        {

            try
            {

                string query = "INSERT INTO proyecto (nombreProyecto, descripcionProyecto, fechaInicio, fechaFin, estado, idAreaTematica, idDirectorProyecto) VALUES (@nombreProyecto, @descripcionProyecto, @fechaInicio, @fechaFin, @estado, @idAreaTematica, @idDirectorProyecto)";
                
                MySqlCommand cmd = new MySqlCommand(query, conexion.ObtenerConexion());
                cmd.Parameters.AddWithValue("@nombreProyecto", proyecto.NombreProyecto);
                cmd.Parameters.AddWithValue("@descripcionProyecto", proyecto.Descripcion);
                cmd.Parameters.AddWithValue("@fechaInicio", proyecto.FechaInicio);
                cmd.Parameters.AddWithValue("@fechaFin", proyecto.FechaFin);
                cmd.Parameters.AddWithValue("@estado", proyecto.Estado);
                cmd.Parameters.AddWithValue("@idAreaTematica", proyecto.IdAreaTematica);
                cmd.Parameters.AddWithValue("@idDirectorProyecto", proyecto.IdDirectorProyecto);

                conexion.AbrirConexion();
                cmd.ExecuteNonQuery();
                conexion.CerrarConexion();

            }
            catch (Exception)
            {
                MessageBox.Show(
                    "No se pudo guardar el proyecto en la base de datos", // Texto del mensaje
                    "Error al registrar El Proyecto",// Titulo del mensaje
                    MessageBoxButtons.OK,         // Tipos de botones: OK, OKCancel, YesNo, YesNoCancel, RetryCancel, AbortRetryIgnore
                    MessageBoxIcon.Error    // Tipo de icono Information, Warning, Error, Question
                );
            }

            finally
            {
                conexion.CerrarConexion();
            }
        }



        public List<Proyecto> listaProyectos()
        {
            List<Proyecto> listaProyectos = new List<Proyecto>();

            try
            {
                string query = "SELECT idProyecto, nombreProyecto, descripcionProyecto, fechaInicio, fechaFin, estado, idAreaTematica, idDirectorProyecto FROM proyecto";
                MySqlCommand cmd = new MySqlCommand(query, conexion.ObtenerConexion());

                conexion.AbrirConexion();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    //Variables temporales
                    AreaTematica areaTemp = new AreaTematica();
                    DirectorProyecto directorTemp = new DirectorProyecto();

                    Proyecto proyecto = new Proyecto()
                    {
                        IdProyecto = reader.GetInt32("idProyecto"),
                        NombreProyecto = reader.GetString("nombreProyecto"),
                        Descripcion = reader.GetString("descripcionProyecto"),
                        FechaInicio = reader.GetDateTime("fechaInicio"),
                        FechaFin = reader.GetDateTime("fechaFin"),
                        Estado = reader.GetString("estado"),
                        IdAreaTematica = reader.GetInt32("idAreaTematica"),
                        IdDirectorProyecto = reader.GetInt32("idDirectorProyecto"),
                    };

                    listaProyectos.Add(proyecto);
                }

                reader.Close();
                conexion.CerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show(
                    "No se pudo obtener la lista de proyectos registrados",
                    "Error de consulta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return listaProyectos;
        }

      

        public Proyecto BuscarProyectoPorNombre(string nombreProyecto)
        {
            Proyecto proyecto = null;

            try
            {
                string query = @"SELECT idProyecto, nombreProyecto, descripcionProyecto, fechaInicio, fechaFin, estado, 
                                idAreaTematica, idDirectorProyecto 
                         FROM proyecto 
                         WHERE nombreProyecto = @nombreProyecto";

                MySqlCommand cmd = new MySqlCommand(query, conexion.ObtenerConexion());
                cmd.Parameters.AddWithValue("@nombreProyecto", nombreProyecto);

                conexion.AbrirConexion();
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    proyecto = new Proyecto
                    {
                        IdProyecto = reader.GetInt32("idProyecto"),
                        NombreProyecto = reader.GetString("nombreProyecto"),
                        Descripcion = reader.GetString("descripcionProyecto"),
                        FechaInicio = reader.GetDateTime("fechaInicio"),
                        FechaFin = reader.GetDateTime("fechaFin"),
                        Estado = reader.GetString("estado"),
                        IdAreaTematica = reader.GetInt32("idAreaTematica"),
                        IdDirectorProyecto = reader.GetInt32("idDirectorProyecto")
                    };
                }

                reader.Close();
                conexion.CerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show(
                    "Error al buscar el proyecto: " + e.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return proyecto; // Retorna null si no se encontró
        }
    }
}
