using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scoring_ball_1
{
    public class StrikeSpareDetector
    {
        public  bool IsStrike(int[] score)
        {
            if (score[0] == 10)
            {
                return true;
            }
            return false;
        }

        public  bool IsSpare(int[] score)
        {
            if (score[0] + score[1] == 10)
            {
                return true;
            }
            return false;
        }
    }
}
