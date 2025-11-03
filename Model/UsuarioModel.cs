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
    public class UsuarioModel
    {
        private ConexionBD conexion = new ConexionBD();

        public Usuario Autenticar(string correo, string password)
        {
            Usuario usuario = null;
            string query = "SELECT * FROM usuario WHERE correo = @correo AND contrasena = @contrasena";

            MySqlConnection conn = conexion.ObtenerConexion();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@correo", correo);
            cmd.Parameters.AddWithValue("@contrasena", password);

            conexion.AbrirConexion();
            var reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                usuario = new Usuario
                {
                    IdUsuario = reader.GetString("idUsuario"),
                    Correo = reader.GetString("correo"),
                    Pass = reader.GetString("contrasena"),
                    Rol = reader.GetString("rol")
                };
            }

            reader.Close();
            conexion.CerrarConexion();
            return usuario;
        }

        public bool Registrar(Usuario usuario)
        {
            bool resultado = false;

            try
            {
                string query = @"INSERT INTO usuario (idUsuario, correo, usuario,  contrasena, claveRecuperacion, rol, estadoUsuario, ultimaFechaDeIngreso, fechaRegistro) 
                     VALUES (@idUsuario, @correo, @usuario, @contrasena, @claveRecuperacion, @rol, @estadoUsuario, @ultimaFechaDeIngreso, @fechaRegistro);";

                MySqlConnection conn = conexion.ObtenerConexion();
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@idUsuario", usuario.IdUsuario);
                cmd.Parameters.AddWithValue("@correo", usuario.Correo);
                cmd.Parameters.AddWithValue("@usuario", usuario.User);
                cmd.Parameters.AddWithValue("@contrasena", usuario.Pass);
                cmd.Parameters.AddWithValue("@claveRecuperacion", usuario.ClaveRecuperacion);
                cmd.Parameters.AddWithValue("@rol", usuario.Rol);
                cmd.Parameters.AddWithValue("@estadoUsuario", usuario.Estado);
                cmd.Parameters.AddWithValue("@ultimaFechaDeIngreso", usuario.UltimaFecha);
                cmd.Parameters.AddWithValue("@fechaRegistro", usuario.FechaRegistro);

                conexion.AbrirConexion();
                cmd.ExecuteNonQuery();
                conexion.CerrarConexion();

                MessageBox.Show(
                      "¡ Usuario registrado exitosamente ! ",// Texto del mensaje
                      "Registro Exitoso",// Titulo del mensaje
                      MessageBoxButtons.OK,         // Tipos de botones: OK, OKCancel, YesNo, YesNoCancel, RetryCancel, AbortRetryIgnore
                      MessageBoxIcon.Information    // Tipo de icono Information, Warning, Error, Question
                );

                resultado = true;

            }
            catch (Exception)
            {
                MessageBox.Show(
                    "No se pudo registrar el usuario ", // Texto del mensaje
                    "Error al registrar el Usuario",// Titulo del mensaje
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

        public bool CambiarPassword(int idUsuario, string nuevaPassword)
        {
            string query = "UPDATE usuario SET contrasena = @contrasena WHERE idUsuario = @idUsuario";

            MySqlConnection conn = conexion.ObtenerConexion();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@contrasena", nuevaPassword);
            cmd.Parameters.AddWithValue("@idUsuario", idUsuario);

            conexion.AbrirConexion();
            int resultado = cmd.ExecuteNonQuery();
            conexion.CerrarConexion();

            return resultado > 0;
        }

        public Usuario BuscarPorCorreo(string correo)
        {
            Usuario usuario = null;
            string query = "SELECT * FROM usuario WHERE correo = @correo";

            MySqlConnection conn = conexion.ObtenerConexion();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@correo", correo);

            conexion.AbrirConexion();
            var reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                usuario = new Usuario
                {
                    IdUsuario = reader.GetString("idUsuario"),
                    Correo = reader.GetString("correo"),
                    Pass = reader.GetString("contrasena"),
                    Rol = reader.GetString("rol"),
                    Estado = reader.GetString("estadoUsuario"),
                    UltimaFecha = reader.GetDateTime("ultimaFechaDeIngreso"),
                    FechaRegistro = reader.GetDateTime("fechaRegistro")
                };
            }

            reader.Close();
            conexion.CerrarConexion();
            return usuario;
        }

    }

}
