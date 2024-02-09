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

            char[] xArray = xString.ToCharArray();

            char temp = xArray[1];
            xArray[1] = xArray[xArray.Length - 1]; 
            xArray[xArray.Length - 1] = temp;

            string nString = new string(xArray);
            int n = Convert.ToInt32(nString);

            Console.WriteLine("Число n: " + n);
        }
    }
}
