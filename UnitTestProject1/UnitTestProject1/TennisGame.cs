﻿namespace UnitTestProject1
{
    public class TennisGame
    {
        private int _firstPlayerScoreTimes;

        public string Score()
        {
            if (_firstPlayerScoreTimes == 2)
            {
                return "Thirty Love";
            }
            if (_firstPlayerScoreTimes == 1)
            {
                return "Fifteen Love";
            }

            return "Love All";
        }

        public void FirstPlayerScore()
        {
            _firstPlayerScoreTimes++;
        }
    }
}