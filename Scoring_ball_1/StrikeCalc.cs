using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scoring_ball_1
{
    public class StrikeCalc:IScoreCalculator
    {
        public int Calculate(int[] score, ScoreCard scoreCard)
        {
            int result = 0;
            if (scoreCard.sparehandler.IsPrevSpare() == true)
            {
                
                result += 20;
                scoreCard.sparehandler.ReAssignedSpare();
            }
            else if (scoreCard.strikehandler.GetStrikeCount() == 3)
            {
                result += 30;
                
                scoreCard.strikehandler.DecreaseStrikeCount();
            }

            return result;
        }

    }
}
