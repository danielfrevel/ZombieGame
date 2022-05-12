using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZombieGame
{
    public interface IObservable
    {
        void Register(IObserver observer);

        void Unregister(IObserver observer);

        void Notify();

    }
}