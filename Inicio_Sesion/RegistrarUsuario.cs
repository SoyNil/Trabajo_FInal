using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;

namespace Inicio_Sesion
{
    public partial class RegistrarUsuario : Form
    {
        public RegistrarUsuario()
        {
            InitializeComponent();
        }
        private void login(string text)
        {
            string connectionString = @"Data Source=DESKTOP-MVF4LL0;Initial Catalog=LOGIN;Integrated Security=True";

            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();

                // Verificar si el usuario ya existe
                SqlCommand checkUserCmd = new SqlCommand("SELECT COUNT(*) FROM SESION WHERE IDUsuario = @IDUsuario", cn);
                checkUserCmd.Parameters.AddWithValue("@IDUsuario", nomb.Text);

                int userCount = (int)checkUserCmd.ExecuteScalar();

                if (userCount > 0)
                {
                    MessageBox.Show("Este usuario ya está en nuestro sistema, intente uno nuevo", "Sistema");
                }
                else
                {
                    // Insertar nuevo usuario
                    SqlCommand insertUserCmd = new SqlCommand("INSERT INTO SESION (IDUsuario, CONTRA) VALUES (@IDUsuario, @CONTRA)", cn);
                    insertUserCmd.Parameters.AddWithValue("@IDUsuario", nomb.Text);
                    insertUserCmd.Parameters.AddWithValue("@CONTRA", contr.Text);

                    int rowsAffected = insertUserCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Datos insertados correctamente", "Sistema");
                    }
                    else
                    {
                        MessageBox.Show("Error al insertar datos", "Sistema");
                    }
                }
            }
        }

            private void RegistrarUsuario_Load(object sender, EventArgs e)
            {
        }

        private void registrar_Click(object sender, EventArgs e)
        {
            login(this.nomb.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form formulario = new Form1();
            formulario.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    } 
}

