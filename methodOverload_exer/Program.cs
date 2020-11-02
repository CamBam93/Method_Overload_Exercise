using System;

namespace methodOverload_exer
{
    class Program
    {
        static void Add(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine($"{sum}");

        }

        static void Add(double a, double b)
        {
            double sum = a + b;
            Console.WriteLine($"{sum}");

        }

        static void Add(int a, int b, bool singular)
        {
            if (singular == true)
            {
                if (a + b == 1)
                {
                    Console.WriteLine($"{a + b} dollar");
                }
                else
                {
                    Console.WriteLine($"{a + b} dollars");
                }
            }

        
        }
        static void Main(string[] args)
        {
            Add(8, 5);
            Add(10.2, 3.5);
            Add(0, 1, true);
        }
    }
}
