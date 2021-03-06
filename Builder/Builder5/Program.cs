// See https://aka.ms/new-console-template for more information
using static System.Console;

namespace Builder5
{
    class Program
    {
        static void Main(string[] args)
        {

            WriteLine("Hello, World!");

            var personBuilder = new PersonBuilder();

            Person person = personBuilder
                .Lives
                    .At("Calle 109 #70-37")
                    .InCity("Medellin, Colombia")
                    .WithPostCode("000000")
                .Works
                    .At("Globant")
                    .AsA("Engineer")
                    .Earning(12000000);

            WriteLine(person);
        }
    }
}
