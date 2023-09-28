using Inicio_Sesion;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inicio_Sesion
{
    public partial class ModificarAlumno : Form
    {
        private DataTable dataTable;

        public ModificarAlumno(DataTable usuariosRango3)
        {
            InitializeComponent();

            dataGridView1.CellClick += DataGridView1_CellClick;

            dataTable = usuariosRango3;
            dataGridView1.DataSource = dataTable;
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (cell.Value != null && cell.Value != DBNull.Value && !string.IsNullOrWhiteSpace(cell.Value.ToString()))
                {
                    dataGridView1.BeginEdit(true);
                }
                else
                {
                    // La celda está vacía, permite la edición
                    dataGridView1.BeginEdit(true);
                }
            }
        }
    }
}
