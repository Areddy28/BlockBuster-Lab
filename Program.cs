using System;
using System.Collections.Generic;

namespace BlockBusterLab
{
    class Program
    {
        static void Main(string[] args)
        {
            bool returnToMain = true;

            while (returnToMain)
            {
                List<string> Scenes = new List<string>();

                BlockBuster blockbuster = new BlockBuster();



                List<Movie> movies = new List<Movie>();

                Movie movieOne = new Movie("Star Wars", "Sci-fi", 92);
                Movie movieTwo = new Movie("Deep Blue Sea", "Horror", 92);
                Movie movieThree = new Movie("Avengers End Game", "Action", 92);
                Movie movieFour = new Movie("Batman Dark Knight", "Action", 92);
                Movie movieFive = new Movie("Lottery Ticket", "Comedy", 92);
                Movie movieSix = new Movie("Friday", "Comedy", 92);



                Console.WriteLine("Welcome to GC Blockbuster!");
                Console.WriteLine();
                Console.Write("Please Select a Movie from the list: ");
                blockbuster.PrintMovies();
                Console.WriteLine();
                Console.Write("Please select a movie you want to watch: ");
                int userMovieInput = int.Parse(Console.ReadLine());
                switch (userMovieInput)
                {
                    case 1:
                        Console.WriteLine(movieOne.ToString());

                        break;
                    case 2:
                        Console.WriteLine(movieTwo.ToString());
                        break;
                    case 3:
                        Console.WriteLine(movieThree.ToString());
                        break;
                    case 4:
                        Console.WriteLine(movieFour.ToString());
                        break;
                    case 5:
                        Console.WriteLine(movieFive.ToString());
                        break;
                    case 6:
                        Console.WriteLine(movieSix.ToString());
                        break;

                }

                


                Console.WriteLine();



                Console.WriteLine("Return to main [y] or [n]");
                string userChoiceToReturn = Console.ReadLine().ToLower();

                if (userChoiceToReturn == "n")
                {
                    returnToMain = false;
                    Console.WriteLine("Thanks, Bye!");
                }

            }


        }
    }
}

       

        
    

