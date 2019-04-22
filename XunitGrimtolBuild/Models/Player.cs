using System.Collections.Generic;

namespace XunitGrimtolBuild.Models
{
    public class Player
    {
        public int Health { get; set; }
        public Player(int startHealth)
        {
            Health = startHealth;
        }

    }
}