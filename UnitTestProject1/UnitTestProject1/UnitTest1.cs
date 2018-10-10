using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class TennisGameTests
    {
        [TestMethod]
        public void Love_All()
        {
            var tennisGame = new TennisGame();
            var score = tennisGame.Score();
            Assert.AreEqual("Love All", score);
        }
    }
}