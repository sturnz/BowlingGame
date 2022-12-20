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
    }
}