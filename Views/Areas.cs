using ProyectoTOO.Controller;
using System;
using System.Data;
using System.Windows.Forms;

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
