using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CricketGame;

namespace CricketGameResultCalculator
{
    public class CheckResult
    {
        public String _result;
        public CheckResult()
        {
            _result = null;
        }
        public void check(Cricket Player1, Cricket Player2)
        {
            if (Player1.PlayerScore > Player2.PlayerScore)
            {
                _result = "Player1 won";
            }
            else if (Player1.PlayerScore < Player2.PlayerScore)
            {
                _result = "Player2 won";
            }
            else
            {
                _result = "Tie";
            }
        }
    }
}
//Test cases of this class 