using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Scoring_ball_1;
namespace TestProject1
{
    public  class SpareCalcTest
    {
        Sparecalc sparecalc = new Sparecalc();
        ScoreCard scoreCard = new ScoreCard();

        [Fact]
        public void Calculate_StrikeCountIsOne()
        {
            scoreCard.strikehandler.IncreaseStrikeCount();
            int[] score = new int[] { 5, 5 };
            int result=sparecalc.Calculate(score, scoreCard);
            Assert.Equal(10 + score[0] + score[1], result);

        }

        [Fact]
        public void Calculate_StrikeCountIsTwo()
        {
            scoreCard.strikehandler.IncreaseStrikeCount();
            scoreCard.strikehandler.IncreaseStrikeCount();

            int[] score = new int[] { 5, 5 };
            int result = sparecalc.Calculate(score, scoreCard);
            Assert.Equal(10 + 10 + score[0] + 10 + score[0] + score[1], result);

        }

        [Fact]
        public void Calculate_IsPrevSpare()
        {
            scoreCard.sparehandler.AssignedSpare();

            int[] score = new int[] { 5, 5 };
            int result = sparecalc.Calculate(score, scoreCard);
            Assert.Equal(10  + score[0], result);

        }
    }
}
