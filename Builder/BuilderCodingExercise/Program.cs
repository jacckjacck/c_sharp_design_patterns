// See https://aka.ms/new-console-template for more information
using BuilderCodingExercise;
using static System.Console;

WriteLine("Hello, World!");

var cb = new CodeBuilder("Person")
    .AddField("Name", "string")
    .AddField("Age", "int");

WriteLine(cb);

