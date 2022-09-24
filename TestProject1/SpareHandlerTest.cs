using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Scoring_ball_1;

namespace TestProject1
{
    public class SpareHandlerTest
    {
        Sparehandler spareHandler=new Sparehandler();
        [Fact]
        
        public void IsPrevSpare_ReturnFalse()
        {
           
            Assert.False(spareHandler.IsPrevSpare());
        }

        [Fact]

        public void AssignedSpare_AssignedSpareTrue()
        {
            spareHandler.AssignedSpare();
            Assert.True(spareHandler.IsPrevSpare());
        }


        [Fact]

        public void AssignedSpare_ReAssignedSpare()
        {
            spareHandler.ReAssignedSpare();
            Assert.False(spareHandler.IsPrevSpare());
        }
    }
}
