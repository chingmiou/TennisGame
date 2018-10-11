using System.Collections.Generic;

namespace UnitTestProject1
{
    public class TennisGame
    {
        private int _firstPlayerScoreTimes;

        public string Score()
        {
            var scoreLookup = new Dictionary<int, string>
            {
                {1,"Fifteen" },
                {2,"Thirty" },
            };
            if (_firstPlayerScoreTimes > 0)
            {
                return $"{scoreLookup[_firstPlayerScoreTimes]} Love";
            }

            return "Love All";
        }

        public void FirstPlayerScore()
        {
            _firstPlayerScoreTimes++;
        }
    }
}