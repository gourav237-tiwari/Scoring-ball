namespace MarsRover
{
    internal class Program
    {
        static void Main(string[] args)
        {
              PositionManager positionManager = new PositionManager();
              DirectionCommander directionCommander = new DirectionCommander(); 

              char[] directionStep = new char[] { 'R', 'L', 'R', 'L', 'F', 'F', 'B', 'B' };


            for(int directionTraversal=0; directionTraversal<directionStep.Length; directionTraversal++)
            {
              
                directionCommander.AssignedDirection(directionStep[directionTraversal], positionManager);
                positionManager.ReFindPosition();
               
            }

            int[] finalPositionCoordinte = positionManager.GetPositionCordinate();
            foreach (var i in finalPositionCoordinte)
            {
                Console.WriteLine(i);
            }
            Directions dire=positionManager.GetFacingDirection();
            Console.WriteLine(dire);
           



         }
    }
}