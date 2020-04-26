using System;

namespace OOP_lab_2_15_2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (double x = -6; x <= 3; x += 0.75)
            {
                double y = Math.Pow(x, 4) - 12 * x + Math.Exp(x);

                Console.WriteLine("x = {0:f2} y = {1:f4}", x, y);
            }
        }
    }
}
