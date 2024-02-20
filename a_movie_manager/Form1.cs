using Microsoft.VisualBasic.FileIO;
using System.Text.Json;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace a_movie_manager
{
    public partial class Form1 : Form
    {
        MovieManager mm = new();
        string fileContent = string.Empty;
        string filePath = string.Empty;
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
            mm.RemoveMovieAt(listView.SelectedIndices[0]);
            updateListView();
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            Form3 form3 = new(mm.GetMovie(listView.SelectedIndices[0]));
            form3.ShowDialog();
        }

        private void updateListView()
        {
            listView.Items.Clear();
            for (int i = 0; i < mm.GetMovies().Count; i++)
            {
                ListViewItem lvi = new(mm.GetMovie(i).Title);
                lvi.SubItems.Add(mm.GetMovie(i).Year.ToString());
                lvi.SubItems.Add(mm.GetMovie(i).Drive.ToString());
                listView.Items.Add(lvi);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox1 = new();
            aboutBox1.ShowDialog();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mm.Clear();
            updateListView();
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                openFileDialog.Filter = "JSON files (*.json)|*.json|XML files (*.xml)|*.xml|CSV files (*.csv)|*.csv|Database files (*.db)|*.db|Data files (*.dat)|*.dat";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }
            if (filePath.EndsWith(".json"))
            {
                Movie m = new();
                JsonDocument jsonDoc = JsonDocument.Parse(fileContent);
                JsonElement root = jsonDoc.RootElement;
                m.Title = root.GetProperty("Title").ToString();
                m.Description = root.GetProperty("Description").ToString();
                m.Duration = int.Parse(root.GetProperty("Duration").ToString());
                m.Drive = char.Parse(root.GetProperty("Drive").ToString());
                m.Year = int.Parse(root.GetProperty("Year").ToString());
                m.Directors = root.GetProperty("Directors").ToString().Split(",").ToList();
            }
            else if (filePath.EndsWith(".xml"))
            {
                Movie m = new();

            }
            else if (filePath.EndsWith(".csv"))
            {
                Movie m = new();
                using (TextFieldParser parser = new TextFieldParser(new StringReader(fileContent)))
                {
                    parser.TextFieldType = FieldType.Delimited;
                    parser.SetDelimiters(",");
                    while (!parser.EndOfData)
                    {
                        string[] fields = parser.ReadFields();
                        foreach (string field in fields)
                        {
                            MessageBox.Show(field);
                        }
                    }
                }
            }
            else if (filePath.EndsWith(".db"))
            {

            }
            else if (filePath.EndsWith(".dat"))
            {

            }
            //MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
