using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scoring_ball_1
{
    public class ScoreRoundTeller

    {

        private int _round = 0;

        public  ScoreRoundTeller(ScoreCard scoreCard)
        {
            this._round=scoreCard.roundmanager.GetRound();

        }
        public int GetRound()
        {
            return _round;
        }

        public int[] GetRoundScore(ScoreCard scoreCard)
        {

            int[] score = new int[2]
            {
            ScoreCard.Score[_round,0],ScoreCard.Score[_round,1]
            };
            scoreCard.roundmanager.NextRound();
            return score;
        }

    }
}
