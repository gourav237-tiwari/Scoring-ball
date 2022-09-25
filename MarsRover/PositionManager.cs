using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public class PositionManager
    {

        private int xCoordinate = 0;
        private int yCoordinate = 0;
        public Directions direction = Directions.N;
       
        public void ReFindPosition()
        {
            switch (this.direction)
            {
                case Directions.N:
                    this.yCoordinate += 1;
                    break;
                case Directions.S:
                    this.yCoordinate -= 1;
                    break;
                case Directions.E:
                    this.xCoordinate += 1;
                    break;
                case Directions.W:
                    this.xCoordinate -= 1;
                    break;
                default:
                    break;
            }
        }

        public int[] GetPositionCordinate()
        {
            return new int[] { xCoordinate, yCoordinate };
        }
        public Directions GetFacingDirection()
        {
            return this.direction;
        }

    }


    }

