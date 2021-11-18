
namespace Factory
{
	internal class Point
	{
		private double x, y;

		// Factory Method
		

		public Point(double x, double y)
		{
			this.x = x;
			this.y = y;
		}

		public override string ToString()
		{
			return $"{nameof(x)} : {x}, {nameof(y)} : {y }";
		}
	}
}
