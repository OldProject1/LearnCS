using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;


namespace SandBox
{
    class Engine { }

    class V8Engine : Engine { }

    interface ICar<out T>
    {
        T GetEngine();
    }

    class Lada<T> : ICar<T> where T : Engine, new()
    {
        public T GetEngine()
        {
            return new T();
        }
    }

    class MyClass
    {
        static void Main(string[] args)
        {
            ICar<Engine> lada = new Lada<V8Engine>();
            //ICar<V8Engine> vEightCar = lada; //error

        }
    }
}

