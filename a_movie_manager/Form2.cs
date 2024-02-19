using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace a_movie_manager
{
    public partial class Form2 : Form
    {
        Movie movie { get; set; } = new();
        public Form2()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            movie.Title = titleTextBox.Text;
            movie.Directors = directorsTextBox.Text.Split(',').ToList();
            movie.Duration = int.Parse(durationTextBox.Text);
            movie.Drive = char.Parse(driveTextBox.Text);
            movie.Description = descriptionRichTextBox.Text;
        }
    }
}
