namespace AGD.SharedModels
{
  public class ValueModel
  {

  //  public ValueModel(string httpResponseMessage)
  //  {
      
  //    //var converter = new JsonConverter<ValueModel>();
  //     var model = JsonConvert.DeserializeObject<ValueModel>(httpResponseMessage);
  //    Response = model.Response;

  //  }

    public string Value { get; set; }
    public string Response { get; set; }
  }
}
