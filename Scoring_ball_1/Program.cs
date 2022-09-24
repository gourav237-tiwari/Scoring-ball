namespace Scoring_ball_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StandardMessage standardmessage = new StandardMessage();
            ScoreCalculator scoreCalculator = new ScoreCalculator();
            ScoreCard scoreCard = new ScoreCard();
            
            standardmessage.StartingMessage();

            for (int round = 0; round < 13; round++)
            {
                if (!scoreCard.roundmanager.IsRoundsEnd())
                {
                    ScoreRoundTeller scoreRoundTeller = new ScoreRoundTeller(scoreCard);
                    int[] score = scoreRoundTeller.GetRoundScore(scoreCard);
                    scoreCalculator.Calculate(score,scoreCard);
                    

                }
                else
                {
                    break;
                }

            }
            standardmessage.LastMessage(scoreCalculator.showScore.ShowResult(scoreCalculator));
            

        }
    }
}