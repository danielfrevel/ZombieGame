using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZombieGame
{
    public class Player : IPlayer, IObserver
    {
        private readonly IMap map;

        public Player(IMap map)
        {
            map.Register(this);
            this.map = map;
        }


        public void Update(IObservable observable)
        {
            Console.WriteLine("Player wurde benachrichtigt");            
        }
    }
}