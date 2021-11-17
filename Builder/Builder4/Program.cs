// See https://aka.ms/new-console-template for more information
using System;

namespace Builder4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, World!");
            var person = new PersonBuilder()
                .Called("John")
                .WorkAs("Policeman")
                .Build();
        }
    }
}
