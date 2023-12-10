namespace Controle.Domain.Entities;

public class Salary : EntityBase
{
    public Decimal ValueSalary { get; set; }
    public int SavePorcentage { get; set; }
    
    public Salary(Decimal valueSalary , int savePorcentage)
    {
        ValueSalary = valueSalary;
        SavePorcentage = savePorcentage;
    }
}
