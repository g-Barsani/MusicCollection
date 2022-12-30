using System.Data.SqlClient;
using System.Data;

namespace MusicCollection
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=SAMSUNG\SQLEXPRESS;
Initial Catalog=MusicCollection;Integrated Security=True;");
        SqlCommand command;
        string placeholder = "Enter an ID...";
        int id;
        public Form1()
        {
            InitializeComponent();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
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
            // Disable sort in dataGridView1
            foreach (DataGridViewColumn column in dataGridView1.Columns)
                column.SortMode = DataGridViewColumnSortMode.NotSortable;

            // Do the code below if the user didn't click on a header
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                id = Convert.ToInt32(row.Cells[0].Value);
                albumBox.Text = row.Cells[1].Value.ToString();
                artistBox.Text = row.Cells[2].Value.ToString();
                genreBox.Text = row.Cells[3].Value.ToString();
                yearOfReleaseBox.Text = row.Cells[4].Value.ToString();
                categoryBox.Text = row.Cells[5].Value.ToString();
                searchBox.Text = id.ToString();
            }
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            if (searchBox.Text != placeholder && !searchBox.Text.Contains('.'))
            {
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Albums WHERE ID = '" + searchBox.Text + "'", connection);
                var dataTable = new DataTable();
                sqlDa.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }

        private void searchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            searchBox.MaxLength = 5;
            if (searchBox.Text == placeholder)
            {
                searchBox.Text = "";
            }
            searchBox.ForeColor = Color.Black;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.') && !(searchBox.Text == placeholder))
            {
                e.Handled = true;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string sqlCommand = "DELETE FROM Albums WHERE ID = " + id + "";
                SqlCommand command = new SqlCommand(sqlCommand, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Record deleted successfully.");
                Utilities.ResetAllControls(this);
                searchBox.Text = "Enter an ID...";
                albumBox.Focus();

                Utilities.ShowDataGridView(this, dataGridView1, connection);
            }

            finally
            {
                connection.Close();
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (searchBox.Text != placeholder && !searchBox.Text.Contains('.') && searchBox.Text != "")
            {
                connection.Open();
                SqlCommand commandToCheckProductId = new SqlCommand("SELECT * FROM Albums WHERE ID = '" + searchBox.Text + "'", connection);
                // Convert.ToString() method handles null
                string albumId = Convert.ToString(commandToCheckProductId.ExecuteScalar());  // Get the value from the first column (ID)
                if (albumId == searchBox.Text)
                {
                    try
                    {
                        //connection.Open();
                        string sqlCommand = "UPDATE Albums SET Album = '" + albumBox.Text + "', Artist = '" + artistBox.Text + "', Genre = '" + genreBox.Text + "', YearOfRelease = '" + yearOfReleaseBox.Text + "', Category = '" + categoryBox.Text + "' WHERE ID = '" + searchBox.Text + "'";
                        SqlDataAdapter sqlDa = new SqlDataAdapter(sqlCommand, connection);
                        sqlDa.SelectCommand.ExecuteNonQuery();
                        MessageBox.Show("Record updated successfully.");

                        Utilities.ShowDataGridView(this, dataGridView1, connection);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
                else
                {
                    MessageBox.Show("This ID does not match any record.");
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Can't update with an invalid ID.");
                connection.Close();
            }
        }
    }   
 }