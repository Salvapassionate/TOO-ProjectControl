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

                
                panelPresentacion.Controls.Clear();// Limpia el panel de presentacion porque sino salen los pryectos del usuario anterior
                cargarProyectos(); //Luego carga los proyectos del nuevo usuario
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

            //Obtenemos el director logueado
            directorProyecto = listaDirectores.Find(a => a.IdUser == _usuarioLogueado.IdUsuario);

            //Filtramos los proyectos del director logueado
            listaProyectos = listaProyectos.FindAll(p => p.IdDirectorProyecto == directorProyecto.IdDirectorProyecto && p.Estado=="En progreso");


            foreach (Proyecto proyecto in listaProyectos)
            {
                areaTematica = listAreas.Find(a => a.IdAreaTematica == proyecto.IdAreaTematica);

                //Contenedor de los proyectos
                Panel contenedor = new Panel();
                contenedor.Name = proyecto.IdProyecto.ToString(); //El nombre del panel sera el nombre del proyecto
                contenedor.Size = new Size(400, 300);
                contenedor.Margin = new Padding(10);
                contenedor.BackColor = Color.FromArgb(230, 235, 240); 
                contenedor.AutoScroll = true;

                //Cabezera del contenedor

                Panel panelCabecera = new Panel();
                panelCabecera.BackColor = Color.FromArgb(0, 102, 204);
                panelCabecera.Dock = DockStyle.Top;
                panelCabecera.Height = 40;

                Panel panelPie = new Panel();
                panelPie.BackColor = Color.FromArgb(0, 102, 204);
                panelPie.Dock = DockStyle.Bottom;
                panelPie.Height = 30;

                // Titulo del contenedor del proyecto
                Label titulo = new Label();
                titulo.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                titulo.ForeColor = titulo.ForeColor = Color.Black;
                titulo.Text = proyecto.NombreProyecto.ToString();
                titulo.Dock = DockStyle.Fill;
                titulo.TextAlign = ContentAlignment.MiddleCenter;
                contenedor.Controls.Add(titulo);

                panelCabecera.Controls.Add(titulo);

                //Contenido del cuerpo

                RichTextBox infoProyecto = new RichTextBox();
                infoProyecto.ReadOnly = true;
                infoProyecto.BorderStyle = BorderStyle.None;
                infoProyecto.BackColor = Color.FromArgb(230, 235, 240); // color de fondo del panel
                infoProyecto.Font = new Font("Segoe UI", 9);
                infoProyecto.Size = new Size(350, 150);
                infoProyecto.Dock = DockStyle.Fill;

                infoProyecto.Text =
                $"📅 Fecha de inicio: {proyecto.FechaInicio.ToString("yy/MM/dd")}\n" +
                $"🏁 Fecha de finalización: {proyecto.FechaFin.ToString("yy/MM/dd")}\n" +
                $"📌 Estado: {proyecto.Estado}\n\n" +
                "📖 Descripción:\n" +
                $"{proyecto.Descripcion}\n\n" +
                $"👨‍💼 Director del proyecto: {directorProyecto.Nombre + " " + directorProyecto.Apellido}\n" +
                $"🏢 Área temática: {areaTematica.NombreArea}";

                contenedor.Controls.Add(infoProyecto);

                //Boton eliminar proyecto

                Button eliminarProyecto = new Button();

                eliminarProyecto.Name = proyecto.IdProyecto.ToString();
                eliminarProyecto.Text = "✖"; // símbolo más estilizado que "X"
                eliminarProyecto.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                eliminarProyecto.Size = new Size(25, 40);
                eliminarProyecto.FlatStyle = FlatStyle.Flat;
                eliminarProyecto.FlatAppearance.BorderSize = 0;
                eliminarProyecto.BackColor = Color.FromArgb(220, 53, 69); // rojo moderno (tipo Bootstrap)
                eliminarProyecto.ForeColor = Color.White;
                eliminarProyecto.Cursor = Cursors.Hand;
                eliminarProyecto.Location = new Point(350, 0);
                eliminarProyecto.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 35, 51);
                eliminarProyecto.FlatAppearance.MouseDownBackColor = Color.FromArgb(180, 30, 40);
                eliminarProyecto.Click += (s, e) =>
                {
                    DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar este proyecto?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resultado == DialogResult.Yes)
                    {
                        Proyecto proyectoAEliminar = new Proyecto();
                        proyectoAEliminar.elimnarProyecto(int.Parse(eliminarProyecto.Name));

                        panelPresentacion.Controls.Clear();
                        cargarProyectos();
                    }
                };

                panelPie.Controls.Add(eliminarProyecto);


                //Boton para finalizar proyecto
                Button finalizarProyecto = new Button();
                finalizarProyecto.Name = proyecto.IdProyecto.ToString();
                finalizarProyecto.Text = "✔"; // símbolo de check
                finalizarProyecto.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                finalizarProyecto.Size = new Size(25, 40);
                finalizarProyecto.FlatStyle = FlatStyle.Flat;
                finalizarProyecto.FlatAppearance.BorderSize = 0;
                finalizarProyecto.BackColor = Color.FromArgb(40, 167, 69); // verde tipo Bootstrap
                finalizarProyecto.ForeColor = Color.White;
                finalizarProyecto.Cursor = Cursors.Hand;
                finalizarProyecto.Location = new Point(320, 0);
                finalizarProyecto.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 35, 51);
                finalizarProyecto.FlatAppearance.MouseDownBackColor = Color.FromArgb(180, 30, 40);

                finalizarProyecto.Click += (s, e) =>
                {
                    DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas Finalizar este proyecto?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resultado == DialogResult.Yes)
                    {
                        Proyecto proyectoAActualizar = new Proyecto();
                        proyectoAActualizar.actualizarProyecto(int.Parse(finalizarProyecto.Name.ToString()), "Finalizado");


                        panelPresentacion.Controls.Clear();
                        cargarProyectos();
                    }
                };

                panelPie.Controls.Add(finalizarProyecto);

                // Fin contenedor proyecto

                contenedor.Controls.Add(panelCabecera);
                contenedor.Controls.Add(panelPie);
                panelPresentacion.Controls.Add(contenedor);
                

            }

            //Finaliza la presentacion de los proyectos

            
        }

        //Evento para actualizar la lista de proyectos
        private void actualizarProyectoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelPresentacion.Controls.Clear();
            cargarProyectos();
        }

        private void nosotrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nosotros nosotros = new Nosotros();
            nosotros.ShowDialog();
        }

        private void editarProyectoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioProyecto proyectoAActualizar = new FormularioProyecto();
            proyectoAActualizar.lbl_IdProyecto.Visible = true;
            proyectoAActualizar.cmbxNombre_Proyecto.Visible = true;

            Proyecto proyecto = new Proyecto();
            DirectorProyecto directorProyecto = new DirectorProyecto();

            // Obtenemos el director logueado
            DirectorProyecto directorLogueado = directorProyecto.listarDirectores().Find(a => a.IdUser == _usuarioLogueado.IdUsuario);

            if (directorLogueado == null)
            {
                MessageBox.Show("No se encontró el director logueado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Filtramos los proyectos del director logueado
            List<Proyecto> listaProyectos = proyecto.ListarProyecto().FindAll(p => p.IdDirectorProyecto == directorLogueado.IdDirectorProyecto && p.Estado == "En progreso");

            if (listaProyectos.Count == 0)
            {
                MessageBox.Show("No hay proyectos asociados a este director.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Cargamos los IDs de los proyectos en el ComboBox
            foreach (Proyecto proj in listaProyectos)
            {
                proyectoAActualizar.cmbxNombre_Proyecto.Items.Add(proj.NombreProyecto);
            }

            proyectoAActualizar.ShowDialog();



        }
    }
}
