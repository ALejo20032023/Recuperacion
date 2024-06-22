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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            RegisterUser();
        }

        private void RegisterUser()
        {
            using (SqlConnection conn = new SqlConnection("Data Source=ALEJANDRO_13\\SQLEXPRESS;Initial Catalog=AppMusicDB;Integrated Security=True"))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO usuarios (Nombre, pass) VALUES (@Nombre, @Pass)", conn))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", txtNewUsuario.Text);
                        cmd.Parameters.AddWithValue("@Pass", txtNewContra.Text);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Usuario registrado con éxito", "Sistema");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Error al registrar el usuario", "Sistema");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Sistema");
                }
            }
        }
    }
}
