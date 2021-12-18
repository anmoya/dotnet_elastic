using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nest;

namespace WebApplication.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IElasticClient _elastic;

        public UserController(IElasticClient elastic)
        {
            _elastic = elastic;
        }

        [HttpGet]
        public async Task<User> Get(string id)
        {
            var response = await _elastic.SearchAsync<User>(s =>
                s.Query(q
                    => q.Term(t => t.Name, id) ||
                       q.Match(m => 
                           m.Field(f => f.Name)
                           .Query(id))));


            return response?.Documents?.FirstOrDefault();
        }

        [HttpPost]
        public void Post([FromBody] User value)
        {
            
        }
        
    }
}