using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.IO;

namespace SandBox
{

    class Car : ICloneable
    {
        public string Model { get; set; }
        public string Company { get; set; }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car { Model = "X", Company = "Tesla"};
            Car myFriendCar = (Car) myCar.Clone();
        }
    }
}
