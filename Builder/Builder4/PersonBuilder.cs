namespace Builder4
{
    internal sealed class PersonBuilder: FunctionalBuilder<Person, PersonBuilder>
    {
        public PersonBuilder Called(string name) => Do(p => p.Name = name);
    }
}
