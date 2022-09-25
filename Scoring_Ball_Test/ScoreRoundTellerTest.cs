using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Scoring_ball_1;

namespace Scoring_Ball_Test
{
    public  class ScoreRoundTellerTest
    {
        //ScoreCard scoreCard = new ScoreCard();
        ScoreCard scoreCard=new ScoreCard();

        [Fact]
        public void GetRound_ReturnRound()
        {
            ScoreRoundTeller scoreRoundTeller = new ScoreRoundTeller(scoreCard);
            int result=scoreRoundTeller.GetRound();
            Assert.Equal(0, result);

        }

        [Fact]
        public void GetRoundScore()
        {
            ScoreRoundTeller scoreRoundTeller = new ScoreRoundTeller(scoreCard);
         
            int[] score=scoreRoundTeller.GetRoundScore(scoreCard);
            int[] expected_core = new int[] { 3,4};
            Assert.Equal(expected_core, score);


        }


    }
}
