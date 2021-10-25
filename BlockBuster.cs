using System;
using System.Collections.Generic;
using System.Text;

namespace BlockBusterLab
{
    class BlockBuster
    {
        List<string> scenes = new List<string>();

        List<Movie> movies = new List<Movie>();



        Movie movieOne = new Movie("Star Wars", "Sci-fi", 92);
        Movie movieTwo = new Movie("Deep Blue Sea", "Horror", 92);
        Movie movieThree = new Movie("Avengers End Game", "Action", 92);
        Movie movieFour = new Movie("Batman Dark Knight", "Action", 92);
        Movie movieFive = new Movie("Lottery Ticket", "Comedy", 92);
        Movie movieSix = new Movie("Friday", "Comedy", 92);







        public void PrintMovies()
        {
            for (int i = 0; i < movies.Count; i++)
            {

                Console.WriteLine(i); ;
            }

        }

        public string CheckOut()
        {
            Console.WriteLine("Which movie would you like to pick?");
            PrintMovies(); 
            int userInput = int.Parse(Console.ReadLine());
            Console.WriteLine(userInput);

            return "movies";
        }

    }
}
