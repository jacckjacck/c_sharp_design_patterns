using System.Threading.Tasks;

namespace Factory2
{
	class Foo
	{
		private Foo()
		{

		}

		public static Task<Foo> CreateAsync()
		{
			var result = new Foo();
			return result.InitAsync();
		}

		private async Task<Foo> InitAsync() {
			await Task.Delay(1000);
			return this;
		}
	}
}
