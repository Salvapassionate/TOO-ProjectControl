using ProyectoTOO.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTOO.Views
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }
        UsuarioController controller = new UsuarioController();

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombres = txtNombres.Text;
            string apellidos = txtApellidos.Text;
            string correo = txtCorreo.Text;
            string usuarioTxt = txtUsuario.Text;
            string pass1 = txtContraseña.Text;
            string pass2 = textBox3.Text;
            string rol = comboBox1.SelectedItem.ToString();

            if (pass1 != pass2)
            {
                MessageBox.Show("Las contraseñas no coinciden");
                return;
            }

            Usuario usuario = new Usuario
            {
                Nombre = nombres,
                Apellido = apellidos,
                Correo = correo,
                User = usuarioTxt,
                Pass = pass1,
                Rol = rol
            };

            bool registrado = controller.RegistrarUsuario(usuario);

            if (registrado)
            {
                MessageBox.Show("Usuario registrado exitosamente");
                this.Close();
                var menu = new Login();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Error al registrar usuario");
            }
        }

    }

}
