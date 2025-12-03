using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisKata.Models
{
    public class Player
    {
        public Player(string? name)
        {
            Name = name;
            Points = 0;
        }

        public string? Name { get; set; }
        public int Points { get; set; }

        public void ScorePoint()
        {
            Points++;
        }
    }
}
