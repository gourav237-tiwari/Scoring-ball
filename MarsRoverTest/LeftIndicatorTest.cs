using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRover;

namespace MarsRoverTest
{
    public class LeftIndicatorTest
    {
        LeftIndicator leftIndicator = new LeftIndicator();
        PositionManager positionManager = new PositionManager();
        [Fact]

        public void FindDirection_AssignedDirectionWest()
        {
            positionManager.direction = Directions.N;
            leftIndicator.FindDirection(positionManager);
            Assert.Equal(Directions.W, positionManager.direction);


        }
        [Fact]

        public void FindDirection_AssignedDirectionEast()
        {
            positionManager.direction = Directions.S;
            leftIndicator.FindDirection(positionManager);
            Assert.Equal(Directions.E, positionManager.direction);


        }
        [Fact]

        public void FindDirection_AssignedDirectionNorth()
        {
            positionManager.direction = Directions.E;
            leftIndicator.FindDirection(positionManager);
            Assert.Equal(Directions.N, positionManager.direction);


        }
        [Fact]

        public void FindDirection_AssignedDirectionSouth()
        {
            positionManager.direction = Directions.W;
            leftIndicator.FindDirection(positionManager);
            Assert.Equal(Directions.S, positionManager.direction);


        }


    }
}
