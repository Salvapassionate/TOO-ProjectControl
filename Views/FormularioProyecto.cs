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
    public partial class FormularioProyecto : Form
    {
        AreaTematicaModel areaTematicaModel = new AreaTematicaModel();
        List<AreaTematica> listaAreas;
        List<DirectorProyecto> listaDirectores;


        public FormularioProyecto()
        {
            InitializeComponent();

            listaAreas = areaTematicaModel.listaAreaTematica();//Esta llista trae todas las areas tematicas disponibles

            if (listaAreas.Count > 0)
            {
                cmbxAreasTematicas.Items.Clear();
                cmbxAreasTematicas.Items.Add("Seleccione un área temática..."); // Texto inicial


                foreach (AreaTematica Area in listaAreas)
                {
                    cmbxAreasTematicas.Items.Add(Area.NombreArea);
                }

                // Mostrar el texto inicial
                cmbxAreasTematicas.SelectedIndex = 0;

            }
            else
            {
                MessageBox.Show(
                    "No existen areas tematicas registradas en el sistema, antes de agregar un proyecto primero registre las areas tematicas",
                    "Error de consulta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );


            }


        }
        
        //Este evento se ejecuta si no hay areas tematicas para mostrar en el formulario
        private void FormularioProyecto_Load(object sender, EventArgs e)
        {
            if (cmbxAreasTematicas.Items.Count == 0)
            {
                this.Close();
            }
        }

        private void btnRegistrarProyecto_Click(object sender, EventArgs e)
        {
            try
            {

                //Variables
                AreaTematica areaTematica = new AreaTematica();
                AreaTematica areaTemp;
                Proyecto proyecto;
                DirectorProyecto director = new DirectorProyecto();
                DirectorProyecto directorTemp;

                listaAreas = areaTematica.listarAreasTematicas();//Esta llista trae todas las areas tematicas disponibles
                listaDirectores = director.listarDirectores();

                if (listaAreas.Count == 0 || listaDirectores.Count == 0)
                {
                    MessageBox.Show(
                     "No se pueden registrar proyectos sin áreas temáticas o directores disponibles.",
                     "Error de registro",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Warning
                    );


                    return;

                }

                areaTemp = listaAreas.Find(a => a.NombreArea == cmbxAreasTematicas.SelectedItem.ToString());
                directorTemp = listaDirectores.Find(d => d.IdUser == vistaPrincipal._usuarioLogueado.IdUsuario);


                if (areaTemp == null || directorTemp == null)
                {
                    MessageBox.Show(
                          "¡Advertencia debes seleccionar un area tematica de la lista! ",// Texto del mensaje
                          "Registro Exitoso",// Titulo del mensaje
                          MessageBoxButtons.OK,         // Tipos de botones: OK, OKCancel, YesNo, YesNoCancel, RetryCancel, AbortRetryIgnore
                          MessageBoxIcon.Warning    // Tipo de icono Information, Warning, Error, Question
                    );

                    return;
                }



                proyecto = new Proyecto
                {
                    FechaInicio = dTFechaInicio.Value,
                    FechaFin = dTFechaInicio.Value,
                    Estado = "En progreso", //Estado inicial del proyecto, los otros estados son "Completado" y "En espera"
                    NombreProyecto = txtNombreProyecto.Text,
                    Descripcion = txtDescripcion.Text,
                    IdAreaTematica = areaTemp.IdAreaTematica,
                    IdDirectorProyecto = directorTemp.IdDirectorProyecto

                };


                if (proyecto != null)
                {
                    if(dTFechaInicio.Value.Date < dTFechaFin.Value.Date)
                    {
                        if (!String.IsNullOrEmpty(txtNombreProyecto.Text))
                        {
                            if (!String.IsNullOrEmpty(txtDescripcion.Text))
                            {
                                proyecto.registrarProyecto(proyecto);

                                MessageBox.Show(
                                      "¡ El proyecto se registro exitosamente ! ",// Texto del mensaje
                                      "Registro Exitoso",// Titulo del mensaje
                                      MessageBoxButtons.OK,         // Tipos de botones: OK, OKCancel, YesNo, YesNoCancel, RetryCancel, AbortRetryIgnore
                                      MessageBoxIcon.Information    // Tipo de icono Information, Warning, Error, Question
                                );

                                LimpiarTextBox();
                            }
                            else
                            {
                                txtDescripcion.Focus();
                                txtDescripcion.BackColor = Color.LightYellow;

                                MessageBox.Show(
                                        "¡ No se puede registrar ningun proyecto sin descripcion, por favor agregue una descripcion ! ",// Texto del mensaje
                                        "Advertencia",// Titulo del mensaje
                                        MessageBoxButtons.OK,         // Tipos de botones: OK, OKCancel, YesNo, YesNoCancel, RetryCancel, AbortRetryIgnore
                                        MessageBoxIcon.Warning    // Tipo de icono Information, Warning, Error, Question
                                );

                            }

                        }
                        else
                        {

                            txtNombreProyecto.Focus();
                            txtNombreProyecto.BackColor = Color.LightYellow;

                            MessageBox.Show(
                                    "¡ No se puede registrar ningun proyecto sin nombre, por favor agregue un nombre ! ",// Texto del mensaje
                                    "Advertencia",// Titulo del mensaje
                                    MessageBoxButtons.OK,         // Tipos de botones: OK, OKCancel, YesNo, YesNoCancel, RetryCancel, AbortRetryIgnore
                                    MessageBoxIcon.Warning    // Tipo de icono Information, Warning, Error, Question
                            );

                        }

                        return;

                    }
                    else
                    {
                        MessageBox.Show(
                              "¡ No se puede poner la misma fecha de inicio y fin del proyecto ! ",// Texto del mensaje
                              "Fechas de inicio y Fin no deben ser iguales",// Titulo del mensaje
                              MessageBoxButtons.OK,         // Tipos de botones: OK, OKCancel, YesNo, YesNoCancel, RetryCancel, AbortRetryIgnore
                              MessageBoxIcon.Warning    // Tipo de icono Information, Warning, Error, Question
                        );

                        dTFechaFin.Focus();

                    }

                }
                else
                {
                    MessageBox.Show(
                        "No fue posible registrar el proyecto",
                        "Error de registro de proyecto",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );

                }
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "No se pudo registrar el proyecto",
                    "Error en el registro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

            }

            



        }


        public void LimpiarTextBox()
        {
            txtNombreProyecto.Clear();
            txtDescripcion.Clear();
            txtDescripcion.BackColor = Color.White;
            txtNombreProyecto.BackColor = Color.White;

        }


    }
}
