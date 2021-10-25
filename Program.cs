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


                BlockBuster b = new BlockBuster();
                b.PrintMovies();  



                //m.ToString();
                //m1.ToString();
                //m2.ToString();
                //m3.ToString();
                //m4.ToString();
                //m5.ToString(); 



                //List<Movie> movies = new List<Movie>();

                //Movie movieOne = new Movie("Star Wars", "Sci-fi", 92, "Luke I am you Father");
                //Movie movieTwo = new Movie("Deep Blue Sea", "Horror", 92, "Shark bites off arm");
                //Movie movieThree = new Movie("Avengers End Game", "Action", 92, "Thanos kills daughter");
                //Movie movieFour = new Movie("Batman Dark Knight", "Action", 92, "Why so Serious");
                //Movie movieFive = new Movie("Lottery Ticket", "Comedy", 92, "When they win lottery ticket");
                //Movie movieSix = new Movie("Friday", "Comedy", 92, "Big Worm KO's a person");



                //Console.WriteLine("Welcome to GC Blockbuster!");
                //Console.WriteLine();
                //Console.Write("Please Select a Movie from the list: ");
                //m.PrintInfo();
                //m1.PrintInfo();
                //m2.PrintInfo();
                //m3.PrintInfo();
                //m4.PrintInfo();
                //m5.PrintInfo();

                //Console.WriteLine();
                //Console.Write("Please select a movie you want to watch: ");
                //int userMovieInput = int.Parse(Console.ReadLine());
                //switch (userMovieInput)
                //{
                //    case 1:
                //        m.PrintInfo(); 

                //        break;
                //    case 2:
                //        m1.PrintInfo(); 
                //        break;
                //    case 3:
                //        m2.PrintInfo(); 
                //        break;
                //    case 4:
                //        m3.PrintInfo(); 
                //        break;
                //    case 5:
                //        m4.PrintInfo();
                //        break;
                //    case 6:
                //        m5.PrintInfo();
                //        break;

                         
                       // d.Play();

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

       

        
    

