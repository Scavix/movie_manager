using Microsoft.VisualBasic.FileIO;
using System.Text.Json;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
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
                lvi.SubItems.Add(mm.GetMovie(i).Duration.ToString());
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
                openFileDialog.Filter = "Text files (*.txt)|*.txt|JSON files (*.json)|*.json|XML files (*.xml)|*.xml|CSV files (*.csv)|*.csv";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
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

        private void scanAndAppendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var folderPicker = new FolderBrowserDialog();
            folderPicker.Description = "Select a folder";
            DialogResult result = folderPicker.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderPicker.SelectedPath))
            {
                var txtFiles = Directory.GetFiles(folderPicker.SelectedPath, "*.txt");
                foreach (var file in txtFiles)
                {
                    Movie m = new()
                    {
                        Title = file.ToString().Split("\\").Last().Split(".").First()
                    };
                    mm.AddMovie(m);
                }
                updateListView();
            }
            else
            {
                MessageBox.Show("No folders selected");
            }
        }

        private void txtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new()
            {
                DefaultExt = "txt",
                Filter = "Text files (*.txt)|*.txt",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                FileName = "MyMovieArchive"
            };
            DialogResult result = sfd.ShowDialog();

            if (result == DialogResult.OK)
            {
                string fileName = sfd.FileName;
                string content = "";
                foreach(var movie in mm.GetMovies())
                {
                    var line = "";
                    line += movie.Title+"@@";
                    line += movie.Description + "@@";
                    foreach(var director in movie.Directors)
                    {
                        line += director + "##";
                    }
                    line += "@@";
                    line += movie.Year.ToString() + "@@";
                    line += movie.Duration.ToString() + "@@";
                    line += movie.Drive.ToString() + "\n";
                    content += line;
                }
                try
                {
                    File.WriteAllText(fileName, content);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving the file: " + ex.Message);
                }
                MessageBox.Show(fileName + " has been saved");
            }
            else
            {
                MessageBox.Show("Save operation cancelled");
            }
        }

        private void jsonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new()
            {
                DefaultExt = "json",
                Filter = "JSON files (*.json)|*.json",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                FileName = "MyMovieArchive"
            };
            DialogResult result = sfd.ShowDialog();

            if (result == DialogResult.OK)
            {
                string fileName = sfd.FileName;
                string content = "{";
                foreach (var movie in mm.GetMovies())
                {
                    var line = "";
                    line += "\"" + movie.Title + "\"" + ":{";
                    line += "\"Description\":\"" + movie.Description + "\",";
                    line += "\"Directors\":[";
                    foreach (var director in movie.Directors)
                    {
                        line += "\""+director+ "\",";
                    }
                    if (movie.Directors.Count>0)
                    {
                        line = line.Substring(0, line.Length - 1);
                    }
                    line += "],";
                    line += "\"Year\":" + movie.Year.ToString() + ",";
                    line += "\"Duration\":" + movie.Duration.ToString() + ",";
                    line += "\"Drive\":\"" + movie.Drive.ToString() + "\"},";
                    content += line;
                }
                content = content.Substring(0, content.Length - 1);
                content += "}";
                try
                {
                    File.WriteAllText(fileName, content);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving the file: " + ex.Message);
                }
                MessageBox.Show(fileName + " has been saved");
            }
            else
            {
                MessageBox.Show("Save operation cancelled");
            }
        }

        private void xmlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new()
            {
                DefaultExt = "xml",
                Filter = "XML files (*.xml)|*.xml",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                FileName = "MyMovieArchive"
            };
            DialogResult result = sfd.ShowDialog();

            if (result == DialogResult.OK)
            {
                string fileName = sfd.FileName;
                string content = "<?xml version=\"1.0\"?>\n<movies>\n";
                int id_counter = 0;
                foreach (var movie in mm.GetMovies())
                {
                    var line = "<movie id=\"mv"+id_counter+ "\">\n";
                    line += "<Title>" + movie.Title + "</Title>\n";
                    line += "<Description>" + movie.Description + "</Description>\n";
                    line += "<Directors>";
                    foreach (var director in movie.Directors)
                    {
                        line += director + ",";
                    }
                    if (movie.Directors.Count > 0)
                    {
                        line = line.Substring(0, line.Length - 1);
                    }
                    line += "</Directors>\n";
                    line += "<Year>" + movie.Year.ToString() + "</Year>\n";
                    line += "<Duration>" + movie.Duration.ToString() + "</Duration>\n";
                    line += "<Drive>" + movie.Drive.ToString() + "</Drive>\n";
                    line += "</movie>\n";
                    content += line;
                }
                content += "</movies>";
                try
                {
                    File.WriteAllText(fileName, content);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving the file: " + ex.Message);
                }
                MessageBox.Show(fileName + " has been saved");
            }
            else
            {
                MessageBox.Show("Save operation cancelled");
            }
        }

        private void csvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new()
            {
                DefaultExt = "csv",
                Filter = "CSV files (*.csv)|*.csv",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                FileName = "MyMovieArchive"
            };
            DialogResult result = sfd.ShowDialog();

            if (result == DialogResult.OK)
            {
                string fileName = sfd.FileName;
                string content = "\"Title\",\"Description\",\"Directors\",\"Year\",\"Duration\",\"Drive\"\n";
                foreach (var movie in mm.GetMovies())
                {
                    var line = "";
                    line += movie.Title + ",";
                    line += movie.Description + ",";
                    foreach (var director in movie.Directors)
                    {
                        line += director + "@";
                    }
                    if (movie.Directors.Count > 0)
                    {
                        line = line.Substring(0, line.Length - 1);
                    }
                    line += ",";
                    line += movie.Year.ToString() + ",";
                    line += movie.Duration.ToString() + ",";
                    line += movie.Drive.ToString();
                    line += "\n";
                    content += line;
                }
                try
                {
                    File.WriteAllText(fileName, content);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving the file: " + ex.Message);
                }
                MessageBox.Show(fileName + " has been saved");
            }
            else
            {
                MessageBox.Show("Save operation cancelled");
            }
        }
    }
}
