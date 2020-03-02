using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;


namespace SandBox
{
    class Engine { }

    class V8Engine : Engine { }

    interface ICar<out T> where T : Engine {
        T GetEngine();
    }

    class Lada : ICar<V8Engine>
    {
        public V8Engine GetEngine()
        {
            return new V8Engine();
        }
    }

    class MyClass {
        static void Main(string[] args)
        {
            Lada lada = new Lada();
            ICar<V8Engine> vEightCar = lada;
            ICar<Engine> someCar = lada;
        }
    }
}

