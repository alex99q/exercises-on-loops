using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int ten = 0;
            int result = 0;

            while (num != 0)
            {
                ten = num % 10;
                result = result + ten;
                num /= 10;
            }

            Console.WriteLine(result);
        }
    }
}
