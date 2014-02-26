using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Best_Movie_Database
{
    class TMovie : IComparable<TMovie>
    {
        public int year;
        private String title;
        private String director;

        public TMovie(int year, String title, String director)
        {
            this.year = year;
            this.title = title;
            this.director = director;
        }

        // Displays the class variables: "Year, Title, Director"
        public override string ToString()
        {
            return year.ToString() + ", " + title + ", " + director;
        }

        // Default comparer for Part type. 
        public int CompareTo(TMovie compareTMovie)
        {
            // A null value means that this object is greater. 
            if (compareTMovie == null)
                return 1;

            else
                return this.year.CompareTo(compareTMovie.year); 
        }
    }
}
