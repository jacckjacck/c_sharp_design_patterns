namespace Builder2
{
    internal class PersonInfoBuilder<T> : PersonBuilder 
        where T: PersonInfoBuilder<T>
    {
        public T Called(string name)
        {
            person.Name = name;
            return (T) this;
        }
    }
}
