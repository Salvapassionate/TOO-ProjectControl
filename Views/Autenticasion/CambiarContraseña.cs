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
        Usuario usuarioController = new Usuario();

        public CambiarContraseña(Usuario usuario)
        {
            InitializeComponent();
            usuarioLogueado = usuario;

        }

        private void btnGuardarContraseña_Click(object sender, EventArgs e)
        {
            //string pass1 = txtContraseña.Text;
            //string pass2 = txtRepetirConstraseña.Text;
            //string correo = txtUsuario.Text.Trim();

            //if (pass1 != pass2)
            //{
            //    MessageBox.Show("Las contraseñas no coinciden");
            //    return;
            //}


            //Usuario u = usuarioController.BuscarUsuarioPorCorreo(correo);

            //if (u == null)
            //{
            //    MessageBox.Show("No existe un usuario con ese correo");
            //    return;
            //}

            //bool ok = usuarioController.CambiarPassword(u.IdUsuario, pass1);

            //if (ok)
            //{
            //    MessageBox.Show("✅ Contraseña actualizada correctamente");
            //    this.Close();
            //}
        }

    }
}
