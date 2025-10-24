using ProyectoTOO.Controller;
using ProyectoTOO.Model;
using ProyectoTOO.Views;
using ProyectoTOO.Views.Autenticasion;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnRegistrarse_MouseEnter(object sender, EventArgs e)
        {

            btnRegistrarse.ForeColor = Color.FromArgb(130, 255, 255);
            btnRegistrarse.Font = new Font("Arial", 12, FontStyle.Bold);

        }

        private void btnRegistrarse_MouseLeave(object sender, EventArgs e)
        {
            btnRegistrarse.ForeColor = Color.FromArgb(128, 255, 255);
            btnRegistrarse.Font = new Font("Arial", 10, FontStyle.Regular);

        }

        //Si dan click en el label de registro se abre un formulario para registrare
        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            Registro FormRegistro = new Registro();
            FormRegistro.ShowDialog();
            this.Hide();
        }

        private void btnCambiarContraseña_MouseEnter(object sender, EventArgs e)
        {
            btnCambiarContraseña.ForeColor = Color.FromArgb(130, 255, 255);
            btnCambiarContraseña.Font = new Font("Arial", 12, FontStyle.Bold);
        }

        private void btnCambiarContraseña_MouseLeave(object sender, EventArgs e)
        {
            btnCambiarContraseña.ForeColor = Color.FromArgb(128, 255, 255);
            btnCambiarContraseña.Font = new Font("Arial", 10, FontStyle.Regular);
        }

        private void btnCambiarContraseña_Click(object sender, EventArgs e)
        {
            CambiarContraseña form = new CambiarContraseña(usuarioLogueado);
            form.ShowDialog();
        }
        Usuario usuarioLogueado;
        UsuarioController controller = new UsuarioController();

        private void btnAutenticar_Click(object sender, EventArgs e)
        {
            string correo = txtUser.Text;
            string pass = txtpassword.Text;

            Usuario usuario = controller.Login(correo, pass);

            if (usuario != null)
            {
                usuarioLogueado = usuario; 

                lblResultado.ForeColor = Color.LightGreen;
                lblResultado.Text = "✅ Bienvenido " + usuario.Nombre;

                this.Hide();
                var menu = new vistaPrincipal(usuarioLogueado);
                menu.Show();
            }
            else
            {
                lblResultado.ForeColor = Color.Red;
                lblResultado.Text = "❌ Credenciales incorrectas.";
            }
        }
    }
}
