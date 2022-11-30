using AFirstEndpoint.Dtos;

namespace AFirstEndpoint
{
    public interface IPersonRepository
    {
        IEnumerable<PersonDto> GetPersons();
        PersonDto GetPerson(int Id);
    }
}