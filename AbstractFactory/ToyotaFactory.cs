using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
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

    class YarisFactory : ToyotaFactory
    {
        public override Body MakeBody()
        {
            return new YarisBody();
        }

        public override Engine MakeEngine()
        {
            return new YarisEngine();
        }
    }

    class AvensisFactory : ToyotaFactory
    {
        public override Body MakeBody()
        {
            return new AvensisBody();
        }

        public override Engine MakeEngine()
        {
            return new AvensisEngine();
        }
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

    class Car
    {
        public Body Body { get; }
        public Engine Engine { get; }

        public Car(Body body, Engine engine)
        {
            Body = body;
            Engine = engine;
        }

        public void StartEngine()
        {
            Engine.Start();
        }

        public override string ToString()
        {
            return $"{Body} with a weight of {Body.Weight}kg and a {Engine}";
        }
    }

    class ToyotaAssemblyLine
    {
        private ToyotaFactory _factory;

        public ToyotaAssemblyLine(ToyotaFactory factory)
        {
            _factory = factory;
        }

        public Car AssembleCar()
        {
            var body = _factory.MakeBody();
            var engine = _factory.MakeEngine();
            return new Car(body, engine);
        }
    }
}
