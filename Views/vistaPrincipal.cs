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

        public vistaPrincipal(Usuario usuario)
        {
            InitializeComponent();
            _usuario = usuario;

            lblBienvenida.Text = $"👋 Bienvenido {_usuario.Nombre} ({_usuario.Rol})";

            // Según el rol
            ConfigurarMenusPorRol();

        }

        private void ConfigurarMenusPorRol()
        {
            if (_usuario.Rol == "Director")
            {
                // Director ve todo
                gestionDeUsuariosToolStripMenuItem.Visible = true;
                agregarAreaTematicaToolStripMenuItem.Visible = true;
                reportesToolStripMenuItem.Visible = true;
            }
            else if (_usuario.Rol == "Investigador")
            {
                // Usuario normal: ocultar cosas administrativas
                gestionDeUsuariosToolStripMenuItem.Visible = false;
                agregarAreaTematicaToolStripMenuItem.Visible = false;
                reportesToolStripMenuItem.Visible = false;
            }
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
        private void xAreasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Areas frm = new Areas();
            frm.ShowDialog();
        }

        private void xInvestigadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Investigador frm = new Investigador();
            frm.ShowDialog();
        }

        private void xEstadoAvanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EstadoAvance frm = new EstadoAvance();
            frm.ShowDialog();
        }

        private void editarCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new EditarCuenta(_usuario.IdUsuario);
            frm.ShowDialog();
        }

        private void gestionDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new GestionUsuarios();
            frm.Show();
        }


    }
}
