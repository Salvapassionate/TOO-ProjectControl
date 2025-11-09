using ProyectoTOO.Controller;
using System;
using System.Windows.Forms;
using static ProyectoTOO.Controller.Proyecto;

namespace ProyectoTOO.Views
{
    public partial class EditarCuenta : Form
    {
        UsuarioController controller = new UsuarioController();
        private string idUsuario;
        public EditarCuenta(string idUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            controller = new UsuarioController();
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string correo = txtCorreo.Text;
            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;

            bool actualizado = controller.ActualizarCuenta(idUsuario.ToString(), correo, usuario, contrasena);

            if (actualizado)
                MessageBox.Show("✅ Cuenta actualizada correctamente.");
            else
                MessageBox.Show("❌ Error al actualizar la cuenta.");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
