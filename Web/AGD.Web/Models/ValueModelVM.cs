using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using AGD.SharedModels;
using Newtonsoft.Json;

namespace AGD.Web.Models
{
  public class ValueModelVM
  {

    public ValueModelVM(string httpResponseMessage)
    {
      
      //var converter = new JsonConverter<ValueModelVM>();
       var model = JsonConvert.DeserializeObject<ValueModel>(httpResponseMessage);
      Response = model.Response;

    }

    public string Value { get; set; }
    public string Response { get; set; }
  }
}
