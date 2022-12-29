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
        string placeholder = "Enter an ID...";
        int id;
        public Form1()
        {
            InitializeComponent();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            Utilities.ResetAllControls(this);
            albumBox.Focus();
            searchBox.Text = placeholder;
            searchBox.ForeColor = Color.Silver;
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

        private void showButton_Click(object sender, EventArgs e)
        {
            Utilities.ShowDataGridView(this, dataGridView1, connection);
        }

        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                id = Convert.ToInt32(row.Cells[0].Value);
                searchBox.Text = row.Cells[0].Value.ToString();
                albumBox.Text = row.Cells[1].Value.ToString();
                artistBox.Text = row.Cells[2].Value.ToString();
                genreBox.Text = row.Cells[3].Value.ToString();
                yearOfReleaseBox.Text = row.Cells[4].Value.ToString();
                categoryBox.Text = row.Cells[5].Value.ToString();
            }
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            if (searchBox.Text != placeholder)
            {
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Albums WHERE ID = '" + searchBox.Text + "'", connection);
                var dataTable = new DataTable();
                sqlDa.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }

        private void searchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            searchBox.Text = "";
            searchBox.ForeColor = Color.Black;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.') && !(searchBox.Text == placeholder))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((sender as TextBox).Text.IndexOf('.') > -1 && !(searchBox.Text == placeholder))
            {
                e.Handled = true;
            }
        }
    }
}