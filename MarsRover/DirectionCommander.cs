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
                case 'R':
                    
                    directionIndicator = new  LeftIndicator();
                    directionIndicator.FindDirection(positionManager);
                    break;
                case 'L':
                    directionIndicator = new RightIndicator();
                    directionIndicator.FindDirection(positionManager);

                    break;
                case 'F':
                    directionIndicator = new FrontIndicator();
                    directionIndicator.FindDirection(positionManager);
                    break;
                case 'B':
                    directionIndicator = new ReverseIndicator();
                    directionIndicator.FindDirection(positionManager);

                    break;
                default:
                    break;
            }

        }

    }
}
