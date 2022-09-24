using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scoring_ball_1
{
    internal class StandardMessage
    {
        public void StartingMessage()
        {
            Console.WriteLine("Welcome to the Game");

        }

        public void LastMessage(int result)
        {
            Console.WriteLine($"Your Final score is {result}");
        }

    }
}
