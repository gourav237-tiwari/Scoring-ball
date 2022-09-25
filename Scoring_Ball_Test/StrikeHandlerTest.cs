using Scoring_ball_1;
namespace Scoring_Ball_Test
{
    public class StrikeHandlerTest
    {
        StrikeHandler strikeHandler = new StrikeHandler();
        [Fact]
       public void IncreaseStrikeCount_IncreaseStrike()
        {
            int strikeCount=strikeHandler.GetStrikeCount();
            strikeHandler.IncreaseStrikeCount();
            Assert.Equal(strikeCount + 1,strikeHandler.GetStrikeCount());

        }

        [Fact]

        public void DecreaseStrikeCount_DecreaseStrike()
        {
            int strikeCount = strikeHandler.GetStrikeCount();
            strikeHandler.DecreaseStrikeCount();
            Assert.Equal(strikeCount - 1, strikeHandler.GetStrikeCount());

        }

        [Fact]

        public void AssignedStrike_ReturnTrue()
        {
            strikeHandler.AssignedStrike();
            Assert.True(strikeHandler.IsPrevStrike());
        }

        [Fact]

        public void ReAssignedStrike_ReturnFalse()
        {
            strikeHandler.AssignedStrike();
            strikeHandler.ReAssignedStrike();
            Assert.False(strikeHandler.IsPrevStrike());
        }
    }
}