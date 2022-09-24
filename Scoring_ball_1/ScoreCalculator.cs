using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scoring_ball_1
{
    public class ScoreCalculator
    {
        private int result = 0;
        public ShowScore showScore { get; }= new ShowScore();
        

        public  int Calculate(int[] score,ScoreCard scoreCard)
        {
            StrikeSpareDetector strikeSpareDetector = new StrikeSpareDetector();
            if (strikeSpareDetector.IsStrike(score))
            {

                scoreCard.strikehandler.IncreaseStrikeCount();
                scoreCard.strikehandler.AssignedStrike();
                StrikeCalc strikecalc= new StrikeCalc();
                result+=strikecalc.Calculate(score,scoreCard);
              
            }
            else
            {
                Sparecalc sparecalc = new Sparecalc();
                result += sparecalc.Calculate(score,scoreCard);
                if (score[1] + score[0] == 10)
                {
                    scoreCard.sparehandler.AssignedSpare();
                }
                else
                {
                    result += score[0] + score[1];
                   
                }
            }
           
            return result;

        }

        public  int GetResult()
        {
            return result;
        }

    }
}
