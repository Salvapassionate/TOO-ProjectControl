using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoTOO.Views;
using ProyectoTOO.Views.Autenticasion;

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
            CambiarContraseña FormCambioContraseña = new CambiarContraseña();
            FormCambioContraseña.ShowDialog();
        }
    }
}
