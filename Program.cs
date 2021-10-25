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

                Movie m = new Movie("Star Wars", "Sci - fi", 92, "Luke I am you Father");
                Movie m1 = new Movie("Deep Blue Sea", "Horror", 92, "Shark bites off arm");
                Movie m2 = new Movie("Avengers End Game", "Action", 92, "Thanos kills daughter");
                Movie m3 = new Movie("Batman Dark Knight", "Action", 92, "Why so Serious");
                Movie m4 = new Movie("Lottery Ticket", "Comedy", 92, "When they win lottery ticket");
                Movie m5 = new Movie("Friday", "Comedy", 92, "Big Worm KO's a person");
                



                //List<Movie> movies = new List<Movie>();

                //Movie movieOne = new Movie("Star Wars", "Sci-fi", 92, "Luke I am you Father");
                //Movie movieTwo = new Movie("Deep Blue Sea", "Horror", 92, "Shark bites off arm");
                //Movie movieThree = new Movie("Avengers End Game", "Action", 92, "Thanos kills daughter");
                //Movie movieFour = new Movie("Batman Dark Knight", "Action", 92, "Why so Serious");
                //Movie movieFive = new Movie("Lottery Ticket", "Comedy", 92, "When they win lottery ticket");
                //Movie movieSix = new Movie("Friday", "Comedy", 92, "Big Worm KO's a person");



                Console.WriteLine("Welcome to GC Blockbuster!");
                Console.WriteLine();
                Console.Write("Please Select a Movie from the list: ");
                
                Console.WriteLine();
                Console.Write("Please select a movie you want to watch: ");
                int userMovieInput = int.Parse(Console.ReadLine());
                switch (userMovieInput)
                {
                    case 1:
                        Console.WriteLine(m.ToString());

                        break;
                    case 2:
                        Console.WriteLine(m1.ToString());
                        break;
                    case 3:
                        Console.WriteLine(m2.ToString());
                        break;
                    case 4:
                        Console.WriteLine(m3.ToString());
                        break;
                    case 5:
                        Console.WriteLine(m4.ToString());
                        break;
                    case 6:
                        Console.WriteLine(m5.ToString());
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

       

        
    

