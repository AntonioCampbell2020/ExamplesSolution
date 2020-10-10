using System;

namespace CalculatorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            float x;
            float y;
            Console.WriteLine("digite o primeiro numero:");
            x = float.Parse(Console.ReadLine());
            Console.WriteLine("digite o segundo numero:");
            y = float.Parse(Console.ReadLine());
            Console.WriteLine(x+y);

        }
    }
}
