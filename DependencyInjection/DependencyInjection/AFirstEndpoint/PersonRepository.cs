namespace AFirstEndpoint
{
    public class PersonRepository : IPersonRepository
    {
        public IEnumerable<Person> GetPersons()
        {
            return new Person[] {
                new Person { Id = 1, Name = "Alice", City = "Amsterdam" },
                new Person { Id = 2, Name = "John", City = "London" }
            };
        }
    }
}
