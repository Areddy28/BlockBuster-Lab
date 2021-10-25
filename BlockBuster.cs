using System;
using System.Collections.Generic;
using System.Text;

namespace BlockBusterLab
{
    class BlockBuster
    {

        public List<string> scenes = new List<string>();
        


        public List<Movie> movies { get; set; } = new List<Movie>();



        public Movie StarWars = new DVD ("Star Wars", "Sci-fi", 92, "Luke I am you Father");
        public Movie DeepBlueSea = new DVD("Deep Blue Sea", "Horror", 92, "Shark bites off arm");
        public Movie AvengersEndGame = new DVD("Avengers Infinity Wars", "Action", 92, "Thanos kills daughter");
        public Movie BatmanDarkKnight = new VHS("Batman Dark Knight", "Action", 92, 60, "Why so Serious");
        public Movie LotteryTicket = new VHS("Lottery Ticket", "Comedy", 92, 40, " When they won the Lottery Ticket");
        public Movie Friday = new VHS("Friday", "Comedy", 92, 70, "Big Worm KO's a person");

        //Movie m = new Movie("Star Wars", "Sci - fi", 92, "Luke I am you Father");
        //Movie m1 = new Movie("Deep Blue Sea", "Horror", 92, "Shark bites off arm");
        //Movie m2 = new Movie("Avengers End Game", "Action", 92, "Thanos kills daughter");
        //Movie m3 = new Movie("Batman Dark Knight", "Action", 92, "Why so Serious");
        //Movie m4 = new Movie("Lottery Ticket", "Comedy", 92, "When they win lottery ticket");
        //Movie m5 = new Movie("Friday", "Comedy", 92, "Big Worm KO's a person");







        public void PrintMovies()
        {
            for (int i = 0; i < movies.Count; i++)
            {

                Console.WriteLine(i); 
            }

        }

        public void CheckOut()
        {
            Console.WriteLine("Which scene of the movie would you like to pick?");
            PrintMovies(); 
            int userInput = int.Parse(Console.ReadLine());
            Console.WriteLine(userInput);

            
        }

    }
}
