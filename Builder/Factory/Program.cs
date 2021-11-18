using System;
using static System.Console;

namespace Factory
{
	class Program
	{
		static void Main(string[] args)
		{
			var point = Point.NewPolarPoint(1.0, Math.PI/2);

			WriteLine(point);
		}
	}
}
