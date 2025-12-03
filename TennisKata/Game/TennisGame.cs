using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TennisKata.Interfaces;
using TennisKata.Models;

namespace TennisKata.Game
{
    public class TennisGame : ITennisGame
    {
        private Player _player1;
        private Player _player2;
        public TennisGame(string player1Name = "player1", string player2Name = "player2")
        {
            _player1 = new Player(player1Name);
            _player2 = new Player(player2Name);
        }

        public string GetScore()
        {
            if (_player1.Points == _player2.Points)
            {
                return GetEqualScoreDescription(_player1.Points);
            }

            if (_player1.Points >= 4 || _player2.Points >= 4)
            {
                return GetEndGameScore();
            }

            return $"{PointToText(_player1.Points)}-{PointToText(_player2.Points)}";
        }

        private string GetEndGameScore()
        {
            int difference = _player1.Points - _player2.Points;

            if (difference == 1)
            {
                return $"Advantage {_player1.Name}";
            }

            if (difference == -1)
            {
                return $"Advantage {_player2.Name}";
            }

            if (difference >= 2)
            {
                return $"Win for {_player1.Name}";
            }

            if (difference <= -2)
            {
                return $"Win for {_player2.Name}";
            }

            return "Deuce";
        }



        private string GetEqualScoreDescription(int points)
        {
            return points switch
            {
                0 => "Love-All",
                1 => "Fifteen-All",
                2 => "Thirty-All",
                _ => "Deuce"
            };
        }

        private string PointToText(int points)
        {
            return points switch
            {
                0 => "Love",
                1 => "Fifteen",
                2 => "Thirty",
                3 => "Forty",
                _ => throw new ArgumentOutOfRangeException(nameof(points))
            };
        }

        public void PointToPlayer1()
        {
            _player1.ScorePoint();
        }

        public void PointToPlayer2()
        {
            _player2.ScorePoint();
        }
    }
}
