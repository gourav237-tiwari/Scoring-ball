using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public class ReverseIndicator:IDirectionIndicator
    {
        public void FindDirection(PositionManager positionManager)
        {
            switch (positionManager.direction)
            {
                case Directions.N:
                    positionManager.direction = Directions.S;
                    break;
                case Directions.S:
                    positionManager.direction = Directions.N;
                    break;
                case Directions.E:
                    positionManager.direction = Directions.W;
                    break;
                case Directions.W:
                    positionManager.direction = Directions.E;
                    break;
                default:
                    break;
            }


        }

    }
}
