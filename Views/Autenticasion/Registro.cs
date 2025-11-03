using ProyectoTOO.Controller;
using System.Security.Cryptography;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoTOO.Model;

namespace ProyectoTOO.Views
{
    public partial class Registro : Form
    {
        Usuario usuarioController = new Usuario();
        InstitucionEducativa inst = new InstitucionEducativa();

        public Registro()
        {
            InitializeComponent();

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombres = txtNombres.Text.Trim();
            string apellidos = txtApellidos.Text.Trim();
            string correo = txtCorreo.Text.Trim();
            string usuarioTxt = txtUsuario.Text.Trim();
            string pass1 = txtContraseña.Text.Trim();
            string pass2 = txtRepetirContraseña.Text.Trim();
            string rol = cmbxRol.SelectedItem.ToString();
            string inst = cmbxInstitucion.SelectedItem.ToString();

            Usuario user = new Usuario();

            // Genera un hash seguro
            string passwordHasheada = BCrypt.Net.BCrypt.HashPassword(pass1);

            if (pass1 != pass2)
            {
                MessageBox.Show(
                    "Las contraseñas no son iguales",// Texto del mensaje
                    "Error con las contraseñas ingresadas ",// Titulo del mensaje
                     MessageBoxButtons.OK,         // Tipos de botones: OK, OKCancel, YesNo, YesNoCancel, RetryCancel, AbortRetryIgnore
                     MessageBoxIcon.Error    // Tipo de icono Information, Warning, Error, Question
                 );
                txtContraseña.Clear();
                txtRepetirContraseña.Clear();
            }

            Usuario usuario = new Usuario
            {
                IdUsuario = usuarioTxt,
                Correo = correo,
                User = usuarioTxt,
                Pass = passwordHasheada,
                ClaveRecuperacion = usuarioTxt + "_" + rol,
                Rol = rol,
                Estado = "Activo",
                UltimaFecha = DateTime.Now,
                FechaRegistro = DateTime.Now,

            };

            if (rol == "Administrador") {

                Administrador admin = new Administrador()
                {
                    Nombre = nombres,
                    Apellido = apellidos,
                    Institucion = cmbxInstitucion.SelectedItem.ToString(),
                    IdUser = usuario.IdUsuario

                };

                bool userNew = user.RegistrarUsuario(usuario);

                bool adminNew = admin.registroAdministrador(admin);

                if (userNew)
                {
                    if (adminNew)
                    {

                        limpiarTextBox();

                    }

                }


            }
            else if (rol == "Director")
            {
                DirectorProyecto director = new DirectorProyecto()
                {
                    Nombre = nombres,
                    Apellido = apellidos,
                    Institucion = cmbxInstitucion.SelectedItem.ToString(),
                    IdUser = usuario.IdUsuario
                };

                bool userNew = user.RegistrarUsuario(usuario);
                bool directorNew = director.registroDirector(director);

                if (userNew)
                {
                    if (directorNew)
                    {

                        limpiarTextBox();

                    }

                }

            }
            else
            {
                Investigador investigador = new Investigador()
                {
                    Nombre = nombres,
                    Apellido = apellidos,
                    Institucion = cmbxInstitucion.SelectedItem.ToString(),
                    IdUser = usuario.IdUsuario

                };

                bool userNew = user.RegistrarUsuario(usuario);
                bool investigadorNew = investigador.registroInvestigador(investigador);

                if (userNew)
                {
                    if (investigadorNew)
                    {

                        limpiarTextBox();

                    }

                }

            }

        }


        private void limpiarTextBox()
        {

            List<TextBox> listaTextBox = new List<TextBox>()
            {
                txtNombres,
                txtApellidos,
                txtCorreo,
                txtUsuario,
                txtContraseña,
                txtRepetirContraseña,
            };

            foreach (TextBox textBox in listaTextBox)
            {
                textBox.Text = "";
            }

        }

        private void ValidarTextBox()
        {
            List<TextBox> listaTextBox = new List<TextBox>()
            {
                txtNombres,
                txtApellidos,
                txtCorreo,
                txtUsuario,
                txtContraseña,
                txtRepetirContraseña,
            };

            foreach (TextBox textBox in listaTextBox)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.BackColor = Color.FromArgb(232, 119, 155);
                    textBox.ForeColor = Color.Black;
                }
                else
                {
                    textBox.BackColor = Color.FromArgb(54, 73, 96);
                    textBox.ForeColor = Color.LightGray;
                }
            }


        }

        private void volverAsuEstado()
        {
            List<TextBox> listaTextBox = new List<TextBox>()
            {
                txtNombres,
                txtApellidos,
                txtCorreo,
                txtUsuario,
                txtContraseña,
                txtRepetirContraseña,
            };

            foreach (TextBox textBox in listaTextBox)
            {
                textBox.BackColor = Color.FromArgb(54, 73, 96);
                textBox.ForeColor = Color.LightGray;
            }


        }

        /// <summary>
        /// Este evento se inicia si no se han agregado instituciones educativas 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Registro_Load(object sender, EventArgs e)
        {
            List<InstitucionEducativa> listIns = inst.listaInstituciones();

            if (listIns.Count == 0)
            {
                MessageBox.Show(
                    "No se puede abrir el formulario porque no hay instituciones educativas, contacte al administrador",// Texto del mensaje
                    "Advertencia",// Titulo del mensaje
                     MessageBoxButtons.OK,         // Tipos de botones: OK, OKCancel, YesNo, YesNoCancel, RetryCancel, AbortRetryIgnore
                     MessageBoxIcon.Warning    // Tipo de icono Information, Warning, Error, Question
                 );

                this.Close();
            }

            foreach (InstitucionEducativa instituciones in listIns)
            {
                cmbxInstitucion.Items.Add(instituciones.NombreInstitucion);
            }
        }
    }

}
