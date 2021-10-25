using System;
using System.Collections.Generic;
using System.Text;

namespace BlockBusterLab
{
    class DVD : Movie
    {
        //the base keyword is a pointer to the direct parent of the current class
        //Commonly it is used t pass parameter up to the constructor of the parent
        //but it is also used to call the parent's version of a method (and often times add onto it)
        public DVD(string Title, string Category, int Runtime, params string[] Scenes)
            : base(Title, Category, Runtime, Scenes)
        {

        }

        //DVDs will let you skip to any scene at any time
        //so we will ask the user what scene they want to watch
        public void Play()
        {
            PrintScenes();
            Console.WriteLine("Which scence would you like to watch? (select by index)");
            int pick = int.Parse(Console.ReadLine());
            string scene = Scenes[pick];
            Console.WriteLine(scene);
        }
    }
    }
