using Controle.Core.BaseEntities;

namespace Controle.Domain.Entities;

public class Investments  : EntityBase
{
    public string InvestName { get; set; }
    public string InstitutionName { get; set; }
    public Decimal InvestValue { get; set; }

    public Investments() {}

    public Investments(string investName, string institutionName, Decimal investValue)
    {   
        InvestName = investName;
        InstitutionName = institutionName;
        InvestValue = investValue; 
    }

}
