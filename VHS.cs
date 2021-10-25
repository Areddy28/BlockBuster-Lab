using System;
using System.Collections.Generic;
using System.Text;

namespace BlockBusterLab
{
    class VHS : Movie
    {
        public int CurrentTime { get; set; }

        public VHS(string Title, string Category, int RunTime, int CurrentTime, params string[] Scenes) : base(Title, Category, RunTime, Scenes) //base references the parent
        {
            this.CurrentTime = CurrentTime;
        }

        public void Play()
        {
            CurrentTime++;
        }

        public void Rewind()
        {
            CurrentTime = 0; 
        }

    }
}
