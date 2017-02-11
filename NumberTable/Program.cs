using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 1;

            for (int col = 1; col <= n; col++)
            {
                count = col;
                for (int row = 0; row < n; row++)
                {
                    if (count <= n) Console.Write(row + col);
                    else Console.Write(2 * n - (row + col));
                    Console.Write(" ");
                    count++;
                }
                Console.WriteLine();
            }
        }
    }
}
