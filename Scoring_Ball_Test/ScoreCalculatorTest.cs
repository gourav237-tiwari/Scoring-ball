using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Scoring_ball_1;

namespace Scoring_Ball_Test
{
    public  class ScoreCalculatorTest
    {
        ScoreCalculator scoreCalculator = new ScoreCalculator();
       
        [Fact]
        public void Calculate_IfStrike_And_PrevSpareIsTrue()
        {
            ScoreCard scoreCard = new ScoreCard();
            int[] score = new int[] { 10, 0 };
            scoreCard.sparehandler.AssignedSpare();
            int ActualResult=scoreCalculator.Calculate(score, scoreCard);
            int ExpectedResult = 20;
            Assert.Equal(ExpectedResult, ActualResult);

        }
        public void Calculate_IfStrike_And_StrikeCountIsThree()
        {
            ScoreCard scoreCard = new ScoreCard();
            int[] score = new int[] { 10, 0 };
            scoreCard.strikehandler.IncreaseStrikeCount();
            scoreCard.strikehandler.IncreaseStrikeCount();
            scoreCard.strikehandler.IncreaseStrikeCount();
            int ActualResult = scoreCalculator.Calculate(score, scoreCard);
            int ExpectedResult = 30;
            Assert.Equal(ExpectedResult, ActualResult);

        }
        [Fact]
        public void Calculate_IfNotStrike_StrikeCountIsOne()
        {
            ScoreCard scoreCard = new ScoreCard();
            int[] score = new int[] { 5, 5 };
            scoreCard.strikehandler.IncreaseStrikeCount();
            int actualResult=scoreCalculator.Calculate(score, scoreCard);
            int expectedResult = 10 + score[0] + score[1];
            Assert.Equal(expectedResult, actualResult);

        }

        [Fact]
        public void Calculate_IfNotStrike_StrikeCountIsTwo()
        {
            ScoreCard scoreCard = new ScoreCard();
            int[] score = new int[] { 5, 5 };
            scoreCard.strikehandler.IncreaseStrikeCount();
            scoreCard.strikehandler.IncreaseStrikeCount();
            int actualResult = scoreCalculator.Calculate(score, scoreCard);
            int expectedResult = 30 + 2*score[0] + score[1];
            Assert.Equal(expectedResult, actualResult);

        }

        [Fact]
        public void Calculate_IfNotStrike_IsPrevSpare()
        {
            ScoreCard scoreCard = new ScoreCard();
            int[] score = new int[] { 5, 5 };
            scoreCard.sparehandler.AssignedSpare();
            int actualResult = scoreCalculator.Calculate(score, scoreCard);
            int expectedResult = 10 + score[0];
            Assert.Equal(expectedResult, actualResult);

        }

    }
}
