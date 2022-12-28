using System.Data.SqlClient;
using System.Data;
namespace MusicCollection
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=SAMSUNG\SQLEXPRESS;
Initial Catalog=MusicCollection;Integrated Security=True;");
        SqlCommand command;
        DataTable table;
        public Form1()
        {
            InitializeComponent();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            Utilities.ResetAllControls(this);
            albumBox.Focus();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Insert data
                connection.Open();
                string sqlCommand = @"INSERT INTO Albums VALUES('" + albumBox.Text + "','" + artistBox.Text + "','" + genreBox.Text + "','" + yearOfReleaseBox.Text + "', '" + categoryBox.Text + "')";
                command = new SqlCommand(sqlCommand, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Data inserted in Database.");

                Utilities.ShowDataGridView(this, dataGridView1, connection);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}