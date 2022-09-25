using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Scoring_ball_1;


namespace Scoring_Ball_Test
{
    public class RoundManagerTest
    {
        RoundManager roundManager=new RoundManager();

        [Fact]

        public void IsRoundsEnd_ReturnFalse()
        {
            Assert.False(roundManager.IsRoundsEnd());
        }

        [Fact]
        public void IsRoundEnd_ReturnTrue()
        {
           for(int i = 0; i < 14; i++)
            {
                roundManager.NextRound();
            }

           Assert.True(roundManager.IsRoundsEnd());
        }
        [Fact]
        public void GetRound_ReturnRound()
        {
            roundManager.NextRound(); 
            Assert.Equal(roundManager.GetRound(), 1);
        }

        [Fact]

        public void IsLastExtraChance_ReturnFalse()
        {

            ScoreCard.Score[9, 0] = 5;
            Assert.False(roundManager.IsLastExtraChance());

        }
        [Fact]
        public void IsLastExtraChance_ReturnTrue()
        {

            ScoreCard.Score[9, 0] = 10;
            Assert.True(roundManager.IsLastExtraChance());

        }
    }
}
