using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterEvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;

            while (true)
            {
                try
                {
                    Console.Write("Enter even number: ");
                    n = int.Parse(Console.ReadLine());
                    if (n % 2 == 0)
                    {
                        Console.WriteLine(n);
                        break;
                    }
                    else Console.WriteLine("The number is not even.");   
                }
                catch(System.FormatException)
                {
                    Console.WriteLine("Invalid number!");
                }
                catch (System.OverflowException)
                {
                    Console.WriteLine("The number is too long!");
                }
            }
        }
    }
}
