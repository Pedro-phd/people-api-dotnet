public interface IRepository
{
  IEnumerable<People> GetAll();
  People GetById(Guid id);
  People Create(PeopleRequest people);
  IEnumerable<People> Search(string param);
}