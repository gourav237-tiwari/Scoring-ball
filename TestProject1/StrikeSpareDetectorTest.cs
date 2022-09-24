using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Scoring_ball_1;

namespace TestProject1
{
    public class StrikeSpareDetectorTest
    {
        StrikeSpareDetector strikeSpareDetector = new StrikeSpareDetector();

        [Fact]

        public void IsStrike_ReturnTrue()
        {
            int[] score = new int[] { 10, 0 };
            Assert.True(strikeSpareDetector.IsStrike(score));

        }

        [Fact]

        public void IsStrike_ReturnFalse()
        {
            int[] score = new int[] { 1, 0 };
            Assert.False(strikeSpareDetector.IsStrike(score));

        }

        [Fact]

        public void IsSpare_ReturnTrue()
        {
            int[] score = new int[] { 6, 4 };
            Assert.True(strikeSpareDetector.IsSpare(score));

        }

        [Fact]

        public void IsSpare_ReturnFalse()
        {
            int[] score = new int[] { 6, 3 };
            Assert.False(strikeSpareDetector.IsSpare(score));

        }
    }

}
