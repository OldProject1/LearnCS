using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace SandBox
{
    class MyClass
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            int[,][] resArr = new int[t,2][];
            for (int i = 0; i < t; i++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                resArr[i, 0] = Console.ReadLine().Split(' ').Select(item => Convert.ToInt32(item)).OrderBy(item => item).ToArray();
                resArr[i, 1] = Console.ReadLine().Split(' ').Select(item => Convert.ToInt32(item)).OrderBy(item => item).ToArray(); ;
            }
            for (int i = 0; i < t; i++)
            {
                foreach (var rowElem in resArr[i, 0]) { Console.Write(rowElem + " "); }
                Console.WriteLine();
                foreach (var rowElem in resArr[i, 1]) { Console.Write(rowElem + " "); }
                Console.WriteLine();
            }
        }
    }
}
