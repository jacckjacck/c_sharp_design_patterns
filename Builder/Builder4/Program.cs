// See https://aka.ms/new-console-template for more information
using Builder4;

Console.WriteLine("Hello, World!");
var person = new PersonBuilder()
    .Called("John")
    .WorkAs("Policeman")
    .Build();
