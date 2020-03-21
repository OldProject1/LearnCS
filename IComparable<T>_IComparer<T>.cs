using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.IO;

namespace SandBox
{
    enum Company { Audi, BMW, Mercedes, Tesla, Porsche, VW }
    class Car : IComparable<Car>
    {
        public Company Company { get; set; }
        public int Price { get; set; }
        public int CompareTo(Car other)
        {
            return Price.CompareTo(other.Price);
        }
        public override string ToString()
        {
            return $"{Price} - {Company}";
        }
    }
    class CarComparer : IComparer<Car>
    {
        public int Compare(Car one, Car two)
        {
            return one.Company.ToString().Length - two.Company.ToString().Length;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car[] cars = new Car[] {
                new Car { Price = 29000, Company = Company.BMW },
                new Car { Price = 19000, Company = Company.Audi },
                new Car { Price = 30000, Company = Company.Tesla },
                new Car { Price = 70000, Company = Company.Porsche },
                new Car { Price = 15000, Company = Company.VW },
            };
            Array.Sort(cars);//by price
            foreach (Car car in cars) { Console.WriteLine(car); }
            Array.Sort(cars, new CarComparer());//by company name
            foreach (Car car in cars) { Console.WriteLine(car); }
            cars = (from car in cars orderby car.Price select car).ToArray(); //again by price
            foreach (Car car in cars) { Console.WriteLine(car); }

        }
    }
}
