using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;
using AGD.SharedModels;
using Microsoft.AspNetCore.Mvc;

namespace AGD.ApiGateway.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ValuesController : ControllerBase
  {
    // GET api/values
    [HttpGet]
    public ActionResult<IEnumerable<string>> Get()
    {
      return new string[] { "value1", "value2" };
    }

    // GET api/values/5
    [HttpGet("{id}")]
    public ActionResult<string> Get(int id)
    {
      return "value";
    }

    // POST api/values
    [HttpPost]
    public async Task<ValueModel> Post([FromBody] ValueModel value)
    {
      var client = new ServiceReference1.Service1Client();
      var channel = client.ChannelFactory.CreateChannel(new EndpointAddress("http://localhost:17715/"));
     var valuestring =  await channel.GetDataAsync(value.Value);
      value.Response = valuestring;
      return value;
    }

    // PUT api/values/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/values/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
  }
}
