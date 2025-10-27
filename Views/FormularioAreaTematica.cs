using ProyectoTOO.Controller;
using ProyectoTOO.Validaciones;
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
    public partial class FormularioAreaTematica : Form
    {
        public FormularioAreaTematica()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Con este evento para el boton btnAgregarAreaTematica realizamos la comunicasion con el controlador y el modelo para guardar el area tematica
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarAreaTematica_Click(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrWhiteSpace(txtNombreAreaTematica.Text) && !string.IsNullOrWhiteSpace(txtDescripcionAreaTematica.Text))
            {
                AreaTematica areaTematica = new AreaTematica(txtNombreAreaTematica.Text, txtDescripcionAreaTematica.Text);

                areaTematica.crearArea(areaTematica);
            }
            else
            {
                MessageBox.Show(
                   "¡ No se puede dejar vacios los cuadros de texto por favor ingresar texto! ",// Texto del mensaje
                   "Advertencia",// Titulo del mensaje
                   MessageBoxButtons.OK,         // Tipos de botones: OK, OKCancel, YesNo, YesNoCancel, RetryCancel, AbortRetryIgnore
                   MessageBoxIcon.Warning    // Tipo de icono Information, Warning, Error, Question
               );
            }

            //Limpiar los inputBox

            txtNombreAreaTematica.Clear();
            txtDescripcionAreaTematica.Clear();



        }

        //Con este evento se valida que no se ponga numeros en el cuadro de texto txtNombreAreaTematica, solo texto
        private void txtNombreAreaTematica_KeyPress(object sender, KeyPressEventArgs e)
        {

            Validador.SoloLetras(txtNombreAreaTematica.Text, e, txtNombreAreaTematica);

        }

        //Con este evento se valida que no se ponga numeros en el cuadro de texto txtDescripcionAreaTematica, solo texto
        private void txtDescripcionAreaTematica_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validador.SoloLetras(txtDescripcionAreaTematica.Text, e, txtDescripcionAreaTematica);
        }
    }
}
