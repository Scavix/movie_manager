using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a_movie_manager
{
    public class Movie
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public List<string> Directors { get; set; } = [];
        public int Duration { get; set; } = 0;
        public int Year { get; set; } = 0;
        public char Drive { get; set; } = 'E';
        public Movie() { }
        public Movie(string title, string description, List<string> directors, int duration, int year, char drive)
        {
            Title = title;
            Description = description;
            Directors = directors;
            Duration = duration;
            Year = 0;
            Drive = drive;
        }
    }
}
