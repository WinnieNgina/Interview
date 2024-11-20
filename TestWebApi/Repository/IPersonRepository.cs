using TestWebApi.Models;

namespace TestWebApi.Repository;

public interface IPersonRepository
{
    Task AddPersonAsync(Person person);
    Task<IEnumerable<Person>> GetPersonsAsync();
}
