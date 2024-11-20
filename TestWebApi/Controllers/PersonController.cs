using Microsoft.AspNetCore.Mvc;
using TestWebApi.Models;
using TestWebApi.Repository;

namespace TestWebApi.Controllers;

[Route("api/person")]
[ApiController]
public class PersonController : ControllerBase
{
    private readonly IPersonRepository _personRepository;

    public PersonController(IPersonRepository personRepository)
    {
        _personRepository = personRepository;
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> AddPerson([FromBody] Person person)
    {
        try
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _personRepository.AddPersonAsync(person);
            return StatusCode(StatusCodes.Status201Created, "Person added successfully.");
        }
        catch (Exception)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, "Server error.");
        }
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> GetPersons()
    {
        try
        {
            var persons = await _personRepository.GetPersonsAsync();

            return Ok(persons);
        }
        catch (Exception)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, "Server Error");
        }
    }
}
