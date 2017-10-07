using System;
using MyCalculator.Application.Services;

namespace MyCalculator.Host.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var calc = new MyCalculatorService();
            var nr1 = 3;
            var nr2 = 6;

            var sum = calc.Add(nr1, nr2);

            Console.WriteLine($"{nr1} + {nr2} = {sum}");

            Console.ReadKey();
        }
    }
}