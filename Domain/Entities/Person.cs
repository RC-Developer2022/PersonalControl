namespace Controle.Domain.Entities;

public class Person : EntityBase
{
    public string Name { get; set; }
    public int Age { get; set; }
    public DateTime BirthDay { get; set; }
    public Guid SalaryId { get; set; }
    public Salary? Salary { get; set; }

    public Person() { }

    public Person(string name, int age, DateTime birthDay)
    {
        Name = name;
        Age = age;
        BirthDay = birthDay;
    }

}
