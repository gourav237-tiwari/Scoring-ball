using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scoring_ball_1
{
    public class RoundManager
    {
        private   int _round = 0;

        public bool IsRoundsEnd()
        {
            if(_round>=12)
                return true;
            return false;

        }

        public bool IsLastExtraChance()
        {
            if (ScoreCard.Score[9, 0] == 10)
            {
                return true;
            }
            return false;
        }

        public void NextRound()
        {
            _round++;
        }

        public  int GetRound()
        {
            return _round;
        }

        
    }
}
