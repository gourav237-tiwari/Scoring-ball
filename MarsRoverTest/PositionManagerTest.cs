using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRover;

namespace MarsRoverTest
{
    public class PositionManagerTest
    {
        PositionManager positionManager = new PositionManager();

        [Fact]
        public void ReFindPosition_Increase_YCoordinate()
        {
            
            positionManager.direction = Directions.N;
            positionManager.ReFindPosition();
            int[] actualCoordinate=positionManager.GetPositionCordinate();
            int[] expectedCoordinate = new int[] { 0, 1 };
            Assert.Equal(expectedCoordinate, actualCoordinate);
        }
        [Fact]
        public void ReFindPosition_Decrease_YCoordinate()
        {
            
            positionManager.direction = Directions.S;
            positionManager.ReFindPosition();
            int[] actualCoordinate = positionManager.GetPositionCordinate();
            int[] expectedCoordinate = new int[] { 0, -1 };
            Assert.Equal(expectedCoordinate, actualCoordinate);
        }
        [Fact]
        public void ReFindPosition_Decrease_XCoordinate()
        {
            
            positionManager.direction = Directions.W;
            positionManager.ReFindPosition();
            int[] actualCoordinate = positionManager.GetPositionCordinate();
            int[] expectedCoordinate = new int[] {  -1,0 };
            Assert.Equal(expectedCoordinate, actualCoordinate);
        }
        [Fact]
        public void ReFindPosition_Increse_XCoordinate()
        {
            
            positionManager.direction = Directions.E;
            positionManager.ReFindPosition();
            int[] actualCoordinate = positionManager.GetPositionCordinate();
            int[] expectedCoordinate = new int[] { 1, 0 };
            Assert.Equal(expectedCoordinate, actualCoordinate);
        }
    }
}
