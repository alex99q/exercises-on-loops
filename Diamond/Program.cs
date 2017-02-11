using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int LeftRight = (n - 1) / 2;
            int mid = 0;

            if (n % 2 == 1)
            {
                for (int i = 0; i < n; i++)
                {
                    if(i < n / 2)
                    {
                        mid = n - 2 * LeftRight - 2;

                        Console.Write(new string('-', LeftRight));
                        Console.Write("*");
                        if (mid >= 0) Console.Write(new string('-', mid));
                        if (mid >= 0) Console.Write("*");
                        Console.WriteLine(new string('-', LeftRight));

                        LeftRight -= 1;
                    }
                    else if (i >= n / 2)
                    {
                        mid = n - 2 * LeftRight - 2;

                        Console.Write(new string('-', Math.Abs(LeftRight)));
                        Console.Write("*");
                        if (mid >= 0) Console.Write(new string('-', mid));
                        if (mid >= 0) Console.Write("*");
                        Console.WriteLine(new string('-', Math.Abs(LeftRight)));

                        LeftRight += 1;
                    }
                }
            }

            if (n % 2 == 0)
            {
                for (int i = 0; i < n - 1; i++)
                {
                    if (i < n / 2)
                    {
                        mid = n - 2 * LeftRight - 2;

                        Console.Write(new string('-', LeftRight));
                        Console.Write("*");
                        if (mid >= 0) Console.Write(new string('-', mid));
                        Console.Write("*");
                        Console.WriteLine(new string('-', LeftRight));

                        LeftRight -= 1;
                    }
                    else if (i == n / 2)
                    {
                        LeftRight = 1;
                        mid = n - 2 * LeftRight - 2;

                        Console.Write(new string('-', Math.Abs(LeftRight)));
                        Console.Write("*");
                        if (mid >= 0) Console.Write(new string('-', mid));
                        Console.Write("*");
                        Console.WriteLine(new string('-', Math.Abs(LeftRight)));

                        LeftRight += 1;
                    }
                    else
                    {
                        mid = n - 2 * LeftRight - 2;

                        Console.Write(new string('-', Math.Abs(LeftRight)));
                        Console.Write("*");
                        if (mid >= 0) Console.Write(new string('-', mid));
                        Console.Write("*");
                        Console.WriteLine(new string('-', Math.Abs(LeftRight)));

                        LeftRight += 1;
                    }
                }
            }

        }
    }
}
