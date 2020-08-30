using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UdemyNLayerProject.Core.Models;
using UdemyNLayerProject.Core.Service;

namespace UdemyNLayerProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private readonly IService<Person> _personService;

        public PeopleController(IService<Person> personService)
        {
            _personService = personService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var people = await _personService.GetAllAsync();
            return Ok(people); // because of its an example, no dto used
        }

        [HttpPost]
        public async Task<IActionResult> Save(Person person)
        {
            var newPerson = await _personService.AddAsync(person);
            return Created(string.Empty, newPerson); // because of its an example, no dto used
        }
    }
}
