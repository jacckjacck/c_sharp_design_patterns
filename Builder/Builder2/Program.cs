// See https://aka.ms/new-console-template for more information
using Builder2;

Console.WriteLine("Hello, World!");

var me = Person.New.Called("Jorge").WorkAsA("Developer").Build();

Console.WriteLine(me);
