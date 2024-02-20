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
    public partial class Form3 : Form
    {
        public Form3(Movie m)
        {
            InitializeComponent();
            titleLabel.Text = m.Title;
            directorsLabel.Text = string.Join(", ", m.Directors);
            durationLabel.Text = m.Duration.ToString();
            driveLabel.Text = m.Drive.ToString();
            yearLabel.Text = m.Year.ToString();
            descriptionRichTextBox.Text = m.Description.ToString();
        }
    }
}
