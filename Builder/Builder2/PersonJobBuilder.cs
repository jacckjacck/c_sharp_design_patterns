namespace Builder2
{
    internal class PersonJobBuilder<T> : PersonInfoBuilder<PersonJobBuilder<T>>
        where T : PersonJobBuilder<T>
    {
        public T WorkAsA(string position)
        {
            person.Position = position;
            return (T) this;
        }
    }
}
