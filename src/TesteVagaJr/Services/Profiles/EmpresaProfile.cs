using AutoMapper;
using TesteVagaJr.Domain.Dtos;
using TesteVagaJr.Domain.Entities;

namespace TesteVagaJr.Services.Profiles;

public class EmpresaProfile : Profile
{
    public EmpresaProfile()
    {
        CreateMap<Empresa, EmpresaDto>().ReverseMap();
        CreateMap<Fornecedor, FornecedorDto>().ReverseMap();
    }
}