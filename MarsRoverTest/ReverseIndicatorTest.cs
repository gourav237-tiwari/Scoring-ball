using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRover;

namespace MarsRoverTest
{
    public class ReverseIndicatorTest
    {
        ReverseIndicator reverseIndicator = new ReverseIndicator();
        PositionManager positionManager = new PositionManager();
        [Fact]

        public void FindDirection_AssignedDirectionSouth()
        {
            positionManager.direction = Directions.N;
            reverseIndicator.FindDirection(positionManager);
            Assert.Equal(Directions.S, positionManager.direction);


        }
        [Fact]

        public void FindDirection_AssignedDirectionEast()
        {
            positionManager.direction = Directions.W;
            reverseIndicator.FindDirection(positionManager);
            Assert.Equal(Directions.E, positionManager.direction);


        }
        [Fact]

        public void FindDirection_AssignedDirectionNorth()
        {
            positionManager.direction = Directions.S;
            reverseIndicator.FindDirection(positionManager);
            Assert.Equal(Directions.N, positionManager.direction);


        }
        [Fact]

        public void FindDirection_AssignedDirectionWest()
        {
            positionManager.direction = Directions.E;
            reverseIndicator.FindDirection(positionManager);
            Assert.Equal(Directions.W, positionManager.direction);


        }
    }
}
