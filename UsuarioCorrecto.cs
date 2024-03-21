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
    public partial class UsuarioCorrecto : Form
    {
        private string nombreUsuario;
        private string contraseña;
        public UsuarioCorrecto(string IDUsuario, string contra)
        {
            InitializeComponent();
            this.nombreUsuario = IDUsuario;
            this.contraseña = contra;
        }

        private void UsuarioCorrecto_Load(object sender, EventArgs e)
        {
            NombrUsu.Text = "Bienvenido, " + nombreUsuario + "!";
            NombContra.Text = "Aqui te mostramos tu contraseña: '" + contraseña + "'.";
        }

        private void NombrUsu_Click(object sender, EventArgs e)
        {
           
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void contra_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 formInicioSesion = new Form1();
            formInicioSesion.Show();
            this.Hide(); 
        }
    }
}
