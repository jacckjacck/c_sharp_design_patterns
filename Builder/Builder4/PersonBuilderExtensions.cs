namespace Builder4
{
    internal static class PersonBuilderExtensions
    {
        public static PersonBuilder WorkAs(this PersonBuilder builder, string position) =>
            builder.Do(p => p.Position = position);
    }
}
