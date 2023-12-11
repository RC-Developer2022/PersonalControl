using AutoMapper;
using Controle.Application.DTO;
using Controle.Domain.Entities;

namespace Controle.Application;

public class AutoMapper : Profile
{
    public AutoMapper()
    {
        CreateMap<Person, PersonDTO>().ReverseMap();
        CreateMap<Salary , SalaryDTO>().ReverseMap();
        CreateMap<Investments , InvestmentsDTO>().ReverseMap();
        CreateMap<FixedExpenses, FixedExpensesDTO>().ReverseMap();
    }
}
