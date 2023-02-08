using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesLab
{
    public class Movie
    {
        public int id;
        public string? category;
        public string? title;
        public int? hours;
        public int? YearReleased;
        public string? description;

        public Movie(int id,string? category, string? title, int hours, int year, string Descr)
        {
            this.category = category;
            this.title = title;
            this.id = id;
            this.hours= hours;
            this.YearReleased = year;
            this.description = Descr;
            
        }
        
        
    }
}
