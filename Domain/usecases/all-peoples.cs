using Microsoft.AspNetCore.Mvc;

public interface IAllPeoples
{
  public IEnumerable<People> get(string searchParam);
}