using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int row = 0;

            for (int i = 0; i < ((n + 1) / 2); i++)
            {
                if (n % 2 == 0 && i == 0)
                {
                    Console.Write(new string('-', (n / 2) - 1));
                    Console.Write(new string('*', 2));
                    Console.WriteLine(new string('-', (n / 2) - 1));
                    row += 2;
                }
                else if (n % 2 == 1 && i == 0)
                {
                    Console.Write(new string('-', (n - 1) / 2));
                    Console.Write(new string('*', 1));
                    Console.WriteLine(new string('-', (n - 1) / 2));
                    row += 1;
                }
                else if (i == (((n + 1) / 2)) - 1)
                {
                    Console.WriteLine(new string('*', row));
                }
                else
                {
                    Console.Write(new string('-', Convert.ToInt32((n - row) / 2)));
                    Console.Write(new string('*', row));
                    Console.WriteLine(new string('-', Convert.ToInt32((n - row) / 2)));
                }
                row += 2;
            }

            for (int j = 0; j < n / 2; j++)
            {
                Console.Write("|");
                Console.Write(new string('*', n - 2));
                Console.WriteLine("|");
            }
        }
    }
}
