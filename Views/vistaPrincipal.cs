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
        public static Usuario _usuarioLogueado;
        

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
                _usuarioLogueado = login.devolverusuarioLogueado();
            }

            if (_usuarioLogueado != null) {

                this.Show();
                this.WindowState = FormWindowState.Maximized;
                login.Close();
               

                if (_usuarioLogueado.Rol == "Director")
                {
                    // Director ve todo
                    agregarAreaTematicaToolStripMenuItem.Visible = true;
                    reportesToolStripMenuItem.Visible = true;
                }
                else if (_usuarioLogueado.Rol == "Investigador")
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

            cargarProyectos();

        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();

            if (login.DialogResult == DialogResult.OK)
            {
                _usuarioLogueado = login.devolverusuarioLogueado();
            }
            else
            {
                Application.Exit();

            }

            if (_usuarioLogueado != null)
            {

                this.Show();
                this.WindowState = FormWindowState.Maximized;
                login.Close();


                if (_usuarioLogueado.Rol == "Director")
                {
                    // Director ve todo
                    agregarAreaTematicaToolStripMenuItem.Visible = true;
                    reportesToolStripMenuItem.Visible = true;
                }
                else if (_usuarioLogueado.Rol == "Investigador")
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


        public void cargarProyectos()
        {
            Proyecto proyectos = new Proyecto();
            DirectorProyecto directorProyecto = new DirectorProyecto();
            AreaTematica areaTematica = new AreaTematica();

            List<Proyecto> listaProyectos = proyectos.ListarProyecto();
            List<DirectorProyecto> listaDirectores = directorProyecto.listarDirectores();
            List<AreaTematica> listAreas = areaTematica.listarAreasTematicas();

            foreach (Proyecto proyecto in listaProyectos)
            {
                

                //Contenedor de los proyectos
                Panel temp = new Panel();
                temp.Name = proyecto.IdProyecto.ToString(); //El nombre del panel sera el nombre del proyecto
                temp.Size = new Size(300, 300);
                temp.Margin = new Padding(10);
                temp.BackColor = Color.FromArgb(158, 180, 193);
                temp.AutoScroll = true;

                // Titulo del contenedor del proyecto
                Label titulo = new Label();
                titulo.Font = new Font("Segoe UI", 11);
                titulo.ForeColor = titulo.ForeColor = Color.FromArgb(17, 75, 95);
                titulo.Text = proyecto.NombreProyecto.ToString();
                titulo.Dock = DockStyle.Top;
                titulo.TextAlign = ContentAlignment.MiddleCenter;
                temp.Controls.Add(titulo);

                //Contenido del cuerpo

                Label estado = new Label();
                estado.Font = new Font("Segoe UI", 11);
                titulo.ForeColor = titulo.ForeColor = Color.FromArgb(17, 75, 95);
                estado.Text = proyecto.Estado.ToString();
                estado.Dock = DockStyle.Fill;
                titulo.TextAlign = ContentAlignment.MiddleLeft;
                temp.Controls.Add(estado);

                //Pie del contenedor
                directorProyecto = listaDirectores.Find(a => a.IdUser == _usuarioLogueado.IdUsuario.ToString());
                Label director = new Label();
                director.Font = new Font("Segoe UI", 11);
                director.Text = "Director:" + directorProyecto.Nombre.ToString() +" "+ directorProyecto.Apellido;
                director.Dock = DockStyle.Bottom;
                director.TextAlign = ContentAlignment.MiddleCenter;
                temp.Controls.Add(director);

                // Fin contenedor proyecto

                panelPresentacion.Controls.Add(temp);

            }

            //Finaliza la presentacion de los proyectos

            
        }
    }
}
