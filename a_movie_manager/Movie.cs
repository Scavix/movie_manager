using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a_movie_manager
{
    internal class Movie
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public List<string> Directors { get; set; } = [];
        public int Duration { get; set; } = 0;
        public char Drive { get; set; } = 'E';
        public Movie() { }
        public Movie(string title, string description, List<string> directors, int duration, char drive)
        {
            Title = title;
            Description = description;
            Directors = directors;
            Duration = duration;
            Drive = drive;
        }
    }
}
