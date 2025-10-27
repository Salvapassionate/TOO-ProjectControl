using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoTOO.Controller;

namespace ProyectoTOO.Views.Autenticasion
{

    public partial class CambiarContraseña : Form
    {
        private Usuario usuarioLogueado;
        UsuarioController controller = new UsuarioController();

        //public CambiarContraseña(Usuario usuario)
        //{
        //    usuarioLogueado = usuario;
        //    txtUsuario.Text = usuarioLogueado.Correo;
        //    txtUsuario.ReadOnly = true;

        //}
        public CambiarContraseña()
        {
            InitializeComponent();
            txtUsuario.ReadOnly = false; 
        }

        private void btnGuardarContraseña_Click_1(object sender, EventArgs e)
        {
            string pass1 = textBox2.Text;
            string pass2 = textBox3.Text;
            string correo = txtUsuario.Text.Trim();
           
            if (pass1 != pass2)
            {
                MessageBox.Show("Las contraseñas no coinciden");
                return;
            }


            Usuario u = controller.BuscarUsuarioPorCorreo(correo);

            if (u == null)
            {
                MessageBox.Show("No existe un usuario con ese correo");
                return;
            }

            bool ok = controller.CambiarPassword(u.IdUsuario, pass1);

            if (ok)
            {
                MessageBox.Show("✅ Contraseña actualizada correctamente");
                this.Close();
            }
        }
    }
}
