using System;
using System.Collections.Generic;
using System.Text;

namespace BlockBusterLab
{
    class DVD : Movie
    {
        public DVD(string Title, string Category, int RunTime): base (Title, Category, RunTime)
        {

        }

        public override void Play()
        {
            Console.WriteLine($"Which scene would you like to watch?");
        }

    }
}
