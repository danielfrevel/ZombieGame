using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZombieGame
{
    public interface IObserver
    {
        void Update(IObservable observable);

    }
}