using Inicio_Sesion;
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
    public partial class Director : Form
    {
        private string idUsuario;
        public Director(string IDUsuario)
        {
            InitializeComponent();
            idUsuario = IDUsuario;

            CargarDatosUsuario();
            
            Hola.Text = Hola.Text +"Hola, "+IDUsuario+"!";
        }
        private void CargarDatosUsuario()
        {
            string connectionString = @"Data Source=DESKTOP-MVF4LL0;Initial Catalog=LOGIN;Integrated Security=True";

            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("SELECT IDUsuario, NOMB, APELL FROM SESION WHERE IDUsuario = @IDUsuario", cn);
                cmd.Parameters.AddWithValue("@IDUsuario", idUsuario);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    usuario.Text = "Usuario: "+dr["IDUsuario"].ToString();
                    nombre.Text = "Nombre: " +dr["NOMB"].ToString();
                    apellido.Text = "Apellido: "+dr["APELL"].ToString();
                }
                else
                {
                    MessageBox.Show("No se encontraron datos para el usuario.", "Sistema");
                }
            }
        }
        private DataTable ObtenerUsuariosRango3()
        {
            DataTable dataTable = new DataTable();

            string connectionString = @"Data Source=DESKTOP-MVF4LL0;Initial Catalog=LOGIN;Integrated Security=True";

            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("SELECT IDUsuario, NOMB, APELL FROM SESION WHERE RANGO = 3", cn);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                dataAdapter.Fill(dataTable);
            }

            return dataTable;
        }
        private DataTable ObtenerUsuariosRango2()
        {
            DataTable dataTable = new DataTable();

            string connectionString = @"Data Source=DESKTOP-MVF4LL0;Initial Catalog=LOGIN;Integrated Security=True";

            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("SELECT IDUsuario, NOMB, APELL FROM SESION WHERE RANGO = 2", cn);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                dataAdapter.Fill(dataTable);
            }

            return dataTable;
        }

        private void UsuarioCorrecto_Load(object sender, EventArgs e)
        {

        }

        private void NombrUsu_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rango_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable usuariosRango3 = ObtenerUsuariosRango3();
            VisualizarAlumnos visualizarAlumno = new VisualizarAlumnos(usuariosRango3);
            visualizarAlumno.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable usuariosRango2 = ObtenerUsuariosRango2();
            VisualizarProfesor profesor = new VisualizarProfesor(usuariosRango2);
            profesor.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable usuariosRango3 = ObtenerUsuariosRango3();
            ModificarAlumno modialumn = new ModificarAlumno(usuariosRango3);
            modialumn.Show();
        }
    }
}
