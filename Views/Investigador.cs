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
    public partial class Investigador : Form
    {
        private ReporteController controller;
        public Investigador()
        {
            InitializeComponent();
            controller = new ReporteController();
            ReporteInvestigador_Load(this, EventArgs.Empty);
        }

        private void ReporteInvestigador_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controller.CargarReporteInvestigadores();
        }
    }
}
