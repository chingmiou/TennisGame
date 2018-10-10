﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class TennisGameTests
    {
        private TennisGame _tennisGame = new TennisGame();

        [TestMethod]
        public void Love_All()
        {
            ScoreShouldBe("Love All");
        }

        [TestMethod]
        public void Fifteen_Love()
        {
            _tennisGame.FirstPlayerScore();
            ScoreShouldBe("Fifteen Love");
        }

        [TestMethod]
        public void Thirty_Love()
        {
            _tennisGame.FirstPlayerScore();
            _tennisGame.FirstPlayerScore();
            ScoreShouldBe("Thirty Love");
        }

        private void ScoreShouldBe(string expected)
        {
            Assert.AreEqual(expected, _tennisGame.Score());
        }
    }
}