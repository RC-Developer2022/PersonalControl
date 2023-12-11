using Controle.Domain.Entities;

namespace Controle.Application.DTO;

public class PersonDTO
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public DateTime BirthDay { get; set; }
    public Guid SalaryId { get; set; }
    public Salary? Salary { get; set; }
}
