using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public interface IDirectionIndicator
    {
        public void FindDirection(PositionManager positionManager);
    }
}
