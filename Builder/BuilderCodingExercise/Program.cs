// See https://aka.ms/new-console-template for more information
using static System.Console;

namespace BuilderCodingExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            WriteLine("Hello, World!");

            var cb = new CodeBuilder("Person")
                .AddField("Name", "string")
                .AddField("Age", "int");

            WriteLine(cb);
        }
    }
}

