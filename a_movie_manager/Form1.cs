namespace a_movie_manager
{
    public partial class Form1 : Form
    {
        MovieManager mm = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // apri form
            Form2 form2 = new();
            if (form2.ShowDialog() == DialogResult.OK)
            {
                
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }

        private void viewButton_Click(object sender, EventArgs e)
        {

        }
    }
}
