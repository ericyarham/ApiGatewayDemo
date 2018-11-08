using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Threading.Tasks;
using AGD.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AGD.Web.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ValuesController : ControllerBase
  {
    // GET: api/Values
    [HttpGet]
    public IEnumerable<string> Get()
    {
      return new string[] { "value1", "value2" };
    }

    // GET: api/Values/5
    [HttpGet("{id}", Name = "Get")]
    public string Get(int id)
    {
      return "value";
    }

    // POST: api/Values
    [HttpPost]
    public async Task<ValueModelVM> Post([FromBody] ValueModelVM value)
    {
      var client = new HttpClient { BaseAddress = new Uri("https://localhost:44393/") };
   
      return new ValueModelVM(await (await client.PostAsync("api/Values", value, new JsonMediaTypeFormatter())).Content.ReadAsStringAsync());
    }

    // PUT: api/Values/5
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
