// See https://aka.ms/new-console-template for more information
using System;

namespace Builder3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var car = CardBuilder.Create()
                .OfType(CarType.Crossover)
                .WithWheels(18)
                .Build();

        }
    }
}