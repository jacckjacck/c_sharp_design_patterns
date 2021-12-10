using System;
using static System.Console;

namespace Prototype
{
	class Program
	{
		static void Main(string[] args)
		{
			var john = new Person(new string[] { "John", "Doe" }, new Address("London Street", 123));
			//var jane = john;
			//jane.Names[0] = " Jane";
			var jane = (Person)john.Clone();
			jane.Names[0] = "Jane";
			jane.Address.HouseNumber = 321;

			WriteLine(john);
			WriteLine(jane);
		}
	}
}
