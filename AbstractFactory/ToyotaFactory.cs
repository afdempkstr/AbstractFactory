using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    //AbstractFactory
    abstract class ToyotaFactory
    {
        abstract public Body MakeBody();
        abstract public Engine MakeEngine();
    }

    abstract class Body
    {
        public int Weight { get; set; }
    }

    abstract class Engine
    {
        public abstract void Start();
    }
}
