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

namespace Inicio_Sesion
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void login(string text, string text1)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-MVF4LL0;Initial Catalog=LOGIN;Integrated Security=True");
            cn.Open();
            SqlCommand cm = new SqlCommand("select IDUsuario, CONTRA, RANGO from SESION where IDUsuario='"+usuario.Text+"'and CONTRA='"+contra.Text+"'",cn);
            SqlDataReader dr = cm.ExecuteReader();
            if (dr.Read())
            {
                int rango = Convert.ToInt32(dr["RANGO"]);
                this.Hide();
                //new Director(usuario.Text).Show();
                if (rango == 1)
                {
                    new Director(usuario.Text).Show();
                }
                else if (rango == 2)
                {
                    Profesor profesor = new Profesor();
                    profesor.Show();
                    // Abre una ventana diferente o realiza acciones específicas para el rango 2
                }
                else if (rango == 3)
                {
                    Alumno alumno = new Alumno();
                    alumno.Show();
                    // Abre una ventana diferente o realiza acciones específicas para el rango 3
                }
                else
                {
                    // Manejar otros valores de "RANGO" aquí si es necesario
                }
            }
            else
            {
                MessageBox.Show("Login Incorrecto", "Sistema");
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
       
        }

        private void btningre_Click(object sender, EventArgs e)
        {
            login(usuario.Text, this.contra.Text);
        }

        private void bntsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void regis_Click(object sender, EventArgs e)
        {
            Form formulario=new RegistrarUsuario();
            formulario.Show();
            this.Hide();
        }
    }
}
