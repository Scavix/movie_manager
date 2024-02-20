using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace a_movie_manager
{
    public partial class Form2 : Form
    {
        private Movie movie;
        public Form2(string title)
        {
            InitializeComponent();
            movie = new Movie();
            Text = title + " form";
            titleTextBox.Text = "";
            directorsTextBox.Text = "";
            durationTextBox.Text = "0";
            driveTextBox.Text = "E";
            yearTextBox.Text = "0";
            descriptionRichTextBox.Text = "";
        }
        public Form2(string title, Movie m)
        {
            InitializeComponent();
            movie = new Movie();
            Text = title + " form";
            titleTextBox.Text = m.Title;
            directorsTextBox.Text = string.Join(", ", m.Directors);
            durationTextBox.Text = m.Duration.ToString();
            driveTextBox.Text = m.Drive.ToString();
            yearTextBox.Text = m.Year.ToString();
            descriptionRichTextBox.Text = m.Description.ToString();
        }
        private void okButton_Click(object sender, EventArgs e)
        {
            movie.Title = titleTextBox.Text;
            movie.Directors = directorsTextBox.Text.Split(',').ToList();
            movie.Duration = int.Parse(durationTextBox.Text);
            movie.Drive = char.Parse(driveTextBox.Text);
            movie.Year = int.Parse(yearTextBox.Text);
            movie.Description = descriptionRichTextBox.Text;
        }
        public Movie GetMovie() => movie;
    }
}