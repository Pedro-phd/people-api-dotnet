using Microsoft.AspNetCore.Mvc;

public interface INewPeople
{
  public string create(PeopleRequest pr);
}