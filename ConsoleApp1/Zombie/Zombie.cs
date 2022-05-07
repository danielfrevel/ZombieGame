using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZombieGame
{
    public class Zombie : IZombie
    {
        public Zombie()
        {

        }

        public void Die()
        {
            Console.WriteLine("Zombie spawned");
        }
    }
}