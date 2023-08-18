public class Repository : IRepository
{

  private DataBaseContext _connection;

  public Repository(DataBaseContext connection)
  {
    _connection = connection;
  }


  public People GetById(Guid id)
  {
    return _connection.Peoples.Where(p => p.Id == id).First();
  }

  public IEnumerable<People> Search(string param)
  {
    return _connection.Peoples.Where(p => p.Search.ToLower().Contains(param.ToLower())).ToList();
  }

  public IEnumerable<People> GetAll()
  {
    return _connection.Peoples.ToList();
  }

  public People Create(PeopleRequest pr)
  {
    People p = new People(pr.Name, pr.Nickname, pr.Birth);
    if (pr.Stack != null) p.Stack = pr.Stack;
    try
    {
      p.isValid();
      _connection.Peoples.Add(p);
      _connection.SaveChanges();
    }
    catch (System.Exception)
    {
      throw new Exception();
    }
    return p;
  }

}