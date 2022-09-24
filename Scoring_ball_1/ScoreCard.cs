using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scoring_ball_1
{
    public class ScoreCard
    {
        //RoundManager roundmanager  = new RoundManager();
        public Sparehandler sparehandler { get; } = new Sparehandler();
        public StrikeHandler strikehandler { get; } = new StrikeHandler();
        public RoundManager roundmanager { get; } = new RoundManager();
        public static int[,] Score = new int[,]
           {

                
                {3,4},{10,0},{3,7},{10,0},{10,0},{10,0},{10,0},{4,5},{5,5},{10,0},{10,0},{5,4}
           };


    }
}
