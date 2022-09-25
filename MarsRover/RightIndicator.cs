using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public  class RightIndicator:IDirectionIndicator
    {
        public void FindDirection(PositionManager positionManager)
        {
            switch (positionManager.direction)
            {
                case Directions.N:
                    positionManager.direction = Directions.E;
                    break;
                case Directions.S:
                    positionManager.direction = Directions.W;
                    break;
                case Directions.E:
                    positionManager.direction = Directions.S;
                    break;
                case Directions.W:
                    positionManager.direction = Directions.N;
                    break;
                default:
                    break;
            }


        }
    }
}
