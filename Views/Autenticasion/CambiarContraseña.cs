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

        public CambiarContraseña(Usuario usuario)
        {
            InitializeComponent();
            usuarioLogueado = usuario;

        }
        private void btnGuardarContraseña_Click(object sender, EventArgs e)
        {
            string pass1 = textBox2.Text;
            string pass2 = textBox3.Text;

            if (pass1 != pass2)
            {
                MessageBox.Show("Las contraseñas no coinciden");
                return;
            }

            bool ok = controller.CambiarPassword(usuarioLogueado.IdUsuario, pass1);

            if (ok)
            {
                MessageBox.Show("✅ Contraseña actualizada correctamente");
                this.Close();
            }
            else
            {
                MessageBox.Show("❌ Error al actualizar la contraseña");
            }
        }
    }
}
