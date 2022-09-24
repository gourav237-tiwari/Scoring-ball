using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scoring_ball_1
{
    public  class Sparecalc:IScoreCalculator
    {
        public int Calculate(int[] score, ScoreCard scoreCard)
        {
            int result = 0;
            int strike_count = scoreCard.strikehandler.GetStrikeCount();
            if (strike_count == 1)
            {
                result = result + 10 + score[0] + score[1];
                scoreCard.strikehandler.DecreaseStrikeCount();
                scoreCard.strikehandler.ReAssignedStrike();

            }
            else if (strike_count == 2)
            {
                result = result + 10 + 10 + score[0];
                result = result + 10 + score[0] + score[1];
                scoreCard.strikehandler.ReAssignedStrike();
                scoreCard.strikehandler.DecreaseStrikeCount();
                scoreCard.strikehandler.DecreaseStrikeCount();

            }
            else if (scoreCard.sparehandler.IsPrevSpare())
            {
                result = result + 10 + score[0];
                scoreCard.sparehandler.ReAssignedSpare();
            }



            return result;
        }
       
    }
}
