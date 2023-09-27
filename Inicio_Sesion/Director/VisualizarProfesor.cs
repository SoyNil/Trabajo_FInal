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
    public partial class VisualizarProfesor : Form
    {
        public VisualizarProfesor(DataTable dataTable)
        {
            InitializeComponent();
            //dataGridView1.Columns["IDUsuario"].HeaderText = "ID";
            if (dataGridView1.Columns.Contains("IDUsuario"))
            {
                dataGridView1.Columns["IDUsuario"].HeaderText = "ID del Alumno";
            }
            else
            {
                MessageBox.Show("La columna 'IDUsuario' no existe en el DataGridView.", "Error");
            }
            //dataGridView1.Columns["NOMB"].HeaderText = "NOMBRE";
            //dataGridView1.Columns["APELL"].HeaderText = "APELLIDO";
            dataGridView1.DataSource = dataTable;
        }
    }
}
