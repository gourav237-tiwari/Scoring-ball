using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Scoring_ball_1;

namespace Scoring_Ball_Test
{
    public class StrikeCalcTest
    {
        StrikeCalc strikeCalc = new StrikeCalc();
        ScoreCard scoreCard = new ScoreCard();

        [Fact]

        public void CalculateScore_IsPrevSpareTrue()
        {
            int[] score = new int[2];
            scoreCard.sparehandler.AssignedSpare();
            int result=strikeCalc.Calculate(score, scoreCard);
            Assert.Equal(20, result);

        }

        [Fact]
        public void CalculateScore_StrikeCountEqualsThree()
        {
            int[] score = new int[2];
            for(int i=0; i<3; i++)
            {
                scoreCard.strikehandler.IncreaseStrikeCount();
            }
            int result = strikeCalc.Calculate(score, scoreCard);
            Assert.Equal(30, result);

        }
    }
}
