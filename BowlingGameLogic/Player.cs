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
            int totalScore  = 0;
            int index       = 0;

            for (int frame = 1; frame <= 10; frame++)
            {
                totalScore += scoreCard[index];

                if(scoreCard[index] == 10)
                {
                    totalScore += scoreCard[index + 1];
                    totalScore += scoreCard[index + 2];
                }
                else
                {
                    totalScore += scoreCard[index + 1];
                }
                index++;
            }

            return totalScore;
        }
    }
}