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
        private void registrar_Click(object sender, EventArgs e)
        {
            login(this.nomb.Text);
        }
        private void login(string text)
        {
            string connectionString = @"Data Source=(localdb)\LOGIN;Initial Catalog=LOGIN;Integrated Security=True";
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                string nombreUsuario = nomb.Text;
                string contraseña = contr.Text;
                if (string.IsNullOrWhiteSpace(nombreUsuario) || string.IsNullOrWhiteSpace(contraseña))
                {
                    MessageBox.Show("Por favor, complete todos los campos", "Sistema");
                }
                else
                {
                    cn.Open();
                SqlCommand checkUserCmd = new SqlCommand("SELECT COUNT(*) FROM SESION WHERE IDUsuario = @IDUsuario", cn);
                checkUserCmd.Parameters.AddWithValue("@IDUsuario", nomb.Text);
                int userCount = (int)checkUserCmd.ExecuteScalar();
                    if (userCount > 0)
                    {
                        MessageBox.Show("Este usuario ya está en nuestro sistema, intente uno nuevo", "Sistema");
                    }
                    else
                    {
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
        }
            private void RegistrarUsuario_Load(object sender, EventArgs e)
            {
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            Form formulario = new Form1();
            formulario.Show();
            this.Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    } 
}