using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scoring_ball_1
{
    public class StrikeHandler
    {
        private   int strikeCount = 0;
        private  bool prevStrike = false;

        public  int GetStrikeCount()
        {
            return strikeCount;
        }

        public  void IncreaseStrikeCount()
        {
            strikeCount++;
        }

        public  void DecreaseStrikeCount()
        {
            strikeCount--;
        }

        public  bool IsPrevStrike()
        {
            return prevStrike;
        }
        public void AssignedStrike()
        {
            prevStrike = true;
        }
        public void ReAssignedStrike()
        {
            prevStrike = false;
        }
    }
}
