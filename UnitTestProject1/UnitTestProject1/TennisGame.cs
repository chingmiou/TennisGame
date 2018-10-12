using System;
using System.Collections.Generic;

namespace UnitTestProject1
{
    public class TennisGame
    {
        private readonly string _firstPlayerName;
        private readonly string _secondPlayerName;
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
            _firstPlayerName = firstPlayerName;
            _secondPlayerName = secondPlayerName;
        }

        public string Score()
        {
            return IsScoreDifferent()
                ? IsReadyForWin() ? AdvState() : LookupScore()
                : IsDeuce() ? Deuce() : SameScore();
        }

        private string SameScore()
        {
            return $"{_scoreLookup[_firstPlayerScoreTimes]} All";
        }

        private static string Deuce()
        {
            return $"Deuce";
        }

        private string AdvState()
        {
            return IsAdv() ? $"{AdvPlayer()} Adv" : $"{AdvPlayer()} Win";
        }

        private bool IsAdv()
        {
            return Math.Abs(_firstPlayerScoreTimes - _secondPlayerScoreTimes) == 1;
        }

        private bool IsReadyForWin()
        {
            return _firstPlayerScoreTimes > 3 || _secondPlayerScoreTimes > 3;
        }

        private bool IsScoreDifferent()
        {
            return _firstPlayerScoreTimes != _secondPlayerScoreTimes;
        }

        private string LookupScore()
        {
            return $"{_scoreLookup[_firstPlayerScoreTimes]} {_scoreLookup[_secondPlayerScoreTimes]}";
        }

        private bool IsDeuce()
        {
            return _firstPlayerScoreTimes >= 3;
        }

        private string AdvPlayer()
        {
            var advPlayer = _firstPlayerScoreTimes > _secondPlayerScoreTimes ? _firstPlayerName : _secondPlayerName;
            return advPlayer;
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