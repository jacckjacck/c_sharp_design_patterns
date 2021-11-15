namespace Builder3
{
    internal interface ISpecifyCarType
    {
        ISpecifyWheelSize OfType(CarType carType);
    }
}
