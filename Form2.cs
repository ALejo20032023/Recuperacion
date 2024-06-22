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

namespace examenreupe
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            logins();
        }

        private void logins()
        {
            SqlConnection conn = new SqlConnection("Data Source= ALEJANDRO_13\\SQLEXPRESS ;Initial Catalog= AppMusicDB ;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT Nombre, pass FROM usuarios WHERE Nombre = '" + txtUsuario.Text + "' and pass='" + txtContra.Text + "'", conn);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {

                MessageBox.Show("Inicio de Sesión Exitoso", "Sistema");

                this.Hide();
                Form1 fr = new Form1();
                fr.ShowDialog();

            }
            else
            {

                MessageBox.Show("Los Datos Son Incorrectos", "Sistema");


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();
            txtContra.Clear();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            Form3 registerForm = new Form3();
            registerForm.ShowDialog();
        }
    }
}
