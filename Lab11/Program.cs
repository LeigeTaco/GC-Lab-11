using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab11
{

    class Program
    {

        static int TotalMovies(Dictionary<byte, List<Movie>> lookup)
        {

            int totalMovies = 0;

            for (byte i = 0; i < lookup.Count; i++)
            {

                foreach (Movie mov in lookup[i])
                {

                    totalMovies++;

                }

            }

            return totalMovies;

        }

        static Dictionary<byte, List<Movie>> MovieSort(Dictionary<byte, List<Movie>> lookup)
        {

            for (byte i = 0; i < lookup.Count; i++)
            {

                lookup[i] = lookup[i].OrderBy(o => o.Title).ToList();

                //foreach (Movie m in lookup[i])
                //{

                //    Console.WriteLine(m.Title);

             }         //Debug
            
                return lookup;

        }

        static byte ValidRef(Dictionary<string, byte> REF)
        {

            byte choice = 0;

            do
            {

                Console.WriteLine("Please enter the movie genre you'd like to view.");

                try
                {

                    choice = REF[Console.ReadLine().ToLower()];

                }
                catch (Exception e)
                {

                    Console.WriteLine($"Error: {e.Message}");

                }

            } while (choice > REF.Count);

            return choice;

        }

        static void QueryByGenre(Dictionary<string, byte> REF, Dictionary<byte, List<Movie>> LIB)
        {

            foreach (Movie mov in LIB[ValidRef(REF)])
            {

                Console.WriteLine(mov.Title);

            }

        }

        static bool Again()
        {

            string choice = "";

            while (true)
            {

                Console.WriteLine("Would you like to continue? (Y/N)");
                choice = Console.ReadLine();

                try
                {

                    if (Regex.IsMatch(choice, @"[yY]"))
                    {

                        return true;

                    }
                    else if (Regex.IsMatch(choice, @"[Nn]"))
                    {

                        return false;

                    }
                    else
                    {

                        Console.WriteLine("Whoops! " + choice);

                    }

                }
                catch (Exception e)
                {

                    Console.WriteLine("Invalid entry! " + e.Message);

                }

            }

        }


        static void Main(string[] args)
        {

            #region Data Storage
            Dictionary<string, byte> reference = new Dictionary<string, byte>();
            reference.Add("adam sandler", 0);
            reference.Add("action", 1);
            reference.Add("comedy", 2);
            reference.Add("romance", 3);
            reference.Add("horror", 4);
            reference.Add("documentary", 5);
            reference.Add("animated", 6);
            reference.Add("adventure", 7);
            reference.Add("thriller", 8);
            reference.Add("crime", 9);
            reference.Add("western", 10);
            reference.Add("musical", 11);
            reference.Add("noir", 12);
            reference.Add("sports", 13);
            reference.Add("mystery", 14);
            reference.Add("scifi", 15);
            reference.Add("drama", 16);

            Dictionary<byte, List<Movie>> lookup = new Dictionary<byte, List<Movie>>();
            lookup.Add(0, new List<Movie>());       //Adam Sandler
            lookup.Add(1, new List<Movie>());       //Action
            lookup.Add(2, new List<Movie>());       //Comedy
            lookup.Add(3, new List<Movie>());       //Romance
            lookup.Add(4, new List<Movie>());       //Horror
            lookup.Add(5, new List<Movie>());       //Documentary
            lookup.Add(6, new List<Movie>());       //Animated
            lookup.Add(7, new List<Movie>());       //Adventure
            lookup.Add(8, new List<Movie>());       //Thriller
            lookup.Add(9, new List<Movie>());       //Crime
            lookup.Add(10, new List<Movie>());      //Western
            lookup.Add(11, new List<Movie>());      //Musical
            lookup.Add(12, new List<Movie>());      //Noir
            lookup.Add(13, new List<Movie>());      //Sports
            lookup.Add(14, new List<Movie>());      //Mystery
            lookup.Add(15, new List<Movie>());      //Sci-fi
            lookup.Add(16, new List<Movie>());      //Drama

            #region Adam Sandler
            lookup[0].Add(new Movie());
            lookup[0].Add(new Movie("Grown Ups", 0));
            #endregion

            #region Action
            lookup[1].Add(new Movie("Baby Driver", 1));
            lookup[1].Add(new Movie("Avengers", 1));
            lookup[1].Add(new Movie("Avengers: Age of Ultron", 1));
            lookup[1].Add(new Movie("Avengers: Infinity War", 1));
            #endregion

            #region Comedy
            lookup[2].Add(new Movie("The Naked Gun", 2));
            lookup[2].Add(new Movie("Airplane", 2));
            lookup[2].Add(new Movie("Airplane 2", 2));
            #endregion

            #region Romance
            lookup[3].Add(new Movie("Warm Bodies", 3));
            #endregion

            #region Horror
            lookup[4].Add(new Movie("It", 4));
            lookup[4].Add(new Movie("Get Out", 4));
            #endregion

            #region Documentary
            lookup[5].Add(new Movie("Planet Earth", 5));
            lookup[5].Add(new Movie("Planet Earth 2", 5));
            #endregion

            #region Animated
            lookup[6].Add(new Movie("Finding Nemo", 6));
            lookup[6].Add(new Movie("Finding Dori", 6));
            #endregion

            #region Adventure
            lookup[7].Add(new Movie("National Treasure", 7));
            lookup[7].Add(new Movie("National Treasure 2", 7));
            #endregion

            #region Thriller
            lookup[8].Add(new Movie("Micheal Jackson", 8));
            #endregion

            #region Crime
            lookup[9].Add(new Movie("Crime", 9));
            #endregion

            #region Western
            lookup[10].Add(new Movie("Hateful Eight", 10));
            #endregion

            #region Musical
            lookup[11].Add(new Movie("Moulin Rouge", 11));
            #endregion

            #region Noir
            lookup[12].Add(new Movie("Noir", 12));
            #endregion

            #region Sports
            lookup[13].Add(new Movie("42", 13));
            #endregion

            #region Mystery
            lookup[14].Add(new Movie("Scooby-Doo", 14));
            #endregion

            #region Scifi
            lookup[15].Add(new Movie("2001: A Space Odyssey", 15));
            #endregion

            #region Drama
            lookup[16].Add(new Movie("Spotlight", 16));
            #endregion

            #endregion

            lookup = MovieSort(lookup);

            do
            {

                QueryByGenre(reference, lookup);

            } while (Again());

        }

    }

}
