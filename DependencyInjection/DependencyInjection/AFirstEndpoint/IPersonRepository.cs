namespace AFirstEndpoint
{
    public interface IPersonRepository
    {
        IEnumerable<Person> GetPersons();
    }
}