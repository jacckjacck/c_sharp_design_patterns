namespace Builder3
{
    internal class CardBuilder
    {
        private class Impl : ISpecifyCarType, ISpecifyWheelSize, IBuildCar
        {
            private readonly Car car = new();

            public Car Build()
            {
                return car;
            }

            public ISpecifyWheelSize OfType(CarType carType)
            {
                car.CarType = carType;
                return this;
            }

            public IBuildCar WithWheels(int size)
            {
                switch (car.CarType)    
                {
                    case CarType.Crossover when size <17 || size > 20:
                    case CarType.Sedan when size <15 || size >17:
                        throw new ArgumentException($"Wrong size of wheel for {car.CarType}.");
                }

                car.WheelSize = size;
                return this;
            }
        }

        public static ISpecifyCarType Create()
        {
            return new Impl();
        }
    }
}
