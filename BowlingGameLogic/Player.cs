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

        public void Roll(int[] fallenPins)
        {
            foreach (var roll in fallenPins)
            {
                scoreCard[numberOfRoll] = roll;
                numberOfRoll++;
            }
        }

        public int GetTotalScore()
        {
            int totalScore  = 0;
            int index       = 0;

            for (int frame = 1; frame <= 10; frame++)
            {
                totalScore += scoreCard[index];

                if (RolledAStrike(index))                            
                {
                    totalScore += BonusPoints(index);
                }
                else if (RolledASpare(index))   
                {
                    totalScore += BonusPoints(index);
                    index++;
                }
                else                                                    
                {
                    totalScore += scoreCard[index + 1];
                }
                index++;
            }

            return totalScore;
        }

        bool RolledAStrike(int index)
        {
            return scoreCard[index] == 10;
        }

        bool RolledASpare(int index)
        {
            return scoreCard[index] + scoreCard[index + 1] == 10;
        }

        int BonusPoints(int index)
        {
            return scoreCard[index + 1] + scoreCard[index + 2];
        }
    }
}