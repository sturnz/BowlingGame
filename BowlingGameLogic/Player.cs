namespace BowlingGameLogic
{
    public class Player
    {
        public int[] scoreCard = new int[21];
        int numberOfRoll = 0;

        public void Roll(int fallenPins)
        {
            scoreCard[numberOfRoll] = fallenPins;
            numberOfRoll++;
        }

        public int GetTotalScore()
        {
            int totalScore = 0;

            foreach (var roll in scoreCard)
            {
                totalScore += roll;
            }

            return totalScore;
        }
    }
}