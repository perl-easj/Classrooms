using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassroomB
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Actor, Movie and Studio objects

            Actor a1 = new Actor("Alfred");
            Actor a2 = new Actor("Birgit");
            Actor a3 = new Actor("Carl");
            Actor a4 = new Actor("David");
            Actor a5 = new Actor("Eric");
            Actor a6 = new Actor("Farah");
            Actor a7 = new Actor("George");

            Movie m1 = new Movie("Se7en", 1995, 127, "New Line Cinema", new List<Actor> { a1, a4, a6 });
            Movie m2 = new Movie("Alien", 1979, 117, "20th Century Fox", new List<Actor> { a4, a7 });
            Movie m3 = new Movie("Forrest Gump", 1994, 142, "Paramount Pictures", new List<Actor> { a1, a2, a3, a4, a6 });
            Movie m4 = new Movie("True Grit", 2010, 110, "Paramount Pictures", new List<Actor> { a1, a3, a6, a7 });
            Movie m5 = new Movie("Dark City", 1998, 111, "New Line Cinema", new List<Actor> { a3, a4 });

            Studio s1 = new Studio("New Line Cinema", "Boston", 4000);
            Studio s2 = new Studio("20th Century Fox", "New York", 2500);
            Studio s3 = new Studio("Paramount Pictures", "New York", 8000);

            List<Movie> movies = new List<Movie> { m1, m2, m3, m4, m5 };
            List<Studio> studios = new List<Studio> { s1, s2, s3 };

            #endregion


            #region Single-property select

            var titles = from m in movies
                         select m.Title;


            Console.WriteLine("Movie titles");
            Console.WriteLine("------------------------");
            foreach (var element in titles)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine();

            #endregion


            #region Multi-property select

            var titlesAndYears = from m in movies
                                 select new {m.Title, m.Year};

            Console.WriteLine("Movie titles and years");
            Console.WriteLine("------------------------");
            foreach (var element in titlesAndYears)
            {
                Console.WriteLine($"{element.Title} from {element.Year}");
            }
            Console.WriteLine();

            #endregion


            #region Select with filtering

            var filtered = from m in movies
                           where m.Year < 1996
                           select new { m.Title, m.Year };

            Console.WriteLine("Movie titles and years (before 1996)");
            Console.WriteLine("------------------------");
            foreach (var element in filtered)
            {
                Console.WriteLine($"{element.Title} from {element.Year}");
            }
            Console.WriteLine();

            #endregion


            #region Select with filtering and ordering

            var ordered = from m in movies
                          where m.Year < 1996
                          orderby m.Year
                          select new { m.Title, m.Year };

            Console.WriteLine("Movie titles and years (before 1996 - ordered)");
            Console.WriteLine("------------------------");
            foreach (var element in ordered)
            {
                Console.WriteLine($"{element.Title} from {element.Year}");
            }
            Console.WriteLine();

            #endregion


            #region Aggregate functions

            var titlesAgain = from m in movies
                              select m.Title;

            Console.WriteLine($"A total of {titlesAgain.Count()} movies");
            Console.WriteLine($"A total of {(from m in movies where m.Year < 1996 select m.Title).Count()} movies");
            Console.WriteLine($"Average year: {(from m in movies select m.Year).Average()} (?)");
            //Console.WriteLine($"Average title: {(from m in movies select m.Title).Average()} (???)");
            Console.WriteLine($"Maximal title: {(from m in movies select m.Title).Max()} (?)");
            Console.WriteLine();
            Console.ReadKey();

            #endregion


            #region Collection-property select

            var titlesAndActors = from m in movies
                                  select new { m.Title, m.Actors};

            Console.WriteLine("Movie titles and actors");
            Console.WriteLine("------------------------");
            foreach (var element in titlesAndActors)
            {
                Console.WriteLine($"{element.Title}");
                foreach (var actor in element.Actors)
                {
                    Console.WriteLine($"  {actor}");
                }
            }
            Console.WriteLine();

            #endregion


            #region Selection with join

            var joinTitleStudio = from m in movies
                                  join s in studios
                                  on m.StudioName equals s.StudioName
                                  where s.HqCity == "New York"
                                  select m.Title;

            Console.WriteLine("Movie titles from studio in New York");
            Console.WriteLine("------------------------");
            foreach (var element in joinTitleStudio)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine();


            #endregion


            Console.WriteLine("Done - press any key to shut down the app");
            Console.ReadKey();
        }
    }
}
