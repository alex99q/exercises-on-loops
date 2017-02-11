using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenPowersOf2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double num = 1;

            //for (int i = 0; i < n; i += 2)
            //{
            //    num = Math.Pow(2, i);
            //    Console.WriteLine(num);
            //}

            for (int i = 0; i <= n; i += 2)
            {
                Console.WriteLine(num);
                num *= 4;
            }
        }
    }
}
