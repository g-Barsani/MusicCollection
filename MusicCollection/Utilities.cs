using System.Data.SqlClient;
using System.Data;

namespace MusicCollection
{
    public class Utilities
    {
        public static void ResetAllControls(Control form)
        {
            /*
             The Control class implements very basic functionality required by classes 
            that display information to the user. It handles user input through the keyboard 
            and pointing devices. 
            */
            foreach (Control control in form.Controls)
            {
                if (control is TextBox)
                {
                    // Explicit casting
                    var textBox = (TextBox)control;
                    textBox.Text = null;
                }
                if (control is ComboBox)
                {
                    var comboBox = (ComboBox)control;
                    comboBox.SelectedIndex = -1;
                }
            }
        }
        public static void ShowDataGridView(Control form, DataGridView dataGridView1, SqlConnection connection)
        {
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Albums", connection);
            var dataTable = new DataTable();
            sqlDa.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }
    }
}
