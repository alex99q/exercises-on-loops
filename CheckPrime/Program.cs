using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool test = true;

            if (n < 2)
            {
                Console.WriteLine("Not Prime");
            }
            else
            {
                for (int i = 2; i <= Math.Round(Math.Sqrt(n), 0); i++)
                {
                    if (n % i == 0)
                    {
                        Console.WriteLine("Not Prime");
                        test = false;
                        break;
                    }
                }
                if (test == true) Console.WriteLine("Prime");
            }

        }
    }
}
