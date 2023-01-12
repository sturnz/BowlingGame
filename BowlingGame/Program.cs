using BowlingGameLogic;

namespace BowlingGameConsole
{
    public class Program
    {
        public static void Main()
        {
            List<Player>    listOfPlayers   = new();
            Game            game            = new();
            int             numberOfPlayers;

            Console.WriteLine("How many players are playing?");
            numberOfPlayers = Convert.ToInt32(Console.ReadLine());

            game.Run(numberOfPlayers); 

            foreach (var player in game.listOfPlayers)
            {
                Console.WriteLine($"Total points of Player {listOfPlayers.IndexOf(player) + 2}: " + player.GetTotalScore());
            }
        }
    }
}