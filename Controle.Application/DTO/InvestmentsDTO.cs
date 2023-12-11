namespace Controle.Application.DTO;

public class InvestmentsDTO
{
    public Guid Id { get; set; }
    public string InvestName { get; set; }
    public string InstitutionName { get; set; }
    public Decimal InvestValue { get; set; }
}
