// See https://aka.ms/new-console-template for more information
using Builder3;

Console.WriteLine("Hello, World!");

var car = CardBuilder.Create()
    .OfType(CarType.Crossover)
    .WithWheels(18)
    .Build();
