using System.Data;
using System.Data.SqlClient;
namespace examenreupe
{
    public partial class Form1 : Form
    {
        string connectionString = "Data Source= ALEJANDRO_13\\SQLEXPRESS ;Initial Catalog= AppMusicDB ;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregarCan_Click(object sender, EventArgs e)
        {
            System.String cancion = txtagregarc.Text;

            using (var connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO canciones (Nombre) VALUES (@cancion)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@cancion", cancion);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }

            LoadCanciones();
        }
        private void LoadCanciones()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM canciones";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }

        private void btnAgregarPlay_Click_1(object sender, EventArgs e)
        {
            int CancionID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            //int cantidad = Convert.ToInt32(txtCantidad.Text);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Playlist (CancionID) VALUES (@CancionID)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CancionID", CancionID);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }

            MessageBox.Show("Tu playlist está lista");
        }


        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT P.playlistID, C.Nombre FROM P Playlist INNER JOIN Canciones C ON P.CancionID = C.CancionID";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView2.DataSource = table;

            }
        }

        private void LoadPlaylist()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT P.playlistID, C.Nombre FROM Playlist P INNER JOIN canciones C ON P.CancionID = C.CancionID";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView2.DataSource = table;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadPlaylist();
        }

        private void btnEliminarPlay_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow != null)
            {
                int playlistID = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Playlist WHERE playlistID = @playlistID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@playlistID", playlistID);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }

                MessageBox.Show("Playlist eliminada.");
                LoadPlaylist();
            }
            else
            {
                MessageBox.Show("Selecciona una playlist para eliminar.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}