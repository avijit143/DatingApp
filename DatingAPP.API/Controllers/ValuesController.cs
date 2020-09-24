using System.Linq;
using DatingApp.API.Data;
using Microsoft.AspNetCore.Mvc;

namespace DatingApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly DataContext _context;
        public ValuesController(DataContext context)
        {
            this._context = context;

        }
        [HttpGet]
        //api/values
        public IActionResult Get()
        {
            var values = _context.Values.ToList();
            return Ok(values);
        }

        [HttpGet("{id}")]
        //api/values/id

        public IActionResult Get(int id)
        {
            var value = _context.Values.FirstOrDefault(x => x.Id == id);
            return Ok(value);
        }
    }
}