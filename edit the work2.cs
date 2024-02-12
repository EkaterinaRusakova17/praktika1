using System;

namespace work2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число x:");
            int x = Convert.ToInt32(Console.ReadLine());

            string xString = x.ToString();

            xString = xString.Remove(1, 1) + xString[1];
            int n = Convert.ToInt32(xString);

            Console.WriteLine("Число n: " + n);
        }
    }
}
