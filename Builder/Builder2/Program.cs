// See https://aka.ms/new-console-template for more information


using System;

namespace Builder2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var me = Person.New.Called("Jorge").WorkAsA("Developer").Build();

            Console.WriteLine(me);

        }
    }
}