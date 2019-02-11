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
        public int Weight { get; protected set; }
    }

    class YarisBody : Body
    {
        public YarisBody()
        {
            Weight = 400;
        }
    }

    class AvensisBody : Body
    {
        public AvensisBody()
        {
            Weight = 500;
        }
    }

    abstract class Engine
    {
        public abstract void Start();
    }

    class YarisEngine : Engine
    {
        public override void Start()
        {
            Console.WriteLine("Vroom!");
        }
    }

    class AvensisEngine : Engine
    {
        public override void Start()
        {
            Console.WriteLine("Vroooooooom!!");
        }
    }



}
