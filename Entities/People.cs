using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

[Table("peoples")]
[Index(nameof(Nickname), IsUnique = true)]
public class People : IPeople
{
  [Column("id")]
  public Guid Id { get; set; }
  [Column("name")]
  public string Name { get; set; }
  [Column("nickname")]

  public string Nickname { get; set; }
  [Column("birth")]
  public DateTime Birth { get; set; }
  [Column("stack")]
  public List<string> Stack { get; set; } = new List<string>();
  [Column("search")]
  public string Search { get; set; } = "";

  public People() { }
  public People(string name, string nickname, string birth)
  {
    Id = Guid.NewGuid();
    Name = name;
    Nickname = nickname;
    Birth = DateTime.Parse(birth).ToUniversalTime();
  }

  public bool isValid()
  {
    if (string.IsNullOrEmpty(Name)) throw new ArgumentNullException("name");
    if (string.IsNullOrEmpty(Nickname)) throw new ArgumentNullException("nickname");
    if (Birth.Equals(null)) throw new ArgumentNullException("birth");
    if (Name.Length > 100) throw new ArgumentOutOfRangeException("name,100");
    if (Nickname.Length > 32) throw new ArgumentOutOfRangeException("nickname,32");
    return true;
  }

  override public string ToString()
  {
    return $"ID: {Id}, Name: {Name}, Nickname: {Nickname}, Birth: {Birth}, Stack: {string.Join(",", Stack)}";
  }

}