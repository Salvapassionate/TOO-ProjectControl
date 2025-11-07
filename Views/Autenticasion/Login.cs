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
using ProyectoTOO.Validaciones;



namespace ProyectoTOO.Views
{
    public partial class Login : Form
    {
        Usuario usuarioLogueado;

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
            Usuario usuarioLogueado = new Usuario();
            CambiarContraseña form = new CambiarContraseña(usuarioLogueado);
            form.ShowDialog();
        }

        private void btnAutenticar_Click(object sender, EventArgs e)
        {
            string correo = txtUser.Text.Trim();
            string pass = txtpassword.Text.Trim();


            if (string.IsNullOrWhiteSpace(correo) || string.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show(
                      "Por favor llenar todos los cuadros de texto",// Texto del mensaje
                      "¡Advertencia! ",// Titulo del mensaje
                      MessageBoxButtons.OK,         // Tipos de botones: OK, OKCancel, YesNo, YesNoCancel, RetryCancel, AbortRetryIgnore
                      MessageBoxIcon.Warning    // Tipo de icono Information, Warning, Error, Question
                );

                if (string.IsNullOrWhiteSpace(correo))
                {
                    txtUser.BackColor = Color.FromArgb(232, 119, 155);
                    txtUser.ForeColor = Color.FromArgb(0, 0, 0);
                }
                else
                {
                    txtUser.BackColor = Color.FromArgb(15, 15, 15);
                    txtUser.ForeColor = Color.White;
                }

                if (string.IsNullOrWhiteSpace(pass)) {

                    txtpassword.BackColor = Color.FromArgb(232, 119, 155);
                    txtpassword.ForeColor = Color.FromArgb(0, 0, 0);
                }
                else
                {
                    txtpassword.BackColor = Color.FromArgb(15, 15, 15);
                    txtpassword.ForeColor = Color.White;
                }
                    

            }
            else
            {
                Usuario usuarioController = new Usuario();

                usuarioLogueado = usuarioController.Login(correo, pass);

                if (usuarioLogueado == null)
                {
                       MessageBox.Show(
                           "El usuario ingresado no existe, por favor ingrese un usuario valido",// Texto del mensaje
                           "¡ Advertencia !",// Titulo del mensaje
                           MessageBoxButtons.OK,         // Tipos de botones: OK, OKCancel, YesNo, YesNoCancel, RetryCancel, AbortRetryIgnore
                           MessageBoxIcon.Warning    // Tipo de icono Information, Warning, Error, Question
                       );

                    limpiarTextBOX();

                    return;
                }


                // Verificas
                bool esValida = BCrypt.Net.BCrypt.Verify(pass, usuarioLogueado.Pass);


                if (esValida && usuarioLogueado.Estado=="Activo")
                {
                    devolverusuarioLogueado(); //Devuelve el usuario logueado si existe

                    MessageBox.Show(
                        "Inicio de sesión exitoso. ¡Nos alegra tenerte de vuelta!",
                        "Acceso concedido",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    devolverusuarioLogueado(); //Devuelve el usuario logueado si existe
                    this.DialogResult = DialogResult.OK;
                    this.Close();


                }
                else
                {
                    MessageBox.Show(
                        "👁️ ¡❌ Credenciales incorrectas!",// Texto del mensaje
                        " ",// Titulo del mensaje
                        MessageBoxButtons.OK,         // Tipos de botones: OK, OKCancel, YesNo, YesNoCancel, RetryCancel, AbortRetryIgnore
                        MessageBoxIcon.Information    // Tipo de icono Information, Warning, Error, Question
                    );

                    limpiarTextBOX(); // Este metodo limpia los textBOX


                }
            }



        }

        /// <summary>
        /// Esta funcion se utilza para devolver el usuario que se ha autenticado en el sistema
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns>Devuelve un Usuario</returns>
        public Usuario devolverusuarioLogueado()
        {
            return usuarioLogueado;
        }

        /// <summary>
        /// Este metodo limpia los textBox
        /// </summary>
        public void limpiarTextBOX()
        {
            txtUser.Clear();
            txtpassword.Clear();
            txtUser.BackColor = Color.FromArgb(15, 15, 15);
            txtpassword.BackColor = Color.FromArgb(15, 15, 15);
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
