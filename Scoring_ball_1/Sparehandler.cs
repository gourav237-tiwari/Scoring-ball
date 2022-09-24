using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scoring_ball_1
{
    public  class Sparehandler
    {
        private bool prevSpare = false;

        public  bool IsPrevSpare()
        {
            return prevSpare;
        }
        public  void AssignedSpare()
        {
            prevSpare = true;
        }
        public  void ReAssignedSpare()
        {
            prevSpare = false;
        }

    }
}
