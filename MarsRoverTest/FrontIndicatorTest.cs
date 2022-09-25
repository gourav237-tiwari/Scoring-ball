using MarsRover;
namespace MarsRoverTest
{
    public class FrontIndicatorTest
    {
        FrontIndicator frontIndicator = new FrontIndicator();
        PositionManager positionManager = new PositionManager();
        [Fact]

        public void FindDirection_AssignedDirectionNorth()
        {
            positionManager.direction = Directions.N;
            frontIndicator.FindDirection(positionManager);
            Assert.Equal(Directions.N, positionManager.direction);


        }
        [Fact]
        public void FindDirection_AssignedDirectionSouth()
        {
            positionManager.direction = Directions.S;
            frontIndicator.FindDirection(positionManager);
            Assert.Equal(Directions.S, positionManager.direction);


        }
        [Fact]
        public void FindDirection_AssignedDirectionEast()
        {
            positionManager.direction = Directions.E;
            frontIndicator.FindDirection(positionManager);
            Assert.Equal(Directions.E, positionManager.direction);


        }
        [Fact]
        public void FindDirection_AssignedDirectionWest()
        {
            positionManager.direction = Directions.W;
            frontIndicator.FindDirection(positionManager);
            Assert.Equal(Directions.W, positionManager.direction);


        }


    }
}