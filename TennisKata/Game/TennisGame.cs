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
            if (_player1.Points == 0 && _player2.Points == 0)
            {
                return "Love-All";
            }

            throw new NotImplementedException();
        }

        public void PointToPlayer1()
        {
            throw new NotImplementedException();
        }

        public void PointToPlayer2()
        {
            throw new NotImplementedException();
        }
    }
}
