public class PeopleRequest
{
  public string Name { get; set; } = "";
  public string Nickname { get; set; } = "";
  public string Birth { get; set; } = "";
  public List<string> Stack { get; set; } = new List<string>();
}