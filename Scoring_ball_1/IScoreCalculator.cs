using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scoring_ball_1
{
    public interface IScoreCalculator
    {
        public int Calculate(int[] score, ScoreCard scoreCard);
        
    }
}
