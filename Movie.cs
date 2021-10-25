using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlockBusterLab
{
    class Movie
    {
        //Properties go here
        public string Title { get; set; }
        public string Category { get; set; }
        public int RunTime { get; set; }
        public List<string> Scenes { get; set; }

        //Constructor goes here

        public Movie (string Title, string Category, int Runtime, params string[] Scenes)
        {
            this.Title = Title;
            this.Category = Category;
            this.RunTime = Runtime;
            this.Scenes = Scenes.ToList(); 
            
        }


        public override string ToString()
        {
            string output = $"Title: {Title}";
            output += $"Category: {Category}";
            output += $"Runtime: {RunTime}";
           

            

            return output; 
        }

        public void PrintScenes()
        {
            for (int i = 0; i < Scenes.Count; i++)
            {
                Console.WriteLine($"{i} : {Scenes[i]}");
            }
        }







    }
}
