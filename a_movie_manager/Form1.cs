using Microsoft.VisualBasic.FileIO;
using System.Text.Json;
using System.Windows.Forms;
using System.Xml;
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
                mm.RemoveMovieAt(listView.SelectedIndices[0]);
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
                        mm.Clear();
                    }
                }
            }
            if (filePath.EndsWith(".txt"))
            {
                foreach(var f in fileContent.Split("\n"))
                {
                    Movie m = new()
                    {
                        Title = f.Split("@@")[0],
                        Description = f.Split("@@")[1],
                        Directors = f.Split("@@")[2].Split("##").ToList(),
                        Year = int.Parse(f.Split("@@")[3]),
                        Duration = int.Parse(f.Split("@@")[4]),
                        Drive = char.Parse(f.Split("@@")[5])
                    };
                    mm.AddMovie(m);
                }
            }
            else if (filePath.EndsWith(".json"))
            {
                JsonDocument jsonDoc = JsonDocument.Parse(fileContent);
                JsonElement root = jsonDoc.RootElement;
                foreach (JsonProperty property in root.EnumerateObject())
                {
                    Movie m = new();
                    JsonElement value = property.Value;
                    m.Title = property.Name.ToString();
                    m.Description = value.GetProperty("Description").ToString();
                    m.Duration = int.Parse(value.GetProperty("Duration").ToString());
                    m.Drive = char.Parse(value.GetProperty("Drive").ToString());
                    m.Year = int.Parse(value.GetProperty("Year").ToString());
                    m.Directors = value.GetProperty("Directors").ToString().Split(",").ToList();
                    mm.AddMovie(m);
                }
                jsonDoc.Dispose();

            }
            else if (filePath.EndsWith(".xml"))
            {
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(fileContent);
                XmlNodeList movieNodes = doc.SelectNodes("//movie");

                foreach (XmlNode movieNode in movieNodes)
                {
                    /*XmlAttribute idAttribute = movieNode.Attributes["id"];
                    string movieId = idAttribute.Value;*/

                    Movie m = new()
                    {
                        Title = movieNode.SelectSingleNode("Title").InnerText,
                        Description = movieNode.SelectSingleNode("Description").InnerText,
                        Directors = movieNode.SelectSingleNode("Directors").InnerText.Split(",").ToList(),
                        Year = int.Parse(movieNode.SelectSingleNode("Year").InnerText),
                        Duration = int.Parse(movieNode.SelectSingleNode("Duration").InnerText),
                        Drive = char.Parse(movieNode.SelectSingleNode("Drive").InnerText)
                    };
                    mm.AddMovie(m);
                }
            }
            else if (filePath.EndsWith(".csv"))
            {
                using (TextFieldParser parser = new TextFieldParser(new StringReader(fileContent)))
                {
                    parser.TextFieldType = FieldType.Delimited;
                    parser.SetDelimiters(",");

                    while (!parser.EndOfData)
                    {
                        string[] fields = parser.ReadLine().Split(",");
                        Movie m = new();
                        m.Title = fields[0];
                        m.Description = fields[1].Replace("|",",");
                        m.Directors = fields[2].Split('@').ToList();
                        m.Year = int.Parse(fields[3]);
                        m.Duration = int.Parse(fields[4]);
                        m.Drive = char.Parse(fields[5]);
                        mm.AddMovie(m);
                    }
                }
            }
            updateListView();
            MessageBox.Show("Succesfully opened");
        }

        private void scanAndAppendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var folderPicker = new FolderBrowserDialog
            {
                Description = "Select a folder"
            };
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
                    if (movie.Directors.Count > 0)
                    {
                        foreach (var director in movie.Directors)
                        {
                            line += director + "##";
                        }
                        line = line.Substring(0, line.Length - 2);
                    }
                    line += "@@";
                    line += movie.Year.ToString() + "@@";
                    line += movie.Duration.ToString() + "@@";
                    line += movie.Drive.ToString() + "\n";
                    content += line;
                }
                content = content.Substring(0, content.Length - 1);
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
                    if (movie.Directors.Count>0)
                    {
                        foreach (var director in movie.Directors)
                        {
                            line += "\"" + director + "\",";
                        }
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
                    if (movie.Directors.Count > 0)
                    {
                        foreach (var director in movie.Directors)
                        {
                            line += director + ",";
                        }
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
                string content = "";
                foreach (var movie in mm.GetMovies())
                {
                    var line = "";
                    line += movie.Title + ",";
                    line += movie.Description.Replace(",","|") + ",";
                    if (movie.Directors.Count > 0)
                    {
                        foreach (var director in movie.Directors)
                        {
                            line += director + "@";
                        }
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
