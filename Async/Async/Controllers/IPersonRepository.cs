using AFirstEndpoint.Dtos;

namespace AFirstEndpoint
{
    public interface IPersonRepository
    {
        Task<IEnumerable<PersonDto>> GetPersons();
        Task<PersonDto> GetPerson(int Id);
        Task<PersonDto> AddPerson(PersonDto person);
    }
}