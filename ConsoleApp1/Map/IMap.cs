using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZombieGame
{
    public interface IMap : IObservable
    {
        void SpawnZombie(IZombie zombie);
    }
}