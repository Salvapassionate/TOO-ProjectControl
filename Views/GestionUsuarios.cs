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
    public partial class GestionUsuarios : Form
    {
        UsuarioController controller = new UsuarioController();
        public GestionUsuarios()
        {
            InitializeComponent();
            controller = new UsuarioController();
            GestionUsuarios_Load(this, EventArgs.Empty);
        }

        private void GestionUsuarios_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controller.ObtenerUsuarios();
        }

        private void btnCambiarEstado_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string idUsuario = dataGridView1.SelectedRows[0].Cells["idUsuario"].Value.ToString();
                string nuevoEstado = comboEstado.SelectedItem.ToString();

                if (controller.CambiarEstadoUsuario(idUsuario, nuevoEstado))
                    MessageBox.Show("✅ Estado actualizado correctamente.");
                else
                    MessageBox.Show("❌ No se pudo cambiar el estado.");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {

        }
    }
}
