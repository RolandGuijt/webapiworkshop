using AFirstEndpoint.Dtos;
using EntityFramework.Database;

namespace AFirstEndpoint
{
    public class PersonRepository : IPersonRepository
    {
        private readonly PersonDbContext _Context;

        public PersonRepository(PersonDbContext context)
        {
            _Context = context;
        }
        public IEnumerable<PersonDto> GetPersons()
        {
            return _Context.Persons.Select(p => 
                new PersonDto { Id = p.Id, Name = p.Name, City = p.City });
        }
    }
}
