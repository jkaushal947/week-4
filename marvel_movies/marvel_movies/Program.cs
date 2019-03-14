using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marvel_movies
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> marvelmovies = new Dictionary<string, int>()
            {
                {"Iron Man", 2008},
                {"Iron Man 2", 2010},
                {"Captain America: The First Avenger", 2011},
                {"Thor", 2011},
                {"Avengers Assemble", 2012},
                {"Iron Man 3", 2013},
                {"Thor: The Dark World", 2014},
                {"Captain America: The Winter Soldier", 2014},
                {"Guardians of the Galaxy", 2014},
                {"Avengers: Age of Ultron", 2015},
                {"Ant-Man", 2015},
                {"Civil War", 2016},
                {"Doctor Strange", 2016},
                {"Guardians of the Galaxy Vol 2.", 2014},
                {"Spiderman: Homecoming", 2017},
                {"Thor: Ragnarok", 2017},
                {"Black Panther", 2018},
                {"Avengers: Infinity War", 2018},
                {"Ant-Man & The Wasp", 2018},
                {"Captain Marvel", 2019}
            };

        Start:
            Console.WriteLine("Do you want to do one of the following: Add, Remove or Search");
            string input = Console.ReadLine();


            switch (input)
            {
                case "Add":
                    AddNewMovie(marvelmovies);
                    LoopOver(marvelmovies);
                    Console.WriteLine("\n");
                    goto Start;
                case "Remove":
                    RemoveMovie(marvelmovies);
                    LoopOver(marvelmovies);
                    Console.WriteLine("\n");
                    goto Start;
                case "Search":
                    SearchMovie(marvelmovies);
                    LoopOver(marvelmovies);
                    Console.WriteLine("\n");
                    goto Start;
                default:
                    Console.WriteLine("Please input any key and value");
                    Console.WriteLine("\n");
                    goto Start;
            }
        }


        static Dictionary<string, int> AddNewMovie(Dictionary<string, int> marvelmovies)
        {
            Console.WriteLine("Enter the name of the new movie");
            string NewMovie = Console.ReadLine();
            Console.WriteLine("Enter the year the movie is released");
            int ReleaseYear = Console.Read();
            marvelmovies.Add(NewMovie, ReleaseYear);
            return (marvelmovies);
        }

        static Dictionary<string, int> RemoveMovie(Dictionary<string, int> marvelmovies)
        {
            Console.WriteLine("Please remove a movie title");
            string removemovie = Console.ReadLine();
            marvelmovies.Remove(removemovie);
            return (marvelmovies);
        }

        static void SearchMovie(Dictionary<string, int> marvelmovies)
        {
            Console.WriteLine("Search the name of a movie");
            string seekmovie = Console.ReadLine();
            //Console.WriteLine("Search for a year");
            //int seekyear = Console.Read();
            bool movieavailable = marvelmovies.ContainsKey(seekmovie);
            //bool yearavailable = marvelmovies.ContainsValue(seekyear);

            if (movieavailable == true)
            {
                Console.WriteLine(seekmovie + " is listed. \n");
            }
            else
            {
                Console.WriteLine(seekmovie + " isn’t listed. \n");
            }
        }

        static void LoopOver(Dictionary<string, int> marvelmovies)
        {
            foreach (KeyValuePair<string, int> movieinfo in marvelmovies)
            {
                Console.WriteLine("Movie: " +  movieinfo.Key  +  "\n" + "Year: "  +  movieinfo.Value);
            }
        }
    }
}