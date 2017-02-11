using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int CurrentNumber = 0;
            int counter = 1;

            while (true)
            {
                for (int i = 0; i < counter; i++)
                {
                    CurrentNumber++;
                    Console.Write(CurrentNumber);
                    Console.Write(" ");
                    if (CurrentNumber == n) return;
                }
                if (CurrentNumber == n) return;
                Console.WriteLine();
                counter++;
            }
        }
    }
}
