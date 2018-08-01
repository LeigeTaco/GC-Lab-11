using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{

    class Program
    {

        //static 

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

            #endregion

        }

    }

}
