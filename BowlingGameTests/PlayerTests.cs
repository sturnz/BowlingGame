using BowlingGameLogic;

namespace BowlingGameTests
{
    [TestClass]
    public class PlayerTests
    {
        [TestMethod]
        public void Create_A_New_Player()
        {
            Player player = new Player();

            Assert.IsNotNull(player);
        }

        [TestMethod]
        public void Roll_Ball()
        {
            // arrange
            Player player = new Player();

            player.Roll(5);
        }

        [TestMethod]
        public void Check_If_Scorecard_Is_Filled_Properly()
        {
            // arrange
            Player player = new Player();
            int expected = 3;

            // act
            player.Roll(3);
            int actual = player.scoreCard[0];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Get_PlayerScore_After_Rolling_Only_2s()
        {
            // arrange
            Player player = new Player();
            int expected = 40;

            // act
            for (int i = 1; i <= 20; i++)
            {
                player.Roll(2);
            }
            int actual = player.GetTotalScore() ;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Get_PlayerScore_After_Rolling_Only_Strikes()
        {
            // arrange
            Player player = new Player();
            int expected = 300;

            // act
            for (int i = 1; i <= 12; i++)
            {
                player.Roll(10);
            }
            int actual = player.GetTotalScore();

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}