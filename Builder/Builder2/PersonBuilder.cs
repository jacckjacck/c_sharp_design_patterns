namespace Builder2
{
    internal abstract class PersonBuilder
    {
        protected Person person = new();

        public Person Build() { return person; }

    }
}
