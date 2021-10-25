using System;
using System.Collections.Generic;
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

        public Movie (string Title, string Category, int Runtime)
        {
            this.Title = Title;
            this.Category = Category;
            this.RunTime = Runtime;
            
        }


        public override string ToString()
        {
            string output = $"Title: {Title}";
            output += $"Category: {Category}";
            output += $"Runtime: {RunTime}";
           

            

            return output; 
        }

        public virtual void Play()
        {

        }

        
        

        



    }
}
