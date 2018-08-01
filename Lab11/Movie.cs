using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{

    class Movie
    {

        private string title;
        private byte category;

        public string Title
        {

            set { title = value; }
            get { return title; }

        }

        public byte Category
        {

            set { category = value; }
            get { return category; }

        }

        public string CategoryToString()
        {

            switch (category)
            {

                case 0:
                    return "Adam Sandler";
                case 1:
                    return "Action";
                case 2:
                    return "Comedy";
                case 3:
                    return "Romance";
                case 4:
                    return "Horror";
                case 5:
                    return "Documentary";
                case 6:
                    return "Animated";
                case 7:
                    return "Adventure";
                case 8:
                    return "Thriller";
                case 9:
                    return "Crime";
                case 10:
                    return "Western";
                case 11:
                    return "Musical";
                case 12:
                    return "Noir";
                case 13:
                    return "Sports";
                case 14:
                    return "Mystery";
                case 15:
                    return "Sci-fi";
                default:
                    return "Adam Sandler";

            }

        }

        public void StringToCategory(Dictionary<string, byte> refernce, string cat)
        {

            try
            {

                Console.WriteLine($"Genre found: {cat} ID {reference[cat]}");
                Category = reference[cat.ToLower()];

            }
            catch
            {

                Console.WriteLine("We could not find that genre, defaulting to \"Adam Sandler\"");
                Category = 0;

            }

        }

        public Movie()
        {

            Title = "The Cobbler";
            Category = 0;

        }

        public Movie(string title, byte cat)
        {

            Title = title;
            Category = cat;

        }

    }

}
