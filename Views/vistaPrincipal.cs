using ProyectoTOO.Controller;
using ProyectoTOO.Model;
using ProyectoTOO.Views;
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
    public partial class vistaPrincipal : Form
    {
        private Usuario _usuario;

        public vistaPrincipal()
        {
            InitializeComponent();


        }
        //Este evento es para cerrar el formulario de la vista principal y esta relacionada al menu salir 
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Este evento inicia el formulario para registrar nuevos proyectos
        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioProyecto NuevoProyecto = new FormularioProyecto();
            NuevoProyecto.ShowDialog();

        }

        private void agregarAreaTematicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioAreaTematica formularioAreaTematica = new FormularioAreaTematica();
            formularioAreaTematica.ShowDialog();
        }

        private void vistaPrincipal_Load(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();

            if(login.DialogResult==DialogResult.OK)
            {
                _usuario = login.devolverusuarioLogueado();
            }

            if (_usuario != null) {

                this.Show();
                this.WindowState = FormWindowState.Maximized;
                login.Close();
               

                if (_usuario.Rol == "Director")
                {
                    // Director ve todo
                    agregarAreaTematicaToolStripMenuItem.Visible = true;
                    reportesToolStripMenuItem.Visible = true;
                }
                else if (_usuario.Rol == "Investigador")
                {
                    // Usuario normal: ocultar cosas administrativas
                    agregarAreaTematicaToolStripMenuItem.Visible = false;
                    reportesToolStripMenuItem.Visible = false;
                }



            }
            else
            {
                this.Close();
            }


        }
    }
}
