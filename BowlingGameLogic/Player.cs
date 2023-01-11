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
                    switch (Pins)
                    {
                        case "x":
                            Pins = "10";
                            break;
                        case "/":
                            Pins = (10 - scoreCard[numberOfRoll - 1]).ToString();
                            break;
                        case "-":
                            Pins = "0";
                            break;
                    }
                    scoreCard[numberOfRoll] = Convert.ToInt32(Pins);
                    numberOfRoll++;
                    break;

                case string[] Pins:
                    for (int index = 0; index < Pins.Length; index++)
                    {
                        switch (Pins[index])
                        {
                            case "x":
                                Pins[index] = "10";
                                break;
                            case "/":
                                Pins[index] = (10 - scoreCard[numberOfRoll - 1]).ToString();
                                break;
                            case "-":
                                Pins[index] = "0";
                                break;
                            default:
                                Pins[index] = Pins[index];
                                break;
                        }
                        scoreCard[numberOfRoll] = Convert.ToInt32(Pins[index]);
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