using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRover;

namespace MarsRoverTest
{
    public  class RightIndicatorTest
    {
        RightIndicator rightIndicator = new RightIndicator();
        PositionManager positionManager = new PositionManager();
        [Fact]

        public void FindDirection_AssignedDirectionWest()
        {
            positionManager.direction = Directions.S;
            rightIndicator.FindDirection(positionManager);
            Assert.Equal(Directions.W, positionManager.direction);


        }
        [Fact]

        public void FindDirection_AssignedDirectionEast()
        {
            positionManager.direction = Directions.N;
            rightIndicator.FindDirection(positionManager);
            Assert.Equal(Directions.E, positionManager.direction);


        }
        [Fact]

        public void FindDirection_AssignedDirectionNorth()
        {
            positionManager.direction = Directions.W;
            rightIndicator.FindDirection(positionManager);
            Assert.Equal(Directions.N, positionManager.direction);


        }
        [Fact]

        public void FindDirection_AssignedDirectionSouth()
        {
            positionManager.direction = Directions.E;
            rightIndicator.FindDirection(positionManager);
            Assert.Equal(Directions.S, positionManager.direction);


        }

    }
}
