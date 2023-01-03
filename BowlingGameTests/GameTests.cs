using Microsoft.VisualStudio.TestTools.UnitTesting;
using BowlingGameLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGameLogic.Tests
{
    [TestClass()]
    public class GameTests
    {
        [TestMethod()]
        public void RunAGame()
        {
            Game game = new Game();

            Assert.IsNotNull(game);
        }
    }
}