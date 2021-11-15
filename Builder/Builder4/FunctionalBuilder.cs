namespace Builder4
{
    internal abstract class FunctionalBuilder<TSubject,T>
        where T : FunctionalBuilder<TSubject, T>
        where TSubject: new()
    {
        private readonly List<Func<Person, Person>> actions = new();

        public T Called(string name) => Do(p => p.Name = name);

        public T Do(Action<Person> action) => AddAction(action);

        public Person Build() => actions.Aggregate(new Person(), (p, f) => f(p));


        private T AddAction(Action<Person> action)
        {
            actions.Add(p =>
            {
                action(p);
                return p;
            });

            return (T) this;
        }
    }
}
