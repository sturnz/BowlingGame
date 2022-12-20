namespace BowlingGameLogic
{
    public class Player
    {
        public int[] scoreCard = new int[21];

        public void Roll(int fallenPins)
        {
            scoreCard[0] = fallenPins;
        }
    }
}