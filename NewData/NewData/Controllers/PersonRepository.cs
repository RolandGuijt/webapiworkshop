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

        public PersonDto AddPerson(PersonDto person)
        {
            var newEntity = new Person { Name = person.Name, City= person.City };
            _Context.Persons.Add(newEntity);
            _Context.SaveChanges();
            person.Id = newEntity.Id;
            return person;
        }

        public PersonDto GetPerson(int Id)
        {
            var person = _Context.Persons.SingleOrDefault(p => p.Id == Id);
            if (person is null)
                return null;
            return new PersonDto { 
                Id = person.Id,
                Name = person.Name,
                City= person.City 
            };
        }

        public IEnumerable<PersonDto> GetPersons()
        {
            return _Context.Persons.Select(p => 
                new PersonDto { Id = p.Id, Name = p.Name, City = p.City });
        }
    }
}
