using System.Collections.Generic;

namespace UnitTestProject1
{
    public class TennisGame
    {
        public string FirstPlayerName { get; }
        public string SecondPlayerName { get; }
        private int _firstPlayerScoreTimes;
        private int _secondPlayerScoreTimes;

        private Dictionary<int, string> _scoreLookup = new Dictionary<int, string>
        {
            {0, "Love"},
            {1, "Fifteen"},
            {2, "Thirty"},
            {3, "Forty"},
        };

        public TennisGame(string firstPlayerName, string secondPlayerName)
        {
            FirstPlayerName = firstPlayerName;
            SecondPlayerName = secondPlayerName;
        }

        public string Score()
        {
            if (_firstPlayerScoreTimes != _secondPlayerScoreTimes)
            {
                if (_firstPlayerScoreTimes > 3)
                {
                    if (_firstPlayerScoreTimes - _secondPlayerScoreTimes == 1)
                    {
                        return "Joey Adv";
                    }
                }

                return $"{_scoreLookup[_firstPlayerScoreTimes]} {_scoreLookup[_secondPlayerScoreTimes]}";
            }

            if (_firstPlayerScoreTimes >= 3)
            {
                return $"Deuce";
            }
            return $"{_scoreLookup[_firstPlayerScoreTimes]} All";
        }

        public void FirstPlayerScore()
        {
            _firstPlayerScoreTimes++;
        }

        public void SecondPlayerScore()
        {
            _secondPlayerScoreTimes++;
        }
    }
}