using System.Globalization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("[Controller]")]
public class PeopleController : ControllerBase
{
  private DataBaseContext _dateService;
  private INewPeople _newPeople;
  private IAllPeoples _allPeoples;
  private IGetByIdPeople _getByIdPeople;
  private IRepository _repository;

  public PeopleController(
    DataBaseContext dateService,
    INewPeople newPeople,
    IAllPeoples allPeoples,
    IGetByIdPeople getByIdPeople,
    IRepository repository
    )
  {
    _dateService = dateService;
    _newPeople = newPeople;
    _allPeoples = allPeoples;
    _getByIdPeople = getByIdPeople;
    _repository = repository;
  }

  [HttpGet("/peoples")]
  public IActionResult GetPeople(string t = "")
  {
    return Ok(_allPeoples.get(t));
  }
  [HttpGet("/people/{id}")]
  public IActionResult GetById(string id)
  {
    return Ok(_getByIdPeople.GetById(Guid.Parse(id)));
  }
  [HttpPost("/people")]
  public IActionResult NewPeople([FromBody] PeopleRequest req)
  {
    try
    {
      var result = _newPeople.create(req);
      return Ok(result);
    }
    catch (System.Exception)
    {
      return BadRequest();
    }
  }

}