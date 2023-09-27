using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inicio_Sesion
{
    public partial class VisualizarAlumnos : Form
    {
        public VisualizarAlumnos(DataTable dataTable)
        {
            InitializeComponent();

            // Establecer la fuente de datos del DataGridView en la DataTable
            dataGridView1.DataSource = dataTable;
        }
    }
}
