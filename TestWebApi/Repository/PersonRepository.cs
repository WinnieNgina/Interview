using Microsoft.EntityFrameworkCore;
using TestWebApi.DataContext;
using TestWebApi.Models;

namespace TestWebApi.Repository;

public class PersonRepository : IPersonRepository
{
    private readonly AppDbContext _context;
    public PersonRepository(AppDbContext context)
    {   
        _context = context;
    }
    public async Task AddPersonAsync(Person person)
    {
        var result = await _context.Persons.AddAsync(person);
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<Person>> GetPersonsAsync()
    {
        return await _context.Persons.ToListAsync();
    }
}
