using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProyectoTOO.Controller.Proyecto;

namespace ProyectoTOO.Views
{
    public partial class InvestigadorReporte : Form
    {
        private ReporteController controller;
        public InvestigadorReporte()
        {
            InitializeComponent();
            controller = new ReporteController();
            ReporteInvestigador_Load(this, EventArgs.Empty);
        }
        private void ReporteInvestigador_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controller.CargarReporteInvestigadores();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "CSV (.csv)|*.csv|Excel (.xlsx)|*.xlsx";
            save.Title = "Exportar Reporte de Áreas";

            if (save.ShowDialog() == DialogResult.OK)
            {
                DataTable dt = (DataTable)dataGridView1.DataSource;

                controller.ExportarExcel(dt, save.FileName);
                MessageBox.Show("Exportado como Excel", "Éxito");
            }
        }
    }
}
