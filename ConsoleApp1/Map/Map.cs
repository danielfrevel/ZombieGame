using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZombieGame
{
    public class Map : IMap, IObservable
    {
        private List<IObserver> Observers = new List<IObserver>();
        public List<IZombie> Zombies = new List<IZombie>();
        
        public void SpawnZombie(IZombie zombie)
        {
            this.Zombies.Add(zombie);
            this.Notify();
        }

        public void Notify()
        {
            foreach (var observer in Observers)
            {
                observer.Update(this);
            }
        }


        public void Register(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void Unregister(IObserver observer)
        {
            Observers.Remove(observer);
        }
    }
}