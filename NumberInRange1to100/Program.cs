using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberInRange1to100
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;

            while(true)
            {
                n = int.Parse(Console.ReadLine());
                if(n < 1 || n > 100) Console.WriteLine("Invalid number!");
                else
                {
                    Console.WriteLine($"The number is: {n}");
                    break;
                }
            }

        }
    }
}
