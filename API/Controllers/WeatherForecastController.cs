using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Persistence;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly DataContext _Context;
        public WeatherForecastController(DataContext Context)
        {
            _Context = Context;
        }
       [HttpGet]
       public async Task<ActionResult<IEnumerable<Value>>> Get()
       {
           var Value =await _Context.Values.ToListAsync();
           return Ok(Value);
       }
       [HttpGet("{id}")]
       public async Task<ActionResult<Value>> Get(int id)
       {
           var Value =await _Context.Values.FindAsync(id);
           return Ok(Value);

       }


    }
}
