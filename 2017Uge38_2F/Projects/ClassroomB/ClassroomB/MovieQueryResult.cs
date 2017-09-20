using System;

namespace ClassroomB
{
    public class MovieQueryResult : IComparable<MovieQueryResult>
    {
        private string _title;
        private int _year;

        public MovieQueryResult(string title, int year)
        {
            _title = title;
            _year = year;
        }

        public string Title
        {
            get { return _title; }
        }

        public int Year
        {
            get { return _year; }
        }

        public int CompareTo(MovieQueryResult other)
        {
            if (Year < other.Year)
            {
                return -1;
            }
            if (Year > other.Year)
            {
                return 1;
            }

            return 0;
        }
    }
}