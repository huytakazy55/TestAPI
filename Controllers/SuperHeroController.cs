using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SuperHeroAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        public async List<SuperHero> heroes = new List<SuperHero>
        {
            new SuperHero {
                Id = 1, 
                Name = "Spider Man", 
                FirstName = "Peter", 
                LastName = "Parker", 
                Place = "New York City" 
                }
            new SuperHero {
                Id = 1, 
                Name = "Iron Man", 
                FirstName = "Tony", 
                LastName = "Stark", 
                Place = "Long Island" 
                }
        };
        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> Get()
        {
            return Ok(heroes);
        }
        
    }
}