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
    public partial class EditarCuenta : Form
    {
        UsuarioController controller = new UsuarioController();
        private int idUsuario;
        public EditarCuenta(int idUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            controller = new UsuarioController();
        }
      

        private void btnGuardar_Click_1(object sender, EventArgs e)
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
