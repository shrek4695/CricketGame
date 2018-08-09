using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketGame
{
    public class Cricket
    {
        public int PlayerScore { get; set; }
        public Boolean Out { get; set; }
        public Cricket()
        {
            PlayerScore = 0;
            Out = false;
        }
        
        public void Score(int runs)
        {
            if (runs <= 6 && runs > 0 && Out==false)
                PlayerScore += runs;
        }
        public void makePlayerOut()
        {
            Out = true;
        }

    }
}