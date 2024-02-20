using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace a_movie_manager
{
    public partial class Form1 : Form
    {
        MovieManager mm = new();
        public Form1()
        {
            InitializeComponent();
            updateListView();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new("Add");
            if (form2.ShowDialog() == DialogResult.OK)
            {
                Movie m = form2.GetMovie();
                mm.AddMovie(m);
                updateListView();
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new("Edit", mm.GetMovie(listView.SelectedIndices[0]));
            if (form2.ShowDialog() == DialogResult.OK)
            {
                Movie m = form2.GetMovie();
                mm.AddMovie(m);
                updateListView();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }

        private void viewButton_Click(object sender, EventArgs e)
        {

        }

        private void updateListView()
        {
            listView.Items.Clear();
            for (int i = 0;i< mm.GetMovies().Count; i++)
            {
                ListViewItem lvi = new(mm.GetMovie(i).Title);
                lvi.SubItems.Add(mm.GetMovie(i).Year.ToString());
                lvi.SubItems.Add(mm.GetMovie(i).Drive.ToString());
                listView.Items.Add(lvi);
            }
        }
    }
}
