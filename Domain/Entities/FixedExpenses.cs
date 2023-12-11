using Controle.Core.BaseEntities;

namespace Controle.Domain.Entities;

public class FixedExpenses : EntityBase
{
    public string NameExpenses { get; set; }
    public Decimal ValueExpenses { get; set; }

    public FixedExpenses(){}
    public FixedExpenses(string nameExpenses, Decimal valueExpenses)
    {
        NameExpenses = nameExpenses;
        ValueExpenses = valueExpenses;
    }
}
