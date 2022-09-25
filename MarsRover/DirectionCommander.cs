using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public class DirectionCommander
    {
       
        IDirectionIndicator directionIndicator;
        public void AssignedDirection(char direction,PositionManager positionManager)
        {
           
            switch (direction)
            {
                case 'E':
                    
                    directionIndicator = new  LeftIndicator();
                    directionIndicator.FindDirection(positionManager);
                    break;
                case 'W':
                    directionIndicator = new RightIndicator();
                    directionIndicator.FindDirection(positionManager);

                    break;
                case 'N':
                    directionIndicator = new FrontIndicator();
                    directionIndicator.FindDirection(positionManager);
                    break;
                case 'S':
                    directionIndicator = new ReverseIndicator();
                    directionIndicator.FindDirection(positionManager);

                    break;
                default:
                    break;
            }

        }

    }
}
