using AutoMapper;
using TesteVagaJr.Domain.Entities;
using TesteVagaJr.Services.Dtos;

namespace TesteVagaJr.Services.Profiles;

public class EmpresaProfile : Profile
{
    public EmpresaProfile()
    {
        CreateMap<Empresa, EmpresaDto>().ReverseMap();
        CreateMap<Fornecedor, FornecedorDto>().ReverseMap();
    }
}