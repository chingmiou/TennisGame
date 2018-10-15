using System;
using System.Collections.Generic;

namespace UnitTestProject1
{
    public class TennisGame
    {
        private readonly string _firstPlayerName;
        private readonly string _secondplayerName;
        private int _firstPlayerScoreTimes;

        private Dictionary<int, string> _scoreLookup = new Dictionary<int, string>
        {
            {0,"Love" },
            {1,"Fifteen" },
            {2,"Thirty" },
            {3,"Forty" },
        };

        private int _secondPlayerScoreTimes;

        public TennisGame(string firstPlayerName, string secondplayerName)
        {
            _firstPlayerName = firstPlayerName;
            _secondplayerName = secondplayerName;
        }

        public string Score()
        {
            if (_firstPlayerScoreTimes != _secondPlayerScoreTimes)
            {
                if (_firstPlayerScoreTimes > 3 || _secondPlayerScoreTimes > 3)
                {
                    if (Math.Abs(_firstPlayerScoreTimes - _secondPlayerScoreTimes) == 1)
                    {
                        var advPlayer = _firstPlayerScoreTimes > _secondPlayerScoreTimes ? _firstPlayerName : _secondplayerName;
                        return $"{advPlayer} Adv";
                    }
                }

                return $"{_scoreLookup[_firstPlayerScoreTimes]} {_scoreLookup[_secondPlayerScoreTimes]}";
            }
            if (_firstPlayerScoreTimes >= 3)
            {
                return "Deuce";
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