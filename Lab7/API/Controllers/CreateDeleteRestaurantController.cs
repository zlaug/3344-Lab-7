using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;
using Classes;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreateDeleteRestaurantController : ControllerBase
    {
        // GET: api/CreateDeleteRestaurant
        [HttpGet]
        public List<Restaurant> Get()
        {
            //return new string[] { "value1", "value2" };
        }

        // GET: api/CreateDeleteRestaurant/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/CreateDeleteRestaurant
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/CreateDeleteRestaurant/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
