using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisKata.Interfaces
{
    public interface ITennisGame
    {
        void PointToPlayer1();
        void PointToPlayer2();
        string GetScore();
    }
}
