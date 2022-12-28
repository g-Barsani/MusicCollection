namespace MusicCollection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            Utilities.ResetAllControls(this);
            albumBox.Focus();
        }
    }
}