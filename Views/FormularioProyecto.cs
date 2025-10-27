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
        public FormularioProyecto()
        {
            InitializeComponent();

            List<AreaTematica> listaAreas = areaTematicaModel.listaAreaTematica();//Esta llista trae todas las areas tematicas disponibles

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

        private void btnRegistrarProyecto_MouseEnter(object sender, EventArgs e)
        {
            btnRegistrarProyecto.BackColor = Color.FromArgb(186, 225, 211);
        }

        private void btnRegistrarProyecto_MouseLeave(object sender, EventArgs e)
        {
            btnRegistrarProyecto.BackColor = Color.FromArgb(54, 73, 96);
        }

        private void btnRegistrarProyecto_Click(object sender, EventArgs e)
        {

        }
    }
}
