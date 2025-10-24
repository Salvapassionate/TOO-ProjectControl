using MySql.Data.MySqlClient;
using ProyectoTOO.Controller;
using System;
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

            MySqlCommand cmd = new MySqlCommand(query, conexion.ObtenerConexion());
            cmd.Parameters.AddWithValue("@correo", correo);
            cmd.Parameters.AddWithValue("@contrasena", password);

            conexion.AbrirConexion();
            var reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                usuario = new Usuario
                {
                    IdUsuario = reader.GetInt32("idUsuario"),
                    //Nombre = reader.GetString("nombres"),
                    //Apellido = reader.GetString("apellidos"),
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

            MySqlCommand cmd = new MySqlCommand(query, conexion.ObtenerConexion());

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
            string query = "UPDATE usuario SET contrasena = @pass WHERE idUsuario = @id";

            MySqlCommand cmd = new MySqlCommand(query, conexion.ObtenerConexion());
            cmd.Parameters.AddWithValue("@pass", nuevaPassword);
            cmd.Parameters.AddWithValue("@id", idUsuario);

            conexion.AbrirConexion();
            int resultado = cmd.ExecuteNonQuery();
            conexion.CerrarConexion();

            return resultado > 0;
        }
    }

}
