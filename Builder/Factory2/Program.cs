using System;
using System.Threading.Tasks;

namespace Factory2
{
	class Program
	{
		static async Task Main(string[] args)
		{
			Foo x = await Foo.CreateAsync();
		}
	}
}
