using System;
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
    public partial class Modificar : Form
    {
        
        private int idUsuario;
        private string nombre;
        private string apellido;

        public Modificar(int idUsuario, string nombre, string apellido)
        {
            InitializeComponent();

            this.idUsuario = idUsuario;
            this.nombre = nombre;
            this.apellido = apellido;
            txtIDUsuario.Text = idUsuario.ToString();
            txtNombre.Text = nombre;
            txtApellido.Text = apellido;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int nuevoIdUsuario = int.Parse(txtIDUsuario.Text);
            string nuevoNombre = txtNombre.Text;
            string nuevoApellido = txtApellido.Text;
            string connectionString = @"Data Source=DESKTOP-MVF4LL0;Initial Catalog=LOGIN;Integrated Security=True";

            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();

                string query = "UPDATE SESION SET NOMB = @Nombre, APELL = @Apellido WHERE IDUsuario = @IDUsuario";

                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    cmd.Parameters.AddWithValue("@Nombre", nuevoNombre);
                    cmd.Parameters.AddWithValue("@Apellido", nuevoApellido);
                    cmd.Parameters.AddWithValue("@IDUsuario", nuevoIdUsuario);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Los datos se han actualizado correctamente.", "Éxito");
                    }
                    else
                    {
                        MessageBox.Show("No se realizaron cambios en los datos.", "Información");
                    }
                }
            }
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
