namespace BowlingGameLogic
{
    public class Player
    {
        public int[]    scoreCard       = new int[21];
        int             numberOfRoll    = 0;

        public void Roll(object fallenPins)
        {
            switch (fallenPins)
            {
                case int Pins:
                    scoreCard[numberOfRoll] = Pins;
                    numberOfRoll++;
                    break;

                case int[] Pins:
                    foreach (var roll in Pins)
                    {
                        scoreCard[numberOfRoll] = roll;
                        numberOfRoll++;
                    }
                    break;

                case string Pins:
                    scoreCard[numberOfRoll] = Convert.ToInt32(Pins);
                    numberOfRoll++;
                    break;

                case string[] Pins:
                    foreach (var roll in Pins)
                    {
                        scoreCard[numberOfRoll] = Convert.ToInt32(roll);
                        numberOfRoll++;
                    }
                    break;
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