using ProyectoTOO.Controller;
using ProyectoTOO.Model;
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
            //Variables
            AreaTematica areaTematica = new AreaTematica();
            Proyecto proyecto;
            DirectorProyecto director = new DirectorProyecto();

            listaAreas = areaTematicaModel.listaAreaTematica();//Esta llista trae todas las areas tematicas disponibles

            //areaTematica = listaAreas.FirstOrDefault(a => a.Nombre.Equals(nombreBuscado, StringComparison.OrdinalIgnoreCase));

            proyecto = new Proyecto
            {
                FechaInicio = dTFechaInicio.Value,
                FechaFin = dTFechaInicio.Value,
                NombreProyecto = txtNombreProyecto.Text,
                Descripcion = txtDescripcion.Text,
                IdAreaTematica = areaTematica.IdAreaTematica

            };

        }


        private void limpiarTextBox()
        {
            txtNombreProyecto.Text = "";
            txtDescripcion.Text = "";

        }


    }
}
