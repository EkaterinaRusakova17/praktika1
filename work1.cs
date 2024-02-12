using System;

namespace PowerCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, n;

            Console.WriteLine("Введите число a:");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите степень n:");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{a}^{n} = {Power(a, n)}");
        }

        static int Power(int a, int n)
        {
            int result = 1;
            for (int index = 0; index < n; ++index)
            {
                result *= a;
            }

            return result;
        }
    }
}
