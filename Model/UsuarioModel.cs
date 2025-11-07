using MySql.Data.MySqlClient;
using ProyectoTOO.Controller;
using System;
using System.Collections.Generic;
using System.Data;
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
                    IdUsuario = reader.GetInt32("idUsuario"),
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
            string query = @"INSERT INTO usuario (correo, contrasena, rol, estadoUsuario, ultimaFechaDeIngreso) 
                     VALUES (@correo, @contrasena, @rol, 'Activo', NOW());";

            MySqlConnection conn = conexion.ObtenerConexion();
            MySqlCommand cmd = new MySqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@correo", usuario.Correo);
            cmd.Parameters.AddWithValue("@contrasena", usuario.Pass);
            cmd.Parameters.AddWithValue("@rol", usuario.Rol);

            conexion.AbrirConexion();
            int resultado = cmd.ExecuteNonQuery();
            conexion.CerrarConexion();

            return resultado > 0;
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
                    IdUsuario = reader.GetInt32("idUsuario"),
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
        public DataTable ListarUsuarios()
        {
            string query = "SELECT idUsuario, usuario, correo, rol, estadoUsuario, ultimaFechaDeIngreso FROM Usuario";
            using (MySqlConnection conn = conexion.ObtenerConexion())
            {
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public bool ActualizarUsuario(string idUsuario, string correo, string usuario, string contrasena)
        {
            string query = @"UPDATE Usuario 
                             SET correo = @correo, usuario = @usuario, contrasena = @contrasena 
                             WHERE idUsuario = @id";
            using (MySqlConnection conn = conexion.ObtenerConexion())
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@correo", correo);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@contrasena", contrasena);
                cmd.Parameters.AddWithValue("@id", idUsuario);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool CambiarEstado(string idUsuario, string nuevoEstado)
        {
            string query = "UPDATE Usuario SET estadoUsuario = @estado WHERE idUsuario = @id";
            using (MySqlConnection conn = conexion.ObtenerConexion())
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@estado", nuevoEstado);
                cmd.Parameters.AddWithValue("@id", idUsuario);
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
