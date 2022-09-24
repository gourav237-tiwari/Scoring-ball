using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scoring_ball_1
{
    public class ShowScore
    {
        public int ShowResult(ScoreCalculator scoreCalculator)
        {
            return scoreCalculator.GetResult();

        }
    }
}
