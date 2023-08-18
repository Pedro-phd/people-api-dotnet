using Microsoft.AspNetCore.Mvc;
public class NewPeople : ControllerBase, INewPeople
{
  private IRepository _repository;
  public NewPeople(IRepository repository)
  {
    _repository = repository;
  }
  public string create(PeopleRequest pr)
  {
    try
    {
      var response = _repository.Create(pr);
      return response.ToString();
    }
    catch (System.Exception)
    {
      throw new Exception();
    }
  }
}