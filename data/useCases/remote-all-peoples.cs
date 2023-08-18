using Microsoft.AspNetCore.Mvc;

public class AllPeoples : IAllPeoples
{
  private IRepository _repository;
  public AllPeoples(IRepository repository)
  {
    _repository = repository;
  }
  public IEnumerable<People> get(string searchParam = "")
  {
    if (searchParam != "") return _repository.Search(searchParam);
    return _repository.GetAll();
  }
}