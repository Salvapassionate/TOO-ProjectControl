using System;
using System.Windows.Forms;
using ProyectoTOO.Controller;

namespace ProyectoTOO.Views
{
    public partial class Areas : Form
    {
        private ReporteController controller;

        public Areas()
        {
            InitializeComponent();
            controller = new ReporteController();
            ReporteAreas_Load(this, EventArgs.Empty);
        }

        private void ReporteAreas_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controller.CargarReporteAreas();
        }
    }
}
