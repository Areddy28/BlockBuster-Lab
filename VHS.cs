using System;
using System.Collections.Generic;
using System.Text;

namespace BlockBusterLab
{
    class VHS : Movie
    {
        public int CurrentTime { get; set; }

        public VHS(int CurrentTime, string Title, string Category, int RunTime ) : base(Title, Category, RunTime)
        {
            this.CurrentTime = CurrentTime;
        }

        public override void Play()
        {
            CurrentTime++;
        }

        public void Rewind()
        {
            CurrentTime = 0; 
        }

    }
}
