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
        private void Login(string text, string text1)
        {
            if (string.IsNullOrWhiteSpace(usuario.Text) || string.IsNullOrWhiteSpace(contra.Text))
            {
                MessageBox.Show("Por favor, complete ambos campos de usuario y contraseña", "Sistema");
            }
            else
            {
                SqlConnection cn = new SqlConnection(@"Data Source=(localdb)\LOGIN;Initial Catalog=LOGIN;Integrated Security=True");
                cn.Open();
                SqlCommand cm = new SqlCommand("select IDUsuario, CONTRA from SESION where IDUsuario='" + usuario.Text + "'and CONTRA='" + contra.Text + "'", cn);
                SqlDataReader dr = cm.ExecuteReader();
                if (dr.Read())
                {
                    this.Hide();
                    UsuarioCorrecto formUsuarioCorrecto = new UsuarioCorrecto(usuario.Text, contra.Text);
                    formUsuarioCorrecto.Show();
                }
                else
                {
                    MessageBox.Show("Login Incorrecto", "Sistema");
                }
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
            Login(usuario.Text, this.contra.Text);
        }
        private void bntsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void usuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}