public class GetByIdPeople : IGetByIdPeople
{
  private IRepository _repository;
  public GetByIdPeople(IRepository repository)
  {
    _repository = repository;
  }

  public People GetById(Guid id)
  {
    return _repository.GetById(id);
  }

}