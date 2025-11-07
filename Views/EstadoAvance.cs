using ProyectoTOO.Controller;
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
    public partial class EstadoAvance : Form
    {
        private ReporteController controller;
        public EstadoAvance()
        {
            InitializeComponent();
            controller = new ReporteController();
            ReporteEstadoAvance_Load(this, EventArgs.Empty);
        }
        private void ReporteEstadoAvance_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controller.CargarReporteEstadoAvance();
        }
    }
}
